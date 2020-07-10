using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _LFP_Final_201801364
{
    class AnalizadorSintactico
    {
        List<Tokens> listaTokens = new List<Tokens>();
        int indice = 0;
        Tokens preAnalisis = null;
        Boolean errorSintactico = false;
        public AnalizadorSintactico(List<Tokens> listaTokens)
        {
            this.listaTokens = listaTokens;
            indice = 0;
            preAnalisis = listaTokens[indice];
            inicio();
            Parea(Tokens.Tipo.SIMBOLOACEPTACION);
        }
        private void inicio()
        {
            Lista();
        }
        private void Lista()
        {
            if (preAnalisis.tipo == Tokens.Tipo.var)
            {
                Declaracion();
                ListaP();
            }
            else if (preAnalisis.tipo == Tokens.Tipo.id)
            {
                Asignacion();
                ListaP();
            }
            else if (preAnalisis.tipo == Tokens.Tipo.print)
            {
                Imprimir();
                ListaP();
            }
            else if (preAnalisis.tipo == Tokens.Tipo.datos)
            {
                MostrarDatos();
                ListaP();
            }
        }
        private void ListaP()
        {
            if(preAnalisis.tipo == Tokens.Tipo.var)
            {
                Declaracion();
                ListaP();
            }else if (preAnalisis.tipo == Tokens.Tipo.id) 
            {
                Asignacion();
                ListaP();
            }else if(preAnalisis.tipo == Tokens.Tipo.print)
            {
                Imprimir();
                ListaP();
            }else if(preAnalisis.tipo == Tokens.Tipo.datos)
            {
                MostrarDatos();
                ListaP();
            }
            else
            {

            }
        }
        private void Declaracion()
        {
            if(preAnalisis.tipo == Tokens.Tipo.var)
            {
                Parea(Tokens.Tipo.var);
                if (preAnalisis.tipo == Tokens.Tipo.id)
                {
                    Parea(Tokens.Tipo.id);
                    if (preAnalisis.tipo == Tokens.Tipo.igual)
                    {
                        Parea(Tokens.Tipo.igual);
                        Expresion();
                        if (preAnalisis.tipo == Tokens.Tipo.punto_coma)
                        {
                            Parea(Tokens.Tipo.punto_coma);
                        }
                        else
                        {

                            Console.WriteLine("Error en la producion en Declaracion()" + "Decricipion:" + " " + preAnalisis.TipoToken.ToString() + "Lexema del token:" + " " + preAnalisis.lexema);
                        }
                    }
                    else
                    {

                        Console.WriteLine("Error en la producion en Declaracion()" + "Decricipion:" + " " + preAnalisis.TipoToken.ToString() + "Lexema del token:" + " " + preAnalisis.lexema);
                    }
                }
                else
                {

                    Console.WriteLine("Error en la producion en Declaracion()" + "Decricipion:" + " " + preAnalisis.TipoToken.ToString() + "Lexema del token:" + " " + preAnalisis.lexema);
                }
            }
            else
            {
                Console.WriteLine("Error en la producion en Declaracion()" + "Decricipion:" + " " + preAnalisis.TipoToken.ToString() + "Lexema del token:" + " " + preAnalisis.Lexema.ToString());
            }
        }
        private void Asignacion()
        {
            if(preAnalisis.tipo == Tokens.Tipo.id)
            {
                Parea(Tokens.Tipo.id);
                Parea(Tokens.Tipo.igual);
                Expresion();
                Parea(Tokens.Tipo.punto_coma);
            }
           
        }
        private void Imprimir()
        {
            if(preAnalisis.tipo == Tokens.Tipo.print)
            {
                Parea(Tokens.Tipo.print);
                Parea(Tokens.Tipo.parentesis_izquierdo);
                Expresion();
                Parea(Tokens.Tipo.parentesis_derecho);
                Parea(Tokens.Tipo.punto_coma);
            }
            else
            {
                Console.WriteLine("Error en la producion en Imprimir()" + "Decricipion:" + " " + preAnalisis.TipoToken.ToString() + "Lexema del token:" + " " + preAnalisis.Lexema);
            }
        }
        private void MostrarDatos()
        {
            if(preAnalisis.tipo == Tokens.Tipo.datos)
            {
                Parea(Tokens.Tipo.datos);
                if (preAnalisis.tipo == Tokens.Tipo.parentesis_izquierdo)
                {
                    Parea(Tokens.Tipo.parentesis_izquierdo);
                    if (preAnalisis.tipo == Tokens.Tipo.parentesis_derecho)
                    {
                        Parea(Tokens.Tipo.parentesis_derecho);
                        if (preAnalisis.tipo == Tokens.Tipo.punto_coma)
                        {
                            Parea(Tokens.Tipo.punto_coma);
                        }
                        else
                        {
                            Console.WriteLine("Error en la producion E()" + "Decricipion:" + " " + preAnalisis.TipoToken.ToString() + "Lexema del token:" + " " + preAnalisis.Lexema.ToString());
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error en la producion E()" + "Decricipion:" + " " + preAnalisis.TipoToken.ToString() + "Lexema del token:" + " " + preAnalisis.Lexema.ToString());
                    }
                }
                else
                {
                    Console.WriteLine("Error en la producion E()" + "Decricipion:" + " " + preAnalisis.TipoToken.ToString() + "Lexema del token:" + " " + preAnalisis.Lexema.ToString());

                }
            }
            else
            {
                Console.WriteLine("Error en la producion E()" + "Decricipion:" + " " + preAnalisis.TipoToken.ToString() + "Lexema del token:" + " " + preAnalisis.Lexema.ToString());
            }
        }
        private void Expresion()
        {
            E();
        }

        private void E()
        {
            T();
            EP();
        }

        private void EP()
        {
            if(preAnalisis.tipo == Tokens.Tipo.mas)
            {
                Parea(Tokens.Tipo.mas);
                T();
                EP();
            }else if(preAnalisis.tipo == Tokens.Tipo.menos)
            {
                Parea(Tokens.Tipo.menos);
                T();
                EP();
            }
            else
            {

            }
        }
        private void T()
        {
            F();
            TP();
        }
        private void TP()
        {
            if(preAnalisis.tipo == Tokens.Tipo.asterisco)
            {
                Parea(Tokens.Tipo.asterisco);
                F();
                TP();
            }else if(preAnalisis.tipo == Tokens.Tipo.diagonal)
            {
                Parea(Tokens.Tipo.diagonal);
                F();
                TP();
            }
            else
            {

            }
        }
        private void F()
        {
            if (preAnalisis.tipo == Tokens.Tipo.numeros)
            {
                Parea(Tokens.Tipo.numeros);
            } else if (preAnalisis.tipo == Tokens.Tipo.id)
            {
                Parea(Tokens.Tipo.id);
            } else if (preAnalisis.tipo == Tokens.Tipo.parentesis_izquierdo)
            {
                Parea(Tokens.Tipo.parentesis_izquierdo);
                E();
                Parea(Tokens.Tipo.parentesis_derecho);
            }
            else
            {
                Console.WriteLine("Error en la producion E()" + "Decricipion:"+" "+preAnalisis.TipoToken.ToString() +"Lexema del token:" +" " + preAnalisis.Lexema);
            }
        }
        private void Parea(Tokens.Tipo tipo)
        {
            if (errorSintactico)
            {
                if (indice < listaTokens.Count - 1)
                {
                    indice++;
                    preAnalisis = listaTokens[indice];
                    if (preAnalisis.tipo == Tokens.Tipo.punto_coma)
                    {
                        errorSintactico = false;
                    }
                }
            }
            else
            {
                
                    if (preAnalisis.tipo == tipo)
                   {
                    if (indice < listaTokens.Count - 1)
                    {
                        indice++;
                        preAnalisis = listaTokens[indice];
                    }
                }
                else
                {
                    Console.WriteLine("Error sintactico se esperaba[" + tipo.ToString() + "] en lugar de {" + preAnalisis.TipoToken + "," + "'" + preAnalisis.Lexema + "'" + "}");
                    errorSintactico = true;
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _LFP_Final_201801364
{
    class Interprete
    {
        List<Tokens> listaTokens = new List<Tokens>();
        List<Simbolo> tablaSimbolos = new List<Simbolo>();
        int indice = 0;
        Tokens preAnalisis = null;
        Boolean errorSintactico = false;
        public Interprete(List<Tokens> listaTokens)
        {
            this.listaTokens = listaTokens;
            indice = 0;
            preAnalisis = listaTokens[indice];
            inicio(true);
            Parea(Tokens.Tipo.SIMBOLOACEPTACION);
            
        }
       
        private void inicio(Boolean bandera)
        {
            Lista(bandera);
        }
        private void Lista(Boolean bandera)
        {
            if (preAnalisis.tipo == Tokens.Tipo.var)
            {
                Declaracion(bandera);
                ListaP(bandera);
            }
            else if (preAnalisis.tipo == Tokens.Tipo.id)
            {
                Asignacion(bandera);
                ListaP(bandera);
            }else if(preAnalisis.tipo == Tokens.Tipo.print)
            {
                Imprimir(bandera);
                ListaP(bandera);
            }else if(preAnalisis.tipo == Tokens.Tipo.datos)
            {
                MostrarDatos(bandera);
                ListaP(bandera);
            }
        }
        private void ListaP(Boolean bandera)
        {
            if (preAnalisis.tipo == Tokens.Tipo.var)
            {
                Declaracion(bandera);
                ListaP(bandera);
            }
            else if (preAnalisis.tipo == Tokens.Tipo.id)
            {
                Asignacion(bandera);
                ListaP(bandera);
            }else if(preAnalisis.tipo == Tokens.Tipo.print)
            {
                Imprimir(bandera);
                ListaP(bandera);

            }else if(preAnalisis.tipo == Tokens.Tipo.datos)
            {
                MostrarDatos(bandera);
                ListaP(bandera);
            }
            else
            {

            }
        }
        public Resultado ObtenerValor(string nombre)
        {
           
            foreach (var item in this.tablaSimbolos)
            {
                if (item.Nombre.Equals(nombre))
                {
                    
                    return item.valor;
                }
            }
            return new Resultado("Error", "");
        }
        private void Declaracion(Boolean bandera)
        {
            if (preAnalisis.tipo == Tokens.Tipo.var)
            {
             

                Parea(Tokens.Tipo.var);
                List<String> lista = new List<String>();
                lista.Add(preAnalisis.lexema);
                Parea(Tokens.Tipo.id);
                Parea(Tokens.Tipo.igual);

                Resultado resultado = Expresion();
                Parea(Tokens.Tipo.punto_coma);
                if (bandera)
                {
                    foreach (var item in lista)
                    {
                        
                        Simbolo simbolo = new Simbolo("var", Convert.ToString(item), resultado);
                        this.tablaSimbolos.Add(simbolo);
                       
                    }
                   
                }
            }
            
        }
        private void Asignacion(Boolean bandera)
        {
            if (preAnalisis.tipo == Tokens.Tipo.id)
            {
                string update = preAnalisis.lexema;
                Parea(Tokens.Tipo.id);
                Parea(Tokens.Tipo.igual);
                Resultado resultado  = Expresion();
                Parea(Tokens.Tipo.punto_coma);
                if (bandera)
                {
                    foreach (Simbolo item in this.tablaSimbolos)
                    {
                        if (item.Nombre.Equals(update))
                        {
                            item.valor = resultado;
                        }
                        
                    }
                }  
            }
            

        }
        private void Imprimir(Boolean bandera)
        {

            if (preAnalisis.tipo == Tokens.Tipo.print)
            {
                Parea(Tokens.Tipo.print);
                Parea(Tokens.Tipo.parentesis_izquierdo);
                Resultado valor = Expresion();

                Parea(Tokens.Tipo.parentesis_derecho);
                Parea(Tokens.Tipo.punto_coma);
                if (bandera)
                {
                    Console.WriteLine(">>" + " " + valor.Result);
                }

            } 
            
           
        }
        private Resultado Expresion()
        {
            return E();
        }

        private void MostrarDatos(Boolean bandera)
        {
            if (preAnalisis.tipo == Tokens.Tipo.datos)
            {
                Parea(Tokens.Tipo.datos);
                Parea(Tokens.Tipo.parentesis_izquierdo);
                Parea(Tokens.Tipo.parentesis_derecho);
                if (preAnalisis.tipo == Tokens.Tipo.punto_coma)
                {
                    Parea(Tokens.Tipo.punto_coma);
                    Console.WriteLine("Juan Daniel Enrique Roman Barrientos --------> 201801364");
                }
            }
           
        }
        private Resultado E()
        {
            Resultado operando1 = T();
            Resultado resultado = EP(operando1);
            return resultado;
        }

        private Resultado EP(Resultado Operando2)
        {
            if (preAnalisis.tipo == Tokens.Tipo.mas)
            {
                Parea(Tokens.Tipo.mas);
                Resultado operandoMasMenos = T();
                Resultado resultado = new Resultado("Error", "");
                switch (Operando2.getTipo)
                {
                    case "var":
                        switch (operandoMasMenos.getTipo)
                        {
                            case "var":
                                int valor1 = Int32.Parse(Operando2.Result);
                                int valor2 = Int32.Parse(operandoMasMenos.Result);
                                resultado = new Resultado("var", Convert.ToString(valor1 + valor2));
                                break;
                        }
                        break;

                }
                return EP(resultado);
            }
            else if (preAnalisis.tipo == Tokens.Tipo.menos)
            {
                Parea(Tokens.Tipo.menos);
                Resultado operandoMasMenos = T();
                Resultado resultado = new Resultado("Error", "");
                switch (Operando2.getTipo)
                {
                    case "var":
                        switch (operandoMasMenos.getTipo)
                        {
                            case "var":
                                int valor1 = Int32.Parse(Operando2.Result);
                                int valor2 = Int32.Parse(operandoMasMenos.Result);
                                resultado = new Resultado("var", Convert.ToString(valor1 - valor2));
                                break;
                        }
                        break;

                }
                return EP(resultado);
            }
            else
            {
                return Operando2;
            }
          
        }
        private Resultado T()
        { 
            Resultado operando1 = F();
            Resultado resultado = TP(operando1);
            return resultado;
        }
        private Resultado TP(Resultado Operando1)
        {
            if (preAnalisis.tipo == Tokens.Tipo.asterisco)
            {
                Parea(Tokens.Tipo.asterisco);
                Resultado operandoPorDiv = F();
                Resultado resultado = new Resultado("Error", "");
                switch (Operando1.getTipo)
                {
                    case "var":
                        switch (operandoPorDiv.getTipo)
                        {
                            case "var":
                                int valor1 = Int32.Parse(Operando1.Result);
                                int valor2 = Int32.Parse(operandoPorDiv.Result);
                                resultado = new Resultado("var", Convert.ToString(valor1*valor2));
                            break;
                        }
                        break;
                    
                }

                return TP(resultado);
            }
            else if (preAnalisis.tipo == Tokens.Tipo.diagonal)
            {
                Parea(Tokens.Tipo.diagonal);
                Resultado operandoPorDiv = F();
                Resultado resultado = new Resultado("Error", "");
                switch (Operando1.getTipo)
                {
                    case "var":
                        switch (operandoPorDiv.getTipo)
                        {
                            case "var":
                                int valor1 = Int32.Parse(Operando1.Result);
                                int valor2 = Int32.Parse(operandoPorDiv.Result);
                                resultado = new Resultado("var", Convert.ToString(valor1 / valor2));
                                break;
                        }
                        break; 
                }
                return TP(resultado);
            }
            else
            {
                return Operando1;
            }
        }
        private Resultado F()
        {
            if(preAnalisis.tipo == Tokens.Tipo.numeros)
            {
                
                Resultado temp = new Resultado("var", preAnalisis.lexema);
                Parea(Tokens.Tipo.numeros);
                return temp;

            }else if(preAnalisis.tipo == Tokens.Tipo.id)
            {
                Resultado valor = ObtenerValor(preAnalisis.lexema);
                Parea(Tokens.Tipo.id);
                return valor;
            }else if(preAnalisis.tipo == Tokens.Tipo.parentesis_izquierdo)
            {
                Parea(Tokens.Tipo.parentesis_izquierdo);
                Resultado operando1 = Expresion();
                Parea(Tokens.Tipo.parentesis_derecho);
                return operando1;
            }
            else
            {
                Console.WriteLine("Error Sintactico" + preAnalisis.TipoToken.ToString() + preAnalisis.Lexema);
                errorSintactico = true; 
            }
            return new Resultado("Error", "");

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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _LFP_Final_201801364
{
    class AnalizadorLexico
    {
        public List<Tokens> listaTokens = new List<Tokens>();
      
        private int estado;
        String auxlex = "";
        private int columna = 0;
        private int fila = 1;
        private char letra;
        private int contID = 0;
     
        public Tokens.Tipo verificar()
        {
            switch (this.auxlex)
            {
                case "var":
                    return Tokens.Tipo.var;
                case "print":
                    return Tokens.Tipo.print;
                case "datos":
                    return Tokens.Tipo.datos;

                default:
                    return Tokens.Tipo.id;
            }
        }

        public List<Tokens> analizadorLexema(String entra)
        {
            entra = entra + "#";
            estado = 0;

            Char c;

            int codigoascii = 0;
            for (int i = 0; i < entra.Length; i++)
            {
                
                c = entra.ElementAt(i);
                letra = entra[i];
                codigoascii = letra;
                switch (estado)
                {
                    case 0:
                        if (letra == '\t' || letra == '\r' || letra == '\b' || letra == '\f' || letra == ' ')
                        {
                            estado = 0;
                        }
                        else if (letra == '\n')
                        {
                            fila += 1;
                            estado = 0;
                        }
                        else if (Char.IsLetter(c))
                        {
                            auxlex += c;
                            estado = 1;
                            columna++;
                        }
                        else if (Char.IsDigit(c))
                        {
                            auxlex += c;
                            columna++;
                            estado = 2;
                        } else if (letra.Equals('+'))
                        {
                            auxlex += letra;
                            columna++;
                            agregarTokens(Tokens.Tipo.mas);
                        } else if (letra.Equals('-'))
                        {
                            auxlex += letra;
                            columna++;
                            agregarTokens(Tokens.Tipo.menos);
                        } else if (letra.Equals('*'))
                        {
                            auxlex += letra;
                            columna++;
                            agregarTokens(Tokens.Tipo.asterisco);
                        } else if (letra.Equals('/'))
                        {
                            auxlex += letra;
                            columna++;
                            agregarTokens(Tokens.Tipo.diagonal);
                        } else if (letra.Equals('('))
                        {
                            auxlex += letra;
                            columna++;
                            agregarTokens(Tokens.Tipo.parentesis_izquierdo);
                        } else if (letra.Equals(')'))
                        {
                            auxlex += letra;
                            columna++;
                            agregarTokens(Tokens.Tipo.parentesis_derecho);
                        } else if (letra.Equals('='))
                        {
                            auxlex += letra;
                            columna++;
                            agregarTokens(Tokens.Tipo.igual);
                        }else if (letra.Equals(';'))
                        {
                            auxlex += letra;
                            columna++;
                            agregarTokens(Tokens.Tipo.punto_coma);
                        }
                        else
                        {
                            if (letra.CompareTo('#') == 0 && i == entra.Length - 1 && c.CompareTo('#') == 0)
                            {


                            }
                            else
                            {
                                Console.WriteLine("Error desconocido" + " " + letra);
                                auxlex = "";
                                estado = 0;
                            }
                        }

                        break;
                    case 1:
                        if (Char.IsLetter(c))
                        {
                            auxlex += c;
                            estado = 1;
                        }
                        else if (Char.IsNumber(c))
                        {
                            auxlex += c;
                            estado = 1;
                        }
                        else
                        {
                            Tokens.Tipo tipoaux = verificar();
                            agregarTokens(tipoaux);
                            i--;
                        }
                        break;
                    case 2:
                        if (Char.IsDigit(c))
                        {
                            auxlex += c;
                            estado = 2;
                        }
                        else
                        {
                            agregarTokens(Tokens.Tipo.numeros);
                            i -= 1;
                        }
                        break;
                    default:
                        break;
                }
            }
            agregarTokens(Tokens.Tipo.SIMBOLOACEPTACION);
            return listaTokens;
        }

        public void agregarTokens(Tokens.Tipo tipo)
        {

            listaTokens.Add(new Tokens(auxlex, tipo, fila, columna));
            auxlex = "";
            estado = 0;


        }
        public int generarID()
        {
            return contID += 1;
        }
        public void imprimirToken(List<Tokens> tokens)
        {
            foreach (Tokens item in tokens)
            {
                Console.WriteLine(generarID() + "----" + item.TipoToken + "-----------" + item.Lexema + "--------------" + item.Fila + "----------------" +
                    item.Columna);
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _LFP_Final_201801364
{
   
    class Tokens
    {
        public enum Tipo
        {
            id,
            numeros,
            mas, 
            menos,
            asterisco,
            diagonal,
            igual,
            var,
            print, 
            datos,
            punto_coma,
            parentesis_derecho,
            parentesis_izquierdo,
            SIMBOLOACEPTACION
        }
       
        public string lexema;
        public Tipo tipo;
        private int columna;
        private int fila; 

        public Tokens(string lexema, Tipo tipo, int columna, int fila)
        {
            
            this.lexema = lexema;
            this.tipo = tipo;
            this.columna = columna;
            this.fila = fila; 
        }
        public Tokens()
        {

        }
      
        public string Lexema
        {
            get
            {
                return this.lexema;
            }
        }
        public string TipoToken
        {
            get
            {
                switch (this.tipo)
                {
                    case Tipo.id:
                        return "id";
                    case Tipo.numeros:
                        return "numeros";
                    case Tipo.mas:
                        return "mas";
                    case Tipo.menos:
                        return "menos";
                    case Tipo.asterisco:
                        return "asterisco";
                    case Tipo.diagonal:
                        return "diagonal";
                    case Tipo.igual:
                        return "igual";
                    case Tipo.var:
                        return "var";
                    case Tipo.print:
                        return "print";
                    case Tipo.datos:
                        return "datos";
                    case Tipo.punto_coma:
                        return "punto_coma";
                    case Tipo.parentesis_derecho:
                        return "parentesis_derecho";
                    case Tipo.parentesis_izquierdo:
                        return "parentesis_izquierdo";
                    case Tipo.SIMBOLOACEPTACION:
                        return "SIMBOLOACEPTACION";
                    default:
                        return "token desconocido";
                }
            }
        }
        public int Columna
        {
            get
            {
                return this.columna;
            }
        }
        public int Fila
        {
            get
            {
                return this.fila;
            }
        }
     
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _LFP_Final_201801364
{
    class Simbolo
    {
        private string tipo;
        private string nombre;
        private Resultado resultado;
        public Simbolo(string tipo, string nombre, Resultado resultado)
        {
            this.tipo = tipo;
            this.nombre = nombre;
            this.resultado = resultado;
        }
        public Simbolo()
        {

        }
        public string Tipo
        {
            get
            {
                return this.tipo; 
            }
        }
        public void setTipo(string tipo)
        {
            this.tipo = tipo; 
        }
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            
        }
       
        public Resultado valor
        {
            get
            {
                return this.resultado;
            }
            set
            {
                resultado = value;
            }
          
        }
        public string GetValor
        {
            get
            {
                return resultado.getTipo + " " + resultado.Result;
            }
        }

       
    }
}

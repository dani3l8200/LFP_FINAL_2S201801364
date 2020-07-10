using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _LFP_Final_201801364
{
    class Resultado
    {
        private string tipo;
        private string resultado;
        public Resultado(string tipo,string resultado)
        {
            this.tipo = tipo;
            this.resultado = resultado;
        }
        public string getTipo
        {
            get
            {
                return this.tipo;
            }
        }
        public void setTipo(string tipo) {
            this.tipo = tipo; 
        }
        public string Result
        {
            get
            {
                return this.resultado;
            }
        }
        public void SetResult(String resultado)
        {
            this.resultado = resultado;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _LFP_Final_201801364
{
    public partial class Form1 : Form
    {
        List<Tokens> listaTokens = new List<Tokens>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string entradatxt = richTextBox1.Text;
            AnalizadorLexico analizador = new AnalizadorLexico();
            List<Tokens> tokens = analizador.analizadorLexema(entradatxt);
            listaTokens = analizador.listaTokens;
            AnalizadorSintactico sintactico = new AnalizadorSintactico(listaTokens);
            Interprete interprete = new Interprete(listaTokens);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Uso_de_Funciones
{
    public partial class FrmFunciones : Form
    {
        public FrmFunciones()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int contador = contador_letras(this.textFrase.Text, textLetra.Text);
            this.textResultado.Text = contador.ToString();
        }

        private int contador_letras(string frase, string letra)
        {
            int cont=0;
            for(int i=0; i < frase.Length; i++)
            {
                if (frase[i].ToString().ToLower()==letra.ToLower())
                    cont++;
            }
            return cont;
        }
    }
}

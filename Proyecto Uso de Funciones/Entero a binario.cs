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
    public partial class Entero_a_binario : Form
    {
        public Entero_a_binario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            bool esNumCorrecto = int.TryParse(this.textNumero.Text, out int numero);
            if (!esNumCorrecto)
            {
                MessageBox.Show("Debe ingresar un valor numerico");
                return;
            }
            if (!(numero >= 0 && numero <= 255))
            {
                MessageBox.Show("Número fuera de rango");
                return;
            }

            int[] binario = decimalBinario(numero);
            Console.WriteLine("Inicio");
            for (int i = binario.Length - 1; i >= 0; i--)
            {
                Console.Write(" {0}", binario [i]);

                if (binario[7] == 1) this.checkBox1.Checked = true;
                if (binario[6] == 1) this.checkBox2.Checked = true;
                if (binario[5] == 1) this.checkBox3.Checked = true;
                if (binario[4] == 1) this.checkBox4.Checked = true;
                if (binario[3] == 1) this.checkBox5.Checked = true;
                if (binario[2] == 1) this.checkBox6.Checked = true;
                if (binario[1] == 1) this.checkBox7.Checked = true;
                if (binario[0] == 1) this.checkBox8.Checked = true;
                if (binario[7] == 0) this.checkBox1.Checked = false;
                if (binario[6] == 0) this.checkBox2.Checked = false;
                if (binario[5] == 0) this.checkBox3.Checked = false;
                if (binario[4] == 0) this.checkBox4.Checked = false;
                if (binario[3] == 0) this.checkBox5.Checked = false;
                if (binario[2] == 0) this.checkBox6.Checked = false;
                if (binario[1] == 0) this.checkBox7.Checked = false;
                if (binario[0] == 0) this.checkBox8.Checked = false;
            }
               Console.WriteLine("Fin");
            //Hay que hacerlo automatico
            //this.checkBox8.Checked = true;
        }

        private int[] decimalBinario(int numero)
        {

            int[] binario = { 0, 0, 0, 0, 0, 0, 0, 0 };
            int resto = 0;
            int i = 0;
            while (numero > 0)
            {
                resto = numero % 2;
                binario[i++] = resto;
                numero = numero / 2;
            }
            return binario;
        }

        private void botonCalcularDecimal_Click(object sender, EventArgs e)
        {
            int num = 0;
            if (checkBox8.Checked)num += 1;
            if (checkBox7.Checked) num += 2;
            if (checkBox6.Checked) num += 4;
            if (checkBox5.Checked) num += 8;
            if (checkBox4.Checked) num += 16;
            if (checkBox3.Checked) num += 32;
            if (checkBox2.Checked) num += 64;
            if (checkBox1.Checked) num += 128;
            this.textNumero.Text = num.ToString();
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            sumaBinarioDecimal();
        }
        void sumaBinarioDecimal()
        {
            int num = 0;
            if (checkBox8.Checked) num += 1;
            if (checkBox7.Checked) num += 2;
            if (checkBox6.Checked) num += 4;
            if (checkBox5.Checked) num += 8;
            if (checkBox4.Checked) num += 16;
            if (checkBox3.Checked) num += 32;
            if (checkBox2.Checked) num += 64;
            if (checkBox1.Checked) num += 128;
            this.textNumero.Text = num.ToString();
            //Trabajo en clases
        }
    }
}

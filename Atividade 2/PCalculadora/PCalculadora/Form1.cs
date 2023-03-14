using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCalculadora
{
    public partial class Form1 : Form
    {
        double numero1, numero2, resultado; //globais
        public Form1()
        {
            InitializeComponent();
        }

        private void TxtNumero1_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(txtNumero1.Text, out numero1))

                MessageBox.Show("Número 1 Inválido");
                //caso queira forçar a voltar no número 1, usar txtNumero1.Focus();
        }

        private void TxtNumero2_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(txtNumero2.Text, out numero2))

                MessageBox.Show("Número 2 Inválido");
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if ((double.TryParse(txtNumero1.Text, out numero1)) &&
                (double.TryParse(txtNumero2.Text, out numero2)))
            {
                resultado = numero1 + numero2;
                txtResult.Text = resultado.ToString();
            }
            else
                MessageBox.Show("Número Inválidos");
        }

        private void BtnSub_Click(object sender, EventArgs e)
        {
            if ((double.TryParse(txtNumero1.Text, out numero1)) &&
                (double.TryParse(txtNumero2.Text, out numero2)))
            {
                resultado = numero1 - numero2;
                txtResult.Text = resultado.ToString();
            }
            else
                MessageBox.Show("Número Inválidos");
        }

        private void BtnMult_Click(object sender, EventArgs e)
        {
            if ((double.TryParse(txtNumero1.Text, out numero1)) &&
                (double.TryParse(txtNumero2.Text, out numero2)))
            {
                resultado = numero1 * numero2;
                txtResult.Text = resultado.ToString();
            }
            else
                MessageBox.Show("Número Inválidos");
        }

        private void BtnDiv_Click(object sender, EventArgs e)
        {

            if ((double.TryParse(txtNumero1.Text, out numero1)) &&
                (double.TryParse(txtNumero2.Text, out numero2)))
            {
                if (numero2 > 0)
                {
                    resultado = numero1 / numero2;
                    txtResult.Text = resultado.ToString();
                }
                else
                    MessageBox.Show("Número Inválidos");
            }
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            txtResult.Clear();
        }
    }
}

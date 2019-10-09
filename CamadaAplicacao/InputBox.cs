using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CamadaAplicacao
{
    public partial class InputBox : Form
    {
        public double Valor;
        public int BotaoEscolhido; //  1=Ok    2=Cancelar

        public InputBox()
        {
            InitializeComponent();
        }

        private void InputBox_Load(object sender, EventArgs e)
        {
            BotaoEscolhido = 2;
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            double Resultado;

            if (double.TryParse(txtValor.Text,out Resultado))
            {
                this.Valor=Resultado;
                BotaoEscolhido = 1;
                this.Close();
            }
            else
            {
                MessageBox.Show(" Valor deve ser um numero");
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            BotaoEscolhido = 2;
            this.Close();
        }

        private void txtValor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                btOk_Click(sender,e);
            }
        }
    }
}

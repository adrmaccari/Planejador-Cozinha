using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CamadaAplicacao;

namespace GestaoCozinha
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


        private void mnuFileComprados_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild!=null)
            {
                this.ActiveMdiChild.Close();
            }
            

            frmComprado FormComprado = new frmComprado();
            FormComprado.MdiParent = this;
            FormComprado.Show();

        }

        private void mnuFilePreparos_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }

            frmPreparo FormPreparo = new frmPreparo();
            FormPreparo.MdiParent = this;
            FormPreparo.Show();
        }

        private void configuraçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }

            frmConfiguracoes FormConfiguracao = new frmConfiguracoes();
            FormConfiguracao.MdiParent = this;
            FormConfiguracao.Show();
        }
    }
}

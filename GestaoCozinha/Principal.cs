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

  
        private void mnuTabelaNutricional_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }

            frmTabelaNutricional TabelaNutricional = new frmTabelaNutricional();
            TabelaNutricional.MdiParent = this;
            TabelaNutricional.Show();

        }


        private void mnuConfiguracoes_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }

            frmConfiguracoes FormConfiguracoes = new frmConfiguracoes();
            FormConfiguracoes.MdiParent = this;
            FormConfiguracoes.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CamadaNegocios;
using System.Data.SqlClient;

namespace CamadaAplicacao
{
    public partial class frmTabelaNutricional : Form
    {
        public frmTabelaNutricional()
        {
            InitializeComponent();
        }




        //----- Preencher todos os campos com o Insumo escolhido na lista Insumos Filtrados
        public void PrencherItemTabela()
        {
            DataTable rsItemTabela = new DataTable();

            int IdTabelaNutricional = int.Parse(gridItensTabela.SelectedRows[0].Cells["IdTabelaNutricional"].Value.ToString());

            rsItemTabela = NTabelaNutricional.BuscarID(IdTabelaNutricional;

            txtNome.Text = rsItemTabela.Rows[0]["Nome"].ToString();
            txtObservacao.Text = rsItemTabela.Rows[0]["Observacao"].ToString();
            txtFonteDetalhes.Text = rsItemTabela.Rows[0]["FonteDetalhes"].ToString();
            txtNumeroTACO.Text = rsItemTabela.Rows[0]["PesoUnitario"].ToString();
            txtPesoAmostra.Text = rsItemTabela.Rows[0]["PesoUnitario"].ToString();
            txtCalorias.Text = rsItemTabela.Rows[0]["PesoUnitario"].ToString();
            txtProteinas.Text = rsItemTabela.Rows[0]["PesoUnitario"].ToString();
            txtLipidios.Text = rsItemTabela.Rows[0]["PesoUnitario"].ToString();
            txtSodio.Text = rsItemTabela.Rows[0]["PesoUnitario"].ToString();
            txtFibra.Text = rsItemTabela.Rows[0]["PesoUnitario"].ToString();
            txtCarb.Text = rsItemTabela.Rows[0]["PesoUnitario"].ToString();
            if (rsItemTabela.Rows[0]["Fonte"].ToString()='T')
            {

            }
            txtPesoAmostra.Text = rsItemTabela.Rows[0]["PesoUnitario"].ToString();


            tabComprado.SelectedIndex = 0;
        }

        //----- LIMPA todos os campos da tab DADOS GERAIS e DADOS NUTRICIONAIS
        public void LimparCampos()
        {
            txtNome.Text = string.Empty;
            txtObservacao.Text = string.Empty;
            txtFonteDetalhes.Text = string.Empty;
            txtPesoAmostra.Text = string.Empty;
            txtCalorias.Text = string.Empty;
            txtProteinas.Text = string.Empty;
            txtLipidios.Text = string.Empty;
            txtSodio.Text = string.Empty;
            txtFibra.Text = string.Empty;
            txtCarb.Text = string.Empty;
            txtNumeroTACO.Text = string.Empty;
            radTACO.Checked = false;
            radManual.Checked = false;
        }


        //---Altera os botoes e caixa de texto para Ativo ou Desativo-------------------
        private void AtivarModoEdicao(Boolean Opcao)
        {
            //OBJETOS Gerais
            if (!Opcao && bolInsumoCarregado)
            {
                btEditar.Enabled = true;
                btExcluir.Enabled = true;
            }
            else
            {
                btEditar.Enabled = false;
                btExcluir.Enabled = false;

            }
            btIncluir.Enabled = !Opcao;
            btSalvar.Enabled = Opcao;
            btCancelar.Enabled = Opcao;
            cmbFiltroTipoInsumo.Enabled = !Opcao;
            cmbInsumos.Enabled = !Opcao;

            //Objetos da primeira tab:  DADOS GERAIS
            txtNome.ReadOnly = !Opcao;
            txtDescricao.ReadOnly = !Opcao;
            txtPreco.ReadOnly = !Opcao;
            txtPesoUnitario.ReadOnly = !Opcao;
            cmbTipoInsumo.Enabled = Opcao;
            cmbUnidade.Enabled = Opcao;

            //Objetos da primeira tab:  DADOS NUTRICIONAIS
            txtNumeroTaco.ReadOnly = !Opcao;
            txtFonte.ReadOnly = !Opcao;
            txtCalorias.ReadOnly = !Opcao;
            txtProteinas.ReadOnly = !Opcao;
            txtLipidios.ReadOnly = !Opcao;
            txtFibras.ReadOnly = !Opcao;
            txtSodio.ReadOnly = !Opcao;
            txtSodio.ReadOnly = !Opcao;

            groupFonte.Enabled = Opcao;
        }









        private void frmTabelaNutricional_Load(object sender, EventArgs e)
        {

        }
    }
}

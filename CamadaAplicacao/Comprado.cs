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

namespace CamadaAplicacao
{
    public partial class frmComprado : Form
    {
        private bool bolNovo;
        private bool bolInsumoCarregado;
        public frmComprado()
        {
            InitializeComponent();
        }

        //-----  Carregar todos os TIPOS DE INSUMOS--------------------------------------------------------------------
        public void CarregarTipoInsumo()
        {
            DataTable rsTipoInsumo = new DataTable();

            rsTipoInsumo = NTipoInsumo.Mostrar();

            //Carrega o combobox Filtro Tipos de Insumo
            cmbFiltroTipoInsumo.Items.Clear();
            cmbFiltroTipoInsumo.Items.Add("Todos(*)");
            for (int i = 0; i < rsTipoInsumo.Rows.Count; i++)
            {
                cmbFiltroTipoInsumo.Items.Add(rsTipoInsumo.Rows[i][1].ToString());
            }
            cmbFiltroTipoInsumo.SelectedIndex = 0;

            //Carrega o comboboc Tipos de Insumo, dentro da Tab
            cmbTipoInsumo.DataSource = rsTipoInsumo;
            cmbTipoInsumo.DisplayMember = "Tipo";
            cmbTipoInsumo.ValueMember = "IdTipoInsumo";
            cmbTipoInsumo.SelectedItem = null;
            
        }

        //-----  Carregar todas as UNIDADES------------------------------------------------------------------------
        public void CarregarUnidadeConsumo()
        {
            DataTable rsUnidadeConsumo = new DataTable();

            rsUnidadeConsumo = NUnidadeConsumo.Mostrar();

            //Carrega o comboboc UNIDADES
            cmbUnidade.DataSource = null;
            cmbUnidade.Items.Clear();
            cmbUnidade.DataSource = rsUnidadeConsumo;
            cmbUnidade.DisplayMember = "Simbolo";
            cmbUnidade.ValueMember = "IdUnidadeConsumo";

            /*for (int i = 0; i < rsUnidadeConsumo.Rows.Count; i++)
            {
                cmbUnidade.Items.Add(rsUnidadeConsumo.Rows[i][1].ToString());
            }*/
        }


        //-----  Carregar a LISTA DE INSUMOS, baseada no filtro aplicado---------------------------------------------
        public void CarregarInsumosFiltrado()
        {
            DataTable rsInsumos = new DataTable();
            string valorSelecionado = cmbFiltroTipoInsumo.SelectedItem.ToString() == "Todos(*)" ? "" : cmbFiltroTipoInsumo.SelectedItem.ToString();

            rsInsumos = NInsumos.BuscarTipoInsumo(valorSelecionado);

            //Carrega o combobox Insumos, dentro da Tab
            cmbInsumos.DataSource = null;
            cmbInsumos.Items.Clear();
            cmbInsumos.DataSource = rsInsumos;
            cmbInsumos.DisplayMember = "Nome";
            cmbInsumos.ValueMember = "IdInsumo";
            cmbInsumos.SelectedItem = null;
        }

        //----- Preencher todos os campos com o Insumo escolhido na lista Insumos Filtrados
        public void PrencherDadosInsumo()
        {
            DataTable rsInsumo = new DataTable();
            int IdInsumo = Convert.ToInt32(((DataRowView)cmbInsumos.SelectedItem).Row[0].ToString());

            rsInsumo = NInsumos.BuscarId(IdInsumo);

            txtIdInsumo.Text = rsInsumo.Rows[0]["IdInsumo"].ToString();
            txtNome.Text = rsInsumo.Rows[0]["Nome"].ToString();
            txtDescricao.Text = rsInsumo.Rows[0]["Descricao"].ToString();
            txtPreco.Text = rsInsumo.Rows[0]["PrecoPadrao"].ToString();
            txtPesoUnitario.Text = rsInsumo.Rows[0]["PesoUnitario"].ToString();
            cmbUnidade.SelectedValue = rsInsumo.Rows[0]["IdUnidadeConsumo"].ToString();
            cmbTipoInsumo.SelectedValue = Convert.ToInt32(rsInsumo.Rows[0]["IdTipoInsumo"].ToString());
        }

        //----- LIMPA todos os campos da tab DADOS GERAIS e DADOS NUTRICIONAIS
        public void LimparCampos()
        {
            txtIdInsumo.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtDescricao.Text = string.Empty;
            txtPreco.Text = string.Empty;
            txtPesoUnitario.Text = string.Empty;
            cmbUnidade.SelectedItem = null;
            cmbTipoInsumo.SelectedItem = null;
            txtCalorias.Text = string.Empty;
            txtProteinas.Text = string.Empty;
            txtLipidios.Text = string.Empty;
            txtSodio.Text = string.Empty;
            txtFibras.Text = string.Empty;
            txtCarb.Text = string.Empty;
            txtNumeroTaco.Text= string.Empty;
            txtFonte.Text = string.Empty;
            radTaco.Checked = false;
            radEntradaManual.Checked = false;
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


        private void frmInsumos_Load(object sender, EventArgs e)
        {
            CarregarTipoInsumo();
            CarregarInsumosFiltrado();
            CarregarUnidadeConsumo();
            AtivarModoEdicao(false);
            bolNovo = false;
            bolInsumoCarregado = false;
        }

        
        private void cmbInsumos_SelectionChangeCommitted(object sender, EventArgs e)
        {
            PrencherDadosInsumo();
            bolInsumoCarregado = true;
            AtivarModoEdicao(false);
        }

        private void cmbFiltroTipoInsumo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CarregarInsumosFiltrado();
            bolInsumoCarregado = false;
            AtivarModoEdicao(false);
            LimparCampos();
        }

        private void btIncluir_Click(object sender, EventArgs e)
        {
            bolInsumoCarregado = false;
            AtivarModoEdicao(true);
            LimparCampos();
            bolNovo = true;

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            bolInsumoCarregado = false;
            bolNovo = false;
            LimparCampos();
            AtivarModoEdicao(false);
            CarregarInsumosFiltrado();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            string Nome= txtNome.Text;
            string Descricao= txtDescricao.Text;
            char FeitoComprado= 'C';
            double PrecoPadrao = double.Parse(txtPreco.Text == string.Empty ? "0" : txtPreco.Text);
            double PesoUnitario = double.Parse(txtPesoUnitario.Text == string.Empty ? "0" : txtPesoUnitario.Text);
            int Unidade = int.Parse(cmbUnidade.SelectedValue.ToString());
            int TipoInsumo = int.Parse(cmbTipoInsumo.SelectedValue.ToString());

            if (bolNovo)
            {
                NInsumos.Inserir(Nome,Descricao,FeitoComprado,PrecoPadrao,PesoUnitario,Unidade, TipoInsumo);
            }
            else
            {
                int IdInsumo = int.Parse(txtIdInsumo.Text);

                NInsumos.Editar(IdInsumo, Nome, Descricao, FeitoComprado, PrecoPadrao, PesoUnitario, Unidade, TipoInsumo);
            }
            CarregarInsumosFiltrado();
            bolNovo = false;
            bolInsumoCarregado = true;
            AtivarModoEdicao(false);
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("Tem certeza que deseja eliminar o Insumo: " + txtNome.Text, "Confirmação",  MessageBoxButtons.OKCancel);

            if (resp==DialogResult.OK)
            {
                NInsumos.Excluir(int.Parse(txtIdInsumo.Text));
                LimparCampos();
                CarregarInsumosFiltrado();
                AtivarModoEdicao(false);
                bolNovo = false;
            }
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            AtivarModoEdicao(true);
        }
    }
}

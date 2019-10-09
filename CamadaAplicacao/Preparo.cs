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
    public partial class frmPreparo : Form
    {
        private bool bolNovo;
        private bool bolPreparoCarregado;
        public int IdPreparo;

        public frmPreparo()
        {
            InitializeComponent();
        }

        public void CarregarPreparos()
        {
            DataTable rsPreparo = new DataTable();

            rsPreparo = NPreparo.Mostrar();

            //Carrega o combobox Insumos, dentro da Tab
            cmbPreparos.DataSource = null;
            cmbPreparos.Items.Clear();
            cmbPreparos.DataSource = rsPreparo;
            cmbPreparos.DisplayMember = "Nome";
            cmbPreparos.ValueMember = "IdInsumo";
            cmbPreparos.SelectedItem = null;
        }

        //----- Preencher todos os campos com o Insumo escolhido na lista Preparos
        public void PrencherDadosPreparo()
        {
            DataTable rsInsumo = new DataTable();
       
            rsInsumo = NPreparo.BuscarId(IdPreparo);

            txtIdInsumo.Text = rsInsumo.Rows[0]["IdInsumo"].ToString();
            txtNome.Text = rsInsumo.Rows[0]["Nome"].ToString();
            txtDescricao.Text = rsInsumo.Rows[0]["Descricao"].ToString();
            txtPreco.Text = rsInsumo.Rows[0]["PrecoPadrao"].ToString();
            cmbUnidade.SelectedValue = rsInsumo.Rows[0]["IdUnidadeConsumo"].ToString();
            txtRendimento.Text = rsInsumo.Rows[0]["RendimentoReceita"].ToString();

            CarregarFichaTecnica();
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
        }


        //-----   Carregar FICHA TECNICA    ------------------------------------------------------------------------
        public void CarregarFichaTecnica()
        {
            DataTable rsFichaTecnica = new DataTable();

            rsFichaTecnica = NFichaTecnica.MostrarItens(IdPreparo);

            //Carrega o comboboc UNIDADES
            gridFichaTecnica.DataSource = rsFichaTecnica;
            gridFichaTecnica.Columns["IdPreparo"].Visible = false;
            gridFichaTecnica.Columns["IdInsumo"].Visible = false;

        }


        //----- LIMPA todos os campos da tab DADOS GERAIS e DADOS NUTRICIONAIS
        public void LimparCampos()
        {
            txtIdInsumo.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtDescricao.Text = string.Empty;
            txtPreco.Text = string.Empty;
            cmbUnidade.SelectedItem = null;
            txtCalorias.Text = string.Empty;
            txtProteinas.Text = string.Empty;
            txtLipidios.Text = string.Empty;
            txtSodio.Text = string.Empty;
            txtFibras.Text = string.Empty;
            txtCarb.Text = string.Empty;
            txtPesoUnitario.Text = string.Empty;
            txtRendimento.Text = string.Empty;
        }


        //---Altera os botoes e caixa de texto para Ativo ou Desativo-------------------
        private void AtivarModoEdicao(Boolean Opcao)
        {
            //OBJETOS Gerais
            if (!Opcao && bolPreparoCarregado)
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
            cmbPreparos.Enabled = !Opcao;

            //Objetos da primeira tab:  DADOS GERAIS
            txtNome.ReadOnly = !Opcao;
            txtDescricao.ReadOnly = !Opcao;
            txtPreco.ReadOnly = !Opcao;
            txtPesoUnitario.ReadOnly = !Opcao;
            txtRendimento.ReadOnly = !Opcao;
            cmbUnidade.Enabled = Opcao;

            //Objetos da tab:  DADOS NUTRICIONAIS
            txtCalorias.ReadOnly = !Opcao;
            txtProteinas.ReadOnly = !Opcao;
            txtLipidios.ReadOnly = !Opcao;
            txtFibras.ReadOnly = !Opcao;
            txtSodio.ReadOnly = !Opcao;
            txtSodio.ReadOnly = !Opcao;
        }


        private void frmPreparo_Load(object sender, EventArgs e)
        {
            CarregarUnidadeConsumo();
            CarregarPreparos();
            AtivarModoEdicao(false);
            bolNovo = false;
            bolPreparoCarregado = false;
        }

        private void btIncluir_Click(object sender, EventArgs e)
        {
            LimparCampos();
            bolNovo = true;
            bolPreparoCarregado = false;
            AtivarModoEdicao(true);
        }

        private void cmbPreparos_SelectionChangeCommitted(object sender, EventArgs e)
        {
            IdPreparo = Convert.ToInt32(((DataRowView)cmbPreparos.SelectedItem).Row[0].ToString());
            PrencherDadosPreparo();
            bolPreparoCarregado = true;
            AtivarModoEdicao(false);
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            string Nome = txtNome.Text;
            string Descricao = txtDescricao.Text;
            char FeitoComprado = 'F';
            double PrecoPadrao = double.Parse(txtPreco.Text == string.Empty ? "0" : txtPreco.Text);
            int Unidade= int.Parse(cmbUnidade.SelectedValue.ToString());
            double Rendimento= double.Parse(txtRendimento.Text == string.Empty ? "0" : txtRendimento.Text);

            if (bolNovo)
            {
                NPreparo.Inserir(Nome,Descricao,FeitoComprado,PrecoPadrao,Unidade,Rendimento);
            }
            else
            {
                int IdPreparo = int.Parse(txtIdInsumo.Text);

                NPreparo.Editar(IdPreparo, Nome, Descricao, FeitoComprado, PrecoPadrao, Unidade, Rendimento);
            }
            CarregarPreparos();
            bolNovo = false;
            bolPreparoCarregado= true;
            AtivarModoEdicao(false);
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            AtivarModoEdicao(true);
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("Tem certeza que deseja eliminar o Preparo: " + txtNome.Text, "Confirmação", MessageBoxButtons.OKCancel);

            if (resp == DialogResult.OK)
            {
                NInsumos.Excluir(int.Parse(txtIdInsumo.Text));
                LimparCampos();
                CarregarPreparos();
                AtivarModoEdicao(false);
                bolNovo = false;
            }

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            bolPreparoCarregado = false;
            bolNovo = false;
            LimparCampos();
            AtivarModoEdicao(false);
        }

        private void btFichaTecnica_Click(object sender, EventArgs e)
        {
            if (bolPreparoCarregado)
            {
                FichaTecnica NovaReceita = new FichaTecnica(int.Parse(txtIdInsumo.Text), txtNome.Text, int.Parse(cmbUnidade.SelectedValue.ToString()), double.Parse(txtRendimento.Text));
                NovaReceita.ShowDialog();
                CarregarFichaTecnica();
            }
        }
    }
}

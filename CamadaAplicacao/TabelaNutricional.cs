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
        public bool bolNovo = false;
        public int IdTabelaNutricional;

        public frmTabelaNutricional()
        {
            InitializeComponent();
        }


        //----- Preencher todos os campos com o Insumo escolhido na lista Insumos Filtrados
        public void PrencherItemTabela()
        {
            DataTable rsItemTabela = new DataTable();

            this.IdTabelaNutricional= int.Parse(gridItensTabela.SelectedRows[0].Cells["Coluna1"].Value.ToString());

            rsItemTabela = NTabelaNutricional.BuscarID(IdTabelaNutricional);

            txtNome.Text = rsItemTabela.Rows[0]["Nome"].ToString();
            txtObservacao.Text = rsItemTabela.Rows[0]["Observacao"].ToString();
            txtFonteDetalhes.Text = rsItemTabela.Rows[0]["FonteDetalhe"].ToString();
            txtNumeroTACO.Text = rsItemTabela.Rows[0]["NumeroTACO"].ToString();
            txtPesoAmostra.Text = rsItemTabela.Rows[0]["PesoAmostra"].ToString();
            txtCalorias.Text = rsItemTabela.Rows[0]["Caloria"].ToString();
            txtProteinas.Text = rsItemTabela.Rows[0]["Proteina"].ToString();
            txtLipidios.Text = rsItemTabela.Rows[0]["Lipidio"].ToString();
            txtSodio.Text = rsItemTabela.Rows[0]["Sodio"].ToString();
            txtFibra.Text = rsItemTabela.Rows[0]["Fibra"].ToString();
            txtCarb.Text = rsItemTabela.Rows[0]["Carb"].ToString();
            if (rsItemTabela.Rows[0]["Fonte"].ToString() == 'T'.ToString())
            {
                radTACO.Select();
            }
            else
            {
                radManual.Select();
            }
            txtPesoAmostra.Text = rsItemTabela.Rows[0]["PesoAmostra"].ToString();

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
            btIncluir.Enabled = !Opcao;
            btExcluir.Enabled = !Opcao;
            btEditar.Enabled = !Opcao;
            btSalvar.Enabled = Opcao;
            btCancelar.Enabled = Opcao;


            //Objetos da primeira tab:  DADOS GERAIS
            txtBusca.ReadOnly = Opcao;
            txtNome.ReadOnly = !Opcao;
            txtObservacao.ReadOnly = !Opcao;
            txtPesoAmostra.ReadOnly = !Opcao;

            //Objetos da primeira tab:  DADOS NUTRICIONAIS
            txtCalorias.ReadOnly = !Opcao;
            txtProteinas.ReadOnly = !Opcao;
            txtLipidios.ReadOnly = !Opcao;
            txtFibra.ReadOnly = !Opcao;
            txtSodio.ReadOnly = !Opcao;
            txtCarb.ReadOnly = !Opcao;
        }


                                 
        private void frmTabelaNutricional_Load(object sender, EventArgs e)
        {
            txtBusca_TextChanged(sender, e);
            AtivarModoEdicao(false);
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            DataTable rsItensTabela = new DataTable();

            rsItensTabela = NTabelaNutricional.BuscarNome(txtBusca.Text);

            gridItensTabela.AutoGenerateColumns = false;
           
            gridItensTabela.Columns["Coluna1"].DataPropertyName = "IdTabelaNutricional";
            gridItensTabela.Columns["Coluna1"].Visible = false;
            gridItensTabela.Columns["Coluna2"].DataPropertyName = "Nome";
            gridItensTabela.Columns["Coluna3"].DataPropertyName = "Observacao";

            gridItensTabela.DataSource = rsItensTabela;
        }


        private void gridItensTabela_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void gridItensTabela_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void gridItensTabela_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PrencherItemTabela();
        }

        private void btIncluir_Click(object sender, EventArgs e)
        {
            bolNovo = true;
            LimparCampos();
            AtivarModoEdicao(true);
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            if (radTACO.Checked)
            {
                MessageBox.Show("Não é permitido editar um item da tabela TACO");
            }
            else
            {
                AtivarModoEdicao(true);
                bolNovo = false;
            }
        }

        private void radTACO_CheckedChanged(object sender, EventArgs e)
        {
            if (radTACO.Checked)
            {
                txtNumeroTACO.Enabled = true;
            }
            else
            {
                txtNumeroTACO.Enabled = false;
            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            string Nome = txtNome.Text ;
            string Observacao= txtObservacao.Text ;
            string FonteDetalhes= "Criado/Editado em: " + DateTime.Today.ToShortDateString() ;
            int PesoAmostra=int.Parse( txtPesoAmostra.Text) ;
            double Calorias=double.Parse( txtCalorias.Text );
            double Proteinas= double.Parse(txtProteinas.Text) ;
            double Lipidios= double.Parse(txtLipidios.Text );
            double Sodio = double.Parse(txtSodio.Text );
            double Fibras = double.Parse(txtFibra.Text);
            double Carb = double.Parse(txtCarb.Text);
            char Fonte = 'M';
            if (bolNovo)
            {
                NTabelaNutricional.Incluir(Nome, Fonte, FonteDetalhes, Observacao, PesoAmostra, Calorias, Proteinas, Lipidios, Fibras, Sodio, Carb);
                LimparCampos();
            }
            else
            {
                NTabelaNutricional.Editar(IdTabelaNutricional, Nome, Fonte, FonteDetalhes, Observacao, PesoAmostra, Calorias, Proteinas, Lipidios, Fibras, Sodio, Carb);
            }
            AtivarModoEdicao(false);

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            AtivarModoEdicao(false);
        }
    }
}

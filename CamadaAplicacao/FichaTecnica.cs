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
    public partial class FichaTecnica : Form
    {
        private string nome;
        private int unidade;
        private double rendimentoReceita;
        private int idPreparo;

        public FichaTecnica()
        {
            InitializeComponent();
        }

        public FichaTecnica(int IdPreparo, string Nome, int Unidade, double RendimentoReceita)
        {
            nome = Nome;
            unidade = Unidade;
            rendimentoReceita = RendimentoReceita;
            idPreparo = IdPreparo;

            InitializeComponent();
        }


        private void CarregarItensReceita()
        {
            DataTable rsItensReceita = new DataTable();

            rsItensReceita = NFichaTecnica.MostrarItens(idPreparo);
            gridItensReceita.DataSource = rsItensReceita;
            gridItensReceita.Columns[0].Visible = false;
        }

        //Verifica se o INSUMO informado ja esta na FICHA TECNICA 
        private bool ItemJaEstaNaReceita(int idInsumo)
        {
            for (int i = 0; i < gridItensReceita.Rows.Count; i++)
            {
                if (int.Parse(gridItensReceita.Rows[i].Cells["IdInsumo"].Value.ToString())==idInsumo)
                {
                    return true;
                }
            }
            return false;
        }


        //-----carregar todos os INSUMOS conforme busca da caixa de texto
        private void CarregarInsumosEncontrados()
        {
            DataTable rsInsumos = new DataTable();

            rsInsumos = NFichaTecnica.BuscarInsumo(txtNomeBusca.Text);

            gridInsumos.DataSource = rsInsumos;

        }


        private void FichaTecnica_Load(object sender, EventArgs e)
        {
            txtNome.Text = nome;
            txtRendimento.Text = rendimentoReceita.ToString();
            cmbUnidade.SelectedValue = unidade;


            //Carrega o combobox UNIDADES
            DataTable rsUnidades = new DataTable();
            rsUnidades = NUnidadeConsumo.Mostrar();

            cmbUnidade.DataSource = null;
            cmbUnidade.Items.Clear();
            cmbUnidade.DataSource = rsUnidades;
            cmbUnidade.DisplayMember = "Simbolo";
            cmbUnidade.ValueMember = "IdUnidadeConsumo";

            CarregarItensReceita();

            CarregarInsumosEncontrados();

        }

        private void TxtNomeBusca_TextChanged(object sender, EventArgs e)
        {
            CarregarInsumosEncontrados();
        }

        private void BtIncluir_Click(object sender, EventArgs e)
        {
            int idInsumo;
            double quantidade;
            
            idInsumo =int.Parse( gridInsumos.SelectedRows[0].Cells["IdInsumo"].Value.ToString());

            if (ItemJaEstaNaReceita(idInsumo))
            {
                MessageBox.Show("Item ja esta incluso na Ficha Tecnica."  + Environment.NewLine + "Uma Receita nao pode ter o mesmo Insumo duas vezes");
            }
            else
            {
                quantidade = -1;
                InputBox CaixaEntrada = new InputBox();
                CaixaEntrada.ShowDialog();
                if (CaixaEntrada.BotaoEscolhido == 1)
                {
                    quantidade = CaixaEntrada.Valor;
                    NFichaTecnica.IncluirItem(idPreparo, idInsumo, quantidade);
                    CarregarItensReceita();
                }
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            string NomeInsumo;
            int IdInsumo;

            NomeInsumo = gridItensReceita.SelectedRows[0].Cells["Nome"].Value.ToString();
            IdInsumo = int.Parse( gridItensReceita.SelectedRows[0].Cells["IdInsumo"].Value.ToString());

            if (MessageBox.Show("Confirma apagar da Ficha Tecnica o Item:   "  + NomeInsumo,"Confirmacao",MessageBoxButtons.OKCancel )==DialogResult.OK)
            {
                NFichaTecnica.ExcluirItem(idPreparo, IdInsumo);
                CarregarItensReceita();
            }

        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

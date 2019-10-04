using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using CamadaNegocios;

namespace CamadaAplicacao
{
    public partial class frmConfiguracoes : Form
    {
        object SelecaoAtual;
        bool ModoEditar = false;
     
        public frmConfiguracoes()
        {
            InitializeComponent();
        }


        private void frmConfiguracoes_Load(object sender, EventArgs e)
        {
            Mostrar();
            SelecaoAtual = lstboxUnidadesConsumo.SelectedValue;
            AtivarModoEdicao(false);
            PreencheCaixas();
        }

        //--------- Mostrar todos os simbolos------------------
        private void Mostrar()
        {
            DataTable dtableLista = new DataTable();

            dtableLista = NUnidadeConsumo.Mostrar();

            lstboxUnidadesConsumo.DataSource = dtableLista;
            lstboxUnidadesConsumo.DisplayMember = "Simbolo";
            lstboxUnidadesConsumo.ValueMember = "IdUnidadeConsumo";
        }

       //---Preenche as caixas de texto----------------------
        private void PreencheCaixas()
        {
            DataTable dtableLista = new DataTable();

            if (lstboxUnidadesConsumo.SelectedItems.Count>0)
            {
                dtableLista = NUnidadeConsumo.Buscar(lstboxUnidadesConsumo.SelectedValue.ToString());

                txtSimbolo.Text = dtableLista.Rows[0]["Simbolo"].ToString();
                txtDescricao.Text = dtableLista.Rows[0]["Descricao"].ToString();               
            }
        }


        //---Altera os botoes e caixa de texto para Ativo ou Desativo-------------------
        private void AtivarModoEdicao(Boolean Opcao)
        {
            btIncluir.Enabled = !Opcao;
            btEditar.Enabled = !Opcao;
            btExcluir.Enabled = !Opcao;
            btSalvar.Enabled = Opcao;
            btCancelar.Enabled = Opcao;
            lstboxUnidadesConsumo.Enabled = !Opcao;

            txtSimbolo.ReadOnly = !Opcao;
            txtDescricao.ReadOnly = !Opcao;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            AtivarModoEdicao(false);

        }

        //-------Botão Salvar-------------------------------------------------------------------
        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (txtDescricao.Text!=string.Empty && txtSimbolo.Text != string.Empty)
            {

                if (ModoEditar)
                {
                    string Resposta = NUnidadeConsumo.Editar(Convert.ToInt32( lstboxUnidadesConsumo.SelectedValue.ToString()), txtSimbolo.Text, txtDescricao.Text);
                }
                else
                {
                    string Resposta = NUnidadeConsumo.Inserir(txtSimbolo.Text, txtDescricao.Text);
                }
            }
            
            AtivarModoEdicao(false);
            Mostrar();
            PreencheCaixas();
        }


        //-------Mostra a opcão selecionada na Lista de Unidades de Consumo---------------------------
        private void lstboxUnidadesConsumo_Click(object sender, EventArgs e)
        {
            if (!SelecaoAtual.Equals(lstboxUnidadesConsumo.SelectedValue))
            {
                PreencheCaixas();
                SelecaoAtual = lstboxUnidadesConsumo.SelectedValue;
            }
         }


        //-------Botão Excluir-------------------------------------------------------------------
        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (lstboxUnidadesConsumo.Items.Count > 1)
            {
                string Simbolo = ((DataRowView)lstboxUnidadesConsumo.SelectedItem).Row[1].ToString();


                DialogResult resp=  MessageBox.Show("Confirma deleção da Unidade de Consumo:  " + Simbolo, "Confirmação", MessageBoxButtons.YesNo);
                if (resp==DialogResult.Yes)
                {
                    NUnidadeConsumo.Excluir(Convert.ToInt32(lstboxUnidadesConsumo.SelectedValue.ToString()));
                }

                Mostrar();
                PreencheCaixas();
            }
        }

        //---------  Botao INCLUIR   --------------------------------
        private void btIncluir_Click(object sender, EventArgs e)
        {
            AtivarModoEdicao(true);

            txtSimbolo.Text = string.Empty;
            txtDescricao.Text = string.Empty;

            ModoEditar = false;

        }

        //---------  Botao EDITAR   --------------------------------
        private void btEditar_Click(object sender, EventArgs e)
        {
            AtivarModoEdicao(true);
            ModoEditar = true;
        }
    }
}

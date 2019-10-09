using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace CamadaDados
{
    public class DFichaTecnica
    {
        public int IdInsumo;
        public int IdPreparo;
        public double Quantidade;

        public DFichaTecnica()
        {
        }

        public DFichaTecnica(int idInsumo, int idPreparo, double quantidade)
        {
            IdInsumo = idInsumo;
            IdPreparo = idPreparo;
            Quantidade = quantidade;
        }


        //-----Mostrar todos os INSUMOS que pertencem a esse PREPARO
        public DataTable MostrarItens(int idPreparo)
        {
            SqlConnection Conexao = new SqlConnection(DConexao.strConexao);
            SqlCommand Comando = new SqlCommand();
            DataTable rsItens = new DataTable();

            try
            {
                //  Abrir a conexão
                Conexao.Open();

                Comando.Connection = Conexao;
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.CommandText = "sp_fichatecnica_mostrar_itens";

                SqlParameter prmIdPreparo = new SqlParameter();
                prmIdPreparo.ParameterName = "@IdPreparo";
                prmIdPreparo.SqlDbType = SqlDbType.Int;
                prmIdPreparo.Value = idPreparo;


                Comando.Parameters.Add(prmIdPreparo);

                SqlDataAdapter Adaptador = new SqlDataAdapter(Comando);
                Adaptador.Fill(rsItens);

            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.Message);
                throw;
            }
            finally
            {
                if (Conexao.State==ConnectionState.Open)
                {
                    Conexao.Close();
                }
            }

            return rsItens;
        }


        //-----Incluir um ITEM na FICHA TECNICA do PREPARO
        public void IncluirItem(DFichaTecnica Item)
        {
            SqlConnection Conexao = new SqlConnection(DConexao.strConexao);
            SqlCommand Comando = new SqlCommand();
            string Resposta;

            try
            {
                //  Abrir a conexão
                Conexao.Open();

                Comando.Connection = Conexao;
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.CommandText = "sp_fichatecnica_item_incluir";

                SqlParameter prmPreparo = new SqlParameter();
                prmPreparo.ParameterName = "@IdPreparo";
                prmPreparo.SqlDbType = SqlDbType.Int;
                prmPreparo.Value = Item.IdPreparo;

                SqlParameter prmInsumo = new SqlParameter();
                prmInsumo.ParameterName = "@IdInsumo";
                prmInsumo.SqlDbType = SqlDbType.Int;
                prmInsumo.Value = Item.IdInsumo;

                SqlParameter prmQuantidade = new SqlParameter();
                prmQuantidade.ParameterName = "@Quantidade";
                prmQuantidade.SqlDbType = SqlDbType.Decimal;
                prmQuantidade.Precision = 10;
                prmQuantidade.Scale = 4;
                prmQuantidade.Value = Item.Quantidade;

                Comando.Parameters.Add(prmPreparo);
                Comando.Parameters.Add(prmInsumo);
                Comando.Parameters.Add(prmQuantidade);

                Resposta = Comando.ExecuteNonQuery() == 1 ? "OK" :" Erro ao incluir Insumo no Preparo" ;
                
            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.Message);
                throw;
            }
            finally
            {
                if (Conexao.State == ConnectionState.Open)
                {
                    Conexao.Close();
                }
            }
        }



        //-----Ecluir um ITEM da FICHA TECNICA 
        public void ExcluirItem(DFichaTecnica Item)
        {
            SqlConnection Conexao = new SqlConnection(DConexao.strConexao);
            SqlCommand Comando = new SqlCommand();
            string Resposta;

            try
            {
                //  Abrir a conexão
                Conexao.Open();

                Comando.Connection = Conexao;
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.CommandText = "sp_fichatecnica_item_excluir";

                SqlParameter prmPreparo = new SqlParameter();
                prmPreparo.ParameterName = "@IdPreparo";
                prmPreparo.SqlDbType = SqlDbType.Int;
                prmPreparo.Value = Item.IdPreparo;

                SqlParameter prmInsumo = new SqlParameter();
                prmInsumo.ParameterName = "@IdInsumo";
                prmInsumo.SqlDbType = SqlDbType.Int;
                prmInsumo.Value = Item.IdInsumo;

                Comando.Parameters.Add(prmPreparo);
                Comando.Parameters.Add(prmInsumo);

                Resposta = Comando.ExecuteNonQuery() == 1 ? "OK" : " Erro ao excluir Insumo no Preparo";

            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.Message);
                throw;
            }
            finally
            {
                if (Conexao.State == ConnectionState.Open)
                {
                    Conexao.Close();
                }
            }
        }



        //-----Mostrar todos os INSUMOS que atendem o criterio de BUSCA
        public DataTable BuscarInsumos(string NomeBusca)
        {
            SqlConnection Conexao = new SqlConnection(DConexao.strConexao);
            SqlCommand Comando = new SqlCommand();
            DataTable rsInsumos = new DataTable();

            try
            {
                //  Abrir a conexão
                Conexao.Open();

                Comando.Connection = Conexao;
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.CommandText = "sp_fichatecnica_buscar_insumos_nome";

                SqlParameter prmNomeBusca = new SqlParameter();
                prmNomeBusca.ParameterName = "@Nome";
                prmNomeBusca.SqlDbType = SqlDbType.VarChar;
                prmNomeBusca.Size = 50;
                prmNomeBusca.Value = NomeBusca;


                Comando.Parameters.Add(prmNomeBusca);

                SqlDataAdapter Adaptador = new SqlDataAdapter(Comando);
                Adaptador.Fill(rsInsumos);

            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.Message);
                throw;
            }
            finally
            {
                if (Conexao.State == ConnectionState.Open)
                {
                    Conexao.Close();
                }
            }

            return rsInsumos;
        }

    }
}

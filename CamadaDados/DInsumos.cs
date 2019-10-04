using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace CamadaDados
{
    public class DInsumos
    {
        public int IdInsumo { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public char FeitoComprado { get; set; }
        public double PrecoPadrao { get; set; }
        public int IdUnidadeConsumo { get; set; }
        public int IdTipoInsumo { get; set; }

        public DInsumos()
        {
        }

        public DInsumos(int idInsumo, string nome, string descricao, char feitoComprado, double precoPadrao, int idUnidadeConsumo, int idTipoInsumo)
        {
            IdInsumo = idInsumo;
            Nome = nome;
            Descricao = descricao;
            FeitoComprado = feitoComprado;
            PrecoPadrao = precoPadrao;
            IdUnidadeConsumo = idUnidadeConsumo;
            IdTipoInsumo = idTipoInsumo;
        }

        public string Criar(DInsumos insumo)
        {
            string resp = "";
            SqlConnection Conexao = new SqlConnection();

            try
            {
                //  Abrir a conexão
                Conexao.ConnectionString = DConexao.strConexao;
                Conexao.Open();

                //criar o comando
                SqlCommand sqlComando = new SqlCommand();
                sqlComando.Connection = Conexao;
                sqlComando.CommandText = "sp_Insumos_criar_comprado";
                sqlComando.CommandType = CommandType.StoredProcedure;

                //Atribuir parametros
                SqlParameter prmNome = new SqlParameter();
                prmNome.ParameterName = "@Nome";
                prmNome.SqlDbType = SqlDbType.VarChar;
                prmNome.Size = 100;
                prmNome.Value = insumo.Nome;

                SqlParameter prmDescricao = new SqlParameter();
                prmDescricao.ParameterName = "@Descricao";
                prmDescricao.SqlDbType = SqlDbType.VarChar;
                prmDescricao.Size = 256;
                prmDescricao.Value = insumo.Descricao;

                SqlParameter prmFeitoComprado = new SqlParameter();
                prmFeitoComprado.ParameterName = "@FeitoComprado";
                prmFeitoComprado.SqlDbType = SqlDbType.Char;
                prmFeitoComprado.Size = 1;
                prmFeitoComprado.Value = 'C';

                SqlParameter prmPrecoPadrao = new SqlParameter();
                prmPrecoPadrao.ParameterName = "@PrecoPadrao";
                prmPrecoPadrao.SqlDbType = SqlDbType.Decimal;
                prmPrecoPadrao.Value = insumo.PrecoPadrao;

                SqlParameter prmIdTipoInsumo = new SqlParameter();
                prmIdTipoInsumo.ParameterName = "@IdTipoInsumo";
                prmIdTipoInsumo.SqlDbType = SqlDbType.Int;
                prmIdTipoInsumo.Value = insumo.IdTipoInsumo;

                SqlParameter prmIdUnidadeConsumo = new SqlParameter();
                prmIdUnidadeConsumo.ParameterName = "@IdUnidadeConsumo";
                prmIdUnidadeConsumo.SqlDbType = SqlDbType.Int;
                prmIdUnidadeConsumo.Value = insumo.IdUnidadeConsumo;

                // atribuir os parametos ao comando e executar
                sqlComando.Parameters.Add(prmNome);
                sqlComando.Parameters.Add(prmDescricao);
                sqlComando.Parameters.Add(prmFeitoComprado);
                sqlComando.Parameters.Add(prmPrecoPadrao);
                sqlComando.Parameters.Add(prmIdTipoInsumo);
                sqlComando.Parameters.Add(prmIdUnidadeConsumo);
                resp = sqlComando.ExecuteNonQuery() == 1 ? "Ok" : "Erro na execução da Stored Procedure";

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
            return resp;
        }
        public string Excluir(DInsumos insumo)
        {
            string resp = "";
            SqlConnection Conexao = new SqlConnection();
            try
            {
                //  Abrir a conexão
                Conexao.ConnectionString = DConexao.strConexao;
                Conexao.Open();

                //criar o comando
                SqlCommand sqlComando = new SqlCommand();
                sqlComando.Connection = Conexao;
                sqlComando.CommandText = "sp_Insumos_excluir";
                sqlComando.CommandType = CommandType.StoredProcedure;

                //Atribuir parametros
                SqlParameter prmIdInsumo = new SqlParameter();
                prmIdInsumo.ParameterName = "@IdInsumo";
                prmIdInsumo.SqlDbType = SqlDbType.Int;
                prmIdInsumo.Value = insumo.IdInsumo;

                // atribuir os parametos ao comando e executar
                sqlComando.Parameters.Add(prmIdInsumo);
                resp = sqlComando.ExecuteNonQuery() == 1 ? "Ok" : "Erro na execução da Stored Procedure";

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
            return resp;
        }
        public string Editar(DInsumos insumo)
        {
            string resp = "";
            SqlConnection Conexao = new SqlConnection();
            try
            {
                //  Abrir a conexão
                Conexao.ConnectionString = DConexao.strConexao;
                Conexao.Open();

                //criar o comando
                SqlCommand sqlComando = new SqlCommand();
                sqlComando.Connection = Conexao;
                sqlComando.CommandText = "sp_Insumos_editar_comprado";
                sqlComando.CommandType = CommandType.StoredProcedure;

                //Atribuir parametros
                SqlParameter prmIdInsumo = new SqlParameter();
                prmIdInsumo.ParameterName = "@IdInsumo";
                prmIdInsumo.SqlDbType = SqlDbType.Int;
                prmIdInsumo.Value = insumo.IdInsumo;

                SqlParameter prmNome = new SqlParameter();
                prmNome.ParameterName = "@Nome";
                prmNome.SqlDbType = SqlDbType.VarChar;
                prmNome.Size = 100;
                prmNome.Value = insumo.Nome;

                SqlParameter prmDescricao = new SqlParameter();
                prmDescricao.ParameterName = "@Descricao";
                prmDescricao.SqlDbType = SqlDbType.VarChar;
                prmDescricao.Size = 256;
                prmDescricao.Value = insumo.Descricao;

                SqlParameter prmFeitoComprado = new SqlParameter();
                prmFeitoComprado.ParameterName = "@FeitoComprado";
                prmFeitoComprado.SqlDbType = SqlDbType.Char;
                prmFeitoComprado.Size = 1;
                prmFeitoComprado.Value = insumo.FeitoComprado;

                SqlParameter prmPrecoPadrao = new SqlParameter();
                prmPrecoPadrao.ParameterName = "@PrecoPadrao";
                prmPrecoPadrao.SqlDbType = SqlDbType.Decimal;
                prmPrecoPadrao.Value = insumo.PrecoPadrao;

                SqlParameter prmIdTipoInsumo = new SqlParameter();
                prmIdTipoInsumo.ParameterName = "@IdTipoInsumo";
                prmIdTipoInsumo.SqlDbType = SqlDbType.Int;
                prmIdTipoInsumo.Value = insumo.IdTipoInsumo;

                SqlParameter prmIdUnidadeConsumo = new SqlParameter();
                prmIdUnidadeConsumo.ParameterName = "@IdUnidadeConsumo";
                prmIdUnidadeConsumo.SqlDbType = SqlDbType.Int;
                prmIdUnidadeConsumo.Value = insumo.IdUnidadeConsumo;


                // atribuir os parametos ao comando e executar
                sqlComando.Parameters.Add(prmIdInsumo);
                sqlComando.Parameters.Add(prmNome);
                sqlComando.Parameters.Add(prmDescricao);
                sqlComando.Parameters.Add(prmFeitoComprado);
                sqlComando.Parameters.Add(prmPrecoPadrao);
                sqlComando.Parameters.Add(prmIdTipoInsumo);
                sqlComando.Parameters.Add(prmIdUnidadeConsumo);
                resp = sqlComando.ExecuteNonQuery() == 1 ? "Ok" : "Erro na execução da Stored Procedure";

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
            return resp;
        }

        // ---------- Método MOSTRAR----------------
        public DataTable Mostrar()
        {
            SqlConnection Conexao = new SqlConnection();
            DataTable rsInsumos = new DataTable();

            try
            {
                //  Abrir a conexão
                Conexao.ConnectionString = DConexao.strConexao;
                Conexao.Open();

                //criar o comando
                SqlCommand sqlComando = new SqlCommand();
                sqlComando.Connection = Conexao;
                sqlComando.CommandText = "sp_Insumos_mostrar_comprado";
                sqlComando.CommandType = CommandType.StoredProcedure;

                // executa o comando e guarda os resultdos em um SqlDataAdapter
                SqlDataAdapter dtaAdpter = new SqlDataAdapter(sqlComando);
                dtaAdpter.Fill(rsInsumos);
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

        // ---------- Método BUSCAR pelo NOME----------------
        public DataTable BuscarNome(string insumoNome)
        {
            SqlConnection Conexao = new SqlConnection();
            DataTable rsInsumos = new DataTable();

            try
            {
                //  Abrir a conexão
                Conexao.ConnectionString = DConexao.strConexao;
                Conexao.Open();

                //criar o comando
                SqlCommand sqlComando = new SqlCommand();
                sqlComando.Connection = Conexao;
                sqlComando.CommandText = "sp_Insumos_buscar_nome_comprado";
                sqlComando.CommandType = CommandType.StoredProcedure;

                SqlParameter prmNome = new SqlParameter();
                prmNome.ParameterName = "@textobusca";
                prmNome.SqlDbType = SqlDbType.VarChar;
                prmNome.Size = 100;
                prmNome.Value = insumoNome;

                sqlComando.Parameters.Add(prmNome);

                // executa o comando e guarda os resultados em um SqlDataAdapter
                SqlDataAdapter dtaAdpater = new SqlDataAdapter(sqlComando);
                dtaAdpater.Fill(rsInsumos);
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

        // ---------- Método BUSCAR pelo ID do Insumo----------------
        public DataTable BuscarId(int idinsumo)
        {
            SqlConnection Conexao = new SqlConnection();
            DataTable rsInsumos = new DataTable();

            try
            {
                //  Abrir a conexão
                Conexao.ConnectionString = DConexao.strConexao;
                Conexao.Open();

                //criar o comando
                SqlCommand sqlComando = new SqlCommand();
                sqlComando.Connection = Conexao;
                sqlComando.CommandText = "sp_Insumos_buscar_id_comprado";
                sqlComando.CommandType = CommandType.StoredProcedure;

                SqlParameter prmIdinsumo = new SqlParameter();
                prmIdinsumo.ParameterName = "@IdInsumo";
                prmIdinsumo.SqlDbType = SqlDbType.Int;
                prmIdinsumo.Value = idinsumo;

                sqlComando.Parameters.Add(prmIdinsumo);

                // executa o comando e guarda os resultados em um SqlDataAdapter
                SqlDataAdapter dtaAdpater = new SqlDataAdapter(sqlComando);
                dtaAdpater.Fill(rsInsumos);
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


        // ---------- Método BUSCAR Insumos pelo Tipo de Insumo (para popular a Combobox----------------
        public DataTable BuscarTipoInsumo(string tiposinsumo)
        {
            SqlConnection Conexao = new SqlConnection();
            DataTable rsInsumos = new DataTable();

            try
            {
                //  Abrir a conexão
                Conexao.ConnectionString = DConexao.strConexao;
                Conexao.Open();

                //criar o comando
                SqlCommand sqlComando = new SqlCommand();
                sqlComando.Connection = Conexao;
                sqlComando.CommandText = "sp_Insumos_buscar_tipoinsumo";
                sqlComando.CommandType = CommandType.StoredProcedure;

                SqlParameter prmTipoInsumo = new SqlParameter();
                prmTipoInsumo.ParameterName = "@textobusca";
                prmTipoInsumo.SqlDbType = SqlDbType.VarChar;
                prmTipoInsumo.Size = 100;
                prmTipoInsumo.Value = tiposinsumo;

                sqlComando.Parameters.Add(prmTipoInsumo);

                // executa o comando e guarda os resultados em um SqlDataAdapter
                SqlDataAdapter dtaAdpater = new SqlDataAdapter(sqlComando);
                dtaAdpater.Fill(rsInsumos);
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

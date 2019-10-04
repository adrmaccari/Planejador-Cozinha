using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace CamadaDados
{
    public class DPreparo
    {
        public int IdInsumo { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public char FeitoComprado { get; set; }
        public double PrecoPadrao { get; set; }
        public int IdUnidadeConsumo { get; set; }
        public double RendimentoReceita { get; set; }

        public DPreparo()
        {
        }

        public DPreparo(int idInsumo, string nome, string descricao, char feitoComprado, double precoPadrao, int idUnidadeConsumo, double rendimentoReceita)
        {
            IdInsumo = idInsumo;
            Nome = nome;
            Descricao = descricao;
            FeitoComprado = feitoComprado;
            PrecoPadrao = precoPadrao;
            IdUnidadeConsumo = idUnidadeConsumo;
            RendimentoReceita = rendimentoReceita;
        }



        public string Criar(DPreparo insumo)
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
                sqlComando.CommandText = "sp_Insumos_criar_preparo";
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
                prmFeitoComprado.Value = 'F';

                SqlParameter prmPrecoPadrao = new SqlParameter();
                prmPrecoPadrao.ParameterName = "@PrecoPadrao";
                prmPrecoPadrao.SqlDbType = SqlDbType.Decimal;
                prmPrecoPadrao.Value = insumo.PrecoPadrao;

                SqlParameter prmRendimentoReceita = new SqlParameter();
                prmRendimentoReceita.ParameterName = "@RendimentoReceita";
                prmRendimentoReceita.SqlDbType = SqlDbType.Decimal;
                prmRendimentoReceita.Value = insumo.RendimentoReceita;

                SqlParameter prmIdUnidadeConsumo = new SqlParameter();
                prmIdUnidadeConsumo.ParameterName = "@IdUnidadeConsumo";
                prmIdUnidadeConsumo.SqlDbType = SqlDbType.Int;
                prmIdUnidadeConsumo.Value = insumo.IdUnidadeConsumo;

                // atribuir os parametos ao comando e executar
                sqlComando.Parameters.Add(prmNome);
                sqlComando.Parameters.Add(prmDescricao);
                sqlComando.Parameters.Add(prmFeitoComprado);
                sqlComando.Parameters.Add(prmPrecoPadrao);
                sqlComando.Parameters.Add(prmRendimentoReceita);
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
        public string Excluir(DPreparo insumo)
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
        public string Editar(DPreparo insumo)
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
                sqlComando.CommandText = "sp_Insumos_editar_preparo";
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

                SqlParameter prmRendimentoReceita = new SqlParameter();
                prmRendimentoReceita.ParameterName = "@RendimentoReceita";
                prmRendimentoReceita.SqlDbType = SqlDbType.Decimal;
                prmRendimentoReceita.Value = insumo.PrecoPadrao;

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
                sqlComando.Parameters.Add(prmRendimentoReceita);
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
                sqlComando.CommandText = "sp_Insumos_mostrar_preparo";
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
                sqlComando.CommandText = "sp_Insumos_buscar_nome_preparo";
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
                sqlComando.CommandText = "sp_Insumos_buscar_id_preparo";
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
    }
}


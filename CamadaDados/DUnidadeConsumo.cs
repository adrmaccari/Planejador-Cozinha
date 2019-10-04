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
    public class DUnidadeConsumo
    {
        public int IdUnidadeConsumo { get; set; }
        public string Simbolo { get; set; }
        public string Descricao { get; set; }

        public DUnidadeConsumo()
        {
        }

        public DUnidadeConsumo(int idUnidadeConsumo, string simbolo, string descricao)
        {
            IdUnidadeConsumo = idUnidadeConsumo;
            Simbolo = simbolo;
            Descricao = descricao;
        }

        public string Criar(DUnidadeConsumo unidadeconsumo)
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
                sqlComando.CommandText = "sp_UnidadeConsumo_criar";
                sqlComando.CommandType =  CommandType.StoredProcedure;

                //Atribuir parametros
                SqlParameter prmSimbolo = new SqlParameter();
                prmSimbolo.ParameterName = "@simbolo";
                prmSimbolo.SqlDbType = SqlDbType.VarChar;
                prmSimbolo.Size = 2;
                prmSimbolo.Value = unidadeconsumo.Simbolo;

                SqlParameter prmDescricao = new SqlParameter();
                prmDescricao.ParameterName = "@descricao";
                prmDescricao.SqlDbType = SqlDbType.VarChar;
                prmDescricao.Size = 256;
                prmDescricao.Value = unidadeconsumo.Descricao;

                // atribuir os parametos ao comando e executar
                sqlComando.Parameters.Add(prmSimbolo);
                sqlComando.Parameters.Add(prmDescricao);
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
        public string Excluir(DUnidadeConsumo unidadeconsumo)
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
                sqlComando.CommandText = "sp_UnidadeConsumo_excluir";
                sqlComando.CommandType = CommandType.StoredProcedure;

                //Atribuir parametros
                SqlParameter prmIdUnidade = new SqlParameter();
                prmIdUnidade.ParameterName = "@idunidadeconsumo";
                prmIdUnidade.SqlDbType = SqlDbType.Int;
                prmIdUnidade.Value = unidadeconsumo.IdUnidadeConsumo;

                // atribuir os parametos ao comando e executar
                sqlComando.Parameters.Add(prmIdUnidade);
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
        public string Editar(DUnidadeConsumo unidadeconsumo)
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
                sqlComando.CommandText = "sp_UnidadeConsumo_editar";
                sqlComando.CommandType = CommandType.StoredProcedure;

                //Atribuir parametros
                SqlParameter prmSimbolo = new SqlParameter();
                prmSimbolo.ParameterName = "@simbolo";
                prmSimbolo.SqlDbType = SqlDbType.VarChar;
                prmSimbolo.Size = 2;
                prmSimbolo.Value = unidadeconsumo.Simbolo;

                SqlParameter prmDescricao = new SqlParameter();
                prmDescricao.ParameterName = "@descricao";
                prmDescricao.SqlDbType = SqlDbType.VarChar;
                prmDescricao.Size = 256;
                prmDescricao.Value = unidadeconsumo.Descricao;

                SqlParameter prmIdUnidade = new SqlParameter();
                prmIdUnidade.ParameterName = "@idunidadeconsumo";
                prmIdUnidade.SqlDbType = SqlDbType.Int;
                prmIdUnidade.Value = unidadeconsumo.IdUnidadeConsumo;

                // atribuir os parametos ao comando e executar
                sqlComando.Parameters.Add(prmSimbolo);
                sqlComando.Parameters.Add(prmDescricao);
                sqlComando.Parameters.Add(prmIdUnidade);
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
            DataTable tblUnidades = new DataTable();
            
            try
            {
                //  Abrir a conexão
                Conexao.ConnectionString = DConexao.strConexao;
                Conexao.Open();

                //criar o comando
                SqlCommand sqlComando = new SqlCommand();
                sqlComando.Connection = Conexao;
                sqlComando.CommandText = "sp_UnidadeConsumo_mostrar";
                sqlComando.CommandType = CommandType.StoredProcedure;

                // executa o comando e guarda os resultdos em um SqlDataAdapter
                SqlDataAdapter rsRegistros = new SqlDataAdapter(sqlComando);
                rsRegistros.Fill(tblUnidades);
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
            return tblUnidades;
        }

        // ---------- Método BUSCAR----------------
        public DataTable Buscar(int unidadeconsumo)
        {
            SqlConnection Conexao = new SqlConnection();
            DataTable tblUnidades = new DataTable();

            try
            {
                //  Abrir a conexão
                Conexao.ConnectionString = DConexao.strConexao;
                Conexao.Open();

                //criar o comando
                SqlCommand sqlComando = new SqlCommand();
                sqlComando.Connection = Conexao;
                sqlComando.CommandText = "sp_UnidadeConsumo_buscar";
                sqlComando.CommandType = CommandType.StoredProcedure;

                SqlParameter prmIdUnidade = new SqlParameter();
                prmIdUnidade.ParameterName = "@idunidade";
                prmIdUnidade.SqlDbType = SqlDbType.Int;
                prmIdUnidade.Value = unidadeconsumo;

                sqlComando.Parameters.Add(prmIdUnidade);

                // executa o comando e guarda os resultados em um SqlDataAdapter
                SqlDataAdapter rsRegistros = new SqlDataAdapter(sqlComando);
                rsRegistros.Fill(tblUnidades);
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
            return tblUnidades;
        }
    }
}

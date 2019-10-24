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
    public class DTabelaNutricional
    {
        public int IdTabelaNutricional { get; set; }
        public string Nome { get; set; }
        public char Fonte { get; set; }
        public string FonteDetalhe { get; set; }
        public string Observacao { get; set; }
        public int PesoAmostra { get; set; }
        public double Caloria { get; set; }
        public double Proteina { get; set; }
        public double Lipidio { get; set; }
        public double Fibra { get; set; }
        public double Sodio { get; set; }
        public double Carb { get; set; }

        public DTabelaNutricional()
        {
        }

        public DTabelaNutricional(int idTabelaNutricional, string nome, char fonte, string fonteDetalhe, string observacao, int pesoAmostra, double caloria, double proteina, double lipidio, double fibra, double sodio, double carb)
        {
            IdTabelaNutricional = idTabelaNutricional;
            Nome = nome;
            Fonte = fonte;
            FonteDetalhe = fonteDetalhe;
            Observacao = observacao;
            PesoAmostra = pesoAmostra;
            Caloria = caloria;
            Proteina = proteina;
            Lipidio = lipidio;
            Fibra = fibra;
            Sodio = sodio;
            Carb = carb;
        }

        public string Criar(DTabelaNutricional tabelaNutricional)
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
                sqlComando.CommandText = "sp_tabelanutricional_incluir";
                sqlComando.CommandType = CommandType.StoredProcedure;

                //Atribuir parametros
                SqlParameter prmNome = new SqlParameter();
                prmNome.ParameterName = "@Nome";
                prmNome.SqlDbType = SqlDbType.VarChar;
                prmNome.Size = 100;
                prmNome.Value = tabelaNutricional.Nome;

                SqlParameter prmFonte = new SqlParameter();
                prmFonte.ParameterName = "@Fonte";
                prmFonte.SqlDbType = SqlDbType.Char;
                prmFonte.Size = 1;
                prmFonte.Value = tabelaNutricional.Fonte;

                SqlParameter prmFonteDetalhe = new SqlParameter();
                prmFonteDetalhe.ParameterName = "@FonteDetalhe";
                prmFonteDetalhe.SqlDbType = SqlDbType.VarChar;
                prmFonteDetalhe.Size = 100;
                prmFonteDetalhe.Value = tabelaNutricional.FonteDetalhe;

                SqlParameter prmObservacao = new SqlParameter();
                prmObservacao.ParameterName = "@Observacao";
                prmObservacao.SqlDbType = SqlDbType.VarChar;
                prmObservacao.Size = 100;
                prmObservacao.Value = tabelaNutricional.Observacao;

                SqlParameter prmPesoAmostra = new SqlParameter();
                prmPesoAmostra.ParameterName = "@PesoAmostra";
                prmPesoAmostra.SqlDbType = SqlDbType.Int;
                prmPesoAmostra.Value = tabelaNutricional.PesoAmostra;

                SqlParameter prmCaloria = new SqlParameter();
                prmCaloria.ParameterName = "@Caloria";
                prmCaloria.SqlDbType = SqlDbType.Decimal;
                prmCaloria.Scale = 4;
                prmCaloria.Precision = 10;
                prmCaloria.Value = tabelaNutricional.Caloria;

                SqlParameter prmProteina = new SqlParameter();
                prmProteina.ParameterName = "@Proteina";
                prmProteina.SqlDbType = SqlDbType.Decimal;
                prmProteina.Scale = 4;
                prmProteina.Precision = 10;
                prmProteina.Value = tabelaNutricional.Proteina;
                
                SqlParameter prmLipidio = new SqlParameter();
                prmLipidio.ParameterName = "@Lipidio";
                prmLipidio.SqlDbType = SqlDbType.Decimal;
                prmLipidio.Scale = 4;
                prmLipidio.Precision = 10;
                prmLipidio.Value = tabelaNutricional.Lipidio;

                SqlParameter prmSodio = new SqlParameter();
                prmSodio.ParameterName = "@Sodio";
                prmSodio.SqlDbType = SqlDbType.Decimal;
                prmSodio.Scale = 4;
                prmSodio.Precision = 10;
                prmSodio.Value = tabelaNutricional.Sodio;

                SqlParameter prmFibra = new SqlParameter();
                prmFibra.ParameterName = "@Fibra";
                prmFibra.SqlDbType = SqlDbType.Decimal;
                prmFibra.Scale = 4;
                prmFibra.Precision = 10;
                prmFibra.Value = tabelaNutricional.Fibra;

                SqlParameter prmCarb = new SqlParameter();
                prmCarb.ParameterName = "@Carb";
                prmCarb.SqlDbType = SqlDbType.Decimal;
                prmCarb.Scale = 4;
                prmCarb.Precision = 10;
                prmCarb.Value = tabelaNutricional.Carb;


                // atribuir os parametos ao comando e executar
                sqlComando.Parameters.Add(prmNome);
                sqlComando.Parameters.Add(prmFonte);
                sqlComando.Parameters.Add(prmFonteDetalhe);
                sqlComando.Parameters.Add(prmObservacao);
                sqlComando.Parameters.Add(prmPesoAmostra);
                sqlComando.Parameters.Add(prmCaloria);
                sqlComando.Parameters.Add(prmProteina);
                sqlComando.Parameters.Add(prmLipidio);
                sqlComando.Parameters.Add(prmFibra);
                sqlComando.Parameters.Add(prmSodio);
                sqlComando.Parameters.Add(prmCarb);
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
        public string Excluir(DTabelaNutricional tabelaNutricional)
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
                sqlComando.CommandText = "sp_tabelanutricional_excluir";
                sqlComando.CommandType = CommandType.StoredProcedure;

                //Atribuir parametros
                SqlParameter prmIdTabelaNutricional = new SqlParameter();
                prmIdTabelaNutricional.ParameterName = "@IdTabelaNutricional";
                prmIdTabelaNutricional.SqlDbType = SqlDbType.Int;
                prmIdTabelaNutricional.Value = tabelaNutricional.IdTabelaNutricional;

                // atribuir os parametos ao comando e executar
                sqlComando.Parameters.Add(prmIdTabelaNutricional);
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


        public string Editar(DTabelaNutricional tabelaNutricional)
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
                sqlComando.CommandText = "sp_tabelanutricional_editar";
                sqlComando.CommandType = CommandType.StoredProcedure;

                //Atribuir parametros
                SqlParameter prmIdTabelaNutricional = new SqlParameter();
                prmIdTabelaNutricional.ParameterName = "@IdTabelaNutricional";
                prmIdTabelaNutricional.SqlDbType = SqlDbType.Int;
                prmIdTabelaNutricional.Value = tabelaNutricional.IdTabelaNutricional;

                SqlParameter prmNome = new SqlParameter();
                prmNome.ParameterName = "@Nome";
                prmNome.SqlDbType = SqlDbType.VarChar;
                prmNome.Size = 100;
                prmNome.Value = tabelaNutricional.Nome;

                SqlParameter prmFonte = new SqlParameter();
                prmFonte.ParameterName = "@Fonte";
                prmFonte.SqlDbType = SqlDbType.Char;
                prmFonte.Size = 1;
                prmFonte.Value = tabelaNutricional.Fonte;

                SqlParameter prmFonteDetalhe = new SqlParameter();
                prmFonteDetalhe.ParameterName = "@FonteDetalhe";
                prmFonteDetalhe.SqlDbType = SqlDbType.VarChar;
                prmFonteDetalhe.Size = 100;
                prmFonteDetalhe.Value = tabelaNutricional.FonteDetalhe;

                SqlParameter prmObservacao = new SqlParameter();
                prmObservacao.ParameterName = "@Observacao";
                prmObservacao.SqlDbType = SqlDbType.VarChar;
                prmObservacao.Size = 100;
                prmObservacao.Value = tabelaNutricional.Observacao;

                SqlParameter prmPesoAmostra = new SqlParameter();
                prmPesoAmostra.ParameterName = "@PesoAmostra";
                prmPesoAmostra.SqlDbType = SqlDbType.Int;
                prmPesoAmostra.Value = tabelaNutricional.PesoAmostra;

                SqlParameter prmCaloria = new SqlParameter();
                prmCaloria.ParameterName = "@Caloria";
                prmCaloria.SqlDbType = SqlDbType.Decimal;
                prmCaloria.Scale = 4;
                prmCaloria.Precision = 10;
                prmCaloria.Value = tabelaNutricional.Caloria;

                SqlParameter prmProteina = new SqlParameter();
                prmProteina.ParameterName = "@Proteina";
                prmProteina.SqlDbType = SqlDbType.Decimal;
                prmProteina.Scale = 4;
                prmProteina.Precision = 10;
                prmProteina.Value = tabelaNutricional.Proteina;

                SqlParameter prmLipidio = new SqlParameter();
                prmLipidio.ParameterName = "@Lipidio";
                prmLipidio.SqlDbType = SqlDbType.Decimal;
                prmLipidio.Scale = 4;
                prmLipidio.Precision = 10;
                prmLipidio.Value = tabelaNutricional.Lipidio;

                SqlParameter prmSodio = new SqlParameter();
                prmSodio.ParameterName = "@Sodio";
                prmSodio.SqlDbType = SqlDbType.Decimal;
                prmSodio.Scale = 4;
                prmSodio.Precision = 10;
                prmSodio.Value = tabelaNutricional.Sodio;

                SqlParameter prmFibra = new SqlParameter();
                prmFibra.ParameterName = "@Fibra";
                prmFibra.SqlDbType = SqlDbType.Decimal;
                prmFibra.Scale = 4;
                prmFibra.Precision = 10;
                prmFibra.Value = tabelaNutricional.Fibra;

                SqlParameter prmCarb = new SqlParameter();
                prmCarb.ParameterName = "@Carb";
                prmCarb.SqlDbType = SqlDbType.Decimal;
                prmCarb.Scale = 4;
                prmCarb.Precision = 10;
                prmCarb.Value = tabelaNutricional.Carb;


                // atribuir os parametos ao comando e executar
                sqlComando.Parameters.Add(prmIdTabelaNutricional);
                sqlComando.Parameters.Add(prmNome);
                sqlComando.Parameters.Add(prmFonte);
                sqlComando.Parameters.Add(prmFonteDetalhe);
                sqlComando.Parameters.Add(prmObservacao);
                sqlComando.Parameters.Add(prmPesoAmostra);
                sqlComando.Parameters.Add(prmCaloria);
                sqlComando.Parameters.Add(prmProteina);
                sqlComando.Parameters.Add(prmLipidio);
                sqlComando.Parameters.Add(prmFibra);
                sqlComando.Parameters.Add(prmSodio);
                sqlComando.Parameters.Add(prmCarb);
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


        public DataTable BuscarNome(string NomeBusca)
        {
            SqlConnection Conexao = new SqlConnection();
            DataTable rsItensTabela = new DataTable();

            try
            {
                //  Abrir a conexão
                Conexao.ConnectionString = DConexao.strConexao;
                Conexao.Open();

                //criar o comando
                SqlCommand sqlComando = new SqlCommand();
                sqlComando.Connection = Conexao;
                sqlComando.CommandText = "sp_tabelanutricional_buscar_nome";
                sqlComando.CommandType = CommandType.StoredProcedure;

                //Atribuir parametros
                SqlParameter prmNome = new SqlParameter();
                prmNome.ParameterName = "@Nome";
                prmNome.SqlDbType = SqlDbType.VarChar;
                prmNome.Size = 100;
                prmNome.Value = NomeBusca;

                // atribuir os parametos ao comando e executar
                sqlComando.Parameters.Add(prmNome);
                SqlDataAdapter DataAdapter = new SqlDataAdapter(sqlComando);
                DataAdapter.Fill(rsItensTabela);

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
            return rsItensTabela;
        }



        public DataTable BuscarID(int idTabelaNutricional)
        {
            SqlConnection Conexao = new SqlConnection();
            DataTable rsItensTabela = new DataTable();

            try
            {
                //  Abrir a conexão
                Conexao.ConnectionString = DConexao.strConexao;
                Conexao.Open();

                //criar o comando
                SqlCommand sqlComando = new SqlCommand();
                sqlComando.Connection = Conexao;
                sqlComando.CommandText = "sp_tabelanutricional_buscar_id";
                sqlComando.CommandType = CommandType.StoredProcedure;

                //Atribuir parametros
                SqlParameter prmIdTabelaNutricional = new SqlParameter();
                prmIdTabelaNutricional.ParameterName = "@IdTabelaNutricional";
                prmIdTabelaNutricional.SqlDbType = SqlDbType.Int;
                prmIdTabelaNutricional.Value = idTabelaNutricional;

                // atribuir os parametos ao comando e executar
                sqlComando.Parameters.Add(prmIdTabelaNutricional);
                SqlDataAdapter DataAdapter = new SqlDataAdapter(sqlComando);
                DataAdapter.Fill(rsItensTabela);

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
            return rsItensTabela;
        }


    }
}

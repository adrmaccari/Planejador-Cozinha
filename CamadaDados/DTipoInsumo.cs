using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace CamadaDados
{
    public class DTipoInsumo
    {
        public DTipoInsumo()
        {
        }

        public DataTable Mostrar()
        {
            SqlConnection Conexao = new SqlConnection();
            DataTable rsTipoInsumo = new DataTable();

            try
            {
                //  Abrir a conexão
                Conexao.ConnectionString = DConexao.strConexao;
                Conexao.Open();

                //criar o comando
                SqlCommand sqlComando = new SqlCommand();
                sqlComando.Connection = Conexao;
                sqlComando.CommandText = "sp_TiposInsumo_mostrar";
                sqlComando.CommandType = CommandType.StoredProcedure;

                // executa o comando e guarda os resultdos em um SqlDataAdapter
                SqlDataAdapter dtaAdpter = new SqlDataAdapter(sqlComando);
                dtaAdpter.Fill(rsTipoInsumo);
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
            return rsTipoInsumo;
        }

    }
}

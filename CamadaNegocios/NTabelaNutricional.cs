using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaDados;
using System.Data;
using System.Data.SqlClient;

namespace CamadaNegocios
{
    public class NTabelaNutricional
    {
        public static string Incluir(string nome, char fonte, string fonteDetalhe, string observacao, int numeroTACO, int pesoAmostra, double caloria, double proteina, double lipidio, double fibra, double sodio, double carb)
        {
            DTabelaNutricional ItemTabela = new DTabelaNutricional();

            ItemTabela.Nome = nome;
            ItemTabela.Fonte = fonte;
            ItemTabela.FonteDetalhe = fonteDetalhe;
            ItemTabela.Observacao = observacao;
            ItemTabela.NumeroTACO = numeroTACO;
            ItemTabela.PesoAmostra = pesoAmostra;
            ItemTabela.Caloria = caloria;
            ItemTabela.Proteina = proteina;
            ItemTabela.Lipidio = lipidio;
            ItemTabela.Fibra = fibra;
            ItemTabela.Sodio = sodio;
            ItemTabela.Carb = carb;

            return ItemTabela.Criar(ItemTabela);
        }

        public static string Editar(int idTabelaNutricional, string nome, char fonte, string fonteDetalhe, string observacao, int numeroTACO, int pesoAmostra, double caloria, double proteina, double lipidio, double fibra, double sodio, double carb)
        {
            DTabelaNutricional ItemTabela = new DTabelaNutricional();

            ItemTabela.IdTabelaNutricional = idTabelaNutricional;
            ItemTabela.Nome = nome;
            ItemTabela.Fonte = fonte;
            ItemTabela.FonteDetalhe = fonteDetalhe;
            ItemTabela.Observacao = observacao;
            ItemTabela.NumeroTACO = numeroTACO;
            ItemTabela.PesoAmostra = pesoAmostra;
            ItemTabela.Caloria = caloria;
            ItemTabela.Proteina = proteina;
            ItemTabela.Lipidio = lipidio;
            ItemTabela.Fibra = fibra;
            ItemTabela.Sodio = sodio;
            ItemTabela.Carb = carb;

            return ItemTabela.Editar(ItemTabela);
        }

        public static string Excluir (int idTabelaNutricional)
        {
            DTabelaNutricional ItemTabela = new DTabelaNutricional();

            ItemTabela.IdTabelaNutricional = idTabelaNutricional;
            return ItemTabela.Excluir(ItemTabela);
        }


        public static DataTable BuscarNome(string NomeBusca)
        {
            DTabelaNutricional TabelaNutricional = new DTabelaNutricional();

            return TabelaNutricional.BuscarNome(NomeBusca);
        }


        public static DataTable BuscarID(int idTabelaNutricional)
        {
            DTabelaNutricional TabelaNutricional = new DTabelaNutricional();

            return TabelaNutricional.BuscarID(idTabelaNutricional);
        }

    }
}

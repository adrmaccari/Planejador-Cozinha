using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaDados;
using System.Data;

namespace CamadaNegocios
{
    public class NUnidadeConsumo
    {
        public static string Inserir(string simbolo, string descricao)
        {
            DUnidadeConsumo Objeto = new DUnidadeConsumo();
            
            Objeto.Simbolo = simbolo.ToUpper();
            Objeto.Descricao = descricao;

            return Objeto.Criar(Objeto);
        }

        public static string Excluir(int idunidadeconsumo)
        {
            DUnidadeConsumo Objeto = new DUnidadeConsumo();

            Objeto.IdUnidadeConsumo = idunidadeconsumo;
            
            return Objeto.Excluir(Objeto);
        }

        public static string Editar(int idunidadeconsumo, string simbolo, string descricao)
        {
            DUnidadeConsumo Objeto = new DUnidadeConsumo();

            Objeto.IdUnidadeConsumo = idunidadeconsumo;
            Objeto.Simbolo = simbolo.ToUpper();
            Objeto.Descricao = descricao;

            return Objeto.Editar(Objeto);
        }

        public static DataTable Mostrar()
        {
            DUnidadeConsumo Objeto = new DUnidadeConsumo();

            return Objeto.Mostrar();
        }

        public static DataTable Buscar(string idunidade)
        {
            DUnidadeConsumo Objeto = new DUnidadeConsumo();

            
            return Objeto.Buscar(int.Parse(idunidade));
        }

    }
}

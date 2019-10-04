using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using CamadaDados;

namespace CamadaNegocios
{
    public class NTipoInsumo
    {
        public static DataTable Mostrar()
        {

            DTipoInsumo insumos = new DTipoInsumo();

            return insumos.Mostrar();
        }

    }
}

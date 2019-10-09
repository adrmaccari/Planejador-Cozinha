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
    public static class NFichaTecnica
    {
        public static void IncluirItem(int idPreparo,int idInsumo, double quantidade)
        {
            DFichaTecnica Item = new DFichaTecnica();

            Item.IdInsumo = idInsumo;
            Item.IdPreparo = idPreparo;
            Item.Quantidade = quantidade;
            Item.IncluirItem(Item);
        }


        public static void ExcluirItem(int idPreparo, int idInsumo)
        {
            DFichaTecnica Item = new DFichaTecnica();

            Item.IdInsumo = idInsumo;
            Item.IdPreparo = idPreparo;
            Item.ExcluirItem(Item);
        }


        public static  DataTable MostrarItens(int idPreparo)
        {
            DFichaTecnica ItemReceita = new DFichaTecnica();

            return ItemReceita.MostrarItens(idPreparo);
        }

        public static DataTable BuscarInsumo(string NomeInsumo)
        {
            DFichaTecnica ItemReceita = new DFichaTecnica();

            return ItemReceita.BuscarInsumos(NomeInsumo);
        }
    }
}

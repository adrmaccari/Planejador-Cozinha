using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CamadaDados;
using System.Data;

namespace CamadaNegocios
{
    public class NPreparo
    {
        public static string Inserir(string nome, string descricao, char feitoComprado , double pesoUnitario, int idUnidadeConsumo, double rendimentoReceita)
        {
            DPreparo Objeto = new DPreparo();

            Objeto.Nome = nome;
            Objeto.FeitoComprado = feitoComprado;
            Objeto.Descricao = descricao;
            Objeto.PesoUnitario = pesoUnitario;
            Objeto.IdUnidadeConsumo = idUnidadeConsumo;
            Objeto.RendimentoReceita = rendimentoReceita;

            return Objeto.Criar(Objeto);
        }

        public static string Excluir(int idinsumo)
        {
            DPreparo Objeto = new DPreparo();

            Objeto.IdInsumo = idinsumo;

            return Objeto.Excluir(Objeto);
        }

        public static string Editar(int idinsumo, string nome, string descricao, char feitoComprado, double pesoUnitario, int idUnidadeConsumo, double rendimentoReceita)
        {

            DPreparo Objeto = new DPreparo();

            Objeto.IdInsumo = idinsumo;
            Objeto.Nome = nome;
            Objeto.FeitoComprado = feitoComprado;
            Objeto.Descricao = descricao;
            Objeto.PesoUnitario = pesoUnitario;
            Objeto.IdUnidadeConsumo = idUnidadeConsumo;
            Objeto.RendimentoReceita = rendimentoReceita;

            return Objeto.Editar(Objeto);
        }

        public static DataTable Mostrar()
        {
            DPreparo Objeto = new DPreparo();

            return Objeto.Mostrar();
        }

        public static DataTable BuscarNMome(string nomeinsumo)
        {
            DPreparo Objeto = new DPreparo();

            return Objeto.BuscarNome(nomeinsumo);
        }

        public static DataTable BuscarId(int IdInsumo)
        {
            DPreparo Objeto = new DPreparo();

            return Objeto.BuscarId(IdInsumo);
        }

        public static void TotalizarFT(int idPreparo)
        {
            DPreparo Objeto = new DPreparo();

            Objeto.TotalizarFT(idPreparo);
        }
    }
}


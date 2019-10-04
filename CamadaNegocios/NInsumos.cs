﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CamadaDados;

namespace CamadaNegocios
{
    public class NInsumos
    {
        public static string Inserir(string nome, string descricao, char feitoComprado, double precoPadrao,  int idUnidadeConsumo, int idTipoInsumo)
        {
            DInsumos Objeto = new DInsumos();

            Objeto.Nome = nome;
            Objeto.FeitoComprado = feitoComprado;
            Objeto.Descricao=descricao;
            Objeto.PrecoPadrao=precoPadrao;
            Objeto.IdTipoInsumo = idTipoInsumo;
            Objeto.IdUnidadeConsumo = idUnidadeConsumo;
            
            return Objeto.Criar(Objeto);
        }

        public static string Excluir(int idinsumo)
        {
            DInsumos Objeto = new DInsumos();

            Objeto.IdInsumo = idinsumo;

            return Objeto.Excluir(Objeto);
        }

        public static string Editar(int idinsumo, string nome, string descricao, char feitoComprado, double precoPadrao, int idUnidadeConsumo, int idTipoInsumo)
        {

            DInsumos Objeto = new DInsumos();

            Objeto.IdInsumo = idinsumo;
            Objeto.Nome = nome;
            Objeto.FeitoComprado = feitoComprado;
            Objeto.Descricao = descricao;
            Objeto.PrecoPadrao = precoPadrao;
            Objeto.IdTipoInsumo = idTipoInsumo;
            Objeto.IdUnidadeConsumo = idUnidadeConsumo;

            return Objeto.Editar(Objeto);
        }

        public static DataTable Mostrar()
        {
            DInsumos Objeto = new DInsumos();

            return Objeto.Mostrar();
        }

        public static DataTable BuscarNMome(string nomeinsumo)
        {
            DInsumos Objeto = new DInsumos();

            return Objeto.BuscarNome(nomeinsumo);
        }

        public static DataTable BuscarId(int IdInsumo)
        {
            DInsumos Objeto = new DInsumos();

            return Objeto.BuscarId(IdInsumo);
        }

        public static DataTable BuscarTipoInsumo(string tipoinsumo)
        {
            DInsumos Objeto = new DInsumos();

            return Objeto.BuscarTipoInsumo(tipoinsumo);
        }
    }
}
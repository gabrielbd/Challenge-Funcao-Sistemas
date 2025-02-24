﻿using FI.AtividadeEntrevista.DAL;
using FI.AtividadeEntrevista.DML;
using System.Collections.Generic;

namespace FI.AtividadeEntrevista.BLL
{
    public class BoCliente
    {
 
        public long Incluir(Cliente cliente)
        {
            DaoCliente cli = new DaoCliente();
            return cli.Incluir(cliente);
        }

        public void Alterar(Cliente cliente)
        {
            DaoCliente cli = new DaoCliente();
            cli.Alterar(cliente);
        }

        public Cliente Consultar(long id)
        {
            DaoCliente cli = new DaoCliente();
            return cli.Consultar(id);
        }

        public void Excluir(long id)
        {
            DaoCliente cli = new DaoCliente();
            cli.Excluir(id);
        }

        public List<Cliente> Listar()
        {
            DaoCliente cli = new DaoCliente();
            return cli.Listar();
        }
        public List<Cliente> Pesquisa(int iniciarEm, int quantidade, string campoOrdenacao, bool crescente, out int qtd)
        {
            DaoCliente cli = new DaoCliente();
            return cli.Pesquisa(iniciarEm,  quantidade, campoOrdenacao, crescente, out qtd);
        }

        public bool VerificarExistencia(string CPF)
        {
            DaoCliente cli = new DaoCliente();
            return cli.VerificarExistencia(CPF);
        }
    }
}

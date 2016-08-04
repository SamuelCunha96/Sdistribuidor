using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sdistribuidor.Entidade;
using Sdistribuidor.DAO;
using System.Data;

namespace Sdistribuidor.Model
{
    public class Loja
    {
        public Loja() { }

        public bool Salvar(Entidade_Loja EntLoja)
        {
            try
            {
                BancoDados.InsertAlterarExcluir("INSERT INTO Loja (nmloja,razao_social,nm_fantasia,cnpj,ie,logradouro,nro,compl,cep,id_uf,id_cidade,fone,tipo_regime)" +
                                                "VALUES('" + EntLoja.nmloja + "','" + EntLoja.razao_social + "','" + EntLoja.nm_fantasia + "','" + EntLoja.cnpj + "','" + EntLoja.ie + "','" + EntLoja.logradouro + "','" + EntLoja.nro + "','" + EntLoja.compl + "','" + EntLoja.cep + "'," + EntLoja.id_uf + "," + EntLoja.id_cidade + ",'" + EntLoja.fone + "','" + EntLoja.tipo_regime + "')");

                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public DataTable Pesquisa()
        {
            return BancoDados.Consultar("SELECT * FROM Loja Order By nmloja");
        }
        public DataTable Pesquisa(int id)
        {
            return BancoDados.Consultar("SELECT * FROM Loja WHERE id=" + id);
        }
        public DataTable Pesquisa(string descricao)
        {
            return BancoDados.Consultar("SELECT * FROM Loja WHERE nmloja like '%" + descricao + "%'");
        }

    }
}

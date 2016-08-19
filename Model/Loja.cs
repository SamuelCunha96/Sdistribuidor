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
                BancoDados.InsertAlterarExcluir("INSERT INTO Loja (nmloja,razao_social,nm_fantasia,cnpj,ie,logradouro,nro,compl,cep,id_uf,id_cidade,fone,tipo_regime,bairro)" +
                                                "VALUES('" + EntLoja.nmloja + "','" + EntLoja.razao_social + "','" + EntLoja.nm_fantasia + "','" + EntLoja.cnpj + "','" + EntLoja.ie + "','" + EntLoja.logradouro + "','" + EntLoja.nro + "','" + EntLoja.compl + "','" + EntLoja.cep + "'," + EntLoja.id_uf + "," + EntLoja.id_cidade + ",'" + EntLoja.fone + "','" + EntLoja.tipo_regime + "','" + EntLoja.bairro + "')");

                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
        public bool Update(Entidade_Loja EntLoja)
        {
            try
            {
                BancoDados.InsertAlterarExcluir("update Loja set nmloja ='" + EntLoja.nmloja + "' ,razao_social='" + EntLoja.razao_social + "',nm_fantasia='" + EntLoja.nm_fantasia + "',cnpj='" + EntLoja.cnpj + "',ie='" + EntLoja.ie + "',bairro='"+ EntLoja.bairro +"',logradouro='" + EntLoja.logradouro + "',nro='" + EntLoja.nro + "',compl='" + EntLoja.compl + "',cep='" + EntLoja.cep + "',id_uf=" + EntLoja.id_uf + ",id_cidade=" + EntLoja.id_cidade + ",fone='" + EntLoja.fone + "',tipo_regime='" + EntLoja.tipo_regime + "' WHERE id=" + EntLoja.id);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public DataTable Pesquisa()
        {
            return BancoDados.Consultar("select l.*,u.desc_uf from loja l inner join uf u on l.id_uf = u.id_uf Order By nmloja");
        }
        public DataTable Pesquisa(int id)
        {
            return BancoDados.Consultar("select l.*,u.desc_uf from loja l inner join uf u on l.id_uf = u.id_uf WHERE id=" + id);
        }
        public DataTable Pesquisa(string descricao)
        {
            return BancoDados.Consultar("select l.*,u.desc_uf from loja l inner join uf u on l.id_uf = u.id_uf WHERE nmloja like '%" + descricao + "%'");
        }


    }
}

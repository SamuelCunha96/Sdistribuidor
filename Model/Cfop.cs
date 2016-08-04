using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sdistribuidor.Entidade;
using Sdistribuidor.DAO;


namespace Sdistribuidor.Model
{
    public class Cfop
    {
        Entidade_Cfop EntCfop;
        public List<Entidade_Cfop> Pesquisa()
        {
            EntCfop = new Entidade_Cfop();

            List<Entidade_Cfop> ListCfop = new List<Entidade_Cfop>();
            var Dt = BancoDados.Consultar("SELECT *  FROM Cfop");

            for (int i = 0; i < Dt.Rows.Count; i++)
            {
                EntCfop.cfop = Convert.ToInt32(Dt.Rows[i][0]);
                EntCfop.descricao = Dt.Rows[i][1].ToString();
                ListCfop.Add(EntCfop);
            }

            return ListCfop;
        }
        public List<Entidade_Cfop> Interno()
        {           
            List<Entidade_Cfop> ListCfop = new List<Entidade_Cfop>();
            var Dt = BancoDados.Consultar("SELECT cfop, cfop || '-' || descricao as descricao FROM cfop WHERE cfop >= '5000' and cfop <= '6000' order by cfop");

            for (int i = 0; i < Dt.Rows.Count; i++)
            {
                EntCfop = new Entidade_Cfop();
                EntCfop.cfop = Convert.ToInt32(Dt.Rows[i][0]);
                EntCfop.descricao = Dt.Rows[i][1].ToString();
                ListCfop.Add(EntCfop);
            }

            return ListCfop;
        }
        public List<Entidade_Cfop> Externo()
        {
            List<Entidade_Cfop> ListCfop = new List<Entidade_Cfop>();
            var Dt = BancoDados.Consultar("SELECT cfop, cfop || '-' || descricao as descricao FROM cfop WHERE cfop >= '6000' and cfop <= '7000' order by cfop");

            for (int i = 0; i < Dt.Rows.Count; i++)
            {
                EntCfop = new Entidade_Cfop();
                EntCfop.cfop = Convert.ToInt32(Dt.Rows[i][0]);
                EntCfop.descricao = Dt.Rows[i][1].ToString();
                ListCfop.Add(EntCfop);
            }

            return ListCfop;
        }
        public Entidade_Cfop Pesquisa(int ID)
        {
            var Dt = BancoDados.Consultar("SELECT *  FROM Cfop WHERE cfop = " + ID);
            EntCfop = new Entidade_Cfop();

            if (Dt.Rows.Count > 0)
            {
                EntCfop.cfop = Convert.ToInt32(Dt.Rows[0][0]);
                EntCfop.descricao = Dt.Rows[0][1].ToString();
            }
            else
                return null;

            return EntCfop;
        }
        public List<Entidade_Cfop> Pesquisa(string Nome)
        {
            var Dt = BancoDados.Consultar("SELECT *  FROM Cfop WHERE descricao like '%" + Nome + "%'");
            EntCfop = new Entidade_Cfop();

            List<Entidade_Cfop> ListCfop = new List<Entidade_Cfop>();

            for (int i = 0; i < Dt.Rows.Count; i++)
            {
                EntCfop.cfop = Convert.ToInt32(Dt.Rows[i][0]);
                EntCfop.descricao = Dt.Rows[i][1].ToString();
                ListCfop.Add(EntCfop);
            }

            return ListCfop;
        }
        public bool Incluir(Entidade_Cfop Obj)
        {
            try
            {
                BancoDados.InsertAlterarExcluir("INSERT INTO cfop (cfop, descricao) values (" + Obj.cfop + ",'" + Obj.descricao + "')");
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool Update(Entidade_Cfop Obj)
        {
            try
            {
                BancoDados.InsertAlterarExcluir("UPDATE cfop SET descricao = '" + Obj.descricao + "' WHERE cfop = " + Obj.cfop);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        //public bool Delete(Entidade_Cfop ObjVendedor)
        //{
        //    using (ISession session = NHibernateHelper.OpenSession())
        //    using (ITransaction transaction = session.BeginTransaction())
        //    {
        //        try
        //        {
        //            session.Delete(ObjVendedor);
        //            transaction.Commit();
        //        }
        //        catch (Exception ex)
        //        {
        //            throw new Exception(ex.Message.ToString());
        //        }
        //    }
        //    return true;
        //}
    }
}

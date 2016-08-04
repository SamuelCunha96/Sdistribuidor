using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sdistribuidor.Entidade;
using Sdistribuidor.DAO;

namespace Sdistribuidor.Model
{
    public class Cst
    {
        Entidade_Cst EntCst;
        
        public List<Entidade_Cst> ICMS(string empresa)
        {
            
            List<Entidade_Cst> ListCst = new List<Entidade_Cst>();
            var Dt = BancoDados.Consultar("SELECT cst, cst || '-' || descricao as descricao FROM cst WHERE tabela_cst = 'ICMS' AND tipo_icms = '" + empresa +"' ORDER BY cst");

            for (int i = 0; i < Dt.Rows.Count; i++)
            {
                EntCst = new Entidade_Cst();
                EntCst.cst = Dt.Rows[i][0].ToString();
                EntCst.descricao = Dt.Rows[i][1].ToString();
                ListCst.Add(EntCst);
            }
            return ListCst;
        }
        public List<Entidade_Cst> IPI()
        {
            List<Entidade_Cst> ListCst = new List<Entidade_Cst>();
            var Dt = BancoDados.Consultar("SELECT cst, cst || '-' || descricao as descricao FROM cst WHERE tabela_cst = 'IPI' ORDER BY cst");

            for (int i = 0; i < Dt.Rows.Count; i++)
            {
                EntCst = new Entidade_Cst();
                EntCst.cst = Dt.Rows[i][0].ToString();
                EntCst.descricao = Dt.Rows[i][1].ToString();
                ListCst.Add(EntCst);
            }
            return ListCst;
        }
        public List<Entidade_Cst> COFINS()
        {
            List<Entidade_Cst> ListCst = new List<Entidade_Cst>();
            var Dt = BancoDados.Consultar("SELECT cst, cst || '-' || descricao as descricao FROM cst WHERE tabela_cst = 'PISCON' ORDER BY cst");

            for (int i = 0; i < Dt.Rows.Count; i++)
            {
                EntCst = new Entidade_Cst();
                EntCst.cst = Dt.Rows[i][0].ToString();
                EntCst.descricao = Dt.Rows[i][1].ToString();
                ListCst.Add(EntCst);
            }
            return ListCst;
        }
        public List<Entidade_Cst> PIS()
        {
            List<Entidade_Cst> ListCst = new List<Entidade_Cst>();
            var Dt = BancoDados.Consultar("SELECT cst, cst || '-' || descricao as descricao FROM cst WHERE tabela_cst = 'PISCON' ORDER BY cst");

            for (int i = 0; i < Dt.Rows.Count; i++)
            {
                EntCst = new Entidade_Cst();
                EntCst.cst = Dt.Rows[i][0].ToString();
                EntCst.descricao = Dt.Rows[i][1].ToString();
                ListCst.Add(EntCst);
            }
            return ListCst;
        }
        public Entidade_Cst Pesquisa(string ID)
        {
            var Dt = BancoDados.Consultar("SELECT *  FROM cst WHERE cst ='"+ ID +"'");
            EntCst = new Entidade_Cst();
            if (Dt.Rows.Count > 0)
            {
                EntCst.cst = Dt.Rows[0][0].ToString();
                EntCst.descricao = Dt.Rows[0][1].ToString();
                EntCst.codigo_origem = Dt.Rows[0][2].ToString();
                EntCst.tipo_icms = Dt.Rows[0][3].ToString();
            }
            else
                return null;
            return EntCst;
        }
        //public Entidade_Cst Pesquisa(string Nome)
        //{
        //    using (ISession session = NHibernateHelper.OpenSession())
        //    {
        //        var obj = session
        //                    .CreateCriteria(typeof(Entidade_Cst))
        //                    .Add(Restrictions.Eq("descricao", Nome))
        //                    .UniqueResult<Entidade_Cst>();

        //        return obj;
        //    }
        //}
        public bool Incluir(Entidade_Cst Obj)
        {
            try
            {
                BancoDados.InsertAlterarExcluir("INSERT INTO cst (cst, descricao, cdOrig,tipo_icms) values ('"+ Obj.cst + "','" + Obj.descricao + "','" + Obj.codigo_origem + "','" + Obj.tipo_icms + "')");
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool Update(Entidade_Cst Obj)
        {
            try
            {
                BancoDados.InsertAlterarExcluir("UPDATE cst SET descricao='" + Obj.descricao + "', cdOrig = '" + Obj.codigo_origem + "',tipo_icms= '" + Obj.tipo_icms + "' WHERE cst  ='" + Obj.cst + "'");
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool Delete(Entidade_Cst ObjVendedor)
        {
            return false;
        }
    }
}

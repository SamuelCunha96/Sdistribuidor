using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sdistribuidor.Entidade;
using Sdistribuidor.DAO;

namespace Sdistribuidor.Model
{
    class Cidade
    {
        Entidade_Cidade EntCidade;
        public List<Entidade_Cidade> Pesquisa()
        {
            List<Entidade_Cidade> ListCidade = new List<Entidade_Cidade>();
            var Dt = BancoDados.Consultar("SELECT *  FROM cidade ORDER BY desc_municipio");

            for (int i = 0; i < Dt.Rows.Count; i++)
            {
                EntCidade = new Entidade_Cidade();
                EntCidade.id = Convert.ToInt32(Dt.Rows[i][0]);
                EntCidade.desc_municipio = Dt.Rows[i][1].ToString();
                EntCidade.id_ibge = Dt.Rows[i][2].ToString();
                //EntCidade.id_uf = Convert.ToInt32(Dt.Rows[i][3]);
                ListCidade.Add(EntCidade);
            }
            return ListCidade;
        }
        public Entidade_Cidade Pesquisa(int ID)
        {
            try
            {
                
                var Dt = BancoDados.Consultar("SELECT *  FROM cidade WHERE id=" + ID);
                if (Dt.Rows.Count > 0)
                {
                    EntCidade = new Entidade_Cidade();
                    EntCidade.id = Convert.ToInt32(Dt.Rows[0][0]);
                    EntCidade.desc_municipio = Dt.Rows[0][1].ToString();
                    EntCidade.id_ibge = Dt.Rows[0][2].ToString();
                    //EntCidade.id_uf = Convert.ToInt32(Dt.Rows[i][3]);
                }
                return EntCidade;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }
        public List<Entidade_Cidade> Pesquisa(string Nome)
        {
            var Dt = BancoDados.Consultar("SELECT *  FROM cidade WHERE desc_municipio like '%" + Nome + "%'");

            List<Entidade_Cidade> ListCidade = new List<Entidade_Cidade>();

            for (int i = 0; i < Dt.Rows.Count; i++)
            {
                EntCidade = new Entidade_Cidade();
                EntCidade.id = Convert.ToInt32(Dt.Rows[i][0]);
                EntCidade.desc_municipio = Dt.Rows[i][1].ToString();
                EntCidade.id_ibge = Dt.Rows[i][2].ToString();

                ListCidade.Add(EntCidade);
            }

            return ListCidade;
        }
        public List<Entidade_Cidade> PesquisaUFCidade(int id)
        {
            var Dt = BancoDados.Consultar("SELECT *  FROM cidade WHERE id_uf = " + id);

            List<Entidade_Cidade> ListCidade = new List<Entidade_Cidade>();

            for (int i = 0; i < Dt.Rows.Count; i++)
            {
                EntCidade = new Entidade_Cidade();
                EntCidade.id = Convert.ToInt32(Dt.Rows[i][0]);
                EntCidade.desc_municipio = Dt.Rows[i][1].ToString();
                EntCidade.id_ibge = Dt.Rows[i][2].ToString();
                ListCidade.Add(EntCidade);
            }
            return ListCidade;
        }
        public Entidade_Cidade PesquisaCidadeIbge(string idibge)
        {
            var Dt = BancoDados.Consultar("SELECT *  FROM cidade WHERE id_ibge = " + idibge);
            if (Dt.Rows.Count > 0)
            {
                EntCidade = new Entidade_Cidade();
                EntCidade.id = Convert.ToInt32(Dt.Rows[0][0]);
                EntCidade.desc_municipio = Dt.Rows[0][1].ToString();
                EntCidade.id_ibge = Dt.Rows[0][2].ToString();
                //EntCidade.id_uf = Convert.ToInt32(Dt.Rows[i][3]);
            }
            return EntCidade;
        }
    }
}

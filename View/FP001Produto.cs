using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sdistribuidor.Model;
using Sdistribuidor.Entidade;

namespace Sdistribuidor.View
{
    public partial class FP001Produto : Form
    {
        public FP001Produto()
        {
            InitializeComponent();
        }
        Produtos mProd;

        public long ID { get; set; }
        public string Descricao { get; set; }
        public string Unidade { get; set; }
        public string NCM { get; set; }

        private void FP001Produto_Load(object sender, EventArgs e)
        {
            mProd = new Produtos();
            var ret = mProd.Pesquisa();

            PreencherGrid(ret);
            
        }
        void PesquisaDesc(string DescPesq)
        {
            PreencherGrid(mProd.Pesquisa(DescPesq));
        }
        void PesquisaDesc(int id)
        {
            PreencherGrid(mProd.Pesquisa(long.Parse(id.ToString())));
        }
        void PreencherGrid(List<Entidade_Produto> ObjProd)
        {
            foreach (var item in ObjProd)
            {
                grdProduto.Rows.Add(item.IdProduto, item.NmProduto, item.Unidade.CdUnidade, item.VlPreco,item.NCM);
            }
        }
        void PreencherGrid(Entidade_Produto ObjProd)
        {
            grdProduto.Rows.Add(ObjProd.IdProduto, ObjProd.NmProduto, ObjProd.Unidade.CdUnidade, ObjProd.VlPreco, ObjProd.NCM);
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            if(TxtPesquisa.Text != string.Empty)
            {
                grdProduto.Rows.Clear();
                if(rdCodigo.Checked == true)
                {
                    PesquisaDesc(int.Parse(TxtPesquisa.Text));
                }
                else
                {
                    PesquisaDesc(TxtPesquisa.Text);
                }
            }
        }

        private void grdProduto_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void grdProduto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex != -1)
            {
                if (grdProduto.Rows.Count > 0)
                {
                    ID = long.Parse(grdProduto.Rows[e.RowIndex].Cells[0].Value.ToString());
                    Descricao = grdProduto.Rows[e.RowIndex].Cells[1].Value.ToString();
                    Unidade = grdProduto.Rows[e.RowIndex].Cells[2].Value.ToString();
                    NCM = grdProduto.Rows[e.RowIndex].Cells[4].Value.ToString();
                    DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Close();
                }
            }
        }
    }
}

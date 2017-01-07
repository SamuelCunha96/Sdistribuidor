using MetroFramework.Forms;
using Sdistribuidor.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sdistribuidor.View
{
    public partial class FMT009MovEstoque : MetroForm
    {
        public FMT009MovEstoque()
        {
            InitializeComponent();
        }

        MovimentacaoEstoque ObjMovEstoque;
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ObjMovEstoque = new MovimentacaoEstoque();
            grdMovEstoque.AutoGenerateColumns = false;
            if (rbData.Checked)
            {
                grdMovEstoque.DataSource = ObjMovEstoque.Pesquisa(dtpIni.Value, dtpFim.Value);
            }
            else
            {
                grdMovEstoque.DataSource = ObjMovEstoque.Pesquisa(Convert.ToInt32(txtProduto.Text));
            }
        }

        private void rbProduto_Click(object sender, EventArgs e)
        {
            pnlData.Visible = false;
            pnlProduto.Visible = true;
        }

        private void rbData_Click(object sender, EventArgs e)
        {
            pnlData.Visible = true;
            pnlProduto.Visible = false;
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

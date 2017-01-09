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

            grdMovEstoque.DataSource = ObjMovEstoque.Pesquisa(dtpIni.Value, dtpFim.Value, txtProduto.Text == string.Empty ? 0 : Convert.ToInt32(txtProduto.Text));
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!txtProduto.Text.Contains(e.KeyChar.ToString()))
            {
                if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
                {
                    e.Handled = true;
                }
            }
        }
    }
}

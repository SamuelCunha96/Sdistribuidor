using MetroFramework.Forms;
using Sdistribuidor.Entidade;
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

namespace Sdistribuidor.View
{
    public partial class FMT010TransacaoMovEstoque : MetroForm
    {
        public FMT010TransacaoMovEstoque()
        {
            InitializeComponent();
        }

        Entidade_Estoque ObjEntEstoque = new Entidade_Estoque();
        MovimentacaoEstoque ObjMovEstoque;
        List<Entidade_Estoque> ListMovEstoque = new List<Entidade_Estoque>();

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            FP001Produto ObjPesProduto = new FP001Produto();
            if (ObjPesProduto.ShowDialog() == DialogResult.OK)
            {
                lblDesc.Text = ObjPesProduto.Descricao;
                txtCodProduto.Text = ObjPesProduto.ID.ToString();
            }
        }

        private void TxtQtMov_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!TxtQtMov.Text.Contains(e.KeyChar.ToString()))
            {
                if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
                {
                    e.Handled = true;
                }
            }
            else if (e.KeyChar.ToString().Trim() == ",")
                e.Handled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            string MsgErro = string.Empty;
            if (ValidarMovEstoque())
            {
                ListMovEstoque = new List<Entidade_Estoque>();
                if (chkFisico.Checked)
                {
                    ObjEntEstoque = new Entidade_Estoque();

                    ObjEntEstoque.id_Produto = Convert.ToInt32(txtCodProduto.Text);
                    ObjEntEstoque.qt_estoque = Convert.ToDecimal(TxtQtMov.Text.Replace(".", ""));
                    ObjEntEstoque.tpmov = CboTipoMovEstoque.SelectedIndex == 0 ? "E" : "S";
                    ObjEntEstoque.tpmovestoque = CboTipoMovEstoque.SelectedIndex == 0 ? "+" : "-";
                    ObjEntEstoque.tptbmov = "F";
                    ObjEntEstoque.obsestoque = txtObs.Text;

                    ListMovEstoque.Add(ObjEntEstoque);
                }
                if (chkEstoque.Checked)
                {
                    ObjEntEstoque = new Entidade_Estoque();

                    ObjEntEstoque.id_Produto = Convert.ToInt32(txtCodProduto.Text);
                    ObjEntEstoque.qt_estoque = Convert.ToDecimal(TxtQtMov.Text.Replace(".", ""));
                    ObjEntEstoque.tpmov = CboTipoMovEstoque.SelectedIndex == 0 ? "E" : "S";
                    ObjEntEstoque.tpmovestoque = CboTipoMovEstoque.SelectedIndex == 0 ? "+" : "-";
                    ObjEntEstoque.tptbmov = "E";
                    ObjEntEstoque.obsestoque = txtObs.Text;

                    ListMovEstoque.Add(ObjEntEstoque);
                }

                ObjMovEstoque = new MovimentacaoEstoque();
                if (ObjMovEstoque.MovimentarEstoque(ListMovEstoque, out MsgErro))
                {
                    MessageBox.Show("Movimentação Realizada com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LimpaCampos();
                }
                else
                {
                    MessageBox.Show("Erro ao incluir os dados!\nErro:" + MsgErro, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void TxtQtMov_Leave(object sender, EventArgs e)
        {
            if (TxtQtMov.Text != string.Empty)
            {
                TxtQtMov.Text = string.Format("{0:n2}", Convert.ToDecimal(TxtQtMov.Text));
            }
            else
                TxtQtMov.Text = "0,00";
        }
        bool ValidarMovEstoque()
        {
            if (chkFisico.Checked == false && chkEstoque.Checked == false)
            {
                MessageBox.Show("Informe um tipo de movimentação!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                chkFisico.Focus();
                return false;
            }
            else if (CboTipoMovEstoque.SelectedIndex == -1)
            {
                MessageBox.Show("Informe a movimentação!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (TxtQtMov.Text.Trim() == "0,00")
            {
                MessageBox.Show("Informe a Quantidade para movimentação!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;

            }
            else if (txtObs.Text == string.Empty)
            {
                MessageBox.Show("Informe a Observação!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
                return true;
        }

        private void TxtQtMov_Layout(object sender, LayoutEventArgs e)
        {

        }

        void LimpaCampos()
        {
            chkFisico.Checked = false;
            chkEstoque.Checked = false;
            txtCodProduto.Text = string.Empty;
            lblDesc.Text = string.Empty;
            CboTipoMovEstoque.SelectedIndex = -1;
            TxtQtMov.Text = "0,00";
            txtObs.Text = string.Empty;
        }
    }
}

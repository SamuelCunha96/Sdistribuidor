using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Sdistribuidor.Entidade;
using Sdistribuidor.Model;
using Sdistribuidor.Relatorio;

namespace Sdistribuidor.View
{
    public partial class FMT002Pagamento : Form
    {
        public FMT002Pagamento()
        {
            InitializeComponent();
        }


        Pagamento MPedidos;
        CartaoBandeira MCartao;
        RecebCaixa MRecebCaixa;
        private void FMT002Pagamento_Load(object sender, EventArgs e)
        {
            CarregarPedidos();
        }

        void CarregarPedidos()
        {
            MPedidos = new Pagamento();

            if (grdPedidosPagamento.Rows.Count > 0)
                grdPedidosPagamento.Rows.Clear();

            var dt = MPedidos.ListaPedidoPagamento("A");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                grdPedidosPagamento.Rows.Add(dt.Rows[i]["cliente"].ToString(), dt.Rows[i]["Dt_Pedido"].ToString(), dt.Rows[i]["Vl_Pedido"], dt.Rows[i]["flcartao"].ToString(), dt.Rows[i]["Desc_formapagto"].ToString(), dt.Rows[i]["flavista"].ToString(), dt.Rows[i]["Id_Pedido"].ToString());
            }
        }

        private void grdPedidosPagamento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                LimpaPanelReceb();
                if(Convert.ToBoolean(grdPedidosPagamento.Rows[e.RowIndex].Cells[3].Value) == true)
                {
                    MCartao = new CartaoBandeira();
                    cboBandeiras.DataSource = MCartao.Lista();
                    lblNmBandeiras.Visible = true;
                    cboBandeiras.Visible = true;
                }
                if (Convert.ToBoolean(grdPedidosPagamento.Rows[e.RowIndex].Cells[3].Value) == true && Convert.ToBoolean(grdPedidosPagamento.Rows[e.RowIndex].Cells[5].Value) == true)
                {
                    pnlPgMixto.Visible = true;
                    lblNmBandeiras.Visible = false;
                    cboBandeiras.Visible = false;
                }
                lblCliente.Text = grdPedidosPagamento.Rows[e.RowIndex].Cells[0].Value.ToString();
                lblDescFormaPagto.Text = grdPedidosPagamento.Rows[e.RowIndex].Cells[4].Value.ToString();
                lblID.Text = grdPedidosPagamento.Rows[e.RowIndex].Cells["ColID"].Value.ToString();
                lbltotal.Text = string.Format("{0:n2}",Convert.ToDecimal(grdPedidosPagamento.Rows[e.RowIndex].Cells[2].Value));
                txtPagamento.Focus();
            }
        }

        private void grdrecebido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                if (MessageBox.Show("Deseja excluir o pagamento," + grdrecebido.Rows[grdrecebido.CurrentRow.Index].Cells[0].Value.ToString() + "?", "Aténção", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    grdrecebido.Rows.RemoveAt(grdrecebido.CurrentRow.Index);
                }
            }
        }

        private void txtPagamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!txtPagamento.Text.Contains(e.KeyChar.ToString()))
            {
                if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
                {
                    e.Handled = true;
                }
            }
            else if (e.KeyChar.ToString().Trim() == ",")
                e.Handled = true;
        }

        private void txtPagamento_Leave(object sender, EventArgs e)
        {
            if (txtPagamento.Text == string.Empty)
                txtPagamento.Text = "0,00";
            else
                txtPagamento.Text = string.Format("{0:N2}", Convert.ToDecimal(txtPagamento.Text));
        }

        bool ValidarPagamento()
        {
            decimal valorreceb = 0;

            if(grdrecebido.Rows.Count > 0)
            {
                for (int i = 0; i < grdrecebido.Rows.Count; i++)
                {
                    valorreceb += Convert.ToDecimal(grdrecebido.Rows[i].Cells[1].Value);
                }
            }
            if (Convert.ToDouble(txtPagamento.Text) == 0){
                MessageBox.Show("Informado um valor!", "Aténção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (Convert.ToDouble(txtPagamento.Text) > Convert.ToDouble(lbltotal.Text) && cboBandeiras.Visible == true)
            {
                MessageBox.Show("O Tipo de pagamento selecionado pelo vendedor não permite o valor ser maior que o valor do pedido.", "Aténção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if ((Convert.ToDouble(txtPagamento.Text) + Convert.ToDouble(valorreceb)) > Convert.ToDouble(lbltotal.Text) && cboBandeiras.Visible == true)
            {
                MessageBox.Show("O Tipo de pagamento selecionado pelo vendedor não permite o valor ser maior que o informado (+) o valor já recebido.", "Aténção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPagamento.Text = string.Format("{0:N2}", Convert.ToDouble(lbltotal.Text) - Convert.ToDouble(valorreceb));
                return false;
            }
            else
                return true;
            
        }

        private void BtnReceber_Click(object sender, EventArgs e)
        {
            FRImpPedido ObjForm = new FRImpPedido();
            if (cboBandeiras.Visible == true)
            {
                if (ValidarPagamento())
                {
                    grdrecebido.Rows.Add(cboBandeiras.Text, txtPagamento.Text);
                    txtPagamento.Text = "0,00";
                }

                if (ValidarRecebimentoDefinitivo())
                {
                    if (SalvarPagamento())
                    {
                        MessageBox.Show("Pagamento realizado com sucesso!", "Sucesso",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                        //Impressão de Pedido
                        ObjForm.IdPedido = Convert.ToInt32(lblID.Text);
                        if (ObjForm.ShowDialog() == DialogResult.OK)
                        {

                        }
                        LimparCampos();
                        CarregarPedidos();
                    }
                }
            }
            else
            {
                if (ValidarPagamento())
                {
                    grdrecebido.Rows.Add(lblDescFormaPagto.Text, txtPagamento.Text);
                    txtPagamento.Text = "0,00";
                }
                if (ValidarRecebimentoDefinitivo())
                {
                    if (SalvarPagamento())
                    {
                        MessageBox.Show("Pagamento realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        ObjForm.IdPedido = Convert.ToInt32(lblID.Text);
                        if (ObjForm.ShowDialog() == DialogResult.OK)
                        {

                        }

                        LimparCampos();
                        CarregarPedidos();


                    }
                }
            }
        }

        bool ValidarRecebimentoDefinitivo()
        {
            decimal valorreceb = 0;

            if (grdrecebido.Rows.Count > 0)
            {
                for (int i = 0; i < grdrecebido.Rows.Count; i++)
                {
                    valorreceb += Convert.ToDecimal(grdrecebido.Rows[i].Cells[1].Value);
                }

                if (valorreceb > Convert.ToDecimal(lbltotal.Text))
                {
                    MessageBox.Show("Troco:" + string.Format("{0:n2}", valorreceb - Convert.ToDecimal(lbltotal.Text)) + "", "Aténção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else if (valorreceb == Convert.ToDecimal(lbltotal.Text))
                {
                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        }
        bool SalvarPagamento()
        {
            List<Entidade_RecebCaixa> ListRecebCaixa = new List<Entidade_RecebCaixa>();

            Entidade_RecebCaixa EntRecebCaixa;
            MRecebCaixa = new RecebCaixa();

            var dtReceb = DateTime.Now;

            for (int i = 0; i < grdrecebido.Rows.Count; i++)
            {
                EntRecebCaixa = new Entidade_RecebCaixa();
                EntRecebCaixa.IdPedido = Convert.ToInt32(lblID.Text);
                if(cboBandeiras.Visible == true)
                    EntRecebCaixa.IdCartaoCredito = Convert.ToInt32(cboBandeiras.SelectedValue);
                EntRecebCaixa.ValorReceb = Convert.ToDouble(grdrecebido.Rows[i].Cells[1].Value.ToString().Replace(".", ""));
                EntRecebCaixa.DtReceb = dtReceb;
                ListRecebCaixa.Add(EntRecebCaixa);
            }

            if (MRecebCaixa.ReceberPagamento(ListRecebCaixa))
            {
                return true;
            }
            else
            {
                return false;
            }   
        }
        void LimparCampos()
        {
            grdrecebido.Rows.Clear();
            grdPedidosPagamento.Rows.Clear();
            txtPagamento.Text = "0,00";
            cboBandeiras.Visible = false;
            pnlPgMixto.Visible = false;
            lblDescFormaPagto.Text = string.Empty;
            lblID.Text = string.Empty;
            lblNmBandeiras.Visible = false;
            lblCliente.Text = string.Empty;
            lbltotal.Text = string.Empty;
        }
        void LimpaPanelReceb()
        {
            txtPagamento.Text = "0,00";
            cboBandeiras.Visible = false;
            pnlPgMixto.Visible = false;
            lblDescFormaPagto.Text = string.Empty;
            lblID.Text = string.Empty;
            lblNmBandeiras.Visible = false;
            lblCliente.Text = string.Empty;
            lbltotal.Text = string.Empty;
            grdrecebido.Rows.Clear();
        }

        private void OptDinheiro_Click(object sender, EventArgs e)
        {
            if (cboBandeiras.Visible == true)
            {
                cboBandeiras.Visible = false;
                lblNmBandeiras.Visible = false;
            }
        }

        private void OptCartao_Click(object sender, EventArgs e)
        {
            if (cboBandeiras.Visible == false)
            {
                cboBandeiras.Visible = true;
                lblNmBandeiras.Visible = true;
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void TmPedido_Tick(object sender, EventArgs e)
        {
            CarregarPedidos();
        }
    }
}

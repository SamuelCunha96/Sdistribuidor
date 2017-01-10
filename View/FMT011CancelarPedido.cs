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
    public partial class FMT011CancelarPedido : MetroForm
    {
        public FMT011CancelarPedido()
        {
            InitializeComponent();
        }

        FP002Cliente ObjParCliente;
        Participante objPart;
        Pedido ObjPedido;
        private void btnPesqCliente_Click(object sender, EventArgs e)
        {
            ObjParCliente = new FP002Cliente();

            if (ObjParCliente.ShowDialog() == DialogResult.OK)
            {
                TxtCodCliente.Text = ObjParCliente.ID.ToString();
                lblNmCliente.Text = ObjParCliente.Nome;
            }
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            ObjPedido = new Pedido();
            grdPedido.AutoGenerateColumns = false;
            if (TxtCodCliente.Text != string.Empty)
            {
                grdPedido.DataSource = ObjPedido.View_PesquisaPedido(Convert.ToInt32(TxtCodCliente.Text), dtpIni.Value, dtpFim.Value);
            }
            else
                PesquisaData();
        }

        private void TxtCodCliente_Leave(object sender, EventArgs e)
        {
            objPart = new Participante();

            if (TxtCodCliente.Text.Trim() != string.Empty)
            {
                int resultCliente;
                if (int.TryParse(TxtCodCliente.Text, out resultCliente))
                {
                    var DtResult = objPart.Pesquisa(Convert.ToInt32(TxtCodCliente.Text));

                    if (DtResult != null)
                    {
                        TxtCodCliente.Text = DtResult.id.ToString();
                        lblNmCliente.Text = DtResult.nome;
                        dtpIni.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Cliente não existe!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("O código digitado é inválido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TxtCodCliente.Text = string.Empty;
                }
            }
        }

        private void TxtCodCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!TxtCodCliente.Text.Contains(e.KeyChar.ToString()))
            {
                if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
                {
                    e.Handled = true;
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja cancelar o pedido N° " + grdPedido.Rows[grdPedido.CurrentRow.Index].Cells[0].Value.ToString() + " ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ObjPedido = new Pedido();
                if (grdPedido.Rows[grdPedido.CurrentRow.Index].Cells[5].Value.ToString() == "R")
                {
                    if (MessageBox.Show("O Pedido está associado a um pagamento, deseja continuar??", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (ObjPedido.CancelarPedido(Convert.ToInt32(grdPedido.Rows[grdPedido.CurrentRow.Index].Cells[0].Value.ToString()), true))
                        {
                            MessageBox.Show("Pedido cancelado com sucesso!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            PesquisaData();
                        }
                        else
                        {
                            MessageBox.Show("Ocorreu um erro contate ao suporte técnico!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    if (ObjPedido.CancelarPedido(Convert.ToInt32(grdPedido.Rows[grdPedido.CurrentRow.Index].Cells[0].Value.ToString())))
                    {
                        MessageBox.Show("Pedido cancelado com sucesso!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        PesquisaData();
                    }
                    else
                    {
                        MessageBox.Show("Ocorreu um erro contate ao suporte técnico!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        void PesquisaData()
        {
            grdPedido.DataSource = ObjPedido.View_PesquisaPedido(dtpIni.Value, dtpFim.Value);
        }
    }
}

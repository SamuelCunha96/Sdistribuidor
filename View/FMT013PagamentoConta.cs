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
    public partial class FMT013PagamentoConta : MetroForm
    {
        public FMT013PagamentoConta()
        {
            InitializeComponent();
        }

        ContaPagar ObjContaPagar;

        string StParcelaPesq = string.Empty;

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            PesquisaDados();
        }

        private void PesquisaDados()
        {
            ObjContaPagar = new ContaPagar();
            grdConta.AutoGenerateColumns = false;

            StParcelaPesq = CboStPagamento.SelectedIndex == 0 ? "A" : "P";

            grdConta.DataSource = ObjContaPagar.Pesquisa(DtpIni.Value, DtpFim.Value, StParcelaPesq);
        }

        private void BtnSelecionar_Click(object sender, EventArgs e)
        {
            lblConta.Text = grdConta.Rows[grdConta.CurrentRow.Index].Cells[0].Value.ToString();
            lblDocumento.Text = grdConta.Rows[grdConta.CurrentRow.Index].Cells[1].Value.ToString();
            lblFornecedor.Text = grdConta.Rows[grdConta.CurrentRow.Index].Cells[2].Value.ToString();
            lblVencimento.Text = Convert.ToDateTime(grdConta.Rows[grdConta.CurrentRow.Index].Cells[4].Value).ToShortDateString();
            lblGruFinanceiro.Text = grdConta.Rows[grdConta.CurrentRow.Index].Cells[5].Value.ToString();
            tbDados.SelectTab(TpPagamento);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (StParcelaPesq == "A")
            {
                if (MessageBox.Show("Deseja Confirmar recebimento?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ObjContaPagar = new ContaPagar();
                    string MsgErro = string.Empty;

                    if (ObjContaPagar.Pagamento(Convert.ToInt32(lblConta.Text), out MsgErro))
                    {
                        MessageBox.Show("Pagamento realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        LimpaCampos();
                        PesquisaDados();
                        tbDados.SelectTab(tpLista);
                    }
                    else
                    {
                        MessageBox.Show("Ocorreu um erro:\n" + MsgErro, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
            }
            else
            {
                if (MessageBox.Show("Deseja estornar recebimento?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ObjContaPagar = new ContaPagar();
                    string MsgErro = string.Empty;

                    if (ObjContaPagar.Estornar(Convert.ToInt32(lblConta.Text), out MsgErro))
                    {
                        MessageBox.Show("Pagamento estornado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        LimpaCampos();
                        PesquisaDados();
                        tbDados.SelectTab(tpLista);
                    }
                    else
                    {
                        MessageBox.Show("Ocorreu um erro:\n" + MsgErro, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
            }
        }

        void LimpaCampos()
        {
            lblConta.Text = string.Empty;
            lblDocumento.Text = string.Empty;
            lblFornecedor.Text = string.Empty;
            lblVencimento.Text = string.Empty;
            lblGruFinanceiro.Text = string.Empty;
        }

        private void FMT013PagamentoConta_Load(object sender, EventArgs e)
        {
            CboStPagamento.SelectedIndex = 0;
        }
    }
}

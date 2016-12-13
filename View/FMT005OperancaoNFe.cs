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
using Sdistribuidor.Relatorio;

namespace Sdistribuidor.View
{
    public partial class FMT005OperancaoNFe : Form
    {
        public FMT005OperancaoNFe()
        {
            InitializeComponent();
        }

        NotaFiscal ObjNotaFiscal;
        void PesquisaDados()
        {
            tmNFe.Enabled = false;
            string vrSql = string.Empty;
            DataTable DtRet;
            ObjNotaFiscal = new NotaFiscal();

            if (rbDtEmissao.Checked)
            {
                vrSql = "dtemissao between '" + string.Format("{0:dd/MM/yyyy}", dtpIni.Value) + " 00:00:00' AND '" + string.Format("{0:dd/MM/yyyy}", dtpFim.Value) + " 23:59:59'";
            }
            else if (rbCliente.Checked)
                vrSql = "p.nome like '%" + TxtPesquisa.Text + "%'";

            if (chkAnalise.Checked)
                vrSql += " AND (CdRetorno IS NULL OR CdRetorno IS NOT NULL OR CdRetorno = 225";
            if (ChkAprovada.Checked)
                vrSql += " OR CdRetorno =100";
            if (chkCancelada.Checked)
                vrSql += " OR CdRetorno =101";
            if (chkInutilizada.Checked)
                vrSql += " OR CdRetorno =102";

            vrSql += ")";
            DtRet = ObjNotaFiscal.PesquisaNFe(vrSql);
            grdNFe.Rows.Clear();
            if (DtRet.Rows.Count > 0)
            {
                for (int i = 0; i < DtRet.Rows.Count; i++)
                {
                    grdNFe.Rows.Add(DtRet.Rows[i]["serienf"].ToString(), DtRet.Rows[i]["nrnf"], DtRet.Rows[i]["nome"].ToString(), DtRet.Rows[i]["dtemissao"].ToString(), DtRet.Rows[i]["vltotal"], DtRet.Rows[i]["txchacessonfe"].ToString(), DtRet.Rows[i]["cdretorno"]);
                }
            }
            tmNFe.Enabled = true;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            PesquisaDados();
        }

        private void rbDtEmissao_Click(object sender, EventArgs e)
        {
            TxtPesquisa.Visible = false;
            pnlData.Visible = true;
            BtnAdd.Location = new Point(245, 39);
        }

        private void rbCliente_Click(object sender, EventArgs e)
        {
            TxtPesquisa.Visible = true;
            pnlData.Visible = false;
            BtnAdd.Location = new Point(522, 34);
        }

        private void tmNFe_Tick(object sender, EventArgs e)
        {
            PesquisaDados();
        }

        private void grdNFe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tmNFe.Enabled = false;
            string retMsgErro;
            if (e.ColumnIndex == 7)
            {
                this.Cursor = Cursors.WaitCursor;
                FRDanfe ObjForm = new FRDanfe();
                ObjForm.Loja = 1;
                ObjForm.NrNFe = Convert.ToInt32(grdNFe.Rows[e.RowIndex].Cells[1].Value.ToString());
                ObjForm.NmSerieNFe = grdNFe.Rows[e.RowIndex].Cells[0].Value.ToString();

                ObjForm.Show();

                this.Cursor = Cursors.Default;
                tmNFe.Enabled = true;
            }
            else if (e.ColumnIndex == 8)
            {
                if (!ObjNotaFiscal.ConsultarEnvioCancelamento(1, Convert.ToInt32(grdNFe.Rows[e.RowIndex].Cells[1].Value.ToString()), grdNFe.Rows[e.RowIndex].Cells[0].Value.ToString()))
                {
                    if (MessageBox.Show("Deseja CANCELAR a nota fiscal N°" + grdNFe.Rows[e.RowIndex].Cells[1].Value.ToString() + " ?", "Cancelamento", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (ObjNotaFiscal.CancelarNFe(1, Convert.ToInt32(grdNFe.Rows[e.RowIndex].Cells[1].Value.ToString()), grdNFe.Rows[e.RowIndex].Cells[0].Value.ToString(), out retMsgErro))
                        {
                            MessageBox.Show("Solicitação de cancelamento enviada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            tmNFe.Enabled = true;
                        }
                    }
                }
                else
                {
                    var RetCancelamento = ObjNotaFiscal.ConsultarRetornoCancelamento(1, Convert.ToInt32(grdNFe.Rows[e.RowIndex].Cells[1].Value.ToString()), grdNFe.Rows[e.RowIndex].Cells[0].Value.ToString());
                    if (RetCancelamento ==578 )
                    {
                        var DtRet = ObjNotaFiscal.ConsultarCancelamento(1, Convert.ToInt32(grdNFe.Rows[e.RowIndex].Cells[1].Value.ToString()), grdNFe.Rows[e.RowIndex].Cells[0].Value.ToString());

                        dtpDataProcessamento.Value = Convert.ToDateTime(DtRet.Rows[0][0]);

                        for (int i = 0; i < DtRet.Rows.Count; i++)
                        {
                            grdCancelamento.Rows.Add(grdNFe.Rows[e.RowIndex].Cells[0].Value, Convert.ToInt32(grdNFe.Rows[e.RowIndex].Cells[1].Value.ToString()), DtRet.Rows[i][0], DtRet.Rows[i][1]);
                        }

                        pnlCancelamento.Visible = true;
                    }
                    else if (RetCancelamento != 0)
                    {
                        MessageBox.Show("Cancelamento com retorno "+ RetCancelamento +", contate ao Administrador!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tmNFe.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Já existe uma Solicitação de cancelamento para esta nota fiscal!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tmNFe.Enabled = true;
                    }
                }
            }
            else if (e.ColumnIndex == 9)
            {
                if (!ObjNotaFiscal.ConsultarEnvioCancelamento(1, Convert.ToInt32(grdNFe.Rows[e.RowIndex].Cells[1].Value.ToString()), grdNFe.Rows[e.RowIndex].Cells[0].Value.ToString()))
                {
                    if (grdNFe.Rows[e.RowIndex].Cells[6].Value.ToString() == string.Empty || grdNFe.Rows[e.RowIndex].Cells[6].Value.ToString() == "225")
                    {
                        if (MessageBox.Show("Deseja INUTILIZAR a nota fiscal N°" + grdNFe.Rows[e.RowIndex].Cells[1].Value.ToString() + " ?", "Cancelamento", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            if (ObjNotaFiscal.InutilizacaoNFe(1, Convert.ToInt32(grdNFe.Rows[e.RowIndex].Cells[1].Value.ToString()), grdNFe.Rows[e.RowIndex].Cells[0].Value.ToString(),55, out retMsgErro))
                            {
                                MessageBox.Show("Solicitação de INUTILIZAÇÃO enviada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            tmNFe.Enabled = true;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Já existe uma Solicitação de INUTILIZAÇÃO para esta nota fiscal!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tmNFe.Enabled = true;
                }
            }
        }

        private void btnSairPanelCancelamento_Click(object sender, EventArgs e)
        {
            pnlCancelamento.Visible = false;
            grdCancelamento.Rows.Clear();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            ObjNotaFiscal = new NotaFiscal();
            string retmsg;
            if (ObjNotaFiscal.CancelamentoAlteraDataProcessamento(1, grdCancelamento.Rows[0].Cells[0].Value.ToString(), Convert.ToInt32(grdCancelamento.Rows[0].Cells[1].Value),dtpDataProcessamento.Value, out retmsg))
            {
                MessageBox.Show("Alteração realizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                pnlCancelamento.Visible = false;
                grdCancelamento.Rows.Clear();
                tmNFe.Enabled = true;
            }
            else
            {
                MessageBox.Show("Erro:\n" + retmsg + ".\nContate ao Administrador.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                tmNFe.Enabled = true;
            }
        }
    }
}

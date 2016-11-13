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
    public partial class FMT005OperancaoNFe : Form
    {
        public FMT005OperancaoNFe()
        {
            InitializeComponent();
        }

        NotaFiscal ObjNotaFiscal;
        void PesquisaDados()
        {
            string vrSql = string.Empty;
            DataTable DtRet;
            ObjNotaFiscal = new NotaFiscal();

            if (rbDtEmissao.Checked)
            {
                vrSql = "dtemissao between '"+ string.Format("{0:dd/MM/yyyy}", dtpIni.Value) + " 00:00:00' AND '"+ string.Format("{0:dd/MM/yyyy}", dtpFim.Value) + " 23:59:59'";
            }
            else if (rbCliente.Checked)
                vrSql = "p.nome like '%" + TxtPesquisa.Text + "%'";

            if (chkAnalise.Checked)
                vrSql += " AND (CdRetorno IS NULL";
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
    }
}

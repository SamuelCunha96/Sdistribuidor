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
    public partial class FMT014CancelarConta : MetroForm
    {
        public FMT014CancelarConta()
        {
            InitializeComponent();
        }

        ContaPagar ObjContaPagar;

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja cancelar a conta:" + grdConta.Rows[grdConta.CurrentRow.Index].Cells[0].Value.ToString() + "\n" +
                                "Fornecedor :" + grdConta.Rows[grdConta.CurrentRow.Index].Cells[1].Value.ToString() + " ?", "Cancela", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
            {
                ObjContaPagar = new ContaPagar();
                string MsgErro = string.Empty;
                if (!ObjContaPagar.ExistePagamento(grdConta.Rows[grdConta.CurrentRow.Index].Cells[0].Value.ToString()))
                {
                    if (ObjContaPagar.Cancelar(Convert.ToInt32(grdConta.Rows[grdConta.CurrentRow.Index].Cells[3].Value.ToString()), grdConta.Rows[grdConta.CurrentRow.Index].Cells[0].Value.ToString(), out MsgErro))
                    {
                        MessageBox.Show("Cancelamento Realizado com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        ConsultaDados();
                    }
                }
                else
                {
                    MessageBox.Show("Existe parcelas pagas!", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    ConsultaDados();
                }
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ConsultaDados();
        }

        void ConsultaDados()
        {
            ObjContaPagar = new ContaPagar();
            grdConta.AutoGenerateColumns = false;
            grdConta.DataSource = ObjContaPagar.DocumentosEmAberto(DtpIni.Value, DtpFim.Value);
        }

        private void FMT014CancelarConta_Load(object sender, EventArgs e)
        {
            
        }
    }
}

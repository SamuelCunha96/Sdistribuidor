using Sdistribuidor.Relatorio;
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
    public partial class FMenu : Form
    {
        public FMenu()
        {
            InitializeComponent();
        }

        private void btnGrupo_Click(object sender, EventArgs e)
        {
            FC002Grupo ObjForm = new FC002Grupo();
            ObjForm.MdiParent = this;
            ObjForm.Show();
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            FC003Produto ObjForm = new FC003Produto();
            ObjForm.MdiParent = this;
            ObjForm.Show();
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            FMP001Pedido ObjForm = new FMP001Pedido();
            ObjForm.MdiParent = this;
            ObjForm.Show();
        }

        private void btnPagamento_Click(object sender, EventArgs e)
        {
            FMT002Pagamento ObjForm = new FMT002Pagamento();
            ObjForm.MdiParent = this;
            ObjForm.Show();
        }

        private void FMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnNotaFiscal_Click(object sender, EventArgs e)
        {
            FMT003NotaFiscal ObjForm = new FMT003NotaFiscal();
            ObjForm.MdiParent = this;
            ObjForm.Show();
        }

        private void btnAux_Click(object sender, EventArgs e)
        {
            FUTabelasAux ObjForm = new FUTabelasAux();
            ObjForm.MdiParent = this;
            ObjForm.Show();
        }

        private void btnLoja_Click(object sender, EventArgs e)
        {
            FC001Empresa ObjForm = new FC001Empresa();
            ObjForm.MdiParent = this;
            ObjForm.Show();
        }

        private void btnParticipante_Click(object sender, EventArgs e)
        {
            FC006Participante ObjForm = new FC006Participante();
            ObjForm.MdiParent = this;
            ObjForm.Show();
        }

        private void btnNFeOutras_Click(object sender, EventArgs e)
        {
            FMT004NotaFiscalDev ObjForm = new FMT004NotaFiscalDev();
            ObjForm.MdiParent = this;
            ObjForm.Show();
        }
        
        private void btnListarNFe_Click(object sender, EventArgs e)
        {
            FMT005OperancaoNFe ObjForm = new FMT005OperancaoNFe();
            ObjForm.MdiParent = this;
            ObjForm.Show();
        }

        private void btnDanfe_Click(object sender, EventArgs e)
        {
            FRDanfe ObjRelatorio = new FRDanfe();
            ObjRelatorio.MdiParent = this;
            ObjRelatorio.Show();
        }
    }
}

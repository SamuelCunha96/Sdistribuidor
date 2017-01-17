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
            
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            
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

        private void btnManifestacao_Click(object sender, EventArgs e)
        {
            FMT006Manifestacao ObjManifestação = new FMT006Manifestacao();
            ObjManifestação.MdiParent = this;
            ObjManifestação.Show();
        }

        private void btnNfEntradaXml_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            FMT009MovEstoque ObjMovEstoque = new FMT009MovEstoque();
            ObjMovEstoque.MdiParent = this;
            ObjMovEstoque.Show();

        }

        private void btnMovEstoque_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnRelatorioPedido_Click(object sender, EventArgs e)
        {
            
        }

        private void TSM001CadastroGrupo_Click(object sender, EventArgs e)
        {
            FC002Grupo ObjForm = new FC002Grupo();
            ObjForm.MdiParent = this;
            ObjForm.Show();
        }

        private void TSM002CadastroProduto_Click(object sender, EventArgs e)
        {
            FC003Produto ObjForm = new FC003Produto();
            ObjForm.MdiParent = this;
            ObjForm.Show();
        }

        private void TSM003CadastroParticipante_Click(object sender, EventArgs e)
        {
            FC006Participante ObjForm = new FC006Participante();
            ObjForm.MdiParent = this;
            ObjForm.Show();
        }

        private void TSM001Movimento001Pedido_Click(object sender, EventArgs e)
        {
            FMP001Pedido ObjForm = new FMP001Pedido();
            ObjForm.MdiParent = this;
            ObjForm.Show();
        }

        private void TSM001Movimento002Cancelar_Click(object sender, EventArgs e)
        {
            FMT011CancelarPedido ObjFormCancelar = new FMT011CancelarPedido();
            ObjFormCancelar.MdiParent = this;
            ObjFormCancelar.Show();
        }

        private void TSM002Caixa002Pagamento_Click(object sender, EventArgs e)
        {
            FMT002Pagamento ObjForm = new FMT002Pagamento();
            ObjForm.MdiParent = this;
            ObjForm.Show();
        }

        private void TSM003Estoque001Consulta_Click(object sender, EventArgs e)
        {
            FMT009MovEstoque ObjMovEstoque = new FMT009MovEstoque();
            ObjMovEstoque.MdiParent = this;
            ObjMovEstoque.Show();
        }

        private void TSM003Estoque002Movimentar_Click(object sender, EventArgs e)
        {
            FMT010TransacaoMovEstoque ObjTransMovEstoque = new FMT010TransacaoMovEstoque();
            ObjTransMovEstoque.MdiParent = this;
            ObjTransMovEstoque.Show();
        }

        private void TSM001NotaFiscalManifestar_Click(object sender, EventArgs e)
        {
            FMT006Manifestacao ObjManifestação = new FMT006Manifestacao();
            ObjManifestação.MdiParent = this;
            ObjManifestação.Show();
        }

        private void TSM002NotaFiscalEntrada001Cadastrar_Click(object sender, EventArgs e)
        {
            FMT007NotaFiscalEntrada ObjNotaFiscalEntradaXml = new FMT007NotaFiscalEntrada();
            ObjNotaFiscalEntradaXml.MdiParent = this;
            ObjNotaFiscalEntradaXml.Show();
        }

        private void TSM003NotaFiscalSaida001Pedido_Click(object sender, EventArgs e)
        {
            FMT003NotaFiscal ObjForm = new FMT003NotaFiscal();
            ObjForm.MdiParent = this;
            ObjForm.Show();
        }

        private void TSM003NotaFiscalSaida002Outras_Click(object sender, EventArgs e)
        {
            FMT004NotaFiscalDev ObjForm = new FMT004NotaFiscalDev();
            ObjForm.MdiParent = this;
            ObjForm.Show();
        }

        private void TSM003NotaFiscalSaida002ListarNFe_Click(object sender, EventArgs e)
        {
            FMT005OperancaoNFe ObjForm = new FMT005OperancaoNFe();
            ObjForm.MdiParent = this;
            ObjForm.Show();
        }

        private void TSM002ConfigTabAux_Click(object sender, EventArgs e)
        {
            FUTabelasAux ObjForm = new FUTabelasAux();
            ObjForm.MdiParent = this;
            ObjForm.Show();
        }

        private void TSM001ConfigLoja_Click(object sender, EventArgs e)
        {
            FC001Empresa ObjForm = new FC001Empresa();
            ObjForm.MdiParent = this;
            ObjForm.Show();
        }

        private void TSM001RelatorioPedido001ListaPedido_Click(object sender, EventArgs e)
        {
            FR003Venda ObjForm = new FR003Venda();
            ObjForm.MdiParent = this;
            ObjForm.Show();
        }

        private void TSM001RelatorioNotaFiscal001ListaNFe_Click(object sender, EventArgs e)
        {
            FR004NfEmitidas ObjForm = new FR004NfEmitidas();
            ObjForm.MdiParent = this;
            ObjForm.Show();
        }

        private void TSM001RelatorioPedido002CurvaABC_Click(object sender, EventArgs e)
        {
            FR005CurvaABC ObjForm = new FR005CurvaABC();
            ObjForm.MdiParent = this;
            ObjForm.Show();
        }

        private void TSM004Financeiro001ContaPagar001Nova_Click(object sender, EventArgs e)
        {
            FMT012ContaPagar ObjForm = new FMT012ContaPagar();
            ObjForm.MdiParent = this;
            ObjForm.Show();
        }

        private void grupoFinanceiroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FC004GrupoFinanceiro ObjForm = new FC004GrupoFinanceiro();
            ObjForm.MdiParent = this;
            ObjForm.Show();
        }
    }
}

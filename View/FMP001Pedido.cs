using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sdistribuidor.Entidade;
using Sdistribuidor.Model;

namespace Sdistribuidor.View
{
    public partial class FMP001Pedido : Form
    {
        public FMP001Pedido()
        {
            InitializeComponent();
        }

        Produtos objProd = new Produtos();
        ProdutoUnidade objProdUnd;
        Participante objPart;
        Pedido objPedido;
        Unidade objUnidade;
        MovimentacaoEstoque ObjMovEstoque;

        Entidade_Pedido EntPedido;
        Entidade_ItemPedido EntItemPedido;

        List<Entidade_Participante> LsPartipante;

        private void FMP001Pedido_Load(object sender, EventArgs e)
        {
            PreencherCombos();
            TxtIdCliente.Focus();
            
        }
        private void TxtCodProd_Leave(object sender, EventArgs e)
        {
            if (TxtCodProd.Text.Trim() != string.Empty && TxtCodProd.Text.Trim() != "0")
            {
                var RetEnt = objProd.Pesquisa(long.Parse(TxtCodProd.Text));
                if (RetEnt != null)
                {
                    PreencherDados(RetEnt);
                    CarregarComboUnidConversao(Convert.ToInt32(RetEnt.IdProduto));
                    CalcularTotalItem();
                    TxtQtd.Focus();
                }
                else
                {
                    MessageBox.Show("Produto não encontrado ou não cadastrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //TxtID.Focus();
                }
            }
        }
        void PreencherCombos()
        {
            //ucVendedor1.PreencherVendedor();
            //ucParticipante1.CarregarParticipante();
            CarregarCliente();
            ucFormaPagto1.CarregarFormaPagamento();
        }

        void CarregarCliente()
        {
            LsPartipante = new List<Entidade_Participante>();
            //objPart = new Participante();
            //AutoCompleteStringCollection dadosLista = new AutoCompleteStringCollection();

            //LsPartipante = objPart.Pesquisa();

            //foreach (var item in LsPartipante)
            //{
            //    dadosLista.Add(item.ParticipanteNomeCpfCnpj);
            //}
            //TxtCliente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //TxtCliente.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //TxtCliente.AutoCompleteCustomSource = dadosLista;
            
        }
        int IdParticipante()
        {
            foreach (var item in LsPartipante)
            {
                if (TxtCliente.Text.ToUpper() == item.ParticipanteNomeCpfCnpj.ToUpper())
                {
                    return item.id;
                }
            }
            return 0;
        }

        public void PreencherDados(Entidade_Produto obj)
        {
            objPart = new Participante();
            if (obj != null)
            {
                lblDesc.Text = obj.NmProduto;

                //var dtPart = objPart.Pesquisa(ucParticipante1.GetParticipante.id);
                //if (dtPart.flcomercio == true)
                //    TxtVlUnitario.Text = string.Format("{0:N2}", obj.VlPreco2);
                //else
                TxtVlUnitario.Text = string.Format("{0:N2}", obj.VlPreco);
                lblUnid.Text = obj.Unidade.CdUnidade;
                LblQtdConv.Text = "0.00";
            }
            else
                MessageBox.Show("Produto não encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        void CarregarComboUnidConversao(int Codigo)
        {
            objProdUnd = new ProdutoUnidade();
            cboUnidConv.DisplayMember = "UndProd";
            cboUnidConv.ValueMember = "UndProd";
            cboUnidConv.DataSource = objProdUnd.Pesquisa(Codigo);
        }
        void PesquisaDados()
        {
            PreencherDados(objProd.Pesquisa(long.Parse( TxtCodProd.Text)));
        }
        void CalcularTotalItem()
        {
            double QtItem = 0;
            double VlUnit = 0;

            QtItem = Convert.ToDouble(TxtQtd.Text.Replace(".", ""));
            VlUnit = Convert.ToDouble(TxtVlUnitario.Text.Replace(".", ""));
            TxtSubTotal.Text = string.Format("{0:N2}", (QtItem * VlUnit));
            TxtTotal.Text = string.Format("{0:N2}", (QtItem * VlUnit));
            CalcularDesconto();
        }
        void CalcularDesconto()
        {
            if (TxtDesconto.Text != string.Empty)
            {
                if (Convert.ToDouble(TxtQtd.Text) > 0 && Convert.ToDouble(TxtDesconto.Text) > 0)
                {
                    TxtTotal.Text = string.Format("{0:N2}", (Convert.ToDouble(TxtQtd.Text) * Convert.ToDouble(TxtVlUnitario.Text)) - ((Convert.ToDouble(TxtQtd.Text) * Convert.ToDouble(TxtVlUnitario.Text)) * (Convert.ToDouble(TxtDesconto.Text) / 100)));
                }
                else
                {
                    TxtSubTotal.Text = string.Format("{0:N2}", (Convert.ToDouble(TxtQtd.Text) * Convert.ToDouble(TxtVlUnitario.Text)));
                    TxtTotal.Text = string.Format("{0:N2}", (Convert.ToDouble(TxtQtd.Text) * Convert.ToDouble(TxtVlUnitario.Text)));
                }
            }
        }
        void CalcularTotalGeral()
        {
            double total = 0;
            double subtotal = 0;
            for (int i = 0; i < grdItem.Rows.Count; i++)
            {
                subtotal += Convert.ToDouble(grdItem.Rows[i].Cells[8].Value.ToString().Replace(".", ""));
                total += Convert.ToDouble(grdItem.Rows[i].Cells[9].Value.ToString().Replace(".", ""));
            }
            lblSubTotal.Text = string.Format("{0:N2}", subtotal);
            lblTotaGeral.Text = string.Format("{0:N2}", total);

        }

        private void TxtQtd_TextChanged(object sender, EventArgs e)
        {
            if (TxtQtd.Text != string.Empty)
            {
                //if (Convert.ToDouble(TxtQtd.Text) != 0)
                //{
                if (TxtQtd.Text == ",")
                {
                    TxtQtd.Text = "0";
                }
                CalcularTotalItem();
                //}
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (ValidaEstoque())
            {
                double vlret = 0;
                var RetValor = double.TryParse(TxtQtd.Text, out vlret);
                if (RetValor == true)
                {
                    if (Convert.ToDouble(TxtQtd.Text) > 0)
                    {
                        CalcularQuantidadeConversao();
                    }
                }
                CalcularTotalItem();
                AdicionarGridProduto();
            }
        }
        public void LimpaCamposAddGrid()
        {
            TxtCodProd.Text = string.Empty;
            lblDesc.Text = string.Empty;
            lblUnid.Text = string.Empty;
            lblUnid.Text = string.Empty;
            LblQtdConv.Text = string.Empty;
            LblQtdConv.Text = string.Empty;
            TxtQtd.Text = "0.0000";
            TxtDesconto.Text = "0,00";
            TxtSubTotal.Text = "0,00";
            TxtTotal.Text = "0,00";
            TxtVlUnitario.Text = "0,00";
            cboUnidConv.DataSource = null;
        }
        void AdionarGrid()
        {
            grdItem.Rows.Add(TxtCodProd.Text, lblDesc.Text, lblUnid.Text, TxtQtd.Text, cboUnidConv.Text, LblQtdConv.Text, TxtVlUnitario.Text, TxtDesconto.Text, Convert.ToDouble(TxtSubTotal.Text.Replace(".", "")), Convert.ToDouble(TxtTotal.Text.Replace(".", "")));
        }

        bool ValidaEstoque()
        {
            ObjMovEstoque = new MovimentacaoEstoque();

            var retQtEstoque = ObjMovEstoque.EstoqueQuantidade(Convert.ToInt32(TxtCodProd.Text));
            if (retQtEstoque < 0)
            {
                MessageBox.Show("Estoque atual é negativo para esse produto!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            else if (retQtEstoque == 0)
            {
                MessageBox.Show("Estoque atual é Zerado para esse produto!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            else if (retQtEstoque < Convert.ToDecimal(TxtQtd.Text.Replace(".", "")))
            {
                MessageBox.Show("A quantidade informada é maior que a quantidade de estoque atual!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            else
                return true;
        }

        bool ValidaAdicionar()
        {
            int RetCod;
            if (int.TryParse(TxtCodProd.Text, out RetCod))
            {
                for (int i = 0; i < grdItem.Rows.Count; i++)
                {
                    if(long.Parse(TxtCodProd.Text)== long.Parse(grdItem.Rows[i].Cells[0].Value.ToString()))
                    {
                        MessageBox.Show("Código do produto já foi incluido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TxtCodProd.Focus();
                        return false;
                    }
                }
                
                if (TxtCodProd.Text == string.Empty)
                {
                    MessageBox.Show("Código do produto obrigatorio.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TxtCodProd.Focus();
                    return false;
                }
                else if (Convert.ToDouble(TxtQtd.Text) == 0)
                {
                    MessageBox.Show("Quantidade necessaria.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TxtQtd.Focus();
                    return false;
                }
                else
                    return true;
            }
            else
            {
                MessageBox.Show("Código do produto digitado é inválido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }

        private void TxtID_EditValueChanged(object sender, EventArgs e)
        {

        }

        public bool ValidaCampos()
        {
            if (!ucFormaPagto1.ValidaCampos())
                return false;
            else if (TxtCliente.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Informe o cliente para finalizar o pedido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            //else if (!ucVendedor1.ValidaCampos())
            //    return false;
            else if (grdItem.Rows.Count == 0)
            {
                MessageBox.Show("Informe um produto para finalizar a venda!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
                return true;
        }
        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void grdItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                if (MessageBox.Show("Deseja excluir o produto," + grdItem.Rows[grdItem.CurrentRow.Index].Cells[0].Value.ToString() + "?", "Aténção", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    grdItem.Rows.RemoveAt(grdItem.CurrentRow.Index);
                    CalcularTotalGeral();
                }
            }
        }

        private void cboUnidConv_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CalcularQuantidadeConversao();
        }

        private void TxtQtd_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                BtnAdd.Focus();
            }
        }
        void CalcularQuantidadeConversao()
        {
            objProdUnd = new ProdutoUnidade();
            if (TxtQtd.Text != string.Empty)
            {
                if (Convert.ToDouble(TxtQtd.Text) > 0)
                {
                    if (lblUnid.Text != cboUnidConv.Text)
                    {
                        var ObjUnidvlfator = objProdUnd.Pesquisa(Convert.ToInt32(TxtCodProd.Text), cboUnidConv.Text);

                        if (ObjUnidvlfator == null)
                        {
                            MessageBox.Show("Fator de Conversão zerado, por favor altere no cadastro do produto.", "Aténção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpaCamposAddGrid();
                            TxtCodProd.Focus();
                        }
                        else
                        {
                            LblQtdConv.Text = string.Format("{0:N4}", Convert.ToDouble(TxtQtd.Text) * ObjUnidvlfator.vlfatorconv);
                        }
                    }
                }
            }
        }

        private void TxtQtd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!TxtQtd.Text.Contains(e.KeyChar.ToString()))
            {
                if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
                {
                    e.Handled = true;
                }
            }
            else if (e.KeyChar.ToString().Trim() == ",")
                e.Handled = true;
        }

        private void TxtQtd_KeyUp(object sender, KeyEventArgs e)
        {
            double vlret = 0;
            var RetValor = double.TryParse(TxtQtd.Text, out vlret);
            if (RetValor == true)
            {
                if (Convert.ToDouble(TxtQtd.Text) > 0)
                {
                    CalcularQuantidadeConversao();
                }
            }
        }

        private void cboUnidConv_SelectedValueChanged(object sender, EventArgs e)
        {
            CalcularQuantidadeConversao();
        }

        void LimpaCampos()
        {
            grdItem.Rows.Clear();
            LimpaCamposAddGrid();
            PreencherCombos();
            CarregarCliente();
            lblSubTotal.Text = "0,00";
            lblTotaGeral.Text = "0,00";
            TxtCliente.Text = string.Empty;
            

        }

        private void TxtDesconto_TextChanged(object sender, EventArgs e)
        {
            CalcularDesconto();
        }

        private void btnPesquisarProduto_Click(object sender, EventArgs e)
        {
            FP001Produto ObjPesquisar = new FP001Produto();
            if (ObjPesquisar.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                TxtCodProd.Text = ObjPesquisar.ID.ToString();
                CarregarComboUnidConversao(Convert.ToInt32(ObjPesquisar.ID));
                PesquisaDados();
                TxtQtd.Focus();
            }
        }

        private void btnPesquisarCliente_Click(object sender, EventArgs e)
        {
            FP002Cliente ObjPesquisar = new FP002Cliente();

            if (ObjPesquisar.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                TxtIdCliente.Text = Convert.ToString(ObjPesquisar.ID);
                TxtCliente.Text = ObjPesquisar.Nome;
                TxtCodProd.Focus();
            }

        }
        void AdicionarGridProduto()
        {
            if (ValidaAdicionar())
            {
                AdionarGrid();
                CalcularTotalGeral();
                LimpaCamposAddGrid();
                TxtCodProd.Focus();
            }
        }

        private void TxtIdCliente_Leave(object sender, EventArgs e)
        {
            objPart = new Participante();

            int resultCliente;
            if(int.TryParse(TxtIdCliente.Text, out resultCliente))
            {
                var DtResult = objPart.Pesquisa(Convert.ToInt32(TxtIdCliente.Text));

                if(DtResult != null)
                {
                    TxtIdCliente.Text = DtResult.id.ToString();
                    TxtCliente.Text = DtResult.nome;
                    TxtCodProd.Focus();
                }
                else
                {
                    MessageBox.Show("Cliente não existe!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("O código digitado é inválido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtIdCliente.Text = string.Empty;
            }
        }

        private void TxtQtd_Leave(object sender, EventArgs e)
        {
            double vlret = 0;
            var RetValor = double.TryParse(TxtQtd.Text, out vlret);
            if (RetValor == true)
            {
                if (Convert.ToDouble(TxtQtd.Text) > 0)
                {
                    CalcularQuantidadeConversao();
                }
            }
            BtnAdd.Focus();
        }

        private void TxtCodProd_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                TxtQtd.Focus();
            }
        }

        private void BtnConfirmar_KeyUp(object sender, KeyEventArgs e)
        {
              
        }

        private void FMP001Pedido_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F9)
            {
                Salvar();
            }
        }

        void Salvar()
        {
            objPedido = new Pedido();
            EntPedido = new Entidade_Pedido();
            objProd = new Produtos();
            objUnidade = new Unidade();
            objPart = new Participante();

            List<Entidade_ItemPedido> ArrayListItemPedido = new List<Entidade_ItemPedido>();

            if (ValidaCampos())
            {
                EntPedido.id_formpagto = ucFormaPagto1.GetFormaPagamento;
                EntPedido.id_participante = objPart.Pesquisa(Convert.ToInt32(TxtIdCliente.Text));
                EntPedido.stentrega = "E";
                EntPedido.stpedido = "A";
                EntPedido.vl_pedido = Convert.ToDouble(lblTotaGeral.Text.Replace(".", ""));
                EntPedido.dt_pedido = DateTime.Now;
                EntPedido.obspedido = "nada";
                EntPedido.ItemPedidos = ArrayListItemPedido;

                for (int i = 0; i < grdItem.Rows.Count; i++)
                {
                    EntItemPedido = new Entidade_ItemPedido();
                    EntItemPedido.id_produto = objProd.Pesquisa(Convert.ToInt32(grdItem.Rows[i].Cells[0].Value));
                    EntItemPedido.Qt_Pedido = Convert.ToDouble(grdItem.Rows[i].Cells[3].Value.ToString().Replace(".", ""));
                    EntItemPedido.qt_pedido_conv = Convert.ToDouble(grdItem.Rows[i].Cells[5].Value.ToString().Replace(".", ""));
                    EntItemPedido.cdunidade_conv = grdItem.Rows[i].Cells[4].Value.ToString();
                    EntItemPedido.Vl_Unitario = Convert.ToDouble(grdItem.Rows[i].Cells[6].Value.ToString().Replace(".", ""));
                    EntItemPedido.Vl_Desconto = Convert.ToDouble(grdItem.Rows[i].Cells[7].Value.ToString().Replace(".", ""));
                    EntItemPedido.CdUnidade = objUnidade.Pesquisa(grdItem.Rows[i].Cells[2].Value.ToString());
                    ArrayListItemPedido.Add(EntItemPedido);
                }
                if (objPedido.Incluir(EntPedido))
                {
                    MessageBox.Show("Pedido realizado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpaCampos();
                    TxtIdCliente.Focus();
                }
            }
        }
    }
}

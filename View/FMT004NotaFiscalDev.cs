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
using Sdistribuidor.Entidade;
using Sdistribuidor.Control;

namespace Sdistribuidor.View
{
    public partial class FMT004NotaFiscalDev : Form
    {
        public FMT004NotaFiscalDev()
        {
            InitializeComponent();
        }

        Produtos objProd = new Produtos();
        ProdutoUnidade objProdUnd;
        Participante objPart;
        Unidade objUnidade;
        Cst ObjCst;
        UF ObjUf;
        Cfop ObjCfop;
        Loja ObjLoja;

        Entidade_TotaisNota EntTotal;

        C_NotaFiscal cNotaFiscal;

        Entidade_NotaFiscal EntNotaFiscal;
        SerieNotaFiscal mSerieNotaFiscal;
        NotaFiscal mNotaFiscal;

        private void btnParticipante_Click(object sender, EventArgs e)
        {
            ConsultarParticipante();
        }

        private void ConsultarParticipante()
        {
            FP002Cliente ObjPesquisar = new FP002Cliente();

            if (ObjPesquisar.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                lblID.Text = Convert.ToString(ObjPesquisar.ID);
                txtCodCliente.Text = Convert.ToString(ObjPesquisar.ID);
                lblCliente.Text = ObjPesquisar.Nome;
                lblUF.Text = ObjPesquisar.Uf;
                PesquisaLogradouroParticipante(ObjPesquisar.ID);

            }
        }

        void CarregarCombosICMS()
        {
            ObjCst = new Cst();

            cboTribIcms.DisplayMember = "descricao";
            cboTribIcms.ValueMember = "cst";
            cboTribIcms.DataSource = ObjCst.ICMS("T");
            
            cboTribIpi.DisplayMember = "descricao";
            cboTribIpi.ValueMember = "cst";
            cboTribIpi.DataSource = ObjCst.IPI();

            cboTribPis.DisplayMember = "descricao";
            cboTribPis.ValueMember = "cst";
            cboTribPis.DataSource = ObjCst.PIS();

            cboTribCofins.DisplayMember = "descricao";
            cboTribCofins.ValueMember = "cst";
            cboTribCofins.DataSource = ObjCst.COFINS();
        }

        private void btnTribOK_Click(object sender, EventArgs e)
        {
            if (ValidaGdTributacao())
            {
                lblTribIcms.Text = cboTribIcms.SelectedValue.ToString();
                lblTribIpi.Text = cboTribIpi.SelectedValue.ToString();
                lblTribPis.Text = cboTribPis.SelectedValue.ToString();
                lblTribCofins.Text = cboTribCofins.SelectedValue.ToString();
                gbTributacao.Visible = false;
            }
        }

        private void btnPesquisaItem_Click(object sender, EventArgs e)
        {
            PesquisarProduto();
        }

        void PesquisarProduto()
        {
            FP001Produto ObjPesquisar = new FP001Produto();
            if (ObjPesquisar.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (ObjPesquisar.NCM != string.Empty)
                {
                    TxtCodItem.Text = ObjPesquisar.ID.ToString();
                    lblNCM.Text = ObjPesquisar.NCM;
                    lblUnidade.Text = ObjPesquisar.Unidade;
                    CarregarComboUnidConversao(Convert.ToInt32(ObjPesquisar.ID));
                    PesquisaDados();
                    if (cboTipoNF.SelectedIndex == 1)
                    {
                        cboUndConv.Enabled = true;
                        txtVlUnitDev.Enabled = true;
                        txtQtdConv.Enabled = true;
                    }
                    txtQtd.Focus();
                }
                else
                {
                    MessageBox.Show("Produto sem NCM, por favor alter o cadastro do produto!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public void PreencherDados(Entidade_Produto obj)
        {
            objPart = new Participante();
            if (obj != null)
            {
                lblItemDesc.Text = obj.NmProduto;
                txtVlUnit.Text = string.Format("{0:N2}", obj.VlPreco);
                lblUnidade.Text = obj.Unidade.CdUnidade;
                txtQtdConv.Text = "0.00";
            }
            else
                MessageBox.Show("Produto não encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void PesquisaDados()
        {
            PreencherDados(objProd.Pesquisa(long.Parse(TxtCodItem.Text)));
        }
        void CarregarComboUnidConversao(int Codigo)
        {
            objProdUnd = new ProdutoUnidade();
            cboUndConv.DisplayMember = "UndProd";
            cboUndConv.ValueMember = "UndProd";
            cboUndConv.DataSource = objProdUnd.Pesquisa(Codigo);
        }

        private void txtQtd_KeyUp(object sender, KeyEventArgs e)
        {
            double vlret = 0;
            var RetValor = double.TryParse(txtQtd.Text, out vlret);
            if (RetValor == true)
            {
                if (Convert.ToDouble(txtQtd.Text) > 0)
                {
                    CalcularQuantidadeConversao();
                }
            }
        }
        void CalcularQuantidadeConversao()
        {
            objProdUnd = new ProdutoUnidade();
            if (txtQtd.Text != string.Empty)
            {
                if (Convert.ToDouble(txtQtd.Text) > 0)
                {
                    if (lblUnidade.Text != cboUndConv.Text)
                    {

                        var ObjUnidvlfator = objProdUnd.Pesquisa(Convert.ToInt32(TxtCodItem.Text), cboUndConv.Text);

                        if (ObjUnidvlfator == null)
                        {
                            MessageBox.Show("Fator de Conversão zerado, por favor altere no cadastro do produto.", "Aténção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            TxtCodItem.Focus();
                        }
                        else
                        {
                            txtQtdConv.Text = string.Format("{0:N4}", Convert.ToDouble(txtQtd.Text) * ObjUnidvlfator.vlfatorconv);
                        }
                    }
                }
            }
        }

        #region --------------- ENTER ---------------
        private void gbPnlProduto_Enter(object sender, EventArgs e)
        {
            TxtCodItem.Focus();
        }
        private void txtVlUnit_Enter(object sender, EventArgs e)
        {
            if (txtVlUnit.Text == "0,00")
            {
                LimpaTxtBox(txtVlUnit);
            }
        }
        private void txtVlUnitDev_Enter(object sender, EventArgs e)
        {
            if (txtVlUnitDev.Text == "0,00")
            {
                LimpaTxtBox(txtVlUnitDev);
            }
        }

        private void txtQtd_Enter(object sender, EventArgs e)
        {
            if (txtQtd.Text == "0,0000")
            {
                LimpaTxtBox(txtQtd);
            }
        }

        private void txtQtdConv_Enter(object sender, EventArgs e)
        {
            if (txtQtdConv.Text == "0,0000")
            {
                LimpaTxtBox(txtQtdConv);
            }
        }

        private void txtAliqIcms_Enter(object sender, EventArgs e)
        {
            if (txtAliqIcms.Text == "0,00")
            {
                LimpaTxtBox(txtAliqIcms);
            }
        }

        private void txtVlBCIcms_Enter(object sender, EventArgs e)
        {
            if (txtVlBCIcms.Text == "0,00")
            {
                LimpaTxtBox(txtVlBCIcms);
            }
        }

        private void txtVlIcms_Enter(object sender, EventArgs e)
        {
            if (txtVlIcms.Text == "0,00")
            {
                LimpaTxtBox(txtVlIcms);
            }
        }

        private void txtVlBcSub_Enter(object sender, EventArgs e)
        {
            if (txtVlBcSub.Text == "0,00")
            {
                LimpaTxtBox(txtVlBcSub);
            }
        }

        private void txtIcmsSub_Enter(object sender, EventArgs e)
        {
            if (txtIcmsSub.Text == "0,00")
            {
                LimpaTxtBox(txtIcmsSub);
            }
        }

        private void txtVlOutras_Enter(object sender, EventArgs e)
        {
            if (txtVlOutras.Text == "0,00")
            {
                LimpaTxtBox(txtVlOutras);
            }
        }

        private void txtVlSeguro_Enter(object sender, EventArgs e)
        {
            if (txtVlSeguro.Text == "0,00")
            {
                LimpaTxtBox(txtVlSeguro);
            }
        }

        private void txtFrete_Enter(object sender, EventArgs e)
        {
            if (txtFrete.Text == "0,00")
            {
                LimpaTxtBox(txtFrete);
            }
        }

        private void txtAliqPis_Enter(object sender, EventArgs e)
        {
            if (txtAliqPis.Text == "0,00")
            {
                LimpaTxtBox(txtAliqPis);
            }
        }

        private void txtVlPis_Enter(object sender, EventArgs e)
        {
            if (txtVlPis.Text == "0,00")
            {
                LimpaTxtBox(txtVlPis);
            }
        }

        private void txtAliqCofins_Enter(object sender, EventArgs e)
        {
            if (txtAliqCofins.Text == "0,00")
            {
                LimpaTxtBox(txtAliqCofins);
            }
        }

        private void txtVlCofins_Enter(object sender, EventArgs e)
        {
            if (txtVlCofins.Text == "0,00")
            {
                LimpaTxtBox(txtVlCofins);
            }
        }

        private void txtDesconto_Enter(object sender, EventArgs e)
        {
            if (txtDesconto.Text == "0,00")
            {
                LimpaTxtBox(txtDesconto);
            }
        }

        #endregion

        private void txtQtd_TextChanged(object sender, EventArgs e)
        {
            if (txtQtd.Text != string.Empty)
            {
                if (Convert.ToDecimal(txtQtd.Text) > 0)
                {
                    TotaisItem();
                }
            }
        }

        void LimpaTxtBox(object Txt)
        {
            ((TextBox)Txt).Text = string.Empty;
        }
        /// <summary>
        /// Formata campo de acordo com a nescidade
        /// </summary>
        /// <param name="Txt">Objeto a ser utilizado. Ex: TextBox</param>
        /// <param name="formato">Tipo de Formato por padrão N2</param>
        void FormataCampoTxtBox(object Txt, string formato = "N2")
        {
            ((TextBox)Txt).Text = string.Format("{0:" + formato + "}", Convert.ToDouble(((TextBox)Txt).Text.Replace(".", "")));
        }

        void TotalGeral()
        {
            decimal VlBaseIcms = 0, VlIcms = 0, VlBaseIcmsSub = 0,VlIcmsSub = 0, VlIpi = 0, VlPis = 0, VlCofins = 0, VlOutras = 0, VlFrete = 0, VlSeguro = 0, VlDesconto = 0, VlTotal = 0;
            

            if(grdProdutoNF.Rows.Count > 0)
            {
                for (int i = 0; i < grdProdutoNF.Rows.Count; i++)
                {
                    VlBaseIcms += Convert.ToDecimal(grdProdutoNF.Rows[i].Cells["ColVlBaseIcms"].Value.ToString().Replace(".", ""));
                    VlIcms += Convert.ToDecimal(grdProdutoNF.Rows[i].Cells["ColVlIcms"].Value.ToString().Replace(".", ""));
                    VlBaseIcmsSub += Convert.ToDecimal(grdProdutoNF.Rows[i].Cells["ColVlBaseIcmsSub"].Value.ToString().Replace(".", ""));
                    VlIcmsSub += Convert.ToDecimal(grdProdutoNF.Rows[i].Cells["ColVlIcmsSub"].Value.ToString().Replace(".", ""));
                    VlIpi += Convert.ToDecimal(grdProdutoNF.Rows[i].Cells["ColVlIpi"].Value.ToString().Replace(".", ""));
                    VlPis += Convert.ToDecimal(grdProdutoNF.Rows[i].Cells["ColVlPis"].Value.ToString().Replace(".", ""));
                    VlCofins += Convert.ToDecimal(grdProdutoNF.Rows[i].Cells["ColVlCofins"].Value.ToString().Replace(".", ""));
                    VlOutras += Convert.ToDecimal(grdProdutoNF.Rows[i].Cells["ColVlOutras"].Value.ToString().Replace(".", ""));
                    VlFrete += Convert.ToDecimal(grdProdutoNF.Rows[i].Cells["ColVlFrete"].Value.ToString().Replace(".", ""));
                    //VlSeguro += Convert.ToDecimal(grdProdutoNF.Rows[i].Cells["ColVlSeguro"].Value.ToString().Replace(".", ""));
                    VlDesconto += Convert.ToDecimal(grdProdutoNF.Rows[i].Cells["ColVlDesconto"].Value.ToString().Replace(".", ""));
                    VlTotal += Convert.ToDecimal(grdProdutoNF.Rows[i].Cells["ColVlTotal"].Value.ToString().Replace(".", ""));
                }

                lblTotVlBaseICms.Text = string.Format("{0:n2}", VlBaseIcms);
                lblTotVlIcms.Text = string.Format("{0:n2}", VlIcms);
                lblTotVlBaseIcmsSub.Text = string.Format("{0:n2}", VlBaseIcmsSub);
                lblTotVlIcmsSub.Text = string.Format("{0:n2}", VlIcmsSub);
                lblTotVlIpi.Text = string.Format("{0:n2}", VlIpi);
                lblTotVlPis.Text = string.Format("{0:n2}", VlPis);
                lblTotVlCofins.Text = string.Format("{0:n2}", VlCofins);
                lblTotVlOutDesp.Text = string.Format("{0:n2}", VlOutras);
                lblTotVlSeguro.Text = string.Format("{0:n2}", VlSeguro);
                lblTotVlDesc.Text = string.Format("{0:n2}", VlDesconto);
                lblTotVlTotal.Text = string.Format("{0:n2}", VlTotal);
            }
            else
            {
                lblTotVlBaseICms.Text = string.Format("{0:n2}", VlBaseIcms);
                lblTotVlIcms.Text = string.Format("{0:n2}", VlIcms);
                lblTotVlBaseIcmsSub.Text = string.Format("{0:n2}", VlBaseIcmsSub);
                lblTotVlIcmsSub.Text = string.Format("{0:n2}", VlIcmsSub);
                lblTotVlIpi.Text = string.Format("{0:n2}", VlIpi);
                lblTotVlPis.Text = string.Format("{0:n2}", VlPis);
                lblTotVlCofins.Text = string.Format("{0:n2}", VlCofins);
                lblTotVlOutDesp.Text = string.Format("{0:n2}", VlOutras);
                lblTotVlSeguro.Text = string.Format("{0:n2}", VlSeguro);
                lblTotVlDesc.Text = string.Format("{0:n2}", VlDesconto);
                lblTotVlTotal.Text = string.Format("{0:n2}", VlTotal);
            }
        }

        void TotaisItem()
        {
            cNotaFiscal = new C_NotaFiscal();
            EntTotal = new Entidade_TotaisNota();

            EntTotal.QtItem = Convert.ToDecimal(txtQtd.Text.Replace(".", ""));
            EntTotal.VlUnitario = Convert.ToDecimal(txtVlUnit.Text.Replace(".", ""));
            EntTotal.VlDesconto = Convert.ToDecimal(txtDesconto.Text.Replace(".", ""));
            EntTotal.VlAliqIcms = Convert.ToDecimal(txtAliqIcms.Text.Replace(".", ""));
            EntTotal.VlAliqIpi = Convert.ToDecimal(txtAliqIpi.Text.Replace(".", ""));

            if (EntTotal.VlAliqIcms != 0)
            {
                txtVlBCIcms.Text = string.Format("{0:N2}", cNotaFiscal.BaseIcms(EntTotal));
                txtVlIcms.Text = string.Format("{0:N2}", cNotaFiscal.Icms(EntTotal));
            }
            else
            {
                txtVlBCIcms.Text = "0,00";
                txtVlIcms.Text = "0,00";
            }
            if (EntTotal.VlAliqIpi != 0)
                txtVlIpi.Text = string.Format("{0:N2}", cNotaFiscal.ValorIpi(EntTotal));
            else
                txtVlIpi.Text = "0,00";

            EntTotal.VlBaseIcms = Convert.ToDecimal(txtVlBCIcms.Text.Replace(".", ""));
            EntTotal.VlIcms = Convert.ToDecimal(txtVlIcms.Text.Replace(".", ""));
            EntTotal.VlBaseIcmsSub = Convert.ToDecimal(txtVlBcSub.Text.Replace(".", ""));
            EntTotal.VlIcmsSub = Convert.ToDecimal(txtIcmsSub.Text.Replace(".", ""));
            EntTotal.VlOutrasDesp = Convert.ToDecimal(txtVlOutras.Text.Replace(".", ""));
            EntTotal.VlSeguro = Convert.ToDecimal(txtVlSeguro.Text.Replace(".", ""));
            EntTotal.VlFrete = Convert.ToDecimal(txtFrete.Text.Replace(".", ""));
            EntTotal.VlIpi = Convert.ToDecimal(txtVlIpi.Text.Replace(".", ""));

            txtTotal.Text = string.Format("{0:N2}", cNotaFiscal.SomarGeral(EntTotal));
        }

        private void BtnAddItem_Click(object sender, EventArgs e)
        {
            if(txtCodCliente.Text != string.Empty)
            {
                CarregarPnlAddItem();
            }
            else
            {
                MessageBox.Show("Informe o Cliente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodCliente.Focus();
            }
        }

        private void FMT004NotaFiscalDev_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void FMT004NotaFiscalDev_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F1)
            {
                ConsultarParticipante();
            }
            else if (e.KeyData == Keys.F2)
            {
                CarregarPnlAddItem();
            }
            else if (e.KeyData == Keys.F3)
            {

            }
            else if (e.KeyData == Keys.F4)
            {

            }
            else if (e.KeyData == Keys.F5)
            {
                if (gbPnlObservações.Visible == true)
                {
                    gbPnlObservações.Visible = false;
                }
                else
                {
                    gbPnlObservações.Visible = true;
                }
            }
            else if (e.KeyData == Keys.F6)
            {

            }
            else if (e.KeyData == Keys.F7)
            {
                PesquisarProduto();
            }
            else if (e.KeyData == Keys.F8)
            {
                if(gbPnlProduto.Visible == true)
                    if (gbTributacao.Visible == true)
                        gbTributacao.Visible = false;
                    else
                        gbTributacao.Visible = true;
            }
            else if(e.KeyData  == Keys.F9)
            {
                AddProdutoGrid();
            }
            else if (e.KeyData == Keys.F10)
            {
                if(gbPnlObservações.Visible == true)
                {
                    gbPnlObservações.Visible = false;
                }
            }

        }

        private void txtQtd_KeyDown(object sender, KeyEventArgs e)
        {

        }

        #region -------- Key Press GERAL --------
        private void txtQtd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!txtQtd.Text.Contains(e.KeyChar.ToString()))
            {
                if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
                {
                    e.Handled = true;
                }
            }
            else if (e.KeyChar.ToString().Trim() == ",")
                e.Handled = true;
        }

        private void txtAliqIcms_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!txtAliqIcms.Text.Contains(e.KeyChar.ToString()))
            {
                if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
                {
                    e.Handled = true;
                }
            }
            else if (e.KeyChar.ToString().Trim() == ",")
                e.Handled = true;
        }

        private void txtVlBCIcms_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!txtVlBCIcms.Text.Contains(e.KeyChar.ToString()))
            {
                if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
                {
                    e.Handled = true;
                }
            }
            else if (e.KeyChar.ToString().Trim() == ",")
                e.Handled = true;
        }

        private void txtVlIcms_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!txtVlIcms.Text.Contains(e.KeyChar.ToString()))
            {
                if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
                {
                    e.Handled = true;
                }
            }
            else if (e.KeyChar.ToString().Trim() == ",")
                e.Handled = true;
        }

        private void txtVlOutras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!txtVlOutras.Text.Contains(e.KeyChar.ToString()))
            {
                if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
                {
                    e.Handled = true;
                }
            }
            else if (e.KeyChar.ToString().Trim() == ",")
                e.Handled = true;
        }

        private void txtAliqIpi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!txtAliqIpi.Text.Contains(e.KeyChar.ToString()))
            {
                if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
                {
                    e.Handled = true;
                }
            }
            else if (e.KeyChar.ToString().Trim() == ",")
                e.Handled = true;
        }

        private void txtVlIpi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!txtVlIpi.Text.Contains(e.KeyChar.ToString()))
            {
                if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
                {
                    e.Handled = true;
                }
            }
            else if (e.KeyChar.ToString().Trim() == ",")
                e.Handled = true;
        }

        private void txtVlSeguro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!txtVlSeguro.Text.Contains(e.KeyChar.ToString()))
            {
                if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
                {
                    e.Handled = true;
                }
            }
            else if (e.KeyChar.ToString().Trim() == ",")
                e.Handled = true;
        }

        private void txtFrete_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!txtFrete.Text.Contains(e.KeyChar.ToString()))
            {
                if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
                {
                    e.Handled = true;
                }
            }
            else if (e.KeyChar.ToString().Trim() == ",")
                e.Handled = true;
        }

        private void txtAliqPis_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!txtAliqPis.Text.Contains(e.KeyChar.ToString()))
            {
                if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
                {
                    e.Handled = true;
                }
            }
            else if (e.KeyChar.ToString().Trim() == ",")
                e.Handled = true;
        }

        private void txtVlPis_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!txtVlPis.Text.Contains(e.KeyChar.ToString()))
            {
                if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
                {
                    e.Handled = true;
                }
            }
            else if (e.KeyChar.ToString().Trim() == ",")
                e.Handled = true;
        }

        private void txtAliqCofins_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!txtAliqCofins.Text.Contains(e.KeyChar.ToString()))
            {
                if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
                {
                    e.Handled = true;
                }
            }
            else if (e.KeyChar.ToString().Trim() == ",")
                e.Handled = true;
        }

        private void txtVlCofins_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!txtVlCofins.Text.Contains(e.KeyChar.ToString()))
            {
                if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
                {
                    e.Handled = true;
                }
            }
            else if (e.KeyChar.ToString().Trim() == ",")
                e.Handled = true;
        }

        private void txtDesconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!txtDesconto.Text.Contains(e.KeyChar.ToString()))
            {
                if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
                {
                    e.Handled = true;
                }
            }
            else if (e.KeyChar.ToString().Trim() == ",")
                e.Handled = true;
        }
        private void txtVlBcSub_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!txtDesconto.Text.Contains(e.KeyChar.ToString()))
            {
                if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
                {
                    e.Handled = true;
                }
            }
            else if (e.KeyChar.ToString().Trim() == ",")
                e.Handled = true;
        }
        #endregion

        #region ------------- Text Changed -------------
        private void txtAliqIcms_TextChanged(object sender, EventArgs e)
        {
            if (txtAliqIcms.Text != string.Empty)
            {
                TotaisItem();
            }
        }

        private void txtVlOutras_TextChanged(object sender, EventArgs e)
        {
            if (txtVlOutras.Text != string.Empty)
            {
                if (Convert.ToDecimal(txtVlOutras.Text) > 0)
                {
                    TotaisItem();
                }
            }
        }

        private void txtAliqIpi_TextChanged(object sender, EventArgs e)
        {
            if (txtAliqIpi.Text != string.Empty)
            {
                TotaisItem();
            }
        }

        private void txtVlSeguro_TextChanged(object sender, EventArgs e)
        {
            if (txtVlSeguro.Text != string.Empty)
            {
                TotaisItem();
            }
        }

        private void txtFrete_TextChanged(object sender, EventArgs e)
        {
            if (txtFrete.Text != string.Empty)
            {
                TotaisItem();
            }
        }

        private void txtAliqPis_TextChanged(object sender, EventArgs e)
        {
            if (txtAliqPis.Text != string.Empty)
            {
                TotaisItem();
            }
        }

        private void txtAliqCofins_TextChanged(object sender, EventArgs e)
        {
            if (txtAliqCofins.Text != string.Empty)
            {
                TotaisItem();
            }
        }

        private void txtDesconto_TextChanged(object sender, EventArgs e)
        {
            if (txtDesconto.Text != string.Empty)
            {
                if (Convert.ToDecimal(txtDesconto.Text) > 0 || (Convert.ToDecimal(txtDesconto.Text) == 0))
                {
                    TotaisItem();
                }
            }
        }
        #endregion

        #region ----------- LEAVE -----------

        private void txtVlBcSub_Leave(object sender, EventArgs e)
        {
            if (txtVlBcSub.Text == string.Empty)
            {
                txtVlBcSub.Text = "0";
                FormataCampoTxtBox(txtVlBcSub);
            }
            else
                FormataCampoTxtBox(txtAliqIcms);
        }

        private void txtAliqIcms_Leave(object sender, EventArgs e)
        {
            if (txtAliqIcms.Text.Trim() == string.Empty)
            {
                txtAliqIcms.Text = "0";
                FormataCampoTxtBox(txtAliqIcms);
            }
            else
                FormataCampoTxtBox(txtAliqIcms);
        }

        private void txtQtd_Leave(object sender, EventArgs e)
        {
            if (txtQtd.Text == string.Empty)
            {
                txtQtd.Text = "0";
                FormataCampoTxtBox(txtQtd);
            }
            else
                FormataCampoTxtBox(txtQtd, "N4");
        }

        private void txtVlBCIcms_Leave(object sender, EventArgs e)
        {
            if (txtVlBCIcms.Text == string.Empty)
            {
                txtVlBCIcms.Text = "0";
                FormataCampoTxtBox(txtVlBCIcms);
            }
            else
                FormataCampoTxtBox(txtVlBCIcms);
        }

        private void txtVlIcms_Leave(object sender, EventArgs e)
        {
            if (txtVlIcms.Text == string.Empty)
            {
                txtVlIcms.Text = "0";
                FormataCampoTxtBox(txtVlIcms);
            }
            else
                FormataCampoTxtBox(txtVlIcms);
        }

        private void txtIcmsSub_Leave(object sender, EventArgs e)
        {
            if (txtIcmsSub.Text == string.Empty)
            {
                txtIcmsSub.Text = "0";
                FormataCampoTxtBox(txtIcmsSub);
            }
            else
                FormataCampoTxtBox(txtIcmsSub);
        }

        private void txtVlOutras_Leave(object sender, EventArgs e)
        {
            if (txtVlOutras.Text == string.Empty)
            {
                txtVlOutras.Text = "0";
                FormataCampoTxtBox(txtVlOutras);
            }
            else
                FormataCampoTxtBox(txtVlOutras);
        }

        private void txtAliqIpi_Leave(object sender, EventArgs e)
        {
            if (txtAliqIpi.Text == string.Empty)
            {
                txtAliqIpi.Text = "0";
                FormataCampoTxtBox(txtAliqIpi);
            }
            else
                FormataCampoTxtBox(txtAliqIpi);
        }

        private void txtVlIpi_Leave(object sender, EventArgs e)
        {
            if (txtVlIpi.Text == string.Empty)
            {
                txtVlIpi.Text = "0";
                FormataCampoTxtBox(txtVlIpi);
            }
            else
                FormataCampoTxtBox(txtVlIpi);
        }

        private void txtVlSeguro_Leave(object sender, EventArgs e)
        {
            if (txtVlSeguro.Text == string.Empty)
            {
                txtVlSeguro.Text = "0";
                FormataCampoTxtBox(txtVlSeguro);
            }
            else
                FormataCampoTxtBox(txtVlSeguro);
        }

        private void txtFrete_Leave(object sender, EventArgs e)
        {
            if (txtFrete.Text == string.Empty)
            {
                txtFrete.Text = "0";
                FormataCampoTxtBox(txtFrete);
            }
            else
                FormataCampoTxtBox(txtFrete);
        }

        private void txtAliqPis_Leave(object sender, EventArgs e)
        {
            if (txtAliqPis.Text == string.Empty)
            {
                txtAliqPis.Text = "0";
                FormataCampoTxtBox(txtAliqPis);
            }
            else
                FormataCampoTxtBox(txtAliqPis);
        }

        private void txtVlPis_Leave(object sender, EventArgs e)
        {
            if (txtVlPis.Text == string.Empty)
            {
                txtVlPis.Text = "0";
                FormataCampoTxtBox(txtVlPis);
            }
            else
                FormataCampoTxtBox(txtVlPis);
        }

        private void txtAliqCofins_Leave(object sender, EventArgs e)
        {
            if (txtAliqCofins.Text == string.Empty)
            {
                txtAliqCofins.Text = "0";
                FormataCampoTxtBox(txtAliqCofins);
            }
            else
                FormataCampoTxtBox(txtAliqCofins);
        }

        private void txtVlCofins_Leave(object sender, EventArgs e)
        {
            if (txtVlCofins.Text == string.Empty)
            {
                txtVlCofins.Text = "0";
                FormataCampoTxtBox(txtVlCofins);
            }
            else
                FormataCampoTxtBox(txtVlCofins);
        }

        private void txtDesconto_Leave(object sender, EventArgs e)
        {
            if (txtDesconto.Text == string.Empty)
            {
                txtDesconto.Text = "0";
                FormataCampoTxtBox(txtDesconto);
            }
            else
                FormataCampoTxtBox(txtDesconto);
        }

        #endregion

        private void btnIncluirItemGrid_Click(object sender, EventArgs e)
        {
            AddProdutoGrid();
        }

        void AddProdutoGrid()
        {
            if (ValidaIncluirGrid())
            {
                grdProdutoNF.Rows.Add(TxtCodItem.Text, lblItemDesc.Text, lblNCM.Text, lblTribIcms.Text, lblTribIpi.Text, lblTribPis.Text, CboCFOP.Text, lblUnidade.Text, txtDesconto.Text, txtQtd.Text, txtVlUnit.Text, txtAliqIcms.Text, txtVlBCIcms.Text, txtVlIcms.Text, txtVlBcSub.Text, txtIcmsSub.Text, txtVlOutras.Text, txtAliqIpi.Text, txtVlIpi.Text, txtAliqPis.Text, txtVlPis.Text, txtAliqCofins.Text, txtVlCofins.Text, txtFrete.Text, txtTotal.Text);
                gbPnlProduto.Visible = false;
                LimpaGbAddItem();
                TotalGeral();
            }
        }
        void CarregarPnlAddItem()
        {
            if (txtCodCliente.Text != string.Empty)
            {
                ObjLoja = new Loja();
                ObjCfop = new Cfop();
                var DtLoja = ObjLoja.Pesquisa(1);

                CboCFOP.DisplayMember = "cfop";
                CboCFOP.ValueMember = "cfop";

                if (lblUF.Text.ToUpper() == DtLoja.Rows[0]["desc_uf"].ToString().ToUpper())
                    CboCFOP.DataSource = ObjCfop.Interno();
                else
                    CboCFOP.DataSource = ObjCfop.Externo();

                CarregarCombosICMS();
                if (gbPnlProduto.Visible == true)
                    gbPnlProduto.Visible = false;
                else
                    gbPnlProduto.Visible = true;
            }
            else
            {
                MessageBox.Show("Informe o Cliente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodCliente.Focus();
            }
        }

        bool ValidaIncluirGrid()
        {
            if (txtAliqIcms.Text == string.Empty)
                txtAliqIcms.Text = "0,00";

            if (TxtCodItem.Text == string.Empty)
            {
                MessageBox.Show("Informe um produto!", "Aténção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (Convert.ToDecimal(txtQtd.Text) == 0)
            {
                MessageBox.Show("Informe a Quantidade!", "Aténção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (lblTribIcms.Text == "---")
            {
                MessageBox.Show("Informe a tributação de ICMS.!", "Aténção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                gbTributacao.Visible = true;
                return false;
            }
            else if ((lblTribIcms.Text == "000" || lblTribIcms.Text == "010" || lblTribIcms.Text == "020") && Convert.ToDecimal(txtAliqIcms.Text) == 0)
            {
                MessageBox.Show("A CST de ICMS informado pede uma aliquota de ICMS!", "Aténção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                gbTributacao.Visible = true;
                cboTribIcms.Focus();
                return false;
            }
            else if (lblTribIpi.Text == "000")
            {
                MessageBox.Show("Informe a tributação de IPI.!", "Aténção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                gbTributacao.Visible = true;
                return false;
            }
            else if (lblTribIpi.Text == "50" && Convert.ToDecimal(txtAliqIpi.Text) == 0)
            {
                MessageBox.Show("A CST de IPI informado pede uma aliquota de IPI!", "Aténção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                gbTributacao.Visible = true;
                cboTribIpi.Focus();
                return false;
            }
            else if (lblTribPis.Text == "000")
            {
                MessageBox.Show("Informe a tributação de PIS.!", "Aténção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                gbTributacao.Visible = true;
                return false;
            }
            else if (lblTribCofins.Text == "000")
            {
                MessageBox.Show("Informe a tributação de COPINS.!", "Aténção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                gbTributacao.Visible = true;
                return false;
            }
            else
                return true;
        }

        bool ValidarNf()
        {
            if (txtCodCliente.Text == string.Empty)
            {
                MessageBox.Show("Informe o cliente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (cboTipoNF.SelectedIndex != 0)
            {
                MessageBox.Show("Informe o tipo de NFe!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if(grdProdutoNF.Rows.Count  == 0)
            {
                MessageBox.Show("Informe um produto para gerar uma nova Nfe!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
                return true;
        }
        bool ValidaGdTributacao()
        {
            if (cboTribIcms.Text == string.Empty)
            {
                MessageBox.Show("Selecione a tribuação de ICMS.", "Aténção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (cboTribIpi.Text == string.Empty)
            {
                MessageBox.Show("Selecione a tribuação de IPI.", "Aténção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (cboTribPis.Text == string.Empty)
            {
                MessageBox.Show("Selecione a tribuação de PIS.", "Aténção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (cboTribCofins.Text == string.Empty)
            {
                MessageBox.Show("Selecione a tribuação de COFINS.", "Aténção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
                return true;
        }

        void LimpaGbAddItem()
        {
            TxtCodItem.Text = string.Empty;
            lblItemDesc.Text = "---";
            lblNCM.Text = "----------";
            lblTribIcms.Text = "000";
            lblTribIpi.Text = "000";
            lblTribPis.Text = "000";
            lblTribCofins.Text = "000";
            CboCFOP.Text = "0000";
            lblUnidade.Text = "---";
            txtDesconto.Text = "0,00";
            txtQtd.Text = "0,00";
            txtVlUnit.Text = "0,00";
            txtAliqIcms.Text = "0,00";
            txtVlBCIcms.Text = "0,00";
            txtVlBcSub.Text = "0,00";
            txtIcmsSub.Text = "0,00";
            txtVlOutras.Text = "0,00";
            txtAliqPis.Text = "0,00";
            txtVlPis.Text = "0,00";
            txtAliqCofins.Text = "0,00";
            txtVlCofins.Text = "0,00";
            txtFrete.Text = "0,00";
            txtTotal.Text = "0,00";
        }

        private void txtCodCliente_Leave(object sender, EventArgs e)
        {
            if(txtCodCliente.Text != string.Empty)
            {
                if (Gerais.FuncoesGerais.ItemNumerico(txtCodCliente.Text))
                {
                    PesquisarCliente(Convert.ToInt32(txtCodCliente.Text));
                    PesquisaLogradouroParticipante(Convert.ToInt32(txtCodCliente.Text));
                    
                }
                else
                {
                    MessageBox.Show("Código Digitado é invalido!", "Aténção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCodCliente.Text = string.Empty;
                }
            }
        }

        void PesquisarCliente(int Id)
        {
            objPart = new Participante();

            var DtRet = objPart.Pesquisa(Id);

            if(DtRet != null)
            {
                lblID.Text = DtRet.id.ToString();
                lblCliente.Text = DtRet.nome;
                txtCodCliente.Text = DtRet.id.ToString();
                lblUF.Text = DtRet.id_uf.desc_uf;
            }
            else
            {
                MessageBox.Show("Cliente não existe!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblID.Text = string.Empty;
                lblCliente.Text = string.Empty;
                txtCodCliente.Text = string.Empty;
                lblUF.Text = string.Empty;
                txtCodCliente.Focus();
            }
        }

        private void TxtCodItem_Leave(object sender, EventArgs e)
        {
            if(TxtCodItem.Text != string.Empty)
            {
                objProd = new Produtos();

                var DtRetProd = objProd.Pesquisa(long.Parse(TxtCodItem.Text));

                if (DtRetProd != null)
                {
                    if (DtRetProd.NCM != string.Empty)
                    {
                        TxtCodItem.Text = DtRetProd.IdProduto.ToString();
                        lblNCM.Text = DtRetProd.NCM;
                        lblUnidade.Text = DtRetProd.Unidade.CdUnidade;
                        CarregarComboUnidConversao(Convert.ToInt32(DtRetProd.IdProduto));
                        PesquisaDados();
                        if (cboTipoNF.SelectedIndex == 1)
                        {
                            cboUndConv.Enabled = true;
                            txtVlUnitDev.Enabled = true;
                            txtQtdConv.Enabled = true;
                        }
                        txtQtd.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Produto sem NCM, por favor alter o cadastro do produto!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Produto não existe!", "Aténção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TxtCodItem.Text = string.Empty;
                    TxtCodItem.Focus();
                }
            }
        }

        private void btnSalvaNfe_Click(object sender, EventArgs e)
        {
            if (ValidarNf())
            {
                Salvar();
            }
        }

        private void grdLocalEntrega_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1)
            {
                if (grdLocalEntrega.Rows[e.RowIndex].Cells[0].Value.ToString() == string.Empty)
                    MessageBox.Show("Não existe local de entrega!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    lblIdLocalEntrega.Text = grdLocalEntrega.Rows[e.RowIndex].Cells[0].Value.ToString();

                    btnLocalEntrega.BackColor = Color.FromArgb(0, 200, 83);

                    gbLocalEntrega.Visible = false;
                }
            }
        }

        private void btnLocalEntrega_Click(object sender, EventArgs e)
        {
            if(gbLocalEntrega.Visible == true)
                gbLocalEntrega.Visible = false;
            else
                gbLocalEntrega.Visible = true;
        }

        void PesquisaLogradouroParticipante(int id)
        {
            objPart = new Participante();

            var DtListLog = objPart.Pesquisa(id);

            lblIdLocalEntrega.Text = string.Empty;

            if (DtListLog.ListLocalEntrega.Count > 0)
            {
                grdLocalEntrega.Rows.Clear();
                foreach (var logradouro in DtListLog.ListLocalEntrega)
                {
                    grdLocalEntrega.Rows.Add(logradouro.id,logradouro.lagradouro, logradouro.end_numero, logradouro.bairro, logradouro.id_uf.desc_uf, logradouro.id_cidade.desc_municipio, logradouro.telefone, logradouro.obs);
                }
            }
            else
            {
                grdLocalEntrega.Rows.Add("NÃO EXISTE LOCAL DE ENTREGA CADASTRADO PARA ESTE CLIENTE!");
            }
        }

        private void BtnSalvarFatura_Click(object sender, EventArgs e)
        {
            gbFaturaNotaFiscal.Visible = false;
            if (ucFormaPagto1.ValidaCampos())
            {
                btnFatura.BackColor = Color.FromArgb(0, 200, 83);
            }
        }

        private void btnFatura_Click(object sender, EventArgs e)
        {
            GroupBoxFormaPagamento();
        }

        void GroupBoxFormaPagamento()
        {
            ucFormaPagto1.CarregarFormaPagamento();
            if (gbFaturaNotaFiscal.Visible == false)
                gbFaturaNotaFiscal.Visible = true;
            else
                gbFaturaNotaFiscal.Visible = false;
        }

        private void grdProdutoNF_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void grdProdutoNF_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                if (MessageBox.Show("Deseja excluir o produto," + grdProdutoNF.Rows[grdProdutoNF.CurrentRow.Index].Cells[0].Value.ToString() + "?", "Aténção", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    grdProdutoNF.Rows.RemoveAt(grdProdutoNF.CurrentRow.Index);
                    TotalGeral();
                }
            }
        }

        bool Salvar()
        {
            EntNotaFiscal = new Entidade_NotaFiscal();
            mSerieNotaFiscal = new SerieNotaFiscal();
            mNotaFiscal = new NotaFiscal();
            objPart = new Participante();

            Entidade_ItemNFe ObjItemNfe;
            List<Entidade_ItemNFe> ObjListItemNfe = new List<Entidade_ItemNFe>();

            try
            {
                EntNotaFiscal.id_loja = Entidade_GeralInformcoes.idloja;
                EntNotaFiscal.id_participante = objPart.Pesquisa(Convert.ToInt32(txtCodCliente.Text));
                EntNotaFiscal.serienf = mSerieNotaFiscal.Serie(Entidade_GeralInformcoes.idloja, "55");
                EntNotaFiscal.nrnf = mSerieNotaFiscal.NfAtual(Entidade_GeralInformcoes.idloja, "55");
                EntNotaFiscal.dtemissao = DateTime.Now;
                EntNotaFiscal.dtsaida = DateTime.Now;
                EntNotaFiscal.vltotal = Convert.ToDecimal(lblTotVlTotal.Text.Replace(".", ""));
                EntNotaFiscal.vlbaseicms = Convert.ToDecimal(lblTotVlBaseICms.Text.Replace(".", ""));
                EntNotaFiscal.vlicms = Convert.ToDecimal(lblTotVlIcms.Text.Replace(".", ""));
                EntNotaFiscal.vlbaseicmssub = Convert.ToDecimal(lblTotVlBaseIcmsSub.Text.Replace(".", ""));
                EntNotaFiscal.vlicmssub = Convert.ToDecimal(lblTotVlIcmsSub.Text.Replace(".", ""));
                EntNotaFiscal.vloutras = Convert.ToDecimal(lblTotVlOutDesp.Text.Replace(".", ""));
                EntNotaFiscal.vlfrete = Convert.ToDecimal(lblTotVlFrete.Text.Replace(".", ""));
                EntNotaFiscal.vlseguro = Convert.ToDecimal(lblTotVlSeguro.Text.Replace(".", ""));
                EntNotaFiscal.vlIpi = Convert.ToDecimal(lblTotVlIpi.Text.Replace(".", ""));
                EntNotaFiscal.vlPis = Convert.ToDecimal(lblTotVlPis.Text.Replace(".", ""));
                EntNotaFiscal.vlCofins = Convert.ToDecimal(lblTotVlCofins.Text.Replace(".", ""));
                EntNotaFiscal.vlDesconto = Convert.ToDecimal(lblTotVlDesc.Text.Replace(".", ""));
                EntNotaFiscal.txobsfisco = txtFisco.Text;
                EntNotaFiscal.txobscontribuinte = txtContribuinte.Text;
                EntNotaFiscal.id_pedido = 0;
                EntNotaFiscal.flfinalidade = cboTipoNF.SelectedIndex + 1;
                EntNotaFiscal.id_localentrega = lblIdLocalEntrega.Text == string.Empty ? 0 : Convert.ToInt32(lblIdLocalEntrega.Text);

                
                for (int i = 0; i < grdProdutoNF.Rows.Count; i++)
                {
                    ObjItemNfe = new Entidade_ItemNFe();

                    ObjItemNfe.IdProduto = long.Parse(grdProdutoNF.Rows[i].Cells["ColCodProd"].Value.ToString());
                    ObjItemNfe.qt_venda = Convert.ToDecimal(grdProdutoNF.Rows[i].Cells["ColQtd"].Value.ToString());
                    ObjItemNfe.VlPreco = Convert.ToDouble(grdProdutoNF.Rows[i].Cells["ColVlUnit"].Value.ToString().Replace(".", ""));
                    ObjItemNfe.icms = grdProdutoNF.Rows[i].Cells["ColCstIcms"].Value.ToString();
                    ObjItemNfe.ipi = grdProdutoNF.Rows[i].Cells["ColCstIpi"].Value.ToString();
                    ObjItemNfe.pis = grdProdutoNF.Rows[i].Cells["ColCstPisCofins"].Value.ToString();
                    ObjItemNfe.cofins = grdProdutoNF.Rows[i].Cells["ColCstPisCofins"].Value.ToString();
                    ObjItemNfe.cfop = Convert.ToInt32(grdProdutoNF.Rows[i].Cells["ColCFOP"].Value);
                    ObjItemNfe.vlbaseicms = Convert.ToDecimal(grdProdutoNF.Rows[i].Cells["ColVlBaseIcms"].Value.ToString());
                    ObjItemNfe.vlicms = Convert.ToDecimal(grdProdutoNF.Rows[i].Cells["ColVlIcms"].Value.ToString());
                    ObjItemNfe.vlbaseicmssub = Convert.ToDecimal(grdProdutoNF.Rows[i].Cells["ColVlIcms"].Value.ToString());
                    ObjItemNfe.vlicmssub  = Convert.ToDecimal(grdProdutoNF.Rows[i].Cells["ColVlIcmsSub"].Value.ToString());
                    ObjItemNfe.vloutras = Convert.ToDecimal(grdProdutoNF.Rows[i].Cells["ColVlOutras"].Value.ToString());
                    ObjItemNfe.vlDesconto = Convert.ToDecimal(grdProdutoNF.Rows[i].Cells["ColVlDesconto"].Value.ToString()); 
                    ObjItemNfe.vlIpi = Convert.ToDecimal(grdProdutoNF.Rows[i].Cells["ColVlIpi"].Value.ToString()); 
                    ObjItemNfe.vlAliqIpi = Convert.ToDecimal(grdProdutoNF.Rows[i].Cells["ColAliqIpi"].Value.ToString());
                    ObjItemNfe.vlAliqIcms = Convert.ToDecimal(grdProdutoNF.Rows[i].Cells["ColAliqIcms"].Value.ToString());
                    ObjItemNfe.vlCofins = Convert.ToDecimal(grdProdutoNF.Rows[i].Cells["ColVlCofins"].Value.ToString());
                    ObjItemNfe.vlPis = Convert.ToDecimal(grdProdutoNF.Rows[i].Cells["ColVlPis"].Value.ToString());

                    ObjListItemNfe.Add(ObjItemNfe);

                }

                EntNotaFiscal.ItemNFe = ObjListItemNfe;
                if (mNotaFiscal.Salvar(EntNotaFiscal))
                {
                    MessageBox.Show("Nota Fiscal: " + EntNotaFiscal.serienf + "-" + EntNotaFiscal.nrnf + " gerada com sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpaCampos();
                    return true;
                    
                }
                else
                {
                    MessageBox.Show("Erro ao lança a nota fiscal!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao incluir!\nMessangem:" + ex.Message.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
        }
        void LimpaCampos()
        {
            txtCodCliente.Text = string.Empty;
            lblCliente.Text = string.Empty;
            lblIdLocalEntrega.Text = string.Empty;
            lblUF.Text = string.Empty;
            cboTipoNF.SelectedIndex = -1;
            btnLocalEntrega.BackColor = Color.FromName("ControlDark");
            btnFatura.BackColor = Color.FromName("ControlDark");
            btnF5Observacoes.BackColor = Color.FromName("ControlDark");
            grdProdutoNF.Rows.Clear();
            
            lblTotVlBaseICms.Text = "0,00";
            lblTotVlIcms.Text = "0,00";
            lblTotVlBaseIcmsSub.Text = "0,00";
            lblTotVlIcmsSub.Text = "0,00";
            lblTotVlOutDesp.Text = "0,00";
            lblTotVlFrete.Text = "0,00";
            lblTotVlSeguro.Text = "0,00";

            lblTotVlIpi.Text = "0,00";
            lblTotVlPis.Text = "0,00";
            lblTotVlCofins.Text = "0,00";
            lblTotVlDesc.Text = "0,00";

            lblTotVlTotal.Text = "0,00";
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void btnObservacoes_Click(object sender, EventArgs e)
        {
            gbPnlObservações.Visible = false;
            if(txtContribuinte.Text != string.Empty || txtFisco.Text != string.Empty)
            {
                btnFatura.BackColor = Color.FromArgb(0, 200, 83);
            }
        }

        
    }
}

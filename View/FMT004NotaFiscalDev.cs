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

        Entidade_TotaisNota EntTotal;

        C_NotaFiscal cNotaFiscal;

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
                lblCliente.Text = ObjPesquisar.Nome;
            }
        }

        private void btnTribOK_Click(object sender, EventArgs e)
        {
            gbTributacao.Visible = false;
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
                TxtCodItem.Text = ObjPesquisar.ID.ToString();
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

        void TotaisItem()
        {
            cNotaFiscal = new C_NotaFiscal();
            EntTotal = new Entidade_TotaisNota();

            EntTotal.QtItem = Convert.ToDouble(txtQtd.Text.Replace(".", ""));
            EntTotal.VlUnitario = Convert.ToDouble(txtVlUnit.Text.Replace(".", ""));
            EntTotal.VlDesconto = Convert.ToDouble(txtDesconto.Text.Replace(".", ""));
            EntTotal.VlAliqIcms = Convert.ToDouble(txtAliqIcms.Text.Replace(".", ""));
            EntTotal.VlAliqIpi = Convert.ToDouble(txtAliqIpi.Text.Replace(".", ""));

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

            EntTotal.VlBaseIcms = Convert.ToDouble(txtVlBCIcms.Text.Replace(".", ""));
            EntTotal.VlIcms = Convert.ToDouble(txtVlIcms.Text.Replace(".", ""));
            EntTotal.VlBaseIcmsSub = Convert.ToDouble(txtVlBcSub.Text.Replace(".", ""));
            EntTotal.VlIcmsSub = Convert.ToDouble(txtIcmsSub.Text.Replace(".", ""));
            EntTotal.VlOutrasDesp = Convert.ToDouble(txtVlOutras.Text.Replace(".", ""));
            EntTotal.VlSeguro = Convert.ToDouble(txtVlSeguro.Text.Replace(".", ""));
            EntTotal.VlFrete = Convert.ToDouble(txtFrete.Text.Replace(".", ""));
            EntTotal.VlIpi = Convert.ToDouble(txtVlIpi.Text.Replace(".", ""));

            txtTotal.Text = string.Format("{0:N2}", cNotaFiscal.SomarGeral(EntTotal));
        }

        private void gbPnlProduto_Enter(object sender, EventArgs e)
        {
            TxtCodItem.Focus();
        }

        private void BtnAddItem_Click(object sender, EventArgs e)
        {
            if (gbPnlProduto.Visible == true)
                gbPnlProduto.Visible = false;
            else
                gbPnlProduto.Visible = true;
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
                if (gbPnlProduto.Visible == true)
                    gbPnlProduto.Visible = false;
                else
                    gbPnlProduto.Visible = true;
            }
            else if (e.KeyData == Keys.F3)
            {

            }
            else if (e.KeyData == Keys.F4)
            {

            }
            else if (e.KeyData == Keys.F5)
            {

            }
            else if (e.KeyData == Keys.F6)
            {

            }
            else if (e.KeyData == Keys.F7)
            {
                PesquisarProduto();
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
            if (txtAliqIcms.Text == string.Empty)
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

        private void btnIncluirItemGrid_Click(object sender, EventArgs e)
        {
            if (ValidaIncluirGrid())
            {

            }
        }

        bool ValidaIncluirGrid()
        {
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
            else if (lblTribIcms.Text == "000")
            {
                MessageBox.Show("Informe a tributação de ICMS.!", "Aténção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                gbTributacao.Visible = true;
                return false;
            }
            else if (lblTribIpi.Text == "000")
            {
                MessageBox.Show("Informe a tributação de IPI.!", "Aténção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                gbTributacao.Visible = true;
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
    }
}

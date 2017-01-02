using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Sdistribuidor.Model;
using Sdistribuidor.Entidade;

namespace Sdistribuidor.View
{
    public partial class FC003Produto : Sdistribuidor.View.FBase
    {
        public FC003Produto()
        {
            InitializeComponent();
        }

        Produtos ModProdutos;
        ProdutoUnidade ModProdutoUnid;
        Unidade ModUnid;
        Cst ModCst;
        Cfop ModCfop;

        Entidade_Produto EntProduto;
        Entidade_ProdutoUnidade EntProdUnid;
        Entidade_Grupo EntGrupo;
        Entidade_Unidade EntUnidade;
        DataGridViewTextBoxColumn NewText;

        public override bool ValidaCampos()
        {

            if (txtID.Text == string.Empty)
            {
                MessageBox.Show("Código do produto obrigatorio.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (txtDescProd.Text == string.Empty)
            {
                MessageBox.Show("Descrição do Produto Obrigátoria.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (TxtNCM.Text == string.Empty)
            {
                MessageBox.Show("NCM Obrigatorio.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (ucUnidade1.Unidade == string.Empty)
            {
                MessageBox.Show("Selecione uma unidade.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (ucUnidade1.Unidade == string.Empty)
            {
                MessageBox.Show("Selecione uma unidade.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
                return true;
        }
        public override bool Salvar()
        {
            EntProduto = new Entidade_Produto();
            EntUnidade = new Entidade_Unidade();
            EntGrupo = new Entidade_Grupo();
            ModProdutos = new Produtos();
            ModProdutoUnid = new ProdutoUnidade();
            List<Entidade_ProdutoUnidade> LsProdUnid = new List<Entidade_ProdutoUnidade>();


            EntUnidade.CdUnidade = ucUnidade1.Unidade;
            EntGrupo.idgrupo = ucGrupo1.IdGrupo;

            EntProduto.IdProduto = Convert.ToInt32(txtID.Text);
            EntProduto.NmProduto = txtDescProd.Text;
            EntProduto.Unidade = EntUnidade;
            EntProduto.IdGrupo = EntGrupo;
            EntProduto.NCM = TxtNCM.Text;
            EntProduto.codigoreferencia = TxtCodigoRef.Text;
            EntProduto.pesoitem = Convert.ToDouble(TxtPesoItem.Text.Replace(".", ""));
            EntProduto.VlPreco = Convert.ToDouble(TxtVlPreco.Text.Replace(".", ""));
            EntProduto.VlPreco2 = Convert.ToDouble(TxtPrecoRest.Text.Replace(".", ""));
            EntProduto.VlPreco3 = Convert.ToDouble(TxtPrecoFin.Text.Replace(".", ""));
            EntProduto.icms = CboIcms.SelectedValue.ToString();
            EntProduto.ipi = CboIpi.SelectedValue.ToString();
            EntProduto.pis = CboPis.SelectedValue.ToString();
            EntProduto.cofins = CboCofins.SelectedValue.ToString();
            EntProduto.cfop_int = Convert.ToInt32(CboCfopInterno.SelectedValue.ToString());
            EntProduto.cfop_ext = Convert.ToInt32(CboCfopExterno.SelectedValue.ToString());

            ModProdutos.Incluir(EntProduto);


            if (grdUnidConv.Rows.Count > 0)
            {
                for (int i = 0; i < grdUnidConv.Rows.Count; i++)
                {
                    EntProdUnid = new Entidade_ProdutoUnidade();

                    EntProdUnid.id_produto = Convert.ToInt32(txtID.Text);
                    EntProdUnid.Unidade = ucUnidade1.Unidade;
                    EntProdUnid.vlfatorconv = Convert.ToDouble(grdUnidConv.Rows[i].Cells[1].Value);
                    ModProdutoUnid.Incluir(EntProdUnid);
                }
            }
            CarregarDados();
            return true;
        }
        public override void CarregarOutrosDados()
        {
            ucGrupo1.Preecher();
            ucUnidade1.Preecher();
            CarregarCst();
        }
        public override bool Editar()
        {
            EntProduto = new Entidade_Produto();
            EntUnidade = new Entidade_Unidade();
            EntGrupo = new Entidade_Grupo();
            ModProdutos = new Produtos();
            ModProdutoUnid = new ProdutoUnidade();
            List<Entidade_ProdutoUnidade> LsProdUnid = new List<Entidade_ProdutoUnidade>();

            EntUnidade.CdUnidade = ucUnidade1.Unidade;
            EntGrupo.idgrupo = ucGrupo1.IdGrupo;
            
            EntProduto.IdProduto = Convert.ToInt32(txtID.Text);
            EntProduto.NmProduto = txtDescProd.Text;
            EntProduto.Unidade = EntUnidade;
            EntProduto.IdGrupo = EntGrupo;
            EntProduto.NCM = TxtNCM.Text;
            EntProduto.codigoreferencia = TxtCodigoRef.Text;
            if (TxtPesoItem.Text.Trim() == string.Empty)
                EntProduto.pesoitem = 0;
            else
                EntProduto.pesoitem = Convert.ToDouble(TxtPesoItem.Text.Replace(".", ""));
            EntProduto.VlPreco = Convert.ToDouble(TxtVlPreco.Text.Replace(".", ""));
            EntProduto.VlPreco2 = Convert.ToDouble(TxtPrecoRest.Text.Replace(".", ""));
            EntProduto.VlPreco3 = Convert.ToDouble(TxtPrecoFin.Text.Replace(".", ""));
            EntProduto.icms = CboIcms.SelectedValue.ToString();
            EntProduto.ipi = CboIpi.SelectedValue.ToString();
            EntProduto.pis = CboPis.SelectedValue.ToString();
            EntProduto.cofins = CboCofins.SelectedValue.ToString();
            EntProduto.cfop_int = Convert.ToInt32(CboCfopInterno.SelectedValue.ToString());
            EntProduto.cfop_ext = Convert.ToInt32(CboCfopExterno.SelectedValue.ToString());

            ModProdutos.Update(EntProduto);


            if (grdUnidConv.Rows.Count > 0)
            {
                EntProdUnid = new Entidade_ProdutoUnidade();
                EntProdUnid.id_produto = Convert.ToInt32(txtID.Text);
                ModProdutoUnid.DeleteAll(EntProdUnid);

                for (int i = 0; i < grdUnidConv.Rows.Count; i++)
                {
                    EntProdUnid = new Entidade_ProdutoUnidade();
                    
                    EntProdUnid.Unidade = grdUnidConv.Rows[i].Cells[0].Value.ToString();
                    EntProdUnid.id_produto = Convert.ToInt32(txtID.Text);
                    EntProdUnid.vlfatorconv = Convert.ToDouble(grdUnidConv.Rows[i].Cells[1].Value);
                    ModProdutoUnid.Incluir(EntProdUnid);
                }
            }

            CarregarDados();
            return true;
        }
        public override void CarregarDados()
        {
            ModProdutos = new Produtos();
            ModUnid = new Unidade();

            var obj = ModProdutos.Pesquisa();
            grdBase.AutoGenerateColumns = false;
            grdBase.DataSource = obj;


            cboUnidConv.DisplayMember = "CdUnidade";
            cboUnidConv.ValueMember = "CdUnidade";
            cboUnidConv.DataSource = ModUnid.Pesquisa();


        }
        public override void PesquisarDados(string Pesquisar, object ID)
        {
            ModProdutos = new Produtos();
            ModProdutoUnid = new ProdutoUnidade();

            var ObjRet = ModProdutos.Pesquisa(Convert.ToInt32(ID));

            txtID.Text = ObjRet.IdProduto.ToString();
            txtID.Enabled = false;
            txtDescProd.Text = ObjRet.NmProduto;
            TxtNCM.Text = ObjRet.NCM;
            TxtPesoItem.Text = string.Format("{0:N2}", ObjRet.pesoitem);
            ucUnidade1.Unidade = ObjRet.Unidade.CdUnidade;
            ucGrupo1.IdGrupo = ObjRet.IdGrupo.idgrupo;
            TxtVlPreco.Text = string.Format("{0:N2}", ObjRet.VlPreco);
            TxtPrecoRest.Text = string.Format("{0:N2}", ObjRet.VlPreco2);
            TxtPrecoFin.Text = string.Format("{0:N2}", ObjRet.VlPreco3);
            TxtCodigoRef.Text = string.Format("{0:N2}", ObjRet.codigoreferencia);
            CboIcms.SelectedValue = ObjRet.icms;
            CboIpi.SelectedValue = ObjRet.ipi;
            CboPis.SelectedValue = ObjRet.pis;
            CboCofins.SelectedValue = ObjRet.cofins;
            CboCfopInterno.SelectedValue = ObjRet.cfop_int;
            CboCfopExterno.SelectedValue = ObjRet.cfop_ext;
            

            var ProdUnid = ModProdutoUnid.Pesquisa(Convert.ToInt32(ID));
            
            grdUnidConv.Rows.Clear();

            if (ProdUnid != null)
            {
                foreach (var item in ProdUnid)
                {
                    grdUnidConv.Rows.Add(item.Unidade, string.Format("{0:N4}", item.vlfatorconv));
                }
            }
            //else
            //{
            //    grdUnidConv.Rows.Add(ObjRet.Unidade.CdUnidade, "1,000");
            //}
        }
        public override void CamposGrid()
        {

            NewText = new DataGridViewTextBoxColumn();
            NewText.HeaderText = "Código";
            NewText.Name = "ColID";
            NewText.DataPropertyName = "idproduto";
            NewText.Width = 60;

            grdBase.Columns.Add(NewText);

            NewText = new DataGridViewTextBoxColumn();
            NewText.HeaderText = "Descrição";
            NewText.Name = "ColDesc";
            NewText.DataPropertyName = "NmProduto";
            NewText.Width = 350;

            grdBase.Columns.Add(NewText);

        }
        public override void LimpaCampos()
        {
            txtID.Text = string.Empty;
            txtDescProd.Text = string.Empty;
            TxtNCM.Text = string.Empty;
            ucUnidade1.Unidade = string.Empty;
            ucGrupo1.IdGrupo = 0;
            TxtVlPreco.Text = "0,00";
            TxtPrecoFin.Text = "0,00";
            TxtPrecoRest.Text = "0,00";
            //base.LimpaCampos();

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (ValidarAddGrdUnidade())
            {
                grdUnidConv.Rows.Add(cboUnidConv.Text, TxtFatorConv.Text);
                cboUnidConv.Text = string.Empty;
                TxtFatorConv.Text = "0.0000";
            }
        }
        bool ValidarAddGrdUnidade()
        {
            if (cboUnidConv.Text == string.Empty)
            {
                MessageBox.Show("Selecione uma unidade de conversão!", "Aténção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (TxtFatorConv.Text == string.Empty)
            {
                MessageBox.Show("Informe o valor para o fator de conversão!", "Aténção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
                return true;
        }

        private void grdUnidConv_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                if (MessageBox.Show("Deseja excluir a unidade," + grdUnidConv.Rows[grdUnidConv.CurrentRow.Index].Cells[0].Value.ToString() + "?", "Aténção", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    grdUnidConv.Rows.RemoveAt(grdUnidConv.CurrentRow.Index);
                }
            }
        }

        public override void LimpaCamposDados()
        {
            base.LimpaCamposDados();
        }

        private void TxtFatorConv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!TxtFatorConv.Text.Contains(e.KeyChar.ToString()))
            {
                if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
                {
                    e.Handled = true;
                }
            }
            else if (e.KeyChar.ToString().Trim() == ",")
                e.Handled = true;
        }

        private void TxtPrecoFin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!TxtPrecoFin.Text.Contains(e.KeyChar.ToString()))
            {
                if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
                {
                    e.Handled = true;
                }
            }
            else if (e.KeyChar.ToString().Trim() == ",")
                e.Handled = true;
        }

        private void TxtVlPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!TxtVlPreco.Text.Contains(e.KeyChar.ToString()))
            {
                if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
                {
                    e.Handled = true;
                }
            }
            else if (e.KeyChar.ToString().Trim() == ",")
                e.Handled = true;
        }

        private void TxtPesoItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!TxtPesoItem.Text.Contains(e.KeyChar.ToString()))
            {
                if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
                {
                    e.Handled = true;
                }
            }
            else if (e.KeyChar.ToString().Trim() == ",")
                e.Handled = true;
        }

        private void TxtFatorConv_Leave(object sender, EventArgs e)
        {
            if(TxtFatorConv.Text.Length > 0)
            {
                TxtFatorConv.Text = string.Format("{0:N4}", Convert.ToDecimal(TxtFatorConv.Text));
            }
        }

        private void TxtVlPreco_Leave(object sender, EventArgs e)
        {
            if (TxtVlPreco.Text.Length > 0)
            {
                TxtVlPreco.Text = string.Format("{0:N2}", Convert.ToDecimal(TxtVlPreco.Text));
            }
        }

        private void TxtPrecoRest_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!TxtPrecoRest.Text.Contains(e.KeyChar.ToString()))
            {
                if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
                {
                    e.Handled = true;
                }
            }
            else if (e.KeyChar.ToString().Trim() == ",")
                e.Handled = true;
        }

        private void TxtPrecoRest_Leave(object sender, EventArgs e)
        {
            if (TxtPrecoRest.Text.Length > 0)
            {
                TxtPrecoRest.Text = string.Format("{0:N2}", Convert.ToDecimal(TxtPrecoRest.Text));
            }
        }

        private void TxtPrecoFin_Leave(object sender, EventArgs e)
        {
            if (TxtPrecoFin.Text.Length > 0)
            {
                TxtPrecoFin.Text = string.Format("{0:N2}", Convert.ToDecimal(TxtPrecoFin.Text));
            }
        }

        private void TxtPesoItem_Leave(object sender, EventArgs e)
        {
            if (TxtPesoItem.Text.Length > 0)
            {
                TxtPesoItem.Text = string.Format("{0:N2}", Convert.ToDecimal(TxtPesoItem.Text));
            }
        }

        void CarregarCst()
        {
            ModCst = new Cst();
            ModCfop = new Cfop();

            CboIcms.DataSource = ModCst.ICMS("S");
            CboIpi.DataSource = ModCst.IPI();
            CboCofins.DataSource = ModCst.COFINS();
            CboPis.DataSource = ModCst.PIS();

            CboCfopInterno.DataSource = ModCfop.Interno();
            CboCfopExterno.DataSource = ModCfop.Externo();
        }

        private void grdUnidConv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                
            }
        }
    }
}

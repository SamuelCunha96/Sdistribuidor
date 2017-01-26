using MetroFramework.Forms;
using Sdistribuidor.Entidade;
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
    public partial class FMT012ContaPagar : MetroForm
    {
        public FMT012ContaPagar()
        {
            InitializeComponent();
        }

        List<Entidade_Participante> ListPart = new List<Entidade_Participante>();
        List<Entidade_ContaPagar> ListContPag;
        Entidade_ContaPagar ObjEntContPag;

        Entidade_Participante ObjPart;
        Participante ObjParticipante;
        GrupoFinanc ObjGrupoFinanc;
        ContaPagar ObjContaPagar;

        void CarregarParticipante()
        {
            ObjParticipante = new Participante(); ;

            AutoCompleteStringCollection ParticipanteList = new AutoCompleteStringCollection();

            var ListParticipante = ObjParticipante.Pesquisa();

            for (int i = 0; i < ListParticipante.Rows.Count; i++)
            {
                ObjPart = new Entidade_Participante();
                ObjPart.id = Convert.ToInt32(ListParticipante.Rows[i]["id_participante"]);
                ObjPart.nome = ListParticipante.Rows[i]["nome"].ToString();
                ObjPart.cnpjcpf = ListParticipante.Rows[i]["cnpjcpf"].ToString();
                ListPart.Add(ObjPart);
                ParticipanteList.Add(ObjPart.ParticipanteNomeCpfCnpj);
            }
            TxtFornecedor.AutoCompleteCustomSource = ParticipanteList;
        }

        private void FMT012ContaPagar_Load(object sender, EventArgs e)
        {
            CarregarParticipante();
            CarregarGrupoFinanceiro();
        }

        private void TxtTotal_Leave(object sender, EventArgs e)
        {
            decimal retDec = 0;
            grdparcelas.Rows.Clear();
            if(TxtTotal.Text != string.Empty)
            {
                if (decimal.TryParse(TxtTotal.Text, out retDec))
                {
                    if(Convert.ToDecimal(TxtTotal.Text) > 0)
                    {
                        GerarParcelas();
                    }
                }
                else
                {
                    MessageBox.Show("Valor informado incorreto!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TxtTotal.Text = "0,00";
                }
            }
        }


        void GerarParcelas()
        {
            int qtparcelas = Convert.ToInt32(TxtQtParcelas.Text);
            int diavenc = DtpVencimento.Value.Day;
            int mesvec = DtpVencimento.Value.Month;

            DateTime DtVenc = DtpVencimento.Value;

            for (int i = 0; i < qtparcelas; i++)
            {
                if (Convert.ToDecimal(txtPrazoDias.Text) == 0)
                    grdparcelas.Rows.Add(DtVenc.AddMonths(i).ToShortDateString(), string.Format("{0:n2}", Convert.ToDecimal(TxtTotal.Text) / qtparcelas));
                else
                {
                    grdparcelas.Rows.Add(DtVenc.Date.ToShortDateString(), string.Format("{0:n2}", Convert.ToDecimal(TxtTotal.Text) / qtparcelas));
                    DtVenc = DtVenc.AddDays(Convert.ToDouble(txtPrazoDias.Text));
                }
            }

            decimal vltotal = 0;
            for (int i = 0; i < grdparcelas.Rows.Count; i++)
            {
                vltotal += Convert.ToDecimal(grdparcelas.Rows[i].Cells[1].Value.ToString().Replace(".", ""));
            }

            if(vltotal != Convert.ToDecimal(TxtTotal.Text))
            {
                decimal primeiraparc = Convert.ToDecimal(grdparcelas.Rows[0].Cells[1].Value.ToString().Replace(".", ""));

                decimal diferenca = Convert.ToDecimal(TxtTotal.Text) - vltotal;
                grdparcelas.Rows[0].Cells[1].Value = primeiraparc + diferenca;
            }
        }

        private void TxtQtParcelas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!TxtQtParcelas.Text.Contains(e.KeyChar.ToString()))
            {
                if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
                {
                    e.Handled = true;
                }
            }
        }

        private void TxtTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!TxtTotal.Text.Contains(e.KeyChar.ToString()))
            {
                if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
                {
                    e.Handled = true;
                }
            }
            else if (e.KeyChar.ToString().Trim() == ",")
                e.Handled = true;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaCampos())
            {
                ListContPag = new List<Entidade_ContaPagar>();
                ObjContaPagar = new ContaPagar();
                string MsgErro = string.Empty;
                for (int i = 0; i < grdparcelas.Rows.Count; i++)
                {
                    ObjEntContPag = new Entidade_ContaPagar();
                    ObjEntContPag.participante = ListPart.Where(p => p.ParticipanteNomeCpfCnpj.Contains(TxtFornecedor.Text)).FirstOrDefault();
                    ObjEntContPag.nrdoc = TxtDoc.Text;
                    ObjEntContPag.dtemissao = DtpEmissao.Value;
                    ObjEntContPag.dtvencimento = Convert.ToDateTime(grdparcelas.Rows[i].Cells[0].Value);
                    ObjEntContPag.vlparcela = Convert.ToDecimal(grdparcelas.Rows[i].Cells[1].Value.ToString().Replace(".",""));
                    ObjEntContPag.id_grupocontpag = Convert.ToInt32(CboContaPagar.SelectedValue);
                    ObjEntContPag.stparcela = "A";
                    ListContPag.Add(ObjEntContPag);
                }


                if (ObjContaPagar.Incluir(ListContPag, out MsgErro))
                {
                    MessageBox.Show("Conta incluida com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    LimpaCampos();
                    CarregarParticipante();
                    CarregarGrupoFinanceiro();
                }
            }
        }


        void CarregarGrupoFinanceiro()
        {
            ObjGrupoFinanc = new GrupoFinanc();
            CboContaPagar.DisplayMember = "desc_financeiro";
            CboContaPagar.ValueMember = "id_grupocontpag";
            CboContaPagar.DataSource = ObjGrupoFinanc.Pesquisa();
        }
        bool ValidaCampos()
        {
            if (TxtFornecedor.Text == string.Empty)
            {
                MessageBox.Show("Informe um Fornecedor!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if(ListPart.Where(p => p.ParticipanteNomeCpfCnpj.Contains(TxtFornecedor.Text)).Count() == 0)
            {
                MessageBox.Show("O Fornecedor informado não existe!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (TxtDoc.Text == string.Empty)
            {
                MessageBox.Show("Informe o Documento!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (TxtQtParcelas.Text == string.Empty)
            {
                MessageBox.Show("Informe o número  de parcelas!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (Convert.ToDecimal(TxtTotal.Text) == 0)
            {
                MessageBox.Show("Informe a Quantidade de Parcelas!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (CboContaPagar.SelectedIndex == -1)
            {
                MessageBox.Show("Informe o Grupo Financeiro!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
                return true;
        }

        void LimpaCampos()
        {
            TxtFornecedor.Text = string.Empty;
            TxtDoc.Text = string.Empty;
            DtpEmissao.Value = DateTime.Now;
            DtpVencimento.Value = DateTime.Now;
            TxtQtParcelas.Text = string.Empty;
            TxtTotal.Text = "0,00";
            txtPrazoDias.Text = "0";
            grdparcelas.Rows.Clear();
        }

        private void TxtQtParcelas_Click(object sender, EventArgs e)
        {

        }

        private void txtPrazoDias_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!txtPrazoDias.Text.Contains(e.KeyChar.ToString()))
            {
                if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
                {
                    e.Handled = true;
                }
            }
        }

        private void txtPrazoDias_Leave(object sender, EventArgs e)
        {
            if(txtPrazoDias.Text == string.Empty)
                txtPrazoDias.Text = "0";
        }
    }
}

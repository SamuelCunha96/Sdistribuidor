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
        Entidade_Participante ObjPart;

        Participante ObjParticipante;

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
            }
        }


        void GerarParcelas()
        {
            int qtparcelas = Convert.ToInt32(TxtQtParcelas.Text);
            DateTime DtVenc = DtpVencimento.Value;
            int diavenc = DtpVencimento.Value.Day;
            int mesvec = DtpVencimento.Value.Month;

            for (int i = 0; i < qtparcelas; i++)
            {
                grdparcelas.Rows.Add(DtVenc.Date.AddMonths(i).ToShortDateString(), string.Format("{0:n2}", Convert.ToDecimal(TxtTotal.Text) / qtparcelas));
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
    }
}

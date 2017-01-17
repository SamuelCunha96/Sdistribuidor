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
    public partial class FC004GrupoFinanceiro : MetroForm
    {
        public FC004GrupoFinanceiro()
        {
            InitializeComponent();
        }

        Entidade_GrupoFinanc ObjEntGruFinanc;
        GrupoFinanc ObjGruFinanc;

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            ObjEntGruFinanc = new Entidade_GrupoFinanc();
            string MsgErro = string.Empty;
            if (TxtGrupo.Text != string.Empty)
            {
                ObjGruFinanc = new GrupoFinanc();
                ObjEntGruFinanc.desc_financeiro = TxtGrupo.Text;
                if (ObjGruFinanc.Incluir(ObjEntGruFinanc, out MsgErro))
                {
                    MessageBox.Show("Grupo incluido com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    TxtGrupo.Text = string.Empty;
                    PesquisaDadosCompletos();
                    tcDados.SelectTab(tpLista);
                }
                else
                {
                    MessageBox.Show("Ocorreu o seguinte erro:\n" + MsgErro +"" , "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Informe um nome para o grupo!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void FC004GrupoFinanceiro_Load(object sender, EventArgs e)
        {
            PesquisaDadosCompletos();
        }

        void PesquisaDadosCompletos()
        {
            ObjGruFinanc = new GrupoFinanc();

            //if (GrdFinanc.Rows.Count > 0)
            //    GrdFinanc.Rows.Clear();

            GrdFinanc.AutoGenerateColumns = false;
            GrdFinanc.DataSource = ObjGruFinanc.Pesquisa();
            GrdFinanc.Refresh();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tcDados.SelectTab(tpLista);
            TxtGrupo.Text = string.Empty;
            PesquisaDadosCompletos();
        }
    }
}

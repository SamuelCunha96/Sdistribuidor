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

namespace Sdistribuidor.Relatorio
{
    public partial class FR003Venda : MetroForm
    {
        public FR003Venda()
        {
            InitializeComponent();
        }

        Pedido ObjPedido;
        string StPedido;
        private void BtnVisualizar_Click(object sender, EventArgs e)
        {
            if (ValidarForm())
            {
                FRelatorio ObjFormBase = new FRelatorio();
                ObjPedido = new Pedido();
                if (CboTipoVenda.SelectedIndex == 0)
                {
                    StPedido = "T";
                    ObjFormBase.Titulo = "Relatorio de Vendas - Completo";
                }
                else if (CboTipoVenda.SelectedIndex == 1)
                {
                    ObjFormBase.Titulo = "Relatorio de Vendas - Em Caixa";
                    StPedido = "R";
                }
                else if (CboTipoVenda.SelectedIndex == 2)
                {
                    ObjFormBase.Titulo = "Relatorio de Vendas - Cancelados";
                    StPedido = "C";
                }
                else if (CboTipoVenda.SelectedIndex == 3)
                {
                    ObjFormBase.Titulo = "Relatorio de Vendas - Associado a NFe";
                    StPedido = "N";
                }
                ObjFormBase.DtBaseLoad = ObjPedido.RelatorioVenda(DtIni.Value, DtFim.Value, StPedido);

                ObjFormBase.DtIni = DtIni.Value;
                ObjFormBase.DtFim = DtFim.Value;
                ObjFormBase.NmRelatorioBaseLoad = "Sdistribuidor.Relatorio.R003Venda.rdlc";
                ObjFormBase.NmDataSet = "DsVenda";
                if(ObjFormBase.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        bool ValidarForm()
        {
            if (CboTipoVenda.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um tipo de Venda.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
                return true;
        }
    }
}

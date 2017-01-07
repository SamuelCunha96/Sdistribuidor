using Microsoft.Reporting.WinForms;
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

namespace Sdistribuidor.Relatorio
{
    public partial class FRImpPedido : Form
    {
        public FRImpPedido()
        {
            InitializeComponent();
        }

        public int IdPedido { get; set; }
        Pedido ObjPedido;
        List<Entidade_ItemPedido> ListItemPedido;
        private void FRImpPedido_Load(object sender, EventArgs e)
        {
            ObjPedido = new Pedido();
            var DtRetPedido = ObjPedido.View_ImpressaoPedido(IdPedido);

            ReportDataSource dsReport = new ReportDataSource("DsPedido", DtRetPedido);
            
            this.rvPedido.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(SubreportProcessingEventHandler);
            this.rvPedido.LocalReport.DataSources.Clear();
            this.rvPedido.LocalReport.DataSources.Add(dsReport);
            this.rvPedido.LocalReport.Refresh();

            this.rvPedido.RefreshReport();
        }

        void SubreportProcessingEventHandler(object sender, SubreportProcessingEventArgs e)
        {
            ObjPedido = new Pedido();
            var DtRetItemPedido = ObjPedido.View_ImpressaoItemPedido(IdPedido);
            ReportDataSource dsSubReport = new ReportDataSource("DsItemPedido", DtRetItemPedido);
            e.DataSources.Add(dsSubReport);
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}

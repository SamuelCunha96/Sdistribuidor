using Microsoft.Reporting.WinForms;
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
    public partial class FRelatorio : Form
    {
        public FRelatorio()
        {
            InitializeComponent();
        }


        public DataTable DtBaseLoad { get; set; }
        public string NmRelatorioBaseLoad { get; set; }
        public string NmDataSet { get; set; }
        public DateTime DtIni { get; set; }
        public DateTime DtFim { get; set; }
        public string Titulo { get; set; }
        private void FRelatorio_Load(object sender, EventArgs e)
        {
            this.RVBase.LocalReport.ReportEmbeddedResource = NmRelatorioBaseLoad;
            ReportDataSource ReportDs = new ReportDataSource();
            ReportDs.Name = NmDataSet;
            ReportDs.Value = DtBaseLoad;
            ReportParameter ParameterDtIni = new ReportParameter("DtIni", DtIni.ToShortDateString());
            ReportParameter ParameterDtFim = new ReportParameter("DtFim", DtFim.ToShortDateString());
            if (!string.IsNullOrEmpty(Titulo))
            {
                ReportParameter ParameterTitulo = new ReportParameter("Titulo", Titulo);
                this.RVBase.LocalReport.SetParameters(ParameterTitulo);
            }
            this.RVBase.LocalReport.SetParameters(ParameterDtIni);
            this.RVBase.LocalReport.SetParameters(ParameterDtFim);
            this.RVBase.LocalReport.DataSources.Add(ReportDs);
            this.RVBase.RefreshReport();
        }
    }
}

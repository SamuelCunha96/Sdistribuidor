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
using Sdistribuidor.Entidade;
using Sdistribuidor.Model;

namespace Sdistribuidor.Relatorio
{
    public partial class FRDanfe : Form
    {
        public FRDanfe()
        {
            InitializeComponent();
        }

        Entidade_NotaFiscal ObjNFe;
        private void FRDanfe_Load(object sender, EventArgs e)
        {
            NotaFiscal ObjNF = new NotaFiscal();
            var DtRet = ObjNF.PesquisaNFe("1", 16);
            ReportDataSource dsReport = new ReportDataSource("DSNFSaida", DtRet);
            this.RVDanfeNFe.LocalReport.DataSources.Clear();
            this.RVDanfeNFe.LocalReport.DataSources.Add(dsReport);
            this.RVDanfeNFe.LocalReport.Refresh();
            this.RVDanfeNFe.RefreshReport();
        }

        private void RVDanfeNFe_Load(object sender, EventArgs e)
        {

        }
    }
}

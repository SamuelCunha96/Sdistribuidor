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
using BarcodeLib;

namespace Sdistribuidor.Relatorio
{
    public partial class FRDanfe : Form
    {
        public FRDanfe()
        {
            InitializeComponent();
        }

        Entidade_NotaFiscal ObjNFe;
        NotaFiscal ObjNF;

        public int Loja { get; set; }
        public int NrNFe { get; set; }
        public string NmSerieNFe { get; set; }

        private void FRDanfe_Load(object sender, EventArgs e)
        {
            ObjNF = new NotaFiscal();
            
            var DtRet = ObjNF.PesquisaNFe(NmSerieNFe, NrNFe);

            ReportDataSource dsReport = new ReportDataSource("DSNFSaida", DtRet);

            Barcode b128C = new Barcode(DtRet.Rows[0]["TxChAcessoNfe"].ToString(), TYPE.CODE128C);
            
            b128C.Encode(TYPE.CODE128C, DtRet.Rows[0]["TxChAcessoNfe"].ToString(),Color.Black,Color.White, 300,40);
            
            var strBase64 = Convert.ToBase64String(b128C.Encoded_Image_Bytes);

            ReportParameter ObjPara = new ReportParameter("ImgCodBarra", strBase64,true);

            this.RVDanfeNFe.LocalReport.SetParameters(ObjPara);

            this.RVDanfeNFe.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(SubreportProcessingEventHandler);
            this.RVDanfeNFe.LocalReport.DataSources.Clear();
            this.RVDanfeNFe.LocalReport.DataSources.Add(dsReport);
            this.RVDanfeNFe.LocalReport.Refresh();
            
            this.RVDanfeNFe.RefreshReport();

            this.Cursor = Cursors.Default;
        }

        void SubreportProcessingEventHandler(object sender, SubreportProcessingEventArgs e)
        {
            ObjNF = new NotaFiscal();
            var DtRetItem = ObjNF.PesquisaItemNFe(NmSerieNFe, NrNFe);
            ReportDataSource dsSubReport = new ReportDataSource("DsItemNFe", DtRetItem);
            e.DataSources.Add(dsSubReport);
        }

        private void RVDanfeNFe_Load(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class FR006Carne : Form
    {
        public FR006Carne()
        {
            InitializeComponent();
        }
        Duplicata ObjDuplicata;
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            FRelatorio ObjFormRelatorioBase = new FRelatorio();
            ObjDuplicata = new Duplicata();
            var DtRetCarne = ObjDuplicata.Carne(2);

            //ObjFormRelatorioBase.DtIni = DtIni.Value;
            //ObjFormRelatorioBase.DtFim = DtFim.Value;
            ObjFormRelatorioBase.FlContemDataEmissao = false;
            ObjFormRelatorioBase.NmDataSet = "DsDuplicata";
            ObjFormRelatorioBase.DtBaseLoad = DtRetCarne;
            ObjFormRelatorioBase.NmRelatorioBaseLoad = "Sdistribuidor.Relatorio.R006Carne.rdlc";

            ObjFormRelatorioBase.ShowDialog();
        }
    }
}

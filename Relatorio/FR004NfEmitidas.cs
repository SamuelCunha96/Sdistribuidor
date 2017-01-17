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
    public partial class FR004NfEmitidas : MetroForm
    {
        public FR004NfEmitidas()
        {
            InitializeComponent();
        }

        NotaFiscal ObjNFEmitida = new NotaFiscal();
        private void BtnVisualizar_Click(object sender, EventArgs e)
        {
            string VrSql = string.Empty;
            string VrSqlSemRetorno = string.Empty;
            foreach (int item in ChkListStNFe.CheckedIndices)
            {
                switch (item)
                {
                    case 0://Esperando aprovação
                        VrSqlSemRetorno = " CdRetorno IS NULL OR ";
                        break;

                    case 1:/*Rejeitada*/
                        VrSql += ",225";
                        break;

                    case 2:/*Autorizada*/
                        VrSql += ",100";
                        break;
                    case 3:/*Cancelados*/
                        VrSql += ",101";
                        break;
                    case 4:/*Inutilizados*/
                        VrSql += ",102";
                        break;
                    case 5:/*Denegadas e Irregularidade*/
                        VrSql += ",301,302,303";
                        break;
                }
            }


            if(VrSql.Substring(0,1) == ",")
            {
                VrSql = "CdRetorno in (" + VrSql.Substring(1, VrSql.Count() - 1) + ") AND ";
            }
            else
            {
                VrSql = "CdRetorno in (" + VrSql + ") AND ";
            }

            VrSql = VrSqlSemRetorno + VrSql;

            FRelatorio ObjFormRelatorioBase = new FRelatorio();

            ObjFormRelatorioBase.DtIni = DtIni.Value;
            ObjFormRelatorioBase.DtFim = DtFim.Value;
            ObjFormRelatorioBase.NmDataSet = "DsNFEmitida";
            ObjFormRelatorioBase.DtBaseLoad = ObjNFEmitida.ConsultaNotasEmitidas(DtIni.Value, DtFim.Value, VrSql);
            ObjFormRelatorioBase.NmRelatorioBaseLoad = "Sdistribuidor.Relatorio.R004NotasEmitidas.rdlc";

            ObjFormRelatorioBase.ShowDialog();



        }
    }
}

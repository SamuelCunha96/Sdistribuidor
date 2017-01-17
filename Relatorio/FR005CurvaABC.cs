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
    public partial class FR005CurvaABC : MetroForm
    {
        public FR005CurvaABC()
        {
            InitializeComponent();
        }

        Pedido ObjPedido;

        private void BtnVisualizar_Click(object sender, EventArgs e)
        {
            ObjPedido = new Pedido();

            var DtRetABC = CalculaPorcentagemAcumulada(ObjPedido.RelatorioCurvaABC(DtIni.Value, DtFim.Value));

            FRelatorio ObjFormRelatorioBase = new FRelatorio();

            ObjFormRelatorioBase.DtIni = DtIni.Value;
            ObjFormRelatorioBase.DtFim = DtFim.Value;
            ObjFormRelatorioBase.NmDataSet = "DsCurvaABC";
            ObjFormRelatorioBase.DtBaseLoad = DtRetABC;
            ObjFormRelatorioBase.NmRelatorioBaseLoad = "Sdistribuidor.Relatorio.R005CurvaABC.rdlc";

            ObjFormRelatorioBase.ShowDialog();
        }

        public DataTable CalculaPorcentagemAcumulada(DataTable DtABC)
        {
            DataTable DtABCNew = new DataTable("DtABCNew");

            DtABCNew.Columns.Add("Id_produto", typeof(Int32));
            DtABCNew.Columns.Add("Descricao", typeof(string));
            DtABCNew.Columns.Add("Qtdvendido", typeof(decimal));
            DtABCNew.Columns.Add("Vl_unitario", typeof(decimal));
            DtABCNew.Columns.Add("TotalVendido", typeof(decimal));
            DtABCNew.Columns.Add("Porcentagem", typeof(decimal));
            DtABCNew.Columns.Add("PorcentagemAcumulada", typeof(decimal));
            DtABCNew.Columns.Add("Classeabc", typeof(string));


            for (int i = 0; i < DtABC.Rows.Count; i++)
            {
                string CodProduto = DtABC.Rows[i]["id_produto"].ToString().Trim();
                decimal PorcentagemAcumulada = 0;
                string ClasseABC = string.Empty;
                for (int j = 0; j < DtABC.Rows.Count; j++)
                {
                    if (DtABC.Rows[j]["id_produto"].ToString().Trim().Equals(CodProduto))
                    {
                        PorcentagemAcumulada += Convert.ToDecimal(DtABC.Rows[j]["porcentagem"].ToString());
                        break;
                    }
                    else
                    {
                        PorcentagemAcumulada += Convert.ToDecimal(DtABC.Rows[j]["porcentagem"].ToString());
                    }
                }

                if(PorcentagemAcumulada <= 80)
                {
                    ClasseABC = "A";
                }
                else if (PorcentagemAcumulada <= 95)
                {
                    ClasseABC = "B";
                }
                else
                    ClasseABC = "C";

                DtABCNew.Rows.Add(DtABC.Rows[i]["id_produto"], DtABC.Rows[i]["descricao"], DtABC.Rows[i]["qtdvendido"], DtABC.Rows[i]["vl_unitario"], DtABC.Rows[i]["totalvendido"], DtABC.Rows[i]["porcentagem"], PorcentagemAcumulada,ClasseABC);
            }

            return DtABCNew;
        }
    }
}



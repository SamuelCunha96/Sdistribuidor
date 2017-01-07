using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sdistribuidor.View;
using Sdistribuidor.Model;
using Sdistribuidor.Entidade;
using Sdistribuidor.Relatorio;

namespace Sdistribuidor
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Loja mLoja = new Loja();
            Entidade_GeralInformcoes.idloja = 1;
            Entidade_GeralInformcoes.idusuario = 1;
            
            var DtLoja = mLoja.Pesquisa(1);

            Entidade_GeralInformcoes.uf = DtLoja.Rows[0]["desc_uf"].ToString();
            Entidade_GeralInformcoes.TipoEmpresa = Convert.ToInt32(DtLoja.Rows[0]["tipo_regime"]);

            FRImpPedido ObjForm = new FRImpPedido();

            ObjForm.IdPedido = 26;
            ObjForm.Show();


            Application.Run(new FMenu());
        }
    }
}

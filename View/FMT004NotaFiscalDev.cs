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
    public partial class FMT004NotaFiscalDev : Form
    {
        public FMT004NotaFiscalDev()
        {
            InitializeComponent();
        }

        private void btnParticipante_Click(object sender, EventArgs e)
        {
            FP002Cliente ObjPesquisar = new FP002Cliente();

            if (ObjPesquisar.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                lblID.Text = Convert.ToString(ObjPesquisar.ID);
                lblCliente.Text = ObjPesquisar.Nome;
            }
        }
    }
}

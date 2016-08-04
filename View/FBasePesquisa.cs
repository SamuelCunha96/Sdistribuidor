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
    public partial class FBasePesquisa : Form
    {
        public FBasePesquisa()
        {
            InitializeComponent();
        }

        public int ID;
        public string Nome;
        public virtual void LimpaCampos()
        {
            grdBase.Columns.Clear();
        }
        public virtual void CamposGrid()
        {

        }

        public virtual void PesquisarDados(string Pesquisar, object ID)
        {

        }
        public virtual void CarregarDados()
        {
            
        }

        public void PreencherCamposDados()
        {
            CamposGrid();
            CarregarDados();
        }

        private void FBasePesquisa_Load(object sender, EventArgs e)
        {
            PreencherCamposDados();
        }

        private void grdBase_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != - 1)
            {
                DialogResult = DialogResult.OK;
                ID = Convert.ToInt32(grdBase.Rows[e.RowIndex].Cells[0].Value);
                Nome = grdBase.Rows[e.RowIndex].Cells[2].Value.ToString();
                this.Close();
            }
        }
    }
}

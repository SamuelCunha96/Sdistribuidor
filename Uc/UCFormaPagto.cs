using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sdistribuidor.Model;
using Sdistribuidor.Entidade;

namespace Sdistribuidor.Uc
{
    public partial class UCFormaPagto : UserControl
    {
        public UCFormaPagto()
        {
            InitializeComponent();
        }

        FormaPagtoItemFormaPagto ObjForma = new FormaPagtoItemFormaPagto();

        public Entidade_FormaPagto GetFormaPagamento
        {
            get
            {
                return ObjForma.Pesquisa(Convert.ToInt32(CboFormaPagto.SelectedValue));
            }
        }

        public void CarregarFormaPagamento()
        {
            CboFormaPagto.DisplayMember = "desc_formapagto";
            CboFormaPagto.ValueMember = "idformapagto";
            if (ObjForma.Pesquisa() != null)
                CboFormaPagto.DataSource = ObjForma.Pesquisa();
        }
        public bool ValidaCampos()
        {
            if (CboFormaPagto.SelectedValue == null && CboFormaPagto.SelectedText.Trim() == string.Empty)
            {
                MessageBox.Show("Selecione a forma de pagamento!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}

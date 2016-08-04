using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Sdistribuidor.Model;

namespace Sdistribuidor.Uc
{
    public partial class UCGrupo : UserControl
    {
        public UCGrupo()
        {
            InitializeComponent();
        }
        Grupo mGrupo;

        public int IdGrupo
        {
            get
            {
                if (CboGrupo.SelectedValue == null)
                    return 0;
                else
                    return Convert.ToInt32(CboGrupo.SelectedValue.ToString());
            }
            set
            {
                CboGrupo.SelectedValue = value;
            }
        }

        public void Preecher()
        {
            mGrupo = new Grupo();
            CboGrupo.DisplayMember = "nmgrupo";
            CboGrupo.ValueMember = "id_grupo";
            CboGrupo.DataSource = mGrupo.Lista();
        }

        private void CboGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}

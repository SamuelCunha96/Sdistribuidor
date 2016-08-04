using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Sdistribuidor.Model;
using Sdistribuidor.Entidade;

namespace Sdistribuidor.Uc
{
    public partial class UCUnidade : UserControl
    {
        public UCUnidade()
        {
            InitializeComponent();
        }

        Unidade mUnidade;

        public string Unidade
        {
            get
            {
                if (CboUnidade.SelectedValue == null)
                    return string.Empty;
                else
                    return CboUnidade.SelectedValue.ToString();
            }
            set
            {
                CboUnidade.SelectedValue = value;
            }
        }

        public Entidade_Unidade GetUnidade
        {
            get
            {
                mUnidade = new Unidade();
                if (CboUnidade.SelectedValue != null)
                    return mUnidade.Pesquisa(CboUnidade.SelectedValue.ToString());
                else
                    return null;
            }
        }

        public void Preecher()
        {
            mUnidade = new Unidade();
            CboUnidade.DisplayMember = "UnidadeDesc";
            CboUnidade.ValueMember = "CdUnidade";
            CboUnidade.DataSource = mUnidade.Pesquisa();
        }
    }
}

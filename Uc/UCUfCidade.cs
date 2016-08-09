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

namespace Sdistribuidor.View.UC
{
    public partial class UCUfCidade : UserControl
    {
        public UCUfCidade()
        {
            InitializeComponent();
        }

        UF modUf;
        Cidade modCidade;

        public int IdCidade 
        {
            get
            {
                if (CboCidade.SelectedValue != null)
                    return int.Parse(CboCidade.SelectedValue.ToString());
                else
                    return 0;
            }
            set
            {
                CboCidade.SelectedValue = value;
            }
        }
        public int IdUf
        {
            get
            {
                if (CboUF.SelectedValue != null)
                    return int.Parse(CboUF.SelectedValue.ToString());
                else
                    return 0;
            }
            set
            {
                CboUF.SelectedValue = value;
                Cidade(value);
            }
        }

        public Entidade_UF GetUF
        {
            get
            {
                modUf = new UF();
                if (CboUF.SelectedValue != null)
                    return  modUf.Pesquisa(Convert.ToInt32(CboUF.SelectedValue.ToString()));
                else
                    return null;
            }
        }
        public Entidade_Cidade GetCidade
        {
            get
            {
                modCidade = new Cidade();
                if (CboUF.SelectedValue != null)
                    return modCidade.Pesquisa(Convert.ToInt32(CboCidade.SelectedValue));
                else
                    return null;
            }
        }

        private void UCUfCidade_Load(object sender, EventArgs e)
        {
            
        }
        public void CarregarCombos()
        {
            Uf();
        }
        void Uf()
        {
            modUf = new UF();
            CboUF.DisplayMember = "desc_uf";
            CboUF.ValueMember = "id_uf";
            CboUF.DataSource = modUf.Pesquisa();
        }
        void Cidade(int iduf)
        {
            modUf = new UF();
            modCidade = new Model.Cidade();
            CboCidade.DisplayMember = "desc_municipio";
            CboCidade.ValueMember = "id";
            var retUF = modUf.Pesquisa(iduf);
            CboCidade.DataSource = modCidade.PesquisaUFCidade(retUF.id_uf);
        }
        public bool ValidarCampos()
        {
            if (CboUF.Text == string.Empty)
            {
                MessageBox.Show("Uf obrigatório.");
                return false;
            }
            else if (CboCidade.Text == string.Empty)
            {
                MessageBox.Show("Cidade obrigatória.");
                return false;
            }
            else
                return true;
        }

        private void CboUF_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Cidade(IdUf);
        }
    }

}

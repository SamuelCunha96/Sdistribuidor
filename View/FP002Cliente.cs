using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Sdistribuidor.Model;


namespace Sdistribuidor.View
{
    public partial class FP002Cliente : Sdistribuidor.View.FBasePesquisa
    {
        public FP002Cliente()
        {
            InitializeComponent();
        }

        DataGridViewTextBoxColumn NewText;

        Participante mParticipante;

        public override void CarregarDados()
        {
            mParticipante = new Participante();
            grdBase.AutoGenerateColumns = false;
            grdBase.DataSource = mParticipante.Pesquisa();
        }

        public override void CamposGrid()
        {
            NewText = new DataGridViewTextBoxColumn();
            NewText.HeaderText = "Código";
            NewText.Name = "ColID";
            NewText.DataPropertyName = "id_participante";
            NewText.Width = 60;

            grdBase.Columns.Add(NewText);

            NewText = new DataGridViewTextBoxColumn();
            NewText.HeaderText = "Cpf/Cnpj";
            NewText.Name = "ColCpfCnpj";
            NewText.DataPropertyName = "cnpjcpf";
            NewText.Width = 100;

            grdBase.Columns.Add(NewText);

            NewText = new DataGridViewTextBoxColumn();
            NewText.HeaderText = "Descrição";
            NewText.Name = "ColDesc";
            NewText.DataPropertyName = "nome";
            NewText.Width = 350;

            grdBase.Columns.Add(NewText);
        }
    }
}

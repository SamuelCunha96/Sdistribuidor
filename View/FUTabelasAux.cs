using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sdistribuidor.Entidade;
using Sdistribuidor.Model;

namespace Sdistribuidor.View
{
    public partial class FUTabelasAux : Form
    {
        public FUTabelasAux()
        {
            InitializeComponent();
        }

        Entidade_UF ObjEntUF;
        Entidade_Cidade ObjEntCid;
        Entidade_Cfop ObjCfop;
        Entidade_Cst ObjCst;
        UF ModUF;
        Cidade ModCidade;
        Cfop ModCfop;
        Cst ModCst;
        private void btIncluir_Click(object sender, EventArgs e)
        {
            string i;
            string ret;
            string MsgRetErro;
            string sLine = "";
            string[] campo = null;
            Regex re;
            StreamReader objReader;
            ObjEntUF = new Entidade_UF();
            ObjEntCid = new Entidade_Cidade();
            ObjCfop = new Entidade_Cfop();

            ModUF = new UF();
            ModCidade = new Cidade();
            ModCfop = new Cfop();
            ModCst = new Cst();

            if (ChkListAux.GetItemChecked(0))
            {
                objReader = new StreamReader(@"D:\ProjetosSistemas\SI\SI\TabelasAux\Estados.txt");
                re = new Regex("\r\n");
                i = objReader.ReadToEnd();
                ret = Convert.ToString(re.Matches(i).Count + 1);

                pbAux.Minimum = 0;
                pbAux.Maximum = 0;
                pbAux.Minimum = 0;
                pbAux.Maximum = int.Parse(ret);

                objReader = new StreamReader(@"D:\ProjetosSistemas\SI\SI\TabelasAux\Estados.txt");

                while (sLine != null)
                {
                    sLine = objReader.ReadLine();
                    if (sLine != null)
                    {
                        campo = sLine.Split(new char[] { '|' });

                        ObjEntUF = new Entidade_UF();

                        ObjEntUF.id_uf = Convert.ToInt32(campo[0].ToString());
                        ObjEntUF.desc_uf = campo[1].ToString();
                        ObjEntUF.nome_uf = campo[2].ToString();
                        var objRet = ModUF.Pesquisa(ObjEntUF.id_uf);
                        //if (objRet == null)
                        //    ModUF.Incluir(ObjEntUF);
                        //else
                        //    ModUF.Update(ObjEntUF);

                        pbAux.Value++; // Auto Incremento progress bar
                        pbAux.Update();
                        this.Update();
                    }
                }
            }
            if (ChkListAux.GetItemChecked(1))
            {
                objReader = new StreamReader(@"D:\ProjetosSistemas\SI\SI\TabelasAux\Cidades.txt");
                re = new Regex("\r\n");
                i = objReader.ReadToEnd();
                ret = Convert.ToString(re.Matches(i).Count + 1);

                pbAux.Minimum = 0;
                pbAux.Maximum = 0;
                pbAux.Minimum = 0;
                pbAux.Maximum = int.Parse(ret);

                objReader = new StreamReader(@"D:\ProjetosSistemas\SI\SI\TabelasAux\Cidades.txt",UTF8Encoding.Default);

                while (sLine != null)
                {
                    sLine = objReader.ReadLine();
                    if (sLine != null)
                    {
                        campo = sLine.Split(new char[] { '|' });

                        ObjEntCid = new Entidade_Cidade();
                        ObjEntUF = new Entidade_UF();

                        ObjEntCid.desc_municipio = campo[1].ToString();
                        ObjEntCid.id_ibge = campo[0].ToString();
                        ObjEntCid.id_uf = ModUF.Pesquisa(Convert.ToInt32(campo[0].ToString().Substring(0,2)));

                        var objRet = ModCidade.PesquisaCidadeIbge(ObjEntCid.id_ibge, out MsgRetErro);

                        //if (objRet == null)
                        //    ModCidade.Incluir(ObjEntCid);
                        //else
                        //{
                        //    ObjEntCid.id = objRet.id;
                        //    ModCidade.Update(ObjEntCid);
                        //}

                        pbAux.Value++; // Auto Incremento progress bar
                        pbAux.Update();
                        this.Update();
                    }
                }
            }
            if (ChkListAux.GetItemChecked(2))
            {

            }
            if (ChkListAux.GetItemChecked(3))
            {
                
                objReader = new StreamReader(@"C:\Users\dp\Documents\Sistemas\Sdistribuidor\TabelasAux\CFOP.txt");
                re = new Regex("\r\n");
                i = objReader.ReadToEnd();
                ret = Convert.ToString(re.Matches(i).Count + 1);

                pbAux.Minimum = 0;
                pbAux.Maximum = 0;
                pbAux.Minimum = 0;
                pbAux.Maximum = int.Parse(ret);

                objReader = new StreamReader(@"C:\Users\dp\Documents\Sistemas\Sdistribuidor\TabelasAux\CFOP.txt", UTF8Encoding.Default);

                while (sLine != null)
                {
                    sLine = objReader.ReadLine();
                    if (sLine != null)
                    {
                        campo = sLine.Split(new char[] { '|' });

                        ObjCfop.cfop = Convert.ToInt32(campo[0].ToString());
                        ObjCfop.descricao = campo[1].ToString();

                        var objRetCfop = ModCfop.Pesquisa(ObjCfop.cfop);

                        if (objRetCfop == null)
                            ModCfop.Incluir(ObjCfop);
                        else
                            ModCfop.Update(ObjCfop);

                        pbAux.Value++; // Auto Incremento progress bar
                        pbAux.Update();
                        this.Update();
                    }
                }
                MessageBox.Show("Cfop`s cadastrados com sucesso.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            if (ChkListAux.GetItemChecked(4))
            {
                objReader = new StreamReader(@"C:\Users\dp\Documents\Sistemas\Sdistribuidor\TabelasAux\Cst.txt");
                re = new Regex("\r\n");
                i = objReader.ReadToEnd();
                ret = Convert.ToString(re.Matches(i).Count + 1);

                pbAux.Minimum = 0;
                pbAux.Maximum = 0;
                pbAux.Minimum = 0;
                pbAux.Maximum = int.Parse(ret);

                objReader = new StreamReader(@"C:\Users\dp\Documents\Sistemas\Sdistribuidor\TabelasAux\Cst.txt", UTF8Encoding.Default);
                ModCst = new Cst();

                while (sLine != null)
                {
                    sLine = objReader.ReadLine();
                    if (sLine != null)
                    {
                        ObjCst = new Entidade_Cst();

                        campo = sLine.Split(new char[] { '|' });

                        ObjCst.cst = campo[0].ToString();
                        ObjCst.descricao = campo[1].ToString();
                        ObjCst.codigo_origem = campo[2].ToString();
                        ObjCst.tipo_icms = campo[3].ToString();

                        var objRetCst = ModCst.Pesquisa(ObjCst.cst);

                        if (objRetCst == null)
                            ModCst.Incluir(ObjCst);
                        else
                            ModCst.Update(ObjCst);

                        pbAux.Value++; // Auto Incremento progress bar
                        pbAux.Update();
                        this.Update();
                    }
                }
                MessageBox.Show("Cst`s cadastrados com sucesso.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }
    }
}

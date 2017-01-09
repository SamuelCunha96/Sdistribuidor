using Sdistribuidor.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Sdistribuidor.Gerais
{
    public class XmlNFeEntrada
    {
        XmlDocument xmlDOC = new XmlDocument();
        XmlNode node;
        FuncoesGerais FunGerais;
        Entidade_NotaFiscal _NotaFiscal;
        Entidade_TotaisNota _TotalNf;
        Entidade_Participante _Participante;
        Entidade_ItemNFe _ItensNotaFiscal;
        Entidade_Fatura _Fatura;
        Entidade_Cidade _Cidade;
        Entidade_UF _Uf;
        List<Entidade_Fatura> _ListFatura;
        List<Entidade_ItemNFe> _ListItensNotaFiscal;


        string[,] itensnfe = new string[200, 12];
        string[,] tribIcms = new string[200, 8];
        string[,] tribIpi = new string[200, 4];
        string[,] tribPis = new string[200, 4];
        string[,] tribConfis = new string[200, 4];
        string[,] duplatasnfe = new string[100, 3];
        string[,] tribTot = new string[100, 1];


        #region -------------- Ler Xml --------------
        public void LerXml(string XmlLoadPath, string XmlNFe, out Entidade_TotaisNota _OutTotaisNota, out Entidade_NotaFiscal _OutNotaFiscal, out List<Entidade_Fatura> _ListOutFatura, out List<Entidade_ItemNFe> _LisOutItens)
        {
            int j = 0;
            int d = 0;

            FunGerais = new FuncoesGerais();
            _NotaFiscal = new Entidade_NotaFiscal();
            _TotalNf = new Entidade_TotaisNota();
            _Participante = new Entidade_Participante();
            _Cidade = new Entidade_Cidade();
            _Uf = new Entidade_UF();
            _Fatura = new Entidade_Fatura();
            _ListFatura = new List<Entidade_Fatura>();
            _ItensNotaFiscal = new Entidade_ItemNFe();
            _ListItensNotaFiscal = new List<Entidade_ItemNFe>();

            if(XmlLoadPath != string.Empty)
            {
                xmlDOC.Load(XmlLoadPath);
            }
            else
            {
                xmlDOC.LoadXml(XmlNFe);
            }            

            node = xmlDOC.DocumentElement;

            foreach (XmlNode xnode1 in node.ChildNodes)
            {
                foreach (XmlNode xnode2 in xnode1.ChildNodes)
                {
                    foreach (XmlNode xnode3 in xnode2.ChildNodes)
                    {
                        switch (xnode3.Name)
                        {
                            case "ide":
                                foreach (XmlNode xnode4 in xnode3.ChildNodes)
                                {
                                    if (xnode4.Name == "serie")
                                    {
                                        _NotaFiscal.serienf = xnode4.InnerText;
                                    }
                                    else if (xnode4.Name == "nNF")
                                    {
                                        _NotaFiscal.nrnf = int.Parse(xnode4.InnerText);
                                    }
                                    else if (xnode4.Name == "dhEmi")
                                    {
                                        _NotaFiscal.dtemissao = Convert.ToDateTime(xnode4.InnerText);
                                    }
                                    else if (xnode4.Name == "mod")
                                    {
                                        _NotaFiscal.modeloNFe = Convert.ToInt32(xnode4.InnerText);
                                    }
                                    else if (xnode4.Name == "indPag")
                                    {
                                        _NotaFiscal.id_formapagto = Convert.ToInt32(xnode4.InnerText);
                                    }
                                }
                                break;
                            case "emit":
                                foreach (XmlNode xnode4 in xnode3.ChildNodes)
                                {
                                    if (xnode4.Name == "CNPJ")
                                    {
                                        _Participante.cnpjcpf = xnode4.InnerText;
                                    }
                                    else if (xnode4.Name == "xNome")
                                    {
                                        _Participante.nome = xnode4.InnerText;
                                        _Participante.razaosocial = xnode4.InnerText;
                                        _Participante.nomefantasia = xnode4.InnerText;
                                    }
                                    else if (xnode4.Name == "IE")
                                    {
                                        _Participante.ie = xnode4.InnerText;
                                    }
                                    else if (xnode4.Name == "enderEmit")
                                    {
                                        foreach (XmlNode xnode5 in xnode4.ChildNodes)
                                        {
                                            if (xnode5.Name == "xLgr")
                                            {
                                                _Participante.lagradouro = xnode5.InnerText;
                                            }
                                            else if (xnode5.Name == "nro")
                                            {
                                                _Participante.numero_end = xnode5.InnerText.Trim() == string.Empty ? xnode5.InnerText : "0";
                                            }
                                            else if (xnode5.Name == "xBairro")
                                            {
                                                _Participante.bairro = xnode5.InnerText;
                                            }
                                            else if (xnode5.Name == "cMun")
                                            {
                                                _Cidade.id_ibge = xnode5.InnerText;
                                            }
                                            else if (xnode5.Name == "xMun")
                                            {
                                                _Cidade.desc_municipio = xnode5.InnerText;
                                            }
                                            else if (xnode5.Name == "UF")
                                            {
                                                _Uf.nome_uf = xnode5.InnerText;
                                            }
                                            else if (xnode5.Name == "CEP")
                                            {
                                                _Participante.cep = xnode5.InnerText;
                                            }
                                            else if (xnode5.Name == "fone")
                                            {
                                                _Participante.telefone = xnode5.InnerText;
                                            }
                                        }
                                        _Participante.id_uf = _Uf;
                                        _Participante.id_cidade = _Cidade;
                                    }
                                }
                                _NotaFiscal.id_participante = _Participante;
                                break;
                            //case "dest":
                            //    j++;
                            //    foreach (XmlNode xnode4 in xnode3.ChildNodes)
                            //    {
                            //        if (xnode4.Name == "CNPJ")
                            //        {
                            //            txtCNPJdest.Text = xnode4.InnerText;
                            //        }
                            //        else if (xnode4.Name == "xNome")
                            //        {
                            //            txtNomeDest.Text = xnode4.InnerText;
                            //        }
                            //        else if (xnode4.Name == "enderDest")
                            //        {
                            //            foreach (XmlNode xnode5 in xnode4.ChildNodes)
                            //            {
                            //                if (xnode5.Name == "xLgr")
                            //                {
                            //                    txtLgrDes.Text = xnode5.InnerText;
                            //                }
                            //                else if (xnode5.Name == "nro")
                            //                {
                            //                    txtNrDest.Text = xnode5.InnerText;
                            //                }
                            //                else if (xnode5.Name == "xBairro")
                            //                {
                            //                    txtBarrioDest.Text = xnode5.InnerText;
                            //                }
                            //                else if (xnode5.Name == "xMun")
                            //                {
                            //                    txtMunDest.Text = xnode5.InnerText;
                            //                }
                            //                else if (xnode5.Name == "CEP")
                            //                {
                            //                    txtCEPDest.Text = xnode5.InnerText;
                            //                }
                            //                else if (xnode5.Name == "fone")
                            //                {
                            //                    txtFoneDest.Text = xnode5.InnerText;
                            //                }
                            //            }
                            //        }

                            //    }
                            //    break;
                            //case "entrega":
                            //    foreach (XmlNode xnode4 in xnode3.ChildNodes)
                            //    {
                            //        if (xnode4.Name == "xLgr")
                            //        {
                            //            txtLgrEntrega.Text = xnode4.InnerText;
                            //        }
                            //        else if (xnode4.Name == "nro")
                            //        {
                            //            txtNrEntrega.Text = xnode4.InnerText;
                            //        }
                            //        else if (xnode4.Name == "xBairro")
                            //        {
                            //            txtBairroEntrega.Text = xnode4.InnerText;
                            //        }
                            //        else if (xnode4.Name == "xMun")
                            //        {
                            //            txtMunEntrega.Text = xnode4.InnerText;
                            //        }
                            //    }
                            //    break;
                            case "det":
                                j++;
                                foreach (XmlNode xnode4 in xnode3.ChildNodes)
                                {
                                    if (xnode4.Name == "prod")
                                    {
                                        foreach (XmlNode xnode5 in xnode4.ChildNodes)
                                        {
                                            if (xnode5.Name == "cProd")
                                            {
                                                itensnfe[j, 0] = xnode5.InnerText;
                                            }
                                            else if (xnode5.Name == "xProd")
                                            {
                                                itensnfe[j, 1] = xnode5.InnerText;
                                            }
                                            else if (xnode5.Name == "NCM")
                                            {
                                                itensnfe[j, 2] = xnode5.InnerText;
                                            }
                                            else if (xnode5.Name == "CFOP")
                                            {
                                                itensnfe[j, 3] = xnode5.InnerText;
                                            }
                                            else if (xnode5.Name == "uCom")
                                            {
                                                itensnfe[j, 4] = xnode5.InnerText;
                                            }
                                            else if (xnode5.Name == "qCom")
                                            {
                                                itensnfe[j, 5] = xnode5.InnerText;
                                            }
                                            else if (xnode5.Name == "vUnCom")
                                            {
                                                itensnfe[j, 6] = xnode5.InnerText;
                                            }
                                            else if (xnode5.Name == "vProd")
                                            {
                                                itensnfe[j, 7] = xnode5.InnerText;
                                            }
                                            else if (xnode5.Name == "vFrete")
                                            {
                                                itensnfe[j, 8] = xnode5.InnerText;
                                            }
                                            else if (xnode5.Name == "vSeq")
                                            {
                                                itensnfe[j, 9] = xnode5.InnerText;
                                            }
                                            else if (xnode5.Name == "vDesc")
                                            {
                                                itensnfe[j, 10] = xnode5.InnerText;
                                            }
                                            else if (xnode5.Name == "vOutro")
                                            {
                                                itensnfe[j, 11] = xnode5.InnerText;
                                            }
                                        }
                                    }
                                    else if (xnode4.Name == "imposto")
                                    {
                                        foreach (XmlNode xnode5 in xnode4.ChildNodes)
                                        {
                                            if (xnode5.Name == "vTotTrib")
                                            {
                                                tribTot[j, 0] = xnode5.InnerText;
                                            }
                                            else if (xnode5.Name == "ICMS")
                                            {
                                                foreach (XmlNode xnode6 in xnode5.ChildNodes)
                                                {
                                                    foreach (XmlNode xnode7 in xnode6.ChildNodes)
                                                    {
                                                        if (xnode7.Name == "CST")
                                                            tribIcms[j, 0] = xnode7.InnerText;
                                                        else if (xnode7.Name == "vBC")
                                                            tribIcms[j, 1] = xnode7.InnerText;
                                                        else if (xnode7.Name == "pICMS")
                                                            tribIcms[j, 2] = xnode7.InnerText;
                                                        else if (xnode7.Name == "vICMS")
                                                            tribIcms[j, 3] = xnode7.InnerText;
                                                        else if (xnode7.Name == "vBCST")
                                                            tribIcms[j, 4] = xnode7.InnerText;
                                                        else if (xnode7.Name == "vICMSST")
                                                            tribIcms[j, 5] = xnode7.InnerText; ;
                                                    }
                                                }
                                            }
                                            else if (xnode5.Name == "IPI")
                                            {
                                                foreach (XmlNode xnode6 in xnode5.ChildNodes)
                                                {
                                                    if (xnode6.Name == "IPITrib")
                                                    {
                                                        foreach (XmlNode xnode7 in xnode6.ChildNodes)
                                                        {
                                                            if (xnode7.Name == "CST")
                                                                tribIpi[j, 0] = xnode7.InnerText;
                                                            else if (xnode7.Name == "vBC")
                                                                tribIpi[j, 1] = xnode7.InnerText;
                                                            else if (xnode7.Name == "pIPI")
                                                                tribIpi[j, 2] = xnode7.InnerText;
                                                            else if (xnode7.Name == "vIPI")
                                                                tribIpi[j, 3] = xnode7.InnerText;
                                                        }
                                                    }
                                                }
                                            }
                                            else if (xnode5.Name == "PIS")
                                            {
                                                foreach (XmlNode xnode6 in xnode5.ChildNodes)
                                                {
                                                    if (xnode6.Name == "PISAliq")
                                                    {
                                                        foreach (XmlNode xnode7 in xnode6.ChildNodes)
                                                        {
                                                            if (xnode7.Name == "CST")
                                                                tribPis[j, 0] = xnode7.InnerText;
                                                            else if (xnode7.Name == "vBC")
                                                                tribPis[j, 1] = xnode7.InnerText;
                                                            else if (xnode7.Name == "pPIS")
                                                                tribPis[j, 2] = xnode7.InnerText;
                                                            else if (xnode7.Name == "vPIS")
                                                                tribPis[j, 3] = xnode7.InnerText;
                                                        }
                                                    }
                                                    else if (xnode6.Name == "PISOutr")
                                                    {
                                                        foreach (XmlNode xnode7 in xnode6.ChildNodes)
                                                        {
                                                            if (xnode7.Name == "CST")
                                                                tribPis[j, 0] = xnode7.InnerText;
                                                            else if (xnode7.Name == "vBC")
                                                                tribPis[j, 1] = xnode7.InnerText;
                                                            else if (xnode7.Name == "pPIS")
                                                                tribPis[j, 2] = xnode7.InnerText;
                                                            else if (xnode7.Name == "vPIS")
                                                                tribPis[j, 3] = xnode7.InnerText;
                                                        }
                                                    }
                                                }
                                            }
                                            else if (xnode5.Name == "COFINS")
                                            {
                                                foreach (XmlNode xnode6 in xnode5.ChildNodes)
                                                {
                                                    if (xnode6.Name == "COFINSAliq")
                                                    {
                                                        foreach (XmlNode xnode7 in xnode6.ChildNodes)
                                                        {
                                                            if (xnode7.Name == "CST")
                                                                tribConfis[j, 0] = xnode7.InnerText;
                                                            else if (xnode7.Name == "vBC")
                                                                tribConfis[j, 1] = xnode7.InnerText;
                                                            else if (xnode7.Name == "pCOFINS")
                                                                tribConfis[j, 2] = xnode7.InnerText;
                                                            else if (xnode7.Name == "vCOFINS")
                                                                tribConfis[j, 3] = xnode7.InnerText;
                                                        }
                                                    }
                                                    else if (xnode6.Name == "COFINSOutr")
                                                    {
                                                        foreach (XmlNode xnode7 in xnode6.ChildNodes)
                                                        {
                                                            if (xnode7.Name == "CST")
                                                                tribConfis[j, 0] = xnode7.InnerText;
                                                            else if (xnode7.Name == "vBC")
                                                                tribConfis[j, 1] = xnode7.InnerText;
                                                            else if (xnode7.Name == "pCOFINS")
                                                                tribConfis[j, 2] = xnode7.InnerText;
                                                            else if (xnode7.Name == "vCOFINS")
                                                                tribConfis[j, 3] = xnode7.InnerText;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                                break;
                            case "cobr":

                                foreach (XmlNode xnode4 in xnode3.ChildNodes)
                                {
                                    d++;
                                    foreach (XmlNode xnode5 in xnode4.ChildNodes)
                                        if (xnode5.Name == "nDup")
                                        {
                                            duplatasnfe[d, 0] = xnode5.InnerText;
                                        }
                                        else if (xnode5.Name == "dVenc")
                                        {
                                            duplatasnfe[d, 1] = xnode5.InnerText;
                                        }
                                        else if (xnode5.Name == "vDup")
                                        {
                                            duplatasnfe[d, 2] = xnode5.InnerText;
                                        }
                                }
                                break;
                            case "total":
                                foreach (XmlNode xnode4 in xnode3.ChildNodes)
                                {
                                    foreach (XmlNode xnode5 in xnode4.ChildNodes)
                                    {
                                        if (xnode5.Name == "vBC")
                                        {
                                            _TotalNf.VlBaseIcms = Convert.ToDecimal(xnode5.InnerText.Replace(".", ","));
                                        }
                                        else if (xnode5.Name == "vICMS")
                                        {
                                            _TotalNf.VlIcms = Convert.ToDecimal(xnode5.InnerText.Replace(".", ","));
                                        }
                                        else if (xnode5.Name == "vBCST")
                                        {
                                            _TotalNf.VlBaseIcmsSub = Convert.ToDecimal(xnode5.InnerText.Replace(".", ","));
                                        }
                                        else if (xnode5.Name == "vST")
                                        {
                                            _TotalNf.VlIcmsSub = Convert.ToDecimal(xnode5.InnerText.Replace(".", ","));
                                        }
                                        else if (xnode5.Name == "vProd")
                                        {
                                            _TotalNf.VlProdutos = Convert.ToDecimal(xnode5.InnerText.Replace(".", ","));
                                        }
                                        else if (xnode5.Name == "vFrete")
                                        {
                                            _TotalNf.VlFrete = Convert.ToDecimal(xnode5.InnerText.Replace(".", ","));
                                        }
                                        else if (xnode5.Name == "vIPI")
                                        {
                                            _TotalNf.VlIpi = Convert.ToDecimal(xnode5.InnerText.Replace(".", ","));
                                        }
                                        else if (xnode5.Name == "vCOFINS")
                                        {
                                            _TotalNf.VlCofins = Convert.ToDecimal(xnode5.InnerText.Replace(".", ","));
                                        }
                                        else if (xnode5.Name == "vPIS")
                                        {
                                            _TotalNf.VlPis = Convert.ToDecimal(xnode5.InnerText.Replace(".", ","));
                                        }
                                        else if (xnode5.Name == "vTotTrib")
                                        {
                                            _TotalNf.VlTrib = Convert.ToDecimal(xnode5.InnerText.Replace(".", ","));
                                        }
                                        else if (xnode5.Name == "vDesc")
                                        {
                                            _TotalNf.VlDesconto = Convert.ToDecimal(xnode5.InnerText.Replace(".", ","));
                                        }
                                        else if (xnode5.Name == "vOutro")
                                        {
                                            _TotalNf.VlOutrasDesp = Convert.ToDecimal(xnode5.InnerText.Replace(".", ","));
                                        }
                                        else if (xnode5.Name == "vNF")
                                        {
                                            _TotalNf.VlNf = Convert.ToDecimal(xnode5.InnerText.Replace(".", ","));
                                        }
                                    }
                                }
                                break;
                            case "transp":
                                foreach (XmlNode xnode4 in xnode3.ChildNodes)
                                {
                                    if (xnode4.Name == "modFrete")
                                    {
                                        //_NotaFiscal.f = xnode4.InnerXml;
                                    }
                                }
                                break;
                            case "infAdic":
                                foreach (XmlNode xnode4 in xnode3.ChildNodes)
                                {
                                    if (xnode4.Name == "infAdFisco")
                                    {
                                        _NotaFiscal.txobsfisco = xnode4.InnerText;
                                    }
                                    else if (xnode4.Name == "infCpl")
                                    {
                                        _NotaFiscal.txobscontribuinte = xnode4.InnerText;
                                    }
                                }
                                break;
                            case "chNFe":
                                _NotaFiscal.txchacessonfe = xnode3.InnerXml;
                                break;
                                //case "xMotivo":
                                //    lblMotivoSefaz.Text = xnode3.InnerXml;
                                //    break;
                        }
                    }
                }
            }

            for (int i = 1; i < 200; i++)
            {
                if (itensnfe[i, 0] != null)
                {
                    _ItensNotaFiscal = new Entidade_ItemNFe();
                    Entidade_Unidade Und = new Entidade_Unidade();

                    _ItensNotaFiscal.IdProdutoEmit = itensnfe[i, 0].ToString();
                    _ItensNotaFiscal.NmProduto = itensnfe[i, 1].ToString();
                    _ItensNotaFiscal.NCM = itensnfe[i, 2].ToString();
                    _ItensNotaFiscal.cfop = int.Parse(itensnfe[i, 3].ToString());
                    Und.Unidade = itensnfe[i, 4].ToString();
                    _ItensNotaFiscal.Unidade = Und;
                    _ItensNotaFiscal.qt_venda = Convert.ToDecimal(itensnfe[i, 5].Replace(".", ","));
                    _ItensNotaFiscal.VlPreco = Convert.ToDouble(itensnfe[i, 6].Replace(".", ","));
                    _ItensNotaFiscal.Total = Convert.ToDecimal(itensnfe[i, 7].Replace(".", ","));

                    if (tribIcms[i, 1] != null)
                    {
                        _ItensNotaFiscal.vlAliqIcms = Convert.ToDecimal(tribIcms[i, 2].Replace(".", ","));
                        _ItensNotaFiscal.vlbaseicms = Convert.ToDecimal(tribIcms[i, 1].Replace(".", ","));
                        _ItensNotaFiscal.vlicms = Convert.ToDecimal(tribIcms[i, 3].ToString().Replace(".", ","));
                    }
                    else
                    {
                        _ItensNotaFiscal.vlAliqIcms = 0;
                        _ItensNotaFiscal.vlbaseicms = 0;
                        _ItensNotaFiscal.vlicms = 0;
                    }
                    if (tribTot[i, 0] != null)
                    {
                        _ItensNotaFiscal.vlTotTrib = Convert.ToDecimal(tribTot[i, 0].ToString().Replace(".", ","));
                    }
                    if (tribIcms[i, 0] != null)
                        _ItensNotaFiscal.icms = tribIcms[i, 0].ToString();
                    else
                        _ItensNotaFiscal.icms = "00";
                    if (tribIcms[i, 4] != null)
                    {
                        _ItensNotaFiscal.vlbaseicmssub = Convert.ToDecimal(tribIcms[i, 4].ToString().Replace(".", ","));
                        _ItensNotaFiscal.vlicmssub = Convert.ToDecimal(tribIcms[i, 5].ToString().Replace(".", ","));
                    }
                    else
                    {
                        _ItensNotaFiscal.vlbaseicmssub = 0;
                        _ItensNotaFiscal.vlicmssub = 0;
                    }
                    if (itensnfe[i, 10] != null)
                        _ItensNotaFiscal.vlDesconto = Convert.ToDecimal(itensnfe[i, 10].Replace(".", ","));
                    else
                        _ItensNotaFiscal.vlDesconto = 0;

                    _ItensNotaFiscal.vlSeguro = 0;
                    if (itensnfe[i, 11] != null)
                        _ItensNotaFiscal.vloutras = Convert.ToDecimal(itensnfe[i, 11].Replace(".", ","));
                    else
                        _ItensNotaFiscal.vloutras = 0;

                    if (tribIpi[i, 0] != null)
                    {
                        _ItensNotaFiscal.ipi = tribIpi[i, 0].ToString();
                        if (string.IsNullOrEmpty(tribIpi[i, 2]) == false)
                            _ItensNotaFiscal.vlAliqIpi = Convert.ToDecimal(tribIpi[i, 2].ToString().Replace(".", ","));
                        else
                            _ItensNotaFiscal.vlAliqIpi = 0;
                        if (string.IsNullOrEmpty(tribIpi[i, 3]) == false)
                            _ItensNotaFiscal.vlIpi = Convert.ToDecimal(tribIpi[i, 3].ToString().Replace(".", ","));
                        else
                            _ItensNotaFiscal.vlIpi = 0;
                    }
                    else
                    {
                        _ItensNotaFiscal.ipi = "--";
                        _ItensNotaFiscal.vlAliqIpi = 0;
                        _ItensNotaFiscal.vlIpi = 0;
                    }
                    if (itensnfe[i, 8] != null)
                        _ItensNotaFiscal.vlFrete = Convert.ToDecimal(itensnfe[i, 8].ToString().Replace(".", ","));
                    else
                        _ItensNotaFiscal.vlFrete = 0;

                    if (tribPis[i, 0] != null)
                    {
                        _ItensNotaFiscal.pis = tribPis[i, 0];
                        _ItensNotaFiscal.vlAliqPis = Convert.ToDecimal(tribPis[i, 2].ToString().Replace(".", ","));
                        _ItensNotaFiscal.vlPis = Convert.ToDecimal(tribPis[i, 3].ToString().Replace(".", ","));
                    }
                    else
                    {
                        _ItensNotaFiscal.pis = "08";
                        _ItensNotaFiscal.vlAliqPis = 0;
                        _ItensNotaFiscal.vlPis = 0;
                    }
                    if (tribConfis[i, 0] != null)
                    {
                        _ItensNotaFiscal.cofins = tribConfis[i, 0];
                        _ItensNotaFiscal.vlAliqCofins = Convert.ToDecimal(tribConfis[i, 2].ToString().Replace(".", ","));
                        _ItensNotaFiscal.vlCofins = Convert.ToDecimal(tribConfis[i, 3].ToString().Replace(".", ","));
                    }
                    else
                    {
                        _ItensNotaFiscal.cofins = "08";
                        _ItensNotaFiscal.vlAliqCofins = 0;
                        _ItensNotaFiscal.vlCofins = 0;
                    }

                    //_ItensNotaFiscal.CdItem = 0;
                    //_ItensNotaFiscal.CdSubItem = string.Empty;
                    //if (FunGerais.ItemNumerico(itensnfe[i, 0].ToString()))
                    //{
                    //    _ItensNotaFiscal.CdItem = int.Parse(itensnfe[i, 0].ToString());
                    //}
                    //else
                    //{
                    //    _ItensNotaFiscal.CdItem = FunGerais.CdItem(itensnfe[i, 0].ToString());
                    //    _ItensNotaFiscal.CdSubItem = FunGerais.CdSubItem(itensnfe[i, 0].ToString());
                    //}

                    _ListItensNotaFiscal.Add(_ItensNotaFiscal);
                }

                if (i < 30)
                {
                    if (duplatasnfe[i, 0] != null)
                    {
                        _Fatura = new Entidade_Fatura();
                        _Fatura.DataFatura = Convert.ToDateTime(duplatasnfe[i, 1]);
                        _Fatura.Valor = Convert.ToDouble(duplatasnfe[i, 2].Replace(".", ","));
                        _ListFatura.Add(_Fatura);
                    }
                }
            }
            _OutNotaFiscal = _NotaFiscal;
            _OutTotaisNota = _TotalNf;
            _LisOutItens = _ListItensNotaFiscal;
            _ListOutFatura = _ListFatura;
        }
    }

    #endregion
}

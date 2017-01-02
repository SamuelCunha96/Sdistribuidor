using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sdistribuidor.Entidade;
using System.Xml;
using System.Data;
using Sdistribuidor.Model;

namespace Sdistribuidor.Control
{
    public class C_NotaFiscal: ICalculos
    {
        public C_NotaFiscal()
        {

        }
        NotaFiscal _mNotafiscal;

        XmlDocument xmlDOC = new XmlDocument();
        XmlNode node;

        FuncoesGerais FunGerais;
        Entidade_NotaFiscal _NotaFiscal;
        Entidade_TotaisNota _TotalNf;
        //Entidade_Fornecedor _Fornecedor;
        //Entidade_Fatura _Fatura;
        //List<Entidade_Fatura> _ListFatura;
        Entidade_ItemNFe _ItensNotaFiscal;
        List<Entidade_ItemNFe> _ListItensNotaFiscal;

        String[,] itensnfe = new String[200, 12];
        String[,] tribIcms = new String[200, 8];
        String[,] tribIpi = new String[200, 4];
        String[,] tribPis = new String[200, 4];
        String[,] tribConfis = new String[200, 4];
        String[,] duplatasnfe = new String[100, 3];

        public string cSolicPagto;
        public string cCompPagto;

        #region ---- METODOS DA INTERFACE ----

        public decimal SomarGeral(Entidade_TotaisNota _Totais)
        {
            return (_Totais.QtItem * _Totais.VlUnitario) + _Totais.VlFrete + _Totais.VlOutrasDesp + _Totais.VlSeguro + _Totais.VlIcmsSub + _Totais.VlIpi  - _Totais.VlDesconto;
        }
        public decimal SomarGeralItem(Entidade_TotaisNota _Totais)
        {
            return _Totais.VlTotalBruto + _Totais.VlFrete + _Totais.VlOutrasDesp + _Totais.VlSeguro + _Totais.VlIcmsSub + _Totais.VlIpi - _Totais.VlDesconto;
        }
        public decimal BaseIcms(Entidade_TotaisNota _Totais)
        {
            return _Totais.VlBaseIcms == 0 ? (_Totais.QtItem * _Totais.VlUnitario) + _Totais.VlFrete + _Totais.VlSeguro + _Totais.VlOutrasDesp - _Totais.VlDesconto : _Totais.VlBaseIcms + _Totais.VlFrete + _Totais.VlSeguro + _Totais.VlOutrasDesp - _Totais.VlDesconto;
        }
        public decimal BaseIcmsReduzida(Entidade_TotaisNota _Totais)
        {
            return 0;
            //_mNotafiscal = new NotaFiscal();
            //return _Totais.VlBaseIcms == 0 ? ((_Totais.QtItem * _Totais.VlUnitario) + _Totais.VlFrete + _Totais.VlSeguro + _Totais.VlOutrasDesp) * _mNotafiscal.ConsultarValorPercentualdeReducao() : _Totais.VlBaseIcms + _Totais.VlFrete + _Totais.VlSeguro + _Totais.VlOutrasDesp;
        }
        public decimal Icms(Entidade_TotaisNota _Totais)
        {
            return _Totais.VlBaseIcms == 0 ? (_Totais.QtItem * _Totais.VlUnitario) * _Totais.VlAliqIcms / 100 : _Totais.VlBaseIcms * _Totais.VlAliqIcms / 100;
        }
        public decimal ValorIpi(Entidade_TotaisNota _Totais)
        {
            return _Totais.VlIpi == 0 ? (_Totais.QtItem * _Totais.VlUnitario) * _Totais.VlAliqIpi / 100 : _Totais.VlIpi * _Totais.VlAliqIpi / 100; 
        }
        public decimal TotalProdutos(Entidade_TotaisNota _Totais)
        {
            return (_Totais.QtItem * _Totais.VlUnitario);
        }
        public decimal BaseSubTriIcms(Entidade_TotaisNota _Totais)
        {
            throw new NotImplementedException();
        }
        public decimal IcmsSubTrib(Entidade_TotaisNota _Totais)
        {
            throw new NotImplementedException();
        }
        public decimal ValorPis(Entidade_TotaisNota _Totais)
        {
            // 1.65
            return ((_Totais.QtItem * _Totais.VlUnitario) + _Totais.VlFrete + _Totais.VlOutrasDesp + _Totais.VlSeguro + _Totais.VlIcmsSub) * Convert.ToDecimal(0.0165);
        }
        public decimal ValorCofins(Entidade_TotaisNota _Totais)
        {
            //7.6
            return ((_Totais.QtItem * _Totais.VlUnitario) + _Totais.VlFrete + _Totais.VlOutrasDesp + _Totais.VlSeguro + _Totais.VlIcmsSub) * Convert.ToDecimal(0.076);
        }
        public decimal ValorPisTab(Entidade_TotaisNota _Totais, decimal vlAliqPis)
        {
            return ((_Totais.QtItem * _Totais.VlUnitario) + _Totais.VlFrete + _Totais.VlOutrasDesp + _Totais.VlSeguro + _Totais.VlIcmsSub) * vlAliqPis / 100;
        }
        public decimal ValorCofinsTab(Entidade_TotaisNota _Totais, decimal vlAliqCofins)
        {
            return ((_Totais.QtItem * _Totais.VlUnitario) + _Totais.VlFrete + _Totais.VlOutrasDesp + _Totais.VlSeguro + _Totais.VlIcmsSub) * vlAliqCofins / 100;
        }

        #endregion

        #region INCLUIR()
        //public bool Incluir(Entidade_NotaFiscal _cNotaFiscal, List<Entidade_Item> _cListItemNF, List<Entidade_Fatura> _cListFaturas)
        //{
        //    _mNotafiscal = new DAO_NotaFiscal();
        //    return _mNotafiscal.Incluir(_cNotaFiscal, _cListItemNF, _cListFaturas,out cSolicPagto, out cCompPagto);
        //}
        #endregion

        #region LER XML
        //public void LerXml(string Path,out Entidade_TotaisNota _OutTotaisNota,out Entidade_NotaFiscal _OutNotaFiscal, out List<Entidade_Fatura> _ListOutFatura,out List<Entidade_Item> _LisOutItens)
        //{
        //    int j = 0;
        //    int d = 0;
        //    FunGerais = new FuncoesGerais();
        //    _NotaFiscal = new Entidade.Entidade_NotaFiscal();
        //    _TotalNf = new Entidade.Entidade_TotaisNota();
        //    _Fornecedor = new Entidade.Entidade_Fornecedor();

        //    _Fatura = new Entidade.Entidade_Fatura();
        //    _ListFatura = new List<Entidade.Entidade_Fatura>();
        //    _ItensNotaFiscal = new Entidade.Entidade_Item();
        //    _ListItensNotaFiscal = new List<Entidade.Entidade_Item>();

        //    xmlDOC.Load(Path);

        //    node = xmlDOC.DocumentElement;

        //    foreach (XmlNode xnode1 in node.ChildNodes)
        //    {
        //        foreach (XmlNode xnode2 in xnode1.ChildNodes)
        //        {
        //            foreach (XmlNode xnode3 in xnode2.ChildNodes)
        //            {
        //                switch (xnode3.Name)
        //                {
        //                    case "ide":
        //                        foreach (XmlNode xnode4 in xnode3.ChildNodes)
        //                        {
        //                            if (xnode4.Name == "serie")
        //                            {
        //                                _NotaFiscal.NmSerieNf = xnode4.InnerText;
        //                            }
        //                            else if (xnode4.Name == "nNF")
        //                            {
        //                                _NotaFiscal.NrNf = int.Parse(xnode4.InnerText);
        //                            }
        //                            else if (xnode4.Name == "dEmi")
        //                            {
        //                                _NotaFiscal.DtEmissao = Convert.ToDateTime(xnode4.InnerText);
        //                            }
        //                            else if (xnode4.Name == "dhEmi")
        //                            {
        //                                _NotaFiscal.DtEmissao = Convert.ToDateTime(xnode4.InnerText);
        //                            }
        //                        }
        //                        break;
        //                    case "emit":
        //                        foreach (XmlNode xnode4 in xnode3.ChildNodes)
        //                        {
        //                            if (xnode4.Name == "CNPJ")
        //                            {
        //                                _Fornecedor.CdCpfCgc = xnode4.InnerText;
        //                            }
        //                            else if (xnode4.Name == "xNome")
        //                            {
        //                                _Fornecedor.nmFornec = xnode4.InnerText;
        //                            }
        //                            else if (xnode4.Name == "enderEmit")
        //                            {
        //                                foreach (XmlNode xnode5 in xnode4.ChildNodes)
        //                                {
        //                                    if (xnode5.Name == "xLgr")
        //                                    {
        //                                        _Fornecedor.NmEnder = xnode5.InnerText;
        //                                    }
        //                                    else if (xnode5.Name == "nro")
        //                                    {
        //                                        _Fornecedor.NrEnder = xnode5.InnerText.Trim() == string.Empty ? xnode5.InnerText : "0";
        //                                    }
        //                                    else if (xnode5.Name == "xBairro")
        //                                    {
        //                                        _Fornecedor.NmBairro = xnode5.InnerText;
        //                                    }
        //                                    else if (xnode5.Name == "xMun")
        //                                    {
        //                                        _Fornecedor.NmCidade = xnode5.InnerText;
        //                                    }
        //                                    else if (xnode5.Name == "CEP")
        //                                    {
        //                                        int Ret = 0;
        //                                        _Fornecedor.CdCep = int.TryParse(xnode5.InnerText, out Ret) == true ? int.Parse(xnode5.InnerText) : 0;
        //                                    }
        //                                    else if (xnode5.Name == "fone")
        //                                    {
        //                                        long Ret = 0;
        //                                        _Fornecedor.NrFone1 = long.TryParse(xnode5.InnerText, out Ret) == true ? long.Parse(xnode5.InnerText) : 0;
        //                                    }
        //                                }
        //                            }
        //                        }
        //                        _NotaFiscal._Entidade_Fornecedor = _Fornecedor;
        //                        break;
        //                    //case "dest":
        //                    //    j++;
        //                    //    foreach (XmlNode xnode4 in xnode3.ChildNodes)
        //                    //    {
        //                    //        if (xnode4.Name == "CNPJ")
        //                    //        {
        //                    //            txtCNPJdest.Text = xnode4.InnerText;
        //                    //        }
        //                    //        else if (xnode4.Name == "xNome")
        //                    //        {
        //                    //            txtNomeDest.Text = xnode4.InnerText;
        //                    //        }
        //                    //        else if (xnode4.Name == "enderDest")
        //                    //        {
        //                    //            foreach (XmlNode xnode5 in xnode4.ChildNodes)
        //                    //            {
        //                    //                if (xnode5.Name == "xLgr")
        //                    //                {
        //                    //                    txtLgrDes.Text = xnode5.InnerText;
        //                    //                }
        //                    //                else if (xnode5.Name == "nro")
        //                    //                {
        //                    //                    txtNrDest.Text = xnode5.InnerText;
        //                    //                }
        //                    //                else if (xnode5.Name == "xBairro")
        //                    //                {
        //                    //                    txtBarrioDest.Text = xnode5.InnerText;
        //                    //                }
        //                    //                else if (xnode5.Name == "xMun")
        //                    //                {
        //                    //                    txtMunDest.Text = xnode5.InnerText;
        //                    //                }
        //                    //                else if (xnode5.Name == "CEP")
        //                    //                {
        //                    //                    txtCEPDest.Text = xnode5.InnerText;
        //                    //                }
        //                    //                else if (xnode5.Name == "fone")
        //                    //                {
        //                    //                    txtFoneDest.Text = xnode5.InnerText;
        //                    //                }
        //                    //            }
        //                    //        }

        //                    //    }
        //                    //    break;
        //                    //case "entrega":
        //                    //    foreach (XmlNode xnode4 in xnode3.ChildNodes)
        //                    //    {
        //                    //        if (xnode4.Name == "xLgr")
        //                    //        {
        //                    //            txtLgrEntrega.Text = xnode4.InnerText;
        //                    //        }
        //                    //        else if (xnode4.Name == "nro")
        //                    //        {
        //                    //            txtNrEntrega.Text = xnode4.InnerText;
        //                    //        }
        //                    //        else if (xnode4.Name == "xBairro")
        //                    //        {
        //                    //            txtBairroEntrega.Text = xnode4.InnerText;
        //                    //        }
        //                    //        else if (xnode4.Name == "xMun")
        //                    //        {
        //                    //            txtMunEntrega.Text = xnode4.InnerText;
        //                    //        }
        //                    //    }
        //                    //    break;
        //                    case "det":
        //                        j++;
        //                        foreach (XmlNode xnode4 in xnode3.ChildNodes)
        //                        {
        //                            if (xnode4.Name == "prod")
        //                            {
        //                                foreach (XmlNode xnode5 in xnode4.ChildNodes)
        //                                {
        //                                    if (xnode5.Name == "cProd")
        //                                    {
        //                                        itensnfe[j, 0] = xnode5.InnerText;
        //                                    }
        //                                    else if (xnode5.Name == "xProd")
        //                                    {
        //                                        itensnfe[j, 1] = xnode5.InnerText;
        //                                    }
        //                                    else if (xnode5.Name == "NCM")
        //                                    {
        //                                        itensnfe[j, 2] = xnode5.InnerText;
        //                                    }
        //                                    else if (xnode5.Name == "CFOP")
        //                                    {
        //                                        itensnfe[j, 3] = xnode5.InnerText;
        //                                    }
        //                                    else if (xnode5.Name == "uCom")
        //                                    {
        //                                        itensnfe[j, 4] = xnode5.InnerText;
        //                                    }
        //                                    else if (xnode5.Name == "qCom")
        //                                    {
        //                                        itensnfe[j, 5] = xnode5.InnerText;
        //                                    }
        //                                    else if (xnode5.Name == "vUnCom")
        //                                    {
        //                                        itensnfe[j, 6] = xnode5.InnerText;
        //                                    }
        //                                    else if (xnode5.Name == "vProd")
        //                                    {
        //                                        itensnfe[j, 7] = xnode5.InnerText;
        //                                    }
        //                                    else if (xnode5.Name == "vFrete")
        //                                    {
        //                                        itensnfe[j, 8] = xnode5.InnerText;
        //                                    }
        //                                    else if (xnode5.Name == "vSeq")
        //                                    {
        //                                        itensnfe[j, 9] = xnode5.InnerText;
        //                                    }
        //                                    else if (xnode5.Name == "vDesc")
        //                                    {
        //                                        itensnfe[j, 10] = xnode5.InnerText;
        //                                    }
        //                                    else if (xnode5.Name == "vOutro")
        //                                    {
        //                                        itensnfe[j, 11] = xnode5.InnerText;
        //                                    }
        //                                }
        //                            }
        //                            else if (xnode4.Name == "imposto")
        //                            {
        //                                foreach (XmlNode xnode5 in xnode4.ChildNodes)
        //                                {
        //                                    if (xnode5.Name == "ICMS")
        //                                    {
        //                                        foreach (XmlNode xnode6 in xnode5.ChildNodes)
        //                                        {
        //                                            foreach (XmlNode xnode7 in xnode6.ChildNodes)
        //                                            {
        //                                                if (xnode7.Name == "CST")
        //                                                    tribIcms[j, 0] = xnode7.InnerText;
        //                                                else if (xnode7.Name == "vBC")
        //                                                    tribIcms[j, 1] = xnode7.InnerText;
        //                                                else if (xnode7.Name == "pICMS")
        //                                                    tribIcms[j, 2] = xnode7.InnerText;
        //                                                else if (xnode7.Name == "vICMS")
        //                                                    tribIcms[j, 3] = xnode7.InnerText;
        //                                                else if (xnode7.Name == "vBCST")
        //                                                    tribIcms[j, 4] = xnode7.InnerText;
        //                                                else if (xnode7.Name == "vICMSST")
        //                                                    tribIcms[j, 5] = xnode7.InnerText; ;
        //                                            }
        //                                        }
        //                                    }
        //                                    else if (xnode5.Name == "IPI")
        //                                    {
        //                                        foreach (XmlNode xnode6 in xnode5.ChildNodes)
        //                                        {
        //                                            if (xnode6.Name == "IPITrib")
        //                                            {
        //                                                foreach (XmlNode xnode7 in xnode6.ChildNodes)
        //                                                {
        //                                                    if (xnode7.Name == "CST")
        //                                                        tribIpi[j, 0] = xnode7.InnerText;
        //                                                    else if (xnode7.Name == "vBC")
        //                                                        tribIpi[j, 1] = xnode7.InnerText;
        //                                                    else if (xnode7.Name == "pIPI")
        //                                                        tribIpi[j, 2] = xnode7.InnerText;
        //                                                    else if (xnode7.Name == "vIPI")
        //                                                        tribIpi[j, 3] = xnode7.InnerText;
        //                                                }
        //                                            }
        //                                        }
        //                                    }
        //                                    else if (xnode5.Name == "PIS")
        //                                    {
        //                                        foreach (XmlNode xnode6 in xnode5.ChildNodes)
        //                                        {
        //                                            if (xnode6.Name == "PISAliq")
        //                                            {
        //                                                foreach (XmlNode xnode7 in xnode6.ChildNodes)
        //                                                {
        //                                                    if (xnode7.Name == "CST")
        //                                                        tribPis[j, 0] = xnode7.InnerText;
        //                                                    else if (xnode7.Name == "vBC")
        //                                                        tribPis[j, 1] = xnode7.InnerText;
        //                                                    else if (xnode7.Name == "pPIS")
        //                                                        tribPis[j, 2] = xnode7.InnerText;
        //                                                    else if (xnode7.Name == "vPIS")
        //                                                        tribPis[j, 3] = xnode7.InnerText;
        //                                                }
        //                                            }
        //                                        }
        //                                    }
        //                                    else if (xnode5.Name == "COFINS")
        //                                    {
        //                                        foreach (XmlNode xnode6 in xnode5.ChildNodes)
        //                                        {
        //                                            if (xnode6.Name == "COFINSAliq")
        //                                            {
        //                                                foreach (XmlNode xnode7 in xnode6.ChildNodes)
        //                                                {
        //                                                    if (xnode7.Name == "CST")
        //                                                        tribConfis[j, 0] = xnode7.InnerText;
        //                                                    else if (xnode7.Name == "vBC")
        //                                                        tribConfis[j, 1] = xnode7.InnerText;
        //                                                    else if (xnode7.Name == "pCOFINS")
        //                                                        tribConfis[j, 2] = xnode7.InnerText;
        //                                                    else if (xnode7.Name == "vCOFINS")
        //                                                        tribConfis[j, 3] = xnode7.InnerText;
        //                                                }
        //                                            }
        //                                        }
        //                                    }
        //                                }
        //                            }
        //                        }
        //                        break;
        //                    case "cobr":

        //                        foreach (XmlNode xnode4 in xnode3.ChildNodes)
        //                        {
        //                            d++;
        //                            foreach (XmlNode xnode5 in xnode4.ChildNodes)
        //                                if (xnode5.Name == "nDup")
        //                                {
        //                                    duplatasnfe[d, 0] = xnode5.InnerText;
        //                                }
        //                                else if (xnode5.Name == "dVenc")
        //                                {
        //                                    duplatasnfe[d, 1] = xnode5.InnerText;
        //                                }
        //                                else if (xnode5.Name == "vDup")
        //                                {
        //                                    duplatasnfe[d, 2] = xnode5.InnerText;
        //                                }
        //                        }
        //                        break;
        //                    case "total":
        //                        foreach (XmlNode xnode4 in xnode3.ChildNodes)
        //                        {
        //                            foreach (XmlNode xnode5 in xnode4.ChildNodes)
        //                            {
        //                                if (xnode5.Name == "vBC")
        //                                {
        //                                    _TotalNf.VlBaseIcms = Convert.ToDouble(xnode5.InnerText.Replace(".",""));
        //                                }
        //                                else if (xnode5.Name == "vICMS")
        //                                {
        //                                    _TotalNf.VlIcms =Convert.ToDouble(xnode5.InnerText.Replace(".",""));
        //                                }
        //                                else if (xnode5.Name == "vBCST")
        //                                {
        //                                    _TotalNf.VlBaseIcmsSub = Convert.ToDouble(xnode5.InnerText.Replace(".",""));
        //                                }
        //                                else if (xnode5.Name == "vST")
        //                                {
        //                                    _TotalNf.VlIcmsSub = Convert.ToDouble(xnode5.InnerText.Replace(".",""));
        //                                }
        //                                else if (xnode5.Name == "vProd")
        //                                {
        //                                    _TotalNf.VlProdutos = Convert.ToDouble(xnode5.InnerText.Replace(".",""));
        //                                }
        //                                else if (xnode5.Name == "vFrete")
        //                                {
        //                                    _TotalNf.VlFrete = Convert.ToDouble(xnode5.InnerText.Replace(".",""));
        //                                }
        //                                else if (xnode5.Name == "vIPI")
        //                                {
        //                                    _TotalNf.VlIpi = Convert.ToDouble(xnode5.InnerText.Replace(".",""));
        //                                }
        //                                else if (xnode5.Name == "vDesc")
        //                                {
        //                                    _TotalNf.VlDesconto =  Convert.ToDouble(xnode5.InnerText.Replace(".",""));
        //                                }
        //                                else if (xnode5.Name == "vOutro")
        //                                {
        //                                    _TotalNf.VlOutrasDesp = Convert.ToDouble(xnode5.InnerText.Replace(".",""));
        //                                }
        //                                else if (xnode5.Name == "vNF")
        //                                {
        //                                    _TotalNf.VlNf = Convert.ToDouble(xnode5.InnerText.Replace(".",""));
        //                                }
        //                            }
        //                        }
        //                        break;
        //                    case "transp":
        //                        foreach (XmlNode xnode4 in xnode3.ChildNodes)
        //                        {
        //                            if (xnode4.Name == "modFrete")
        //                            {
        //                                _NotaFiscal.CdFrete = xnode4.InnerXml;
        //                            }
        //                        }
        //                        break;
        //                    //case "infAdic":
        //                    //    foreach (XmlNode xnode4 in xnode3.ChildNodes)
        //                    //    {
        //                    //        if (xnode4.Name == "infCpl")
        //                    //        {
        //                    //            lblInfAdicional.Text = xnode4.InnerText;
        //                    //        }
        //                    //    }
        //                    //    break;
        //                    case "chNFe":
        //                        _NotaFiscal.TxChAcessoNfe = xnode3.InnerXml;
        //                        break;
        //                    //case "xMotivo":
        //                    //    lblMotivoSefaz.Text = xnode3.InnerXml;
        //                    //    break;
        //                }
        //            }
        //        }
        //    }

        //    for (int i = 1; i < 200; i++)
        //    {
        //        if (itensnfe[i, 0] != null)
        //        {
        //            _ItensNotaFiscal = new Entidade_Item();

        //            _ItensNotaFiscal.ITEMCompleto = itensnfe[i, 0].ToString();
        //            _ItensNotaFiscal.NmItem = itensnfe[i, 1].ToString();
        //            _ItensNotaFiscal.NrClassFiscal = itensnfe[i, 2].ToString();
        //            _ItensNotaFiscal.CFOP = int.Parse(itensnfe[i, 3].ToString());
        //            _ItensNotaFiscal.UnidadeConvertida = itensnfe[i, 4].ToString();
        //            _ItensNotaFiscal.QtdEntrada = Convert.ToDouble(itensnfe[i, 5].Replace(".", ","));
        //            _ItensNotaFiscal.VlUnitarioEntrada = Convert.ToDouble(itensnfe[i, 6].Replace(".", ","));
        //            _ItensNotaFiscal.VlTotal = Convert.ToDouble(itensnfe[i, 7].Replace(".", ","));

        //            if (tribIcms[i, 1] != null)
        //            {
        //                _ItensNotaFiscal.VlAliqIcms = Convert.ToDouble(tribIcms[i, 2].Replace(".", ","));
        //                _ItensNotaFiscal.VlBaseIcms = Convert.ToDouble(tribIcms[i, 1].Replace(".", ","));
        //                _ItensNotaFiscal.VlIcms = Convert.ToDouble(tribIcms[i, 3].ToString().Replace(".", ","));
        //            }
        //            else
        //            {
        //                _ItensNotaFiscal.VlAliqIcms = 0;
        //                _ItensNotaFiscal.VlBaseIcms = 0;
        //                _ItensNotaFiscal.VlIcms = 0;
        //            }
        //            if (tribIcms[i, 0] != null)
        //                _ItensNotaFiscal.CstIcms = tribIcms[i, 0].ToString();
        //            else
        //                _ItensNotaFiscal.CstIcms = "00";
        //            if (tribIcms[i, 4] != null)
        //            {
        //                _ItensNotaFiscal.VlBaseIcmsSub = Convert.ToDouble(tribIcms[i, 4].ToString().Replace(".", ","));
        //                _ItensNotaFiscal.VlIcmsSub = Convert.ToDouble(tribIcms[i, 5].ToString().Replace(".", ","));
        //            }
        //            else
        //            {
        //                _ItensNotaFiscal.VlBaseIcmsSub = 0;
        //                _ItensNotaFiscal.VlIcmsSub = 0;
        //            }
        //            if (itensnfe[i, 10] != null)
        //                _ItensNotaFiscal.VlDesconto = Convert.ToDouble(itensnfe[i, 10].Replace(".", ","));
        //            else
        //                _ItensNotaFiscal.VlDesconto = 0;

        //            _ItensNotaFiscal.VlSeguro = 0;
        //            if (itensnfe[i, 11] != null)
        //                _ItensNotaFiscal.VlOutrasDesp = Convert.ToDouble(itensnfe[i, 11].Replace(".", ","));
        //            else
        //                _ItensNotaFiscal.VlOutrasDesp = 0;

        //            if (tribIpi[i, 0] != null)
        //            {
        //                if (string.IsNullOrEmpty(tribIpi[i, 2])==false)
        //                    _ItensNotaFiscal.VlAliqIpi = Convert.ToDouble(tribIpi[i, 2].ToString().Replace(".", ","));
        //                else
        //                    _ItensNotaFiscal.VlAliqIpi = 0;
        //                if (string.IsNullOrEmpty(tribIpi[i, 3]) == false)
        //                    _ItensNotaFiscal.VlIpi = Convert.ToDouble(tribIpi[i, 3].ToString().Replace(".", ","));
        //                else
        //                    _ItensNotaFiscal.VlIpi = 0;
        //            }
        //            else
        //            {
        //                _ItensNotaFiscal.VlAliqIpi = 0;
        //                _ItensNotaFiscal.VlIpi = 0;
        //            }
        //            if (itensnfe[i, 8] != null)
        //                _ItensNotaFiscal.VlFrete = Convert.ToDouble(itensnfe[i, 8].ToString().Replace(".", ","));
        //            else
        //                _ItensNotaFiscal.VlFrete = 0;

        //            if (tribPis[i, 0] != null)
        //            {
        //                _ItensNotaFiscal.VlPis = Convert.ToDouble(tribPis[i, 3].ToString().Replace(".", ","));
        //            }
        //            if (tribConfis[i, 0] != null)
        //            {
        //                _ItensNotaFiscal.VlCofins = Convert.ToDouble(tribConfis[i, 3].ToString().Replace(".", ","));
        //            }

        //            _ItensNotaFiscal.CdItem = 0;
        //            _ItensNotaFiscal.CdSubItem = string.Empty;
        //            //if (FunGerais.ItemNumerico(itensnfe[i, 0].ToString()))
        //            //{
        //            //    _ItensNotaFiscal.CdItem = int.Parse(itensnfe[i, 0].ToString());
        //            //}
        //            //else
        //            //{
        //            //    _ItensNotaFiscal.CdItem = FunGerais.CdItem(itensnfe[i, 0].ToString());
        //            //    _ItensNotaFiscal.CdSubItem = FunGerais.CdSubItem(itensnfe[i, 0].ToString());
        //            //}
                    
        //            _ListItensNotaFiscal.Add(_ItensNotaFiscal);
        //        }

        //        if (i < 30)
        //        {
        //            if (duplatasnfe[i, 0] != null)
        //            {
        //                _Fatura = new Entidade_Fatura();
        //                _Fatura.DataFatura = Convert.ToDateTime(duplatasnfe[i, 1]);
        //                _Fatura.Valor = Convert.ToDouble(duplatasnfe[i, 2].Replace(".", ","));
        //                _ListFatura.Add(_Fatura);
        //            }
        //        }
        //    }

        //    _OutNotaFiscal = _NotaFiscal;
        //    _OutTotaisNota = _TotalNf;
        //    _LisOutItens = _ListItensNotaFiscal;
        //    _ListOutFatura = _ListFatura;
        //}
        #endregion

        #region LISTAGEM DE NOTAS FISCAIS
        //public List<Entidade_NotaFiscal> PesquisaDados(Entidade_NotaFiscal cEntidadeNotaFisca)
        //{
        //    try
        //    {
        //        _mNotafiscal = new DAO_NotaFiscal();

        //        return _mNotafiscal.PesquisarNotas(cEntidadeNotaFisca);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message.ToString() + " -- " + ex.InnerException.ToString());
        //    }
        //}
        #endregion

        #region LISTAGEM DE ITENS DA NOTA FISCAL
        //public List<Entidade_Item> PesquisaItem(Entidade_NotaFiscal NotaItens)
        //{
        //    try
        //    {
        //        _mNotafiscal = new DAO_NotaFiscal();

        //        return _mNotafiscal.PesquisaItensNotaFiscal(NotaItens);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message.ToString() + " -- " + ex.InnerException.ToString());
        //    }
        //}
        #endregion

        #region EXISTENCIA DE FATURAS
        //public bool ExisteFaturas(Entidade_NotaFiscal NotaItens)
        //{
        //    try
        //    {
        //        _mNotafiscal = new DAO_NotaFiscal();

        //        return _mNotafiscal.ExisteFaturas(NotaItens);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message.ToString());
        //    }
        //}
        #endregion

        #region Faturas 
        //public List<Entidade_Fatura> Faturas(Entidade_NotaFiscal NotaFaturas)
        //{
        //    try
        //    {
        //        _mNotafiscal = new DAO_NotaFiscal();

        //        return _mNotafiscal.Faturas(NotaFaturas);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message.ToString());
        //    }
        //}
        #endregion

        #region Dados Adicionais
        //public void DadosAdicionaisNotaFisca(Entidade_NotaFiscal NotaFiscal, out string cEvento, out string cCentroCusto, out string cAgentePagto, out string cFormaPagto)
        //{
        //    try
        //    {
        //        _mNotafiscal = new DAO_NotaFiscal();

        //        _mNotafiscal.DadosAdicionaisFatura(NotaFiscal, out cEvento, out cCentroCusto, out cAgentePagto, out cFormaPagto);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message.ToString());
        //    }
        //}
        #endregion

        //public bool ExisteCompromissoFinanceiroNotaFiscal(Entidade_NotaFiscal NotaFicalCancelar)
        //{
        //    _mNotafiscal = new DAO_NotaFiscal();

        //    return _mNotafiscal.ExisteCompromissoFinanceiro(NotaFicalCancelar);
        //}
        //public bool NotaFiscalInterna(Entidade_NotaFiscal pNotaFiscalEnt)
        //{
        //    _mNotafiscal = new DAO_NotaFiscal();
        //    return _mNotafiscal.NotaFiscalInterna(pNotaFiscalEnt);
        //}
        //public bool CancelamentoNotaFiscalFornecedor(Entidade_NotaFiscal cNotaFiscal, List<Entidade_Item> cListItemNF)
        //{
        //    try
        //    {
        //        _mNotafiscal = new DAO_NotaFiscal();

        //        return _mNotafiscal.CancelamentoNotaFiscal(cNotaFiscal, cListItemNF);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message.ToString());
        //    }
        //}

        //public bool NotaFiscalExiste(int ploja, int pnotafiscal, int pfornecedor, string pnmserienf)
        //{
        //    _mNotafiscal = new DAO_NotaFiscal();
        //    return _mNotafiscal.NotaFiscalExiste(ploja, pnotafiscal, pfornecedor, pnmserienf);
        //}

        //public bool ValidarNfReferida(int ploja, int pNotaFiscal, string pSerie)
        //{
        //    _mNotafiscal = new DAO_NotaFiscal();

        //    return _mNotafiscal.ValidarNfReferida(ploja, pNotaFiscal, pSerie);
        //}
        //public DataTable ConsultarNotas(int pLoja, DateTime pDtIni, DateTime pDtFim)
        //{
        //    _mNotafiscal = new DAO_NotaFiscal();
        //    return _mNotafiscal.ConsultarNotas(pLoja, pDtIni, pDtFim);
        //}
        //public int ConsultarNumeroNotaFiscal(int pLoja, string pNmSerieNf)
        //{
        //    _mNotafiscal = new DAO_NotaFiscal();
        //    return _mNotafiscal.ConsultarNumeroNotaFiscal(pLoja, pNmSerieNf);
        //}
        //public string ConsultarSerieNf(int pLoja)
        //{
        //    _mNotafiscal = new DAO_NotaFiscal();
        //    return _mNotafiscal.ConsultarSerieNf(pLoja);
        //}

        //public bool IncluirNotaFiscalDevolucao(Entidade_NotaFiscal cNotaFiscal, List<Entidade_Item> cListItemNF,out string pErro)
        //{
        //    _mNotafiscal = new DAO_NotaFiscal();
        //    return _mNotafiscal.IncluirDevolucaoMercadoria(cNotaFiscal, cListItemNF, out pErro);
        //}
        //public bool CancelamentoNotaFiscalInterna(Entidade_NotaFiscal pNotaFiscal, List<Entidade_Item> _pmListItemNF)
        //{
        //    _mNotafiscal = new DAO_NotaFiscal();
        //    return _mNotafiscal.CancelamentoNotaFiscalInterna(pNotaFiscal, _pmListItemNF);
        //}
        //public int CodigoRetornoNfe(Entidade_NotaFiscal pNotaFiscal)
        //{
        //    _mNotafiscal = new DAO_NotaFiscal();
        //    return _mNotafiscal.CodigoRetornoNfe(pNotaFiscal);
        //}
    }
}

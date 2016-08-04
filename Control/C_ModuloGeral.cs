using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Net;
using System.IO;

namespace Sdistribuidor.Control
{
    class C_ModuloGeral
    {
        string dados;
        bool ValidaEstoque;
        int result;

        DataTable dt;

        //DAO_FuncoesGerais ObjFuncGerais;

        public C_ModuloGeral()
        {
            
        }

        //DAO_Cliente M_Cliente = new DAO_Cliente();
        public string FormataItemAlmox(string item)
        {
            if (item.Length == 7)
                return string.Format("{0:00}.{1:00}.{2:0000}", int.Parse(item.Substring(0, 1)), int.Parse(item.Substring(1, 2)), int.Parse(item.Substring(3, 4)));
            else
                return string.Format("{0:00}.{1:00}.{2:0000}", int.Parse(item.Substring(0, 2)), int.Parse(item.Substring(1, 2)), int.Parse(item.Substring(4, 4)));
        }
        public string FormatCPNJCPF(string CPNFCPF)
        {
            dados = string.Empty;
            if (CPNFCPF != string.Empty)
            {
                if (CPNFCPF.Length == 11)
                    return dados = String.Format(@"{0:000\.000\.000\-00}", Convert.ToDouble(CPNFCPF));
                else
                    return dados = String.Format(@"{0:00\.000\.000\/0000\-00}", Convert.ToDouble(CPNFCPF));
            }

            return dados;
        }
        public string FormatFONE(string Fone)
        {
            dados = string.Empty;
            if (Fone != string.Empty)
            {
                return dados = String.Format(@"{0:(00)0000\.0000}", long.Parse(Fone));
            }
            else
            {
                return dados;
            }
        }

        public string FormatCEP(string CEP)
        {
            dados = string.Empty;
            if (CEP != string.Empty)
            {
                return dados = String.Format(@"{0:00000\-000}", Convert.ToInt32(CEP));
            }
            else
            {
                return dados;
            }
        }
        public string FormatValores(string valor)
        {
            dados = string.Empty;
            if (valor != string.Empty)
            {
                return dados = String.Format(@"{0:C}", Convert.ToDecimal(valor));
            }
            else
            {
                return dados;
            }
        }
        public string FormatValoresBanco(string valor)
        {
            dados = string.Empty;
            if (valor != string.Empty)
            {
                return dados = valor.Replace("R$", "").Replace(".", "");
            }
            else
            {
                return dados;
            }
        }
        public string FormatDataBanco(DateTime data)
        {
            return dados = "'" + data.ToString("MM/dd/yyyy") + "'";
        }
        public string TiraCampos(string valor)
        {
            dados = string.Empty;
            if (valor != string.Empty)
            {
                dados = valor.Replace("-", "");
                dados = dados.Replace(",", "");
                dados = dados.Replace(".", "");
                dados = dados.Replace("/", "");
                dados = dados.Replace("á", "a");
                dados = dados.Replace("ã", "a");
                dados = dados.Replace("(", "");
                dados = dados.Replace(")", "");
                dados = dados.Replace("é", "e");
                dados = dados.Replace("ú", "u");
            }

            return dados;
        }
        public bool ItemNumerico(string item)
        {
            bool validarNumerico = false;
            int returnoResultado;

            return validarNumerico = int.TryParse(item.Trim(), out returnoResultado);
        }
        public int CdItem(string item)
        {
            bool validarNumerico = false;
            int returnoResultado;

            validarNumerico = int.TryParse(item.Trim(), out returnoResultado);

            try
            {
                if (validarNumerico)
                    return int.Parse(item);
                else
                    return int.Parse(item.Trim().Substring(0, item.Trim().Length - 1));
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public string CdSubItem(string item)
        {
            return item.Substring(item.Trim().Length - 1, 1);
        }
        public bool ValidaCampoNumerico(string Valor)
        {
            ValidaEstoque = int.TryParse(Valor.Trim(), out result);
            if (ValidaEstoque)
                return true;
            else
                return false;
        }
        public DataTable ConsultaCep( string _Cep)
        {
            DataTable dtResult = new DataTable();

            dtResult = ConsultarCepCorreios(_Cep);

            if (dtResult == null || dtResult.Rows.Count == 0)
            {
                dtResult = ConsultarCepRepublicaVirtual(_Cep);
                if (dtResult == null)
                    return null;
                else
                    return dtResult;
            }
            else
                return dtResult;
        }
        private DataTable ConsultarCepRepublicaVirtual(string Cep)
        {
            try
            {
                DataSet ds = new DataSet();
                ds.ReadXml("http://cep.republicavirtual.com.br/web_cep.php?cep=" + Cep + "&formato=xml");

                dt = new DataTable();

                if (ds.Tables[0].Rows.Count > 0)
                {
                    dt.Columns.Add("Logradouro", typeof(string));
                    dt.Columns.Add("Bairro", typeof(string));
                    dt.Columns.Add("Localidade", typeof(string));
                    dt.Columns.Add("UF", typeof(string));

                    dt.Rows.Add(ds.Tables[0].Rows[0]["logradouro"].ToString(), ds.Tables[0].Rows[0]["bairro"].ToString(), ds.Tables[0].Rows[0]["cidade"].ToString(), ds.Tables[0].Rows[0]["uf"].ToString());
                }
                return dt;
            }
            catch
            {
                return null;
            }
        }

        private DataTable ConsultarCepCorreios(string cep)
        {
            try
            {
                // Efetua a requisio ao site passando o CEP como querystring
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("http://www.buscacep.correios.com.br/servicos/dnec/consultaLogradouroAction.do?Metodo=listaLogradouro&CEP=" + cep + "&TipoConsulta=cep");
                int count;
                byte[] buf = new byte[1000];
                StringBuilder sb = new StringBuilder();
                string temp;
                // Recebe a resposta da requisio
                HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                // Transforma a requisio em um Stream
                Stream stream = httpWebResponse.GetResponseStream();
                // Carrega e despeja um buffer (array de bytes), apendando em um StringBuider enquanto o buffer não estiver vazio
                do
                {
                    count = stream.Read(buf, 0, buf.Length);
                    temp = Encoding.Default.GetString(buf, 0, count).Trim();
                    sb.Append(temp);

                } while (count > 0);
                // Converte o String Buider para String
                string html = sb.ToString();
                // Seleciona o String HTML de acordo com os delimitadores
                html = this.retornarHtml(html, "<?xml version = '1.0' encoding = 'ISO-8859-1'?>", "<table width=\"645\">");
                // Exibe o HTML em um controle Literal
                //LiteralResultado.Text = html;

                return ReadHtmlTable(html);
            }
            catch (Exception)
            {
                return null;
            }
        }
        private string retornarHtml(string html, string delimitadorInicial, string delimitadorFinal)
        {
            int posInicial;
            int posFinal;
            // Verifica se o delimitador inicial foi encontrado
            if (html.IndexOf(delimitadorInicial) != -1)
            {
                // Verifica a posio do delimitador inicial dentro do String HTML (soma a quantidade de caracteres do delimitador)
                posInicial = html.IndexOf(delimitadorInicial) + (delimitadorInicial.Length + 1);

                // Verifica a posio do ltimo caracter do delimitador final
                posFinal = html.IndexOf(delimitadorFinal, posInicial) - posInicial;
                // Retorna a String HTML de acordo com a posio inicial e a posio final
                html = html.Trim().Substring(posInicial, posFinal);
            }
            return html;
        }

        public DataTable ReadHtmlTable(string tableHtml)
        {
            // inicializa a tabela...
            dt = new DataTable();
            dt.Columns.Add("Logradouro", typeof(string));
            dt.Columns.Add("Bairro", typeof(string));
            dt.Columns.Add("Localidade", typeof(string));
            dt.Columns.Add("UF", typeof(string));

            // procura as linhas da tabela...
            System.Text.RegularExpressions.MatchCollection matches =
             System.Text.RegularExpressions.Regex.Matches(tableHtml, @"<TR.*?>(.*?)</TR>", System.Text.RegularExpressions.RegexOptions.IgnoreCase | System.Text.RegularExpressions.RegexOptions.Singleline);

            // varre os resultados e adiciona na lista...
            foreach (System.Text.RegularExpressions.Match match in matches)
                if (match.Success && match.Groups.Count > 1)
                {
                    string rowText = match.Groups[1].Value;

                    // pega os dados da linha...
                    System.Text.RegularExpressions.MatchCollection matchesTD =
                     System.Text.RegularExpressions.Regex.Matches(rowText, @"<TD.*?>(.*?)</TD>", System.Text.RegularExpressions.RegexOptions.IgnoreCase | System.Text.RegularExpressions.RegexOptions.Singleline);

                    // pega o resultado da linha...
                    List<string> rowValues = new List<string>();
                    foreach (System.Text.RegularExpressions.Match matchTD in matchesTD)
                        if (match.Success && matchTD.Groups.Count > 1)
                            rowValues.Add(matchTD.Groups[1].Value);

                    // preeche o grid...
                    // NESTE PONTO, rowValues contém a lista dos valores dentro de <TR>...
                    dt.Rows.Add(rowValues[0].ToString(), rowValues[1].ToString(), rowValues[2].ToString(), rowValues[3].ToString());
                }

            return dt;
        }

        //public DataTable ConsultaIcms()
        //{
        //    try
        //    {
        //        return DAO_FuncoesGerais.ConsultaIcms();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message.ToString());
        //    }
        //}
        //public DataTable ConsultaIpi()
        //{
        //    try
        //    {
        //        return DAO_FuncoesGerais.ConsultaIpi();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message.ToString());
        //    }
        //}
        //public DataTable ConsultaPis()
        //{
        //    try
        //    {
        //        return DAO_FuncoesGerais.ConsultaPis();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message.ToString());
        //    }
        //}
        //public DataTable ConsultaCofins()
        //{
        //    try
        //    {
        //        return DAO_FuncoesGerais.ConsultaCofins();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message.ToString());
        //    }
        //}
        //public DataTable ConsultarUnidade()
        //{
        //    try
        //    {
        //        return DAO_FuncoesGerais.ConsultarUnidade();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message.ToString());
        //    }
        //}

        //#region VALIDAR CPF
        ////eddiegleyson alves
        ////data:05/06/2012
        //public bool ValidaCPF(string vrCPF)
        //{
        //    //string valor = vrCPF.Replace(".", "");
        //    //valor = valor.Replace("-", "");

        //    if (vrCPF.Length != 11)
        //        return false;

        //    bool igual = true;
        //    for (int i = 1; i < 11 && igual; i++)
        //        if (vrCPF[i] != vrCPF[0])
        //            igual = false;
        //    if (igual || vrCPF == "12345678909")
        //        return false;
        //    int[] numeros = new int[11];
        //    for (int i = 0; i < 11; i++)
        //        numeros[i] = int.Parse(vrCPF[i].ToString());
        //    int soma = 0;
        //    for (int i = 0; i < 9; i++)
        //        soma += (10 - i) * numeros[i];
        //    int resultado = soma % 11;
        //    if (resultado == 1 || resultado == 0)
        //    {
        //        if (numeros[9] != 0)
        //            return false;
        //    }
        //    else if (numeros[9] != 11 - resultado)
        //        return false;
        //    soma = 0;
        //    for (int i = 0; i < 10; i++)
        //        soma += (11 - i) * numeros[i];
        //    resultado = soma % 11;
        //    if (resultado == 1 || resultado == 0)
        //    {
        //        if (numeros[10] != 0)
        //            return false;
        //    }
        //    else
        //        if (numeros[10] != 11 - resultado)
        //            return false;
        //    return true;
        //}
        //#endregion
        //#region CONSULTAR SE CPF JÁ POSSUI CADASTRO NA BASE DE DADOS
        ////Eddiegleyson alves
        ////data:06/06/2012
        //public bool ConsultaCpfCadastradoBaseDados(ENTIDADE_Cliente ObjE_Cliente)
        //{
        //    try
        //    {
        //        return (M_Cliente.DAO_ConsultaCpfCadastrado(ObjE_Cliente));
        //    }
        //    catch (Exception ex)
        //    {

        //        throw new Exception(ex.Message.ToString());
        //    }
        //}
        //#endregion
        //#region VALIDA CNPJ
        //public bool ValidaCNPJ(string vrCNPJ)
        //{

        //    string CNPJ = vrCNPJ;

        //    //CNPJ = CNPJ.Replace("/", "");

        //    //CNPJ = CNPJ.Replace("-", "");



        //    int[] digitos, soma, resultado;

        //    int nrDig;

        //    string ftmt;

        //    bool[] CNPJOk;



        //    ftmt = "6543298765432";

        //    digitos = new int[14];

        //    soma = new int[2];

        //    soma[0] = 0;

        //    soma[1] = 0;

        //    resultado = new int[2];

        //    resultado[0] = 0;

        //    resultado[1] = 0;

        //    CNPJOk = new bool[2];

        //    CNPJOk[0] = false;

        //    CNPJOk[1] = false;



        //    try
        //    {

        //        for (nrDig = 0; nrDig < 14; nrDig++)
        //        {

        //            digitos[nrDig] = int.Parse(

        //                CNPJ.Substring(nrDig, 1));

        //            if (nrDig <= 11)

        //                soma[0] += (digitos[nrDig] *

        //                  int.Parse(ftmt.Substring(

        //                  nrDig + 1, 1)));

        //            if (nrDig <= 12)

        //                soma[1] += (digitos[nrDig] *

        //                  int.Parse(ftmt.Substring(

        //                  nrDig, 1)));

        //        }



        //        for (nrDig = 0; nrDig < 2; nrDig++)
        //        {

        //            resultado[nrDig] = (soma[nrDig] % 11);

        //            if ((resultado[nrDig] == 0) || (

        //                 resultado[nrDig] == 1))

        //                CNPJOk[nrDig] = (

        //                digitos[12 + nrDig] == 0);

        //            else

        //                CNPJOk[nrDig] = (

        //                digitos[12 + nrDig] == (

        //                11 - resultado[nrDig]));

        //        }

        //        return (CNPJOk[0] && CNPJOk[1]);

        //    }

        //    catch
        //    {

        //        return false;

        //    }

        //}
        //#endregion
    }

}

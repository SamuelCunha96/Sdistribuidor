using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace SCA.Gerais
{
    class FuncoesGerais
    {
        public FuncoesGerais()
        {
        }
        public void AssinaturaDigital(XmlDocument xmlAssinar)
        {
            //string retorno = teste.Substring(0, teste.Length - 5);

        }

        public int RetornoCodigoIbge(int IdIbge)
        {
            int i = 0;
            //foreach (var item in Enum.GetValues(typeof(envEventoCancNFe.TCOrgaoIBGE)))
            //{
            //    if (item.ToString().Substring(item.ToString().Count() - 2, 2) == IdIbge.ToString())
            //    {
            //        break;
            //    }
            //    i += 1;
            //}

            return i;
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
                throw new Exception(ex.Message.ToString());
            }
        }
        public string CdSubItem(string item)
        {
            return item.Substring(item.Trim().Length - 1, 1);
        }
    }
}

using DAL.ItemVenda;
using DTO.ItemVenda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ItemVenda
{
    public class ItemVendaBLL
    {
        ItemVendaDAL itemVendaDAL = new ItemVendaDAL();
        public List<ItemVendaDTO> ObtemDadosVenda(bool pesquisaPorCupom, DateTime dtVenda, string termoPesquisa, string cdLoja)
        {
            string sqlCommand = string.Format("SELECT V.FP_AUTORIZACAO, I.CDBARRA, " +
                " I.FP_QTDEAUTORIZADA, I.FP_QTDEDIARIAPRESC, I.FP_QTDESOLICITADA, " +
                " I.FP_VLRPARCELAMS, I.FP_VLRPARCELACLI, I.VLRUNITARIO, " +
                " F.FP_USUARIO, F.FP_SENHA" +
                " FROM VENDA V, ITEMVENDA I, FUNCIONARIOS F" +
                " WHERE V.DATA = I.DATA" +
                " AND V.HORA = I.HORA" +
                " AND V.NRCUPOM = I.NRCUPOM" +
                " AND V.CDPOS = I.CDPOS" +
                " AND V.CDLOJA = I.CDLOJA" +
                " AND V.CDLOJA = @CDLOJAV" +
                " AND I.CDLOJA = @CDLOJAIV" +
              //  " AND V.FP_AUTORIZACAO IS NOT NULL" +
              //  " AND V.CDCONVENIO = (SELECT VALOR FROM PRC_BUSCA_PARAMETRO('CDCONVENIOFPOPULAR'))" +
              //  " AND V.FP_AUTORIZACAO IS NOT NULL" +
                " {0} = @TERMOPESQUISA " +
                " AND V.DATA = @DATAV" +
                " AND I.DATA = @DATAIV" +
                " AND F.CDFUNCIONARIO = I.CDFUNCIONARIO", pesquisaPorCupom ? "AND V.NRCUPOM": "AND V.FP_AUTORIZACAO");

            List<KeyValuePair<string, string>> parametrosSqlCommand = new List<KeyValuePair<string, string>>();
            parametrosSqlCommand.Add(new KeyValuePair<string, string>("@TERMOPESQUISA", termoPesquisa));
            parametrosSqlCommand.Add(new KeyValuePair<string, string>("@DATAV", dtVenda.ToShortDateString()));
            parametrosSqlCommand.Add(new KeyValuePair<string, string>("@DATAIV", dtVenda.ToShortDateString()));
            parametrosSqlCommand.Add(new KeyValuePair<string, string>("@CDLOJAV", cdLoja));
            parametrosSqlCommand.Add(new KeyValuePair<string, string>("@CDLOJAIV", cdLoja));
            return itemVendaDAL.ObtemDadosVenda(sqlCommand, parametrosSqlCommand);
        }
    }
}

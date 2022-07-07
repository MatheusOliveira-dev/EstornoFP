using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Paramdinamico
{
    public class ParamdinamicoDAL
    {
        public string ObtemParametro(string parametro)
        {
            string valorParametro = string.Empty;

            ConexaoAoBanco ConexaoAoBanco = new ConexaoAoBanco();

            FbCommand commandObtemParametro = new FbCommand("SELECT VALOR FROM PRC_BUSCA_PARAMETRO(@PARAMETRO)", ConexaoAoBanco.Conectar());

            commandObtemParametro.Parameters.AddWithValue("@PARAMETRO", parametro);

            valorParametro = (string)commandObtemParametro.ExecuteScalar();

            ConexaoAoBanco.Desconectar();

            return valorParametro;
        }
    }
}

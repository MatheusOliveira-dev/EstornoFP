using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DTO.Lojas;

namespace DAL.Lojas
{
    public class LojasDAL
    {
        public LojaDTO ObtemCNPJLoja(int cdLoja)
        {
            LojaDTO lojaDTO = new LojaDTO();

            ConexaoAoBanco ConexaoAoBanco = new ConexaoAoBanco();

            FbCommand commandObtemCnpjLojaLocal = new FbCommand("SELECT CGC FROM LOJAS" +
                " WHERE CDLOJA = @CDLOJA", ConexaoAoBanco.Conectar());

            commandObtemCnpjLojaLocal.Parameters.AddWithValue("@CDLOJA", cdLoja);

            lojaDTO.CNPJ = (string)commandObtemCnpjLojaLocal.ExecuteScalar();

            ConexaoAoBanco.Desconectar();

            return lojaDTO;
        }


        public List<LojaDTO> ObtemCdLojas()
        {
            List<LojaDTO> lstLojasDTO = new List<LojaDTO>();

            ConexaoAoBanco ConexaoAoBanco = new ConexaoAoBanco();

            FbCommand commandObtemCdLojas = new FbCommand("SELECT CDLOJA FROM LOJAS" +
                " WHERE FLGATIVO = 'S'" +
                " AND CDLOJA <> 0" +
                " ORDER BY CDLOJA", ConexaoAoBanco.Conectar());

            FbDataReader reader = commandObtemCdLojas.ExecuteReader();

            while (reader.Read())
            {
                LojaDTO lojaDTO = new LojaDTO();

                lojaDTO.CdLoja = reader.GetInt32(0);

                lstLojasDTO.Add(lojaDTO);
            }

            reader.Close();
            ConexaoAoBanco.Desconectar();

            return lstLojasDTO;
        }

        public int ObtemCdLojaLocal()
        {
            int cdLojaLocal = 1;

            ConexaoAoBanco ConexaoAoBanco = new ConexaoAoBanco();

            FbCommand commandObtemCnpjLojaLocal = new FbCommand("SELECT CDLOJA FROM LOJAS" +
                " WHERE CDLOJA = (SELECT VALOR FROM PRC_BUSCA_PARAMETRO('CDLOJA'))", ConexaoAoBanco.Conectar());

            cdLojaLocal = (int)commandObtemCnpjLojaLocal.ExecuteScalar();

            ConexaoAoBanco.Desconectar();

            return cdLojaLocal;
        }
    }
}

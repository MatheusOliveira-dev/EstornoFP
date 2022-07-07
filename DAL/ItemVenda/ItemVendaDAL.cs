using DTO.ItemVenda;
using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ItemVenda
{
    public class ItemVendaDAL
    {
        public List<ItemVendaDTO> ObtemDadosVenda(string sqlCommand,
            List<KeyValuePair<string, string>> parametrosSqlCommand)
        {
            List<ItemVendaDTO> lstItemVendaDTO = new List<ItemVendaDTO>();

            ConexaoAoBanco ConexaoAoBanco = new ConexaoAoBanco();

            FbCommand commandObtemDadosVenda = new FbCommand(sqlCommand, ConexaoAoBanco.Conectar());

            foreach (var parametro in parametrosSqlCommand)
            {
                commandObtemDadosVenda.Parameters.AddWithValue(parametro.Key, parametro.Value);
            }

            FbDataReader reader = commandObtemDadosVenda.ExecuteReader();
            
            while (reader.Read())
            {
                ItemVendaDTO itemVendaDTO = new ItemVendaDTO();

                itemVendaDTO.NrAutorizacaoFP = reader[0].ToString();
                itemVendaDTO.CdBarra = reader[1].ToString();
                itemVendaDTO.QtdeAutorizadaFP = reader.GetInt32(2);
                itemVendaDTO.QtdePrescritaFP = reader.GetInt32(3);
                itemVendaDTO.QtdeSolicitadaFP = reader.GetInt32(4);
                itemVendaDTO.VlrParcelaMSFP = reader.GetDecimal(5);
                itemVendaDTO.VlrParcelaClienteFP = reader.GetDecimal(6);
                itemVendaDTO.VlrUnitario = reader.GetDecimal(7);
                itemVendaDTO.FuncionarioUsuarioFP = reader[8].ToString();
                itemVendaDTO.FuncionarioSenhaFP = reader[9].ToString();
                lstItemVendaDTO.Add(itemVendaDTO);
            }

            reader.Close();
            ConexaoAoBanco.Desconectar();

            return lstItemVendaDTO;
        }
    }
}

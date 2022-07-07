using Core;
using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class ConexaoAoBanco
    {
        FirebirdSql.Data.FirebirdClient.FbConnection Conexao = new FbConnection();

        public ConexaoAoBanco()
        {
            string dataSource = Helpers.ObtemParametroSisIni("Servidor");
            string dataBase = Helpers.ObtemParametroSisIni("Endereco");
            string password = Helpers.ObtemParametroSisIni("Senha");

            password = string.IsNullOrWhiteSpace(password) ? "masterkey" : password;

            Conexao.ConnectionString = string.Format("DataSource={0};Database={1};User=SYSDBA;Password={2};Port=3050;Dialect=3;", 
                dataSource.Replace(":", null), dataBase, password);
        }


        public FbConnection Conectar()
        {
            if (Conexao.State == System.Data.ConnectionState.Closed)
            {
                Conexao.Open();
            }

            return Conexao;
        }

        public FbConnection Desconectar()
        {
            if (Conexao.State == System.Data.ConnectionState.Open)
            {
                Conexao.Close();
            }

            return Conexao;
        }
    }
}

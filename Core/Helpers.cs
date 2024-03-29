﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Core
{
    public static class Helpers
    {

        public static bool ArquivoExiste(string caminho, bool toUpper = true)
        {
            if (toUpper)
            {
                return File.Exists(caminho.ToUpper());
            }

            return File.Exists(caminho);
        }

        public static string ObtemParametroSisIni(string parametroBusca)
        {
            string linhasSisIni = File.ReadAllText("Sis.ini");

       
            foreach (var linha in linhasSisIni.Split('\n'))
            {
                if (!string.IsNullOrWhiteSpace(linha) 
                    && linha.Split('=')[0].Trim()
                    .ToUpper().Equals(parametroBusca.ToUpper()))
                {
                    return linha.Split('=')[1].ToString().Trim();
                }
                else
                {
                    continue;
                }

            }

            return string.Empty;
        }

        public static bool ValidaValorIntTextbox(string valor)
        {
            if (int.TryParse(valor, out int resultado))
                return true;
            else
                return false;
        }

        public static bool ValidaValorDoubleTextbox(string valor)
        {
            if (Double.TryParse(valor, out double resultado))
                return true;
            else
                return false;
        }
    }
}

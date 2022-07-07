using DAL.Paramdinamico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Paramdinamico
{
    public class ParamdinamicoBLL
    {
        ParamdinamicoDAL paramdinamicoDAL = new ParamdinamicoDAL();

        public string ObtemParametro(string parametro)
        {
            return paramdinamicoDAL.ObtemParametro(parametro);
        }
    }
}

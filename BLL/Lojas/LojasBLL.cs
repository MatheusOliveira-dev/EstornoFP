using DAL.Lojas;
using DTO.Lojas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Lojas
{
    public class LojasBLL
    {
        LojasDAL lojasDAL = new LojasDAL();

        public LojaDTO ObtemCNPJLoja(int cdLoja)
        {
            return lojasDAL.ObtemCNPJLoja(cdLoja);
        }

        public List<LojaDTO> ObtemCdLojas()
        {
            return lojasDAL.ObtemCdLojas();
        }

        public int ObtemCdLojaLocal()
        {
            return lojasDAL.ObtemCdLojaLocal();
        }
    }
}

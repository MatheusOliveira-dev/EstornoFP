using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NovoItemEstornoManual
    {
        public string EAN { get; set; }
        public int QtdePrescrita { get; set; }
        public int QtdeSolicitada { get; set; }
        public int QtdeAutorizada { get; set; }
        public int QtdeDevolvida { get; set; }
        public double VlrParcelaMS { get; set; }
        public double VlrParcelaCliente { get; set; }
        public double VlrVenda { get; set; }
    }
}

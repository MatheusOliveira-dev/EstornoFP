using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.ItemVenda
{
    public class ItemVendaDTO
    {
        public string NrAutorizacaoFP {get; set;}
        public string CdBarra { get; set; }
        public int QtdeAutorizadaFP { get; set; }
        public int QtdePrescritaFP { get; set; }
        public int QtdeSolicitadaFP { get; set; }
        public decimal VlrParcelaMSFP { get; set; }
        public decimal VlrParcelaClienteFP { get; set; }
        public decimal VlrUnitario { get; set; }
        public string FuncionarioUsuarioFP { get; set; }
        public string FuncionarioSenhaFP { get; set; }
    }
}

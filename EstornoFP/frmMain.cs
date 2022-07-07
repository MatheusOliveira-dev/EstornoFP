using BLL.ItemVenda;
using BLL.Lojas;
using BLL.Paramdinamico;
using DTO.ItemVenda;
using DTO.Lojas;
using EstornoFP.WSFP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core;
namespace EstornoFP
{
    public partial class frmMain : Form
    {
        private readonly ParamdinamicoBLL paramdinamicoBLL = new ParamdinamicoBLL();
        private readonly LojasBLL lojasBLL = new LojasBLL();

        public frmMain()
        {
            InitializeComponent();
            
            if (!Helpers.ArquivoExiste("Sis.ini"))
            {
                MessageBox.Show("Arquivo Sis.ini Não Encontrado.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

                if (Application.MessageLoop)
                    Application.Exit();
                else
                    Environment.Exit(1);
            }
          
            ObtemCdLojas();
        }

        private void ObtemCdLojas()
        {
            cmbxLojaVenda.Items.Clear();

            List<LojaDTO> lstLojasDTO = new List<LojaDTO>();

            try
            {
                lstLojasDTO = lojasBLL.ObtemCdLojas();
               
                foreach (var lojaDTO in lstLojasDTO)
                {
                    cmbxLojaVenda.Items.Add(lojaDTO.CdLoja);
                }

                cmbxLojaVenda.SelectedIndex = cmbxLojaVenda.FindStringExact(lojasBLL.ObtemCdLojaLocal().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Erro ao Obter as CdLojas.\n\nErro: {0}", ex.Message), "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void EstornaVenda()
        {
            try
            {
                Tuple<MedicamentoDTO[], List<ItemVendaDTO>> dadosVenda = ObtemDadosVenda();

                if (dadosVenda.Item1 == null || dadosVenda.Item2 == null || dadosVenda.Item2.Count <= 0)
                {
                    MessageBox.Show("Nenhuma Venda Encontrada.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    return;
                }

                MedicamentoDTO[] medicamentosDTO = dadosVenda.Item1;

                WSFP.UsuarioFarmaciaDTO usuarioFarmaciaDTO = ObtemDadosUsuarioFarmacia();
                usuarioFarmaciaDTO.usuarioVendedor = dadosVenda.Item2[0].FuncionarioUsuarioFP;
                usuarioFarmaciaDTO.senhaVendedor = dadosVenda.Item2[0].FuncionarioSenhaFP;

                WSFP.EstornoDTO estornoDTO = new EstornoDTO();
                estornoDTO.nuCnpj = ObtemCNPJLojaVenda(int.Parse(cmbxLojaVenda.SelectedItem.ToString()));
                estornoDTO.nuAutorizacao = dadosVenda.Item2[0].NrAutorizacaoFP;
                estornoDTO.arrMedicamentoDTO = medicamentosDTO;

                EstornoFP.WSFP.ConfirmacaoEstornoDTO confirmacaoEstornoDTO = new ConfirmacaoEstornoDTO();

                EstornoFP.WSFP.ServicoSolicitacaoWSClient servicoSolicitacaoWS = new ServicoSolicitacaoWSClient();

                confirmacaoEstornoDTO = servicoSolicitacaoWS.executarEstorno(estornoDTO, usuarioFarmaciaDTO);


                if (string.IsNullOrWhiteSpace(confirmacaoEstornoDTO.nuEstorno))
                {
                    MessageBox.Show(string.Format("Estorno NÃO efetuado.\n\nMensagem de Erros: {0}", confirmacaoEstornoDTO.descMensagemErro), "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    MessageBox.Show(string.Format("Estorno Efetuado.\n\nNº de Estorno: {0}\n\nSituação de Estorno: {1}", confirmacaoEstornoDTO.nuEstorno, confirmacaoEstornoDTO.inSituacaoEstorno), "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    tbNrAutorizacaoNrCupom.Text = string.Empty;
                    ObtemCdLojas();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Processo de Estorno Abortado.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }
        }

        private string ObtemCNPJLojaVenda(int cdLoja)
        {
            string cnpjLojaVenda = string.Empty;
            
            try
            {
                cnpjLojaVenda = lojasBLL.ObtemCNPJLoja(cdLoja).CNPJ;
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Erro ao Obter o CNPJ da Loja da Venda.\n\nErro: {0}", ex.Message), "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                throw;
            }

            return cnpjLojaVenda;
        }

        private WSFP.UsuarioFarmaciaDTO ObtemDadosUsuarioFarmacia()
        {
            WSFP.UsuarioFarmaciaDTO usuarioFarmaciaDTO = new WSFP.UsuarioFarmaciaDTO();

            try
            {
                usuarioFarmaciaDTO.usuarioFarmacia = paramdinamicoBLL.ObtemParametro("FP_USUARIO");
                usuarioFarmaciaDTO.senhaFarmacia = paramdinamicoBLL.ObtemParametro("FP_SENHA");
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Erro ao Obter o Usuário e Senha da Loja na Farmácia Popular.\n\nErro: {0}", ex.Message), "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                throw;
            }
          

            return usuarioFarmaciaDTO;
        }

        private Tuple<MedicamentoDTO[], List<ItemVendaDTO>> ObtemDadosVenda()
        {
            ItemVendaBLL itemVendaBLL = new ItemVendaBLL();
            
            try
            {
                List<ItemVendaDTO> lstItensVendaDTO = new List<ItemVendaDTO>();
                
                lstItensVendaDTO = itemVendaBLL.ObtemDadosVenda(rdBtnNrCupomFiscal.Checked, dtPickerDataVenda.Value, 
                    tbNrAutorizacaoNrCupom.Text.Trim(), cmbxLojaVenda.SelectedItem.ToString());

                MedicamentoDTO[] medicamentoDTOs = new MedicamentoDTO[lstItensVendaDTO.Count];

                for (int i = 0; i < lstItensVendaDTO.Count; i++)
                {
                    MedicamentoDTO medicamentoDTO = new MedicamentoDTO();

                    medicamentoDTO.coCodigoBarra = lstItensVendaDTO[i].CdBarra;
                    medicamentoDTO.qtAutorizada = lstItensVendaDTO[i].QtdeAutorizadaFP;
                    medicamentoDTO.qtPrescrita = lstItensVendaDTO[i].QtdePrescritaFP;
                    medicamentoDTO.qtSolicitada = lstItensVendaDTO[i].QtdeSolicitadaFP;
                    medicamentoDTO.vlPrecoSubsidiadoMS = Convert.ToDouble(lstItensVendaDTO[i].VlrParcelaMSFP);
                    medicamentoDTO.vlPrecoSubsidiadoPaciente = Convert.ToDouble(lstItensVendaDTO[i].VlrParcelaClienteFP);
                    medicamentoDTO.vlPrecoVenda = Convert.ToDouble(lstItensVendaDTO[i].VlrUnitario);
                    medicamentoDTO.qtDevolvida = lstItensVendaDTO[i].QtdeAutorizadaFP;
                    medicamentoDTOs[i] = medicamentoDTO;
                }

                return Tuple.Create(medicamentoDTOs, lstItensVendaDTO);
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Erro ao Obter os Dados da Venda.\n\nErro: {0}", ex.Message), "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                throw;
            }
        }

        private void btnCancelarAutorizacao_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNrAutorizacaoNrCupom.Text))
            {
                MessageBox.Show("O Número da Autorização ou Número do Cupom Fiscal deve ser informado.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                tbNrAutorizacaoNrCupom.Focus();
                return;
            }
            else if (cmbxLojaVenda.Items.Count <= 0 || cmbxLojaVenda.SelectedIndex < 0)
            {
                MessageBox.Show("A Loja da Venda deve ser informada.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                cmbxLojaVenda.Focus();
                return;
            }
            else
            {
                if (MessageBox.Show("Confirma o Estorno da Venda?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    EstornaVenda();
                }
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            dtPickerDataVenda.Value = DateTime.Now;
        }

        private void rdBtnNrAutorizacao_CheckedChanged(object sender, EventArgs e)
        {
            lblPesquisa.Text = " Nº Autorização:";
           
        }

        private void rdBtnNrCupomFiscal_CheckedChanged(object sender, EventArgs e)
        {
            lblPesquisa.Text = "Nº Cupom Fiscal:";
        }
    }
}

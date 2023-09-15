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
using DTO;
using System.ServiceModel.Channels;

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
            cmbxLojaVenda_Automatico.Items.Clear();
            cmbxLojaVenda_Manual.Items.Clear();

            List<LojaDTO> lstLojasDTO = new List<LojaDTO>();

            try
            {
                lstLojasDTO = lojasBLL.ObtemCdLojas();
               
                foreach (var lojaDTO in lstLojasDTO)
                {
                    cmbxLojaVenda_Automatico.Items.Add(lojaDTO.CdLoja);
                    cmbxLojaVenda_Manual.Items.Add(lojaDTO.CdLoja);
                }

                cmbxLojaVenda_Automatico.SelectedIndex = cmbxLojaVenda_Automatico.FindStringExact(lojasBLL.ObtemCdLojaLocal().ToString());
                cmbxLojaVenda_Manual.SelectedIndex = cmbxLojaVenda_Manual.FindStringExact(lojasBLL.ObtemCdLojaLocal().ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Erro ao Obter as CdLojas.\n\nErro: {0}", ex.Message), "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void EstornaVenda_Automatico()
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
                estornoDTO.nuCnpj = ObtemCNPJLojaVenda(int.Parse(cmbxLojaVenda_Automatico.SelectedItem.ToString()));
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
                    tbNrAutorizacaoNrCupom_Automatico.Text = string.Empty;
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
                
                lstItensVendaDTO = itemVendaBLL.ObtemDadosVenda(rdBtnNrCupomFiscal_Automatico.Checked, dtPickerDataVenda_Automatico.Value, 
                    tbNrAutorizacaoNrCupom_Automatico.Text.Trim(), cmbxLojaVenda_Automatico.SelectedItem.ToString());

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
            if (string.IsNullOrWhiteSpace(tbNrAutorizacaoNrCupom_Automatico.Text))
            {
                MessageBox.Show("O Número da Autorização ou Número do Cupom Fiscal deve ser informado.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                tbNrAutorizacaoNrCupom_Automatico.Focus();
                return;
            }
            else if (cmbxLojaVenda_Automatico.Items.Count <= 0 || cmbxLojaVenda_Automatico.SelectedIndex < 0)
            {
                MessageBox.Show("A Loja da Venda deve ser informada.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                cmbxLojaVenda_Automatico.Focus();
                return;
            }
            else
            {
                if (MessageBox.Show("Confirma o Estorno da Autorização?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    EstornaVenda_Automatico();
                }
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            dtPickerDataVenda_Automatico.Value = DateTime.Now;
        }

        private void rdBtnNrAutorizacao_CheckedChanged(object sender, EventArgs e)
        {
            lblPesquisa.Text = " Nº Autorização:";
            tbNrAutorizacaoNrCupom_Automatico.Size = new Size(135, 22);
           
        }

        private void rdBtnNrCupomFiscal_CheckedChanged(object sender, EventArgs e)
        {
            lblPesquisa.Text = "Nº Cupom Fiscal:";
            tbNrAutorizacaoNrCupom_Automatico.Size = new Size(80, 22);
        }


        private void EstornaVenda_Manual()
        {
            try
            {
                MedicamentoDTO[] medicamentoDTOs = new MedicamentoDTO[dtGridViewItensVenda_Manual.Rows.Count];

                for (int i = 0; i < dtGridViewItensVenda_Manual.Rows.Count; i++)
                {
                    MedicamentoDTO medicamentoDTO = new MedicamentoDTO();
                    medicamentoDTO.coCodigoBarra = dtGridViewItensVenda_Manual.Rows[i].Cells["column_EAN"].Value.ToString();
                    medicamentoDTO.qtAutorizada = int.Parse(dtGridViewItensVenda_Manual.Rows[i].Cells["column_QtdeAutorizada"].Value.ToString());
                    medicamentoDTO.qtPrescrita = int.Parse(dtGridViewItensVenda_Manual.Rows[i].Cells["column_QtdePrescrita"].Value.ToString());
                    medicamentoDTO.qtSolicitada = int.Parse(dtGridViewItensVenda_Manual.Rows[i].Cells["column_QtdeSolicitada"].Value.ToString());
                    medicamentoDTO.vlPrecoSubsidiadoMS = Convert.ToDouble(dtGridViewItensVenda_Manual.Rows[i].Cells["column_VlrSubsidioMS"].Value.ToString());
                    medicamentoDTO.vlPrecoSubsidiadoPaciente = Convert.ToDouble(dtGridViewItensVenda_Manual.Rows[i].Cells["column_VlrSubsidioPaciente"].Value.ToString());
                    medicamentoDTO.vlPrecoVenda = Convert.ToDouble(dtGridViewItensVenda_Manual.Rows[i].Cells["column_VlrVenda"].Value.ToString());
                    medicamentoDTO.qtDevolvida = int.Parse(dtGridViewItensVenda_Manual.Rows[i].Cells["column_QtdeDevolvida"].Value.ToString());
                    medicamentoDTOs[i] = medicamentoDTO;
                }
            
                WSFP.UsuarioFarmaciaDTO usuarioFarmaciaDTO = ObtemDadosUsuarioFarmacia();
                usuarioFarmaciaDTO.usuarioVendedor = tbCPFFuncionario_Manual.Text.Trim();
                usuarioFarmaciaDTO.senhaVendedor = tbSenhaFuncionario_Manual.Text.Trim();

                WSFP.EstornoDTO estornoDTO = new EstornoDTO();
                estornoDTO.nuCnpj = ObtemCNPJLojaVenda(int.Parse(cmbxLojaVenda_Manual.SelectedItem.ToString()));
                estornoDTO.nuAutorizacao = tbNrAutorizacao_Manual.Text.Trim();
                estornoDTO.arrMedicamentoDTO = medicamentoDTOs;

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
                    tbNrAutorizacao_Manual.Text = string.Empty;
                    ObtemCdLojas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Processo de Estorno Abortado.\n\nErro: " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }
        }

        private void btnCancelamentoAutorizacao_Manual_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNrAutorizacao_Manual.Text))
            {
                MessageBox.Show("O Número da Autorização deve ser informado.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                tbNrAutorizacao_Manual.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(tbCPFFuncionario_Manual.Text))
            {
                MessageBox.Show("O Login (CPF) de um funcionário deve ser informado.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                tbCPFFuncionario_Manual.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(tbSenhaFuncionario_Manual.Text))
            {
                MessageBox.Show("A Senha do funcionário deve ser informada.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                tbSenhaFuncionario_Manual.Focus();
                return;
            }
            else if (cmbxLojaVenda_Manual.Items.Count <= 0 || cmbxLojaVenda_Manual.SelectedIndex < 0)
            {
                MessageBox.Show("A Loja da Venda deve ser informada.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                cmbxLojaVenda_Manual.Focus();
                return;
            }
            else if (dtGridViewItensVenda_Manual.Rows.Count <= 0)
            {
                MessageBox.Show("Os produtos devem ser informados com seus respectivos valores.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return;
            }
            else
            {
                if (MessageBox.Show("Confirma o Estorno da Autorização?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    EstornaVenda_Manual();
                }
            }
        }

        private void btnAdicionarItem_Click(object sender, EventArgs e)
        {
            frmAdicionarItemEstornoManual frmAdicionarItemEstornoManual = new frmAdicionarItemEstornoManual();
            frmAdicionarItemEstornoManual.NovoItemEvent += FrmAdicionarItemEstornoManual_NovoItemEvent;
            frmAdicionarItemEstornoManual.ShowDialog();
        }

        private void FrmAdicionarItemEstornoManual_NovoItemEvent(NovoItemEstornoManual novoItem, bool addNovoItem)
        {
            dtGridViewItensVenda_Manual.Rows.Add(novoItem.EAN, novoItem.QtdePrescrita, novoItem.QtdeSolicitada, novoItem.QtdeAutorizada, novoItem.QtdeDevolvida, novoItem.VlrParcelaMS, novoItem.VlrParcelaCliente, novoItem.VlrVenda);

            if (addNovoItem)
                btnAdicionarItem.PerformClick();

        }

        private void btnRemoverItem_Click(object sender, EventArgs e)
        {
            if (dtGridViewItensVenda_Manual.Rows.Count > 0 && dtGridViewItensVenda_Manual.SelectedRows.Count > 0)
            {
                dtGridViewItensVenda_Manual.Rows.Remove(dtGridViewItensVenda_Manual.CurrentRow);
            }
        }
    }
}

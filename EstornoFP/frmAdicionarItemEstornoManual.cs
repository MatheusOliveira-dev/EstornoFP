using Core;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstornoFP
{
    public partial class frmAdicionarItemEstornoManual : Form
    {
        public event Action<NovoItemEstornoManual, bool> NovoItemEvent;

        public frmAdicionarItemEstornoManual()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            tbEAN.Text = string.Empty;
            tbQtdePrescrita.Text = string.Empty;
            tbQtdeSolicitada.Text = string.Empty;
            tbQtdeAutorizada.Text = string.Empty;
            tbQtdeDevolvida.Text = string.Empty;
            tbVlrParcelaMS.Text = string.Empty;
            tbVlrParcelaCliente.Text = string.Empty;
            tbVlrVenda.Text = string.Empty;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbEAN.Text.Trim()))
            {
                MessageBox.Show("EAN do item deve ser informado.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                tbEAN.Focus();
                return;
            }
            else if (!Helpers.ValidaValorIntTextbox(tbQtdePrescrita.Text.Trim()))
            {
                MessageBox.Show("Quantidade Prescrita informada é inválida.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                tbQtdePrescrita.Focus();
                return;
            }
            else if (!Helpers.ValidaValorIntTextbox(tbQtdeSolicitada.Text.Trim()))
            {
                MessageBox.Show("Quantidade Solicitada informada é inválida.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                tbQtdeSolicitada.Focus();
                return;
            }
            else if (!Helpers.ValidaValorIntTextbox(tbQtdeAutorizada.Text.Trim()))
            {
                MessageBox.Show("Quantidade Autorizada informada é inválida.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                tbQtdeAutorizada.Focus();
                return;
            }
            else if (!Helpers.ValidaValorIntTextbox(tbQtdeDevolvida.Text.Trim()))
            {
                MessageBox.Show("Quantidade Devolvida informada é inválida.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                tbQtdeDevolvida.Focus();
                return;
            }
            else if (!Helpers.ValidaValorDoubleTextbox(tbVlrParcelaMS.Text.Trim()))
            {
                MessageBox.Show("Valor da Parcela do MS informado é inválida.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                tbVlrParcelaMS.Focus();
                return;
            }
            else if (!Helpers.ValidaValorDoubleTextbox(tbVlrParcelaCliente.Text.Trim()))
            {
                MessageBox.Show("Valor da Parcela do Cliente informado é inválida.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                tbVlrParcelaCliente.Focus();
                return;
            }
            else if (!Helpers.ValidaValorDoubleTextbox(tbVlrVenda.Text.Trim()))
            {
                MessageBox.Show("Valor Venda informado é inválido.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                tbVlrVenda.Focus();
                return;
            }
            else
            {
                bool addNovoItem = false;
                NovoItemEstornoManual novoItemEstornoManual = new NovoItemEstornoManual();
                novoItemEstornoManual.EAN = tbEAN.Text.Trim();
                novoItemEstornoManual.QtdePrescrita = int.Parse(tbQtdePrescrita.Text.Trim());
                novoItemEstornoManual.QtdeSolicitada = int.Parse(tbQtdeSolicitada.Text.Trim());
                novoItemEstornoManual.QtdeAutorizada = int.Parse(tbQtdeAutorizada.Text.Trim());
                novoItemEstornoManual.QtdeDevolvida = int.Parse(tbQtdeDevolvida.Text.Trim());
                novoItemEstornoManual.VlrParcelaMS = Convert.ToDouble(tbVlrParcelaMS.Text.Trim());
                novoItemEstornoManual.VlrParcelaCliente = Convert.ToDouble(tbVlrParcelaCliente.Text.Trim());
                novoItemEstornoManual.VlrVenda = Convert.ToDouble(tbVlrVenda.Text.Trim());

                if (MessageBox.Show("Item adicionado. Deseja adicionar outro item?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    addNovoItem = true;
                    this.Opacity = 0;
                }

                NovoItemEvent(novoItemEstornoManual, addNovoItem);
                this.Close();
            }
        }
    }
}

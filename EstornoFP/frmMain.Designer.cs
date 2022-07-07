namespace EstornoFP
{
    partial class frmMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdBtnNrCupomFiscal = new System.Windows.Forms.RadioButton();
            this.rdBtnNrAutorizacao = new System.Windows.Forms.RadioButton();
            this.dtPickerDataVenda = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelarAutorizacao = new System.Windows.Forms.Button();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.tbNrAutorizacaoNrCupom = new System.Windows.Forms.TextBox();
            this.cmbxLojaVenda = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdBtnNrCupomFiscal);
            this.groupBox1.Controls.Add(this.rdBtnNrAutorizacao);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 56);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar Por";
            // 
            // rdBtnNrCupomFiscal
            // 
            this.rdBtnNrCupomFiscal.AutoSize = true;
            this.rdBtnNrCupomFiscal.Checked = true;
            this.rdBtnNrCupomFiscal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnNrCupomFiscal.Location = new System.Drawing.Point(6, 21);
            this.rdBtnNrCupomFiscal.Name = "rdBtnNrCupomFiscal";
            this.rdBtnNrCupomFiscal.Size = new System.Drawing.Size(109, 17);
            this.rdBtnNrCupomFiscal.TabIndex = 1;
            this.rdBtnNrCupomFiscal.TabStop = true;
            this.rdBtnNrCupomFiscal.Text = "Nº Cupom Fiscal";
            this.rdBtnNrCupomFiscal.UseVisualStyleBackColor = true;
            this.rdBtnNrCupomFiscal.CheckedChanged += new System.EventHandler(this.rdBtnNrCupomFiscal_CheckedChanged);
            // 
            // rdBtnNrAutorizacao
            // 
            this.rdBtnNrAutorizacao.AutoSize = true;
            this.rdBtnNrAutorizacao.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnNrAutorizacao.Location = new System.Drawing.Point(119, 21);
            this.rdBtnNrAutorizacao.Name = "rdBtnNrAutorizacao";
            this.rdBtnNrAutorizacao.Size = new System.Drawing.Size(102, 17);
            this.rdBtnNrAutorizacao.TabIndex = 0;
            this.rdBtnNrAutorizacao.Text = "Nº Autorização";
            this.rdBtnNrAutorizacao.UseVisualStyleBackColor = true;
            this.rdBtnNrAutorizacao.CheckedChanged += new System.EventHandler(this.rdBtnNrAutorizacao_CheckedChanged);
            // 
            // dtPickerDataVenda
            // 
            this.dtPickerDataVenda.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPickerDataVenda.Location = new System.Drawing.Point(103, 69);
            this.dtPickerDataVenda.Name = "dtPickerDataVenda";
            this.dtPickerDataVenda.Size = new System.Drawing.Size(80, 20);
            this.dtPickerDataVenda.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label1.Location = new System.Drawing.Point(13, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Data da Venda:";
            // 
            // btnCancelarAutorizacao
            // 
            this.btnCancelarAutorizacao.Location = new System.Drawing.Point(103, 149);
            this.btnCancelarAutorizacao.Name = "btnCancelarAutorizacao";
            this.btnCancelarAutorizacao.Size = new System.Drawing.Size(130, 23);
            this.btnCancelarAutorizacao.TabIndex = 3;
            this.btnCancelarAutorizacao.Text = "Cancelar Autorização";
            this.btnCancelarAutorizacao.UseVisualStyleBackColor = true;
            this.btnCancelarAutorizacao.Click += new System.EventHandler(this.btnCancelarAutorizacao_Click);
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblPesquisa.Location = new System.Drawing.Point(4, 98);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(94, 13);
            this.lblPesquisa.TabIndex = 4;
            this.lblPesquisa.Text = "Nº Cupom Fiscal:";
            // 
            // tbNrAutorizacaoNrCupom
            // 
            this.tbNrAutorizacaoNrCupom.Location = new System.Drawing.Point(103, 95);
            this.tbNrAutorizacaoNrCupom.Name = "tbNrAutorizacaoNrCupom";
            this.tbNrAutorizacaoNrCupom.Size = new System.Drawing.Size(130, 20);
            this.tbNrAutorizacaoNrCupom.TabIndex = 5;
            // 
            // cmbxLojaVenda
            // 
            this.cmbxLojaVenda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxLojaVenda.FormattingEnabled = true;
            this.cmbxLojaVenda.Location = new System.Drawing.Point(103, 121);
            this.cmbxLojaVenda.Name = "cmbxLojaVenda";
            this.cmbxLojaVenda.Size = new System.Drawing.Size(67, 21);
            this.cmbxLojaVenda.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label2.Location = new System.Drawing.Point(16, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Loja da Venda:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(239, 184);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbxLojaVenda);
            this.Controls.Add(this.tbNrAutorizacaoNrCupom);
            this.Controls.Add(this.lblPesquisa);
            this.Controls.Add(this.btnCancelarAutorizacao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtPickerDataVenda);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estorno FP";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdBtnNrCupomFiscal;
        private System.Windows.Forms.RadioButton rdBtnNrAutorizacao;
        private System.Windows.Forms.DateTimePicker dtPickerDataVenda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelarAutorizacao;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.TextBox tbNrAutorizacaoNrCupom;
        private System.Windows.Forms.ComboBox cmbxLojaVenda;
        private System.Windows.Forms.Label label2;
    }
}


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
            this.rdBtnNrCupomFiscal_Automatico = new System.Windows.Forms.RadioButton();
            this.rdBtnNrAutorizacao_Automatico = new System.Windows.Forms.RadioButton();
            this.dtPickerDataVenda_Automatico = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelarAutorizacao_Automatico = new System.Windows.Forms.Button();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.tbNrAutorizacaoNrCupom_Automatico = new System.Windows.Forms.TextBox();
            this.cmbxLojaVenda_Automatico = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnRemoverItem = new System.Windows.Forms.Button();
            this.btnAdicionarItem = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCancelamentoAutorizacao_Manual = new System.Windows.Forms.Button();
            this.dtGridViewItensVenda_Manual = new System.Windows.Forms.DataGridView();
            this.column_EAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_QtdePrescrita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_QtdeSolicitada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_QtdeAutorizada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_QtdeDevolvida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_VlrSubsidioMS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_VlrSubsidioPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_VlrVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbxLojaVenda_Manual = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSenhaFuncionario_Manual = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCPFFuncionario_Manual = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNrAutorizacao_Manual = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewItensVenda_Manual)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdBtnNrCupomFiscal_Automatico);
            this.groupBox1.Controls.Add(this.rdBtnNrAutorizacao_Automatico);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(111, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 56);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar Por";
            // 
            // rdBtnNrCupomFiscal_Automatico
            // 
            this.rdBtnNrCupomFiscal_Automatico.AutoSize = true;
            this.rdBtnNrCupomFiscal_Automatico.Checked = true;
            this.rdBtnNrCupomFiscal_Automatico.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnNrCupomFiscal_Automatico.Location = new System.Drawing.Point(14, 22);
            this.rdBtnNrCupomFiscal_Automatico.Name = "rdBtnNrCupomFiscal_Automatico";
            this.rdBtnNrCupomFiscal_Automatico.Size = new System.Drawing.Size(109, 17);
            this.rdBtnNrCupomFiscal_Automatico.TabIndex = 1;
            this.rdBtnNrCupomFiscal_Automatico.TabStop = true;
            this.rdBtnNrCupomFiscal_Automatico.Text = "Nº Cupom Fiscal";
            this.rdBtnNrCupomFiscal_Automatico.UseVisualStyleBackColor = true;
            this.rdBtnNrCupomFiscal_Automatico.CheckedChanged += new System.EventHandler(this.rdBtnNrCupomFiscal_CheckedChanged);
            // 
            // rdBtnNrAutorizacao_Automatico
            // 
            this.rdBtnNrAutorizacao_Automatico.AutoSize = true;
            this.rdBtnNrAutorizacao_Automatico.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnNrAutorizacao_Automatico.Location = new System.Drawing.Point(127, 22);
            this.rdBtnNrAutorizacao_Automatico.Name = "rdBtnNrAutorizacao_Automatico";
            this.rdBtnNrAutorizacao_Automatico.Size = new System.Drawing.Size(120, 17);
            this.rdBtnNrAutorizacao_Automatico.TabIndex = 0;
            this.rdBtnNrAutorizacao_Automatico.Text = "Nº Autorização F.P";
            this.rdBtnNrAutorizacao_Automatico.UseVisualStyleBackColor = true;
            this.rdBtnNrAutorizacao_Automatico.CheckedChanged += new System.EventHandler(this.rdBtnNrAutorizacao_CheckedChanged);
            // 
            // dtPickerDataVenda_Automatico
            // 
            this.dtPickerDataVenda_Automatico.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPickerDataVenda_Automatico.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPickerDataVenda_Automatico.Location = new System.Drawing.Point(241, 68);
            this.dtPickerDataVenda_Automatico.Name = "dtPickerDataVenda_Automatico";
            this.dtPickerDataVenda_Automatico.Size = new System.Drawing.Size(80, 22);
            this.dtPickerDataVenda_Automatico.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label1.Location = new System.Drawing.Point(151, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Data da Venda:";
            // 
            // btnCancelarAutorizacao_Automatico
            // 
            this.btnCancelarAutorizacao_Automatico.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnCancelarAutorizacao_Automatico.Location = new System.Drawing.Point(111, 166);
            this.btnCancelarAutorizacao_Automatico.Name = "btnCancelarAutorizacao_Automatico";
            this.btnCancelarAutorizacao_Automatico.Size = new System.Drawing.Size(261, 28);
            this.btnCancelarAutorizacao_Automatico.TabIndex = 3;
            this.btnCancelarAutorizacao_Automatico.Text = "Cancelar Autorização";
            this.btnCancelarAutorizacao_Automatico.UseVisualStyleBackColor = true;
            this.btnCancelarAutorizacao_Automatico.Click += new System.EventHandler(this.btnCancelarAutorizacao_Click);
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblPesquisa.Location = new System.Drawing.Point(142, 97);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(94, 13);
            this.lblPesquisa.TabIndex = 4;
            this.lblPesquisa.Text = "Nº Cupom Fiscal:";
            // 
            // tbNrAutorizacaoNrCupom_Automatico
            // 
            this.tbNrAutorizacaoNrCupom_Automatico.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNrAutorizacaoNrCupom_Automatico.Location = new System.Drawing.Point(241, 94);
            this.tbNrAutorizacaoNrCupom_Automatico.Name = "tbNrAutorizacaoNrCupom_Automatico";
            this.tbNrAutorizacaoNrCupom_Automatico.Size = new System.Drawing.Size(80, 22);
            this.tbNrAutorizacaoNrCupom_Automatico.TabIndex = 5;
            // 
            // cmbxLojaVenda_Automatico
            // 
            this.cmbxLojaVenda_Automatico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxLojaVenda_Automatico.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxLojaVenda_Automatico.FormattingEnabled = true;
            this.cmbxLojaVenda_Automatico.Location = new System.Drawing.Point(241, 120);
            this.cmbxLojaVenda_Automatico.Name = "cmbxLojaVenda_Automatico";
            this.cmbxLojaVenda_Automatico.Size = new System.Drawing.Size(80, 21);
            this.cmbxLojaVenda_Automatico.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label2.Location = new System.Drawing.Point(154, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Loja da Venda:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(7, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(497, 339);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.cmbxLojaVenda_Automatico);
            this.tabPage1.Controls.Add(this.btnCancelarAutorizacao_Automatico);
            this.tabPage1.Controls.Add(this.dtPickerDataVenda_Automatico);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.lblPesquisa);
            this.tabPage1.Controls.Add(this.tbNrAutorizacaoNrCupom_Automatico);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(489, 313);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Automático";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnRemoverItem);
            this.tabPage2.Controls.Add(this.btnAdicionarItem);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.btnCancelamentoAutorizacao_Manual);
            this.tabPage2.Controls.Add(this.dtGridViewItensVenda_Manual);
            this.tabPage2.Controls.Add(this.cmbxLojaVenda_Manual);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.tbSenhaFuncionario_Manual);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.tbCPFFuncionario_Manual);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.tbNrAutorizacao_Manual);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(489, 313);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Manual";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnRemoverItem
            // 
            this.btnRemoverItem.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverItem.Location = new System.Drawing.Point(404, 96);
            this.btnRemoverItem.Name = "btnRemoverItem";
            this.btnRemoverItem.Size = new System.Drawing.Size(81, 28);
            this.btnRemoverItem.TabIndex = 18;
            this.btnRemoverItem.Text = "Remover Item -";
            this.btnRemoverItem.UseVisualStyleBackColor = true;
            this.btnRemoverItem.Click += new System.EventHandler(this.btnRemoverItem_Click);
            // 
            // btnAdicionarItem
            // 
            this.btnAdicionarItem.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarItem.Location = new System.Drawing.Point(320, 96);
            this.btnAdicionarItem.Name = "btnAdicionarItem";
            this.btnAdicionarItem.Size = new System.Drawing.Size(81, 28);
            this.btnAdicionarItem.TabIndex = 17;
            this.btnAdicionarItem.Text = "Adicionar Item +";
            this.btnAdicionarItem.UseVisualStyleBackColor = true;
            this.btnAdicionarItem.Click += new System.EventHandler(this.btnAdicionarItem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label7.Location = new System.Drawing.Point(6, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Itens da Venda:";
            // 
            // btnCancelamentoAutorizacao_Manual
            // 
            this.btnCancelamentoAutorizacao_Manual.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnCancelamentoAutorizacao_Manual.Location = new System.Drawing.Point(355, 282);
            this.btnCancelamentoAutorizacao_Manual.Name = "btnCancelamentoAutorizacao_Manual";
            this.btnCancelamentoAutorizacao_Manual.Size = new System.Drawing.Size(134, 28);
            this.btnCancelamentoAutorizacao_Manual.TabIndex = 15;
            this.btnCancelamentoAutorizacao_Manual.Text = "Cancelar Autorização";
            this.btnCancelamentoAutorizacao_Manual.UseVisualStyleBackColor = true;
            this.btnCancelamentoAutorizacao_Manual.Click += new System.EventHandler(this.btnCancelamentoAutorizacao_Manual_Click);
            // 
            // dtGridViewItensVenda_Manual
            // 
            this.dtGridViewItensVenda_Manual.AllowUserToAddRows = false;
            this.dtGridViewItensVenda_Manual.AllowUserToDeleteRows = false;
            this.dtGridViewItensVenda_Manual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridViewItensVenda_Manual.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column_EAN,
            this.column_QtdePrescrita,
            this.column_QtdeSolicitada,
            this.column_QtdeAutorizada,
            this.column_QtdeDevolvida,
            this.column_VlrSubsidioMS,
            this.column_VlrSubsidioPaciente,
            this.column_VlrVenda});
            this.dtGridViewItensVenda_Manual.Location = new System.Drawing.Point(8, 130);
            this.dtGridViewItensVenda_Manual.Name = "dtGridViewItensVenda_Manual";
            this.dtGridViewItensVenda_Manual.ReadOnly = true;
            this.dtGridViewItensVenda_Manual.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridViewItensVenda_Manual.Size = new System.Drawing.Size(479, 150);
            this.dtGridViewItensVenda_Manual.TabIndex = 14;
            // 
            // column_EAN
            // 
            this.column_EAN.HeaderText = "EAN";
            this.column_EAN.Name = "column_EAN";
            this.column_EAN.ReadOnly = true;
            this.column_EAN.Width = 85;
            // 
            // column_QtdePrescrita
            // 
            this.column_QtdePrescrita.HeaderText = "Qtd. Prescr.";
            this.column_QtdePrescrita.Name = "column_QtdePrescrita";
            this.column_QtdePrescrita.ReadOnly = true;
            this.column_QtdePrescrita.Width = 50;
            // 
            // column_QtdeSolicitada
            // 
            this.column_QtdeSolicitada.HeaderText = "Qtd. Solicit.";
            this.column_QtdeSolicitada.Name = "column_QtdeSolicitada";
            this.column_QtdeSolicitada.ReadOnly = true;
            this.column_QtdeSolicitada.Width = 50;
            // 
            // column_QtdeAutorizada
            // 
            this.column_QtdeAutorizada.HeaderText = "Qtd. Autoriz.";
            this.column_QtdeAutorizada.Name = "column_QtdeAutorizada";
            this.column_QtdeAutorizada.ReadOnly = true;
            this.column_QtdeAutorizada.Width = 50;
            // 
            // column_QtdeDevolvida
            // 
            this.column_QtdeDevolvida.HeaderText = "Qtd. Devolv.";
            this.column_QtdeDevolvida.Name = "column_QtdeDevolvida";
            this.column_QtdeDevolvida.ReadOnly = true;
            this.column_QtdeDevolvida.Width = 50;
            // 
            // column_VlrSubsidioMS
            // 
            this.column_VlrSubsidioMS.HeaderText = "Vlr. Parc. MS";
            this.column_VlrSubsidioMS.Name = "column_VlrSubsidioMS";
            this.column_VlrSubsidioMS.ReadOnly = true;
            this.column_VlrSubsidioMS.Width = 50;
            // 
            // column_VlrSubsidioPaciente
            // 
            this.column_VlrSubsidioPaciente.HeaderText = "Vlr. Parc. Clie.";
            this.column_VlrSubsidioPaciente.Name = "column_VlrSubsidioPaciente";
            this.column_VlrSubsidioPaciente.ReadOnly = true;
            this.column_VlrSubsidioPaciente.Width = 50;
            // 
            // column_VlrVenda
            // 
            this.column_VlrVenda.HeaderText = "Vlr. Venda";
            this.column_VlrVenda.Name = "column_VlrVenda";
            this.column_VlrVenda.ReadOnly = true;
            this.column_VlrVenda.Width = 50;
            // 
            // cmbxLojaVenda_Manual
            // 
            this.cmbxLojaVenda_Manual.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxLojaVenda_Manual.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxLojaVenda_Manual.FormattingEnabled = true;
            this.cmbxLojaVenda_Manual.Location = new System.Drawing.Point(405, 14);
            this.cmbxLojaVenda_Manual.Name = "cmbxLojaVenda_Manual";
            this.cmbxLojaVenda_Manual.Size = new System.Drawing.Size(80, 21);
            this.cmbxLojaVenda_Manual.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label6.Location = new System.Drawing.Point(320, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Loja da Venda:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label5.Location = new System.Drawing.Point(20, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Senha Funcionário:";
            // 
            // tbSenhaFuncionario_Manual
            // 
            this.tbSenhaFuncionario_Manual.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSenhaFuncionario_Manual.Location = new System.Drawing.Point(130, 65);
            this.tbSenhaFuncionario_Manual.Name = "tbSenhaFuncionario_Manual";
            this.tbSenhaFuncionario_Manual.Size = new System.Drawing.Size(163, 22);
            this.tbSenhaFuncionario_Manual.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label4.Location = new System.Drawing.Point(23, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Login Funcionário:";
            // 
            // tbCPFFuncionario_Manual
            // 
            this.tbCPFFuncionario_Manual.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCPFFuncionario_Manual.Location = new System.Drawing.Point(130, 37);
            this.tbCPFFuncionario_Manual.Name = "tbCPFFuncionario_Manual";
            this.tbCPFFuncionario_Manual.Size = new System.Drawing.Size(163, 22);
            this.tbCPFFuncionario_Manual.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label3.Location = new System.Drawing.Point(22, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nº Autorização F.P:";
            // 
            // tbNrAutorizacao_Manual
            // 
            this.tbNrAutorizacao_Manual.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNrAutorizacao_Manual.Location = new System.Drawing.Point(130, 11);
            this.tbNrAutorizacao_Manual.Name = "tbNrAutorizacao_Manual";
            this.tbNrAutorizacao_Manual.Size = new System.Drawing.Size(163, 22);
            this.tbNrAutorizacao_Manual.TabIndex = 7;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(505, 363);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estorno FP";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewItensVenda_Manual)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdBtnNrCupomFiscal_Automatico;
        private System.Windows.Forms.RadioButton rdBtnNrAutorizacao_Automatico;
        private System.Windows.Forms.DateTimePicker dtPickerDataVenda_Automatico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelarAutorizacao_Automatico;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.TextBox tbNrAutorizacaoNrCupom_Automatico;
        private System.Windows.Forms.ComboBox cmbxLojaVenda_Automatico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNrAutorizacao_Manual;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSenhaFuncionario_Manual;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCPFFuncionario_Manual;
        private System.Windows.Forms.ComboBox cmbxLojaVenda_Manual;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dtGridViewItensVenda_Manual;
        private System.Windows.Forms.Button btnCancelamentoAutorizacao_Manual;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_EAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_QtdePrescrita;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_QtdeSolicitada;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_QtdeAutorizada;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_QtdeDevolvida;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_VlrSubsidioMS;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_VlrSubsidioPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_VlrVenda;
        private System.Windows.Forms.Button btnAdicionarItem;
        private System.Windows.Forms.Button btnRemoverItem;
    }
}


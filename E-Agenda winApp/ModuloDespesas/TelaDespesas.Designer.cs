namespace E_Agenda_winApp.ModuloDespesasECategorias
{
    partial class TelaDespesas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbId = new Label();
            lbdescricao = new Label();
            lbValor = new Label();
            lbData = new Label();
            lbPagamento = new Label();
            txtId = new TextBox();
            txtDescricao = new TextBox();
            txtValor = new TextBox();
            dataInicio = new DateTimePicker();
            cbPagamento = new ComboBox();
            btnSalvar = new Button();
            btnCancelar = new Button();
            label1 = new Label();
            cbCategorias = new CheckedListBox();
            SuspendLayout();
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new Point(100, 21);
            lbId.Name = "lbId";
            lbId.Size = new Size(51, 15);
            lbId.TabIndex = 0;
            lbId.Text = "Número";
            // 
            // lbdescricao
            // 
            lbdescricao.AutoSize = true;
            lbdescricao.Location = new Point(93, 58);
            lbdescricao.Name = "lbdescricao";
            lbdescricao.Size = new Size(58, 15);
            lbdescricao.TabIndex = 1;
            lbdescricao.Text = "Descrição";
            // 
            // lbValor
            // 
            lbValor.AutoSize = true;
            lbValor.Location = new Point(118, 93);
            lbValor.Name = "lbValor";
            lbValor.Size = new Size(33, 15);
            lbValor.TabIndex = 2;
            lbValor.Text = "Valor";
            // 
            // lbData
            // 
            lbData.AutoSize = true;
            lbData.Location = new Point(120, 127);
            lbData.Name = "lbData";
            lbData.Size = new Size(31, 15);
            lbData.TabIndex = 3;
            lbData.Text = "Data";
            // 
            // lbPagamento
            // 
            lbPagamento.AutoSize = true;
            lbPagamento.Location = new Point(30, 158);
            lbPagamento.Name = "lbPagamento";
            lbPagamento.Size = new Size(121, 15);
            lbPagamento.TabIndex = 4;
            lbPagamento.Text = "Forma de Pagamento";
            // 
            // txtId
            // 
            txtId.Location = new Point(169, 18);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 5;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(169, 50);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(100, 23);
            txtDescricao.TabIndex = 6;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(169, 85);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(100, 23);
            txtValor.TabIndex = 7;
            // 
            // dataInicio
            // 
            dataInicio.CustomFormat = "HH:mm";
            dataInicio.Format = DateTimePickerFormat.Short;
            dataInicio.Location = new Point(169, 121);
            dataInicio.Name = "dataInicio";
            dataInicio.Size = new Size(100, 23);
            dataInicio.TabIndex = 8;
            // 
            // cbPagamento
            // 
            cbPagamento.FormattingEnabled = true;
            cbPagamento.Location = new Point(169, 150);
            cbPagamento.Name = "cbPagamento";
            cbPagamento.Size = new Size(121, 23);
            cbPagamento.TabIndex = 9;
            // 
            // btnSalvar
            // 
            btnSalvar.DialogResult = DialogResult.OK;
            btnSalvar.Location = new Point(287, 383);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(85, 39);
            btnSalvar.TabIndex = 11;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(387, 383);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(83, 39);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar ";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(304, 158);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 13;
            label1.Text = "Obrigatorio";
            // 
            // cbCategorias
            // 
            cbCategorias.FormattingEnabled = true;
            cbCategorias.Location = new Point(78, 192);
            cbCategorias.Name = "cbCategorias";
            cbCategorias.Size = new Size(294, 166);
            cbCategorias.TabIndex = 14;
            // 
            // TelaDespesas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 436);
            Controls.Add(cbCategorias);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(cbPagamento);
            Controls.Add(dataInicio);
            Controls.Add(txtValor);
            Controls.Add(txtDescricao);
            Controls.Add(txtId);
            Controls.Add(lbPagamento);
            Controls.Add(lbData);
            Controls.Add(lbValor);
            Controls.Add(lbdescricao);
            Controls.Add(lbId);
            Name = "TelaDespesas";
            ShowIcon = false;
            Text = "Despesas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbId;
        private Label lbdescricao;
        private Label lbValor;
        private Label lbData;
        private Label lbPagamento;
        private TextBox txtId;
        private TextBox txtDescricao;
        private TextBox txtValor;
        private DateTimePicker dataInicio;
        private ComboBox cbPagamento;
        private Button btnSalvar;
        private Button btnCancelar;
        private Label label1;
        private CheckedListBox cbCategorias;
    }
}
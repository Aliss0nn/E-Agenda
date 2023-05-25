namespace E_Agenda_winApp.ModuloTarefa
{
    partial class TelaCadastroItensForm
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
            btnAdicionar = new Button();
            txtTituloItem = new TextBox();
            label3 = new Label();
            listItens = new ListBox();
            btnCancelar = new Button();
            btnGravar = new Button();
            txtNome = new TextBox();
            label2 = new Label();
            txtId = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(434, 95);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 29;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // txtTituloItem
            // 
            txtTituloItem.Location = new Point(154, 95);
            txtTituloItem.Name = "txtTituloItem";
            txtTituloItem.Size = new Size(274, 23);
            txtTituloItem.TabIndex = 28;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(87, 99);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 27;
            label3.Text = "Descrição:";
            // 
            // listItens
            // 
            listItens.FormattingEnabled = true;
            listItens.ItemHeight = 15;
            listItens.Location = new Point(92, 134);
            listItens.Name = "listItens";
            listItens.Size = new Size(417, 184);
            listItens.TabIndex = 26;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(434, 334);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 41);
            btnCancelar.TabIndex = 25;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(353, 334);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 41);
            btnGravar.TabIndex = 24;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(154, 61);
            txtNome.Name = "txtNome";
            txtNome.ReadOnly = true;
            txtNome.Size = new Size(355, 23);
            txtNome.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(108, 65);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 22;
            label2.Text = "Nome";
            // 
            // txtId
            // 
            txtId.Location = new Point(154, 28);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(60, 23);
            txtId.TabIndex = 21;
            txtId.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(128, 32);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 20;
            label1.Text = "Id:";
            // 
            // TelaCadastroItensForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(872, 515);
            Controls.Add(btnAdicionar);
            Controls.Add(txtTituloItem);
            Controls.Add(label3);
            Controls.Add(listItens);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Name = "TelaCadastroItensForm";
            ShowIcon = false;
            Text = "Cadastrar Itens";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdicionar;
        private TextBox txtTituloItem;
        private Label label3;
        private ListBox listItens;
        private Button btnCancelar;
        private Button btnGravar;
        private TextBox txtNome;
        private Label label2;
        private TextBox txtId;
        private Label label1;
    }
}
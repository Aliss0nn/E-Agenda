namespace E_Agenda_winApp.ModuloContato
{
    partial class TelaContatoForm
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
            btnCancelar = new Button();
            btnSalvar = new Button();
            label1 = new Label();
            txtId = new TextBox();
            label2 = new Label();
            txtNome = new TextBox();
            label3 = new Label();
            txtTelefone = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtEmail = new TextBox();
            txtEmpresa = new TextBox();
            txtCargo = new TextBox();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(362, 283);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(82, 35);
            btnCancelar.TabIndex = 0;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalvar.DialogResult = DialogResult.OK;
            btnSalvar.Location = new Point(270, 283);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(86, 35);
            btnSalvar.TabIndex = 1;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 12);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 2;
            label1.Text = "Id";
            // 
            // txtId
            // 
            txtId.Location = new Point(61, 9);
            txtId.Name = "txtId";
            txtId.Size = new Size(77, 23);
            txtId.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 43);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 4;
            label2.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(61, 35);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(383, 23);
            txtNome.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 72);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 6;
            label3.Text = "Telefone";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(61, 64);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(143, 23);
            txtTelefone.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(219, 72);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 8;
            label4.Text = "E-mail";           
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(5, 100);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 9;
            label5.Text = "Empresa";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(270, 101);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 10;
            label6.Text = "Cargo";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(266, 64);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(178, 23);
            txtEmail.TabIndex = 11;
            // 
            // txtEmpresa
            // 
            txtEmpresa.Location = new Point(61, 93);
            txtEmpresa.Name = "txtEmpresa";
            txtEmpresa.Size = new Size(199, 23);
            txtEmpresa.TabIndex = 12;
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(315, 93);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(129, 23);
            txtCargo.TabIndex = 13;
            // 
            // TelaContatoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 330);
            Controls.Add(txtCargo);
            Controls.Add(txtEmpresa);
            Controls.Add(txtEmail);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtTelefone);
            Controls.Add(label3);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Controls.Add(btnSalvar);
            Controls.Add(btnCancelar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaContatoForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Contatos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnSalvar;
        private Label label1;
        private TextBox txtId;
        private Label label2;
        private TextBox txtNome;
        private Label label3;
        private TextBox txtTelefone;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtEmail;
        private TextBox txtEmpresa;
        private TextBox txtCargo;
    }
}
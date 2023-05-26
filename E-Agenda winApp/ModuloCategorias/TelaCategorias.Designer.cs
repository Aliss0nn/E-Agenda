namespace E_Agenda_winApp.ModuloDespesasECategorias
{
    partial class TelaCategorias
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
            lbtitulo = new Label();
            txtTitulo = new TextBox();
            txtId = new TextBox();
            bntSalvar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new Point(54, 33);
            lbId.Name = "lbId";
            lbId.Size = new Size(51, 15);
            lbId.TabIndex = 0;
            lbId.Text = "Número";
            // 
            // lbtitulo
            // 
            lbtitulo.AutoSize = true;
            lbtitulo.Location = new Point(68, 78);
            lbtitulo.Name = "lbtitulo";
            lbtitulo.Size = new Size(37, 15);
            lbtitulo.TabIndex = 1;
            lbtitulo.Text = "Título";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(130, 70);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(100, 23);
            txtTitulo.TabIndex = 2;
            // 
            // txtId
            // 
            txtId.Location = new Point(130, 25);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 3;
            // 
            // bntSalvar
            // 
            bntSalvar.DialogResult = DialogResult.OK;
            bntSalvar.Location = new Point(197, 157);
            bntSalvar.Name = "bntSalvar";
            bntSalvar.Size = new Size(95, 34);
            bntSalvar.TabIndex = 4;
            bntSalvar.Text = "Salvar";
            bntSalvar.UseVisualStyleBackColor = true;
            bntSalvar.Click += bntSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(298, 157);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(90, 34);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // TelaCategorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 236);
            Controls.Add(btnCancelar);
            Controls.Add(bntSalvar);
            Controls.Add(txtId);
            Controls.Add(txtTitulo);
            Controls.Add(lbtitulo);
            Controls.Add(lbId);
            Name = "TelaCategorias";
            ShowIcon = false;
            Text = "Cadastro de Categorias";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbId;
        private Label lbtitulo;
        private TextBox txtTitulo;
        private TextBox txtId;
        private Button bntSalvar;
        private Button btnCancelar;
    }
}
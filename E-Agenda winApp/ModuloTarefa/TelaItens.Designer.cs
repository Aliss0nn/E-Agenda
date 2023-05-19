namespace E_Agenda_winApp.ModuloTarefa
{
    partial class TelaItens
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
            label1 = new Label();
            label2 = new Label();
            txtDescricao = new TextBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            lbListaItens = new ListBox();
            btnSalvar = new Button();
            btnCancelar = new Button();
            pnControls = new Panel();
            pnControls.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(244, 21);
            label1.Name = "label1";
            label1.Size = new Size(256, 37);
            label1.TabIndex = 0;
            label1.Text = "Adicionando Itens";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(31, 121);
            label2.Name = "label2";
            label2.Size = new Size(101, 28);
            label2.TabIndex = 1;
            label2.Text = "Descrição ";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(138, 129);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(387, 23);
            txtDescricao.TabIndex = 2;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton1.Location = new Point(16, 14);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(91, 23);
            radioButton1.TabIndex = 3;
            radioButton1.TabStop = true;
            radioButton1.Text = "Concluída ";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton2.Location = new Point(16, 43);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(116, 23);
            radioButton2.TabIndex = 4;
            radioButton2.TabStop = true;
            radioButton2.Text = "Não Concluída";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // lbListaItens
            // 
            lbListaItens.FormattingEnabled = true;
            lbListaItens.ItemHeight = 15;
            lbListaItens.Location = new Point(138, 253);
            lbListaItens.Name = "lbListaItens";
            lbListaItens.SelectionMode = SelectionMode.MultiSimple;
            lbListaItens.Size = new Size(323, 94);
            lbListaItens.TabIndex = 5;
            // 
            // btnSalvar
            // 
            btnSalvar.DialogResult = DialogResult.OK;
            btnSalvar.Location = new Point(300, 362);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(95, 45);
            btnSalvar.TabIndex = 6;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(430, 362);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(95, 45);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // pnControls
            // 
            pnControls.Controls.Add(radioButton1);
            pnControls.Controls.Add(radioButton2);
            pnControls.Location = new Point(138, 168);
            pnControls.Name = "pnControls";
            pnControls.Size = new Size(150, 79);
            pnControls.TabIndex = 8;
            // 
            // TelaItens
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 447);
            Controls.Add(pnControls);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(lbListaItens);
            Controls.Add(txtDescricao);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaItens";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Adicionar Itens";
            pnControls.ResumeLayout(false);
            pnControls.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtDescricao;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private ListBox lbListaItens;
        private Button btnSalvar;
        private Button btnCancelar;
        private Panel pnControls;
    }
}
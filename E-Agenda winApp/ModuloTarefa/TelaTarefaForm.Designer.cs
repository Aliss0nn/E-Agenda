namespace E_Agenda_winApp.ModuloTarefa
{
    partial class TelaTarefa
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
            txtIdTarefa = new Label();
            txtId = new TextBox();
            txtNomeDaTarefa = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dtInicio = new DateTimePicker();
            dtFinal = new DateTimePicker();
            lbInicio = new Label();
            lbFinal = new Label();
            cmbPrioridade = new ComboBox();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(509, 271);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(82, 35);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalvar.DialogResult = DialogResult.OK;
            btnSalvar.Location = new Point(404, 271);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(86, 35);
            btnSalvar.TabIndex = 2;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txtIdTarefa
            // 
            txtIdTarefa.AutoSize = true;
            txtIdTarefa.Location = new Point(76, 17);
            txtIdTarefa.Name = "txtIdTarefa";
            txtIdTarefa.Size = new Size(17, 15);
            txtIdTarefa.TabIndex = 3;
            txtIdTarefa.Text = "Id";
            // 
            // txtId
            // 
            txtId.Location = new Point(108, 9);
            txtId.Name = "txtId";
            txtId.Size = new Size(38, 23);
            txtId.TabIndex = 4;
            // 
            // txtNomeDaTarefa
            // 
            txtNomeDaTarefa.Location = new Point(108, 38);
            txtNomeDaTarefa.Name = "txtNomeDaTarefa";
            txtNomeDaTarefa.Size = new Size(369, 23);
            txtNomeDaTarefa.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 46);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 7;
            label2.Text = "Nome da Tarefa";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 78);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 8;
            label1.Text = "Prioridade";
            // 
            // dtInicio
            // 
            dtInicio.Location = new Point(56, 170);
            dtInicio.Name = "dtInicio";
            dtInicio.Size = new Size(254, 23);
            dtInicio.TabIndex = 10;
            // 
            // dtFinal
            // 
            dtFinal.Location = new Point(341, 170);
            dtFinal.Name = "dtFinal";
            dtFinal.Size = new Size(261, 23);
            dtFinal.TabIndex = 11;
            // 
            // lbInicio
            // 
            lbInicio.AutoSize = true;
            lbInicio.Location = new Point(108, 131);
            lbInicio.Name = "lbInicio";
            lbInicio.Size = new Size(86, 15);
            lbInicio.TabIndex = 12;
            lbInicio.Text = "Inicio da Tarefa";
            // 
            // lbFinal
            // 
            lbFinal.AutoSize = true;
            lbFinal.Location = new Point(395, 131);
            lbFinal.Name = "lbFinal";
            lbFinal.Size = new Size(82, 15);
            lbFinal.TabIndex = 13;
            lbFinal.Text = "Final da Tarefa";
            // 
            // cmbPrioridade
            // 
            cmbPrioridade.FormattingEnabled = true;
            cmbPrioridade.Location = new Point(108, 75);
            cmbPrioridade.Name = "cmbPrioridade";
            cmbPrioridade.Size = new Size(121, 23);
            cmbPrioridade.TabIndex = 14;
            // 
            // TelaTarefa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(626, 329);
            Controls.Add(cmbPrioridade);
            Controls.Add(lbFinal);
            Controls.Add(lbInicio);
            Controls.Add(dtFinal);
            Controls.Add(dtInicio);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(txtNomeDaTarefa);
            Controls.Add(txtId);
            Controls.Add(txtIdTarefa);
            Controls.Add(btnSalvar);
            Controls.Add(btnCancelar);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaTarefa";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tarefas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnSalvar;
        private Label txtIdTarefa;
        private TextBox txtId;
        private TextBox txtNomeDaTarefa;
        private Label label2;
        private Label label1;
        private DateTimePicker dtInicio;
        private DateTimePicker dtFinal;
        private Label lbInicio;
        private Label lbFinal;
        private ComboBox cmbPrioridade;
    }
}
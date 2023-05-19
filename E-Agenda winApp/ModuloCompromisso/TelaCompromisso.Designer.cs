namespace E_Agenda_winApp.ModuloCompromisso
{
    partial class TelaCompromisso
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
            txtId = new TextBox();
            txtAssunto = new TextBox();
            label3 = new Label();
            checkBox1 = new CheckBox();
            CbContatos = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            rdBtnRemoto = new RadioButton();
            rdBtnPresencial = new RadioButton();
            txtRemoto = new TextBox();
            txtPresencial = new TextBox();
            btnSalvarCompromisso = new Button();
            btnCancelar = new Button();
            txtLocal = new TextBox();
            label6 = new Label();
            dateTimeData = new DateTimePicker();
            dateTimeInicial = new DateTimePicker();
            dateTimeFinal = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(53, 32);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(21, 63);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 1;
            label2.Text = "Assunto";
            // 
            // txtId
            // 
            txtId.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtId.Location = new Point(83, 24);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 2;
            // 
            // txtAssunto
            // 
            txtAssunto.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtAssunto.Location = new Point(83, 60);
            txtAssunto.Name = "txtAssunto";
            txtAssunto.Size = new Size(311, 23);
            txtAssunto.TabIndex = 3;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(40, 103);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 4;
            label3.Text = "Data";
            // 
            // checkBox1
            // 
            checkBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(90, 188);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(277, 19);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Deseja marcar um contato neste compromisso?";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // CbContatos
            // 
            CbContatos.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            CbContatos.FormattingEnabled = true;
            CbContatos.Location = new Point(90, 213);
            CbContatos.Name = "CbContatos";
            CbContatos.Size = new Size(121, 23);
            CbContatos.TabIndex = 7;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(35, 146);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 9;
            label4.Text = "Inicio";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(237, 146);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 10;
            label5.Text = "Término";
            // 
            // rdBtnRemoto
            // 
            rdBtnRemoto.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            rdBtnRemoto.AutoSize = true;
            rdBtnRemoto.Location = new Point(42, 291);
            rdBtnRemoto.Name = "rdBtnRemoto";
            rdBtnRemoto.Size = new Size(67, 19);
            rdBtnRemoto.TabIndex = 12;
            rdBtnRemoto.TabStop = true;
            rdBtnRemoto.Text = "Remoto";
            rdBtnRemoto.UseVisualStyleBackColor = true;
            // 
            // rdBtnPresencial
            // 
            rdBtnPresencial.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            rdBtnPresencial.AutoSize = true;
            rdBtnPresencial.Location = new Point(40, 316);
            rdBtnPresencial.Name = "rdBtnPresencial";
            rdBtnPresencial.Size = new Size(78, 19);
            rdBtnPresencial.TabIndex = 13;
            rdBtnPresencial.TabStop = true;
            rdBtnPresencial.Text = "Presencial";
            rdBtnPresencial.UseVisualStyleBackColor = true;
            // 
            // txtRemoto
            // 
            txtRemoto.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtRemoto.Location = new Point(144, 283);
            txtRemoto.Name = "txtRemoto";
            txtRemoto.Size = new Size(169, 23);
            txtRemoto.TabIndex = 14;
            // 
            // txtPresencial
            // 
            txtPresencial.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtPresencial.Location = new Point(144, 312);
            txtPresencial.Name = "txtPresencial";
            txtPresencial.Size = new Size(169, 23);
            txtPresencial.TabIndex = 15;
            // 
            // btnSalvarCompromisso
            // 
            btnSalvarCompromisso.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalvarCompromisso.DialogResult = DialogResult.OK;
            btnSalvarCompromisso.Location = new Point(329, 365);
            btnSalvarCompromisso.Name = "btnSalvarCompromisso";
            btnSalvarCompromisso.Size = new Size(75, 32);
            btnSalvarCompromisso.TabIndex = 16;
            btnSalvarCompromisso.Text = "Salvar";
            btnSalvarCompromisso.UseVisualStyleBackColor = true;
            btnSalvarCompromisso.Click += btnSalvarCompromisso_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(410, 365);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 32);
            btnCancelar.TabIndex = 17;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtLocal
            // 
            txtLocal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtLocal.Location = new Point(144, 253);
            txtLocal.Name = "txtLocal";
            txtLocal.Size = new Size(169, 23);
            txtLocal.TabIndex = 21;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(74, 261);
            label6.Name = "label6";
            label6.Size = new Size(35, 15);
            label6.TabIndex = 22;
            label6.Text = "Local";
            // 
            // dateTimeData
            // 
            dateTimeData.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            dateTimeData.Location = new Point(83, 97);
            dateTimeData.Name = "dateTimeData";
            dateTimeData.Size = new Size(245, 23);
            dateTimeData.TabIndex = 23;
            // 
            // dateTimeInicial
            // 
            dateTimeInicial.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            dateTimeInicial.CustomFormat = "hh:mm";
            dateTimeInicial.Location = new Point(74, 140);
            dateTimeInicial.Name = "dateTimeInicial";
            dateTimeInicial.Size = new Size(133, 23);
            dateTimeInicial.TabIndex = 24;
            // 
            // dateTimeFinal
            // 
            dateTimeFinal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            dateTimeFinal.CustomFormat = "HH:mm";
            dateTimeFinal.Location = new Point(302, 140);
            dateTimeFinal.Name = "dateTimeFinal";
            dateTimeFinal.Size = new Size(118, 23);
            dateTimeFinal.TabIndex = 25;
            // 
            // TelaCompromisso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 409);
            Controls.Add(dateTimeFinal);
            Controls.Add(dateTimeInicial);
            Controls.Add(dateTimeData);
            Controls.Add(label6);
            Controls.Add(txtLocal);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvarCompromisso);
            Controls.Add(txtPresencial);
            Controls.Add(txtRemoto);
            Controls.Add(rdBtnPresencial);
            Controls.Add(rdBtnRemoto);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(CbContatos);
            Controls.Add(checkBox1);
            Controls.Add(label3);
            Controls.Add(txtAssunto);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaCompromisso";
            ShowIcon = false;
            Text = "TelaCompromisso";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtId;
        private TextBox txtAssunto;
        private Label label3;
        private CheckBox checkBox1;
        private ComboBox CbContatos;
        private Label label4;
        private Label label5;
        private RadioButton rdBtnRemoto;
        private RadioButton rdBtnPresencial;
        private TextBox txtRemoto;
        private TextBox txtPresencial;
        private Button btnSalvarCompromisso;
        private Button btnCancelar;
        private TextBox txtLocal;
        private Label label6;
        private DateTimePicker dateTimeData;
        private DateTimePicker dateTimeInicial;
        private DateTimePicker dateTimeFinal;
    }
}
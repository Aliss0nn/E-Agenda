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
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            txtRemoto = new TextBox();
            txtPresencial = new TextBox();
            btnSalvar = new Button();
            btnCancelar = new Button();
            txtData = new TextBox();
            txtInicio = new TextBox();
            txtFinal = new TextBox();
            txtLocal = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 45);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 76);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 1;
            label2.Text = "Assunto";
            // 
            // txtId
            // 
            txtId.Location = new Point(78, 37);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 2;
            // 
            // txtAssunto
            // 
            txtAssunto.Location = new Point(78, 73);
            txtAssunto.Name = "txtAssunto";
            txtAssunto.Size = new Size(311, 23);
            txtAssunto.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 116);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 4;
            label3.Text = "Data";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(78, 201);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(284, 19);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Deseja marcar um contanto neste compromisso?";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // CbContatos
            // 
            CbContatos.FormattingEnabled = true;
            CbContatos.Location = new Point(78, 226);
            CbContatos.Name = "CbContatos";
            CbContatos.Size = new Size(121, 23);
            CbContatos.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 159);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 9;
            label4.Text = "Inicio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(242, 159);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 10;
            label5.Text = "Término";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(46, 300);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(67, 19);
            radioButton1.TabIndex = 12;
            radioButton1.TabStop = true;
            radioButton1.Text = "Remoto";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(35, 329);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(78, 19);
            radioButton2.TabIndex = 13;
            radioButton2.TabStop = true;
            radioButton2.Text = "Presencial";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // txtRemoto
            // 
            txtRemoto.Location = new Point(139, 296);
            txtRemoto.Name = "txtRemoto";
            txtRemoto.Size = new Size(169, 23);
            txtRemoto.TabIndex = 14;
            // 
            // txtPresencial
            // 
            txtPresencial.Location = new Point(139, 325);
            txtPresencial.Name = "txtPresencial";
            txtPresencial.Size = new Size(169, 23);
            txtPresencial.TabIndex = 15;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(314, 375);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 32);
            btnSalvar.TabIndex = 16;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(395, 375);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 32);
            btnCancelar.TabIndex = 17;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtData
            // 
            txtData.Location = new Point(78, 113);
            txtData.Name = "txtData";
            txtData.Size = new Size(311, 23);
            txtData.TabIndex = 18;
            // 
            // txtInicio
            // 
            txtInicio.Location = new Point(79, 151);
            txtInicio.Name = "txtInicio";
            txtInicio.Size = new Size(145, 23);
            txtInicio.TabIndex = 19;
            // 
            // txtFinal
            // 
            txtFinal.Location = new Point(301, 151);
            txtFinal.Name = "txtFinal";
            txtFinal.Size = new Size(140, 23);
            txtFinal.TabIndex = 20;
            // 
            // txtLocal
            // 
            txtLocal.Location = new Point(139, 267);
            txtLocal.Name = "txtLocal";
            txtLocal.Size = new Size(169, 23);
            txtLocal.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(69, 275);
            label6.Name = "label6";
            label6.Size = new Size(35, 15);
            label6.TabIndex = 22;
            label6.Text = "Local";
            // 
            // TelaCompromisso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 419);
            Controls.Add(label6);
            Controls.Add(txtLocal);
            Controls.Add(txtFinal);
            Controls.Add(txtInicio);
            Controls.Add(txtData);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(txtPresencial);
            Controls.Add(txtRemoto);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
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
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private TextBox txtRemoto;
        private TextBox txtPresencial;
        private Button btnSalvar;
        private Button btnCancelar;
        private TextBox txtData;
        private TextBox txtInicio;
        private TextBox txtFinal;
        private TextBox txtLocal;
        private Label label6;
    }
}
namespace E_Agenda_winApp.ModuloCompromisso
{
    partial class TelaFiltradorForm
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
            lbInicio = new Label();
            lblFinal = new Label();
            dateTimeInicio = new DateTimePicker();
            dateTimeFinal = new DateTimePicker();
            btnFiltrar = new Button();
            btnCancelar = new Button();
            rdbTodos = new RadioButton();
            rdbPassado = new RadioButton();
            rdbFuturos = new RadioButton();
            SuspendLayout();
            // 
            // lbInicio
            // 
            lbInicio.AutoSize = true;
            lbInicio.Location = new Point(56, 162);
            lbInicio.Name = "lbInicio";
            lbInicio.Size = new Size(79, 15);
            lbInicio.TabIndex = 0;
            lbInicio.Text = "Data de Inicio";
            // 
            // lblFinal
            // 
            lblFinal.AutoSize = true;
            lblFinal.Location = new Point(330, 162);
            lblFinal.Name = "lblFinal";
            lblFinal.Size = new Size(59, 15);
            lblFinal.TabIndex = 1;
            lblFinal.Text = "Data Final";
            // 
            // dateTimeInicio
            // 
            dateTimeInicio.Anchor = AnchorStyles.None;
            dateTimeInicio.Location = new Point(56, 199);
            dateTimeInicio.Name = "dateTimeInicio";
            dateTimeInicio.Size = new Size(250, 23);
            dateTimeInicio.TabIndex = 2;
            // 
            // dateTimeFinal
            // 
            dateTimeFinal.Anchor = AnchorStyles.None;
            dateTimeFinal.Location = new Point(330, 199);
            dateTimeFinal.Name = "dateTimeFinal";
            dateTimeFinal.Size = new Size(260, 23);
            dateTimeFinal.TabIndex = 3;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Anchor = AnchorStyles.None;
            btnFiltrar.DialogResult = DialogResult.OK;
            btnFiltrar.Location = new Point(175, 241);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(118, 38);
            btnFiltrar.TabIndex = 4;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;            
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.None;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(330, 241);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(114, 38);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // rdbTodos
            // 
            rdbTodos.AutoSize = true;
            rdbTodos.Location = new Point(56, 35);
            rdbTodos.Name = "rdbTodos";
            rdbTodos.Size = new Size(206, 19);
            rdbTodos.TabIndex = 6;
            rdbTodos.TabStop = true;
            rdbTodos.Text = "Visualizar Todos os Compromissos";
            rdbTodos.UseVisualStyleBackColor = true;
            // 
            // rdbPassado
            // 
            rdbPassado.AutoSize = true;
            rdbPassado.Location = new Point(56, 76);
            rdbPassado.Name = "rdbPassado";
            rdbPassado.Size = new Size(273, 19);
            rdbPassado.TabIndex = 7;
            rdbPassado.TabStop = true;
            rdbPassado.Text = "Visualizar Somente os Compromissos Passados";
            rdbPassado.UseVisualStyleBackColor = true;
            // 
            // rdbFuturos
            // 
            rdbFuturos.AutoSize = true;
            rdbFuturos.Location = new Point(56, 114);
            rdbFuturos.Name = "rdbFuturos";
            rdbFuturos.Size = new Size(265, 19);
            rdbFuturos.TabIndex = 8;
            rdbFuturos.TabStop = true;
            rdbFuturos.Text = "Visualizar Somente os Compromissos Futuros";
            rdbFuturos.UseVisualStyleBackColor = true;
            // 
            // TelaFiltradorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(614, 352);
            Controls.Add(rdbFuturos);
            Controls.Add(rdbPassado);
            Controls.Add(rdbTodos);
            Controls.Add(btnCancelar);
            Controls.Add(btnFiltrar);
            Controls.Add(dateTimeFinal);
            Controls.Add(dateTimeInicio);
            Controls.Add(lblFinal);
            Controls.Add(lbInicio);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaFiltradorForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Filtrar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbInicio;
        private Label lblFinal;
        private DateTimePicker dateTimeInicio;
        private DateTimePicker dateTimeFinal;
        private Button btnFiltrar;
        private Button btnCancelar;
        private RadioButton rdbTodos;
        private RadioButton rdbPassado;
        private RadioButton rdbFuturos;
    }
}
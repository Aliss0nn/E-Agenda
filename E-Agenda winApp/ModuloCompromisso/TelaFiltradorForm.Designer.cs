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
            SuspendLayout();
            // 
            // lbInicio
            // 
            lbInicio.AutoSize = true;
            lbInicio.Location = new Point(164, 42);
            lbInicio.Name = "lbInicio";
            lbInicio.Size = new Size(36, 15);
            lbInicio.TabIndex = 0;
            lbInicio.Text = "Inicio";
            // 
            // lblFinal
            // 
            lblFinal.AutoSize = true;
            lblFinal.Location = new Point(462, 42);
            lblFinal.Name = "lblFinal";
            lblFinal.Size = new Size(32, 15);
            lblFinal.TabIndex = 1;
            lblFinal.Text = "Final";
            // 
            // dateTimeInicio
            // 
            dateTimeInicio.Location = new Point(65, 78);
            dateTimeInicio.Name = "dateTimeInicio";
            dateTimeInicio.Size = new Size(250, 23);
            dateTimeInicio.TabIndex = 2;
            // 
            // dateTimeFinal
            // 
            dateTimeFinal.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dateTimeFinal.Location = new Point(360, 78);
            dateTimeFinal.Name = "dateTimeFinal";
            dateTimeFinal.Size = new Size(255, 23);
            dateTimeFinal.TabIndex = 3;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnFiltrar.DialogResult = DialogResult.OK;
            btnFiltrar.Location = new Point(223, 156);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(86, 38);
            btnFiltrar.TabIndex = 4;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(340, 156);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(95, 38);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // TelaFiltradorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(659, 235);
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
    }
}
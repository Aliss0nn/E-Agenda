namespace E_Agenda_winApp.ModuloDespesasECategorias
{
    partial class TabelaDespesaControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gridDespesa = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gridDespesa).BeginInit();
            SuspendLayout();
            // 
            // gridDespesa
            // 
            gridDespesa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridDespesa.Dock = DockStyle.Fill;
            gridDespesa.Location = new Point(0, 0);
            gridDespesa.Name = "gridDespesa";
            gridDespesa.RowTemplate.Height = 25;
            gridDespesa.Size = new Size(494, 381);
            gridDespesa.TabIndex = 0;
            // 
            // TabelaDespesaControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gridDespesa);
            Name = "TabelaDespesaControl";
            Size = new Size(494, 381);
            ((System.ComponentModel.ISupportInitialize)gridDespesa).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gridDespesa;
    }
}

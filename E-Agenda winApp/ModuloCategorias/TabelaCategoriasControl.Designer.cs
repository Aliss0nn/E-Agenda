﻿namespace E_Agenda_winApp.ModuloCategorias
{
    partial class TabelaCategoriasControl
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
            gridCategoria = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gridCategoria).BeginInit();
            SuspendLayout();
            // 
            // gridCategoria
            // 
            gridCategoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridCategoria.Dock = DockStyle.Fill;
            gridCategoria.Location = new Point(0, 0);
            gridCategoria.Name = "gridCategoria";
            gridCategoria.RowTemplate.Height = 25;
            gridCategoria.Size = new Size(567, 398);
            gridCategoria.TabIndex = 0;
            // 
            // TabelaCategoriasControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gridCategoria);
            Name = "TabelaCategoriasControl";
            Size = new Size(567, 398);
            ((System.ComponentModel.ISupportInitialize)gridCategoria).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gridCategoria;
    }
}

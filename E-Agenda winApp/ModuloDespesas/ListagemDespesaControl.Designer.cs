namespace E_Agenda_winApp.ModuloDespesasECategorias
{
    partial class ListagemDespesaControl
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
            listaDespesas = new ListBox();
            SuspendLayout();
            // 
            // listaDespesas
            // 
            listaDespesas.Dock = DockStyle.Fill;
            listaDespesas.FormattingEnabled = true;
            listaDespesas.ItemHeight = 15;
            listaDespesas.Location = new Point(0, 0);
            listaDespesas.Name = "listaDespesas";
            listaDespesas.Size = new Size(485, 385);
            listaDespesas.TabIndex = 0;
            // 
            // ListagemDespesaControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listaDespesas);
            Name = "ListagemDespesaControl";
            Size = new Size(485, 385);
            ResumeLayout(false);
        }

        #endregion

        private ListBox listaDespesas;
    }
}

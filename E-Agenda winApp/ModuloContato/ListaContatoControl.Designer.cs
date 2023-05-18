namespace E_Agenda_winApp.ModuloContato
{
    partial class ListagemDeContatoControl
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
            listDeContato = new ListBox();
            SuspendLayout();
            // 
            // listDeContato
            // 
            listDeContato.Dock = DockStyle.Fill;
            listDeContato.FormattingEnabled = true;
            listDeContato.ItemHeight = 15;
            listDeContato.Location = new Point(0, 0);
            listDeContato.Name = "listDeContato";
            listDeContato.Size = new Size(711, 315);
            listDeContato.TabIndex = 0;
            // 
            // ListagemDeContatoControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listDeContato);
            Name = "ListagemDeContatoControl";
            Size = new Size(711, 315);
            ResumeLayout(false);
        }

        #endregion

        private ListBox listDeContato;
    }
}

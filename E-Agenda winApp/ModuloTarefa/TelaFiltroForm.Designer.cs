﻿namespace E_Agenda_winApp.ModuloTarefa
{
    partial class TelaFiltroForm
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
            rdbConcluidas = new RadioButton();
            rdbPendentes = new RadioButton();
            rdbTodos = new RadioButton();
            btnCancelar = new Button();
            btnFiltrar = new Button();
            SuspendLayout();
            // 
            // rdbConcluidas
            // 
            rdbConcluidas.AutoSize = true;
            rdbConcluidas.Location = new Point(36, 103);
            rdbConcluidas.Name = "rdbConcluidas";
            rdbConcluidas.Size = new Size(175, 19);
            rdbConcluidas.TabIndex = 9;
            rdbConcluidas.TabStop = true;
            rdbConcluidas.Text = "Visualizar Tarefas Concluídas";
            rdbConcluidas.UseVisualStyleBackColor = true;
            // 
            // rdbPendentes
            // 
            rdbPendentes.AutoSize = true;
            rdbPendentes.Location = new Point(36, 66);
            rdbPendentes.Name = "rdbPendentes";
            rdbPendentes.Size = new Size(171, 19);
            rdbPendentes.TabIndex = 8;
            rdbPendentes.TabStop = true;
            rdbPendentes.Text = "Visualizar Tarefas Pendentes";
            rdbPendentes.UseVisualStyleBackColor = true;
            // 
            // rdbTodos
            // 
            rdbTodos.AutoSize = true;
            rdbTodos.Location = new Point(36, 28);
            rdbTodos.Name = "rdbTodos";
            rdbTodos.Size = new Size(160, 19);
            rdbTodos.TabIndex = 7;
            rdbTodos.TabStop = true;
            rdbTodos.Text = "Visualizar Todas as Tarefas";
            rdbTodos.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(222, 182);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 50);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnFiltrar
            // 
            btnFiltrar.DialogResult = DialogResult.OK;
            btnFiltrar.Location = new Point(141, 182);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(75, 50);
            btnFiltrar.TabIndex = 5;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            // 
            // TelaFiltroForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 261);
            Controls.Add(rdbConcluidas);
            Controls.Add(rdbPendentes);
            Controls.Add(rdbTodos);
            Controls.Add(btnCancelar);
            Controls.Add(btnFiltrar);
            HelpButton = true;
            Name = "TelaFiltroForm";
            ShowIcon = false;
            Text = "Filtrar Tarefas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rdbConcluidas;
        private RadioButton rdbPendentes;
        private RadioButton rdbTodos;
        private Button btnCancelar;
        private Button btnFiltrar;
    }
}
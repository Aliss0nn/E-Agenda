using E_Agenda_winApp.Compartilhado;
using E_Agenda_winApp.ModuloTarefa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Agenda_winApp.ModuloContato
{
    public partial class TabelaContatoControl : UserControl
    {
        public TabelaContatoControl()
        {
            InitializeComponent();
            
            ConfigurarColunas();

            gridContato.ConfigurarGridZebrado();

            gridContato.ConfigurarGridSomenteLeitura();
        }
        private void ConfigurarColunas()
        {
            DataGridViewColumn[] colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn()
                {
                    Name = "id",
                    HeaderText = "Id"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "nome",
                    HeaderText = "Nome"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "cargo",
                    HeaderText = "Cargo"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "email",
                    HeaderText = "Email"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "Empresa",
                    HeaderText = "Empresa"
                },
                new DataGridViewTextBoxColumn()
                {
                     Name = "telefone",
                    HeaderText = "Telefone"
                }
                
            };

            gridContato.Columns.AddRange(colunas);
        }
        public int ObterIdSelecionado()
        {
            int id;

            try
            {
                id = Convert.ToInt32(gridContato.SelectedRows[0].Cells["id"].Value);
            }
            catch
            {
                id = -1;
            }

            return id;
        }
        public void AtualizarRegistros(List<Contato> contatos)
        {
            gridContato.Rows.Clear();
            
            foreach (Contato contato in contatos)
            {
                gridContato.Rows.Add(contato.id, contato.nome, contato.cargo, contato.email, contato.empresa,contato.telefone);
            }
        }
    }
}

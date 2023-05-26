using E_Agenda_winApp.Compartilhado;
using E_Agenda_winApp.ModuloDespesasECategorias;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Agenda_winApp.ModuloCategorias
{
    public partial class TabelaCategoriasControl : UserControl
    {
        public TabelaCategoriasControl()
        {
            InitializeComponent();

            ConfigurarColunas();

            gridCategorias.ConfigurarGridSomenteLeitura();

            gridCategorias.ConfigurarGridZebrado();
        }
        public void AtualizarRegistros(List<Categorias> categorias)
        {
            gridCategorias.Rows.Clear();

            foreach (Categorias categoria in categorias)
            {
                gridCategorias.Rows.Add(categoria.id, categoria.titulo);
            }
        }
        private void ConfigurarColunas()
        {
            DataGridViewColumn[] colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn()
                {
                    Name = "id",
                    HeaderText = "Número"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "titulo",
                    HeaderText = "Título"
                },             
            };

            gridCategorias.Columns.AddRange(colunas);
        }

        public int ObterIdSelecionado()
        {
            int id;

            try
            {
                id = Convert.ToInt32(gridCategorias.SelectedRows[0].Cells["id"].Value);
            }
            catch
            {
                id = -1;
            }

            return id;
        }
    }
}

using E_Agenda_winApp.Compartilhado;

namespace E_Agenda_winApp.ModuloTarefa
{
    public partial class TabelaTarefaControl : UserControl
    {
        public TabelaTarefaControl()
        {
            InitializeComponent();

            ConfigurarColunas();
            
            gridTarefas.ConfigurarGridSomenteLeitura();

            gridTarefas.ConfigurarGridZebrado();
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
                    Name = "titulo",
                    HeaderText = "Título"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "prioridade",
                    HeaderText = "Prioridade"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "percentualConcluido",
                    HeaderText = "% Concluído"
                }
            };

            gridTarefas.Columns.AddRange(colunas);
        }

        public void AtualizarRegistros(List<Tarefa> tarefas)
        {
            gridTarefas.Rows.Clear();
            
            foreach (Tarefa tarefa in tarefas)
            {
                gridTarefas.Rows.Add(tarefa.id, tarefa.nome, tarefa.prioridade, tarefa.percentualConcluido);
            }
        }

        public int ObterIdSelecionado()
        {
            int id;

            try
            {
                id = Convert.ToInt32(gridTarefas.SelectedRows[0].Cells["id"].Value);
            }
            catch
            {
                id = -1;
            }

            return id;
        }
    }
}

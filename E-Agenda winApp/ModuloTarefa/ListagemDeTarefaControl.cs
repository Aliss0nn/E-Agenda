namespace E_Agenda_winApp.ModuloTarefa
{
    public partial class ListagemDeTarefaControl : UserControl
    {            
        public ListagemDeTarefaControl()
        {
            InitializeComponent();
       
        }

        public void AtualizarRegistros(List<Tarefa> tarefas)
        {
            listTarefas.Items.Clear();

            foreach (Tarefa item in tarefas)
            {
                listTarefas.Items.Add(item);
            }
        }

        public Tarefa ObterTarefaSelecionada()
        {
            return (Tarefa)listTarefas.SelectedItem;
        }


    }

}

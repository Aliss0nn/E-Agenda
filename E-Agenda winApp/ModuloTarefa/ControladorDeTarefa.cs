using E_Agenda_winApp.Compartilhado;

namespace E_Agenda_winApp.ModuloTarefa
{
    public class ControladorDeTarefa : ControladorBase
    {
        private RepositorioTarefas repositorioTarefas;
        private ListagemDeTarefaControl listagemDeTarefa;

        public ControladorDeTarefa(RepositorioTarefas repositorioTarefas)
        {
            this.repositorioTarefas = repositorioTarefas;
        }

        public override string ToolTipInserir { get { return "Inserir nova Tarefa"; } }

        public override string ToolTipEditar { get { return "Editar Tarefa Existente"; } }

        public override string ToolTipExcluir { get { return "Excluir Tarefa Existente"; } }

        public override string ToolTipFiltrar { get { return "Filtrar Tarefa Existente"; } }

        public override string ToolTipAdicionaritens { get { return "Ver itens"; } }

        public override void Inserir()
        {
            TelaTarefa telaTarefa = new TelaTarefa();

            DialogResult opcaoEscolhida = telaTarefa.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Tarefa tarefa = telaTarefa.Tarefa;

                repositorioTarefas.Inserir(tarefa);

                CarregarTarefas();
            }
        }

        public override void Editar()
        {
            Tarefa tarefa = listagemDeTarefa.ObterTarefaSelecionada();
            

            if (tarefa == null)
            {
                MessageBox.Show("Selecione uma Tarefa Primeiro!", "Edição de Tarefas",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            TelaTarefa telaTarefa = new TelaTarefa();

            telaTarefa.TirarDatas();
          
            telaTarefa.Tarefa = listagemDeTarefa.ObterTarefaSelecionada();

            DialogResult opcaoEscolhida = telaTarefa.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                tarefa = telaTarefa.Tarefa;

                repositorioTarefas.Editar(tarefa);

                CarregarTarefas();
            }
        }

        public override void Excluir()
        {       
            Tarefa tarefa = listagemDeTarefa.ObterTarefaSelecionada();

            if (tarefa == null)
            {
                MessageBox.Show("Selecione uma Tarefa Primeiro!", "Edição de Tarefas",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show("Deseja excluir a Tarefa" + tarefa.nome, "Excluir Tarefas",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioTarefas.Excluir(tarefa);

                CarregarTarefas();
            }
        }
        private void CarregarTarefas()
        {
            List<Tarefa> tarefas = repositorioTarefas.SelecionarTodos();

            listagemDeTarefa.AtualizarRegistros(tarefas);
        }

        public override UserControl ObterListagem()
        {
            if (listagemDeTarefa == null)
            {
                listagemDeTarefa = new ListagemDeTarefaControl();
            }

            CarregarTarefas();

            return listagemDeTarefa;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Tarefas";
        }

        public override void AdicionarItens()
        {
            TelaItens telaItem = new TelaItens();

            Tarefa tarefaSelecionada = listagemDeTarefa.ObterTarefaSelecionada();

            if (tarefaSelecionada == null)
            {
                MessageBox.Show("Um Item deve estar selecionado!", "Seleção de Itens", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            telaItem.LimparTela();

            foreach (Itens item in tarefaSelecionada.listaItens)
            {
                telaItem.AdicionarItem(item);
            }

            if (telaItem.ShowDialog() == DialogResult.OK)
            {
                Itens item = telaItem.Itens;

                tarefaSelecionada.listaItens.Add(item);
            }
        }
    }
}

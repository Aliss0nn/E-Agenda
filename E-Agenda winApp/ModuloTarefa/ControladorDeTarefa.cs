using E_Agenda_winApp.Compartilhado;

namespace E_Agenda_winApp.ModuloTarefa
{
    public class ControladorDeTarefa : ControladorBase, Filtrador
    {
        private IRepositorioTarefa repositorioTarefas;
        private TabelaTarefaControl tabelaTarefa;
        protected List<Tarefa> listaRegistros;

        public ControladorDeTarefa(IRepositorioTarefa repositorioTarefas)
        {
            this.repositorioTarefas = repositorioTarefas;        
        }
        #region tooltips
        public override string ToolTipInserir { get { return "Inserir nova Tarefa"; } }

        public override string ToolTipEditar { get { return "Editar Tarefa Existente"; } }

        public override string ToolTipExcluir { get { return "Excluir Tarefa Existente"; } }

        public override string ToolTipFiltrar { get { return "Filtrar Tarefa Existente"; } }

        public override string ToolTipAdicionaritens { get { return "Ver itens"; } }
        #endregion tooltips

        #region buttons
        public override bool FiltrarHabilitado => true;
        public override bool AdicionarItensHabilitado => true;
        #endregion 

        public override void Inserir()
        {
            TelaTarefa telaTarefa = new TelaTarefa();

            DialogResult opcaoEscolhida = telaTarefa.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Tarefa tarefa = telaTarefa.ObterTarefa();

                repositorioTarefas.Inserir(tarefa);

                CarregarTarefas();
            }
        }

        public override void Editar()
        {
            Tarefa tarefaSelecionada = ObterTarefaSelecionada();

            if (tarefaSelecionada == null)
            {
                MessageBox.Show("Selecione uma tarefa primeiro", "Edição de Tarefa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }

            TelaTarefa telaTarefa = new TelaTarefa();

            telaTarefa.ConfigurarTela(tarefaSelecionada);

            DialogResult opcaoEscolhida = telaTarefa.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Tarefa tarefa = telaTarefa.ObterTarefa();

                repositorioTarefas.Editar(tarefa.id, tarefa);

                CarregarTarefas();
            }
        }

        private Tarefa ObterTarefaSelecionada()
        {
            int id = tabelaTarefa.ObterIdSelecionado();

            return repositorioTarefas.SelecionarPorId(id);
        }

        public override void Excluir()
        {
            Tarefa tarefa = ObterTarefaSelecionada();

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

        private void CarregarTarefas(List<Tarefa> tarefas)
        {
            tabelaTarefa.AtualizarRegistros(tarefas);

            TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {tarefas.Count} tarefa(s)");
        }

        private void CarregarTarefas()
        {
            List<Tarefa> tarefas = repositorioTarefas.SelecionarTodos();

            tabelaTarefa.AtualizarRegistros(tarefas);
        }

        public override UserControl ObterListagem()
        {
            if (tabelaTarefa == null)
            {
                tabelaTarefa = new TabelaTarefaControl();
            }

            CarregarTarefas();

            return tabelaTarefa;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Tarefas";
        }

        public override void Adicionar()
        {
            Tarefa tarefaSelecionada = ObterTarefaSelecionada();

            if (tarefaSelecionada == null)
            {
                MessageBox.Show("Selecione uma tarefa primeiro", "Adição de Itens da Tarefa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }

            TelaCadastroItensForm telaCadastroItensTarefa = new TelaCadastroItensForm(tarefaSelecionada);

            DialogResult opcaoEscolhida = telaCadastroItensTarefa.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                List<ItemTarefa> itensParaAdicionar = telaCadastroItensTarefa.ObterItensCadastrados();

                foreach (ItemTarefa item in itensParaAdicionar)
                {
                    tarefaSelecionada.AdicionarItem(item);
                }

                repositorioTarefas.Editar(tarefaSelecionada.id, tarefaSelecionada);
                CarregarTarefas();
            }
        }

        public override void ConcluirItens()
        {
            Tarefa tarefaSelecionada = ObterTarefaSelecionada();

            if (tarefaSelecionada == null)
            {
                MessageBox.Show("Selecione uma tarefa primeiro", "Atualização de Itens da Tarefa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }

            TelaAtualizacaoItens telaAtualizacaoItensTarefa = new TelaAtualizacaoItens(tarefaSelecionada);

            DialogResult opcaoEscolhida = telaAtualizacaoItensTarefa.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                List<ItemTarefa> itensMarcados = telaAtualizacaoItensTarefa.ObterItensMarcados();

                List<ItemTarefa> itensPendentes = telaAtualizacaoItensTarefa.ObterItensPendentes();

                foreach (ItemTarefa item in itensMarcados)
                {
                    tarefaSelecionada.ConcluirItem(item);
                }

                foreach (ItemTarefa item in itensPendentes)
                {
                    tarefaSelecionada.DesmarcarItem(item);
                }

                repositorioTarefas.Editar(tarefaSelecionada.id, tarefaSelecionada);

                CarregarTarefas();
            }
        }

        public override void Filtrar()
        {
            if (tabelaTarefa == null)
                tabelaTarefa = new TabelaTarefaControl();

            TelaFiltroForm telaFiltroTarefa = new TelaFiltroForm();

            DialogResult opcaoEscolhida = telaFiltroTarefa.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                
                StatusTarefaEnum status = telaFiltroTarefa.ObterFiltroTarefa();
                List<Tarefa> tarefas = null;

                switch (status)
                {
                    case StatusTarefaEnum.Pendentes:
                        tarefas = repositorioTarefas.SelecionarPendentes();
                        break;

                    case StatusTarefaEnum.Concluidas:
                        tarefas = repositorioTarefas.SelecionarConcluidas();
                        break;

                    default:
                        tarefas = repositorioTarefas.SelecionarTodosOrdenadosPorPrioridade();
                        break;
                }

                CarregarTarefas(tarefas);
            }
        }
    }
}
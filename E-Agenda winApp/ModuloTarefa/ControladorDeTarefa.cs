using E_Agenda_winApp.Compartilhado;
using E_Agenda_winApp.ModuloContato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            TelaTarefa telaTarefa = new TelaTarefa();

            telaTarefa.Tarefa = listagemDeTarefa.ObterTarefaSelecionada();

            DialogResult opcaoEscolhida = telaTarefa.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Tarefa tarefa = telaTarefa.Tarefa;

                repositorioTarefas.Editar(tarefa);

                CarregarTarefas();
            }
        }

        public override void Excluir()
        {
            Tarefa tarefa = listagemDeTarefa.ObterTarefaSelecionada();

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

        
    }
}

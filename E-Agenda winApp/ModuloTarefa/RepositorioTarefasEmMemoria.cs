using E_Agenda_winApp.Compartilhado;
using E_Agenda_winApp.ModuloContato;

namespace E_Agenda_winApp.ModuloTarefa
{
    public class RepositorioTarefasEmMemoria : RepositorioBase<Tarefa>,IRepositorioTarefa
    {
        List<Tarefa> tarefas = new List<Tarefa>();       
        public int contador;

        public RepositorioTarefasEmMemoria(List<Tarefa> tarefas)
        {
            listaRegistros = tarefas;
        }

        public void Inserir(Tarefa tarefa)
        {
            contador++;
            tarefa.id = contador;
            tarefas.Add(tarefa);

            contador++;
        }

        public List<Tarefa> SelecionarTodos()
        {
           return tarefas;
        }

        public void Editar(int id, Tarefa tarefa)
        {
            Tarefa tarefaSelecionada = SelecionarPorId(tarefa.id);

            tarefaSelecionada.id = tarefa.id;
            tarefaSelecionada.prioridade = tarefa.prioridade;
            tarefaSelecionada.dataFinal = tarefa.dataFinal;
            tarefaSelecionada.dataInicial = tarefa.dataInicial;
            tarefaSelecionada.nome = tarefa.nome;
        }

        public Tarefa SelecionarPorId(int id)
        {         
            return tarefas.FirstOrDefault(x => x.id == id);
        }

        public void Excluir(Tarefa tarefa)
        {
            tarefas.Remove(tarefa);
        }

        public List<Tarefa> SelecionarPendentes()
        {
            return listaRegistros
               .Where(x => x.percentualConcluido == 100)
               .OrderByDescending(x => x.prioridade)
               .ToList();
        }

        public List<Tarefa> SelecionarConcluidas()
        {
            return listaRegistros
               .Where(x => x.percentualConcluido < 100)
               .OrderByDescending(x => x.prioridade)
               .ToList();
        }

        public List<Tarefa> SelecionarTodosOrdenadosPorPrioridade()
        {
            return listaRegistros
                .OrderByDescending(x => x.prioridade)
                .ToList();
        }
    }
}

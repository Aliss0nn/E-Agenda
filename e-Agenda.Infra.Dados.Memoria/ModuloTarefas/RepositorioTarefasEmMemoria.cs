using E_Agenda_winApp.Compartilhado;

namespace E_Agenda_winApp.ModuloTarefa
{
    public class RepositorioTarefasEmMemoria : RepositorioBaseEmMemoria<Tarefa>,IRepositorioTarefa
    {          
        public int contador;

        public RepositorioTarefasEmMemoria(List<Tarefa> tarefas)
        {
            listaRegistros = tarefas;
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

        public void Editar(Tarefa registro)
        {
            throw new NotImplementedException();
        }
    }
}

using E_Agenda_winApp.Compartilhado;
using System.Runtime.Serialization.Formatters.Binary;

namespace E_Agenda_winApp.ModuloTarefa
{
    public class RepositorioTarefaEmArquivo : RepositorioBaseEmArquivo<Tarefa>, IRepositorioTarefa
    {
        public RepositorioTarefaEmArquivo(ContextoDados contexto) : base(contexto)
        {
        }

        protected override List<Tarefa> ObterRegistros()
        {
            return contextoDados.tarefas;
        }

        public List<Tarefa> SelecionarConcluidas()
        {
            return ObterRegistros()
                    .Where(x => x.percentualConcluido == 100)
                    .ToList();
        }

        public List<Tarefa> SelecionarPendentes()
        {
            return ObterRegistros()
                    .Where(x => x.percentualConcluido < 100)
                    .ToList();
        }
        
        public List<Tarefa> SelecionarTodosOrdenadosPorPrioridade()
        {
            return ObterRegistros()
                    .OrderByDescending(x => x.prioridade)
                    .ToList();
        }        
    }
}

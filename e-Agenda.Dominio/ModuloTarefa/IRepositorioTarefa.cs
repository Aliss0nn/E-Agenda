using E_Agenda_winApp.Compartilhado;

namespace E_Agenda_winApp.ModuloTarefa
{
    public interface IRepositorioTarefa : IRepositorioBase<Tarefa>
    {     
        List<Tarefa> SelecionarConcluidas();
        List<Tarefa> SelecionarPendentes();   
        List<Tarefa> SelecionarTodosOrdenadosPorPrioridade();     
    }
}

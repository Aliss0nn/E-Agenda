using E_Agenda_winApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Agenda_winApp.ModuloTarefa
{
    public interface IRepositorioTarefa : IRepositorioBase<Tarefa>
    {     
        List<Tarefa> SelecionarConcluidas();
        List<Tarefa> SelecionarPendentes();   
        List<Tarefa> SelecionarTodosOrdenadosPorPrioridade();     
    }
}

using E_Agenda_winApp.Compartilhado;
using E_Agenda_winApp.ModuloContato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Agenda_winApp.ModuloCompromisso
{
    public interface IRepositorioCompromisso : IRepositorioBase<Compromisso>
    {     
        List<Compromisso>? SelecionarCompromissosPassados(DateTime now);
        List<Compromisso>? SelecionarCompromissosFuturos(DateTime dataInicio, DateTime dataFinal);
    }
}

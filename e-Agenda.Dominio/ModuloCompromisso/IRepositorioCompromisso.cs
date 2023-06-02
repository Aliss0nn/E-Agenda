using E_Agenda_winApp.Compartilhado;

namespace E_Agenda_winApp.ModuloCompromisso
{
    public interface IRepositorioCompromisso : IRepositorioBase<Compromisso>
    {     
        List<Compromisso>? SelecionarCompromissosPassados(DateTime now);
        List<Compromisso>? SelecionarCompromissosFuturos(DateTime dataInicio, DateTime dataFinal);
    }
}

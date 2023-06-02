using E_Agenda_winApp.Compartilhado;

namespace E_Agenda_winApp.ModuloCompromisso
{
    public class RepositorioCompromissoEmMemoria : RepositorioBaseEmMemoria<Compromisso>
    {
        List<Compromisso> compromissos = new List<Compromisso>();
        
        public RepositorioCompromissoEmMemoria(List<Compromisso> compromissos)
        {
            this.listaRegistros = compromissos;
        }

        public List<Compromisso> SelecionarAlternativa(Predicate<Compromisso> periodo)
        {
            return compromissos.FindAll(periodo);
        }

        public List<Compromisso> SelecionarCompromissosPassados(DateTime hoje)
        {
            return listaRegistros.Where(x => x.data.Date < hoje.Date).ToList();
        }

        public List<Compromisso> SelecionarCompromissosFuturos(DateTime dataInicio, DateTime dataFinal)
        {
            return listaRegistros
                .Where(x => x.data > dataInicio)
                .Where(x => x.data < dataFinal)
                .ToList();
        }
    }
}

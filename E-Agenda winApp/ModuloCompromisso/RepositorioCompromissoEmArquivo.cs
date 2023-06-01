using E_Agenda_winApp.Compartilhado;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization.Formatters.Binary;

namespace E_Agenda_winApp.ModuloCompromisso
{
    public class RepositorioCompromissoEmArquivo : RepositorioBaseEmArquivo<Compromisso>, IRepositorioCompromisso
    {
        public RepositorioCompromissoEmArquivo(ContextoDados contexto) : base(contexto)
        {

        }
   
        protected override List<Compromisso> ObterRegistros()
        {
            return contextoDados.compromissos;
        }

        public List<Compromisso>? SelecionarCompromissosPassados(DateTime now)
        {
            return ObterRegistros().Where(x => x.data.Date < now.Date).ToList();
        }

        public List<Compromisso>? SelecionarCompromissosFuturos(DateTime dataInicio, DateTime dataFinal)
        {
            return ObterRegistros()
                .Where(x => x.data > dataInicio)
                .Where(x => x.data < dataFinal)
                .ToList(); ;
        }

        public void Editar(Compromisso registro)
        {
            throw new NotImplementedException();
        }
    }
}

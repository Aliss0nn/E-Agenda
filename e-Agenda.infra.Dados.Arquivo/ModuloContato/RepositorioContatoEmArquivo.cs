using E_Agenda_winApp.Compartilhado;
using E_Agenda_winApp.ModuloCompromisso;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;

namespace E_Agenda_winApp.ModuloContato
{
    public class RepositorioContatoEmArquivo : RepositorioBaseEmArquivo<Contato>, IRepositorioContato
    {
        public RepositorioContatoEmArquivo(ContextoDados contexto) : base(contexto)
        {

        }

        protected override List<Contato> ObterRegistros()
        {
            return contextoDados.contatos;
        }

                
        public void Editar(int id, Contato contato)
        {
            throw new NotImplementedException();
        }
    }
}

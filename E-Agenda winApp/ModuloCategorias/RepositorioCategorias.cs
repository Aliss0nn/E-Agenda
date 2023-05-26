using E_Agenda_winApp.Compartilhado;
using E_Agenda_winApp.ModuloContato;

namespace E_Agenda_winApp.ModuloCategorias
{
    public class RepositorioCategorias : RepositorioBase<Categorias>
    {
        List<Categorias> categorias = new List<Categorias>();

        public RepositorioCategorias(List<Categorias> listacategorias)
        {
            this.listaRegistros = listacategorias;
        }

        public List<Categorias> SelecionarTodos()
        {
            return categorias;
        }
    }
}

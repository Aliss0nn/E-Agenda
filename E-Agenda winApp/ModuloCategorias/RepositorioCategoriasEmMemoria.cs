using E_Agenda_winApp.Compartilhado;
using E_Agenda_winApp.ModuloContato;

namespace E_Agenda_winApp.ModuloCategorias
{
    public class RepositorioCategoriasEmMemoria 
    {
        List<Categorias> categorias = new List<Categorias>();
        static int contador;

       
        public void Inserir(Categorias categoria)
        {
            contador++;
            categoria.id = contador;
            categorias.Add(categoria);
        }
        public void Editar(Categorias categoria)
        {
            Categorias categoriaSelecionada = SelecionarPorId(categoria.id);

            categoriaSelecionada.id = categoria.id;
            categoriaSelecionada.titulo = categoria.titulo;
        }

        public Categorias SelecionarPorId(int id)
        {
            return categorias.FirstOrDefault(x => id == id);
        }

        public void Excluir(Categorias categoria)
        {
            categorias.Remove(categoria);
        }

        public List<Categorias> SelecionarTodos()
        {
            return categorias;
        }
    }
}

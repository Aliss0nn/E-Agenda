using E_Agenda_winApp.ModuloContato;

namespace E_Agenda_winApp.ModuloCategorias
{
    public interface IRepositorioCategorias
    {
        void Inserir(Categorias novaCategoria);
        void Editar(int id, Categorias categoria);
        void Excluir(Categorias categoriaSelecionada);
        Categorias SelecionarPorId(int id);
        List<Categorias> SelecionarTodos();
    }
}

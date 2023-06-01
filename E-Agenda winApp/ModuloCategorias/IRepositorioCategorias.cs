using E_Agenda_winApp.Compartilhado;
using E_Agenda_winApp.ModuloContato;

namespace E_Agenda_winApp.ModuloCategorias
{
    public interface IRepositorioCategorias : IRepositorioBase<Categorias>
    {
        public void AtualizarCategorias(List<Categorias> categorias);
    }
}

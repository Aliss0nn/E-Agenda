using E_Agenda_winApp.Compartilhado;
using E_Agenda_winApp.ModuloCategorias;
using E_Agenda_winApp.ModuloDespesas;

namespace E_Agenda_winApp.ModuloDespesasECategorias
{
    public class RepositorioDespesaEmMemoria : RepositorioBaseEmMemoria<Despesas>, IRepositorioDespesas

    {
        public void Editar(Despesas registro)
        {
            throw new NotImplementedException();
        }
    }
}

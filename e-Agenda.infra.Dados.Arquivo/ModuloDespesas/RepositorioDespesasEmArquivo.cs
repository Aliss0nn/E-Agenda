using E_Agenda_winApp.Compartilhado;
using E_Agenda_winApp.ModuloCategorias;
using E_Agenda_winApp.ModuloDespesasECategorias;

namespace E_Agenda_winApp.ModuloDespesas
{
    public class RepositorioDespesasEmArquivo : RepositorioBaseEmArquivo<Despesas>, IRepositorioDespesas
    {
        public RepositorioDespesasEmArquivo(ContextoDados contexto) : base(contexto)
        {

        }

        protected override List<Despesas> ObterRegistros()
        {
            return contextoDados.despesas;
        }



        //Categorias IRepositorioBase<Categorias>.SelecionarPorId(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //List<Categorias> IRepositorioBase<Categorias>.SelecionarTodos()
        //{
        //    throw new NotImplementedException();
        //}
    }
}

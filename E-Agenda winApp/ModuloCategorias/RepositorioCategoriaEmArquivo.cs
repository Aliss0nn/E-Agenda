using E_Agenda_winApp.Compartilhado;

namespace E_Agenda_winApp.ModuloCategorias
{
    public class RepositorioCategoriaEmArquivo : RepositorioBaseEmArquivo<Categorias>, IRepositorioCategorias, IRepositorioCategoriaEmArquivo
    {
        public const string NOME_ARQUIVO_Categorias = "C:\\temp\\contatos\\dados-contatos.bin";
        public RepositorioCategoriaEmArquivo(ContextoDados contexto) : base(contexto)
        {

        }

        protected override List<Categorias> ObterRegistros()
        {
            return contextoDados.categorias;
        }

        public void AtualizarCategorias(List<Categorias> categorias)
        {
            throw new NotImplementedException();
        }
    }
}

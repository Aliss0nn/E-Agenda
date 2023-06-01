using E_Agenda_winApp.Compartilhado;

namespace E_Agenda_winApp.ModuloCategorias
{
    public class RepositorioCategoriaEmArquivo : RepositorioBaseEmArquivo<Categorias>,IRepositorioCategorias
    {    
        public const string NOME_ARQUIVO_Categorias = "C:\\temp\\contatos\\dados-contatos.bin";
        public RepositorioCategoriaEmArquivo()
        {
        }

        public void AtualizarCategorias(List<Categorias> categorias)
        {
            throw new NotImplementedException();
        }
    }
}

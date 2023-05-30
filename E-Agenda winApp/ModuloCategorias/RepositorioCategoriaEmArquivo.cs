using E_Agenda_winApp.ModuloContato;
using System.Runtime.Serialization.Formatters.Binary;

namespace E_Agenda_winApp.ModuloCategorias
{
    public class RepositorioCategoriaEmArquivo : IRepositorioCategorias
    {
        private static int contador;

        private List<Categorias> categorias = new List<Categorias>();

        private const string NOME_ARQUIVO_Categoria = "C:\\temp\\categorias\\dados-categorias.bin";

        public RepositorioCategoriaEmArquivo()
        {
            if (File.Exists(NOME_ARQUIVO_Categoria))
                CarregarCategoriasDoArquivo();
        }
        public void Inserir(Categorias novaCategoria)
        {
            contador++;
            novaCategoria.id = contador;
            categorias.Add(novaCategoria);

            GravarContatosDoArquivo();
        }

        public void Editar(int id, Categorias categoria)
        {
            Categorias categoriasSelecionada = SelecionarPorId(id);

            categoriasSelecionada.AtualizarInformacoes(categoria);

            GravarContatosDoArquivo();
        }

        public void Excluir(Categorias categoriaSelecionada)
        {
            categorias.Remove(categoriaSelecionada);

            GravarContatosDoArquivo();
        }

        public Categorias SelecionarPorId(int id)
        {
            Categorias categoria = categorias.FirstOrDefault(x => x.id == id);

            return categoria;
        }

        public List<Categorias> SelecionarTodos()
        {
            return categorias;
        }
        private void CarregarCategoriasDoArquivo()
        {
            BinaryFormatter serializador = new BinaryFormatter();

            byte[] categoriasBytes = File.ReadAllBytes(NOME_ARQUIVO_Categoria);

            MemoryStream categoriasStream = new MemoryStream(categoriasBytes);

            categorias = (List<Categorias>)serializador.Deserialize(categoriasStream);

            AtualizarContador();
        }

        private void AtualizarContador()
        {
            contador = categorias.Max(x => x.id);
        }

        private void GravarContatosDoArquivo()
        {
            BinaryFormatter serializador = new BinaryFormatter();

            MemoryStream categoriaStream = new MemoryStream();

            serializador.Serialize(categoriaStream, categorias);

            byte[] contatosBytes = categoriaStream.ToArray();

            File.WriteAllBytes(NOME_ARQUIVO_Categoria, contatosBytes);
        }
    }
}

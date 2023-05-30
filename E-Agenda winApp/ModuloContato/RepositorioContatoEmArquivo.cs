using System.Runtime.Serialization.Formatters.Binary;

namespace E_Agenda_winApp.ModuloContato
{
    public class RepositorioContatoEmArquivo : IRepositorioContato
    {
        private static int contador;

        private List<Contato> contatos = new List<Contato>();

        private const string NOME_ARQUIVO_Contatos = "C:\\temp\\contatos\\dados-contatos.bin";

        public RepositorioContatoEmArquivo()
        {
            if (File.Exists(NOME_ARQUIVO_Contatos))
                CarregarContatosDoArquivo();
        }
    
        public void Inserir(Contato novoContato)
        {
            contador++;
            novoContato.id = contador;
            contatos.Add(novoContato);

            GravarContatosDoArquivo();
        }
        
        public void Editar(int id, Contato contato)
        {
            Contato contatoSelecionado = SelecionarPorId(id);

            contatoSelecionado.AtualizarInformacoes(contato);

            GravarContatosDoArquivo();
        }

        public void Excluir(Contato ContatoSelecionado)
        {
            contatos.Remove(ContatoSelecionado);

            GravarContatosDoArquivo();
        }
        public List<Contato> SelecionarTodos()
        {
            return contatos;
        }

        public Contato SelecionarPorId(int id)
        {
            Contato contato = contatos.FirstOrDefault(x => x.id == id);

            return contato;
        }
        private void GravarContatosDoArquivo()
        {
            BinaryFormatter serializador = new BinaryFormatter();

            MemoryStream contatosStream = new MemoryStream();

            serializador.Serialize(contatosStream, contatos);

            byte[] contatosBytes = contatosStream.ToArray();

            File.WriteAllBytes(NOME_ARQUIVO_Contatos,contatosBytes);
        }
        private void CarregarContatosDoArquivo()
        {
            BinaryFormatter serializador = new BinaryFormatter();

            byte[] contatosBytes = File.ReadAllBytes(NOME_ARQUIVO_Contatos); 

            MemoryStream contatosStream = new MemoryStream(contatosBytes);

            contatos = (List<Contato>)serializador.Deserialize(contatosStream);

            AtualizarContador();          
        }

        private void AtualizarContador()
        {
           contador = contatos.Max(x => x.id);
        }      
    }
}

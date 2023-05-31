using E_Agenda_winApp.ModuloContato;
using System.Runtime.Serialization.Formatters.Binary;

namespace E_Agenda_winApp.ModuloCompromisso
{
    public class RepositorioCompromissoEmArquivo : IRepositorioCompromisso
    {
        private static int contador;

        private List<Compromisso> compromissos = new List<Compromisso>();

        private const string NOME_ARQUIVO_COMPROMISSO = "C:\\temp\\compromisso\\dados-compromisso.bin";
        public RepositorioCompromissoEmArquivo()
        {
            if (File.Exists(NOME_ARQUIVO_COMPROMISSO))
                CarregarCompromissosDoArquivo();
        }
       
        public void Inserir(Compromisso novoCompromisso)
        {
            contador++;
            novoCompromisso.id = contador;
            compromissos.Add(novoCompromisso);

            GravarCompromissoDoArquivo();
        }  
        
        public void Editar(int id, Compromisso compromisso)
        {
            Compromisso compromissoSelecionado = SelecionarPorId(id);

            compromissoSelecionado.AtualizarInformacoes(compromisso);

            GravarCompromissoDoArquivo();
        }

        public void Excluir(Compromisso CompromissoSelecionado)
        {
            compromissos.Remove(CompromissoSelecionado);

            GravarCompromissoDoArquivo();
        }
     
        public Compromisso SelecionarPorId(int id)
        {
            Compromisso compromisso = compromissos.FirstOrDefault(x => x.id == id);

            return compromisso;
        }

        public List<Compromisso> SelecionarTodos()
        {
            return compromissos; 
        }

        private void GravarCompromissoDoArquivo()
        {
            BinaryFormatter serializador = new BinaryFormatter();

            MemoryStream compromissoStream = new MemoryStream();

            serializador.Serialize(compromissoStream, compromissos);

            byte[] compromissoBytes = compromissoStream.ToArray();

            File.WriteAllBytes(NOME_ARQUIVO_COMPROMISSO, compromissoBytes);
        }
        private void CarregarCompromissosDoArquivo()
        {
            BinaryFormatter serializador = new BinaryFormatter();

            byte[] compromissoBytes = File.ReadAllBytes(NOME_ARQUIVO_COMPROMISSO);

            MemoryStream compromissoStream = new MemoryStream(compromissoBytes);

            compromissos = (List<Compromisso>)serializador.Deserialize(compromissoStream);

            AtualizarContador();
        }

        private void AtualizarContador()
        {
            contador = compromissos.Max(x => x.id);
        }

        public List<Compromisso>? SelecionarCompromissosPassados(DateTime now)
        {
            return compromissos.Where(x => x.data.Date < now.Date).ToList();
        }

        public List<Compromisso>? SelecionarCompromissosFuturos(DateTime dataInicio, DateTime dataFinal)
        {
            return compromissos
                .Where(x => x.data > dataInicio)
                .Where(x => x.data < dataFinal)
                .ToList(); ;
        }
    }
}

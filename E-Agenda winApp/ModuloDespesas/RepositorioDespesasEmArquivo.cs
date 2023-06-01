using E_Agenda_winApp.Compartilhado;
using E_Agenda_winApp.ModuloCategorias;
using E_Agenda_winApp.ModuloContato;
using E_Agenda_winApp.ModuloDespesasECategorias;
using System.Runtime.Serialization.Formatters.Binary;

namespace E_Agenda_winApp.ModuloDespesas
{
    public class RepositorioDespesasEmArquivo : RepositorioBaseEmArquivo<Despesas>, IRepositorioDespesas
    {
        private static int contador;

        private List<Despesas> despesas = new List<Despesas>();

        private const string NOME_ARQUIVO_DESPESAS = "C:\\temp\\despesas\\dados-despesas.bin";
      
        public RepositorioDespesasEmArquivo()
        {
            if (File.Exists(NOME_ARQUIVO_DESPESAS))
                CarregarDespesasDoArquivo();
        }

        public void Inserir(Despesas novaDespesa)
        {
            contador++;
            novaDespesa.id = contador;
            despesas.Add(novaDespesa);

            GravarDespesasDoArquivo();
        }
     
        public void Editar(int id, Despesas Despesa)
        {
            Despesas despesaSelecionada = SelecionarPorId(id);

            despesaSelecionada.AtualizarInformacoes(Despesa);

            GravarDespesasDoArquivo();
        }

        public void Excluir(Despesas DespesaSelecionada)
        {
            despesas.Remove(DespesaSelecionada);

            GravarDespesasDoArquivo();
        }
      
        public Despesas SelecionarPorId(int id)
        {
            Despesas despesa = despesas.FirstOrDefault(x => x.id == id);

            return despesa;
        }

        public List<Despesas> SelecionarTodos()
        {
            return despesas;
        }

        private void CarregarDespesasDoArquivo()
        {
            BinaryFormatter serializador = new BinaryFormatter();

            byte[] despesasBytes = File.ReadAllBytes(NOME_ARQUIVO_DESPESAS);

            MemoryStream despesasStream = new MemoryStream(despesasBytes);

            despesas = (List<Despesas>)serializador.Deserialize(despesasStream);

            AtualizarContador();
        }

        private void AtualizarContador()
        {
           contador = despesas.Max(x => x.id);
        }

        private void GravarDespesasDoArquivo()
        {
            BinaryFormatter serializador = new BinaryFormatter();

            MemoryStream despesasStream = new MemoryStream();

            serializador.Serialize(despesasStream, despesas);

            byte[] despesasBytes = despesasStream.ToArray();

            File.WriteAllBytes(NOME_ARQUIVO_DESPESAS, despesasBytes);
        }

        public void Editar(Categorias registro)
        {
            throw new NotImplementedException();
        }

        public void Excluir(Categorias registro)
        {
            throw new NotImplementedException();
        }

        public void Inserir(Categorias registro)
        {
            throw new NotImplementedException();
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

using E_Agenda_winApp.Compartilhado;

namespace E_Agenda_winApp.ModuloTarefa
{
    public class Tarefa : EntidadeBase<Tarefa>
    {      
        public string nome;
        public string prioridade;
        public DateTime dataInicial;
        public DateTime dataFinal;
        public List<Itens> listaItens;
 
        public Tarefa(string nome, string prioridade, DateTime dataInicial, DateTime dataFinal)
        {
            this.nome = nome;
            this.dataInicial = dataInicial;
            this.dataFinal = dataFinal;
            this.prioridade = prioridade;
            listaItens = new List<Itens>();
        }

        public override void AtualizarInformacoes(Tarefa registroAtualizado)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return "id: " + id + "," + "nome:" + nome + "," + "Prioridade: " + prioridade;
        }

        public override string[] Validar()
        {
            throw new NotImplementedException();
        }
    }

}

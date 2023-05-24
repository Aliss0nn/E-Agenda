using E_Agenda_winApp.Compartilhado;

namespace E_Agenda_winApp.ModuloTarefa
{
    public class Tarefa : EntidadeBase<Tarefa>
    {      
        public string nome;
        public PrioridadeTarefaEnum prioridade;
        public DateTime dataInicial;
        public DateTime dataFinal;
        public List<Itens> listaItens;
 
        public Tarefa(string nome, PrioridadeTarefaEnum prioridade, DateTime dataInicial, DateTime dataFinal)
        {
            this.nome = nome;
            this.dataInicial = dataInicial;
            this.dataFinal = dataFinal;
            this.prioridade = prioridade;
            listaItens = new List<Itens>();
        }

        public override void AtualizarInformacoes(Tarefa registroAtualizado)
        {
            this.nome = registroAtualizado.nome;
            this.prioridade = registroAtualizado.prioridade;
            this.dataFinal = registroAtualizado.dataFinal;
            this.dataInicial = registroAtualizado.dataInicial;
        }

        public override string ToString()
        {
            return "id: " + id + "," + "nome:" + nome + "," + "Prioridade: " + prioridade;
        }

        public override string[] Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(nome))
                erros.Add("O campo 'nome' é obrigatório");

            return erros.ToArray();
        }
    }

}

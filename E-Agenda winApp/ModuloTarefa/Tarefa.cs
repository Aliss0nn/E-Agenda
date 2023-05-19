using E_Agenda_winApp.Compartilhado;

namespace E_Agenda_winApp.ModuloTarefa
{
    public class Tarefa : EntidadeBase
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

        public override string ToString()
        {
            return "id: " + id + "," + "nome:" + nome + "," + "Prioridade: " + prioridade;
        }

        
    }

}

using E_Agenda_winApp.Compartilhado;

namespace E_Agenda_winApp.ModuloTarefa
{
    public class Tarefa : EntidadeBase
    {      
        public string nome;
        public string prioridade;

        public Tarefa(string nome, string prioridade)
        {           
            this.nome = nome;
            this.prioridade = prioridade;
        }

        public override string ToString()
        {
            return "id: " + id + "," + nome + ", Prioridade" + prioridade;
        }

    }

}

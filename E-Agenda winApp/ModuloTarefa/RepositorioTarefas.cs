namespace E_Agenda_winApp.ModuloTarefa
{
    public class RepositorioTarefas
    {
        List<Tarefa> tarefas = new List<Tarefa>();       
        public int contador;
       
        public void Inserir(Tarefa tarefa)
        {
            contador++;
            tarefa.id = contador;
            tarefas.Add(tarefa);

            contador++;
        }

        public List<Tarefa> SelecionarTodos()
        {
           return tarefas;
        }

        public void Editar(Tarefa tarefa)
        {          
            Tarefa tarefaSelecionada = SelecionarPorId(tarefa.id);
                   
            tarefaSelecionada.nome = tarefa.nome;  
            tarefaSelecionada.prioridade = tarefa.prioridade;
        }

        public Tarefa SelecionarPorId(int id)
        {         
            return tarefas.FirstOrDefault(x => x.id == id);
        }

        public void Excluir(Tarefa tarefa)
        {
            tarefas.Remove(tarefa);
        }
    }
}

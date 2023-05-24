using E_Agenda_winApp.Compartilhado;

namespace E_Agenda_winApp.ModuloTarefa
{
    public class ItemTarefa
    {
        public string titulo;
        public bool concluido;

        public ItemTarefa(string titulo)
        {
            this.titulo = titulo;
        }

        public override string ToString()
        {
            return titulo;
        }

        public void Concluir()
        {
            concluido = true;
        }

        public override bool Equals(object? obj)
        {
            return obj is ItemTarefa tarefa &&
                   titulo == tarefa.titulo &&
                   concluido == tarefa.concluido;
        }

        public void Desmarcar()
        {
            concluido = false;
        }
    }


    public class Tarefa : EntidadeBase<Tarefa>
    {      
        public string nome;
        public PrioridadeTarefaEnum prioridade;
        public DateTime dataInicial;
        public DateTime dataFinal;      
        public List<ItemTarefa> itens;
        public decimal percentualConcluido;

        public Tarefa(int id, string nome, PrioridadeTarefaEnum prioridade, DateTime dataInicial, DateTime dataFinal)
        {
            this.id = id;
            this.nome = nome;
            this.dataInicial = dataInicial;
            this.dataFinal = dataFinal;
            this.prioridade = prioridade;
            itens = new List<ItemTarefa>();
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
            return "id: " + id + "," + "nome:" + nome + "," + "Prioridade: " + prioridade + "Percentual Concluído" + percentualConcluido;
        }

        public override string[] Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(nome))
                erros.Add("O campo 'nome' é obrigatório");

            return erros.ToArray();
        }

        public void AdicionarItem(ItemTarefa item)
        {
            itens.Add(item);
        }

        public void ConcluirItem(ItemTarefa item)
        {
            ItemTarefa itemSelecionado = itens.FirstOrDefault(x => x.Equals(item));

            itemSelecionado.Concluir();

            CalcularPercentualConcluido();
        }

        public void DesmarcarItem(ItemTarefa item)
        {
            ItemTarefa itemSelecionado = itens.FirstOrDefault(x => x.Equals(item));

            itemSelecionado.Desmarcar();

            CalcularPercentualConcluido();
        }

        private void CalcularPercentualConcluido()
        {
            decimal qtdItens = itens.Count();

            if (qtdItens == 0)
                return;

            decimal qtdConcluidos = itens.Count(x => x.concluido == true);

            decimal resultado = (qtdConcluidos / qtdItens) * 100;

            percentualConcluido = Math.Round(resultado, 2);
        }
    }

}

using E_Agenda_winApp.Compartilhado;
using E_Agenda_winApp.ModuloCategorias;

namespace E_Agenda_winApp.ModuloDespesasECategorias
{
    [Serializable]
    public class Despesas : EntidadeBase<Despesas>
    {
        public string descricao = "";
        public string valor;
        public DateTime data;
        public PagamentoCategoriaEnum pagamento;
        public Categorias categoria;

        public Despesas(int id, string descricao, string valor, DateTime data, PagamentoCategoriaEnum pagamento,
            Categorias categoria)
        {
            this.id = id;
            this.descricao = descricao;
            this.valor = valor;
            this.data = data;
            this.pagamento = pagamento;
            this.categoria = categoria;
        }

        public override void AtualizarInformacoes(Despesas registroAtualizado)
        {
            this.pagamento = registroAtualizado.pagamento;
            this.descricao = registroAtualizado.descricao;
            this.data = registroAtualizado.data;
            this.valor = registroAtualizado.valor;
        }

        public override string[] Validar()
        {
           
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(descricao))
                erros.Add("O campo 'descrição' é obrigatório");

            if (string.IsNullOrEmpty(valor.ToString()))
                erros.Add("O campo 'Valor' é obrigatório");
           
            return erros.ToArray();
        }
    }
}

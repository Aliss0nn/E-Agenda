namespace E_Agenda_winApp.ModuloDespesasECategorias
{
    public class RepositorioDespesa 
    {
        List<Despesas> despesas = new List<Despesas>();

        private static int contador;

        public void Inserir(Despesas despesa)
        {
            contador++;
            despesa.id = contador;
            despesas.Add(despesa);
        }

        public List<Despesas> SelecionarTodos()
        {
            return despesas;
        }

        public void Editar(Despesas despesas)
        {
           
            Despesas despesaSelecionada = SelecionarPorId(despesas.id);

            despesaSelecionada.descricao = despesas.descricao;
            despesaSelecionada.pagamento = despesas.pagamento;
            despesaSelecionada.valor = despesas.valor;
            despesaSelecionada.data = despesas.data;
        }

        public Despesas SelecionarPorId(int id)
        {
            return despesas.FirstOrDefault(x => id == id);
        }

        public void Excluir(Despesas despesa)
        {
            despesas.Remove(despesa);
        }
    }
}

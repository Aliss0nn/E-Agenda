namespace E_Agenda_winApp.Compartilhado
{
    public abstract class RepositorioBaseEmArquivo<TEntidade> where TEntidade : EntidadeBase<TEntidade>
    {
        private int contador;
        protected ContextoDados contextoDados;

        protected abstract List<TEntidade> ObterRegistros();

        public RepositorioBaseEmArquivo(ContextoDados contexto)
        {
            contextoDados = contexto;

            AtualizarContador();
        }
        
        public void Inserir(TEntidade novoRegistro)
        {
            List<TEntidade> registros = ObterRegistros();

            contador++;
            novoRegistro.id = contador;
            registros.Add(novoRegistro);

            contextoDados.GravarEmArquivoJson();
        }

        public void Editar(int id, TEntidade registroAtualizado)
        {
            TEntidade registroSelecionado = SelecionarPorId(id);

            registroSelecionado.AtualizarInformacoes(registroAtualizado);

            contextoDados.GravarEmArquivoJson();
        }

        public void Excluir(TEntidade registroSelecionado)
        {
            List<TEntidade> registros = ObterRegistros();

            registros.Remove(registroSelecionado);

            contextoDados.GravarEmArquivoJson();
        }

        public TEntidade SelecionarPorId(int id)
        {
            List<TEntidade> registros = ObterRegistros();

            return registros.FirstOrDefault(x => x.id == id);
        }

        public List<TEntidade> SelecionarTodos()
        {
            return ObterRegistros();
        }

        private void AtualizarContador()
        {
            if (ObterRegistros().Count > 0)
                contador = ObterRegistros().Max(x => x.id);
        }      
    }
}


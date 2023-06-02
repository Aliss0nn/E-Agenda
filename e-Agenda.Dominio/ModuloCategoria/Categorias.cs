using E_Agenda_winApp.Compartilhado;

namespace E_Agenda_winApp.ModuloCategorias
{
    [Serializable]
    public class Categorias : EntidadeBase<Categorias>
    {
        public string titulo;

        public Categorias(int id, string titulo)
        {
            this.titulo = titulo;
            this.id = id;
        }

        public override void AtualizarInformacoes(Categorias registroAtualizado)
        {
            this.titulo = registroAtualizado.titulo;
            this.id = registroAtualizado.id;
        }
        public override string[] Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(titulo))
                erros.Add("O campo 'descrição' é obrigatório");

            return erros.ToArray();
        }
      
    }
}

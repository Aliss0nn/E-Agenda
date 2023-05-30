using E_Agenda_winApp.Compartilhado;

namespace E_Agenda_winApp.ModuloContato
{

    [Serializable]
    public class Contato : EntidadeBase<Contato>
    {        
        public string telefone;
        public string email;
        public string cargo;
        public string nome;
        public string empresa;

        public Contato(string telefone, string email, string cargo, string nome, string empresa)
        {          
            this.telefone = telefone;
            this.email = email;
            this.cargo = cargo;
            this.nome = nome;
            this.empresa = empresa;
        }

        public override void AtualizarInformacoes(Contato registroAtualizado)
        {
            this.telefone = registroAtualizado.telefone;
            this.email = registroAtualizado.email;
            this.cargo = registroAtualizado.cargo;
            this.nome = registroAtualizado.nome;
            this.empresa = registroAtualizado.empresa;
        }

        public override string ToString()
        {
            return "Id: " + id + "," + nome + ", " + "Cargo: " + cargo +  ", Empresa: " + empresa;
        }

        public override string[] Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(nome))
                erros.Add("O campo 'nome' é obrigatório");

            if (string.IsNullOrEmpty(telefone))
                erros.Add("O campo 'telefone' é obrigatório");

            if (string.IsNullOrEmpty(email))
                erros.Add("O campo 'email' é obrigatório");

            return erros.ToArray();
        }
    }

}

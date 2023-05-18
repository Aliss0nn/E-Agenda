using E_Agenda_winApp.Compartilhado;

namespace E_Agenda_winApp.ModuloContato
{
    public class Contato : EntidadeBase
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

        public override string ToString()
        {
            return "id: " + id + "," + nome + ", Empresa" + empresa;
        }

    }

}

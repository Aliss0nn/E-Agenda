using E_Agenda_winApp.Compartilhado;
using E_Agenda_winApp.ModuloContato;

namespace E_Agenda_winApp.ModuloCompromisso
{
    public class Compromisso : EntidadeBase<Compromisso>
    {
        public string assunto;
        public string local;
        public DateTime data;
        public DateTime horaInicio;
        public DateTime horaFinal;
        public Contato contato;
        

        public Compromisso(string assunto, string local, DateTime data, DateTime horaInicio, DateTime horaFinal, Contato contato)
        {
            this.assunto = assunto;
            this.local = local;
            this.data = data;
            this.horaInicio = horaInicio;
            this.horaFinal = horaFinal;
            this.contato = contato;
        }

        public override void AtualizarInformacoes(Compromisso registroAtualizado)
        {
            this.assunto = registroAtualizado.assunto;
            this.local = registroAtualizado.local;
            this.data = registroAtualizado.data;
            this.horaInicio = registroAtualizado.horaInicio;
            this.horaFinal = registroAtualizado.horaFinal;
            this.contato = registroAtualizado.contato;
        }
        

        public override string ToString()
        {
            return "id: " + id + "\t assunto: " + assunto + "\t local: " + local + "\t data: " + data + "\t horaInicio: " + horaInicio + "\t horaFinal: " + horaFinal;
        }

        public override string[] Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(assunto))
                erros.Add("O campo 'nome' é obrigatório");

            if (string.IsNullOrEmpty(local))
                erros.Add("O campo Local é Obrigatório");

            return erros.ToArray();
        }
    }
}

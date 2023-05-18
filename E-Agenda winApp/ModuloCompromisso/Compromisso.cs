using E_Agenda_winApp.Compartilhado;
using E_Agenda_winApp.ModuloContato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Agenda_winApp.ModuloCompromisso
{
    public class Compromisso : EntidadeBase
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

        public override string ToString()
        {
            return "id: " + id + "\t assunto: " + assunto + "\t local: " + local + "\t data: " + data + "\t horaInicio: " + horaInicio + "\t horaFinal: " + horaFinal;
        }
    }
}

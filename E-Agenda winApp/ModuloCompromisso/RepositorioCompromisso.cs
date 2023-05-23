namespace E_Agenda_winApp.ModuloCompromisso
{
    public class RepositorioCompromisso
    {
        List<Compromisso> compromissos = new List<Compromisso>();
        private int contador;

        public void Inserir(Compromisso compromisso)
        {
            contador++;
            compromisso.id = contador;
            compromissos.Add(compromisso);
        }

        public List<Compromisso> SelecionarTodos()
        {
            return compromissos;
        }

        public void Editar(Compromisso compromisso)
        {          
            Compromisso compromissoSelecionado = SelecionarPorId(compromisso.id);

            compromissoSelecionado.id = compromisso.id;
            compromissoSelecionado.assunto = compromisso.assunto;
            compromissoSelecionado.local = compromisso.local;
            compromissoSelecionado.horaFinal = compromisso.horaFinal;
            compromissoSelecionado.horaInicio = compromisso.horaInicio;
            compromissoSelecionado.data = compromisso.data;
        }

        public Compromisso SelecionarPorId(int id)
        {
            return compromissos.FirstOrDefault(x => id == id);
        }

        public void Excluir(Compromisso compromisso)
        {
            compromissos.Remove(compromisso);
        }

        public List<Compromisso> SelecionarAlternativa(Predicate<Compromisso> periodo)
        {
            return compromissos.FindAll(periodo);
        }
    }
}

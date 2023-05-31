using E_Agenda_winApp.ModuloContato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Agenda_winApp.ModuloCompromisso
{
    public interface IRepositorioCompromisso
    {
        void Inserir(Compromisso novoCompromisso);
        void Editar(int id, Compromisso Compromisso);
        void Excluir(Compromisso CompromissoSelecionado);
        Compromisso SelecionarPorId(int id);
        List<Compromisso> SelecionarTodos();
        List<Compromisso>? SelecionarCompromissosPassados(DateTime now);
        List<Compromisso>? SelecionarCompromissosFuturos(DateTime dataInicio, DateTime dataFinal);
    }
}

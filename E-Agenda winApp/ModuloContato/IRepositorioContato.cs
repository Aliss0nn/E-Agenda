using E_Agenda_winApp.Compartilhado;
using E_Agenda_winApp.ModuloTarefa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Agenda_winApp.ModuloContato
{
    public interface IRepositorioContato : IRepositorioBase<Contato>
    {
        void Inserir(Contato novoContato);
        void Editar(int id, Contato contato);
        void Excluir(Contato ContatoSelecionado);
        Contato SelecionarPorId(int id);
        List<Contato> SelecionarTodos();
    }
}

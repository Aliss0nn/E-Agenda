using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Agenda_winApp.Compartilhado
{
    public interface IRepositorioBase<TEntidade> where TEntidade : EntidadeBase<TEntidade>
    {
        void Editar(TEntidade registro);
        void Excluir(TEntidade registro);
        void Inserir(TEntidade registro);
        TEntidade SelecionarPorId(int id);
        List<TEntidade> SelecionarTodos();
    }
}

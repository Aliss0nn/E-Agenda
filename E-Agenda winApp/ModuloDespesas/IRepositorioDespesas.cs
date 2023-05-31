using E_Agenda_winApp.ModuloContato;
using E_Agenda_winApp.ModuloDespesasECategorias;
using E_Agenda_winApp.ModuloTarefa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Agenda_winApp.ModuloDespesas
{
    public interface IRepositorioDespesas
    {
        void Inserir(Despesas novaDespesa);
        void Editar(int id, Despesas Despesa);
        void Excluir(Despesas DespesaSelecionada);
        Despesas SelecionarPorId(int id);
        List<Despesas> SelecionarTodos();
    }
}

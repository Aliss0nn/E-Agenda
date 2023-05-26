using E_Agenda_winApp.Compartilhado;
using E_Agenda_winApp.ModuloCompromisso;
using E_Agenda_winApp.ModuloContato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Agenda_winApp.ModuloDespesasECategorias
{
    public class RepositorioDespesa : RepositorioBase<Despesas> 
    {     
        public RepositorioDespesa(List<Despesas> despesas)
        {
            this.listaRegistros = despesas;
        }

        public void Editar(Despesas despesas)
        {
           
            Despesas despesaSelecionada = SelecionarPorId(despesas.id);

            despesaSelecionada.descricao = despesas.descricao;
            despesaSelecionada.pagamento = despesas.pagamento;
            despesaSelecionada.valor = despesas.valor;
            despesaSelecionada.data = despesas.data;
        }
    }
}

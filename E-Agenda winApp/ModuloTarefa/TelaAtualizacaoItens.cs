using E_Agenda_winApp.Compartilhado;
using System.Data;

namespace E_Agenda_winApp.ModuloTarefa
{
    public partial class TelaAtualizacaoItens : Form
    {
        public TelaAtualizacaoItens(Tarefa tarefa)
        {
            InitializeComponent();

            this.ConfigurarDialog();

            ConfigurarTela(tarefa);

        }

        private void ConfigurarTela(Tarefa tarefa)
        {
            txtId.Text = tarefa.id.ToString();

            txtTitulo.Text = tarefa.nome;

            int i = 0;
            foreach (ItemTarefa item in tarefa.itens)
            {
                listItensTarefa.Items.Add(item);

                if (item.concluido)
                    listItensTarefa.SetItemChecked(i, true);

                i++;
            }
        }

        public List<ItemTarefa> ObterItensMarcados()
        {
            return listItensTarefa.CheckedItems.Cast<ItemTarefa>().ToList();
        }

        public List<ItemTarefa> ObterItensPendentes()
        {
            return listItensTarefa.Items.Cast<ItemTarefa>()
                .Except(ObterItensMarcados())
                .ToList();
        }
    }
}

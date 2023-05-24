using E_Agenda_winApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Agenda_winApp.ModuloTarefa
{
    public partial class TelaCadastroItensForm : Form
    {
        public TelaCadastroItensForm(Tarefa tarefa)
        {
            InitializeComponent();

            this.ConfigurarDialog();

            ConfigurarTela(tarefa);
        }

        private void ConfigurarTela(Tarefa tarefa)
        {
            txtId.Text = tarefa.id.ToString();

            txtNome.Text = tarefa.nome.ToString();

            listItens.Items.AddRange(tarefa.itens.ToArray());
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string titulo = txtTituloItem.Text;

            ItemTarefa itemTarefa = new ItemTarefa(titulo);

            listItens.Items.Add(itemTarefa);
        }
        public List<ItemTarefa> ObterItensCadastrados()
        {
            return listItens.Items.Cast<ItemTarefa>().ToList();
        }
    }
}

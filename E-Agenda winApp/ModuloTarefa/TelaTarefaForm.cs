using E_Agenda_winApp.ModuloContato;
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
    public partial class TelaTarefa : Form
    {
        private Tarefa tarefa;

        public TelaTarefa()
        {
            InitializeComponent();
        }

        public Tarefa Tarefa
        {
            set
            {
                txtId.Text = value.id.ToString();
                txtNomeDaTarefa.Text = value.nome;
                txtPrioridade.Text = value.prioridade;

            }
            get
            {
                return tarefa;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNomeDaTarefa.Text;
            string prioridade = txtPrioridade.Text;

            tarefa = new Tarefa(nome, prioridade);
        }
    }
}

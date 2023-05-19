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
    public partial class TelaItens : Form
    {
        private Itens itens;

        public Itens Itens
        {
            set
            {
                txtDescricao.Text = value.descricao;
            }

            get
            {
                return itens;
            }
        }

        public void AdicionarItem(Itens item)
        {
            lbListaItens.Items.Add(item);
        }

        public void LimparTela()
        {
            lbListaItens.Items.Clear();
        }

        public TelaItens()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string descricao = txtDescricao.Text;
            string concluida = pnControls.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked).Text;

            itens = new Itens(descricao, concluida);
        }
    }
}

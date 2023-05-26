using E_Agenda_winApp.Compartilhado;
using E_Agenda_winApp.ModuloCategorias;
using E_Agenda_winApp.ModuloCompromisso;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Agenda_winApp.ModuloDespesasECategorias
{
    public partial class TelaCategorias : Form
    {
        private Categorias categoria;
        private List<Categorias> listCategoria;

        public TelaCategorias()
        {
            InitializeComponent();
            this.ConfigurarDialog();

        }

        public Categorias Categorias
        {
            set
            {
                txtId.Text = value.id.ToString();
                txtTitulo.Text = value.titulo;
            }
            get
            {
                return categoria;
            }
        }

        public void ConfigurarTela(Categorias categoria)
        {
            txtId.Text = categoria.id.ToString();
            txtTitulo.Text = categoria.titulo;
        }

        private void bntSalvar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            string titulo = txtTitulo.Text;

            categoria = new Categorias(id, titulo);

            string[] erros = categoria.Validar();

            if (erros.Length > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }

    }
}

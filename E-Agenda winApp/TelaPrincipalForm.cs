using E_Agenda_winApp.Compartilhado;
using E_Agenda_winApp.ModuloCompromisso;
using E_Agenda_winApp.ModuloContato;
using E_Agenda_winApp.ModuloTarefa;

namespace E_Agenda_winApp
{
    public partial class TelaPrincipalForm : Form
    {
        private ControladorBase controlador;
        private RepositorioTarefas repositorioTarefas = new RepositorioTarefas();
        private RepositorioContato repositorioContato = new RepositorioContato();
        private RepositorioCompromisso repositorioCompromisso = new RepositorioCompromisso();

        public TelaPrincipalForm()
        {
            InitializeComponent();
        }

        private void contatosMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorDeContato(repositorioContato);

            ConfigurarTelaPrincipal(controlador);
        }

        private void ConfigurarListagem(ControladorBase controladorBase)
        {
            UserControl listagem = controladorBase.ObterListagem();
            listagem.Dock = DockStyle.Fill;
            panelRegistros.Controls.Clear();
            panelRegistros.Controls.Add(listagem);
        }

        private void ConfigurarTelaPrincipal(ControladorBase controladorBase)
        {
            labelTipoCadastro.Text = controladorBase.ObterTipoCadastro();

            ConfigurarToolTips(controlador);

            ConfigurarListagem(controlador);
        }

        private void tarefasMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorDeTarefa(repositorioTarefas);

            ConfigurarTelaPrincipal(controlador);
        }

        private void compromissosMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorDeCompromisso(repositorioCompromisso,repositorioContato);

            ConfigurarTelaPrincipal(controlador);
        }

        private void ConfigurarToolTips(ControladorBase controlador)
        {
            btnInserir.ToolTipText = controlador.ToolTipInserir;
            btnEditar.ToolTipText = controlador.ToolTipEditar;
            btnExcluir.ToolTipText = controlador.ToolTipExcluir;
            btnFiltrar.ToolTipText = controlador.ToolTipFiltrar;
        }


        private void btnInserir_Click(object sender, EventArgs e)
        {
            controlador.Inserir();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            controlador.Editar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            controlador.Excluir();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if(controlador is Filtrador)
            {
                Filtrador filtrador = (Filtrador)controlador;
                filtrador.Filtrar();
            }
        }
    }
}
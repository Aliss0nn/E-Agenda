using E_Agenda_winApp.Compartilhado;
using E_Agenda_winApp.ModuloCategorias;
using E_Agenda_winApp.ModuloCompromisso;
using E_Agenda_winApp.ModuloContato;
using E_Agenda_winApp.ModuloDespesas;
using E_Agenda_winApp.ModuloDespesasECategorias;
using E_Agenda_winApp.ModuloTarefa;

namespace E_Agenda_winApp
{
    public partial class TelaPrincipalForm : Form
    {
        private ControladorBase controlador;
        private IRepositorioTarefa repositorioTarefas = new RepositorioTarefaEmArquivo();
        private IRepositorioContato repositorioContato = new RepositorioContatoEmArquivo();
        private IRepositorioCategorias repositorioCategorias = new RepositorioCategoriaEmArquivo();
        private IRepositorioCompromisso repositorioCompromisso = new RepositorioCompromissoEmArquivo();

        private IRepositorioDespesas repositorioDespesa = new RepositorioDespesasEmArquivo();
        private static TelaPrincipalForm telaPrincipal;
        private TabelaDespesaControl tabelaDespesa;
        


        public TelaPrincipalForm()
        {        
            InitializeComponent();
        }

        public void AtualizarRodape(string mensagem)
        {
            labelRodape.Text = mensagem;
        }

        public static TelaPrincipalForm Instancia
        {
            get
            {
                if (telaPrincipal == null)
                    telaPrincipal = new TelaPrincipalForm();

                return telaPrincipal;
            }
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

        //private void ConfigurarBarraFerramentas(ControladorBase controlador)
        //{
        //    barraFerramentas.Enabled = true;

        //    ConfigurarToolTips(controlador);

        //    ConfigurarEstados(controlador);
        //}

        private void ConfigurarToolTips(ControladorBase controlador)
        {
            btnInserir.ToolTipText = controlador.ToolTipInserir;
            btnEditar.ToolTipText = controlador.ToolTipEditar;
            btnExcluir.ToolTipText = controlador.ToolTipExcluir;
            btnFiltrar.ToolTipText = controlador.ToolTipFiltrar;
            btnItens.ToolTipText = controlador.ToolTipAdicionaritens;
        }

        private void ConfigurarTelaPrincipal(ControladorBase controladorBase)
        {
            labelTipoCadastro.Text = controladorBase.ObterTipoCadastro();

            ConfigurarEstados(controlador);

            ConfigurarToolTips(controlador);

            ConfigurarListagem(controlador);
        }

        private void ConfigurarEstados(ControladorBase controlador)
        {
            btnInserir.Enabled = controlador.InserirHabilitado;
            btnEditar.Enabled = controlador.EditarHabilitado;
            btnExcluir.Enabled = controlador.ExcluirHabilitado;
            btnFiltrar.Enabled = controlador.FiltrarHabilitado;
            btnItens.Enabled = controlador.AdicionarItensHabilitado;
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
     
        private void despesasMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorDeDespesas(tabelaDespesa, repositorioDespesa,repositorioCategorias);

            ConfigurarTelaPrincipal(controlador);
        }
        private void categoriasMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorCategorias(repositorioCategorias);

            ConfigurarTelaPrincipal(controlador);
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (controlador == null)
            {
                MessageBox.Show("Selecione um tipo De Cadastro Primeiro!", "E-agenda",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            controlador.Inserir();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (controlador == null)
            {
                MessageBox.Show("Selecione um tipo De Cadastro Primeiro!", "E-agenda",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            controlador.Editar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (controlador == null)
            {
                MessageBox.Show("Selecione um tipo De Cadastro Primeiro!", "E-agenda",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            controlador.Excluir();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (controlador is Filtrador)
            {
                Filtrador filtrador = (Filtrador)controlador;
                filtrador.Filtrar();
            }
        }

        private void btnItens_Click(object sender, EventArgs e)
        {
            if (controlador == null)
            {
                MessageBox.Show("Selecione um tipo De Cadastro Primeiro!", "E-agenda",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            controlador.Adicionar();
        }      
    }
}
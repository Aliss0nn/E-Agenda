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
        private static TelaPrincipalForm telaPrincipal;


        public TelaPrincipalForm()
        {
            PopularListas(repositorioCompromisso, repositorioContato);
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
            controlador = new ControladorDeCompromisso(repositorioCompromisso, repositorioContato);

            ConfigurarTelaPrincipal(controlador);
        }

        private void ConfigurarToolTips(ControladorBase controlador)
        {
            btnInserir.ToolTipText = controlador.ToolTipInserir;
            btnEditar.ToolTipText = controlador.ToolTipEditar;
            btnExcluir.ToolTipText = controlador.ToolTipExcluir;
            btnFiltrar.ToolTipText = controlador.ToolTipFiltrar;
            btnItens.ToolTipText = controlador.ToolTipAdicionaritens;
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


            controlador.AdicionarItens();
        }


        public void PopularListas(RepositorioCompromisso repositorio, RepositorioContato repositorioContato)
        {
            Contato contato01 = new Contato("4998234402", "aaa@hotmail.com", "Estagi�rio", "Alisson Scopel", "Klabin");
            Contato contato02 = new Contato("4932893292", "bbb@gmail.com", "Estagi�rio", "Felipe Maines", "NDD");
            Contato contato03 = new Contato("4982913821", "cccc@gmail.com", "Estagi�rio", "Gustavo Ramos", "RR");
            Contato contato04 = new Contato("4283198321", "dddd@gmail.com", "Estagi�rio", "Leonardo Medeiros", "Poker");
            Contato contato05 = new Contato("4983829289", "dudu@gmail.com", "Dev Junior", "Eduardo Maines", "NDD");

            repositorioContato.Inserir(contato01);
            repositorioContato.Inserir(contato02);
            repositorioContato.Inserir(contato03);
            repositorioContato.Inserir(contato04);
            repositorioContato.Inserir(contato05);

            Compromisso compromisso01 = new Compromisso("Reuni�o", "Klabin", DateTime.Now.Date, DateTime.Now, DateTime.Today, contato01);
            Compromisso compromisso02 = new Compromisso("Reuni�o", "NDD", DateTime.Now.Date, DateTime.Now, DateTime.Today, contato02);
            Compromisso compromisso03 = new Compromisso("Reuni�o", "Casa", DateTime.Now.Date, DateTime.Now, DateTime.Today, contato03);

            repositorioCompromisso.Inserir(compromisso01);
            repositorioCompromisso.Inserir(compromisso02);
            repositorioCompromisso.Inserir(compromisso03);
        }


    }
}
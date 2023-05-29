using E_Agenda_winApp.Compartilhado;
using E_Agenda_winApp.ModuloCategorias;
using E_Agenda_winApp.ModuloCompromisso;
using E_Agenda_winApp.ModuloContato;
using E_Agenda_winApp.ModuloDespesasECategorias;
using E_Agenda_winApp.ModuloTarefa;

namespace E_Agenda_winApp
{
    public partial class TelaPrincipalForm : Form
    {
        private ControladorBase controlador;
        private RepositorioTarefas repositorioTarefas = new RepositorioTarefas(new List<Tarefa>());
        private RepositorioContato repositorioContato = new RepositorioContato();
        private RepositorioCategorias repositorioCategorias = new RepositorioCategorias();
        private RepositorioCompromisso repositorioCompromisso = new RepositorioCompromisso(new List<Compromisso>());

        private RepositorioDespesa repositorioDespesa = new RepositorioDespesa();
        private static TelaPrincipalForm telaPrincipal;
        private TabelaDespesaControl tabelaDespesa;
        


        public TelaPrincipalForm()
        {
            PopularListas(repositorioCompromisso, repositorioContato, repositorioTarefas, repositorioDespesa, repositorioCategorias);
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
            controlador = new ControladorDeCompromisso(repositorioCompromisso, repositorioContato);

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


        public void PopularListas(RepositorioCompromisso repositorio, RepositorioContato repositorioContato, RepositorioTarefas repositorioTarefa,
            RepositorioDespesa repositorioDespesa, RepositorioCategorias repositorioCategorias)
        {
            Contato contato01 = new Contato("4998234402", "aaa@hotmail.com", "Estagiário", "Alisson Scopel", "Klabin");
            Contato contato02 = new Contato("4932893292", "bbb@gmail.com", "Estagiário", "Felipe Maines", "NDD");
            Contato contato03 = new Contato("4982913821", "cccc@gmail.com", "Estagiário", "Gustavo Ramos", "RR");
            Contato contato04 = new Contato("4283198321", "dddd@gmail.com", "Estagiário", "Leonardo Medeiros", "Poker");
            Contato contato05 = new Contato("4983829289", "dudu@gmail.com", "Dev Junior", "Eduardo Maines", "NDD");

            repositorioContato.Inserir(contato01);
            repositorioContato.Inserir(contato02);
            repositorioContato.Inserir(contato03);
            repositorioContato.Inserir(contato04);
            repositorioContato.Inserir(contato05);

            Compromisso compromisso01 = new Compromisso("Reunião", "Klabin", DateTime.Now.Date, DateTime.Now, DateTime.Today, contato01);
            Compromisso compromisso02 = new Compromisso("Reunião", "NDD", DateTime.Now.Date, DateTime.Now, DateTime.Today, contato02);
            Compromisso compromisso03 = new Compromisso("Reunião", "Casa", DateTime.Now.Date, DateTime.Now, DateTime.Today, contato03);

            repositorioCompromisso.Inserir(compromisso01);
            repositorioCompromisso.Inserir(compromisso02);
            repositorioCompromisso.Inserir(compromisso03);

            Tarefa t1 = new Tarefa(1, "Preparar Apresentação 1", PrioridadeTarefaEnum.Alta, DateTime.Now, DateTime.Now);

            t1.AdicionarItem(new ItemTarefa("a"));
            t1.AdicionarItem(new ItemTarefa("b"));
            t1.AdicionarItem(new ItemTarefa("c"));

            Tarefa t2 = new Tarefa(2, "Preparar Apresentação 2 ", PrioridadeTarefaEnum.Alta, DateTime.Now, DateTime.Now);

            t2.AdicionarItem(new ItemTarefa("a"));
            t2.AdicionarItem(new ItemTarefa("b"));
            t2.AdicionarItem(new ItemTarefa("c"));


            Tarefa t3 = new Tarefa(3, "Preparar Apresentação 3 ", PrioridadeTarefaEnum.Baixa, DateTime.Now, DateTime.Now);

            t3.AdicionarItem(new ItemTarefa("a"));
            t3.AdicionarItem(new ItemTarefa("b"));
            t3.AdicionarItem(new ItemTarefa("c"));

            repositorioTarefa.Inserir(t1);
            repositorioTarefa.Inserir(t2);
            repositorioTarefa.Inserir(t3);

            Categorias categoria01 = new Categorias(1, "ANIVERSÁRIO");
            Categorias categoria02 = new Categorias(2, "CHURRASCO");
            Categorias categoria03 = new Categorias(3, "FESTA");

            repositorioCategorias.Inserir(categoria01);
            repositorioCategorias.Inserir(categoria02);
            repositorioCategorias.Inserir(categoria03);


            Despesas despesas01 = new Despesas(1, "Churras", "400", DateTime.Now, PagamentoCategoriaEnum.Dinheiro, categoria01);
            Despesas despesas02 = new Despesas(1, "Consertar carro", "1100", DateTime.Now, PagamentoCategoriaEnum.CartaoCredito, categoria02);
            Despesas despesas03 = new Despesas(1, "Festa", "500", DateTime.Now, PagamentoCategoriaEnum.CartaoDebito, categoria03);

            repositorioDespesa.Inserir(despesas01);
            repositorioDespesa.Inserir(despesas02);
            repositorioDespesa.Inserir(despesas03);
        }

       
    }
}
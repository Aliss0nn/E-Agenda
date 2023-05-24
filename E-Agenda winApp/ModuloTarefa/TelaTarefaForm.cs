namespace E_Agenda_winApp.ModuloTarefa
{
    public partial class TelaTarefa : Form
    {
        private Tarefa tarefa;

        public TelaTarefa()
        {
            InitializeComponent();
            ConfigurarData(dtInicio);
            ConfigurarData(dtFinal);
            CarregarPrioridades();
        }

        public void TirarDatas()
        {
            dtInicio.Enabled = false;
            dtFinal.Enabled = false;
            lbFinal.Enabled = false;
            lbInicio.Enabled = false;
        }


        private void CarregarPrioridades()
        {
            PrioridadeTarefaEnum[] prioridades = Enum.GetValues<PrioridadeTarefaEnum>();

            foreach (PrioridadeTarefaEnum prioridade in prioridades)
            {
                cmbPrioridade.Items.Add(prioridade);
            }
        }

        public Tarefa Tarefa
        {
            set
            {
                txtId.Text = value.id.ToString();
                txtNomeDaTarefa.Text = value.nome;
                dtInicio.Value = value.dataInicial;
                dtFinal.Value = value.dataFinal;

            }
            get
            {
                return tarefa;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            string nome = txtNomeDaTarefa.Text;
            PrioridadeTarefaEnum prioridade = (PrioridadeTarefaEnum)cmbPrioridade.SelectedItem;
            DateTime dataInicial = dtInicio.Value;
            DateTime dataFinal = dtFinal.Value;


            tarefa = new Tarefa(id,nome, prioridade, dataFinal, dataInicial);
        }

        private void ConfigurarData(DateTimePicker data)
        {
            data.Format = DateTimePickerFormat.Custom;
            data.CustomFormat = "HH:mm";
            data.ShowUpDown = true;
        }

        public void ConfigurarTela(Tarefa tarefaSelecionada)
        {
            txtId.Text = tarefaSelecionada.id.ToString();

            txtNomeDaTarefa.Text = tarefaSelecionada.nome;

            cmbPrioridade.SelectedItem = tarefaSelecionada.prioridade;

            dtInicio.Value = tarefaSelecionada.dataInicial;

            dtFinal.Value = tarefaSelecionada.dataFinal;
        }

        public Tarefa ObterTarefa()
        {
            int id = Convert.ToInt32(txtId.Text);

            string titulo = txtNomeDaTarefa.Text;

            PrioridadeTarefaEnum prioridade = (PrioridadeTarefaEnum)cmbPrioridade.SelectedItem;

            DateTime dataCriacao = dtInicio.Value;
            DateTime dataFinal = dtFinal.Value;

            return new Tarefa(id,titulo, prioridade, dataCriacao, dataFinal);
        }
    }
}

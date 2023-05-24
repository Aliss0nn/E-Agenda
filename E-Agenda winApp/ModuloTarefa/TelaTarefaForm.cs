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
            CarregarTarefas();
        }

        public void TirarDatas()
        {
            dtInicio.Enabled = false;
            dtFinal.Enabled = false;
            lbFinal.Enabled = false;
            lbInicio.Enabled = false;
        }


        private void CarregarTarefas()
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
            string nome = txtNomeDaTarefa.Text;
            PrioridadeTarefaEnum prioridade = (PrioridadeTarefaEnum)cmbPrioridade.SelectedItem;
            DateTime dataInicial = dtInicio.Value;
            DateTime dataFinal = dtFinal.Value;


            tarefa = new Tarefa(nome, prioridade, dataFinal, dataInicial);
        }

        private void ConfigurarData(DateTimePicker data)
        {
            data.Format = DateTimePickerFormat.Custom;
            data.CustomFormat = "HH:mm";
            data.ShowUpDown = true;
        }
    }
}

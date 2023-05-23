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
            string prioridade = txtPrioridade.Text;
            DateTime dataInicial = dtInicio.Value;
            DateTime dataFinal = dtFinal.Value;


            tarefa = new Tarefa(nome,prioridade,dataFinal,dataInicial);
        }

        private void ConfigurarData(DateTimePicker data)
        {
            data.Format = DateTimePickerFormat.Custom;
            data.CustomFormat = "HH:mm";
            data.ShowUpDown = true;
        }
    }
}

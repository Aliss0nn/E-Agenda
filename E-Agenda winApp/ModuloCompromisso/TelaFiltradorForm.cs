namespace E_Agenda_winApp.ModuloCompromisso
{
    public partial class TelaFiltradorForm : Form
    {
        public DateTime DataInicial
        {
            get
            {
                return dateTimeInicio.Value;
            }
        }

        public DateTime DataFinal
        {
            get
            {
                return dateTimeFinal.Value;
            }
        }


        public TelaFiltradorForm()
        {
            InitializeComponent();
            this.dateTimeInicio.MinDate = DateTime.Now;
            this.dateTimeFinal.MinDate = DateTime.Now;
        }

        public StatusCompromissosEnum ObterStatus()
        {
            if (rdbFuturos.Checked)
            {
                return StatusCompromissosEnum.Futuros;
            }
            else if (rdbPassado.Checked)
            {
                return StatusCompromissosEnum.Passados;
            }
            else
            {
                return StatusCompromissosEnum.Todos;
            }
        }

        public DateTime ObterDataInicio()
        {
            return dateTimeInicio.Value;
        }

        public DateTime ObterDataFinal()
        {
            return dateTimeFinal.Value;
        }

        private void rdbFuturos_CheckedChanged(object sender, EventArgs e)
        {
            dateTimeInicio.Enabled = !dateTimeInicio.Enabled;
            dateTimeFinal.Enabled = !dateTimeFinal.Enabled;
        }

      
    }
}

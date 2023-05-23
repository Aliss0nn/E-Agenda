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
    
    }
}

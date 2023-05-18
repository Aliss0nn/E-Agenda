using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

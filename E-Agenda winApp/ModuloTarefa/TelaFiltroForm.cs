using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Agenda_winApp.ModuloTarefa
{
    public partial class TelaFiltroForm : Form
    {
        public TelaFiltroForm()
        {
            InitializeComponent();
        }

        public StatusTarefaEnum ObterFiltroTarefa()
        {
            if (rdbConcluidas.Checked == true)
                return StatusTarefaEnum.Concluidas;

            else if (rdbPendentes.Checked == true)
                return StatusTarefaEnum.Pendentes;

            return StatusTarefaEnum.Todos;
        }
    }
}

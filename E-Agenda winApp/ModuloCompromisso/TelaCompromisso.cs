using E_Agenda_winApp.ModuloContato;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace E_Agenda_winApp.ModuloCompromisso
{
    public partial class TelaCompromisso : Form
    {
        private Compromisso compromisso;

        public TelaCompromisso()
        {
            InitializeComponent();
        }
        public Compromisso Compromisso
        {
            set
            {
                txtId.Text = value.id.ToString();
                txtAssunto.Text = value.assunto;
            }
            get
            {
                return compromisso;
            }
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string assunto = txtAssunto.Text;
            string local = txtLocal.Text;
            string data = txtData.Text;
            string horaFinal = txtFinal.Text;
            string horaInicial = txtInicio.Text;

            compromisso = new Compromisso(assunto,local,data,horaInicial,horaFinal);
        }
    }
}

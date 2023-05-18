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

        public List<Contato> contatos;

        public TelaCompromisso()
        {
            InitializeComponent();
            ConfigurarData(dateTimeInicial);
            ConfigurarData(dateTimeFinal);

        }

        public Compromisso Compromisso
        {
            set
            {
                txtId.Text = value.id.ToString();
                txtAssunto.Text = value.assunto;
                txtLocal.Text = value.local;
                dateTimeInicial.Value = value.horaFinal;
                dateTimeFinal.Value = value.horaFinal;
                dateTimeData.Value = value.data;
            }
            get
            {
                return compromisso;
            }
        }

        private void ConfigurarData(DateTimePicker data)
        {
            data.Format = DateTimePickerFormat.Custom;
            data.CustomFormat = "HH:mm";
            data.ShowUpDown = true;
        }

        public void ObterContatos(List<Contato> contatos)
        {
            this.contatos = contatos;

            foreach(Contato c in contatos)
            {
                CbContatos.Items.Add(c);
            }
        }

        public void btnSalvarCompromisso_Click(object sender, EventArgs e)
        {
            string assunto = txtAssunto.Text;
            string local = txtLocal.Text;
            DateTime data = dateTimeData.Value;
            DateTime horaInicial = dateTimeInicial.Value;
            DateTime horaFinal = dateTimeFinal.Value;

            Contato contato = contatos.Find(x => x.nome == CbContatos.SelectedItem);

            compromisso = new Compromisso(assunto, local, data, horaInicial, horaFinal, contato);
        }
    }
}

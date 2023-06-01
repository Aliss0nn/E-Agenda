using E_Agenda_winApp.Compartilhado;
using E_Agenda_winApp.ModuloContato;

namespace E_Agenda_winApp.ModuloCompromisso
{
    public partial class TabelaCompromissoControl : UserControl
    {
        public TabelaCompromissoControl()
        {
            InitializeComponent();

            ConfigurarColunas();

            gridCompromisso.ConfigurarGridZebrado();

            gridCompromisso.ConfigurarGridSomenteLeitura();
        }
        private void ConfigurarColunas()
        {
            DataGridViewColumn[] colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn()
                {
                    Name = "id",
                    HeaderText = "Id"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "assunto",
                    HeaderText = "Assunto"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "contato",
                    HeaderText = "Contato"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "data",
                    HeaderText = "Data"
                }
            };

            gridCompromisso.Columns.AddRange(colunas);
        }

        public void AtualizarRegistros(List<Compromisso> compromissos)
        {
            gridCompromisso.Rows.Clear();

            foreach (Compromisso compromisso in compromissos)
            {
                if (compromisso.contato == null)
                {
                    compromisso.contato = new Contato("teste","teste","teste","teste","teste");

                    gridCompromisso.Rows.Add(compromisso.id, compromisso.assunto, compromisso.contato?.nome, compromisso.data);
                }
            }
        }

        public int ObterIdSelecionado()
        {
            int id;

            try
            {
                id = Convert.ToInt32(gridCompromisso.SelectedRows[0].Cells["id"].Value);
            }
            catch
            {
                id = -1;
            }

            return id;
        }
    }
}

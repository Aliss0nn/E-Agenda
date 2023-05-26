using E_Agenda_winApp.Compartilhado;

namespace E_Agenda_winApp.ModuloDespesasECategorias
{
    public partial class TabelaDespesaControl : UserControl
    {
        public TabelaDespesaControl()
        {
            InitializeComponent();

            ConfigurarColunas();
            
            gridDespesa.ConfigurarGridSomenteLeitura();

            gridDespesa.ConfigurarGridZebrado();
        }

        public void AtualizarRegistros(List<Despesas> despesas)
        {
            gridDespesa.Rows.Clear();

            foreach (Despesas despesa in despesas)
            {
                gridDespesa.Rows.Add(despesa.id,despesa.descricao,despesa.valor,despesa.data,despesa.pagamento);
            }
        }
        private void ConfigurarColunas()
        {
            DataGridViewColumn[] colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn()
                {
                    Name = "id",
                    HeaderText = "Número"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "descricao",
                    HeaderText = "Descrição"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "valor",
                    HeaderText = "Valor"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "data",
                    HeaderText = "Data"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "pagamento",
                    HeaderText = "Forma de Pagamento"
                },             
            };

            gridDespesa.Columns.AddRange(colunas);
        }

        public int ObterIdSelecionado()
        {
            int id;

            try
            {
                id = Convert.ToInt32(gridDespesa.SelectedRows[0].Cells["id"].Value);
            }
            catch
            {
                id = -1;
            }

            return id;
        }
    }
}

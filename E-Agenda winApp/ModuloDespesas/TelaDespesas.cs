using E_Agenda_winApp.Compartilhado;
using E_Agenda_winApp.ModuloCategorias;
using E_Agenda_winApp.ModuloContato;
using E_Agenda_winApp.ModuloTarefa;

namespace E_Agenda_winApp.ModuloDespesasECategorias
{
    public partial class TelaDespesas : Form
    {
        private Despesas despesas;
        private List<Categorias> categorias;


        public TelaDespesas()
        {
            InitializeComponent();

            this.ConfigurarDialog();
            CarregarPagamentos();        
        }

        public Despesas Despesas
        {
            set
            {
                txtId.Text = value.id.ToString();
                txtDescricao.Text = value.descricao;
                txtValor.Text = value.valor.ToString();

            }
            get
            {
                return despesas;
            }
        }

        public void ConfigurarTela(Despesas despesa)
        {
            txtId.Text = despesa.id.ToString();
            txtDescricao.Text = despesa.descricao;
            txtValor.Text = (despesa.valor.ToString());
        }

        private void CarregarPagamentos()
        {
            PagamentoCategoriaEnum[] pagamentos = Enum.GetValues<PagamentoCategoriaEnum>();

            foreach (PagamentoCategoriaEnum pagamento in pagamentos)
            {
                cbPagamento.Items.Add(pagamento);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(txtId.Text);
            string descricao = txtDescricao.Text;
            string valor = txtValor.Text;
            PagamentoCategoriaEnum pagamento = (PagamentoCategoriaEnum)cbPagamento.SelectedItem;
            DateTime data = dataInicio.Value;
          
            Categorias categoria = categorias.Find(x => x.titulo == cbCategorias.SelectedItem);

            despesas = new Despesas(id, descricao, valor, data, pagamento,categoria);

            string[] erros = despesas.Validar();

            if (erros.Length > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }
        public void ObterCategorias(List<Categorias> categoria)
        {
            this.categorias = categoria;

            foreach (Categorias c in categorias)
            {            
                cbCategorias.Items.Add(c);
            }
        }
       
    }
}

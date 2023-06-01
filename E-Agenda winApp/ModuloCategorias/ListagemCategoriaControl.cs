namespace E_Agenda_winApp.ModuloCategorias
{
    public partial class ListagemCategoriaControl : UserControl
    {
        public ListagemCategoriaControl()
        {
            InitializeComponent();
        }
        public void AtualizarRegistros(List<Categorias> categorias)
        {
            listCategorias.Items.Clear();

            foreach (Categorias item in categorias)
            {
                listCategorias.Items.Add(item);
            }

        }

        public Categorias ObterCategoriaSelecionada()
        {
            return (Categorias)listCategorias.SelectedItem;
        }
    }
}

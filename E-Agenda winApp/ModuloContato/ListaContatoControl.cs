namespace E_Agenda_winApp.ModuloContato
{
    public partial class ListagemDeContatoControl : UserControl
    {            
        public ListagemDeContatoControl()
        {
            InitializeComponent();
                     
        }
        public void AtualizarRegistros(List<Contato> contatos)
        {
            listDeContato.Items.Clear();
            
            foreach (Contato item in contatos)
            {
                listDeContato.Items.Add(item);
            }
        }
       
        public Contato ObterContatoSelecionado()
        {
            return (Contato)listDeContato.SelectedItem;
        }
    }

}

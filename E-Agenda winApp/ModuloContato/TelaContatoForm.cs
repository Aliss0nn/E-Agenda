namespace E_Agenda_winApp.ModuloContato
{
    public partial class TelaContatoForm : Form
    {
        private Contato contato;
       
        public TelaContatoForm()
        {           
            InitializeComponent();
        }

        public Contato Contato
        {
            set
            {
                txtId.Text = value.id.ToString();
                txtNome.Text = value.nome;
                txtTelefone.Text = value.telefone;
                txtCargo.Text = value.cargo;
                txtEmail.Text = value.email;
                txtEmpresa.Text = value.empresa;
            }
            get
            {
                return contato;
            }
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {          
            string nome = txtNome.Text;
            string cargo = txtCargo.Text;
            string empresa = txtEmpresa.Text;
            string email = txtEmail.Text;
            string telefone = txtTelefone.Text;

            contato = new Contato(telefone, email, cargo, nome, empresa);
         
            string[] erros = contato.Validar();

            if( erros.Length > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }

        }

       
    }
}

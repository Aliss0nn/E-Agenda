using E_Agenda_winApp.Compartilhado;

namespace E_Agenda_winApp.ModuloContato
{
    public class ControladorDeContato : ControladorBase
    {
        private RepositorioContato repositorioContato;
        private ListagemDeContatoControl listagemDeContato;

        public ControladorDeContato(RepositorioContato repositorioContato) 
        {
            this.repositorioContato = repositorioContato;
        }
      
        public override string ToolTipInserir { get { return "Inserir novo Contato"; } }

        public override string ToolTipEditar { get { return "Editar Contato Existente"; } }

        public override string ToolTipExcluir { get { return "Excluir Contato Existente"; } }

        public override string ToolTipFiltrar { get { return "Filtrar Contato Existente"; } }

        public override string ToolTipAdicionaritens { get { return "Adicionar Itens"; } }

        public override void Inserir()
        {
            TelaContatoForm telaContatoForm = new TelaContatoForm();

            DialogResult opcaoEscolhida = telaContatoForm.ShowDialog();

            if(opcaoEscolhida == DialogResult.OK)
            {
                Contato contato = telaContatoForm.Contato;

                repositorioContato.Inserir(contato);

                CarregarContatos();
            }
        }
        public override void Editar()
        {
            TelaContatoForm telaContatoForm = new TelaContatoForm();
           
            telaContatoForm.Contato = listagemDeContato.ObterContatoSelecionado();

            DialogResult opcaoEscolhida = telaContatoForm.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Contato contato = telaContatoForm.Contato;

                repositorioContato.Editar(contato);

                CarregarContatos();
            }
        }

        public override void Excluir()
        {
            Contato contato = listagemDeContato.ObterContatoSelecionado();

            DialogResult opcaoEscolhida = MessageBox.Show("Deseja Excluir o contato" + contato.nome, "Excluir Contatos",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioContato.Excluir(contato);

                CarregarContatos();
            }
        }

        private void CarregarContatos()
        {
            List<Contato> contatos = repositorioContato.SelecionarTodos();

            listagemDeContato.AtualizarRegistros(contatos);
        }

        public override UserControl ObterListagem()
        {
           if(listagemDeContato == null)
           {
                listagemDeContato = new ListagemDeContatoControl();
           }

            CarregarContatos();

            return listagemDeContato;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Contatos";
        }

        public override void AdicionarItens()
        {
            throw new NotImplementedException();
        }
    }
}

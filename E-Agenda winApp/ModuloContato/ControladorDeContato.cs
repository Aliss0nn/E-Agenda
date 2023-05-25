using E_Agenda_winApp.Compartilhado;
using E_Agenda_winApp.ModuloTarefa;

namespace E_Agenda_winApp.ModuloContato
{
    public class ControladorDeContato : ControladorBase
    {
        private RepositorioContato repositorioContato;
        private TabelaContatoControl tabelaContato;

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
            Contato contato = ObterContatoSelecionado();

            if (contato == null)
            {
                MessageBox.Show("Selecione um Contato Primeiro!", "Edição De Contatos",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                return;
            }

            TelaContatoForm telaContatoForm = new TelaContatoForm();
          
            telaContatoForm.ConfigurarTela(contato);

            DialogResult opcaoEscolhida = telaContatoForm.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                contato = telaContatoForm.Contato;

                repositorioContato.Editar(contato);

                CarregarContatos();
            }
        }

        private Contato ObterContatoSelecionado()
        {
            int id = tabelaContato.ObterIdSelecionado();

            return repositorioContato.SelecionarPorId(id);
        }

        public override void Excluir()
        {
            Contato contato = ObterContatoSelecionado();

            if(contato == null )
            {
                MessageBox.Show("Selecione um Contato Primeiro!", "Exclusão De Contatos",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

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

            tabelaContato.AtualizarRegistros(contatos);
        }

        public override UserControl ObterListagem()
        {
           if(tabelaContato == null)
           {
                tabelaContato = new TabelaContatoControl();
           }

            CarregarContatos();

            return tabelaContato;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Contatos";
        }     
    }
}

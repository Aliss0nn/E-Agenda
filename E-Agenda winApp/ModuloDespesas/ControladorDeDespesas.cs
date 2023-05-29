using E_Agenda_winApp.Compartilhado;
using E_Agenda_winApp.ModuloCategorias;

namespace E_Agenda_winApp.ModuloDespesasECategorias
{
    public class ControladorDeDespesas : ControladorBase
    {
        private TabelaDespesaControl tabelaDespesa;
        private RepositorioDespesa repositorioDespesa;
        private RepositorioCategorias repositorioCategorias;

        public ControladorDeDespesas(TabelaDespesaControl tabelaDespesa, 
            RepositorioDespesa repositorioDespesa,
            RepositorioCategorias repositorioCategorias)
        {
            this.tabelaDespesa = tabelaDespesa;
            this.repositorioDespesa = repositorioDespesa;
            this.repositorioCategorias = repositorioCategorias;
        }

        public override string ToolTipInserir { get { return "Inserir nova Despesa"; } }

        public override string ToolTipEditar { get { return "Editar Despesa Existente"; } }

        public override string ToolTipExcluir { get { return "Excluir Despesa Existente"; } }

        public override void Inserir()
        {
            TelaDespesas telaDespesas = new TelaDespesas();
        
            telaDespesas.ObterCategorias(this.repositorioCategorias.SelecionarTodos());
            
            DialogResult opcaoEscolhida = telaDespesas.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Despesas despesas = telaDespesas.Despesas;

                repositorioDespesa.Inserir(despesas);

                CarregarDespesas();
            }
        }

        public override void Editar()
        {
            Despesas despesa = ObterDespesaSelecionada();

            if (despesa == null)
            {
                MessageBox.Show("Selecione uma Despesa Primeiro!", "Edição De Despesas",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            TelaDespesas telaDespesas = new TelaDespesas();
            
            telaDespesas.ObterCategorias(this.repositorioCategorias.SelecionarTodos());

            telaDespesas.ConfigurarTela(despesa);

            DialogResult opcaoEscolhida = telaDespesas.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                despesa = telaDespesas.Despesas;

                repositorioDespesa.Editar(despesa);

                CarregarDespesas();
            }
        }

        public Despesas ObterDespesaSelecionada()
        {
            int id = tabelaDespesa.ObterIdSelecionado();

            return repositorioDespesa.SelecionarPorId(id);
        }

        public override void Excluir()
        {
            Despesas despesa = ObterDespesaSelecionada();

            if (despesa == null)
            {
                MessageBox.Show("Selecione uma Despesa Primeiro!", "Exclusão De Despesas",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show("Deseja Excluir a Despesa" + despesa.id, "Excluir Despesas",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioDespesa.Excluir(despesa);

                CarregarDespesas();
            }
        }
    
        public override UserControl ObterListagem()
        {
            if (tabelaDespesa == null)
            {
                tabelaDespesa = new TabelaDespesaControl();
            }

            CarregarDespesas();

            return tabelaDespesa;
        }

        private void CarregarDespesas()
        {
            List<Despesas> despesas = repositorioDespesa.SelecionarTodos();

            tabelaDespesa.AtualizarRegistros(despesas);
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Despesas";
        }
    }
}

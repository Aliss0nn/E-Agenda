using E_Agenda_winApp.Compartilhado;
using E_Agenda_winApp.ModuloCompromisso;
using E_Agenda_winApp.ModuloDespesasECategorias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Agenda_winApp.ModuloCategorias
{
    public class ControladorCategorias : ControladorBase
    {
        private TabelaCategoriasControl tabelaCategoria;
        private IRepositorioCategorias repositorioCategorias;

        public ControladorCategorias(IRepositorioCategorias repositorioCategorias)
        {           
            this.repositorioCategorias = repositorioCategorias;
        }

        public override string ToolTipInserir { get { return "Inserir nova Categoria"; } }

        public override string ToolTipEditar { get { return "Editar Categoria Existente"; } }

        public override string ToolTipExcluir { get { return "Excluir Categoria Existente"; } }

        public override void Inserir()
        {
            TelaCategorias telaCategorias = new TelaCategorias();
           
            DialogResult opcaoEscolhida = telaCategorias.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Categorias categoria = telaCategorias.Categorias;

                repositorioCategorias.Inserir(categoria);

                CarregarCategorias();
            }
        }

        public override void Editar()
        {
            Categorias categoria = ObterCategoriaSelecionada();

            if (categoria == null)
            {
                MessageBox.Show("Selecione uma Categoria Primeiro!", "Edição De Categorias",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            TelaCategorias telaCategorias = new TelaCategorias();

            telaCategorias.ConfigurarTela(categoria);

            DialogResult opcaoEscolhida = telaCategorias.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                categoria = telaCategorias.Categorias;

                repositorioCategorias.Editar(categoria.id,categoria);

                CarregarCategorias();
            }
        }

        private Categorias ObterCategoriaSelecionada()
        {
            int id = tabelaCategoria.ObterIdSelecionado();

            return repositorioCategorias.SelecionarPorId(id);
        }

        public override void Excluir()
        {
            Categorias categorias = ObterCategoriaSelecionada();

            if (categorias == null)
            {
                MessageBox.Show("Selecione uma Categoria Primeiro!", "Exclusão De Categorias",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show("Deseja Excluir a Categoria" + categorias.id, "Excluir Categorias",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioCategorias.Excluir(categorias);

                CarregarCategorias();
            }
        }
    
        public override UserControl ObterListagem()
        {
            if (tabelaCategoria == null)
            {
                tabelaCategoria = new TabelaCategoriasControl();
            }

            CarregarCategorias();

            return tabelaCategoria;
        }

        private void CarregarCategorias()
        {
            List<Categorias> categorias = repositorioCategorias.SelecionarTodos();

            tabelaCategoria.AtualizarRegistros(categorias);
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Categorias";
        }
    }
}

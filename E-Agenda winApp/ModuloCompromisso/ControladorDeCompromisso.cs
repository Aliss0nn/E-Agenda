using E_Agenda_winApp.Compartilhado;
using E_Agenda_winApp.ModuloContato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Agenda_winApp.ModuloCompromisso
{
    public class ControladorDeCompromisso : ControladorBase, Filtrador
    {
         private RepositorioCompromisso repositorioCompromisso;
         private ListaCompromissoControl listaCompromisso;
         private RepositorioContato repositorioContato;

        public ControladorDeCompromisso(RepositorioCompromisso repositorioCompromisso, RepositorioContato repositorioContato)
        {
            this.repositorioCompromisso = repositorioCompromisso;
            this.repositorioContato = repositorioContato;
        }

        public override string ToolTipInserir { get { return "Inserir novo Compromisso"; } }

        public override string ToolTipEditar { get { return "Editar Compromisso Existente"; } }

        public override string ToolTipExcluir { get { return "Excluir Compromisso Existente"; } }

        public override string ToolTipFiltrar { get { return "Filtrar Compromisso Existente"; } }

        public override string ToolTipAdicionaritens => throw new NotImplementedException();

        public override void Inserir()
        {         
            TelaCompromisso telaCompromisso = new TelaCompromisso();
          
            telaCompromisso.ObterContatos(this.repositorioContato.SelecionarTodos());
            DialogResult opcaoEscolhida = telaCompromisso.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Compromisso compromisso = telaCompromisso.Compromisso;

                repositorioCompromisso.Inserir(compromisso);

                CarregarCompromissos();
            }
        }

        private void CarregarCompromissos()
        {
            List<Compromisso> compromissos = repositorioCompromisso.SelecionarTodos();
      
            listaCompromisso.AtualizarRegistros(compromissos);
        }

        public override void Editar()
        {           
            TelaCompromisso telaCompromisso = new TelaCompromisso();
            telaCompromisso.ObterContatos(this.repositorioContato.SelecionarTodos());

            telaCompromisso.Compromisso = listaCompromisso.ObterCompromissoSelecionado();

            DialogResult opcaoEscolhida = telaCompromisso.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Compromisso compromisso = telaCompromisso.Compromisso;

                repositorioCompromisso.Editar(compromisso);

                CarregarCompromissos();
            }
        }

        public override void Excluir()
        {
            Compromisso compromisso = listaCompromisso.ObterCompromissoSelecionado();

            DialogResult opcaoEscolhida = MessageBox.Show("Deseja Excluir o Compromisso" + compromisso.assunto, "Excluir Compromisso",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioCompromisso.Excluir(compromisso);

                CarregarCompromissos();
            }
        }

      
        public override UserControl ObterListagem()
        {
           if (listaCompromisso == null)
           {
                listaCompromisso = new ListaCompromissoControl();
           }

            CarregarCompromissos();

            return listaCompromisso;

        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Compromissos";
        }

        public void Filtrar()
        {
            if (listaCompromisso == null)
                listaCompromisso = new ListaCompromissoControl();

           TelaFiltradorForm telaFiltrador = new TelaFiltradorForm();

            DialogResult opcaoEscolhida = telaFiltrador.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Predicate<Compromisso> periodo = c => c.data > telaFiltrador.DataInicial
                && c.data <= telaFiltrador.DataFinal;

                List<Compromisso> compromissos = repositorioCompromisso.SelecionarAlternativa(periodo);

                listaCompromisso.AtualizarRegistros(compromissos);
            }
        }

        public override void AdicionarItens()
        {
            throw new NotImplementedException();
        }
    }
}

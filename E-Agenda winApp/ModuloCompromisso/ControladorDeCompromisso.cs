﻿using E_Agenda_winApp.Compartilhado;
using E_Agenda_winApp.ModuloContato;

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

        public override string ToolTipAdicionaritens { get { return "Adicionar Itens"; } }

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
        private void CarregarCompromissos(List<Compromisso> compromissos)
        {
            listaCompromisso.AtualizarRegistros(compromissos);
        }


        private void CarregarCompromissos()
        {
            List<Compromisso> compromissos = repositorioCompromisso.SelecionarTodos();
      
            listaCompromisso.AtualizarRegistros(compromissos);
        }

        public override void Editar()
        {           
            Compromisso compromisso = listaCompromisso.ObterCompromissoSelecionado();

            if (compromisso == null)
            {
                MessageBox.Show("Selecione um Compromisso Primeiro!", "Edição De Compromissos",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            TelaCompromisso telaCompromisso = new TelaCompromisso();
            telaCompromisso.ObterContatos(this.repositorioContato.SelecionarTodos());

            telaCompromisso.Compromisso = listaCompromisso.ObterCompromissoSelecionado();

            DialogResult opcaoEscolhida = telaCompromisso.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                compromisso = telaCompromisso.Compromisso;

                repositorioCompromisso.Editar(compromisso);

                CarregarCompromissos();
            }
        }

        public override void Excluir()
        {
            Compromisso compromisso = listaCompromisso.ObterCompromissoSelecionado();

            if(compromisso == null)
            {
                MessageBox.Show("Selecione um Compromisso Primeiro!", "Exclusão De Compromissos",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

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

            TelaFiltradorForm telaFiltro = new TelaFiltradorForm();
            DialogResult opcaoEscolhida = telaFiltro.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                StatusCompromissosEnum status = telaFiltro.ObterStatus();
                List<Compromisso> compromissos = null;

                if (status == StatusCompromissosEnum.Todos)
                {
                    compromissos = repositorioCompromisso.SelecionarTodos();
                }

                else if (status == StatusCompromissosEnum.Passados)
                {
                    compromissos = repositorioCompromisso.SelecionarCompromissosPassados(DateTime.Now);
                }
                else if (status == StatusCompromissosEnum.Futuros)
                {
                    DateTime dataInicio = telaFiltro.ObterDataInicio();
                    DateTime dataFinal = telaFiltro.ObterDataFinal();

                    compromissos = repositorioCompromisso.SelecionarCompromissosFuturos(dataInicio, dataFinal);
                }

                CarregarCompromissos(compromissos);

                TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {compromissos.Count} compromissos");
            }
        }       
    }
}

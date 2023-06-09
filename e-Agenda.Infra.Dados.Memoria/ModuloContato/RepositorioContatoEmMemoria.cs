﻿using E_Agenda_winApp.Compartilhado;
using E_Agenda_winApp.ModuloTarefa;

namespace E_Agenda_winApp.ModuloContato
{
    public class RepositorioContatoEmMemoria : RepositorioBaseEmMemoria<Contato>
    {
        List<Contato> contatos = new List<Contato>();

        private static int contador;
        public void Inserir(Contato contato)
        {
            contador++;
            contato.id = contador;
            contatos.Add(contato);
        }

        public List<Contato> SelecionarTodos()
        {
            return contatos;
        }

        public void Editar(Contato contato)
        {
            Contato contatoSelecionado = SelecionarPorId(contato.id);

            contatoSelecionado.email = contato.email;
            contatoSelecionado.nome = contato.nome;
            contatoSelecionado.cargo = contato.cargo;
            contatoSelecionado.empresa = contato.empresa;
            contatoSelecionado.telefone = contato.telefone;
        }

        public Contato SelecionarPorId(int id)
        {
            return contatos.FirstOrDefault(x => id == id);
        }

        public void Excluir(Contato contato)
        {
            contatos.Remove(contato);
        }
   
    }
}



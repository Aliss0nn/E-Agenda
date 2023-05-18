using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

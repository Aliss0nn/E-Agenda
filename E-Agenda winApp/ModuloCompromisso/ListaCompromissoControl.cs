﻿using E_Agenda_winApp.ModuloContato;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Agenda_winApp.ModuloCompromisso
{
    public partial class ListaCompromissoControl : UserControl
    {
        public ListaCompromissoControl()
        {
            InitializeComponent();
        }

        public void AtualizarRegistros(List<Compromisso> compromissos)
        {
            listCompromisso.Items.Clear();

            foreach (Compromisso compromisso in compromissos)
            {
                listCompromisso.Items.Add(compromisso);
            }
        }

        public Compromisso ObterCompromissoSelecionado()
        {
            return (Compromisso)listCompromisso.SelectedItem;
        }
            
    }
}

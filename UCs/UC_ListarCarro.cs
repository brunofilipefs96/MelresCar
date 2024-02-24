using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automobile
{
    
    public partial class UC_ListarCarro : UserControl
    {
        ListaClasses listaClasses = new ListaClasses();
        string selecao;

        public string classeCarroSelecionada(string selecao)
        {
            return selecao;
        }
        public UC_ListarCarro()
        {
            InitializeComponent();
        }
        private void ACarros_Click(object sender, EventArgs e)
        {
            listaClasses.Show();
            selecao = "a";
            classeCarroSelecionada(selecao);
        }

        private void BCarros_Click(object sender, EventArgs e)
        {
            listaClasses.Show();
            selecao = "b";
            classeCarroSelecionada(selecao);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Automobile.Forms;

namespace Automobile
{
    public partial class UC_Reservas : UserControl
    {
        public UC_Reservas()
        {
            InitializeComponent();
        }

        private void buttonCriarReserva_Click(object sender, EventArgs e)
        {
            MenuAdicionarReserva menuAdicionarReserva = new MenuAdicionarReserva();
            menuAdicionarReserva.Show();
        }

        private void buttonVerReserva_Click(object sender, EventArgs e)
        {
            MenuMostrarReserva menuMostrarReserva = new MenuMostrarReserva();
            menuMostrarReserva.Show();
        }

        private void buttonLucroDatas_Click(object sender, EventArgs e)
        {
            MenuMostrarLucro menuMostrarLucro = new MenuMostrarLucro();
            menuMostrarLucro.Show();
        }
    }
}

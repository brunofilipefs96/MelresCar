using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automobile
{
    internal static class Program
    {
        public static Empresa melresCar = new Empresa();
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            melresCar.CarregarFicheiroCSV("veiculos");
            melresCar.CarregarFicheiroCSV("clientes");
            melresCar.CarregarFicheiroCSV("reservas");
            melresCar.CarregarFicheiroCSV("funcionarios");

            Application.Run(new MenuLogin());



        }
    }
}

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
        private static DateTime _horaDoSistema;
        private static int DaysAdded;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            _horaDoSistema = DateTime.Now;

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            melresCar.CarregarFicheiroCSV("veiculos");
            melresCar.CarregarFicheiroCSV("clientes");
            melresCar.CarregarFicheiroCSV("reservas");
            melresCar.CarregarFicheiroCSV("funcionarios");

            Application.Run(new MenuLogin());
        }
        public static DateTime DataHoraDoSistema()
        {
            return _horaDoSistema;
        }
        public static void DataHoraDoSistema(DateTime hora)
        {
            _horaDoSistema = hora;
        }
        public static void AdicionarDia()
        {
            _horaDoSistema = _horaDoSistema.AddDays(1);
            DaysAdded++;
        }
        public static int DiasAdicionados()
        {
            return DaysAdded;
        }
        public static void AdicionarSegundos()
        {
            _horaDoSistema = _horaDoSistema.AddSeconds(1);
        }

    }
}

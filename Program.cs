using System;
using System.Collections.Generic;
using System.Linq;
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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Carro carro = new Carro();
            Mota mota = new Mota();

            Funcionario manuel = new Funcionario("Manuel","132132132","Rua da Quinta", "manuel@manual.pt","911111111",1,"manuel","qwerty",1000);

            melresCar.InserirVeiculo(carro);
            melresCar.InserirVeiculo(mota);

            melresCar.escreverFicheiroCSV("veiculos");

            Application.Run(new MenuLogin());

            


        }
    }
}

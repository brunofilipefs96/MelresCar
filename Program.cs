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
            melresCar.InserirVeiculo(carro);
            melresCar.InserirVeiculo(mota);

            Funcionario manuel = new Funcionario("Manuel", "132132132", "Rua da Quinta", "manuel@manual.pt", "911111111", 1, "manuel", "qwerty", 1000);
            melresCar.InserirFuncionario(manuel);

            Cliente cliente = new Cliente("Bruno","111111111","Rua do Bruno","bruno@bruno.pt","911111111");
            melresCar.InserirCliente(cliente);

            melresCar.EscreverFicheiroCSV("veiculos");
            melresCar.EscreverFicheiroCSV("funcionarios");
            melresCar.EscreverFicheiroCSV("clientes");
            melresCar.EscreverFicheiroCSV("reservas");


            Application.Run(new MenuLogin());

        }
    }
}

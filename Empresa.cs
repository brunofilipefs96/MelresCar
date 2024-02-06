using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobile
{
    internal class Empresa
    {
        private List<Veiculo> _veiculos;
        private List<Cliente> _clientes;
        private List<Funcionario> _funcionario;
        private List<Reserva> _reservas;

        public List<Veiculo> Veiculos
        {
            get { return _veiculos; }
            set { _veiculos = value; }
        }
        public List<Cliente> Clientes
        {
            get { return _clientes; }
            set { _clientes = value; }
        }
        public List<Funcionario> Funcionario
        {
            get { return _funcionario; }
            set { _funcionario = value; }
        }
        public List<Reserva> Reservas
        {
            get { return _reservas; }
            set { _reservas = value; }
        }
        public Empresa()
        {
            Veiculos = new List<Veiculo>();
            Clientes = new List<Cliente>();
            Funcionario = new List<Funcionario>();
            Reservas = new List<Reserva>();
        }
        public void InserirVeiculo(Veiculo veiculo)
        {
            Veiculos.Add(veiculo);
        }
        public void InserirCliente(Cliente cliente)
        {
            Clientes.Add(cliente);
        }
        public void InserirFuncionario(Funcionario funcionario)
        {
            Funcionario.Add(funcionario);
        }
        public void RemoverVeiculo(Veiculo veiculo)
        {
            Veiculos.Remove(veiculo);
        }
        public void RemoverCliente(Cliente cliente)
        {
            Clientes.Remove(cliente);
        }
        public void RemoverFuncionario(Funcionario funcionario)
        {
            Funcionario.Remove(funcionario);
        }
        public void AlterarEstadoVeiculo(Veiculo veiculo, string estado)
        {
            veiculo.Estado = estado;
        }
        public void ListarVeiculosDisponiveis()
        {
            foreach (Veiculo veiculo in Veiculos)
            {
                if (veiculo.Estado == "Disponivel")
                {
                    Console.WriteLine(veiculo);
                }
            }
        }
        public void ListarVeiculosManutencao()
        {
            foreach (Veiculo veiculo in Veiculos)
            {
                if (veiculo.Estado == "Manutencao")
                {
                    Console.WriteLine(veiculo);
                }
            }
        }
        public void calcularPrecoReserva()
        {
            decimal preco = 0;
            foreach (Veiculo veiculo in Veiculos)
            {
                if (veiculo.Estado == "Disponivel")
                {
                    preco = veiculo.PrecoDiario;
                }
            }
            Console.WriteLine("O preço da reserva é: " + preco);
        }
        public void AvancarDia()
        {
            
        }
    }
}

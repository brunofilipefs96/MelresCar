using System;
using System.IO;
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
        private int _contaVeiculos;
        private int _contaReservas;
        private int _contaClientes;
        private int _contaFuncionarios;


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
        public List<Funcionario> Funcionarios
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
            Funcionarios = new List<Funcionario>();
            Reservas = new List<Reserva>();
        }
        public void carregarFicheiroCSV(string nomeFicheiro)
        {
            if (!File.Exists(nomeFicheiro + ".csv"))
            {
                File.Create(nomeFicheiro + ".csv").Close();
            }
            try
            {
                nomeFicheiro += ".csv";
                string[] lines = File.ReadAllLines(nomeFicheiro);

                if (nomeFicheiro == "veiculos.csv")
                {
                    _contaVeiculos = File.ReadLines(nomeFicheiro).Count();
                    foreach (string line in lines)
                    {
                        string[] fields = line.Split(',');
                        Veiculo veiculoAux = new Veiculo();
                        veiculoAux.IdVeiculo = Convert.ToInt32(fields[0]);
                        veiculoAux.TipoVeiculo = fields[1];
                        veiculoAux.ClasseVeiculo = fields[2];
                        veiculoAux.Marca = fields[3];
                        veiculoAux.Modelo = fields[4];
                        veiculoAux.Matricula = fields[5];
                        veiculoAux.Combustivel = fields[6];
                        veiculoAux.Ano = Convert.ToInt32(fields[7]);
                        veiculoAux.Estado = fields[8];
                        veiculoAux.PrecoDiario = Convert.ToDecimal(fields[9]);
                        veiculoAux.DataPrevistaDisponibilidade = Convert.ToDateTime(fields[10]);
                        Veiculos.Add(veiculoAux);
                    }
                }
                else if (nomeFicheiro == "reservas.csv")
                {
                    _contaReservas = File.ReadLines(nomeFicheiro).Count();
                    foreach (string line in lines)
                    {
                        string[] fields = line.Split(',');
                        Reserva reservaAux = new Reserva();
                        reservaAux.IdReserva = Convert.ToInt32(fields[0]);
                        reservaAux.DataReserva = Convert.ToDateTime(fields[1]);
                        reservaAux.DataInicio = Convert.ToDateTime(fields[2]);
                        reservaAux.DataFim = Convert.ToDateTime(fields[3]);
                        reservaAux.IdVeiculo = Convert.ToInt32(fields[4]);
                        reservaAux.NumCliente = Convert.ToInt32(fields[5]);
                        reservaAux.PrecoTotal = Convert.ToDecimal(fields[6]);

                        Reservas.Add(reservaAux);

                    }
                }
                else if (nomeFicheiro == "clientes.csv")
                {
                    _contaClientes = File.ReadLines(nomeFicheiro).Count();
                    foreach (string line in lines)
                    {
                        string[] fields = line.Split(',');
                        Cliente clienteAux = new Cliente();
                        
                        //Falta criar o construtor Cliente com dados Default e atribuir os fields aqui

                        Clientes.Add(clienteAux);

                    }
                }
                else if (nomeFicheiro == "funcionarios.csv")
                {
                    _contaFuncionarios = File.ReadLines(nomeFicheiro).Count();
                    foreach (string line in lines)
                    {
                        string[] fields = line.Split(',');
                        Funcionario funcionarioAux = new Funcionario();

                        //Falta criar o construtor Funcionario com dados Default e atribuir os fields aqui

                        Funcionarios.Add(funcionarioAux);

                    }
                }
                escreverFicheiroCSV("avioes");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao carregar ficheiro CSV: {ex.Message}");
            }
        }

        public void escreverFicheiroCSV(string nomeFicheiro)
        {
            try
            {
                if (nomeFicheiro == "veiculos")
                {
                    nomeFicheiro += ".csv";
                    StreamWriter writer = new StreamWriter(nomeFicheiro);
                    foreach (var fields in Veiculos)
                    {
                        string line = string.Join(",", fields);
                        writer.WriteLine(line);
                    }
                    writer.Close();
                }
                else if (nomeFicheiro == "reservas")
                {
                    nomeFicheiro += ".csv";
                    StreamWriter writer = new StreamWriter(nomeFicheiro);
                    foreach (var fields in Reservas)
                    {
                        string line = string.Join(",", fields);
                        writer.WriteLine(line);
                    }
                    writer.Close();
                }
                else if (nomeFicheiro == "clientes")
                {
                    nomeFicheiro += ".csv";
                    StreamWriter writer = new StreamWriter(nomeFicheiro);
                    foreach (var fields in Clientes)
                    {
                        string line = string.Join(",", fields);
                        writer.WriteLine(line);
                    }
                    writer.Close();
                }
                else if (nomeFicheiro == "funcionarios")
                {
                    nomeFicheiro += ".csv";
                    StreamWriter writer = new StreamWriter(nomeFicheiro);
                    foreach (var fields in Funcionarios)
                    {
                        string line = string.Join(",", fields);
                        writer.WriteLine(line);
                    }
                    writer.Close();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao escrever no ficheiro CSV: {ex.Message}");
            }
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
            Funcionarios.Add(funcionario);
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
            Funcionarios.Remove(funcionario);
        }
        public void AlterarEstadoVeiculo(Veiculo veiculo, string estado)
        {
            veiculo.Estado = estado;
        }


        public void ListarVeiculosDisponiveis()
        {
            foreach (Veiculo veiculo in Veiculos)
            {
                if (veiculo.Estado == "disponivel")
                {
                    Console.WriteLine(veiculo);
                }
            }
        }
        public void ListarVeiculosManutencao()
        {
            foreach (Veiculo veiculo in Veiculos)
            {
                if (veiculo.Estado == "em manutencao")
                {
                    Console.WriteLine(veiculo);
                }
            }
        }
        
        public void AvancarDia()
        {
            
        }
    }
}

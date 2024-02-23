using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

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
        private string _loggedAccount;
        private int _daysAdded;

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
        public int ContaVeiculos
        {
            get { return _contaVeiculos; }
            set { _contaVeiculos = value; }
        }
        public int ContaReservas
        {
            get { return _contaReservas; }
            set { _contaReservas = value; }
        }
        public int ContaClientes
        {
            get { return _contaClientes; }
            set { _contaClientes = value; }
        }
        public int ContaFuncionarios
        {
            get { return _contaFuncionarios; }
            set { _contaFuncionarios = value; }
        }
        public string LoggedAccount
        {
            get { return _loggedAccount; }
            set { _loggedAccount = value; }
        }
        public int DaysAdded
        {
            get { return _daysAdded; }
            set { _daysAdded = value; }
        }
        public Empresa()
        {
            Veiculos = new List<Veiculo>();
            Clientes = new List<Cliente>();
            Funcionarios = new List<Funcionario>();
            Reservas = new List<Reserva>();
            ContaVeiculos = 0;
            ContaReservas = 0;
            ContaClientes = 0;
            ContaFuncionarios = 0;
            LoggedAccount = "";
            DaysAdded = 0;
        }
        public bool VerificaInteiro(string numero)
        {
            if (int.TryParse(numero, out int result) && result > 0)
            {
                return true;
            }
            return false;
        }

        public bool VerificaDecimal(string numero)
        {
            if (decimal.TryParse(numero, out decimal result) && result > 0)
            {
                return true;
            }
            return false;
        }

        public bool VerificaEmail(string email)
        {
            string regex = @"^[^@\s]+@[^@\s]+\.(pt|com|net|org|gov)$";

            return Regex.IsMatch(email, regex, RegexOptions.IgnoreCase);
        }

        public void CarregarFicheiroCSV(string nomeFicheiro)
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
                        if (fields[1] == "carro"){
                            Carro carroAux = new Carro();
                            carroAux.IdVeiculo = Convert.ToInt32(fields[0]);
                            carroAux.TipoVeiculo = fields[1];
                            carroAux.ClasseVeiculo = fields[2];
                            carroAux.Marca = fields[3];
                            carroAux.Modelo = fields[4];
                            carroAux.Matricula = fields[5];
                            carroAux.Combustivel = fields[6];
                            carroAux.Ano = Convert.ToInt32(fields[7]);
                            carroAux.Estado = fields[8];
                            carroAux.PrecoDiario = Convert.ToDecimal(fields[9]);
                            carroAux.DataPrevistaDisponibilidade = Convert.ToDateTime(fields[10]);
                            //Campos Extra do Carro
                            carroAux.NumPortas = Convert.ToInt32(fields[11]);
                            carroAux.TipoCaixa = fields[12];
                            Veiculos.Add(carroAux);
                        }
                        else if (fields[1] == "mota")
                        {
                            Mota motaAux = new Mota();
                            motaAux.IdVeiculo = Convert.ToInt32(fields[0]);
                            motaAux.TipoVeiculo = fields[1];
                            motaAux.ClasseVeiculo = fields[2];
                            motaAux.Marca = fields[3];
                            motaAux.Modelo = fields[4];
                            motaAux.Matricula = fields[5];
                            motaAux.Combustivel = fields[6];
                            motaAux.Ano = Convert.ToInt32(fields[7]);
                            motaAux.Estado = fields[8];
                            motaAux.PrecoDiario = Convert.ToDecimal(fields[9]);
                            motaAux.DataPrevistaDisponibilidade = Convert.ToDateTime(fields[10]);
                            //Campos Extra da Mota
                            motaAux.Cilindrada = Convert.ToInt32(fields[11]);
                            Veiculos.Add(motaAux);
                        }
                        else if (fields[1] == "camiao")
                        {
                            Camiao camiaoAux = new Camiao();
                            camiaoAux.IdVeiculo = Convert.ToInt32(fields[0]);
                            camiaoAux.TipoVeiculo = fields[1];
                            camiaoAux.ClasseVeiculo = fields[2];
                            camiaoAux.Marca = fields[3];
                            camiaoAux.Modelo = fields[4];
                            camiaoAux.Matricula = fields[5];
                            camiaoAux.Combustivel = fields[6];
                            camiaoAux.Ano = Convert.ToInt32(fields[7]);
                            camiaoAux.Estado = fields[8];
                            camiaoAux.PrecoDiario = Convert.ToDecimal(fields[9]);
                            camiaoAux.DataPrevistaDisponibilidade = Convert.ToDateTime(fields[10]);
                            //Campos Extra do Camiao
                            camiaoAux.PesoMaximo = Convert.ToDouble(fields[11]);
                            Veiculos.Add(camiaoAux);
                        }
                        else if (fields[1] == "camioneta")
                        {
                            Camioneta camionetaAux = new Camioneta();
                            camionetaAux.IdVeiculo = Convert.ToInt32(fields[0]);
                            camionetaAux.TipoVeiculo = fields[1];
                            camionetaAux.ClasseVeiculo = fields[2];
                            camionetaAux.Marca = fields[3];
                            camionetaAux.Modelo = fields[4];
                            camionetaAux.Matricula = fields[5];
                            camionetaAux.Combustivel = fields[6];
                            camionetaAux.Ano = Convert.ToInt32(fields[7]);
                            camionetaAux.Estado = fields[8];
                            camionetaAux.PrecoDiario = Convert.ToDecimal(fields[9]);
                            camionetaAux.DataPrevistaDisponibilidade = Convert.ToDateTime(fields[10]);
                            //Campos Extra da Camioneta
                            camionetaAux.NumEixos = Convert.ToInt32(fields[11]);
                            camionetaAux.NumPassageiros = Convert.ToInt32(fields[12]);
                            Veiculos.Add(camionetaAux);
                        }
                        
                        
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
                        clienteAux.Nome = fields[0];
                        clienteAux.Nif = fields[1];
                        clienteAux.Morada = fields[2];
                        clienteAux.Email = fields[3];
                        clienteAux.Telemovel = fields[4];
                        //Campo Extra do Cliente
                        clienteAux.NumCliente = Convert.ToInt32(fields[5]);

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
                        funcionarioAux.Nome = fields[0];
                        funcionarioAux.Nif = fields[1];
                        funcionarioAux.Morada = fields[2];
                        funcionarioAux.Email = fields[3];
                        funcionarioAux.Telemovel = fields[4];
                        //Campo Extras do Funcionário
                        funcionarioAux.IdFuncionario = Convert.ToInt32(fields[5]);
                        funcionarioAux.Username = fields[6];
                        funcionarioAux.Password = fields[7];
                        funcionarioAux.Salario = Convert.ToDecimal(fields[8]);

                        Funcionarios.Add(funcionarioAux);

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao carregar ficheiro CSV: {ex.Message}");
            }
        }

        public void EscreverFicheiroCSV(string nomeFicheiro)
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
            ContaVeiculos++;
        }
        public void InserirCliente(Cliente cliente)
        {
            Clientes.Add(cliente);
            ContaClientes++;
        }
        public void InserirFuncionario(Funcionario funcionario)
        {
            Funcionarios.Add(funcionario);
            ContaFuncionarios++;
        }
        public void InserirReserva(Reserva reserva)
        {
            Reservas.Add(reserva);
            ContaReservas++;
        }
        
        public void RemoverVeiculo(Veiculo veiculo)
        {
            Veiculos.Remove(veiculo);
            ContaVeiculos--;
        }
        public void RemoverCliente(int indexCliente)
        {
            Clientes.RemoveAt(indexCliente);
            ContaClientes--;
        }
        public void RemoverFuncionario(int indexFuncionario)
        {
            Funcionarios.RemoveAt(indexFuncionario);
            ContaFuncionarios--;
        }
        public void RemoverReserva(Reserva reserva)
        {
            Reservas.Remove(reserva);
            ContaReservas--;
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
        public int gerarId(string tipo)
        {
            int id = 0;
            if (tipo == "veiculo")
            {
                foreach (var veiculo in Program.melresCar.Veiculos)
                {
                    if (veiculo.IdVeiculo > id)
                    {
                        id = veiculo.IdVeiculo;
                    }
                }
            }
            else if (tipo == "reserva")
            {
                foreach (var reserva in Program.melresCar.Reservas)
                {
                    if (reserva.IdReserva > id)
                    {
                        id = reserva.IdReserva;
                    }
                }
            }
            else if (tipo == "cliente")
            {
                foreach (var cliente in Program.melresCar.Clientes)
                {
                    if (cliente.NumCliente > id)
                    {
                        id = cliente.NumCliente;
                    }
                }
            }
            else if (tipo == "funcionario")
            {
                foreach (var funcionario in Program.melresCar.Funcionarios)
                {
                    if (funcionario.IdFuncionario > id)
                    {
                        id = funcionario.IdFuncionario;
                    }
                }
            }
            
            return id + 1;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobile
{
    internal class Funcionario : Pessoa
    {
        private int _idFuncionario;
        private string _username;
        private string _password;
        private decimal _salario;

        public int IdFuncionario
        {
            get { return _idFuncionario; }
            set { _idFuncionario = value; }
        }
        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        public decimal Salario
        {
            get { return _salario; }
            set { _salario = value; }
        }
        public Funcionario() : base()
        {
            IdFuncionario = -1;
            Username = "n/d";
            Password = "n/d";
            Salario = -1;
        }

        public Funcionario(string nome, string nif, string morada, string email, string telemovel, string username, string password, decimal salario) : base(nome, nif, morada, email, telemovel)
        {
            IdFuncionario = Program.melresCar.gerarId("funcionario");
            Username = username;
            Password = password;
            Salario = salario;

        }

        public override string ToString()
        {
            return $"{base.ToString()},{IdFuncionario},{Username},{Password},{Salario}";
        }


    }
}

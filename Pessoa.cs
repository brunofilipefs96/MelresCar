using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobile
{
    internal class Pessoa
    {
        private string _nome;
        private string _nif;
        private string _morada;
        private string _email;
        private string _telemovel;

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        public string Nif
        {
            get { return _nif; }
            set { _nif = value; }
        }
        public string Morada
        {
            get { return _morada; }
            set { _morada = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public string Telemovel
        {
            get { return _telemovel; }
            set { _telemovel = value; }
        }

        public Pessoa(string nome, string nif, string morada, string email, string telemovel)
        {
            Nome = nome;
            Nif = nif;
            Morada = morada;
            Email = email;
            Telemovel = telemovel;
        }

        public override string ToString()
        {
            return "Nome: " + Nome + "\nNIF: " + Nif + "\nMorada: " + Morada + "\nEmail: " + Email + "\nTelemóvel: " + Telemovel + "\n";
        }

    }
}

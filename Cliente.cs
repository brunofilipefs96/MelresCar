using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobile
{
    internal class Cliente : Pessoa
    {
        private int _numCliente;

        public int NumCliente
        {
            get { return _numCliente; }
            set { _numCliente = value; }
        }

        public Cliente(string nome, string nif, string morada, string email, string telemovel, int numCliente) : base (nome, nif, morada, email, telemovel)
        {
            NumCliente = numCliente;
        }

        public override string ToString()
        {
            return base.ToString() + "Número de Cliente: " + NumCliente + "\n";
        }
    }
}

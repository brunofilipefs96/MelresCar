using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobile
{
    internal class Carro : Veiculo
    {
        private int _numPortas;
        private string _tipoCaixa;

        public int NumPortas
        {
            get { return _numPortas; }
            set { _numPortas = value; }
        }
        public string TipoCaixa
        {
            get { return _tipoCaixa; }
            set { _tipoCaixa = value; }
        }

        public Carro() : base()
        {
            NumPortas = -1;
            TipoCaixa = "n/d";
        }

        public Carro(string tipoVeiculo, string classeVeiculo, string marca, string modelo, string matricula, string combustivel, int ano, decimal precoDiario, int numPortas, string tipoCaixa) : base(tipoVeiculo, classeVeiculo, marca, modelo, matricula, combustivel, ano, precoDiario)
        {
            NumPortas = numPortas;
            TipoCaixa = tipoCaixa;
        }
        
        
        public override string ToString()
        {
            return $"{base.ToString()},{NumPortas},{TipoCaixa}";
        }

    }
}

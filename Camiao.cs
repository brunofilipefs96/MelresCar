using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobile
{
    internal class Camiao : Veiculo
    {
        private double _pesoMaximo;

        public double PesoMaximo
        {
            get { return _pesoMaximo; }
            set { _pesoMaximo = value; }
        }

        public Camiao() : base()
        {
            PesoMaximo = -1;
        }

        public Camiao(string tipoVeiculo, string classeVeiculo, string marca, string modelo, string matricula, string combustivel, int ano, string estado, decimal precoDiario, DateTime dataPrevistaDisponibilidade, double pesoMaximo) : base(tipoVeiculo, classeVeiculo, marca, modelo, matricula, combustivel, ano, estado, precoDiario, dataPrevistaDisponibilidade)
        {           
            PesoMaximo = pesoMaximo;
        }

        public override string ToString()
        {
            return $"{base.ToString()},{PesoMaximo}"; 
        }
    }
}

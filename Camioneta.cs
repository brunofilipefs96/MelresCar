using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobile
{
    internal class Camioneta : Veiculo
    {
        private int _numEixos;
        private int _numPassageiros;

        public int NumEixos
        {
            get { return _numEixos; }
            set { _numEixos = value; }
        }
        public int NumPassageiros
        {
            get { return _numPassageiros; }
            set { _numPassageiros = value; }
        }
        public Camioneta() : base()
        {
            NumEixos = -1;
            NumPassageiros = -1;
        }
        public Camioneta(int idVeiculo, string tipoVeiculo, string classeVeiculo, string marca, string modelo, string matricula, string combustivel, int ano, string estado, decimal precoDiario, DateTime dataPrevistaDisponibilidade, int numEixos, int numPassageiros) : base(idVeiculo, tipoVeiculo, classeVeiculo, marca, modelo, matricula, combustivel, ano, estado, precoDiario, dataPrevistaDisponibilidade)
        {
            NumEixos = numEixos;
            NumPassageiros = numPassageiros;
        }

        public override string ToString()
        {
            return $"{base.ToString()},{NumEixos},{NumPassageiros}";
        }
    }
}

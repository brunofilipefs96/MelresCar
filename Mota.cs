using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobile
{
    internal class Mota : Veiculo
    {
        private int _cilindrada;

        public int Cilindrada
        {
            get { return _cilindrada; }
            set { _cilindrada = value; }
        }
        public Mota() : base()
        {
            Cilindrada = -1;
        }

        public Mota(int idVeiculo, string tipoVeiculo, string classeVeiculo, string marca, string modelo, string matricula, string combustivel, int ano, string estado, decimal precoDiario, DateTime dataPrevistaDisponibilidade, int cilindrada) : base(idVeiculo, tipoVeiculo, classeVeiculo, marca, modelo, matricula, combustivel, ano, estado, precoDiario, dataPrevistaDisponibilidade)
        {
            Cilindrada = cilindrada;
        }


        public override string ToString()
        {
            return $"{base.ToString()},{Cilindrada}";
        }
    }
}

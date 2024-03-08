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

        public Mota(string tipoVeiculo, string classeVeiculo, string marca, string modelo, string matricula, string combustivel, int ano, decimal precoDiario, int cilindrada) : base(tipoVeiculo, classeVeiculo, marca, modelo, matricula, combustivel, ano, precoDiario)
        {
            Cilindrada = cilindrada;
        }


        public override string ToString()
        {
            return $"{base.ToString()},{Cilindrada}";
        }
    }
}

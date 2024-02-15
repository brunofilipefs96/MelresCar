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

        public Carro(int idVeiculo, string tipoVeiculo, string classeVeiculo, string marca, string modelo, string matricula, string combustivel, int ano, string estado, decimal precoDiario, DateTime dataPrevistaDisponibilidade, int numPortas, string tipoCaixa) : base(idVeiculo, tipoVeiculo, classeVeiculo, marca, modelo, matricula, combustivel, ano, estado, precoDiario, dataPrevistaDisponibilidade)
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

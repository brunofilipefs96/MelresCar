using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobile
{
    internal class Reserva
    {
        private int _idReserva;
        private DateTime _dataReserva;
        private DateTime _dataInicio;
        private DateTime _dataFim;
        private int _idVeiculo;
        private int _numCliente;
        private decimal _precoTotal;

        public int IdReserva
        {
            get { return _idReserva; }
            set { _idReserva = value; }
        }
        public DateTime DataReserva
        {
            get { return _dataReserva; }
            set { _dataReserva = value; }
        }
        public DateTime DataInicio
        {
            get { return _dataInicio; }
            set { _dataInicio = value; }
        }
        public DateTime DataFim
        {
            get { return _dataFim; }
            set { _dataFim = value; }
        }
        public int IdVeiculo
        {
            get { return _idVeiculo; }
            set { _idVeiculo = value; }
        }
        public int NumCliente
        {
            get { return _numCliente; }
            set { _numCliente = value; }
        }
        public decimal PrecoTotal
        {
            get { return _precoTotal; }
            set { _precoTotal = value; }
        }
        public Reserva()
        {
            IdReserva = -1;
            DataReserva = new DateTime();
            DataInicio = new DateTime();
            DataFim = new DateTime();
            IdVeiculo = -1;
            NumCliente = -1;
            PrecoTotal = 0;
        }

        public Reserva(DateTime dataInicio, DateTime dataFim, int idVeiculo, int numCliente, decimal precoTotal)
        {
            IdReserva = Program.melresCar.gerarId("reserva");
            DataReserva = DateTime.Now;
            DataInicio = dataInicio;
            DataFim = dataFim;
            IdVeiculo = idVeiculo;
            NumCliente = numCliente;
            PrecoTotal = precoTotal;
        }

        public override string ToString()
        {
            return $"{IdReserva},{DataReserva},{DataInicio},{DataFim},{IdVeiculo},{NumCliente},{PrecoTotal}";
        }
    }
}

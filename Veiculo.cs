using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobile
{
    internal class Veiculo
    {
        private int _idVeiculo;
        private string _tipoVeiculo;
        private string _classeVeiculo;
        private string _marca;
        private string _modelo;
        private string _matricula;
        private string _combustivel;
        private int _ano;
        private string _estado;
        private decimal _precoDiario;
        private DateTime _dataPrevistaDisponibilidade;

        public int IdVeiculo
        {
            get { return _idVeiculo; }
            set { _idVeiculo = value; }
        }
        public string TipoVeiculo
        {
            get { return _tipoVeiculo; }
            set { _tipoVeiculo = value; }
        }
        public string ClasseVeiculo
        {
            get { return _classeVeiculo; }
            set { _classeVeiculo = value; }
        }
        public string Marca
        {
            get { return _marca; }
            set { _marca = value; }
        }
        public string Modelo
        {
            get { return _modelo; }
            set { _modelo = value; }
        }
        public string Matricula
        {
            get { return _matricula; }
            set { _matricula = value; }
        }
        public string Combustivel
        {
            get { return _combustivel; }
            set { _combustivel = value; }
        }
        public int Ano
        {
            get { return _ano; }
            set { _ano = value; }
        }
        public string Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }
        public decimal PrecoDiario
        {
            get { return _precoDiario; }
            set { _precoDiario = value; }
        }
        public DateTime DataPrevistaDisponibilidade
        {
            get { return _dataPrevistaDisponibilidade; }
            set { _dataPrevistaDisponibilidade = value; }
        }
        public Veiculo()
        {
            IdVeiculo = -1;
            TipoVeiculo = "n/d";
            ClasseVeiculo = "n/d";
            Marca = "n/d";
            Modelo = "n/d";
            Matricula = "n/d";
            Combustivel = "n/d";
            Ano = -1;
            Estado = "n/d";
            PrecoDiario = -1;
            DataPrevistaDisponibilidade = new DateTime();
        }

        public Veiculo( string tipoVeiculo, string classeVeiculo, string marca, string modelo, string matricula, string combustivel, int ano, string estado, decimal precoDiario, DateTime dataPrevistaDisponibilidade)
        {
            IdVeiculo = Program.melresCar.gerarId("veiculo");
            TipoVeiculo = tipoVeiculo;
            ClasseVeiculo = classeVeiculo;
            Marca = marca;
            Modelo = modelo;
            Matricula = matricula;
            Combustivel = combustivel;
            Ano = ano;
            Estado = estado;
            PrecoDiario = precoDiario;
            DataPrevistaDisponibilidade = dataPrevistaDisponibilidade;
        }

        public override string ToString()
        {
            return $"{IdVeiculo},{TipoVeiculo},{ClasseVeiculo},{Marca},{Modelo},{Matricula},{Combustivel},{Ano},{Estado},{PrecoDiario},{DataPrevistaDisponibilidade}";
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoHospedagem.models
{
    public class Suite
    {
        int _numeroQuarto;
        string _tipoSuite;
        int _capacidade;
        decimal _valorDiaria; 
        public int Reserva{ get; set;}
        public string TipoSuite{
            get => _tipoSuite;
        }
        public int NumeroQuarto{
            get => _numeroQuarto;
        }
        public int Capacidade{
            get => _capacidade;
        }
        public decimal ValorDiaria{
            get => _valorDiaria;
            set => _valorDiaria = value;
        }

        public Suite(string tipoSuite,int numeroQuarto, int capacidade, decimal valorDiaria){
            _numeroQuarto = numeroQuarto;
            _tipoSuite = tipoSuite;
            _capacidade = capacidade;
            _valorDiaria = valorDiaria;
        }
    }
}
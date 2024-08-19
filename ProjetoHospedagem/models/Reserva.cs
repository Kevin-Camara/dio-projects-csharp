using System;

namespace ProjetoHospedagem.models
{
    public class Reserva
    {
        public int IdReserva { get; }
        List<Pessoa> Hospedes = new List<Pessoa>();
        public Suite Suite { get; set;}
        public decimal ValorTotalReserva;
        int DiasResevados;

        public Reserva(){
            IdReserva = GerarIdReserva();
        }

        public void CadastrarHospedes(List<Pessoa> hospedes){
            Hospedes = hospedes;
        }
        public void CadastrarSuite(Suite suite){
            if(suite.Capacidade < ObterQuantidadeHospedes()){
                throw new ArgumentException("Quantidade de hospedes superior a capacidade da Suite.");
            }
            Suite = suite;
        }
        public int ObterQuantidadeHospedes(){
            return Hospedes.Count();
        }
        public void QuantidadeDiasReservados(int diasReservados){
            DiasResevados = diasReservados;
            CalcularValorDiaria();
        }
        public void CalcularValorDiaria(){
            if(DiasResevados >= 10){
                ValorTotalReserva = (Suite.ValorDiaria * DiasResevados) * 0.9M; 
            }
            ValorTotalReserva = (Suite.ValorDiaria * DiasResevados);
        }
        private int GerarIdReserva(){
            return Hotel.QuantidadeReservas() + 1000;
        }
    }
}
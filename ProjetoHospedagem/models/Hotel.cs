using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoHospedagem.models
{
    public class Hotel
    {
        static List<Reserva> Reservas = new List<Reserva>();
        public static List<Pessoa> Pessoas = new List<Pessoa>();
        public static List<Suite> Suites = new List<Suite>();


        public static void AdicionarReserva(Reserva reserva){
            Reservas.Add(reserva);
        }
        public static int QuantidadeReservas(){
            return Reservas.Count;
        }
        public static void ListarReservas(){
            foreach(Reserva reserva in Reservas){
                Console.WriteLine("------------------------------------");
                Console.WriteLine($"ID: {reserva.IdReserva}\nQuarto Suite: {reserva.Suite.NumeroQuarto}\n" +
                                  $"Quantidade de hospedes: {reserva.ObterQuantidadeHospedes()}\n" +
                                  $"Valor total pago: {reserva.ValorTotalReserva}");
            }
        }
        public static void RemoverReserva(int posicao){
            Reservas.Remove(Reservas[posicao]);
        }
        public static void ListarPessoas(){
            int cont = 0;
            Console.WriteLine("------------------------------");
            foreach (Pessoa item in Pessoas)
            {
                Console.WriteLine($"{cont} - {item.Nome} {item.Sobrenome}");
                cont++;
            }
            Console.WriteLine("------------------------------");

        }
    }
}
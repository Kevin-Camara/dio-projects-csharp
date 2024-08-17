using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace FirstProject.Projetos.Estacionamento.Models
{
    public class Estacionamento
    {
        public string name;
        private decimal precoInicial;
        private decimal precoPorHora;
        private int horas;
        List<string> veiculos = new List<string>(0);

        public Estacionamento(string _name, decimal _precoInicial, decimal _precoPorHora){
            this.name = _name;
            this.precoInicial = _precoInicial;
            this.precoPorHora = _precoPorHora;
        }

        public decimal getPrecoInicial(){
            return this.precoInicial;
        }
        public void setPrecoInicial(decimal valor){
            this.precoInicial = valor;
        }
        public decimal getPrecoPorHora(){
            return this.precoPorHora;
        }
        public void setPrecoPorHora(decimal valor){
            this.precoPorHora = valor;
        }


        public void AdicionarVeiculo(string placa){
                this.veiculos.Add(placa);
        }
        public void RemoverVeiculo(string placa){
            if(ConsultarNoEstacionamento(placa)){
                Console.Write("Quantas horas esta estacionado : ");
                this.horas = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Valor total : {this.precoInicial + (horas * this.precoPorHora)}");
                this.veiculos.Remove(placa);
            }
        }
        public void ListarVeiculos(){
            if(this.veiculos.Count() > 0){
                foreach (string item in veiculos)
                {
                    Console.Write($"{item} | ");
                }
                Console.WriteLine("");
            }else{
                Console.WriteLine("Nao ha veiculos estacionados");
            }
        }
        private bool ConsultarNoEstacionamento(string placa){
            if(veiculos.Contains(placa)){
                return true;
            }else{
                Console.WriteLine("Veiculo nao encontrado !");
                return false;
            }
        }
    }
}
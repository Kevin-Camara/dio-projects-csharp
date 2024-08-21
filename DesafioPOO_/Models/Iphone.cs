namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
         public Iphone(string numero, string modelo, string imei, int capacidade) : base(numero, modelo, imei, capacidade)
        {
            
        }
        public override void InstalarAplicativo(string nomeApp){
            Console.WriteLine($"Instalando o aplicativo \"{nomeApp}\" no Iphone");
        }
    }
}
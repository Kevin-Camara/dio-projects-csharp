using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ProjetoHospedagem.models;

bool Validador = true; 
int opcao;
do{
    opcao = Menu();
    switch(opcao){
        case 1:
            CadastrarPessoa(Hotel.Pessoas);
            break;
        case 2: 
            CadastrarSuite(Hotel.Suites);
            break;
        case 3: 
            GerarReserva();
            break;
        case 4:
            Hotel.ListarReservas();
            break;
        case 5:
            Hotel.ListarReservas();
            Console.Write("Escolha a reserva a ser removida: ");
            Hotel.RemoverReserva(Convert.ToInt32(Console.ReadLine()) - 1000);
            break;
        case 6:
            Hotel.ListarPessoas();
            break;
        case 7:
            Validador = false;
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
    
}while(Validador);

Console.WriteLine("Programa encerrado !");


static int Menu(){
    string[] menu = new string [] {"Cadastrar pessoa", "Cadastrar suite", "Gerar reserva",
                                   "Listar Reservas", "Remover reserva","Listar Pessoas", "Encerrar"};
    int cont = 1;
    foreach (string item in menu){
        Console.WriteLine($"{cont} - {item}");
        cont++;
    }
    return Convert.ToInt32(Console.ReadLine());
}
static void CadastrarPessoa(List<Pessoa> Pessoas){
    Console.Write("Nome: ");
    string nome = Console.ReadLine();
    Console.Write("Sobrenome: ");
    string sobrenome = Console.ReadLine();
    Pessoa newPessoa = new Pessoa(nome, sobrenome);

    Pessoas.Add(newPessoa);
}
static void CadastrarSuite(List<Suite> Suites){
    Console.Write("Tipo da suite: ");
    string tipoSuite = Console.ReadLine();
    Console.Write("Número da suite: ");
    int numeroQuarto = Convert.ToInt32(Console.ReadLine());
    Console.Write("Capacidade da suite: ");
    int capacidade = Convert.ToInt32(Console.ReadLine());
    Console.Write("Preço diario da suite: ");
    decimal precoDiario = Convert.ToDecimal(Console.ReadLine());

    Suite newSuite = new Suite(tipoSuite, numeroQuarto, capacidade, precoDiario);
    Suites.Add(newSuite);  
}
static void GerarReserva(){
    Reserva newReserva = new Reserva();
    newReserva.CadastrarHospedes(VerificarPessoas());
    newReserva.CadastrarSuite(VerificarSuite());
    Console.Write("Reservar por quantos dias: ");
    newReserva.QuantidadeDiasReservados(Convert.ToInt32(Console.ReadLine()));

    Hotel.AdicionarReserva(newReserva);
}
static List<Pessoa> VerificarPessoas(){
    if(Hotel.Pessoas.Count == 0){
        Console.WriteLine("Nenhuma Pessoa cadastrada !\n ---Abrindo cadastro de pessoa---  ");
        CadastrarPessoa(Hotel.Pessoas);
        return Hotel.Pessoas;
    }else{
        List<Pessoa> pessoas = new List<Pessoa>();
        int selecao = 0;
        Hotel.ListarPessoas();
        for(int i = 0; i < Hotel.Pessoas.Count; i++){
            Console.Write("Selecione as pessoas para reserva: (99 p/ sair)");
            selecao = Convert.ToInt32(Console.ReadLine());
            if(selecao == 99){
                break;
            }
            pessoas.Add(Hotel.Pessoas[selecao]);
        }
        foreach(Pessoa pessoa in pessoas){
            Hotel.Pessoas.Remove(pessoa);
        }
        return pessoas;
    }
}
static Suite VerificarSuite(){
    if(Hotel.Suites.Count == 0){
        Console.WriteLine("Nenhuma Suite cadastrada !\n ---Abrindo cadastro de Suite---  ");
        CadastrarSuite(Hotel.Suites);
        return Hotel.Suites[0];
    }else{
        int cont = 0;
        Console.WriteLine("Escolha uma suite: ");
       foreach (Suite item in Hotel.Suites)
       {
        Console.WriteLine($"{cont} - Nº{item.NumeroQuarto} Tipo: {item.TipoSuite} ");
        cont++;
       }
       Suite suite = Hotel.Suites[Convert.ToInt32(Console.ReadLine())];
       Hotel.Suites.Remove(suite);
       return suite;
    }
}
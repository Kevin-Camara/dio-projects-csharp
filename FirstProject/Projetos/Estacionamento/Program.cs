using FirstProject.Projetos.Estacionamento.Models;

List<Estacionamento> listaEstacionamento = new List<Estacionamento>(); 

bool repetir = true;
int index = 0;

Console.WriteLine("Criação de estacionamento");
AdicionarEstacionamento(listaEstacionamento);
do{
    menu();
    int opcao = Convert.ToInt32(Console.ReadLine());
    switch(opcao){
        case 1:
            Console.Write("Placa do veiculo: "); 
            listaEstacionamento[index].AdicionarVeiculo(Console.ReadLine()!);
            break;
        case 2:
            Console.Write("Placa do veiculo a ser retirado: ");
            listaEstacionamento[index].RemoverVeiculo(Console.ReadLine()!);
            break;
        case 3:
            listaEstacionamento[index].ListarVeiculos();
            break;
        case 4:
            Console.WriteLine("Criação de estacionamento");
            AdicionarEstacionamento(listaEstacionamento);
            break;
        case 5:
            Console.WriteLine("Seleção estacionamento");
            int cont = 0;
            foreach (Estacionamento item in listaEstacionamento){
                Console.WriteLine($"{cont}. {item.name}");
                cont++;
            }
            index = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"Troca realizada para o {listaEstacionamento[index].name}");
            break;
        case 6:        
            Console.WriteLine("Encerrando programa !");
            repetir = false;
            break;
        default:
            Console.WriteLine("Opcao invalida, tente novamente !");
            break;
    }
}while(repetir);


static void menu(){
    string[] opcoes = new string[] {"Cadastrar veiculos","Remover veiculos","Listar veiculos",
    "Adiconar estacionamento", "Selecionar estacionamento", "Encerrar",};
    int cont = 1;
    foreach (string item in opcoes)
    {
        Console.WriteLine($"{cont}. {item}");
        cont++;
    }
}
static void AdicionarEstacionamento(List<Estacionamento> estacionamentos){
    Console.Write("Preço fixo: ");
    decimal precoFixo = Convert.ToDecimal(Console.ReadLine());
    Console.Write("Preço por hora: ");
    decimal precoPorHora = Convert.ToDecimal(Console.ReadLine());
    string nome = $"Estacionamento {estacionamentos.Count()}";
    Estacionamento newEstacionamento = new Estacionamento(nome, precoFixo, precoPorHora);
    estacionamentos.Add(newEstacionamento);
}
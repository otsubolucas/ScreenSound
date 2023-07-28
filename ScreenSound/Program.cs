//Screen Sound
using System.Linq.Expressions;

string mensagemDeBoasVindas = "Sejam bem-vindos ao Screen Sound!";
List<string> listaDasBandas = new List<string>();
void ExibirMensagem()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
                        ");
    Console.WriteLine(mensagemDeBoasVindas);

}
void ExibirMenu()
{
    ExibirMensagem();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir média de uma banda");
    Console.WriteLine("Digite 0 para sair");

    Console.Write("\nDigite a sua opção: ");
    String opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNum = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNum)
    {
        case 1:
            RegistrarBanda();
            break;
        case 2:
            MostrarBanda();
            break;
        case 3:
            Console.WriteLine("\nVocê escolheu a opção " + opcaoEscolhida);
            break;
        case 4:
            Console.WriteLine("\nVocê escolheu a opção " + opcaoEscolhida);
            break;
        case 0:
            Console.Clear();
            Console.WriteLine("\nSaindo.....");
            Thread.Sleep(1000);
            break;
        default:
            Console.WriteLine("\n[ERRO] Opção inválida!!!");
            break;
    }

    void RegistrarBanda()
    {
        Console.Clear();
        Console.WriteLine(@"
█▀█ █▀▀ █▀▀ █ █▀ ▀█▀ █▀█ █▀█   █▀▄ █▀▀   █▄▄ ▄▀█ █▄░█ █▀▄ ▄▀█ █▀
█▀▄ ██▄ █▄█ █ ▄█ ░█░ █▀▄ █▄█   █▄▀ ██▄   █▄█ █▀█ █░▀█ █▄▀ █▀█ ▄█");
        Console.Write("\nDigite o nome da banda que deseja registrar: ");
        string nomeBanda = Console.ReadLine()!;
        listaDasBandas.Add(nomeBanda);
        Console.Beep();
        Console.WriteLine($"\nBanda {nomeBanda} registrada com sucesso!");
        Thread.Sleep(1000);
        Console.Clear();
        ExibirMenu();
    }
    void MostrarBanda()
    {
        Console.Clear();
        Console.WriteLine(@"
█░░ █ █▀ ▀█▀ ▄▀█   █▀▄ ▄▀█ █▀   █▄▄ ▄▀█ █▄░█ █▀▄ ▄▀█ █▀
█▄▄ █ ▄█ ░█░ █▀█   █▄▀ █▀█ ▄█   █▄█ █▀█ █░▀█ █▄▀ █▀█ ▄█");
        if (listaDasBandas.Count == 0)
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("NENHUMA BANDA RESGITRADA!!!");
            Console.WriteLine("-----------------------------------");
        }

        // for(int i = 0; i < listaDasBandas.Count; i++) 
        //{
        //   Console.Write($"\nBanda: {listaDasBandas[i]}");
        // }
        foreach (string banda in listaDasBandas)
        {
            Console.WriteLine($"Banda: {banda}");
        }
        Console.WriteLine();
        Console.WriteLine("\nAperte qualquer tecla para voltar ao menu principal");
        Console.WriteLine("***************************************************");
        Console.ReadKey();
        Console.Clear();
        ExibirMenu();

    }
}

ExibirMenu();

// Screen Sound
//Pedro Henrique de Souza Ramos 
using System.Net.Http.Headers;
internal class Program
{
    private static void Main(string[] args)
    {
        string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
        Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();

        void ExibirMensagemDeBoasVindas()
        {
            Console.WriteLine(@"

█████████████████████████████████████████████████████████████████████████
█─▄▄▄▄█─▄▄▄─█▄─▄▄▀█▄─▄▄─█▄─▄▄─█▄─▀█▄─▄███─▄▄▄▄█─▄▄─█▄─██─▄█▄─▀█▄─▄█▄─▄▄▀█
█▄▄▄▄─█─███▀██─▄─▄██─▄█▀██─▄█▀██─█▄▀─████▄▄▄▄─█─██─██─██─███─█▄▀─███─██─█
▀▄▄▄▄▄▀▄▄▄▄▄▀▄▄▀▄▄▀▄▄▄▄▄▀▄▄▄▄▄▀▄▄▄▀▀▄▄▀▀▀▄▄▄▄▄▀▄▄▄▄▀▀▄▄▄▄▀▀▄▄▄▀▀▄▄▀▄▄▄▄▀▀
    ");
            Console.WriteLine("*******************************");
            Console.WriteLine(mensagemDeBoasVindas);
            Console.WriteLine("*******************************");
        }
        void ExibirOpcoesDoMenu()
        {
            Console.WriteLine("\nDigite 1 para registrar uma banda");
            Console.WriteLine("Digite 2 para mostrar todas as bandas");
            Console.WriteLine("Digite 3 para avaliar uma banda");
            Console.WriteLine("Digite 4 para exibir a média de uma banda");
            Console.WriteLine("Digite -1 para sair");

            Console.Write("\nDigite a sua opçao: ");

            string opcaoEscolhida = Console.ReadLine()!;
            int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

            switch (opcaoEscolhidaNumerica)
            {
                case 1:
                    RegistrarBanda();
                    break;
                case 2:
                    MostrarBandasRegistradas();
                    break;
                case 3:
                    AvaliarumaBanda();
                    break;
                case 4:
                    MediadasBandas();
                    break;
                case -1:
                    Console.WriteLine("Tchau :) !");
                    break;
                default:
                    Console.WriteLine("Você digitou uma opçao inválida: " + opcaoEscolhida);
                    break;
            }
        }
        void RegistrarBanda()
        {
            Console.Clear();
            ExibirTituloDaOpcao("Registro de Bandas");
            Console.Write("Digite o nome da banda que deseja registrar: ");
            string nomedaBanda = Console.ReadLine()!;
            bandasRegistradas.Add(nomedaBanda, new List<int>());
            Console.WriteLine($"A banda {nomedaBanda} foi registrado com sucesso!");
            Thread.Sleep(2000);
            Console.Clear();
            ExibirMensagemDeBoasVindas();
            ExibirOpcoesDoMenu();
        }

        void MostrarBandasRegistradas()
        {
            Console.Clear();
            ExibirTituloDaOpcao("Exibindo todas as bandas registradas");
            /*for (int i = 0; i < ListadasBandas.Count; i++)
            {
                Console.WriteLine($"Banda: {ListadasBandas[i]}");
            }*/
            foreach (string banda in bandasRegistradas.Keys)
            {
                Console.WriteLine($"Banda: {banda}");
            }
            Console.Write("\nDigite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
            ExibirMensagemDeBoasVindas();
            ExibirOpcoesDoMenu();
        }

        void ExibirTituloDaOpcao(string titulo)
        {
            int quantDeLetras = titulo.Length;
            string asterisco = string.Empty.PadLeft(quantDeLetras, '*');
            Console.WriteLine(asterisco);
            Console.WriteLine(titulo);
            Console.WriteLine(asterisco + "\n");
        }

        void AvaliarumaBanda()
        {
            //Digite qual a banda deseja avaliar
            //Se a banda existir atribir uma nota
            //Caso não volta ao Menu Principal
            Console.Clear();
            ExibirTituloDaOpcao("Avaliar Banda");
            Console.Write("Digite o nome da banda que deseja avaliar: ");
            string nomedaBanda = Console.ReadLine()!;
      
            if (bandasRegistradas.ContainsKey(nomedaBanda))
            {
                Console.Write($"Qual a nota que a banda {nomedaBanda} merece: ");
                int nota = int.Parse(Console.ReadLine()!);
                bandasRegistradas[nomedaBanda].Add(nota);
                Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomedaBanda}");
                Thread.Sleep(3000);
                Console.Clear();
                ExibirMensagemDeBoasVindas();
                ExibirOpcoesDoMenu();
            }
            else
            {
                Console.WriteLine($"\nA banda {nomedaBanda} não foi encontrado.");
                Console.Write("\nDigite uma tecla para voltar ao Menu Principal");
                Console.ReadKey();
                Console.Clear();
                ExibirMensagemDeBoasVindas();
                ExibirOpcoesDoMenu();
            }
        }

        void MediadasBandas()
        {
            Console.Clear();
            ExibirTituloDaOpcao("Media das Bandas!");
            Console.Write("Digite o nome da banda que deseja a media: ");
            string nomeBandas = Console.ReadLine()!;

            if (bandasRegistradas.ContainsKey(nomeBandas))
            {
                List<int> media = bandasRegistradas[nomeBandas];
                Console.WriteLine($"\nA media da bandas {nomeBandas} e {media.Average()}");
                Console.Write("\nDigite uma tecla para voltar ao Menu Principal");
                Console.ReadKey();
                Console.Clear();
                ExibirMensagemDeBoasVindas();
                ExibirOpcoesDoMenu();
            }
            else
            {
                Console.WriteLine($"\nAluno(a) {nomeBandas} não foi encontrado.");
                Console.Write("\nDigite uma tecla para voltar ao Menu Principal");
                Console.ReadKey();
                Console.Clear();
                ExibirMensagemDeBoasVindas();
                ExibirOpcoesDoMenu();
            }
        }

        ExibirMensagemDeBoasVindas();
        ExibirOpcoesDoMenu();
    }
}
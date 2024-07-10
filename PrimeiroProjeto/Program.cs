namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // Screen Sound
            string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
            List<string> listaDasBandas = new List<string> { "U2", "The Beatles", "Linkin Park"};

            void ExibirLogo()
            {
                Console.WriteLine
                (@"
                    
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
                ");
                Console.WriteLine(mensagemDeBoasVindas);
            }

            void ExibirOpcoesDoMenu()
            {
                ExibirLogo();
                Console.WriteLine("\nDigite 1 para registrar uma banda");
                Console.WriteLine("Digite 2 para mostrar todas as bandas");
                Console.WriteLine("Digite 3 para avaliar uma banda");
                Console.WriteLine("Digite 4 para exibir a média de uma banda");
                Console.WriteLine("Digite -1 para sair");

                Console.Write("\nDigite a sua opção: ");
                int opcaoEscolhida = int.Parse(Console.ReadLine()!);

                switch (opcaoEscolhida)
                {
                    case 1: RegistrarBandas();
                        break;
                    case 2: MostrarBandasRegistradas();
                        break;
                    case 3: Console.WriteLine("Você escolheu a opção " + opcaoEscolhida);
                        break;
                    case 4: Console.WriteLine("Você escolheu a opção " + opcaoEscolhida);
                        break;
                    case -1: Console.WriteLine("Tchau tchau");
                        break;
                    default: Console.WriteLine("Opção inválida");
                        break;
                }

            }

            void RegistrarBandas()
            {
                Console.Clear();
                Console.WriteLine("******************");
                Console.WriteLine("Registro de bandas");
                Console.WriteLine("******************\n");
                Console.Write("Digite o nome da banda que deseja registrar: ");
                string nomeDabanda = Console.ReadLine()!;
                listaDasBandas.Add(nomeDabanda);
                Console.WriteLine($"A banda {nomeDabanda} foi registrada com sucesso!");
                Thread.Sleep( 2000 );
                Console.Clear();
                ExibirOpcoesDoMenu();
            }

            void MostrarBandasRegistradas()
            {
                Console.Clear();
                Console.WriteLine("************************************");
                Console.WriteLine("Exibindo todas as bandas registradas");
                Console.WriteLine("************************************\n");
                /*for (int i = 0; i < listaDasBandas.Count; i++)
                {
                    Console.WriteLine($"Banda: {listaDasBandas[i]}");
                }*/
                foreach (var banda in listaDasBandas)
                {
                    Console.WriteLine($"Banda: {banda}");
                }
                Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
                ExibirOpcoesDoMenu();
            }

            ExibirOpcoesDoMenu();

            

            /*
                Exercício 1
           
                string curso = "C#";
                string nome = "Gabriel";
                string sobrenome = "Silva";

                Console.WriteLine(curso + " " + nome + " " + sobrenome); 
            */

            /*
                Exercício 2
            Console.Write("Digite uma nota: ");
            int notaMedia = int.Parse(Console.ReadLine()!);
            if (notaMedia >= 5)
            {
                Console.WriteLine("Nota suficiente para aprovação");
            }

            List<string> linguagens = ["C#", "Java", "JavaScript"];
            Console.WriteLine(linguagens[0]);

            int posicao = int.Parse(Console.ReadLine()!);
            Console.WriteLine(linguagens[posicao]);
            */

            /*
             Exercício 3

            Random aleatorio = new Random();
            int numeroSecreto = aleatorio.Next(1, 101);

            do
            {
                Console.Write("Digite um número entre 1 e 100: ");
                int chute = int.Parse(Console.ReadLine());

                if (chute == numeroSecreto)
                {
                    Console.WriteLine("Parabéns! Você acertou o número.");
                    break;
                }
                else if (chute < numeroSecreto)
                {
                    Console.WriteLine("O número é maior.");
                }
                else
                {
                    Console.WriteLine("O número é menor.");
                }

            } while (true);

            Console.WriteLine("O jogo acabou. Você acertou o número secreto!");
            */
        }   
    }
}

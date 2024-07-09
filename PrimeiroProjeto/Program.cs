namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // Screen Sound
            string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";

            void ExibirMensagemDeBoasVindas()
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
                Console.WriteLine("\nDigite 1 para registrar uma banda");
                Console.WriteLine("Digite 2 para mostrar todas as bandas");
                Console.WriteLine("Digite 3 para avaliar uma banda");
                Console.WriteLine("Digite 4 para exibir a média de uma banda");
                Console.WriteLine("Digite -1 para sair");

                Console.Write("\nDigite a sua opção: ");
                int opcaoEscolhida = int.Parse(Console.ReadLine()!);

                switch (opcaoEscolhida)
                {
                    case 1: Console.WriteLine("Você escolheu a opção " + opcaoEscolhida);
                        break;
                    case 2: Console.WriteLine("Você escolheu a opção " + opcaoEscolhida);
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

            ExibirMensagemDeBoasVindas();
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

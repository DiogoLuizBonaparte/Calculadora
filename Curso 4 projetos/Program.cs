namespace Curso_4_projetos
{
    internal class Program
    {
        enum EMenu { Somar = 1, Subtrair, Multiplicar, Dividir, Potencia, Raiz, Sair}

        static void Main(string[] args)
        {
            bool escolheuSair = false;
            while(!escolheuSair) 
            {
                Console.WriteLine("Digite uma opção");
                Console.WriteLine("1 - Somar\n2 - Subtrair\n3 - Multiplicar\n4 - Divdir\n5 - Potencia\n6 - Raiz\n7 - Sair");

                EMenu opcaoEscohida = (EMenu)int.Parse(Console.ReadLine());
                Console.WriteLine(opcaoEscohida);

                switch (opcaoEscohida)
                {
                    case EMenu.Somar:
                        Soma();
                        break;
                    case EMenu.Subtrair:
                        Subtrair();
                        break;
                    case EMenu.Multiplicar:
                        Multiplicar();
                        break;
                    case EMenu.Dividir:
                        Divisao();
                        break;
                    case EMenu.Potencia:
                        Potencia();
                        break;
                    case EMenu.Raiz:
                        Raiz();
                        break;
                    case EMenu.Sair:
                        Console.WriteLine("Você escolheu sair. Boa sorte, até a próxima");
                        escolheuSair = true;
                        break;
                }
                Console.ReadLine();
                Console.Clear();
            }

            static void Soma()
            {
                Console.WriteLine("Digite o primeiro número");
                int number1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segunda número");
                int number2 = int.Parse(Console.ReadLine());
                int soma = number1 + number2;

                Console.WriteLine("O RESULTADO É: " + soma);
            }

            static void Subtrair()
            {
                Console.WriteLine("Digite o primeiro número");
                int number1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segunda número");
                int number2 = int.Parse(Console.ReadLine());
                int subtracao = number1 - number2;

                Console.WriteLine("O RESULTADO É: " + subtracao);
            }

            static void Multiplicar()
            {
                Console.WriteLine("Digite o primeiro número");
                int number1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segunda número");
                int number2 = int.Parse(Console.ReadLine());
                int multiplicacao = number1 * number2;

                Console.WriteLine("O RESULTADO É: " + multiplicacao);
            }

            static void Divisao()
            {
                Console.WriteLine("Digite o primeiro número");
                int number1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segunda número");
                int number2 = int.Parse(Console.ReadLine());
                float divisao = (float)number1 / (float)number2;

                Console.WriteLine("O RESULTADO É: " + divisao);
            }

            static void Potencia()
            {
                Console.WriteLine("Digite a base da pontência");
                int number1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o expoente pontência");
                int number2 = int.Parse(Console.ReadLine());

                int potencia = (int)Math.Pow(number1, number2);

                Console.WriteLine("O RESULTADO É: " + potencia);
            }

            static void Raiz()
            {
                Console.WriteLine("Digite o que será elevado a raiz");
                int number1 = int.Parse(Console.ReadLine());
                double raiz = Math.Sqrt(number1);

                Console.WriteLine("O RESULTADO É: " + raiz);
            }
        }
    }
}
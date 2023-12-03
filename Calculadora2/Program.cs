namespace Calculadora2
{

    internal class Program
    {
        enum EOpcoes { Somar = 1, Subtrair, Multiplicar, Dividir, Potencia, Raiz, Sair }

        public static void Main(string[] args)
        {

            bool saiu = false;
            while (!saiu)
            {

                Opcoes();
                EOpcoes EOpcaoEscolhida = (EOpcoes)int.Parse(Console.ReadLine());

                switch (EOpcaoEscolhida)
                {
                    case EOpcoes.Somar:
                        Somar();
                        break;
                    case EOpcoes.Subtrair:
                        Subtrair();
                        break;
                    case EOpcoes.Multiplicar:
                        Multiplicar();
                        break;
                    case EOpcoes.Dividir:
                        Dividir();
                        break;
                        break;
                    case EOpcoes.Potencia:
                        Potencia();
                        break;
                        break;
                    case EOpcoes.Raiz:
                        Raiz();
                        break;
                    case EOpcoes.Sair:
                        Sair();
                        saiu = true;
                        break;
                    default:
                        TratamentoErro();
                        break;
                }
                Console.ReadLine();
                Console.Clear();

            }
        }


    static void Opcoes()
        {
            Console.WriteLine("Escolha uma opção");
            Console.WriteLine("\"1 - Somar\n2 - Subtrair\n3 - Multiplicar\n4 - Divdir\n5 - Potencia\n6 - Raiz\n7 - Sair\"");
        }

        static void TratamentoErro()
        {
            Console.WriteLine("Opção invalida.");
             
        }    

        static void Somar()
        {
            Console.WriteLine("Você escolheu somar \n");
            Console.WriteLine("Digite o primeiro número");
            int soma1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número");
            int soma2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"O resultado da soma é: {soma1 + soma2}");
           
        }
        static void Subtrair()
        {
            Console.WriteLine("Vocês escolheu subtrair \n");
            Console.WriteLine("Digite o primeiro número");
            int sub1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número");
            int sub2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"O resultado da soma é: {sub1 - sub2}");
          
        }

        static void Multiplicar()
        {
            Console.WriteLine("Vocês escolheu multiplicar \n");
            Console.WriteLine("Digite o primeiro número");
            int mult1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número");
            int mult2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"O resultado da soma é: {mult1 * mult2}");
          }

        static void Dividir()
        {
            Console.WriteLine("Vocês escolheu dividir");
            Console.WriteLine("Digite o primeiro número");
            int div1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número");
            int div2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"O resultado da soma é: {div1 * div2}");

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

        static void Sair()
        {
            Console.WriteLine("Você escolheu sair. O programa será encerrado.");
             

        }

            
       
    }
}
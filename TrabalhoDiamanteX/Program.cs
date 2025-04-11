namespace TrabalhoDiamanteX
{
    class Program
    {
        // Menu para o usuário
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            int numeroDeLinhasEColunas = 0;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("-------------------------------------------- GERADOR DE DIAMANTES ------------------------------------------------------");
            Console.WriteLine('\n' + "                                   Bem-Vindo ao nosso gerador de diamantes!                                             " + '\n');
            Console.ResetColor();
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------" + '\n');
            Console.WriteLine("Primeiramente para calcularmos e gerarmos um diamante precisaremos de um número ímpar inteiro!");
            Console.Write("Por isso digite um número ímpar inteiro por favor(EXEMPLO: 1,3,5,7): ");
            numeroDeLinhasEColunas = VerificaImpar(numeroDeLinhasEColunas);
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------" + '\n');
            Console.WriteLine("Diamante gerado:" + '\n');
            GerarDiamante(numeroDeLinhasEColunas);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"\nDIAMANTE {numeroDeLinhasEColunas} X {numeroDeLinhasEColunas}\n");
            Console.ResetColor();
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------" + '\n');
            Console.WriteLine("Gostaria de gerar outro diamante?(S/N)");
            string resposta = Console.ReadLine().ToUpper();
            if (resposta == "S")
            {
                Console.Clear();
                Main(args);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Obrigado por usar nosso gerador de diamantes!");
                Console.WriteLine("Até a próxima!");
                Console.WriteLine();
                Console.ResetColor();
            }

        }

        //Função para verificar se o número é ímpar e se é inteiro
        static int VerificaImpar(int n)
        {
            bool valido = false;

            while (!valido)
            {
                string entrada = Console.ReadLine();

                if (int.TryParse(entrada, out n))
                {
                    if (n % 2 != 0)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Número válido");
                        valido = true;
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Número inválido! Tente novamente com um número ímpar:");
                        Console.ResetColor();
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Entrada inválida! Por favor, digite um número inteiro:");
                    Console.ResetColor();
                }
            }
            return n;
        }

        //Função para gerar o diamante
        static void GerarDiamante(int n)
        {
            int espacos = n / 2;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < espacos; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < n - espacos * 2; j++)
                {
                    Console.Write("X");
                }
                Console.WriteLine();
                if (i < n / 2)
                    espacos--;
                else
                    espacos++;
            }
        }
    }
}

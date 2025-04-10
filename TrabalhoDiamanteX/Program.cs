namespace TrabalhoDiamanteX
{
    class Program
    {
        // Menu para o usuário
        static void Main(string[] args)
        {
            Console.WriteLine('\n' + "Bem-Vindo ao nosso gerador de diamantes!" + '\n');
            Console.WriteLine("------------------------------------------------------" + '\n');
            Console.WriteLine("Primeiramente para calcularmos e gerarmos um diamante precisaremos de um número ímpar inteiro!");
            Console.Write("Por isso digite um número ímpar inteiro por favor(EXEMPLO: 1,3,5,7): ");
            int n = int.Parse(Console.ReadLine());
            n = VerificaImpar(n);
            Console.WriteLine("------------------------------------------------------" + '\n');
            Console.WriteLine("Diamante gerado:" + '\n');
            GerarDiamante(n);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"\nDIAMANTE {n} X {n}\n");
            Console.ResetColor();
            Console.WriteLine("------------------------------------------------------" + '\n');
            Console.WriteLine("Gostaria de gerar outro diamante?(S/N)");
            string resposta = Console.ReadLine().ToUpper();
            if (resposta == "S")
            {
                Console.Clear();
                Main(args);
            }
            else
            {
                Console.WriteLine("Obrigado por usar nosso gerador de diamantes!");
                Console.WriteLine("Até a próxima!");
            }

        }

        //Função para verificar se o número é ímpar
        static int VerificaImpar(int n)
        {
            while (n % 2 == 0)
            {
                Console.WriteLine("Número inválido! Tente novamente com um número ímpar:");
                n = int.Parse(Console.ReadLine());
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

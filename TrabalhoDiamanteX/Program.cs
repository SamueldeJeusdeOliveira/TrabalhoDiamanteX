namespace TrabalhoDiamanteX
{
    class Program
    {
        static void Main(string[] args)
        {
            // Menu para o usuário
            Console.WriteLine("Bem-Vindo ao nosso gerador de diamantes!" + '\n');
            Console.WriteLine("------------------------------------------------------" + '\n');
            Console.WriteLine("Primeiramente para calcularmos e gerarmos um diamante precisaremos de um número ímpar inteiro!");
            Console.Write("Por isso digite um número ímpar inteiro por favor(EXEMPLO: 1,3,5,7): ");
            int n = int.Parse(Console.ReadLine());
            n = VerificaImpar(n);
            Console.WriteLine("------------------------------------------------------" + '\n');
            Console.WriteLine(n);
        }
        public override string ToString()
        {
            return base.ToString();
        }
        static int VerificaImpar(int n)
        {
            while (n % 2 == 0)
            {
                Console.WriteLine("Número inválido! Tente novamente com um número ímpar:");
                n = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Número válido!");
            return n;
        }
    }
}
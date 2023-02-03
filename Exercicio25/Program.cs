namespace Exercicio25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o número da conta: ");
            int numConta = int.Parse(Console.ReadLine());
            Console.Write("Digite o saldo da conta: ");
            double saldo = double.Parse(Console.ReadLine());
            Console.Write("Digite o débito da conta: ");
            double debito = double.Parse(Console.ReadLine());
            Console.Write("Digite o crédito da conta: ");
            double credito = double.Parse(Console.ReadLine());

            double saldoAtual = saldo - debito + credito;

            Console.WriteLine(new String('-', 50));

            if (saldoAtual < 0.0)
            {
                Console.WriteLine($"Saldo Negativo - Saldo: R$ {saldoAtual:N2}");
            }
            else
            {
                Console.WriteLine($"Saldo Positivo - Saldo: R$ {saldoAtual:N2}");
            }

        }
    }
}
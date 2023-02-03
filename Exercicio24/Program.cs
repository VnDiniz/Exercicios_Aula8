namespace Exercicio24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o valor do salário do vendedor: ");
            double salarioFixo = double.Parse(Console.ReadLine());
            Console.Write("Insira o valor das vendas do vendedor: ");
            double valorVendas = double.Parse(Console.ReadLine());

            double comissao1 = 0.0;
            double comissao2 = 0.0;

            if (valorVendas <= 1500.0)
            {
                comissao1 = valorVendas * 0.03;
            }
            else
            {
                comissao1 = 1500.0 * 0.03;
                comissao2 = (valorVendas - 1500.0) * 0.05;
            }

            double salarioTotal = salarioFixo + comissao1 + comissao2;

            Console.WriteLine($"Salário total do vendedor: R$ {salarioTotal:N2}");

        }
    }
}
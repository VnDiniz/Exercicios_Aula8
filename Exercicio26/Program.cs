namespace Exercicio26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a quantidade atual do estoque: ");
            int qntdEstoque = int.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade máxima do estoque: ");
            int qntdMax = int.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade mínima do estoque: ");
            int qntdMin = int.Parse(Console.ReadLine());

            int qntdMedia = (qntdMax + qntdMin) / 2;

            Console.WriteLine(new String('-', 50));
            Console.WriteLine($"Quantidade Atual: {qntdEstoque}\nQuantidade Média: {qntdMedia}");

            if (qntdEstoque >= qntdMedia)
            {
                Console.WriteLine("-> Não efetuar compra.");
            }
            else{
                Console.WriteLine("-> Efetuar compra.");
            }
        }
    }
}
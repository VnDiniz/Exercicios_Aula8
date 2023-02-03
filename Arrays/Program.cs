namespace Arrays
{
    internal class Program
    {

        // Declarar array com parâmetro
        private static decimal CalcularMedia(params decimal[] notas)
        {
            // Definição da varriável soma = 0
            decimal soma = 0;

            // Iterar o array notas e acumular seus valores
            for (int i = 0; i < notas.GetLength(0); i++)
            {
                soma += notas[i];   // somas = somas + notas[i]
            }

            return soma / notas.Length;
        }

        private static void ExibirParametros(params object[] valores)
        {
            foreach (object i in valores)
            {
                Console.WriteLine($"Valor: {i}");
                Console.WriteLine($"Tipo: {i.GetType()}");
                Console.WriteLine(new String('-', 50));
            }
        }


        static void Main(string[] args)
        {
            // <tipo>[] <nomeDoArray> = new <tipo>[qtd]

            // Array Unidimensional
            string[] aluno = new string[5];

            aluno[0] = "Jhonny";
            aluno[1] = "Vinicius";
            aluno[2] = "Guilherme";
            aluno[3] = "Fernando";
            aluno[4] = "Romulo";

            string[] aluno2 = new string[3] { "Vinicius", "Fernando", "Guilherme" };

            for (int i = 0; i < aluno.Length; i++)
            {
                Console.WriteLine($"Aluno #{i+1}: {aluno[i]}");
            }

            // Array bidimensional
            int[,] numeros =
            {
                { 17, 22, 12, 44, 34 },
                { 23, 33, 12, 21, 45 }
            };

            Console.WriteLine(new String('-', 50));
            Console.WriteLine($"Valor na posição [1,1]: {numeros[1, 1]}");

            Console.WriteLine(new String('-', 50));

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine($"Posição [{i},{j}]: {numeros[i, j]}");
                }
            }

            Console.WriteLine(new String('-', 50));

            Console.WriteLine("Arrays passando parâmetros");
            decimal[] valor = { 5, 7 ,8, 9 };

            Console.WriteLine("Média: " + CalcularMedia(valor));
            Console.WriteLine("Média 2: " + CalcularMedia(15, 20, 60));

            Console.WriteLine(new String('-', 50));

            ExibirParametros("Vinicius", 4.5m, 'C', 12.89);

        }
    }
}
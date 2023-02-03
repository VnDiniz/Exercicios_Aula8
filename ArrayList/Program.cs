using System.Collections;

namespace ArrayListAula
{
    internal class Program
    {
        static void ListarListas(ArrayList nomeLista)
        {
            for (int i = 0; i < nomeLista.Count; i++)
            {
                Console.WriteLine($"Elemento #{i + 1}: {nomeLista[i]}");
            }
        }

        static void Main(string[] args)
        {
            // Definir o ArrayList
            ArrayList lista = new ArrayList();

            // ArrayList é um array de objetos que tem seus próprios 
            // métodos para:
            // inserir, adicionar, procurar, ordenar etc.
            /*
            * Métodos Importantes:
            * Add(objeto)
            * Insert(posição, objeto)
            * IndexOf(objeto)
            * Remove(objeto)
            * RemoveAt(posição)
            * Sort()
            */

            lista.Add("Computador");
            lista.Add("Lápis");
            lista.Add("Borracha");
            ListarListas(lista);
            Console.WriteLine(new String('-', 50));

            lista.Remove("Lápis");
            ListarListas(lista);
            Console.WriteLine(new String('-', 50));

            lista.Insert(0, "Mouse");
            ListarListas(lista);
            Console.WriteLine(new String('-', 50));

        }
    }
}
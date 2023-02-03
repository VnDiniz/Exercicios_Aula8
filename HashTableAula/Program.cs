using System.Collections;

namespace HashTableAula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable dePara = new Hashtable();

            dePara.Add("1", "Régua");
            dePara.Add("2", "Lápis");
            dePara.Add("3", "Borracha");
            dePara.Add("4", "Caneta");
            dePara.Add("5", "Estojo");

            foreach (DictionaryEntry i in dePara)
            {
                Console.WriteLine(i.Key + " - " + i.Value);
            }

        }
    }
}
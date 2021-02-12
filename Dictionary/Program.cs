using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> dictionary = new MyDictionary<int, string>();

            dictionary.Add(0, "kalem");
            dictionary.Add(1, "masa");
            dictionary.Add(2, "Ebru");
            dictionary.Add(3, "renk");

            Console.WriteLine("--------------------------");

            dictionary.List();

            Console.WriteLine("--------------------------");

            Console.WriteLine(dictionary.Count);
        }
    }
}

using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> names = new MyList<string>();
            names.Add("Sümeyye Nur");
            names.Add("Merve Nur");

            Console.WriteLine("Listemin uzunluğu: {0}", names.Length);

            foreach (var name in names.Items)
            {
                Console.WriteLine("Listemdeki ad: {0}", name);
            }
        }
    }
}

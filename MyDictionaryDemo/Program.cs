using System;

namespace MyDictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> meyveler = new MyDictionary<int, string>();
            meyveler.Add(01, "Elma");
            meyveler.Add(02, "Karpuz");
            meyveler.Add(03, "Kiraz");
            meyveler.Add(04, "Portakal");
            meyveler.Add(05, "Üzüm");
            meyveler.Add(06, "Ananas");
            meyveler.Add(07, "Armut");
            meyveler.Add(08, "Kavun");
            meyveler.Add(09, "Kivi");

            foreach (var id in meyveler.Keys)
            {
                Console.WriteLine(id);
            }
            foreach (var meyve in meyveler.Values)
            {
                Console.WriteLine(meyve);
            }
        }
    }
}

using System;

namespace consoleprogrammingtester
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("İsminizi Giriniz");
            string name = Console.ReadLine();
            Console.WriteLine("Soyadınızı Girin");
            string surname = Console.ReadLine();

            Console.WriteLine("Merhaba" + name+ " " + surname);
        }
    }
}

using System;

namespace Degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            byte x = 5;     // Bellekte 1 byte yer tutar 
            sbyte y = 5;    // Bellekte 1 byte yer tutar 

            short s = 5;    // Bellekte 2 byte yer tutar 
            ushort us = 5;  // Bellekte 2 byte yer tutar 
            
            int i = 2;      // Bellekte 4 byte yer tutar
            Int16 i16 = 2;  // Bellekte 2 byte yer tutar
            Int32 i32 = 2;  // Bellekte 4 byte yer tutar
            Int64 i64 = 2;  // Bellekte 8 byte yer tutar

            uint ui = 2;    // Bellekte 4 byte yer tutar
            long l = 4;     // Bellekte 8 byte yer tutar
            ulong ul = 4;   // Bellekte 8 byte yer tutar
            
            //Reel sayılar

            float f = 5;    // Bellekte 4 byte yer tutar
            double d = 5;   // Bellekte 8 byte yer tutar
            decimal dc = 5; // Bellekte 16 byte yer tutar

            char ch = '2';      // Bellekte 2 byte yer tutar
            string str = "Nuh";  // Bellekte sınırsız yer tutar

            bool b1 = true;
            bool b2 = false;

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);

            object o1 = "x";
            object o2 = 'y';
            object o3 = 4;
            object o4 = 4.3;

            // string 

            string str1 = string.Empty;
            str = "Nuh Aktürk";
            string ad = "Nuh";
            string soyad = "Aktürk";
            string tamIsim = ad + " " + soyad;

            //integer

            int integer1 = 5;
            int integer2 = 3;
            int integer3 = integer1 * integer2;

            //boolean

            bool bool1 = 20>2;

            // Değişken Dönüşümleri

            string str20 = "20";
            int integer20 = 23;
            string yeniDeger = str20 + integer20.ToString();
            Console.WriteLine(yeniDeger); // Çıktısı 2023

            int integer21 = integer20 + Convert.ToInt32(str20);
            Console.WriteLine(integer21); // Çıktısı 41

            int integer22 = integer20 + int.Parse(str20);
            Console.WriteLine(integer22); // Çıktısı 41

            // datetime

            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);

            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(datetime2);

            //saat

            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);
        }
    }
}

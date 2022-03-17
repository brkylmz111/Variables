using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                //atama ve işlemli atama
                int x = 3;
                int y = 3;
                y = y + 2;

                Console.WriteLine(y);
                y += 2;
                Console.WriteLine(y);
                y /= 3;
                Console.WriteLine(x);
                x *= 2;
                //mantıksal operatörler
                // ||,,!
                bool isSucces = true;
                bool isCompleted = false;

                if (isSucces && isCompleted)
                    Console.WriteLine("perfect");

                if (isSucces || isCompleted)
                    Console.WriteLine("great");
                if (isSucces && isCompleted)
                    Console.WriteLine("fine");

                //ilişkisel operatörler

                int a = 3;
                int b = 4;
                bool sonuc = a < b;

                Console.WriteLine(sonuc);
                sonuc = a > b;
                Console.WriteLine(sonuc);
                sonuc = a >= b;
                Console.WriteLine(sonuc);
                sonuc = a <= b;
                Console.WriteLine(sonuc);
                sonuc = a == b;
                Console.WriteLine(sonuc);
                //aritmatik operatörler

                int sayi = 10;
                int sayi2 = 5;
                int sonuc1 = sayi/sayi2;
                Console.WriteLine(sonuc1);
                int sonuc2 = sayi * sayi2;
                Console.WriteLine(sonuc2);
                int sonuc3 = sayi  + sayi2;
                Console.WriteLine(sonuc3);
                int sonuc4 = sayi++;
                Console.WriteLine(sonuc4);

            }
        }
    }
}
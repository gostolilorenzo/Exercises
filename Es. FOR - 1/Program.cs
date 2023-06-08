using System;
using System.Reflection.Metadata;

namespace Es.Cicli
{
    class Program
    {
        static void Main(string[] args)
        {

            //STAMPA 500 NUMERI

            //int n = 1;

            //while (n <= 500)
            //{
            //    Console.WriteLine($"{n} ");
            //    n++;
            //}
            //Console.WriteLine("Premi un tasto per continuare ...");
            //Console.ReadKey();

            //int n = 1;      
            //int trovati = 0;
            //int numeroBello = 7;
            //int numeroCheAumenta = 1;


            //Console.WriteLine(n % 2 != 0 ? : n++);


            //PRIMI 100 NUMERI DISPARI

            //do
            //{
            //    if (n % 2 != 0)
            //    {
            //        console.writeline(n);
            //        trovati++;
            //    }
            //    n++;
            //}
            //while (trovati < 100);           


            //MULTIPLI DI 7

            //do
            //{
            //    n = numeroBello * trovati;
            //    Console.WriteLine(n);
            //    trovati++;               
            //}

            //while (trovati <= 50);


            //SOMMA DEI PRIMI 100 NUMERI INTERI

            int n = 0;
            int trovati = 0;

            do
            {
                n = n + trovati;                
                trovati++;
            }
            while (trovati <= 100); Console.WriteLine($"SOMMA DEI PRIMI 100 NUMERI INTERI: {n }");

        }
    }
}
using System;
using System.Threading;

namespace Struttura_Selettiva
{
    class Program
    {
        static void Main(string[] args)
        {
            string lettura = "";
            bool prima_volta_in_italia = false;

            do
            {
                Console.WriteLine("Quanti anni hai (exit per teminare)? -> ");
                lettura = Console.ReadLine();

                if (int.TryParse(lettura, out int eta) && eta > 0 && eta <= 120)
                {
                    Console.WriteLine(eta >= 18 ? "Sei maggiorenne" : "Sei minorenne");

                    if (eta >= 12 && eta < 18 || eta >= 65 && eta <= 75)
                        Console.WriteLine("Hai diritto a uno sconto!");

                    if (eta < 12 || eta > 65 && prima_volta_in_italia)
                        Console.WriteLine("Ingresso gratuito!");

                }
                else
                    Console.WriteLine("Devi inserire un valore numerico valido! Compreso tra 1 e 120");
            }
            while (lettura != "exit");
        }
    }
}
using System;
using System.Reflection.Metadata;

namespace Calcolatrice
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;

            Console.WriteLine("1-Inserisci un numero\n2-Inserisci il tipo: \n\taddizione = a\n\tsottrazione = s\n\tmoltiplicazione = m\n\tdivisione = d\n3-secondo numero");
            if (int.TryParse(Console.ReadLine(), out num1))
            {
                if (Console.ReadLine() == "a")
                {
                    if (int.TryParse(Console.ReadLine(), out num2))
                    {
                        Console.WriteLine($"Il tuo riusltato è: {num1 + num2} !");
                    }
                }
                else if (Console.ReadLine() == "s")
                {
                    if (int.TryParse(Console.ReadLine(), out num2))
                    {
                        Console.WriteLine($"Il tuo riusltato è: {num1 - num2} !");
                    }
                }
                else if (Console.ReadLine() == "m")
                {
                    if (int.TryParse(Console.ReadLine(), out num2))
                    {
                        Console.WriteLine($"Il tuo riusltato è: {num1 * num2} !");
                    }
                }
                else if (Console.ReadLine() == "d")
                {
                    if (num2 > 0)
                    {
                        if (int.TryParse(Console.ReadLine(), out num2))
                        {
                            Console.WriteLine($"Il tuo riusltato è: {num1 / num2} !");
                        }
                    }                 
                }
            }
        }
    }
}
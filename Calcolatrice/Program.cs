using System;
using System.Threading;

namespace Calcolatrice
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num1 = 0;
            //int num2 = 0;

            //Console.WriteLine("1-Inserisci un numero\n2-Inserisci il tipo: \n\taddizione = a\n\tsottrazione = s\n\tmoltiplicazione = m\n\tdivisione = d\n3-secondo numero");
            //if (int.TryParse(Console.ReadLine(), out num1))
            //{
            //    if (Console.ReadLine() == "a")
            //    {
            //        if (int.TryParse(Console.ReadLine(), out num2))
            //        {
            //            Console.WriteLine($"Il tuo riusltato è: {num1 + num2} !");
            //        }
            //    }
            //    else if (Console.ReadLine() == "s")
            //    {
            //        if (int.TryParse(Console.ReadLine(), out num2))
            //        {
            //            Console.WriteLine($"Il tuo riusltato è: {num1 - num2} !");
            //        }
            //    }
            //    else if (Console.ReadLine() == "m")
            //    {
            //        if (int.TryParse(Console.ReadLine(), out num2))
            //        {
            //            Console.WriteLine($"Il tuo riusltato è: {num1 * num2} !");
            //        }
            //    }
            //    else if (Console.ReadLine() == "d")
            //    {
            //        if (int.TryParse(Console.ReadLine(), out num2))
            //        {
            //            if (num2 > 0)
            //            {
            //                Console.WriteLine($"Il tuo riusltato è: {num1 / num2} !");
            //            }
            //        }                 

            //    }
            //}

            string selezione = "";
            do
            {
                Console.WriteLine("Benvenuti nella Home di questa fantastica calcolatrice!\n");
                Console.WriteLine("1 -> seleziona che tipo di operazione vuoi fare: ");
                Console.WriteLine("\t1 - Addizioni");
                Console.WriteLine("\t2 - Sottrazioni");
                Console.WriteLine("\t3 - Moltiplicazioni");
                Console.WriteLine("\t4 - Divisioni");
                Console.WriteLine("\t5 - Potenze");
                Console.WriteLine("\t6 - Radice quadrata");

                Console.WriteLine("\t9 - exit");    

                Console.WriteLine();

                Console.Write("SCEGLI -> ");
                selezione = Console.ReadLine();

                if (int.TryParse(selezione, out int operazione) && operazione >= 1 && operazione <= 5 || operazione == 6 || operazione == 9)
                {
                    int op1 = 0, op2 = 0;

                    if (operazione != 6 && operazione != 9) 
                    {
                        Console.WriteLine("Primo operando -> ");
                        int.TryParse(Console.ReadLine(), out op1);

                        Console.WriteLine($"{Environment.NewLine}Secondo operando -> ");
                        int.TryParse(Console.ReadLine(), out op2);
                    }
                    
                    if (operazione == 6);
                        Console.WriteLine("Inserisci il numero -> ");
                        int.TryParse(Console.ReadLine(), out op1);
                    
                    switch (operazione)
                    {
                        case 1:
                            Console.WriteLine($"{op1} + {op2} = {op1 + op2}");

                            break;

                        case 2:
                            Console.WriteLine($"{op1} - {op2} = {op1 - op2}");

                            break;

                        case 3:
                            Console.WriteLine($"{op1} * {op2} = {op1 * op2}");

                            break;

                        case 4:
                            if (op2 != 0)
                                Console.WriteLine($"{op1} / {op2} = {op1 / op2}");
                            else
                                Console.WriteLine("Impossibile dividere per zero!");

                            break;

                        case 5:
                            Console.WriteLine($"{op1} elevato alla {op2} = {Math.Pow(op1, op2)}");

                            break;
                        
                        case 6:
                            Console.WriteLine($"Radice quadrata di {op1} = {Math.Sqrt(op1)}");

                            break;
                    }
                }
                Console.ReadKey();
                Console.Clear();
            }
            while (selezione != "exit");
        }
    }
}
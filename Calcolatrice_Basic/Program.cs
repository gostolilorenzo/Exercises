using System;
using System.Threading;

namespace Calcolatrice_Basic
{
    class Program
    {

        static bool exp1() { Console.Write("exp1\n"); return true; }
        static bool exp2() { Console.Write("exp2\n"); return true; }
        static bool exp3() { Console.Write("exp3\n"); return true; }
        static bool exp4() { Console.Write("exp4\n"); return true; }

        static void Main(string[] args)
        {


            string scelta = "";
            do
            {
                Console.WriteLine("MENU\n");
                Console.WriteLine("a - Somme");
                Console.WriteLine("b - Sottrazioni");
                Console.WriteLine("c - Prodotti");
                Console.WriteLine("d - Divisioni");
                Console.WriteLine("e - Potenze");
                //Console.WriteLine("f - Radici Quadrate");
                Console.WriteLine("z - ESCI");

                Console.WriteLine();

                Console.Write("SCEGLI -> ");
                //scelta = Console.ReadLine();

                ConsoleKeyInfo tasto = Console.ReadKey();
                char operazione = tasto.KeyChar;

                //bool esito = int.TryParse(scelta, out int operazione);

                int op1 = 0, op2 = 0;

                if (operazione != 'z' && operazione >= 'a' && operazione <= 'e')
                {
                    Console.Write($"{Environment.NewLine}Primo operando -> ");
                    int.TryParse(Console.ReadLine(), out op1);

                    Console.Write($"{Environment.NewLine}Secondo operando -> ");
                    int.TryParse(Console.ReadLine(), out op2);
                }
                //else (operazione == 'f')
                //{
                //    Console.WriteLine($"Radice quadrata di {op1} = {Math.Sqrt(op1)}");
                //}

                switch (operazione)
                {

                    case 'a':
                        Console.WriteLine($"{op1} + {op2} = {op1 + op2}");
                        break;

                    case 'b':
                        Console.WriteLine($"{op1} - {op2} = {op1 - op2}");
                        break;

                    case 'c':
                        Console.WriteLine($"{op1} * {op2} = {op1 * op2}");
                        break;

                    case 'd':
                        if (op2 != 0)
                            Console.WriteLine($"{op1} / {op2} = {(double)op1 / op2}");
                        else
                            Console.WriteLine("Impossibile dividere per zero!");
                        break;

                    case 'e':
                        Console.WriteLine($"{op1} elevato alla {op2} = {Math.Pow(op1, op2)}");
                        break;

                    //case 'f':
                    //    Console.WriteLine($"Radice quadrata di {op1} = {Math.Sqrt(op1)}");
                    //    break;

                    case 'z':
                        Console.WriteLine("Grazie per aver usato la calcolatrice");
                        break;

                    default:
                        Console.WriteLine(" Scelta non valida");
                        break;
                }
                /*Per far riferimento a più case usare "goto" es. case "a" + "b" = "a" goto "b" 
                usare "when" quando vogliamo aggiungere una condizione al case
                */
                Console.ReadKey();
                Console.Clear();
            }
            while (scelta != "9");
        }
    }
}
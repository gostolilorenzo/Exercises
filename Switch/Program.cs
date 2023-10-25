using System;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Globalization;
using System.Text.RegularExpressions;

namespace switch_test
{

    enum GiorniSettimana { Lun = 1, Mar, Mer, Gio, Ven, Sab, Dom };
    class Program
    {
        static void Main(string[] args)
        {
            //int eta = 23; int stipendio = 4000;
            //string colore = "";
            //do
            //{
            //    Console.WriteLine("Qual è il tuo colore preferito?");
            //    colore = Console.ReadLine();

            //    switch (colore)
            //    {
            //        case "Verde scuro":
            //            Console.WriteLine("Sei un tipo tenebroso");
            //            goto case "Verde";

            //        case "Giallo":
            //        case "giallo":
            //            Console.WriteLine("Un colore solare!");
            //            continue;
            //        case "Verde":
            //            Console.WriteLine("Il colore degli smeraldi!");
            //            break;
            //        case "grigio" when eta < 15 && stipendio > 3000:
            //            Console.WriteLine("Non può piacerti questo colore alla tua età!");
            //            break;
            //        default:
            //            Console.WriteLine("Un colore come qualunque altro");
            //            break;
            //    }

            //    //molte istruzioni ..
            //    Console.WriteLine("Sono passato di qui!");

            //} while (colore != "nero");

            CultureInfo[] cultures = CultureInfo.GetCultureInfo(CultureTypes.AllCultures);

            CultureInfo[] cultures = new CultureInfo("En-en");

            Console.WriteLine("Inserisci un numero con la virgola\n");
            double.TryParse(Console.ReadLine(), NumberStyles.Float | NumberStyles.AllowThousands,
                            culture, out double d);
            switch (d)
            {
                case 3.14:
                    Console.WriteLine("Il famoso PI greco!");
                    break;

                default:
                    Console.WriteLine("un double come un altro...");
                    break;
            }

            Console.WriteLine(d.ToString(culture));
            //int eta = 23; int stipendio = 4000;
            //string colore = "ciao";
            //double d = 3.14;
            //long l = 345;

            //object x = eta;

            //switch (x)
            //{
            //    case int num_int:
            //        Console.WriteLine($"Elaboro un intero: {num_int}");
            //        break;

            //    case double num_double:
            //        Console.WriteLine($"Elaboro un intero: {num_double}");
            //        break;

            //    case string stringa:
            //        Console.WriteLine($"Elaboro una stringa: {stringa}");
            //        break;

            //    case default:
            //        Console.WriteLine($"Tipo di dato non previsto: {x.ToString()}");
            //        break;
            //}

            //int giorno = 3;
            //string giorno_settimana = giorno switch
            //{
            //    1 => "Lunedì",
            //    2 => "Martedì",
            //    3 => "Mercoledì",
            //    _ => "Non è un giorno della settimana correttamente codificato"
            //};

            //Console.WriteLine(giorno_settimana);

            //Console.WriteLine(giorno switch
            //    {
            //        1 => "Lunedì",
            //        2 => "Martedì",
            //        3 => "Mercoledì",
            //        _ => "Non è un giorno della settimana correttamente codificato"
            //    }
            //);

        }
    }
}
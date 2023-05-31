using System;
using System.IO;

namespace conta_vocali_consonanti_punteggiatura
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Inserisci una frase");
            //string lettura = Console.ReadLine();

            //int vocali = 0, consonanti = 0, punteggiatura = 0, cifre=0;


            //S E N Z A  A R R A Y

            //foreach (char c in lettura)
            //  switch (char.ToLower(c))
            //  {
            //    case 'a': case 'e': case 'i': case 'o': case 'u':
            //      vocali++;
            //    break;

            //    case '.': case ',': case ' ': case ';': case '!':
            //      punteggiatura++;
            //    break;

            //    case '0': case '1': case '2': case '3': case '4': case '5':
            //    case '6': case '7': case '8': case '9':
            //      cifre++;
            //      break;

            //    default:
            //      consonanti++;
            //    break;
            //  }

            //foreach (char c in lettura)
            //{
            //  if ("aeiou".Contains(char.ToLower(c)))
            //    vocali++;
            //  else 
            //    if ("!?.,:; /{}\"".Contains(char.ToLower(c)))
            //      punteggiatura++;
            //    else 
            //      if ("bcdfghjklmnpqrstvwxyz".Contains(char.ToLower(c)))
            //        consonanti++;
            //      else
            //        if ("0123456789".Contains(char.ToLower(c)))
            //          cifre++;
            //}

            //foreach (char c in lettura)
            //{
            //  if ("aeiou".Contains(char.ToLower(c)))
            //    vocali++;
            //  else
            //    if (char.IsPunctuation(c))
            //    punteggiatura++;
            //  else
            //    if (char.IsLetter(c))
            //      consonanti++;
            //    else
            //       if (char.IsDigit(c))
            //        cifre++;
            //}
            //Console.WriteLine($"Vocali: {vocali}, Consonanti: {consonanti}, " +
            //                  $"Punteggiatura: {punteggiatura}, Cifre: {cifre}"); 

            // UN ALTRO ESERCIZIO 
            //DirectoryInfo cartella = new DirectoryInfo(".");
            //long totale_spazio = 0;

            //foreach (FileInfo file in cartella.GetFiles())
            //{
            //  Console.WriteLine($"File: {file.Name.PadRight(60, ' ')} - Dimensione: {file.Length}bytes");
            //  totale_spazio += file.Length;
            //}

            //Console.WriteLine($"\n----------Totale spazio occupato dalla cartella:  {totale_spazio}bytes");


            //C O N T A   O C C O R R E N Z E - V E R S O  G L I  A R R A Y

            //La soluzione del masochista
            //int a=0, b=0, c=0, d=0; //ecc. abbiate pieta!

            Console.WriteLine("Inserisci una frase");
            string lettura = Console.ReadLine();

            //foreach (char lettera in lettura)
            //  switch (lettera)
            //  {
            //    case 'a': a++; break;
            //    case 'b': b++; break;
            //    case 'c': c++; break;
            //    case 'd': d++; break;
            //  }

            //con le stringe - variante 1
            //string alfabeto = "abcdefghkilmnopqrstuvwxyz01234567890-=+_.,?()%$^&*/";

            //foreach(char lettera in alfabeto)
            //{
            //  int occorrenze = 0;

            //  foreach (char c in lettura)
            //    if (c == lettera) occorrenze++;

            //  if (occorrenze > 0)
            //    Console.WriteLine($"Simbolo {lettera} trovato {occorrenze} volt{(occorrenze>1 ? 'e' : 'a')}");
            //}

            string alfabeto = "abcdefghkilmnopqrstuvwxyz01234567890-=+_.,?()%$^&*/";

            string risultato = "";

            foreach (char simbolo in alfabeto)
            {
                int occorrenze = 0;

                foreach (char c in lettura)
                    if (c == simbolo) occorrenze++;

                if (occorrenze > 0)
                {
                    Console.WriteLine($"Simbolo {simbolo} trovato {occorrenze} volt{(occorrenze > 1 ? 'e' : 'a')}");
                    risultato += simbolo + occorrenze.ToString().PadLeft(5, '0');
                }
            }
            Console.WriteLine(risultato);

            char cercato = 'c';
            for (int i = 0; i < risultato.Length / 6; i++)
            {
                string blocco = risultato.Substring(6 * i, 6);

                if (blocco[0] == cercato)
                {
                    int occorrenze = int.Parse(blocco.Substring(1, 5));
                    Console.WriteLine($"Simbolo {cercato} trovato {occorrenze} volt{(occorrenze > 1 ? 'e' : 'a')}");
                    break;
                }
            }




        }
    }
}
using System;

namespace array_1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Inserisci una frase");
            //string lettura = Console.ReadLine();

            //string alfabeto = "abcdefghkilmnopqrstuvwxyz01234567890-=+_.,?()%$^&*/";
            //int[] contatori = new int[alfabeto.Length];

            //contatori[0] = 222;
            //contatori[10] = 1000;
            //Console.WriteLine($"L'array contatori può memorizzare {contatori.Length} numeri interi");

            //ESEMPIO 1
            int max_numeri = 50;
            int[] numeri_casuali = new int[max_numeri];

            Random r = new Random();
            for (int i = 0; i < max_numeri; i++)
                numeri_casuali[i] = r.Next();

            foreach (int n in numeri_casuali)
                Console.Write($"{n} ");

            //sommatoria
            long somma = 0;
            foreach (int n in numeri_casuali)
                somma += n;
            Console.WriteLine($"\n\nSommatoria: {somma}");

            double media = (double)somma / max_numeri;
            Console.WriteLine($"\n\nMedia: {media}");

            string[] colori = { "giallo", "verde", "rosso" };
            Console.WriteLine(colori[1]);

            //scegli il primo numero e confrontalo con gli altri se c'è un numero più piccolo usa quello per il confronto

            int min_num = 0;

            for (int i = 0; i < max_numeri; i++) //faccio il codice seguente 50 volte
            {
                if (numeri_casuali[i] < numeri_casuali[min_num])
                {
                    min_num = i;
                }

                //if (numeri_casuali[i] < numeri_casuali[i + 1];
            }
            Console.WriteLine(numeri_casuali[min_num]);


            int max_num = 0;
            for (int i = 0; i < max_numeri; i++) //faccio il codice seguente 50 volte
            {
                if (numeri_casuali[i] > numeri_casuali[max_num])
                {
                    max_num = i;
                }

                //if (numeri_casuali[i] < numeri_casuali[i + 1];
            }
            Console.WriteLine(numeri_casuali[max_num]);

            //ARRAY
            //nomeArray[posizione]


            //if (numeri_casuali[0] < numeri_casuali[1])

        }
    }
}
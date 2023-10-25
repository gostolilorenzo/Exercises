using System.Numerics;

string testo = Console.ReadLine();

int conta_voc = 0;
int conta_con = 0;
int conta_num = 0;
int conta_seg = 0;
int conta_let = 0;
int conta_tot = 0;

foreach (char t in testo)
{
    if (Char.IsLetter(t))

    {
        if (t == 'a' || t == 'A' || t == 'e' || t == 'E' || t == 'i' || t == 'I' || t == 'o' || t == 'O' || t == 'u' || t == 'U')
        {
            conta_voc++;
        }
        else
        {
            conta_con++;
        }
    }

    else if (Char.IsNumber(t))
    { conta_num++; }
}
Console.WriteLine($"\nVocali totali trovate {conta_voc}");
Console.WriteLine($"\nConsonanti totali trovate {conta_con}");
Console.WriteLine($"\nNumeri totali trovati {conta_num}");

conta_let = conta_voc + conta_con;
Console.WriteLine($"\nLettere totali trovate {conta_let}");

conta_tot = conta_let + conta_num;
Console.WriteLine($"\nCaratteri totali trovati {conta_tot}");
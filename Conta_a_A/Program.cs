string numeri = Console.ReadLine();
int cont = 0;
foreach (char c in numeri)
{
    if (c == 'a' || c == 'A')
    {
        cont++;
    }

}
Console.WriteLine($"Trovate {cont} a/A");

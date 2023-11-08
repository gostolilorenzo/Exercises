string numeri = Console.ReadLine();
int cont = 0;

//foreach (char c in numeri)
//{
//    if (c == 'a' || c == 'A')
//    {
//        cont++;
//    }

//}
//Console.WriteLine($"Trovate {cont} a/A");


foreach (char c in numeri)
    if ("aA".Contains(c) ) cont++;

Console.WriteLine($"Trovate {cont} a/A");


//foreach (char c in Console.ReadLine() )
//    if ("aA".Contains(c)) cont++;

//Console.WriteLine($"Trovate {cont} a/A");


//quest'ultimo esempio si usa se poi non dobbiamo farcene nulla di questo blocco di codice
string nome1, auxiliar;
string nome2;

Console.WriteLine("troca de nomes \n");

Console.Write("nome1 = ");
nome1 = Console.ReadLine()!;

Console.Write("nome2 = ");
nome2 = Console.ReadLine()!;

auxiliar = nome1;
nome1 = nome2;
nome2 = auxiliar;

Console.WriteLine($"nome1 = {nome1}");
Console.WriteLine($"nome2 = {nome2}");


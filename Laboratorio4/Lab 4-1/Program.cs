static void Main(string[] args)
{
    int x, n;
    string linea;
    Console.Write("Ingrese  el valor de : ");
    linea = Console.ReadLine();
    n = int.Parse(linea);
    x = 1;

    while (x <= n)
    {
        Console.Write(x);
        Console.Write(" , ");
        x = x + 1;
    }
    Console.ReadKey();

}
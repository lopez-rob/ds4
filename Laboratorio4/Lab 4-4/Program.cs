class Program 
{ 
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese la nota del estudiante: ");
        float score = float.Parse(Console.ReadLine());

        if (score >= 70)
        {
            Console.WriteLine();
            Console.WriteLine($"Su nota es: {score}. Ha aprobado!");
        }
        else 
        {
            Console.WriteLine();
            Console.WriteLine($"Su nota es: {score}. Ha reprobado, debe repetir.");
        }
    }
}
using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Hallo! Wie heißt du?");
        string name = Console.ReadLine();
        Console.WriteLine("Wie alt bist du?");
        string alter = Console.ReadLine();
        Console.WriteLine("Wie ist dein Wohnort?");
        string wohnort = Console.ReadLine();
        Console.WriteLine("--------");
        Console.WriteLine("Dein Name ist " + name+".");
        Console.WriteLine($"Du bist {alter} Jahre alt und wohnst in {wohnort}!");
        Console.WriteLine("Schön dich kennenzulernen {0} !", name);
        Console.WriteLine("________");
        Console.WriteLine("Drücke eine Taste zum Beenden!");
        Console.ReadKey();
    }
}

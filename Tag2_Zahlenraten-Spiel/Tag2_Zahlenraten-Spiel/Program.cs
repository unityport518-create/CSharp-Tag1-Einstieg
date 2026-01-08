using System;
class Program
{
    static void Main()
    {
        Random random = new Random();
        int geheimzahl = random.Next(1, 11);

        Console.WriteLine("Hallo! Schön, dass du wieder da bist. Hier ist ein Zahlenraten-Spiel. Rate eine Zahl von 1 bis 10.");
        string eingabe = Console.ReadLine();
        int zahl;

        if(!int.TryParse(eingabe, out zahl))
        {
            Console.WriteLine("Bitte gib eine Zahl ein.");
            Console.ReadKey();
            return;
        }
        if(zahl < 1 || zahl > 10)
        {
            Console.WriteLine("Ungültige Eingabe. Bitte gib eine Zahl zwischen 1 und 10 ein");
            Console.ReadKey();
            return;
        }
        if(zahl < geheimzahl)
        {
            Console.WriteLine($"Die Zahl {zahl} ist zu klein.");
        }
        else if(zahl > geheimzahl)
        {
            Console.WriteLine($"Die Zahl {zahl} ist zu groß");
        }
        else
        {
            Console.WriteLine("Stimmt! Du hast die Geheimzahl richtig geraten");
        }
        Console.WriteLine($"Die Geheimzahl war {geheimzahl}");
        Console.WriteLine("Drücke eine Taste, um das Programm zu beenden");
        Console.ReadKey();
    }
}
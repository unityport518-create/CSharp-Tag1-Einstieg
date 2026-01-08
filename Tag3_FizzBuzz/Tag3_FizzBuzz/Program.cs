using System;
class Programm
{
    static void Main()
    {
        int i = 1;
        while (i != 101)
        {
            
            
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
               
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine("Fizz");
               
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("Buzz");
               
            }
            else
            {
                Console.WriteLine(i);
            }
            i++;

                
            
            
        }
        Console.WriteLine("Bitte drücken Sie eine beliebige Taste, um das Programm zu beenden.");
        Console.ReadKey();
    }
}
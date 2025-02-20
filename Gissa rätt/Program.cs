using System;

namespace Gissa_rätt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gissa ett tal mellan 1 och 100");
            String gissa = Console.ReadLine();
            int tal = Convert.ToInt32(gissa);
            Random randomerare = new Random();
            int slump_tal = randomerare.Next(1, 101); // här skapar vi slumptalet
            int counter = 1;
            while (tal != slump_tal)
                {
                counter++; 
                if (tal < slump_tal) 
                { Console.WriteLine("Du gissade för lågt.");
                    gissa = Console.ReadLine();
                    tal = Convert.ToInt32(gissa);
                } //om du gissar för högt får du detta och en ny chans att gissa

                else if (tal > slump_tal) 
                { Console.WriteLine("Du gissade för högt.");
                    gissa = Console.ReadLine();
                    tal = Convert.ToInt32(gissa);
                } //om du gissar för högt får du detta och en ny chans att gissa



            }
            Console.WriteLine("Grattis! du gissade rätt! Du gissade" +" "+ counter +" "+ "gånger");
            Console.ReadLine();
        }
    }
}

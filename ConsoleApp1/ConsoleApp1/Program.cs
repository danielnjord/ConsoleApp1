using System.Timers;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool fortsätt = true;
            List<string> historik = new List<string>();

            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Välkommen till miniräknaren!");
            while (fortsätt)
            { 
                Console.BackgroundColor = ConsoleColor.DarkGreen;

                Console.Write("Skriv in ett tal: ");
                float förstaTal = float.Parse(Console.ReadLine());
                Console.WriteLine("Välj nån av följande: + - / * ");
                string metod = Console.ReadLine();

                Console.WriteLine("Skriv in ditt andra tal: ");
                float andraTal = float.Parse(Console.ReadLine());

                float summa = 0;
                string uträkning = "";

                if (metod == "+")
                {
                    summa = förstaTal + andraTal;
                    Console.WriteLine("Uträkningen på dina tal = " + summa);
                    uträkning = $"{förstaTal} + {andraTal} = {summa}";
                    historik.Add(uträkning);
                }
                else if (metod == "-")
                {
                    summa = förstaTal - andraTal;
                    Console.WriteLine("Uträkningen på dina tal = " + summa);
                    uträkning = $"{förstaTal} - {andraTal} = {summa}";
                    historik.Add(uträkning);
                }
                else if (metod == "/" && andraTal == 0)
                {
                    Console.WriteLine("Ogiltig inmatning");
                }
                else if (metod == "/")
                {
                    summa = förstaTal / andraTal;
                    Console.WriteLine("Uträkningen på dina tal = " + summa);
                    uträkning = $"{förstaTal} / {andraTal} = {summa}";
                    historik.Add(uträkning);
                }
                else if (metod == "*")
                {
                    summa = förstaTal * andraTal;
                    Console.WriteLine("Uträkningen på dina tal = " + summa);
                    uträkning = $"{förstaTal} * {andraTal} = {summa}";
                    historik.Add(uträkning);
                }
                else
                {
                    Console.WriteLine("Felaktig input"); 
                }

                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Vill du visa dina tidigare resultat? ja/nej");
                string visa = Console.ReadLine();
                if (visa == "ja")
                {
                    Console.WriteLine("Din historik:");
                    foreach (string item in historik)
                    {
                        Console.WriteLine(item);
                    }
                }

                Console.WriteLine("Vill du avluta programmet? ja/nej");
                string avsluta = Console.ReadLine();

                if (avsluta == "ja") 
                {
                    fortsätt = false;
                }
            } 
        }
    }
}
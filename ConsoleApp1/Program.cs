using System.Timers;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
            \n = ny rad   
            \t = tab
            console.clear = rensar
            ändra textfärg 
            ändra bakgrundsfärg 
            $ Console.WriteLine($"{Math.PI:0.000}") gör till string
            ctrl k,c = kommentera markerad text
            */


            //Console.WriteLine("Type          Bytes     Min                               Max ");
            //Console.WriteLine("---------------------------------------------------------------------------------------");

            //// $ för att smidigare kunna lägga till variabler osv med vanlig text utan att behöva använda massa: + " " + 
            //Console.WriteLine($"sbyte         {sizeof(sbyte)}        {sbyte.MinValue}                               {sbyte.MaxValue}");
            //Console.WriteLine($"byte          {sizeof(byte)}         {byte.MinValue}                                 {byte.MaxValue}");
            //Console.WriteLine($"short         {sizeof(short)}        {short.MinValue}                             {short.MaxValue}");
            //Console.WriteLine($"ushort        {sizeof(ushort)}         {ushort.MinValue}                                 {ushort.MaxValue}");
            //Console.WriteLine($"int           {sizeof(int)}        {int.MinValue}                        {int.MaxValue}");
            //Console.WriteLine($"uint          {sizeof(uint)}         {uint.MinValue}                                 {uint.MaxValue}");
            //Console.WriteLine($"long          {sizeof(long)}        {long.MinValue}               {long.MaxValue}");
            //Console.WriteLine($"ulong         {sizeof(ulong)}         {ulong.MinValue}                                 {ulong.MaxValue}");
            //Console.WriteLine($"float         {sizeof(float)}        {float.MinValue}                     {float.MaxValue}");
            //Console.WriteLine($"double        {sizeof(double)}        {double.MinValue}           {double.MaxValue}");
            //Console.WriteLine($"decimal       {sizeof(decimal)}       {decimal.MinValue}     {decimal.MaxValue}");



            // Välkomnande meddelande
            // En lista för att spara historik för räkningar
            // Användaren matar in tal och matematiska operation
            // OBS! Användaren måsta mata in ett tal för att kunna ta sig vidare i programmet!
            // Ifall användaren skulle dela med 0 visa Ogiltig inmatning!
            // Lägga resultat till listan
            // Visa resultat
            // Fråga användaren om den vill visa tidigare resultat.
            // Visa tidigare resultat
            // Fråga användaren om den vill avsluta eller fortsätta.



            // skapar en boolean som styr om miniräknaren ska avslutas eller ej
            bool fortsätt = true;
            // skapar en lista som kan innehålla strängar
            List<string> historik = new List<string>();

            // while loop så att allt inom denna fortsätter hända sålänge 'fortsätt' = true
            while (fortsätt)
            { 

                Console.WriteLine("Välkommen till miniräknaren!");
                Console.Write("Skriv in ett tal: ");
                // skapar min variabel 'förstaTal' samt tilldelar den det värdet som användaren väljer via input
                float förstaTal = float.Parse(Console.ReadLine());
                Console.WriteLine("Välj nån av följande: + - / * ");
                string metod = Console.ReadLine();

                Console.WriteLine("Skriv in ditt andra tal: ");
                float andraTal = float.Parse(Console.ReadLine());

                // deklarerar variabler
                float summa = 0;
                string uträkning = "";

                // om 'metod' är samma som '+' så sker följande
                if (metod == "+")
                {
                    summa = förstaTal + andraTal;
                    Console.WriteLine("Uträkningen på dina tal = " + summa);
                    // variabeln 'uträkning' får ett nytt värde och läggs till i listan för strängar
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
                // om användaren väljer att dela sitt första tal med 0 som skrivs detta felmeddelande ut
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
                    Console.WriteLine("Felaktig input"); // meddelande om använder skriver in nåt annat än de giltiga metoderna: + - / *
                }

                Console.WriteLine("Vill du visa dina tidigare resultat? ja/nej");
                string visa = Console.ReadLine();
                // om användaren skriver ja händer följande annars fortsätter programmet
                if (visa == "ja")
                {
                    Console.WriteLine("Din historik:");
                    // foreach loop för att gå igenom varje element i listan 'historik' och skriver ut dess innehåll
                    foreach (string item in historik)
                    {
                        Console.WriteLine(item);
                    }
                }

                Console.WriteLine("Vill du avluta programmet? ja/nej");
                string avsluta = Console.ReadLine();

                if (avsluta == "ja") 
                {
                    // ställer om bool 'fortsätt' till false vilket avslutar while loopen och programmet
                    fortsätt = false;
                }

            } 
        }
    }
}
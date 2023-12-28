
//Skapa en miniräknare som tar tal och matematiska operator från användare via konsol eller ett grafiskt interface.
//Varje resultat ska sparas i en lista. Kopiera pseudo koden som innehåller instruktioner, klistra in i ditt projekt
//och följa den under kodande. Analysera och utvärdera gränssnitt, designmönster och lösningar i din kod och föreslå
//vidare utökningar.

//Pseudo kod
// Välkomnande meddelande<<<<<<<<<<<
// En lista för att spara historik för räkningar<<<<<<
// Användaren matar in tal och matematiska operation<<<<<<
// OBS! Användaren måsta mata in ett tal för att kunna ta sig vidare i programmet!<<<<<<<<<
// Ifall användaren skulle dela med 0 visa Ogiltig inmatning!<<<<<<<<<
// Lägga resultat till listan<<<<<<<
// Visa resultat<<<<<<<<
// Fråga användaren om den vill visa tidigare resultat.<<<
// Visa tidigare resultat<<<<<<<
// Fråga användaren om den vill avsluta eller fortsätta.<<<<<<<<

//GIT
//Skapa en GIT repository, och använda sig av GIT för versionshantering i denna projekt.  

//Checklista
//Input/output
//Lista med historik
//Kontrollstrukturer
//Välja lämpligt designmönster
//Källkodshantering med GIT

//Betygsättning
//Den här inlämningen kontrollerar följande läranderesultat

//Kunskaper om/i:

//1.Programmering
//2.Loopar, if-satser, villkor
//3.       Listor och arrayer 
//4.       Funktioner 
//5.       Lagringsstruktur, kontrollstruktur och algoritmer 
//6.       Designmönster 
//7.       Tekniska instruktioner och manualläsning även på engelska

//Färdigheter i att:

//8.Konstruera enkla program innehållande kontrollstruktur 
//9.     Hantera dataflöde som sker genom gränssnitt 
//10.   Använda versionshantering 
//11.   Använda samlingsklasser

//Kompetenser för att:

//12.Värdera samlingsklasser och ta ställning till när något blir omodernt samt föreslå lösning


//Godkänt (G)
//Den studerande har visat läranderesultat kopplat till inlämningsuppgift

//Väl godkänt (VG) 
//Den studerande har visat läranderesultat kopplat till inlämningsuppgift. Den studerande kan dessutom: 
//• självständigt och med hög kvalité analysera och utvärdera gränssnitt, designmönster och lösningar.


//Analys och utvärdering av lösning lämnas in som en rapport (i fil format) tillsammans med länken
//till Git repo där lösning är uppladdad.


using System.ComponentModel.Design;

namespace Miniräknaren
{
    internal class Program
    {

        class Miniräknaren//Klass som innehåller programmets metoder.
        {
            //public double NummerEtt {  get; set; }
            //public double NummerTvå { get; set; }
            //public double NummerTre {  get; set; }
            //public double Resultatet { get; set; }
            //public Kalkulationer(double nummerEtt, double nummerTvå, double nummerTre, double resultatet)
            //{
            //    NummerEtt = nummerEtt;
            //    NummerTvå = nummerTvå;
            //    NummerTre = nummerTre;
            //    Resultatet = resultatet;
            //} 

            public double IsNumber()
            {

                return 0;
            }

            public static void Fortsätta()//metod för att fråga om användaren vill fortsätta eller avsluta programmet.
            {

                bool fortsätta = true;
                while (fortsätta)
                {
                    Console.WriteLine("----------------------------------------------------------------------------");
                    Console.WriteLine("Vill du fortsätta (j/J) eller avsluta programmet (vilken tangent som helst)?");
                    Console.WriteLine("----------------------------------------------------------------------------");
                    string jJnN = Console.ReadLine().ToLower();
                    if (jJnN == "j")
                    {
                        fortsätta=false;
                    }else
                    {
                        Console.WriteLine("Programmet avslutas.");
                        Environment.Exit(0);//Avslutar programmet helt.
                    }

                }

            }
            public static void Area()//Metod som visar/beräknar olika areor beroende på användarens val.
            {
                bool areaBool = true;
                List<double> areaResultat = new List<double>();//Lista att spara alla resultat i.
                while (areaBool)
                {
                    Console.WriteLine("-------------------------------------------------------");//Skriver ut olika area alternativ så att användaren ser vad valmöjligheterna är:
                    Console.WriteLine("Välkommen till beräkning av area! Var god gör ditt val:");
                    Console.WriteLine("-------------------------------------------------------");
                    Console.WriteLine("[1] - Rektangel.");
                    Console.WriteLine("[2] - Kvadrat.");
                    Console.WriteLine("[3] - Cirkel.");
                    Console.WriteLine("[4] - Triangel.");
                    Console.WriteLine("[5] - Trapets/Paralelltrapets.");
                    Console.WriteLine("[6] - Ellips.");
                    Console.WriteLine("[7] - Romb.");
                    Console.WriteLine("[8] - Alla resultat för beräkningar av area.");
                    Console.WriteLine("[9] - Tillbaka till miniräknaren.");
                    Console.WriteLine("------------------------------------------------------");


                    Int32.TryParse(Console.ReadLine(), out int input);
                    double ett, tva, tre, area;
                    double pi = Math.PI;
                    double half = 0.5;
                    switch (input)
                    {
                        case 1:
                            Console.WriteLine("Ange rektangelns höjd:");
                            if(double.TryParse(Console.ReadLine(), out ett))
                            {
                                Console.WriteLine("Ange rektangelns bredd:");
                                if(double.TryParse(Console.ReadLine(), out tva))
                                {
                                    area = ett * tva;
                                    areaResultat.Add(area);
                                    Console.WriteLine("-------------------------------------------------");
                                    Console.WriteLine($"Rektangelns area är: {area}.");
                                    Console.WriteLine("-------------------------------------------------");
                                    Fortsätta();
                                }
                                else
                                {
                                    Console.WriteLine("-------------------------------------------------");
                                    Console.WriteLine("Felaktig inmatning för bredd. Ange ett giltigt tal.");
                                    Console.WriteLine("-------------------------------------------------");
                                }
                            }
                            else
                            {
                                Console.WriteLine("-------------------------------------------------");
                                Console.WriteLine("Felaktigt inmatning för höjd. Ange ett giltigt tal.");
                                Console.WriteLine("-------------------------------------------------");
                            }
                            break;
                        case 2:
                            Console.WriteLine("Skriv hur långa sidorna av kvadraten är:");
                            if(double.TryParse(Console.ReadLine(), out ett))
                            {
                                area = ett * ett;
                                areaResultat.Add(area);
                                Console.WriteLine("-------------------------------------------------");
                                Console.WriteLine($"Arean av kvadraten är: {area}.");
                                Console.WriteLine("-------------------------------------------------");
                                Fortsätta();
                            }
                            else
                            {
                                Console.WriteLine("-------------------------------------------------");
                                Console.WriteLine("Felaktigt val, ange en siffra.");
                                Console.WriteLine("-------------------------------------------------");
                            }
                            break;
                        case 3:
                            Console.WriteLine("Skriv in radien av cirkeln:");
                            if (double.TryParse(Console.ReadLine(), out ett))
                            {
                                area = pi * (ett * ett);
                                areaResultat.Add(area);
                                Console.WriteLine("-------------------------------------------------");
                                Console.WriteLine($"Cirkelns area är: {area}.");
                                Console.WriteLine("-------------------------------------------------");
                                Fortsätta();
                            }
                            else
                            {
                                Console.WriteLine("-------------------------------------------------");
                                Console.WriteLine("Felaktigt val, ange en siffra.");
                                Console.WriteLine("-------------------------------------------------");
                            }
                            break;
                        case 4:
                            Console.WriteLine("Skriv in höjden av triangeln:");
                            if (double.TryParse(Console.ReadLine(), out ett))
                            {
                                Console.WriteLine("Skriv in bredden av triangeln:");
                                if (double.TryParse(Console.ReadLine(), out tva))
                                {
                                    area = half * ett * tva;
                                    areaResultat.Add(area);
                                    Console.WriteLine("-------------------------------------------------");
                                    Console.WriteLine($"Triangelns area är: {area}.");
                                    Console.WriteLine("-------------------------------------------------");
                                    Fortsätta();
                                }
                                else
                                {
                                    Console.WriteLine("-------------------------------------------------");
                                    Console.WriteLine("Felaktigt val, ange en siffra.");
                                    Console.WriteLine("-------------------------------------------------");
                                }
                            }
                            else
                            {
                                Console.WriteLine("-------------------------------------------------");
                                Console.WriteLine("Felaktigt val, ange en siffra.");
                                Console.WriteLine("-------------------------------------------------");
                            }
                            break;
                        case 5:
                            Console.WriteLine("Ange första basen för trapetsen:");
                            if (double.TryParse(Console.ReadLine(), out ett))
                            {
                                Console.WriteLine("Ange andra basen för trapetsen:");
                                if (double.TryParse(Console.ReadLine(), out tva))
                                {
                                    Console.WriteLine("Ange trapetsens höjd:");
                                    if (double.TryParse(Console.ReadLine(), out tre))
                                    {
                                        area = half * (ett + tva) * tre;
                                        areaResultat.Add(area);
                                        Console.WriteLine("-------------------------------------------------");
                                        Console.WriteLine($"Trapetsens/Paralelltrapetsens area är: {area}.");
                                        Console.WriteLine("-------------------------------------------------");
                                        Fortsätta();
                                    }
                                    else
                                    {
                                        Console.WriteLine("-------------------------------------------------");
                                        Console.WriteLine("Felaktigt val, ange en siffra.");
                                        Console.WriteLine("-------------------------------------------------");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("-------------------------------------------------");
                                    Console.WriteLine("Felaktigt val, ange en siffra.");
                                    Console.WriteLine("-------------------------------------------------");
                                }
                            }
                            else
                            {
                                Console.WriteLine("-------------------------------------------------");
                                Console.WriteLine("Felaktigt val, ange en siffra.");
                                Console.WriteLine("-------------------------------------------------");
                            }
                            break;
                        case 6:
                            Console.WriteLine("Ange värde för halva storaxeln:");
                            if (double.TryParse(Console.ReadLine(), out ett))
                            {
                                Console.WriteLine("Ange värde för halva lillaxeln:");
                                if (double.TryParse(Console.ReadLine(), out tva)) 
                                {
                                    area = pi * ett * tva;
                                    areaResultat.Add(area);
                                    Console.WriteLine("-------------------------------------------------");
                                    Console.WriteLine($"Ellipsens area är: {area}.");
                                    Console.WriteLine("-------------------------------------------------");
                                    Fortsätta();
                                }
                                else
                                {
                                    Console.WriteLine("-------------------------------------------------");
                                    Console.WriteLine("Felaktigt val, ange en siffra.");
                                    Console.WriteLine("-------------------------------------------------");
                                }
                            }
                            else
                            {
                                Console.WriteLine("-------------------------------------------------");
                                Console.WriteLine("Felaktigt val, ange en siffra.");
                                Console.WriteLine("-------------------------------------------------");
                            }
                            break;
                        case 7:
                            Console.WriteLine("Ange värde av första diagonalen:");
                            if (double.TryParse(Console.ReadLine(), out ett))
                            {
                                Console.WriteLine("Ange värde av andra diagonalen:");
                                if (double.TryParse(Console.ReadLine(), out tva))
                                {
                                    area = half * ett * tva;
                                    areaResultat.Add(area);
                                    Console.WriteLine("-------------------------------------------------");
                                    Console.WriteLine($"Rombens area är: {area}.");
                                    Console.WriteLine("-------------------------------------------------");
                                    Fortsätta();
                                }
                                else
                                {
                                    Console.WriteLine("-------------------------------------------------");
                                    Console.WriteLine("Felaktigt val, ange en siffra.");
                                    Console.WriteLine("-------------------------------------------------");
                                }
                            }
                            else
                            {
                                Console.WriteLine("-------------------------------------------------");
                                Console.WriteLine("Felaktigt val, ange en siffra.");
                                Console.WriteLine("-------------------------------------------------");
                            }
                            break;
                        case 8:
                            Console.WriteLine("Alla resultat:");
                            foreach (double resultat in areaResultat)
                            {
                                Console.WriteLine(resultat);
                            }
                            Fortsätta();
                            break;
                        case 9:
                            Console.WriteLine("-------------------------------------------------");
                            Console.WriteLine(">>>>>>>>>>>Beräkning av area avslutas.<<<<<<<<<<<");
                            Console.WriteLine("-------------------------------------------------");
                            areaBool = false;//Nu är boolen false och programmet/loopen avslutas.
                            break;
                        default:
                            Console.WriteLine("-------------------------------------------------");
                            Console.WriteLine(">>>>>>>>>>>>>>>>>>Ogiltigt val<<<<<<<<<<<<<<<<<<<");//Om användaren gör ett val som inte ingår i menyn så kommer ett felmeddelande.
                            Console.WriteLine("-------------------------------------------------");
                            break;

                    }

                }


            }

            static void Main(string[] args)
            {

                bool fortsätt = true;
                List<double> allaResultat = new List<double>();//Lista att spara alla resultat i.

                while (fortsätt)
                {
                    Console.BackgroundColor = ConsoleColor.Magenta;//Ändrar färger för text och bakgrund för att snygga till programmet lite :)
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("-------------------------------------------------");//Skriver ut själva programmet så att användaren ser vad valmöjligheterna är:
                    Console.WriteLine("Välkommen till miniräknaren. Var god gör ett val:");
                    Console.WriteLine("-------------------------------------------------");
                    Console.WriteLine("[1] - Addera.");
                    Console.WriteLine("[2] - Subtrahera.");
                    Console.WriteLine("[3] - Multiplicera.");
                    Console.WriteLine("[4] - Area.");
                    Console.WriteLine("[5] - Dividera.");
                    Console.WriteLine("[6] - Mixa (+-*/).");
                    Console.WriteLine("[7] - Roten.");
                    Console.WriteLine("[8] - Potens.");
                    Console.WriteLine("[9] - Triomitri.");
                    Console.WriteLine("[10] - Sinus.");
                    Console.WriteLine("[11] - Cosinus.");
                    Console.WriteLine("[12] - Tangens.");
                    Console.WriteLine("[13] - Lista med alla resultat.");
                    Console.WriteLine("[14] - Avsluta.");
                    Console.WriteLine("-------------------------------------------------");

                    Int32.TryParse(Console.ReadLine(), out int input);//Läser av användarens val och sparar den i variabeln input.
                    double siffraEtt, siffraTva, siffraResultat;//Lägger till variablar för beräkningarna i programmet.
                    double resultatet = 0;
                    switch (input)
                    {
                        case 1://När användaren gör val 1 så körs följande kod:
                            while (true)
                            {
                                Console.WriteLine("Skriv en siffra för att addera, skriv x för att avsluta:");
                                string inputen = Console.ReadLine();
                                if (inputen.ToLower() == "x")
                                {
                                    break;
                                }
                                if (double.TryParse(inputen, out double siffra))
                                {
                                    resultatet += siffra;
                                    allaResultat.Add(resultatet);
                                    Console.Clear();
                                    Console.WriteLine($"{resultatet - siffra} + {siffra} = {resultatet}");
                                    Console.WriteLine("Historik:");
                                    for (int i = 0; i < allaResultat.Count; i++)
                                    {
                                        Console.WriteLine($"{i + 1}. {allaResultat[i]}");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("-------------------------------------------------");
                                    Console.WriteLine("Felaktig inmatning...");
                                    Console.WriteLine("-------------------------------------------------");
                                }
                            }
                            Fortsätta();
                            break;//Avbryter adderingen och går tillbaka till början av loopen.
                        case 2:
                            while (true)
                            {
                                Console.WriteLine("Skriv en siffra för att subtrahera, skriv x för att avsluta:");
                                string inputen = Console.ReadLine();
                                if (inputen.ToLower() == "x")
                                {
                                    break;
                                }
                                if (double.TryParse(inputen, out double siffra))
                                {
                                    resultatet -= siffra;
                                    allaResultat.Add(resultatet);
                                    Console.WriteLine("-------------------------------------------------");
                                    Console.WriteLine($"Nuvarande resultatet är: {resultatet}");
                                    Console.WriteLine("-------------------------------------------------");
                                }
                                else
                                {
                                    Console.WriteLine("-------------------------------------------------");
                                    Console.WriteLine("Felaktig inmatning...");
                                    Console.WriteLine("-------------------------------------------------");
                                }
                            }
                            Fortsätta();
                            break;
                        case 3:
                            while (true)
                            {
                                Console.WriteLine("Skriv en siffra för att multiplicera, skriv x för att avsluta:");
                                string inputen = Console.ReadLine();
                                if (inputen.ToLower() == "x")
                                {
                                    break;
                                }
                                if (double.TryParse(inputen, out double siffra))
                                {
                                    if (allaResultat.Count == 0)
                                    {
                                        resultatet = siffra;
                                    }
                                    else
                                    {
                                        resultatet *= siffra;
                                    }
                                    allaResultat.Add(resultatet);
                                    Console.Clear();
                                    Console.WriteLine($"Nuvarande resultatet är: {resultatet}");
                                }
                                else
                                {
                                    Console.WriteLine("-------------------------------------------------");
                                    Console.WriteLine("Felaktig inmatning...");
                                    Console.WriteLine("-------------------------------------------------");
                                }
                            }
                            Fortsätta();
                            break;
                        case 4:
                            Area();
                            break;
                        case 5:
                            Console.WriteLine("Skriv en siffra:");
                            siffraEtt = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine($"Skriv siffran du vill dividera med {siffraEtt}:");
                            double ejNoll;
                            do
                            {
                                ejNoll = Convert.ToDouble(Console.ReadLine());
                                if (ejNoll == 0)//Om användaren försöker dividera med 0 kommer ett felmeddelande.
                                {
                                    Console.WriteLine("-------------------------------------------------");
                                    Console.WriteLine(">>>>>>Kan ej dividera med 0! Försök igen!<<<<<<<<");
                                    Console.WriteLine("-------------------------------------------------");
                                }
                            }while (ejNoll == 0);
                            siffraResultat = siffraEtt / ejNoll;
                            allaResultat.Add(siffraResultat);
                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------");
                            Console.WriteLine($"{siffraEtt} / {ejNoll} = {siffraResultat}.");
                            Console.WriteLine("-------------------------------------------------");
                            Fortsätta();
                            break;
                        case 6:
                            break;
                        case 7:
                            Console.WriteLine("Ange vilken siffra du vill beräkna roten ur:");
                            double roten;
                            do//En do while loop för att ge användaren möjlighet att fortsätta även om hen matar in negativt tal
                            {
                                roten = Convert.ToDouble(Console.ReadLine());
                                if (roten <= 0)//Kontrollerar att talet inte är negativt, då får användaren göra om valet
                                {
                                    Console.WriteLine("-------------------------------------------------");
                                    Console.WriteLine(">>>Talet får inte vara negativt! Försök igen:<<<<");
                                    Console.WriteLine("-------------------------------------------------");
                                }
                                else
                                {
                                    Console.WriteLine("-------------------------------------------------");
                                    Console.WriteLine("Felaktig inmatning...");
                                    Console.WriteLine("-------------------------------------------------");
                                }
                            } while (roten <= 0);
                            siffraResultat = Math.Sqrt(roten);
                            allaResultat.Add(siffraResultat);
                            Console.WriteLine($"Roten ur {roten} är {siffraResultat}.");
                            Fortsätta();
                            break;
                        case 8:
                            Console.WriteLine("Ange basen:");
                            siffraEtt = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Ange exponenten:");
                            siffraTva = Convert.ToDouble(Console.ReadLine());
                            siffraResultat = Math.Pow(siffraEtt, siffraTva);
                            allaResultat.Add(siffraResultat);
                            Console.WriteLine($"{siffraEtt} upphöjt till {siffraTva} är likamed {siffraResultat}.");
                            Fortsätta();
                            break;
                        case 9:
                            Fortsätta();
                            break;
                        case 10:
                            Fortsätta();
                            break;
                        case 11:
                            Fortsätta();
                            break;
                        case 12:
                            Fortsätta();
                            break;
                        case 13:
                            Console.WriteLine("Alla resultat:");
                            foreach (double resultat in allaResultat)
                            {
                                Console.WriteLine(resultat);
                            }
                            Fortsätta();
                            break;
                        case 14:
                            Console.WriteLine("Programmet avslutas.. Tack för den här gången!");
                            fortsätt = false;//Nu är boolen false och programmet/loopen avslutas.
                            break;
                        default:
                            Console.WriteLine("-------------------------------------------------");
                            Console.WriteLine(">>>>>>>>>>>>>>>>>>Ogiltigt val<<<<<<<<<<<<<<<<<<<");//Om användaren gör ett val som inte ingår i menyn så kommer ett felmeddelande.
                            Console.WriteLine("-------------------------------------------------");
                            break;
                        }
                    }
                Console.ReadLine();
            }
                
        }
    }
        
}



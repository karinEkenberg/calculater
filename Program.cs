
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


using System.ComponentModel.Design;

namespace Miniräknaren
{
    internal class Program
    {

        class Miniräknaren//Klass som innehåller programmets metoder.
        {
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

            public static void PrintResults(string outputen)
            {
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine($"{outputen}");
                Console.WriteLine("-------------------------------------------------");
                Fortsätta();
            }

            public static void PrintText(string output)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine($"{output}");
                Console.WriteLine("-------------------------------------------------");
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(2000);
            }

            public static void Area()//Metod som visar/beräknar olika areor beroende på användarens val.
            {
                bool areaBool = true;
                List<double> areaResultat = new List<double>();//Lista att spara alla resultat i.
                while (areaBool)
                {
                    Console.Clear();    
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
                            Console.Clear();
                            while (true)
                            {
                                Console.WriteLine("Ange rektangelns höjd:");
                                if (double.TryParse(Console.ReadLine(), out ett))
                                {
                                    Console.WriteLine("Ange rektangelns bredd:");
                                    if (double.TryParse(Console.ReadLine(), out tva))
                                    {
                                        area = ett * tva;
                                        areaResultat.Add(area);
                                        PrintResults($"Rektangelns area är: {area}.");
                                    }
                                    else
                                    {
                                        PrintText("Felaktig inmatning...");
                                        continue;
                                    }
                                }
                                else
                                {
                                    PrintText("Felaktig inmatning...");
                                    continue;
                                }
                                break;
                            }
                            break;
                        case 2:
                            Console.Clear();
                            while (true)
                            {
                                Console.WriteLine("Skriv hur långa sidorna av kvadraten är:");
                                if (double.TryParse(Console.ReadLine(), out ett))
                                {
                                    area = ett * ett;
                                    areaResultat.Add(area);
                                    PrintResults($"Arean av kvadraten är: {area}.");
                                }
                                else
                                {
                                    PrintText("Felaktig inmatning...");
                                    continue;
                                }
                                break;
                            }
                            break;
                        case 3:
                            Console.Clear();
                            while (true)
                            {
                                Console.WriteLine("Skriv in radien av cirkeln:");
                                if (double.TryParse(Console.ReadLine(), out ett))
                                {
                                    area = pi * (ett * ett);
                                    areaResultat.Add(area);
                                    PrintResults($"Cirkelns area är: {area}.");
                                }
                                else
                                {
                                    PrintText("Felaktig inmatning...");
                                    continue;
                                }
                                break;
                            }
                            break;
                        case 4:
                            Console.Clear();
                            while (true)
                            {
                                Console.WriteLine("Skriv in höjden av triangeln:");
                                if (double.TryParse(Console.ReadLine(), out ett))
                                {
                                    Console.WriteLine("Skriv in bredden av triangeln:");
                                    if (double.TryParse(Console.ReadLine(), out tva))
                                    {
                                        area = half * ett * tva;
                                        areaResultat.Add(area);
                                        PrintResults($"Triangelns area är: {area}.");
                                    }
                                    else
                                    {
                                        PrintText("Felaktig inmatning...");
                                        continue;
                                    }
                                }
                                else
                                {
                                    PrintText("Felaktig inmatning...");
                                    continue;
                                }
                                break;
                            }
                            break;
                        case 5:
                            Console.Clear();
                            while (true)
                            {

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
                                            PrintResults($"Trapetsens/Paralelltrapetsens area är: {area}.");
                                        }
                                        else
                                        {
                                            PrintText("Felaktig inmatning...");
                                            continue;
                                        }
                                    }
                                    else
                                    {
                                        PrintText("Felaktig inmatning...");
                                        continue;
                                    }
                                }
                                else
                                {
                                    PrintText("Felaktig inmatning...");
                                    continue;
                                }
                                break;
                            }
                            break;
                        case 6:
                            Console.Clear();
                            while (true)
                            {
                                Console.WriteLine("Ange värde för halva storaxeln:");
                                if (double.TryParse(Console.ReadLine(), out ett))
                                {
                                    Console.WriteLine("Ange värde för halva lillaxeln:");
                                    if (double.TryParse(Console.ReadLine(), out tva))
                                    {
                                        area = pi * ett * tva;
                                        areaResultat.Add(area);
                                        PrintResults($"Ellipsens area är: {area}.");
                                    }
                                    else
                                    {
                                        PrintText("Felaktig inmatning...");
                                        continue;
                                    }
                                }
                                else
                                {
                                    PrintText("Felaktig inmatning...");
                                    continue;
                                }
                                break;
                            }
                            break;
                        case 7:
                            Console.Clear();
                            while (true)
                            {
                                Console.WriteLine("Ange värde av första diagonalen:");
                                if (double.TryParse(Console.ReadLine(), out ett))
                                {
                                    Console.WriteLine("Ange värde av andra diagonalen:");
                                    if (double.TryParse(Console.ReadLine(), out tva))
                                    {
                                        area = half * ett * tva;
                                        areaResultat.Add(area);
                                        PrintResults($"Rombens area är: {area}.");
                                    }
                                    else
                                    {
                                        PrintText("Felaktig inmatning...");
                                        continue;
                                    }
                                }
                                else
                                {
                                    PrintText("Felaktig inmatning...");
                                    continue;
                                }
                                break;
                            }
                            break;
                        case 8:
                            Console.Clear();
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
                            PrintText("Felaktig inmatning...");
                            break;

                    }

                }


            }

            static void Main(string[] args)
            {

                bool fortsätt = true;
                List<string> allaResultat = new List<string>();//Lista att spara alla resultat i.
                List<double> resterandeResultat = new List<double>();

                while (fortsätt)
                {
                    Console.BackgroundColor = ConsoleColor.Magenta;//Ändrar färger för text och bakgrund för att snygga till programmet lite :)
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();
                    Console.WriteLine("-------------------------------------------------");//Skriver ut själva programmet så att användaren ser vad valmöjligheterna är:
                    Console.WriteLine("Välkommen till miniräknaren. Var god gör ett val:");
                    Console.WriteLine("-------------------------------------------------");
                    Console.WriteLine("[1] - Addera.");
                    Console.WriteLine("[2] - Subtrahera.");
                    Console.WriteLine("[3] - Multiplicera.");
                    Console.WriteLine("[4] - Area.");
                    Console.WriteLine("[5] - Dividera.");
                    Console.WriteLine("[6] - Roten.");
                    Console.WriteLine("[7] - Potens.");
                    Console.WriteLine("[8] - Trigonometri (Sinus, Cosinus, Tangens).");
                    Console.WriteLine("[9] - Lista med alla resultat.");
                    Console.WriteLine("[10] - Avsluta.");
                    Console.WriteLine("-------------------------------------------------");

                    Int32.TryParse(Console.ReadLine(), out int input);//Läser av användarens val och sparar den i variabeln input.
                    double siffraEtt, siffraTva, siffraResultat, vinkelGrader;//Lägger till variablar för beräkningarna i programmet.
                    double resultatet = 0;
                    string calculation = "";
                    switch (input)
                    {
                        case 1://När användaren gör val 1 så körs följande kod:
                            Console.Clear();
                            while (true)
                            {
                                Console.WriteLine("Skriv en siffra för att addera, skriv x för att avsluta:");
                                string inputen = Console.ReadLine();
                                if (inputen.ToLower() == "x")
                                {
                                    calculation += $" = {resultatet}";
                                    allaResultat.Add(calculation);
                                    break;
                                }
                                if (double.TryParse(inputen, out double siffra))
                                {
                                    resultatet += siffra;
                                    if (calculation == "")
                                    {
                                        calculation = $"{siffra}";
                                    }
                                    else
                                    {
                                        calculation += $" + {siffra}";
                                    }
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
                                    PrintText("Felaktig inmatning...");
                                    continue;
                                }
                            }
                            Fortsätta();
                            break;//Avbryter adderingen och går tillbaka till början av loopen.
                        case 2:
                            Console.Clear();
                            while (true)
                            {
                                Console.WriteLine("Skriv en siffra för att subtrahera den, skriv x för att avsluta:");
                                string inputen = Console.ReadLine();
                                if (inputen.ToLower() == "x")
                                {
                                    calculation += $" = {resultatet}";
                                    allaResultat.Add(calculation);
                                    break;
                                }
                                if (double.TryParse(inputen, out double siffra))
                                {

                                    if (calculation == "")
                                    {
                                        resultatet = siffra;
                                        calculation = $"{siffra}";
                                        Console.Clear();
                                        Console.WriteLine($"{siffra} = {resultatet}");
                                        Console.WriteLine("Historik:");
                                    }
                                    else
                                    {
                                        resultatet -= siffra;
                                        calculation += $" - {siffra}";
                                        Console.Clear();
                                        Console.WriteLine($"{resultatet + siffra} - {siffra} = {resultatet}");
                                        Console.WriteLine("Historik:");
                                    }
                                    for (int i = 0; i < allaResultat.Count; i++)
                                    {
                                        Console.WriteLine($"{i + 1}. {allaResultat[i]}");
                                    }
                                }
                                else
                                {

                                    PrintText("Felaktig inmatning...");
                                    continue;
                                }
                            }
                            Fortsätta();
                            break;
                        case 3:
                            Console.Clear();
                            double resultatMulti = 1;
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
                                  resultatMulti *= siffra;
                                  Console.Clear();
                                  resterandeResultat.Add(resultatMulti);
                                  Console.WriteLine($"Nuvarande resultatet är: {resultatMulti}");
                                }
                                else
                                {
                                    PrintText("Felaktig inmatning...");
                                    continue;
                                }
                            }
                            Fortsätta();
                            break;
                        case 4:
                            Console.Clear();
                            Area();
                            break;
                        case 5:
                            Console.Clear();
                            while (true)
                            {
                                Console.WriteLine("Skriv en siffra:");
                                double siffran;
                                if (double.TryParse(Console.ReadLine(), out siffran))
                                {
                                    Console.WriteLine($"Skriv siffran du vill dividera med {siffran}:");
                                    double ejNoll;
                                    do
                                    {
                                        ejNoll = Convert.ToDouble(Console.ReadLine());
                                        if (ejNoll == 0)//Om användaren försöker dividera med 0 kommer ett felmeddelande.
                                        {
                                            PrintText("Kan ej dividera med 0...");
                                            break;
                                        }
                                    } while (ejNoll == 0);
                                    siffraResultat = siffran / ejNoll;
                                    resterandeResultat.Add(siffraResultat);
                                    Console.Clear();
                                    PrintResults($"{siffran} / {ejNoll} = {siffraResultat}.");
                                    break;
                                }
                                else
                                {
                                    PrintText("Felaktig inmatning...");
                                    continue;
                                }
                            }
                            break;
                        case 6:
                            Console.Clear();
                            while (true)
                            {
                                Console.WriteLine("Ange vilken siffra du vill beräkna roten ur:");
                                double roten;
                                if (double.TryParse(Console.ReadLine(), out roten))
                                {
                                    do//En do while loop för att ge användaren möjlighet att fortsätta även om hen matar in negativt tal
                                    {
                                        if (roten <= 0)//Kontrollerar att talet inte är negativt, då får användaren göra om valet
                                        {
                                            PrintText("Talet får inte vara negativt...");
                                            break;
                                        }
                                    } while (roten <= 0);
                                    siffraResultat = Math.Sqrt(roten);
                                    resterandeResultat.Add(siffraResultat);
                                    Console.WriteLine($"Roten ur {roten} är {siffraResultat}.");
                                    Fortsätta();
                                }
                                else
                                {
                                    PrintText("Felaktig inmatning...");
                                    continue;
                                }
                                break;
                            }
                            break;
                        case 7:
                            Console.Clear();
                            while (true)
                            {
                                Console.WriteLine("Ange basen:");
                                if (double.TryParse(Console.ReadLine(), out siffraEtt))
                                {
                                    Console.WriteLine("Ange exponenten:");
                                    if (double.TryParse(Console.ReadLine(), out siffraTva))
                                    {
                                        siffraResultat = Math.Pow(siffraEtt, siffraTva);
                                        resterandeResultat.Add(siffraResultat);
                                        Console.WriteLine($"{siffraEtt} upphöjt till {siffraTva} är likamed {siffraResultat}.");
                                        Fortsätta();
                                    }
                                    else
                                    {
                                        PrintText("Felaktig inmatning...");
                                        continue;
                                    }
                                }
                                else
                                {
                                    PrintText("Felaktig inmatning...");
                                    continue;
                                }
                                break;
                            }
                            break;
                        case 8:
                            Console.Clear();
                            while (true)
                            {
                                Console.WriteLine("Ange en vinkel i grader:");
                                if (double.TryParse(Console.ReadLine(), out vinkelGrader))
                                {
                                    double vinkelRadianer = Math.PI * vinkelGrader / 180.0;//Konverterar vinkeln från grader till radianer
                                    double sinusResultat = Math.Sin(vinkelRadianer);//Sinus
                                    Console.WriteLine($"Sinus ({vinkelGrader} grader) = {sinusResultat}.");
                                    resterandeResultat.Add(sinusResultat);
                                    double cosinusResultat = Math.Cos(vinkelRadianer);//Cosinus
                                    Console.WriteLine($"Cosinus ({vinkelGrader} grader) = {cosinusResultat}.");
                                    resterandeResultat.Add(cosinusResultat);
                                    double tangensResultat = Math.Tan(vinkelRadianer);//Tangens
                                    Console.WriteLine($"Tangens ({vinkelGrader} grader) = {tangensResultat}.");
                                    resterandeResultat.Add(tangensResultat);
                                    Fortsätta();
                                }
                                else
                                {
                                    PrintText("Felaktig inmatning...");
                                    continue;
                                }
                                break;
                            }
                            break;
                        case 9:
                            Console.Clear();
                            if (resterandeResultat.Count == 0 && allaResultat.Count == 0)//Felmeddelande om det inte finns några resultat
                            {
                                Console.WriteLine("Det finns inga resultat att visa.");
                            }
                            else
                            {
                                Console.WriteLine("Alla resultat:");
                                foreach (string dsdasd in allaResultat)
                                {
                                    Console.WriteLine(dsdasd);
                                }
                                foreach (double resultat in resterandeResultat)
                                {
                                    Console.WriteLine(resultat);
                                }
                                Fortsätta();
                            }
                            break;
                        case 10:
                            Console.WriteLine("Programmet avslutas.. Tack för den här gången!");
                            fortsätt = false;//Nu är boolen false och programmet/loopen avslutas.
                            break;
                        default:
                            PrintText("Felaktig inmatning...");
                            break;
                        }
                    }
                Console.ReadLine();
            }
                
        }
    }
        
}



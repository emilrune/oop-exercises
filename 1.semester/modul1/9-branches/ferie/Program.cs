/*  Undervisningskalenderen fortæller os at der (blandt andet) er følgende ferier:
 • Efterårsferie Oktober
 • Juleferie December
 • Påskeferie April
 • Sommerferie Juli + August
 Skriv et program, hvori
 1. Et månedsnummer gives via en variabel.
 2. Afhængigt af indholdet af denne variabel udskrives en feries navn (hvis
 der er ferie i måneden) eller “Hårdt arbejde” (hvis der ikke er). */
 

        // 1. Et månedsnummer gives via en variabel
        Console.WriteLine("Hvilken måned ønsker du at tjekke ferie i?");
        string month = Console.ReadLine(); // Du kan ændre denne værdi til den ønskede måned

        bool canBeConverted = int.TryParse(month, out int monthConverted);

        Console.Write("Du har ønsket at vide noget om " + monthConverted + ". I denne måned står den på ");

        //! To-do: lav et array for at få output i månedsnavn og ikke bare som tal. !

        // 2. Tjek hvilken ferie der er i måneden eller udskriv "Hårdt arbejde"
        switch (monthConverted)
        {
            case 4:
                Console.WriteLine("Påskeferie");
                break;
            case 7:
            case 8:
                Console.WriteLine("Sommerferie");
                break;
            case 10:
                Console.WriteLine("Efterårsferie");
                break;
            case 12:
                Console.WriteLine("Juleferie");
                break;
            default:
                Console.WriteLine("Hårdt arbejde");
                break;
        }
   

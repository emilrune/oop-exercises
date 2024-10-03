



        // 1. Gennemløb alle positive heltal under 300.000 og find primtallene
        List<int> primeNumbers300 = FindPrimesBelow(300000);
        List<int> primeNumbers1000 = FindPrimesBelow(1000000);

        // 2. Udskriv alle fundne primtal
        Console.WriteLine("Primtal under 300.000:");
        foreach (int prime in primeNumbers300)
        {
            Console.WriteLine(prime);
        }



        // 3. Vent på brugerinput
        Console.WriteLine("Tryk på mellemrum for at finde det største primtal, under EN MILLION...");
        Console.ReadKey();

        // 4. Udskriv det største primtal
        Console.WriteLine($"\nTadaa, det er {primeNumbers1000[^1]}"); // ^1 er værktøj i C#, til at hente 'sidste element i en liste'
    

    // Funktion der gennemløber alle tal under 1.000.000 og finder primtal
    static List<int> FindPrimesBelow(int limit)
    {
        List<int> primes = new List<int>();

        for (int i = 2; i < limit; i++)  // Start fra 2 da det er det mindste primtal
        {
            if (IsPrime(i))  // Hvis tallet er et primtal, tilføj det til listen
            {
                primes.Add(i);
            }
        }

        return primes;
    }

    // Funktion der bestemmer om et givent tal er et primtal
    static bool IsPrime(int number)
    {
        if (number <= 1) return false;
        if (number == 2) return true;  // 2 er det eneste lige primtal
        if (number % 2 == 0) return false;  // Hvis tallet er lige og ikke 2, er det ikke et primtal

        // Tjek kun op til kvadratroden af tallet for at optimere primtalskontrollen
        int boundary = (int)Math.Sqrt(number);

        for (int i = 3; i <= boundary; i += 2)  // Hop over alle lige tal
        {
            if (number % i == 0)
            {
                return false;
            }
        }

    return true;
    }

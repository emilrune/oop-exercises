       
        // Definer pi som en konstant. Math.PI kalder pi som værdien 3.1415....
        const double pi = Math.PI;

        // Definer radius for de tre cirkler
        double radius1 = 1.0;
        double radius3 = 3.0;
        double radius5 = 5.0;

        // Udregn omkredsene
        double omkreds1 = 2 * pi * radius1;
        double omkreds3 = 2 * pi * radius3;
        double omkreds5 = 2 * pi * radius5;

        // Udskriv omkredsene for hver cirkel
        Console.WriteLine("Omkredsen af cirkel med radius 1: " + omkreds1);
        Console.WriteLine("Omkredsen af cirkel med radius 3: " + omkreds3);
        Console.WriteLine("Omkredsen af cirkel med radius 5: " + omkreds5);

        // Beregn summen af omkredsene
        double totalOmkreds = omkreds1 + omkreds3 + omkreds5;

        // Udskriv summen af omkredsene
        Console.WriteLine("Summen af omkredsene af de tre cirkler: " + totalOmkreds);

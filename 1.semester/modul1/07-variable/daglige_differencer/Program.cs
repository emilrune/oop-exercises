
        // 1. Erklær og tildel dagstemperaturerne vha. array
        double[] temperatures = 
        {
            21.5, // Mandag
            23.7, // Tirsdag
            19.6, // Onsdag
            22.5, // Torsdag
            25.3, // Fredag
            21.7, // Lørdag
            18.9  // Søndag
        };

        // 2. Udskriv temperaturdifferencen mellem to på hinanden følgende dage. Vi bruger igen et array til variablen "days"
        string[] days = { "Mandag", "Tirsdag", "Onsdag", "Torsdag", "Fredag", "Lørdag", "Søndag" };

        //for at printe alle dage ud, bruger vi et for loop
        for (int i = 1; i < temperatures.Length; i++)
        {
            double difference = temperatures[i] - temperatures[i - 1];
            //Console.WriteLine($"{days[i]} - {days[i - 1]}: {difference:F1} grader");
            Console.WriteLine(days[i] + " til " + days[i - 1] + " " + difference +" grader");
        }

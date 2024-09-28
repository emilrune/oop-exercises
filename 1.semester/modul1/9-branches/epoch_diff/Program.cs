/* 
        // 1. Angiv et antal sekunder siden 1. januar 1970
        long totalSeconds = 1727049605; // Du kan ændre dette til et andet antal sekunder. Vi bruger long typen da vi kan komme ud for at skulle bruge mange sekunder :)

        // Konstant værdier
        const int secondsPerMinute = 60;
        const int minutesPerHour = 60;
        const int hoursPerDay = 24;
        const int daysPerYear = 365;
        
        // Beregn sekunder i en dag og i et år
        long secondsPerDay = secondsPerMinute * minutesPerHour * hoursPerDay;
        long secondsPerYear = secondsPerDay * daysPerYear;

        // 2. Konvertering af sekunder til hele år og dage
        long years = totalSeconds / secondsPerYear;
        long remainingSeconds = totalSeconds % secondsPerYear;
        long days = remainingSeconds / secondsPerDay;

        // 3. Udskriv resultatet
        Console.WriteLine($"Tidsstempel svarer til: {years} år og {days} dage."); */
 

        // 2. Erklær en variabel der repræsenterer et antal sekunder siden 1. januar 2024
        long secondsSince2024 = 23299208; // 
        
        // Konstant værdier
        const int secondsPerMinute = 60;
        const int minutesPerHour = 60;
        const int hoursPerDay = 24;
        const int daysPerMonth = 30;
        const int monthsPerYear = 15;
        
        // Beregn sekunder per dag og måned
        long secondsPerDay = secondsPerMinute * minutesPerHour * hoursPerDay;
        long secondsPerMonth = secondsPerDay * daysPerMonth;

        // 3. Udregn måned og dag baseret på antallet af sekunder siden 1. januar 2024 (under forudsætning at alle måneder er præcis 30 dage)
        long months = secondsSince2024 / secondsPerMonth;
        long remainingSeconds = secondsSince2024 % secondsPerMonth;
        long days = remainingSeconds / secondsPerDay;

        // Indeksér månederne med tal (Januar = 1, Februar = 2, osv.)
        long currentMonth = months % monthsPerYear + 1;
        long currentDay = days + 1; // Dage starter fra 1

        // Udskriv den beregnede måned og dag
        Console.WriteLine($"Måned: {currentMonth}, Dag: {currentDay}");

        // 4. Tjek om det er juleaften
        if (currentMonth == 12 && currentDay == 24)
        {
            Console.WriteLine("Det er jul!");
        }
        else
        {
            // Beregn hvor lang tid der er til den 24. december
            long monthsUntilDecember = 12 - currentMonth;
            long daysUntil24th = 24 - currentDay;
            
            // Håndter hvis vi er i december, men dagen er før den 24.
            if (currentMonth == 12 && currentDay < 24)
            {
                monthsUntilDecember = 0;  // Ingen måneder tilbage, kun dage
                daysUntil24th = 24 - currentDay;
            }
            // Hvis vi er i en tidligere måned
            else if (currentMonth < 12)
            {
                daysUntil24th += monthsUntilDecember * daysPerMonth;  // Konverter måneder til dage
            }

            // Udskriv hvor mange dage der er til juleaften den 24/12
            Console.WriteLine($"Der er {daysUntil24th} dage til jul.");
        }
       

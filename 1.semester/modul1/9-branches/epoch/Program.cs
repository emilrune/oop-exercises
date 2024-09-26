
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
        Console.WriteLine($"Tidsstempel svarer til: {years} år og {days} dage.");
 
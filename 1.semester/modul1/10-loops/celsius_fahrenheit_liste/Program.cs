/* Skriv et program, hvori

- Der udskrives en tabel af matchende Celcius og Fahrenheit værdier
- Formel: T.fahrenheit = 32 + 9/5 T.celsius

- Der skal være ét sæt matchende værdier per linje.
- Listen skal starte med-5◦C og slutte ved 40◦C.
- Listen skal have én linje for hver 0,5◦C. */

// Metode blok - celsius til fahrenheit konvertering


//


// The following is a more simple way to convert and list the temperatures

// loop blok (INKL. konvertering)

for (double celsius = -5; celsius <= 40; celsius += 0.5)
    {                                                                     //loop for -5 to 40
        double fahrenheitConverted = 32 + (9.0 / 5.0) * celsius;            //conversion
        Console.WriteLine("Når celsius er = {0, 2 :0.0},  så er fahrenheit = {1, 2 :0.0}", celsius, fahrenheitConverted);          //console output
    }





/*
Skriv et program, hvori:

- Der udskrives en tabel af matchende Celcius og Fahrenheit værdier
- Formel: T.fahrenheit = 32 + 9/5 T.celsius

- Der skal være ét sæt matchende værdier per linje.
- Listen skal starte med-5◦C og slutte ved 40◦C.
- Listen skal have én linje for hver 0,5◦C.
*/


/* 
---------------------------------------------------------------------
Opgave 10.1 - Celsius til fahrenheit
---------------------------------------------------------------------
*/

/*
for (double celsius = -5; celsius <= 40; celsius += 0.5)                                                                            //loop for -5 to 40
    {                                                                     
        double fahrenheitConverted = 32 + (9.0 / 5.0) * celsius;                                                                    //conversion
        Console.WriteLine("Når celsius er = {0, 2 :0.0},  så er fahrenheit = {1, 2 :0.0}", celsius, fahrenheitConverted);          //console output
    }


/*
---------------------------------------------------------------------
Opgave 10.2 - Celsius til fahrenheit, i omvendt rækkefølge
---------------------------------------------------------------------
*/
/*
for (double celsius = 40; celsius >= -5; celsius -= 0.5)                                                                            //loop for 40 to -5
    {                                                                     
        double fahrenheitConverted = 32 + (9.0 / 5.0) * celsius;                                                                    //conversion
        Console.WriteLine("Når celsius er = {0, 2 :0.0},  så er fahrenheit = {1, 2 :0.0}", celsius, fahrenheitConverted);          //console output
    }


/*
---------------------------------------------------------------------
Opgave 10.3a - Celsius til fahrenheit alternativer: 'foreach' loop
---------------------------------------------------------------------
*/

/*
// Opret et array og fyld det med alle celsius værdier, fra -5 til 40, med 0.5 interval, vha. 'for' loop
double[] celsiusValues = new double[91];


for (int i = 0; i < celsiusValues.Length; i++)
    {
        celsiusValues[i] = -5 + i * 0.5;
    }
 
// brug 'foreach' loopet til at omregne celsius til fahrenheit, ud fra det "celsius-fyldte" array. 'Foreach' beregner på hver plads i array'et, et skridt af gangen
foreach (double celsius in celsiusValues)
    {
        double fahrenheitConverted = 32 + (9.0 / 5.0) * celsius;
        Console.WriteLine("Når celsius er = {0:0.0}, så er fahrenheit = {1:0.0}", celsius, fahrenheitConverted);
    }
Console.WriteLine("test");
*/


/*
---------------------------------------------------------------------
Opgave 10.3b - Celsius til fahrenheit alternativer: 'while' loop
---------------------------------------------------------------------
*/

// Erklær en double variabel og initialisér celsius-værdien til starttemperaturen (-5)
double celsius = -5;

// Brug et while loop til at iterere over celsius-værdierne, ("så længe celsius er mindre eller lig med 40 grader, skal loopet køres igennem igen")
while (celsius <= 40)
{
    // Konverter celsius til fahrenheit ud fra formlen
    double fahrenheitConverted = 32 + (9.0 / 5.0) * celsius;

    // Udskriv resultaterne
    Console.WriteLine("Når celsius er = {0:0.0}, så er fahrenheit = {1:0.0}", celsius, fahrenheitConverted);

    // Vigtigt for at få et while-loop til at virke; opdatér celsius-værdien med 0,5, for hver iteration. 
    celsius += 0.5;
}



/*
---------------------------------------------------------------------
TIP: brug følgende, til at tjekke om et array bliver fyldt korrekt op!

foreach (int i in celsiusValues)
    {
        Console.WriteLine(i.ToString());
    }
---------------------------------------------------------------------
*/
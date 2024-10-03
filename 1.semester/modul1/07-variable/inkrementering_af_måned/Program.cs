
        // 1. Erklær en heltallig variabel
        int month;

        // 2. Tildel variablen en værdi, fx 2 for Februar
        month = 2;

        // 3. Udskriv variablens værdi
        Console.WriteLine("Måned (første gang): " + month);

        // 4. Forøg værdien af denne variabel med en halv (1/2 = 0.5)
        month += (int)0.5;  // Heltal kan ikke gemme halve værdier, så det vil ikke ændre værdien

        // 5. Udskriv variablens værdi (forventet stadig 2, da heltal ikke ændres af halve værdier)
        Console.WriteLine("Måned (efter 0.5 forøgelse): " + month);

        // 6. Forøg værdien af denne variabel med en halv igen
        month += (int)0.5;  // Samme som før, ingen ændring

        // 7. Udskriv variablens værdi
        Console.WriteLine("Måned (efter endnu en 0.5 forøgelse): " + month);
 

/*  Forklaring:
Programmet erklærer en heltallig (type int) variabel "month". Variablen month tildeles værdien 2, som repræsenterer februar.

Den første udskrivning viser værdien af variablen (2).
Forsøget på at forøge variablen med 0.5 sker, men da variablen er af typen int (heltal), vil det ikke ændre værdien. Heltal kan ikke gemme decimaltal
så resultatet bliver rundet ned, og værdien forbliver 2.

Efter den første forøgelse udskrives variablen igen, og den forbliver 2.
Endnu en forøgelse med 0.5 sker, men ligesom før forbliver værdien 2.

Til sidst udskrives den endelige værdi af variablen, som stadig er 2.

Bemærkning:
Hvis man ønsker at de halve forøgelser faktisk skal påvirke variablen, skal man bruge en datatype der understøtter decimaltal (fx "double" eller "float") i stedet for "int". */
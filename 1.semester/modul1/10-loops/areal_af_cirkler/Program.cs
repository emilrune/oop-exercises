
/* 
---------------------------------------------------------------------
Opgave 10.4 - Areal af cirkler (beregnet vha. loops)
---------------------------------------------------------------------
*/

/* Skriv et program der udregner og udskriver arealet (π · r2) af tre cirkler med
 radius på hhv. 1, 3 og 5. Beregninger skal køres vha. loops (jeg har brugt foreach loop + et array) */

// Array med de tre radius-værdier
double[] radii = { 1, 3, 5 };

// Konstant værdi for pi
const double pi = Math.PI;

// Loop gennem alle radius-værdier og beregn arealet
foreach (double radius in radii)
{
    // Beregn arealet for den aktuelle cirkel vha. Math.Pow metoden (.Pow = "ARG 1 raised to power of ARG 2")
    double area = pi * Math.Pow(radius, 2);

    // Udskriv radius og det tilhørende areal
    Console.WriteLine("En cirkel med radius {0} har et areal på {1:0.00}", radius, area);
}
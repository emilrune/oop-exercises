
/* Skriv et program der udregner og udskriver arealet (π · r2) af tre cirkler med
 radius på hhv. 1, 3 og 5. */

 double radius1=1;
 double radius2=3;
 double radius3=5;

 double pi=3.14;

 double result1 = pi * radius1 * radius1;
 double result2 = pi * radius2 * radius2;
 double result3 = pi * radius3 * radius3;
 
string txt1 = "Hvis radius er " + radius1 + " så er arealet " + result1;
string txt2 = "Hvis radius er " + radius2 + " så er arealet " + result2;
string txt3 = "Hvis radius er " + radius3 + " så er arealet " + result3;

// Console.WriteLine("Hvis radius er 1 er arealet: " + result1 + "\nhvis radius er 3 er arealet: " + result2);

Console.WriteLine(txt1);
Console.WriteLine(txt2);
Console.WriteLine(txt3);

// Forsøgt med funktioner

// double functionResult(double)
/*
 Skriv et program, der finder det største tal i et array af typen int[], og udskriver indeks for dette tal. Find selv på noget passende indhold til dette array.
*/


/* 
---------------------------------------------------------------------
Opgave 11.4 - Størst i Array
---------------------------------------------------------------------
*/

int[] largestNumber = new int[10]; //laver et int array med 10 pladser
int min = 0; //erklærer min og max værdier for tallene der skal fyldes i array
int max = 50;


//BLOK TIL AT GENERERE TILFÆLDIGE TAL
Random randomNumber = new Random(); //metode til at generere tilfældige tal, gemt i 'Random' klassen, under navnet randomNumber

for (int i = 0; i < largestNumber.Length; i++) //for loop til at fylde array op, med nedenstående
    {
    largestNumber[i] = randomNumber.Next(min, max); //her fyldes tilfældige tal, vha. Random.Next ind i largestNumber array'et (indenfor min og max variablerne)
    Console.WriteLine("Tallet på plads {0} i array'et har værdien: {1}", i, largestNumber[i]); //udskriver alle genererede tal, på deres respektive pladser i array'et
    }

//BLOK TIL AT FINDE DET STØRSTE TAL
int maxNumber = largestNumber[0]; //erklærer en ny variabel, der i første omgang indeholder værdien fra array'ets allerførste plads

for (int i = 1; i < largestNumber.Length; i++) //for loop til at tjekke alle array talværdierne
{
    if (largestNumber[i] > maxNumber) //if statement, der opdaterer maxNumber, med en større værdi (hvis plads 0 ikke allerede indeholdt den største værdi i array'et)
    {
        maxNumber = largestNumber[i];
    }
}

Console.WriteLine("\nDet største tal af alle i array'et er: " + maxNumber);


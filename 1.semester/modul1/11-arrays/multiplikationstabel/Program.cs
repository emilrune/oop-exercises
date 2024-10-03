

// 1. Initialiser variablen 'size' til 24
int size = 25;

// 2. Opret et array med længde svarende til 'size'
int[] multiplesOfThree = new int[size];

// 3. Fyld arrayet med 3-tabellen (elementet på indeks n skal have værdien 3 * n)
for (int i = 0; i < multiplesOfThree.Length; i++)
{
    multiplesOfThree[i] = 3 * i;
}

// 4. Udskriv nogle vigtige elementer for at verificere korrektheden
Console.WriteLine("Første element (multiplesOfThree[0]): " + multiplesOfThree[1]);  // Det første element
Console.WriteLine("Midterste element (multiplesOfThree[{0}]): " + multiplesOfThree[size / 2], size / 2);  // Det midterste element
Console.WriteLine("Sidste element (multiplesOfThree[{0}]): " + multiplesOfThree[size - 1], size - 1);  // Det sidste element

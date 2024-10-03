

// 1. Opret en multidimensionel array [12 måneder, maks 31 dage per måned]
string[,] calendar = new string[12, 31]; // Antag maks 31 dage i hver måned
string[] daysOfWeek = { "Mandag", "Tirsdag", "Onsdag", "Torsdag", "Fredag", "Lørdag", "Søndag" };

// Antal dage i hver måned i 2024 (skudår)
int[] daysInMonth = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

// Start 1. januar 2024 på en mandag (index 0)
int dayIndex = 0;

// 2. Fyld kalenderen med korrekte ugedage
for (int month = 0; month < 12; month++)
{
    for (int day = 0; day < daysInMonth[month]; day++)
    {
        calendar[month, day] = daysOfWeek[dayIndex];
        dayIndex = (dayIndex + 1) % 7; // Cirkulerer gennem ugedagene
    }
}

// 3. Udskriv kalenderen som en tabel
string[] monthNames = { "Januar", "Februar", "Marts", "April", "Maj", "Juni", "Juli", "August", "September", "Oktober", "November", "December" };

for (int month = 0; month < 12; month++)
{
    Console.WriteLine("\n" + monthNames[month] + ":");
    for (int day = 0; day < daysInMonth[month]; day++)
    {
        // Udskriv hver dag og ugedag
        //Console.WriteLine("{1} d. {0,20: 0.0}", day + 1 + ". " + monthNames[month], calendar[month, day]);

        Console.WriteLine("{0} d. {1}", calendar[month, day], day + 1 + ". " + monthNames[month]);
    }
}
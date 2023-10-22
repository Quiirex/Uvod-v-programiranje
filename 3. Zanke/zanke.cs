// 'for' zanka:
// 'for' zanka se uporablja za izvajanje kode določeno število krat.

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Ponavljam " + i);
}

//////////////////////////////////////////////////////////////////////////////////////

// 'while' zanka:
// 'while' zanka izvaja določen kos kode, dokler je pogoj izpolnjen.

int stevec = 0;
while (stevec < 5)
{
    Console.WriteLine("Ponavljam " + stevec);
    stevec++;
}

//////////////////////////////////////////////////////////////////////////////////////

// 'do-while' zanka:
// 'do-while' zanka je podobna while zanki, 
// vendar se koda vedno izvede vsaj enkrat, 
// nato pa se izvaja, dokler je pogoj izpolnjen.

int stevec = 0;
do
{
    Console.WriteLine("Ponavljam " + stevec);
    stevec++;
}
while (stevec < 5);

//////////////////////////////////////////////////////////////////////////////////////

// Prekinitev zanke:
// Zanke je mogoče prekiniti z uporabo ukazov "break" ali "continue".

for (int i = 0; i < 10; i++)
{
    if (i == 5)
        break; // Prekine zanko
    Console.WriteLine(i);
}

for (int i = 0; i < 10; i++)
{
    if (i == 5)
        continue; // Nadaljuj z naslednjo iteracijo
    Console.WriteLine(i);
}

//////////////////////////////////////////////////////////////////////////////////////

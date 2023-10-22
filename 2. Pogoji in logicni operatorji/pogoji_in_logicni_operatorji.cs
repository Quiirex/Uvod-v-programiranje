// Pogoji (if-else):
// Pogojni stavki se uporabljajo za izvajanje različnih delov 
// kode glede na izpolnjevanje določenega pogoja.

int starost = 20;

if (starost >= 18)
{
    Console.WriteLine("Oseba je polnoletna.");
}
else
{
    Console.WriteLine("Oseba je mladoletna.");
}

//////////////////////////////////////////////////////////////////////////////////////

// Večpogojni stavki (else if):
// Uporabljajo se za preverjanje več pogojev po vrsti in izvajanje ustreznega dela kode, 
// ki ustreza prvemu izpolnjenemu pogoju.

int ocena = 85;

if (ocena >= 90)
{
    Console.WriteLine("Odlično!");
}
else if (ocena >= 70)
{
    Console.WriteLine("Dobro.");
}
else
{
    Console.WriteLine("Potrebno izboljšanje.");
}

//////////////////////////////////////////////////////////////////////////////////////

// Logični operatorji (&&, ||, !):
// Uporaba logičnih operatorjev za združevanje pogojev.

int starost = 20;
bool jeStudent = true;

if (starost >= 18 && jeStudent) // && -> in
{
    Console.WriteLine("Oseba je polnoletna in študent.");
}
else if (starost >= 18 || jeStudent) // || -> ali
{
    Console.WriteLine("Oseba je polnoletna ali študent.");
}
else if (!jeStudent) // ! -> negacija
{
    Console.WriteLine("Oseba ni študent.");
}

//////////////////////////////////////////////////////////////////////////////////////

// Ternarni operator (?:):
// Uporaba ternarnega operatorja za krajše pogoje preverjanja v izrazih.

int starost = 20;
string status = (starost >= 18) ? "Polnoletna" : "Mladoletna";
// ekvivalentno:
// if (starost >= 18)
// {
//     status = "Polnoletna";
// }
// else
// {
//     status = "Mladoletna";
// }
Console.WriteLine("Oseba je " + status + ".");

//////////////////////////////////////////////////////////////////////////////////////

// Switch stavki:
// Uporaba switch stavkov za izvajanje različnih delov kode glede na vrednost spremenljivke.

int ocena = 3;
switch (ocena)
{
    case 1:
        Console.WriteLine("Nedovoljivo");
        break;
    case 2:
        Console.WriteLine("Zadostno");
        break;
    case 3:
        Console.WriteLine("Dobro");
        break;
    default:
        Console.WriteLine("Ni ocene.");
        break;
}

//////////////////////////////////////////////////////////////////////////////////////
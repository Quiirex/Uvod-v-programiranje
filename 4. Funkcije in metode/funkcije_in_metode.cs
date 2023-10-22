// Funkcije in Metode:
// Funkcije so osnovna sestavina vsakega programskega jezika. 
// Omogočajo, da razdelimo svoj program na manjše enote, 
// ki izvajajo specifične naloge. 

void Pozdravi(string ime)
{
    Console.WriteLine("Pozdravljen, " + ime + "!");
}

//////////////////////////////////////////////////////////////////////////////////////

// Metode:
// Metode so funkcije, ki so definirane znotraj razreda.

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
    }
}

//////////////////////////////////////////////////////////////////////////////////////

// Vračanje vrednosti
// Funkcije lahko vračajo vrednosti.

int Dodaj(int a, int b)
{
    return a + b;
}

string Pozdravi(string ime)
{
    return "Pozdravljen, " + ime + "!";
}

//////////////////////////////////////////////////////////////////////////////////////

// Argumenti funkcije:
// Funkcije sprejemajo argumente (parametre),
// ki jih lahko uporabljamo v telesu funkcije.

void Pozdravi(string ime)
{
    Console.WriteLine("Pozdravljen, " + ime + "!");
}

//////////////////////////////////////////////////////////////////////////////////////

// Overload funkcij:
// Definiramo lahko več funkcij z istim imenom, 
// vendar z različnim številom ali tipom argumentov. 
// Ta koncept se imenuje "overload" funkcij.

void Pozdravi(string ime)
{
    Console.WriteLine("Pozdravljen, " + ime + "!");
}

void Pozdravi(string ime, string priimek)
{
    Console.WriteLine("Pozdravljen, " + ime + " " + priimek + "!");
}

//////////////////////////////////////////////////////////////////////////////////////

// Rekurzija:
// Funkcija lahko kliče sama sebe, kar imenujemo rekurzija.

int Fib(int n)
{
    if (n <= 1)
    {
        return n;
    }
    return Fib(n - 1) + Fib(n - 2);
}

//////////////////////////////////////////////////////////////////////////////////////

// Statične metode:
// Ko je beseda "static" uporabljena v definiciji metode (na primer public static void myMethod()), 
// pomeni, da metoda pripada razredu samemu, ne pa tudi posameznim primerkom razreda. 
// To pomeni, da metode ni treba povezati z določenim objektom razreda, 
// ampak jo je mogoče klicati neposredno prek razreda. 
// To je koristno, kadar metoda ne potrebuje dostopa do stanja posameznih primerkov razreda.

public class Calculator
{
    public static int Add(int a, int b)
    {
        return a + b;
    }
}

// Klic staticne metode
int rezultat = Calculator.Add(5, 3);

//////////////////////////////////////////////////////////////////////////////////////

// Statične spremenljivke:
// Ko je beseda "static" uporabljena v definiciji spremenljivke (na primer public static int myVar;),
// pomeni, da spremenljivka pripada razredu samemu, ne pa tudi posameznim primerkom razreda.

public class Counter
{
    public static int Count = 0;
}

// Uporaba staticne spremenljivke
Counter.Count++;

//////////////////////////////////////////////////////////////////////////////////////

// Statični blok kode:
// Ko je beseda "static" uporabljena v definiciji bloka kode (na primer static { ... }),
// pomeni, da se bo ta blok kode izvedel samo enkrat, ko se bo razred naložil v pomnilnik.

public class MyStaticClass
{
    static MyStaticClass()
    {
        // Ta blok kode se izvede ob prvem dostopu do razreda
        Console.WriteLine("Staticni konstruktor se izvaja.");
    }
}

//////////////////////////////////////////////////////////////////////////////////////

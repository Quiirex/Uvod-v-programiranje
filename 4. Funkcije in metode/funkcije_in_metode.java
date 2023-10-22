// Funkcije in Metode:
// Funkcije so osnovna sestavina vsakega programskega jezika. 
// Omogočajo, da razdelimo svoj program na manjše enote, 
// ki izvajajo specifične naloge. 

void pozdravi(String ime) {
    System.out.println("Pozdravljen, " + ime + "!");
}

//////////////////////////////////////////////////////////////////////////////////////

// Metode:
// Metode so funkcije, ki so definirane znotraj razreda.

public class Main {
    public static void main(String[] args) {
        System.out.println("Hello World!");
    }
}

//////////////////////////////////////////////////////////////////////////////////////

// Vračanje vrednosti
// Funkcije lahko vračajo vrednosti.

int dodaj(int a, int b) {
    return a + b;
}

String pozdravi(String ime) {
    return "Pozdravljen, " + ime + "!";
}

//////////////////////////////////////////////////////////////////////////////////////

// Argumenti funkcije:
// Funkcije sprejemajo argumente (parametre),
// ki jih lahko uporabljamo v telesu funkcije.

void pozdravi(String ime) {
    System.out.println("Pozdravljen, " + ime + "!");
}

//////////////////////////////////////////////////////////////////////////////////////

// Overload funkcij:
// Definiramo lahko več funkcij z istim imenom, 
// vendar z različnim številom ali tipom argumentov. 
// Ta koncept se imenuje "overload" funkcij.

void pozdravi(String ime) {
    System.out.println("Pozdravljen, " + ime + "!");
}

void pozdravi(String ime, String priimek) {
    System.out.println("Pozdravljen, " + ime + " " + priimek + "!");
}

//////////////////////////////////////////////////////////////////////////////////////

// Rekurzija:
// Funkcija lahko kliče sama sebe, kar imenujemo rekurzija.

int fib(int n) {
    if (n <= 1) {
        return n;
    }
    return fib(n - 1) + fib(n - 2);
}

//////////////////////////////////////////////////////////////////////////////////////

// Statične metode:
// Ko je beseda "static" uporabljena v definiciji metode (na primer public static void myMethod()), 
// pomeni, da metoda pripada razredu samemu, ne pa tudi posameznim primerkom razreda. 
// To pomeni, da metode ni treba povezati z določenim objektom razreda, 
// ampak jo je mogoče klicati neposredno prek razreda. 
// To je koristno, kadar metoda ne potrebuje dostopa do stanja posameznih primerkov razreda.

public class Calculator {
    public static int add(int a, int b) {
        return a + b;
    }
}

// Klic statične metode
int rezultat = Calculator.add(5, 3);

//////////////////////////////////////////////////////////////////////////////////////

// Statične spremenljivke:
// Ko je beseda "static" uporabljena v definiciji spremenljivke (na primer public static int myVar;),
// pomeni, da spremenljivka pripada razredu samemu, ne pa tudi posameznim primerkom razreda.

public class Counter {
    public static int count = 0;
}

// Uporaba statične spremenljivke
Counter.count++;

//////////////////////////////////////////////////////////////////////////////////////

// Statični blok kode:
// Ko je beseda "static" uporabljena v definiciji bloka kode (na primer static { ... }),
// pomeni, da se bo ta blok kode izvedel samo enkrat, ko se bo razred naložil v pomnilnik.

public class MyStaticClass {
    static {
        // Ta blok kode se izvede ob prvem dostopu do razreda
        System.out.println("Statični konstruktor se izvaja.");
    }
}

//////////////////////////////////////////////////////////////////////////////////////
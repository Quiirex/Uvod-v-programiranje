// Objektno-usmerjeno programiranje (OOP):
// Objektno-usmerjeno programiranje je paradigma, 
// ki temelji na konceptih objektov in razredov. 
// OOP omogoča boljše organiziranje in upravljanje kode 
// ter spodbuja ponovno uporabo kode.

// Strukti (Structs):
// Strukti so podobni razredom, vendar so vrednostni tipi
// in jih običajno uporabljamo za majhne podatkovne strukture.

public struct Coords
{
    public double X { get; }
    public double Y { get; }
    
    public Coords(double x, double y)
    {
        X = x;
        Y = y;
    }

    public override string ToString() => $"({X}, {Y})";
}

//////////////////////////////////////////////////////////////////////////////////////

// Razredi (Classes): 
// Razredi so temeljna enota OOP in predstavljajo modele objektov.

public class Oseba
{
    public string Ime { get; set; }
    public int Starost { get; set; }
}

//////////////////////////////////////////////////////////////////////////////////////

// Lastnosti (Properties):
// Lastnosti so podatki, ki jih ima objekt.

public class Oseba
{
    public string Ime { get; set; } // Ime je lastnost
    public int Starost { get; set; } // Starost je lastnost
}

//////////////////////////////////////////////////////////////////////////////////////

// Fieldi (Fields):
// Fieldi so (skoraj vedno) zasebni za razred in 
// dostopni prek lastnosti get in set.

public class Oseba
{
    // Ime in starost sta lastnosti
    public string Ime
    {
        get { return ime; } // ime je field
        set { ime = value; }
    }

    public int Starost
    {
        get { return starost; } // starost je field
        set { starost = value; }
    }

    private string priimek; // priimek je field
}

//////////////////////////////////////////////////////////////////////////////////////

// Objekti (Objects): 
// Objekti so primerki razredov, ki dejansko obstajajo v programu. 
// Lahko ustvarimo več objektov istega razreda.

Oseba oseba1 = new Oseba();
oseba1.Ime = "Janez";
oseba1.Starost = 20;

//////////////////////////////////////////////////////////////////////////////////////

// Konstruktorji (Constructors): 
// Konstruktorji so posebne metode razreda, 
// ki se kličejo ob ustvarjanju objekta 
// in omogočajo inicializacijo objekta.

public class Oseba
{
    public string Ime { get; set; }
    public int Starost { get; set; }

    public Oseba(string ime, int starost)
    {
        this.Ime = ime;
        this.Starost = starost;
    }
}

// 'This' rezervirana beseda se uporablja za sklicevanje na trenutni objekt.

//////////////////////////////////////////////////////////////////////////////////////

// Encapsulacija (Encapsulation): 
// Encapsulacija pomeni skrivanje podatkov razreda 
// pred neposrednim dostopom 
// ter zagotavljanje dostopa prek javnih vmesnikov (getters in setters).

public class Oseba
{
    private string ime;
    private int starost;

    public string Ime
    {
        get { return ime; }
        set { ime = value; }
    }

    public int Starost
    {
        get { return starost; }
        set { starost = value; }
    }
}

//////////////////////////////////////////////////////////////////////////////////////

// Dedovanje (Inheritance): 
// Dedovanje omogoča ustvarjanje novih razredov (podrazredov), 
// ki podedujejo lastnosti in metode obstoječega razreda (nadrazreda).
// Podrazredi lahko nadgradijo ali spremenijo obstoječe lastnosti in metode.
// V C# lahko razred deduje od večih razredov.

public class Oseba
{
    public string Ime { get; set; }
    public int Starost { get; set; }
}

public class Student : Oseba
{
    public int Letnik { get; set; }
}

// Večkratno dedovanje (Multiple Inheritance):

public class Oseba
{
    public string Ime { get; set; }
    public int Starost { get; set; }
}

public class Student : Oseba
{
    public int Letnik { get; set; }
}

public class Zaposlen : Oseba
{
    public int Placa { get; set; }
}

public class StudentZaposlen : Student, Zaposlen
{
    public int Placa { get; set; }
}

//////////////////////////////////////////////////////////////////////////////////////

// Polimorfizem (Polymorphism): 
// Polimorfizem omogoča, da različni objekti istega nadrazreda 
// uporabljajo enake metode na svoj način. 
// To omogoča prilagajanje vedenja razredov.

public class Oseba
{
    public string Ime { get; set; }
    public int Starost { get; set; }

    public virtual void Pozdravi()
    {
        Console.WriteLine("Pozdravljen, " + Ime + "!");
    }
}

public class Student : Oseba
{
    public int Letnik { get; set; }

    public override void Pozdravi()
    {
        Console.WriteLine("Zdravo, " + Ime + "!");
    }
}

//////////////////////////////////////////////////////////////////////////////////////

// Abstraktni razredi in metode (Abstract Classes and Methods): 
// Abstraktne razrede in metode uporabljamo za definiranje skupnih lastnosti, 
// vendar njihove dejanske implementacije odložimo na podrazrede.

public abstract class Oseba
{
    public string Ime { get; set; }
    public int Starost { get; set; }

    public abstract void Pozdravi();
}

public class Student : Oseba
{
    public int Letnik { get; set; }

    public override void Pozdravi()
    {
        Console.WriteLine("Zdravo, " + Ime + "!");
    }
}

//////////////////////////////////////////////////////////////////////////////////////

// Vmesniki (Interfaces):
// Vmesniki so podobni abstraktnim razredom,
// vendar lahko razredi implementirajo več vmesnikov.
// Ne rabi imeti črke I pred imenom, to je za lažjo prepoznavnost.

public interface IOseba
{
    string Ime { get; set; }
    int Starost { get; set; }

    void Pozdravi();
}

public class Student : IOseba
{
    public string Ime { get; set; }
    public int Starost { get; set; }
    public int Letnik { get; set; }

    public void Pozdravi()
    {
        Console.WriteLine("Zdravo, " + Ime + "!");
    }
}

//////////////////////////////////////////////////////////////////////////////////////
// Objektno-usmerjeno programiranje (OOP):
// Objektno-usmerjeno programiranje je paradigma, 
// ki temelji na konceptih objektov in razredov. 
// OOP omogoča boljše organiziranje in upravljanje kode 
// ter spodbuja ponovno uporabo kode.

//////////////////////////////////////////////////////////////////////////////////////

// Razredi (Classes):
// Razredi so temeljna enota OOP in predstavljajo modele objektov.

public class Oseba {
    public String ime;
    public int starost;
}

//////////////////////////////////////////////////////////////////////////////////////

// Lastnosti (Properties):
// Lastnosti so podatki, ki jih ima objekt.

public class Oseba {
    private String ime; // ime je lastnost
    private int starost; // starost je lastnost
}

//////////////////////////////////////////////////////////////////////////////////////

// Objekti (Objects): 
// Objekti so primerki razredov, ki dejansko obstajajo v programu. 
// Lahko ustvarimo več objektov istega razreda.

Oseba oseba1 = new Oseba();
oseba1.ime = "Janez";
oseba1.starost = 20;

//////////////////////////////////////////////////////////////////////////////////////

// Konstruktorji (Constructors):
// Konstruktorji so posebne metode razreda,
// ki se kličejo ob ustvarjanju objekta
// in omogočajo inicializacijo objekta.

public class Oseba {
    public String ime;
    public int starost;

    public Oseba(String ime, int starost) {
        this.ime = ime;
        this.starost = starost;
    }
}

//////////////////////////////////////////////////////////////////////////////////////

// Encapsulacija (Encapsulation):
// Encapsulacija pomeni skrivanje podatkov razreda
// pred neposrednim dostopom
// ter zagotavljanje dostopa prek javnih vmesnikov (getters in setters).

public class Oseba {
    private String ime;
    private int starost;

    public String getIme() {
        return ime;
    }

    public void setIme(String ime) {
        this.ime = ime;
    }

    public int getStarost() {
        return starost;
    }

    public void setStarost(int starost) {
        this.starost = starost;
    }
}

//////////////////////////////////////////////////////////////////////////////////////

// Dedovanje (Inheritance):
// Dedovanje omogoča ustvarjanje novih razredov (podrazredov),
// ki podedujejo lastnosti in metode obstoječega razreda (nadrazreda).
// Podrazredi lahko nadgradijo ali spremenijo obstoječe lastnosti in metode.
// V Javi lahko razred deduje samo od enega razreda.

public class Oseba {
    public String ime;
    public int starost;
}

public class Student extends Oseba {
    public int letnik;
}

//////////////////////////////////////////////////////////////////////////////////////

// Polimorfizem (Polymorphism):
// Polimorfizem omogoča, da različni objekti istega nadrazreda
// uporabljajo enake metode na svoj način.
// To omogoča prilagajanje vedenja razredov.

public class Oseba {
    public String ime;
    public int starost;

    public void pozdravi() {
        System.out.println("Pozdravljen, " + ime + "!");
    }
}

public class Student extends Oseba {
    public int letnik;

    @Override
    public void pozdravi() {
        System.out.println("Zdravo, " + ime + "!");
    }
}

//////////////////////////////////////////////////////////////////////////////////////

// Abstraktne razrede in metode (Abstract Classes and Methods):
// Abstraktne razrede in metode uporabljamo za definiranje skupnih lastnosti,
// vendar njihove dejanske implementacije odložimo na podrazrede.

public abstract class Oseba {
    public String ime;
    public int starost;

    public abstract void pozdravi();
}

public class Student extends Oseba {
    public int letnik;

    @Override
    public void pozdravi() {
        System.out.println("Zdravo, " + ime + "!");
    }
}

//////////////////////////////////////////////////////////////////////////////////////

// Vmesniki (Interfaces):
// Vmesniki so podobni abstraktnim razredom,
// vendar lahko razredi implementirajo več vmesnikov.
// Ne rabi imeti črke I pred imenom, to je za lažjo prepoznavnost.

public interface IOseba {
    String getIme();
    int getStarost();

    void pozdravi();
}

public class Student implements IOseba {
    private String ime;
    private int starost;
    private int letnik;

    public String getIme() {
        return ime;
    }

    public int getStarost() {
        return starost;
    }

    public void pozdravi() {
        System.out.println("Zdravo, " + ime + "!");
    }
}

//////////////////////////////////////////////////////////////////////////////////////
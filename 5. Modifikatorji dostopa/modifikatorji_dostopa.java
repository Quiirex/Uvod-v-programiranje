// Public (javno):
// Če deklarirate spremenljivko ali metodo kot "public",
// je ta dostopna iz katerega koli drugega razreda.

public class Oseba {
    public String ime;
    public void Pozdravi() {
        System.out.println("Pozdravljen!");
    }
}

//////////////////////////////////////////////////////////////////////////////////////

// Private (zasebno):
// Če deklarirate spremenljivko ali metodo kot "private",
// je ta dostopna samo iz razreda, v katerem je bila deklarirana.

public class Oseba {
    private String ime;
    private void Pozdravi() {
        System.out.println("Pozdravljen!");
    }
}

//////////////////////////////////////////////////////////////////////////////////////

// Protected (zaščiteno):
// Če deklarirate spremenljivko ali metodo kot "protected",
// je ta dostopna samo iz razreda, v katerem je bila deklarirana,
// in iz podrazredov tega razreda.

public class Oseba {
    protected String ime;
    protected void Pozdravi() {
        System.out.println("Pozdravljen!");
    }
}

//////////////////////////////////////////////////////////////////////////////////////

// Default (privzeto):
// Če deklarirate spremenljivko ali metodo brez modifikatorja dostopa,
// je ta dostopna samo iz razreda, v katerem je bila deklarirana,
// in iz razredov v istem paketu.

public class Oseba {
    String ime;
    void Pozdravi() {
        System.out.println("Pozdravljen!");
    }
}

//////////////////////////////////////////////////////////////////////////////////////
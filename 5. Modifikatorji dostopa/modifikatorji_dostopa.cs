// Public (javno):
// Če deklarirate spremenljivko ali metodo kot "public",
// je ta dostopna iz katerega koli drugega razreda.

public class Oseba {
    public string Ime;
    public void Pozdravi() {
        Console.WriteLine("Pozdravljen!");
    }
}

//////////////////////////////////////////////////////////////////////////////////////

// Private (zasebno):
// Če deklarirate spremenljivko ali metodo kot "private",
// je ta dostopna samo iz razreda, v katerem je bila deklarirana.

public class Oseba {
    private string Ime;
    private void Pozdravi() {
        Console.WriteLine("Pozdravljen!");
    }
}

//////////////////////////////////////////////////////////////////////////////////////

// Protected (zaščiteno):
// Če deklarirate spremenljivko ali metodo kot "protected",
// je ta dostopna samo iz razreda, v katerem je bila deklarirana,
// in iz podrazredov tega razreda.

public class Oseba {
    protected string Ime;
    protected void Pozdravi() {
        Console.WriteLine("Pozdravljen!");
    }
}

//////////////////////////////////////////////////////////////////////////////////////

// Internal (notranje):
// Če deklarirate spremenljivko ali metodo kot "internal",
// je ta dostopna samo iz trenutnega projekta (assembly).

public class Oseba {
    internal string Ime;
    internal void Pozdravi() {
        Console.WriteLine("Pozdravljen!");
    }
}

//////////////////////////////////////////////////////////////////////////////////////

// Protected Internal (zaščiteno notranje):
// Če deklarirate spremenljivko ali metodo kot "protected internal",
// je ta dostopna iz trenutnega projekta (assembly) in iz podrazredov tega razreda (assembly).

public class Oseba {
    protected internal string Ime;
    protected internal void Pozdravi() {
        Console.WriteLine("Pozdravljen!");
    }
}

//////////////////////////////////////////////////////////////////////////////////////

// Private Protected (zasebno zaščiteno):
// Če deklarirate spremenljivko ali metodo kot "private protected",
// je ta dostopna samo iz trenutnega projekta (assembly) in iz podrazredov tega razreda (assembly).

public class Oseba {
    private protected string Ime;
    private protected void Pozdravi() {
        Console.WriteLine("Pozdravljen!");
    }
}

//////////////////////////////////////////////////////////////////////////////////////
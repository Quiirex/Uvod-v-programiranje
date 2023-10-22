// Sestavljanje nizov (String Concatenation) in Formatiranje nizov (String Formatting):
// Sestavljanje več nizov v en niz.

String ime = "Ana";
String priimek = "Novak";
String celoIme = ime + " " + priimek;
// Rezultat: celoIme = "Ana Novak"

// Ali

String celoIme = String.format("%s %s", ime, priimek);

// Ali

String celoIme = String.join(" ", ime, priimek);

// Ali

String celoIme = new StringBuilder().append(ime).append(" ").append(priimek).toString();

//////////////////////////////////////////////////////////////////////////////////////

// Iskanje v nizih (String Searching):
// Iskanje podnizov v nizu.

String besedilo = "To je primer besedila za iskanje.";
boolean vsebujeBesedo = besedilo.contains("primer");
int pozicija = besedilo.indexOf("besedila");
// Rezultat: pozicija = 14

//////////////////////////////////////////////////////////////////////////////////////

// Spreminjanje nizov (String Manipulation):
// Spreminjanje nizov, npr. z zamenjavo besed ali odstranjevanjem presledkov.

String izvirno = "To je izvirno besedilo.";
String spremenjeno = izvirno.replace("izvirno", "spremenjeno");
String brezPresledkov = izvirno.replace(" ", "");
// Rezultat: brezPresledkov = "Tojeizvirnobesedilo."

//////////////////////////////////////////////////////////////////////////////////////

// Razdeljevanje nizov (String Splitting):
// Razdeljevanje niza na manjše dele glede na določen znak ali vzorec.

String nizi = "Prvi;Drugi;Tretji";
String[] deli = nizi.split(";");
// Rezultat: deli = { "Prvi", "Drugi", "Tretji" }

//////////////////////////////////////////////////////////////////////////////////////

// Velikost in Primerjava nizov (String Length and Comparison):
// Ugotavljanje dolžine niza ter primerjanje nizov.

String prvi = "Abcd";
String drugi = "abcd";
int dolzina = prvi.length();
boolean enaka = prvi.equalsIgnoreCase(drugi);
// Rezultat: dolzina = 4, enaka = true

//////////////////////////////////////////////////////////////////////////////////////

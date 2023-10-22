// Sestavljanje nizov (String Concatenation) in Formatiranje nizov (String Formatting):
// Sestavljanje več nizov v en niz.

string ime = "Ana";
string priimek = "Novak";
string celoIme = ime + " " + priimek;
// Rezultat: celoIme = "Ana Novak"

// Ali

string celoIme = string.Format("{0} {1}", ime, priimek);

// Ali

string celoIme = $"{ime} {priimek}";

// Ali

string celoIme = string.Concat(ime, " ", priimek);

// Ali

string celoIme = string.Join(" ", ime, priimek);

// Ali

StringBuilder sb = new StringBuilder();
sb.Append(ime);
sb.Append(" ");
sb.Append(priimek);

//////////////////////////////////////////////////////////////////////////////////////

// Iskanje v nizih (String Searching):
// Iskanje podnizov v nizu.

string besedilo = "To je primer besedila za iskanje.";
bool vsebujeBesedo = besedilo.Contains("primer");
int pozicija = besedilo.IndexOf("besedila");
// Rezultat: pozicija = 14

//////////////////////////////////////////////////////////////////////////////////////

// Spreminjanje nizov (String Manipulation):
// Spreminjanje nizov, npr. z zamenjavo besed ali odstranjevanjem presledkov.

string izvirno = "To je izvirno besedilo.";
string spremenjeno = izvirno.Replace("izvirno", "spremenjeno");
string brezPresledkov = izvirno.Replace(" ", "");
// Rezultat: brezPresledkov = "Tojeizvirnobesedilo."

//////////////////////////////////////////////////////////////////////////////////////

// Razdeljevanje nizov (String Splitting):
// Razdeljevanje niza na manjše dele glede na določen znak ali vzorec.

string nizi = "Prvi;Drugi;Tretji";
string[] deli = nizi.Split(';');
// Rezultat: deli = { "Prvi", "Drugi", "Tretji" }

//////////////////////////////////////////////////////////////////////////////////////

// Velikost in Primerjava nizov (String Length and Comparison):
// Ugotavljanje dolžine niza ter primerjanje nizov.

string prvi = "Abcd";
string drugi = "abcd";
int dolzina = prvi.Length;
bool enaka = prvi.Equals(drugi, StringComparison.OrdinalIgnoreCase);
// Rezultat: dolzin = 3, enaka = true

//////////////////////////////////////////////////////////////////////////////////////

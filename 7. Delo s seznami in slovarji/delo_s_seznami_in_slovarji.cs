// Seznami:
// Uporaba seznama za shranjevanje večih elementov istega tipa podatkov.

List<int> stevilke = new List<int> { 1, 2, 3, 4, 5 };
stevilke.Add(6);
int prvaStevilka = stevilke[0];
// Rezultat: stevilke = { 1, 2, 3, 4, 5, 6 }
// Rezultat: prvaStevilka = 1

//////////////////////////////////////////////////////////////////////////////////////

// Slovarji:
// Uporaba slovarja za shranjevanje parov ključa in vrednosti.

Dictionary<string, int> ocene = new Dictionary<string, int>();
ocene["Ana"] = 95;
ocene["Boris"] = 88;
int ocenaAne = ocene["Ana"];
// Rezultat: ocene = { "Ana": 95, "Boris": 88 }
// Rezultat: ocenaAne = 95

//////////////////////////////////////////////////////////////////////////////////////

// Zanke v seznamih in slovarjih:
// Uporaba zank za pregledovanje elementov v seznamih in slovarjih.

List<int> stevilke = new List<int> { 1, 2, 3, 4, 5 };
foreach (int stevilka in stevilke)
{
    Console.WriteLine(stevilka);
}
// Rezultat: stevilke = { 1, 2, 3, 4, 5 }
// Rezultat:
// 1
// 2
// 3
// 4
// 5

Dictionary<string, int> ocene = new Dictionary<string, int>();
ocene["Ana"] = 95;
ocene["Boris"] = 88;
foreach (KeyValuePair<string, int> par in ocene)
{
    Console.WriteLine("{0}: {1}", par.Key, par.Value);
}
// Rezultat: ocene = { "Ana": 95, "Boris": 88 }
// Rezultat:
// Ana: 95
// Boris: 88

//////////////////////////////////////////////////////////////////////////////////////

// Metode za upravljanje s seznami in slovarji:
// Uporaba metod za dodajanje, odstranjevanje in iskanje elementov v seznamih in slovarjih.

List<int> stevilke = new List<int> { 1, 2, 3, 4, 5 };
stevilke.Add(6);
stevilke.Remove(3);
bool vsebujePet = stevilke.Contains(5);
// Rezultat: stevilke = { 1, 2, 4, 5, 6 }
// Rezultat: vsebujePet = true

Dictionary<string, int> ocene = new Dictionary<string, int>();
ocene["Ana"] = 95;
ocene["Boris"] = 88;
ocene.Remove("Ana");
bool vsebujeBorisa = ocene.ContainsKey("Boris");
// Rezultat: ocene = { "Boris": 88 }
// Rezultat: vsebujeBorisa = true

//////////////////////////////////////////////////////////////////////////////////////
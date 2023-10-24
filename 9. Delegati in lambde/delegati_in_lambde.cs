// Delegat:
// Delegate v C# je tip, ki omogoča shranjevanje reference na metodo s specifičnim podpisom. 
// Uporablja se za podajanje metod kot argumentov ali za obvladovanje dogodkov.

delegate int Operacija(int a, int b);
Operacija seštej = (a, b) => a + b;
int rezultat = seštej(5, 3); // Rezultat bo 8

//////////////////////////////////////////////////////////////////////////////////////

// Lambda izraz:
// Lambda izraz je anonimna funkcija, ki jo lahko shranimo v spremenljivko ali jo podamo kot argument.
// Lambda izraz je lahko bodisi izraz bodisi stavek bloka.

// Izraz:
(int a, int b) => a + b;

// Stavek bloka:
(int a, int b) => { return a + b; };

// Izpiši vsak element v seznamu:
List<int> list = new List<int> { 1, 2, 3, 4, 5 };
list.ForEach(item => Console.WriteLine(item));
// Rezultat: 1 2 3 4 5

// Izpiši vsak element v seznamu, ki je večji od 3:
List<int> list = new List<int> { 1, 2, 3, 4, 5 };
list.Where(item => item > 3).ToList().ForEach(item => Console.WriteLine(item));
// Rezultat: 4 5

//////////////////////////////////////////////////////////////////////////////////////

// LINQ:
// Language Integrated Query (LINQ) je tehnologija vgrajena v C#, 
// ki omogoča poizvedovanje nad podatkovnimi viri.

// Izpiši vsak element v seznamu, ki je večji od 3:
List<int> list = new List<int> { 1, 2, 3, 4, 5 };
var query = from item in list
            where item > 3
            select item;

foreach (var item in query)
{
    Console.WriteLine(item);
}
// Rezultat: 4 5

//////////////////////////////////////////////////////////////////////////////////////
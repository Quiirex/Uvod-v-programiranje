int celoStevilo = 42;

double decimalnoStevilo = 3.14;

bool logičnaVrednost = true;

char znak = 'A';

string besedilo = "To je primer.";

byte bajt = 255;

ushort kratekCelostevilen = 1000;

uint celostevilen = 1000;

ulong dolgCelostevilen = 1000;

sbyte bajtCelostevilen = 1000;

short kratekCelostevilen = 1000;

long dolgoCeloStevilo = 123456789012345;

float plavajočeOštevilo = 1.23f;

decimal decimalnoCelostevilo = 123.45m;

const int KONSTANTA = 42;

List<int> seznam = new List<int>() { 1, 2, 3 };

Dictionary<string, int> slovar = new Dictionary<string, int>() { { "Ključ", 1 } };

int[] tabela = new int[] { 1, 2, 3 };

int[,] matrika = new int[,] { { 1, 2 }, { 3, 4 } };

int[][] jaggedTabela = new int[][] { new int[] { 1, 2 }, new int[] { 3, 4 } };

int? nullableSpremenljivka = null;

var avtomatskoZaznanaSpremenljivka = 42;

dynamic dinamicnaSpremenljivka = 42;

(double, int) tuple = (4.5, 3);

enum Season
{
    Spring,
    Summer,
    Autumn,
    Winter
}

record Oseba(string Ime, string Priimek);
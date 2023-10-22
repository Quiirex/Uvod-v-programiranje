int celoStevilo = 42;

double decimalnoStevilo = 3.14;

boolean logičnaVrednost = true;

char znak = 'A';

String besedilo = "To je primer.";

byte bajt = 255;

short kratekCelostevilen = 1000;

long dolgoCeloStevilo = 123456789012345L;

float plavajočeOštevilo = 1.23f;

BigDecimal decimalnoCelostevilo = new BigDecimal("123.45");

final int KONSTANTA = 42;

List<Integer> seznam = new ArrayList<>(Arrays.asList(1, 2, 3));

LinkedList<Integer> povezaniSeznam = new LinkedList<>(Arrays.asList(1, 2, 3));

Map<String, Integer> slovar = new HashMap<>();

Set<Integer> mnozica = new HashSet<>(Arrays.asList(1, 2, 3));

Iterator<Integer> iterator = seznam.iterator();

int[] tabela = {1, 2, 3};

int[][] matrika = {{1, 2}, {3, 4}};

Integer nullableSpremenljivka = null; // Autoboxing

var avtomatskoZaznanaSpremenljivka = 42; // var od Java 10 dalje

enum Season {
    SPRING,
    SUMMER,
    AUTUMN,
    WINTER
}

// Ovojni (wrapper) razredi omogočajo uporabo primitivnih 
// podatkovnih tipov (int, boolean itd.) kot objektov.

Integer i = 42;

Double d = 3.14;

Short s = 1000;

Long l = 123456789012345L;

Float f = 1.23f;

Boolean b = true;

Byte by = 127;

Character c = 'A';

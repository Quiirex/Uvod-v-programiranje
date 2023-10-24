// Delegat:
// Delegat omogoča shranjevanje reference na metodo s specifičnim podpisom. 
// Uporablja se za podajanje metod kot argumentov ali za obvladovanje dogodkov.

interface Calculator {
    int calculate(int a, int b);
}

class AddCalculator implements Calculator {
    @Override
    public int calculate(int a, int b) {
        return a + b;
    }
}

public class Main {
    public static void main(String[] args) {
        Calculator calculator = new AddCalculator();
        int result = calculator.calculate(5, 3);
        System.out.println("Rezultat: " + result);
    }
}

//////////////////////////////////////////////////////////////////////////////////////

// Lambda izraz:
// Lambda izraz je anonimna funkcija, ki jo lahko shranimo v spremenljivko ali jo podamo kot argument.
// Lambda izraz je lahko bodisi izraz bodisi stavek bloka.

ArrayList<Integer> numbers = new ArrayList<Integer>();
numbers.add(5);
numbers.add(9);
numbers.add(8);
numbers.add(1);
numbers.forEach( (n) -> { System.out.println(n); } );
// Rezultat: 5 9 8 1

// Lambda izraz je lahko shranjen v spremenljivko.
Calculator calculator = (a, b) -> a + b;
int result = calculator.calculate(5, 3);
System.out.println("Rezultat: " + result);
// Rezultat: 8

//////////////////////////////////////////////////////////////////////////////////////
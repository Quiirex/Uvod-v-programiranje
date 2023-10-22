// Seznami:
// Uporaba seznama za shranjevanje večih elementov istega tipa podatkov.

List<Integer> stevilke = new ArrayList<Integer>();
stevilke.add(1);
stevilke.add(2);
stevilke.add(3);
stevilke.add(4);
stevilke.add(5);
stevilke.add(6);
int prvaStevilka = stevilke.get(0);
// Rezultat: stevilke = [1, 2, 3, 4, 5, 6]
// Rezultat: prvaStevilka = 1

//////////////////////////////////////////////////////////////////////////////////////

// Slovarji:
// Uporaba slovarja za shranjevanje parov ključa in vrednosti.

Map<String, Integer> ocene = new HashMap<String, Integer>();
ocene.put("Ana", 95);
ocene.put("Boris", 88);
int ocenaAne = ocene.get("Ana");
// Rezultat: ocene = {Ana=95, Boris=88}
// Rezultat: ocenaAne = 95

//////////////////////////////////////////////////////////////////////////////////////

// Zanke v seznamih in slovarjih:
// Uporaba zank za pregledovanje elementov v seznamih in slovarjih.

List<Integer> stevilke2 = new ArrayList<Integer>();
stevilke2.add(1);
stevilke2.add(2);
stevilke2.add(3);
stevilke2.add(4);
stevilke2.add(5);

for (int stevilka : stevilke2) {
    System.out.println(stevilka);
}
// Rezultat: stevilke2 = [1, 2, 3, 4, 5]
// Rezultat:
// 1
// 2
// 3
// 4
// 5

Map<String, Integer> ocene2 = new HashMap<String, Integer>();
ocene2.put("Ana", 95);
ocene2.put("Boris", 88);

for (Map.Entry<String, Integer> entry : ocene2.entrySet()) {
    System.out.println(entry.getKey() + ": " + entry.getValue());
}
// Rezultat: ocene2 = {Ana=95, Boris=88}
// Rezultat:
// Ana: 95
// Boris: 88

//////////////////////////////////////////////////////////////////////////////////////

// Metode za upravljanje s seznami in slovarji:
// Uporaba metod za dodajanje, odstranjevanje in iskanje elementov v seznamih in slovarjih.

List<Integer> stevilke3 = new ArrayList<Integer>();
stevilke3.add(1);
stevilke3.add(2);
stevilke3.add(3);
stevilke3.add(4);
stevilke3.add(5);
stevilke3.add(6);
stevilke3.remove(Integer.valueOf(3));
boolean vsebujePet = stevilke3.contains(5);
// Rezultat: stevilke3 = [1, 2, 4, 5, 6]
// Rezultat: vsebujePet = true

Map<String, Integer> ocene3 = new HashMap<String, Integer>();
ocene3.put("Ana", 95);
ocene3.put("Boris", 88);
ocene3.remove("Ana");
boolean vsebujeBorisa = ocene3.containsKey("Boris");
// Rezultat: ocene3 = {Boris=88}
// Rezultat: vsebujeBorisa = true

//////////////////////////////////////////////////////////////////////////////////////
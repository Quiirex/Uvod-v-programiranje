// Pogoji (if-else):
// Pogojni stavki se uporabljajo za izvajanje različnih delov
// kode glede na izpolnjevanje določenega pogoja.

int starost = 20;

if (starost >= 18) {
    System.out.println("Oseba je polnoletna.");
} else {
    System.out.println("Oseba je mladoletna.");
}

//////////////////////////////////////////////////////////////////////////////////////

// Večpogojni stavki (else if):
// Uporabljajo se za preverjanje več pogojev po vrsti in izvajanje ustreznega dela kode, 
// ki ustreza prvemu izpolnjenemu pogoju.

int ocena = 85;

if (ocena >= 90) {
    System.out.println("Odlično!");
} else if (ocena >= 70) {
    System.out.println("Dobro.");
} else {
    System.out.println("Potrebno izboljšanje.");
}

//////////////////////////////////////////////////////////////////////////////////////

// Logični operatorji (&&, ||, !):
// Uporaba logičnih operatorjev za združevanje pogojev.

int starost = 20;
boolean jeStudent = true;

if (starost >= 18 && jeStudent) { // && -> in
    System.out.println("Oseba je polnoletna in študent.");
}
else if (starost >= 18 || jeStudent) { // || -> ali
    System.out.println("Oseba je polnoletna ali študent.");
}
else if (!jeStudent) { // ! -> negacija
    System.out.println("Oseba ni študent.");
}

//////////////////////////////////////////////////////////////////////////////////////

// Ternarni operator (?:):
// Uporaba ternarnega operatorja za krajše pogoje preverjanja v izrazih.

int starost = 20;
String status = (starost >= 18) ? "Polnoletna" : "Mladoletna";
// ekvivalentno:
// if (starost >= 18) {
//     status = "Polnoletna";
// } else {
//     status = "Mladoletna";
// }
System.out.println("Oseba je " + status + ".");

//////////////////////////////////////////////////////////////////////////////////////

// Switch stavki:
// Uporaba switch stavkov za izvajanje različnih delov kode glede na vrednost spremenljivke.

int ocena = 3;
switch (ocena) {
    case 1:
        System.out.println("Nedovoljivo");
        break;
    case 2:
        System.out.println("Zadostno");
        break;
    case 3:
        System.out.println("Dobro");
        break;
    default:
        System.out.println("Ni ocene.");
        break;
}

//////////////////////////////////////////////////////////////////////////////////////


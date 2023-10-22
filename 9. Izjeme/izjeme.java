// Izjeme (Exceptions):
// Izjeme predstavljajo neobičajne dogodke, ki se lahko pojavijo med izvajanjem programa. 
// Težave, kot so deljenje z ničlo, dostop do neobstoječih datotek ali druge napake, lahko sprožijo izjeme. 
// Obvladovanje izjem je pomemben del razvoja programske opreme, saj omogoča elegantno obvladovanje napak in omogoča programu, 
// da se primerno odzove na te napake, ne da bi se sesul.

try {
    int deljenec = 0;
    int rezultat = 10 / deljenec; // To bo sprožilo ArithmeticException
} catch (ArithmeticException ex) {
    System.out.println("Napaka: Delitev z ničlo ni mogoča. " + ex.getMessage());
} catch (Exception ex) {
    System.out.println("Splošna napaka: " + ex.getMessage());
} finally {
    System.out.println("Ta blok se vedno izvede, ne glede na to, ali je prišlo do izjeme ali ne.");
}

// Dobre prakse za upravljanje izjem:
// Izjeme uporabljajte samo za izjemne dogodke, ne pa za nadzor toka programa.
// Izjeme si vrstijo po hierarhiji, zato morate najprej obravnavati izjeme, ki so bolj specifične.

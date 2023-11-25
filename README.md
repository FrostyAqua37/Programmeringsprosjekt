IS202 - Nøsted Prosjekt
***********************

Applikasjonen er satt opp i en MVC rammeverk. Dette står for model, view og controller. Dette er et en struktur som decouple brukergrensesnitt,
data og applikasjonslogikken. Det gjør slik at om det blir endringer i model, view eller i controller, vil de ikke påvirke hverandre. Dette gjør
koden generelt bedre, da den er lettere å forstå og har bedre struktur.

Applikasjonen kan kjøres både Docker og lokalt. Den er derimot koblet mot en lokal database. 

Modell representerer dataene, logikken og reglene i applikasjonen. I model er det fire mapper: Account, Checklist, ServiceOrdre og Users. 
View er ansvarlig for visningen av dataene til brukeren. I view er det 6 mapper: Account, Checklist, Home, ServiceOrder, Shared og Users. 
Controller håndterer generelt behandlingen av data. I controllerern er det fem klasser: Account, Checklist, Home, ServiceOrder og Users. 

Account håndterer inn/ut logging. Checklist håndterer oppsett og funksjoner relatert til sjekklisten. Home håndterer oppsettet til hjemmesiden. 
ServiceOrder håndterer oppsettet og funksjoner relatert til serviceordre. Users håndterer de ulike rollene i systemet.

Funksjonen legger til rette for håndtering av serviceordre for Nøsted. De ansatte, Mekanikerene og Administrative, har forskjellige roller, og
har dermed tilgang til forskjellige funksjoner i systemet. Det har mulighet å lage en serviceordre med all den nødvendige informasjonen. 
Denne serviceordren kan lagre, redigere og slette. Deretter kan man linke denne serviceorderen til en sjekkliste gjennom databasen. 
Sjekklisten har oppsettet Nøsted bruker idag for serviceordre angående vinsjer. Man kan i tillegg logge ut og inn av systemet. 

Se Wiki for informasjon om testing og bruksanvisning.

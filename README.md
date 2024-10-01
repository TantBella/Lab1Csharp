# Lab1 – Hitta tal i sträng med tecken


![Bild på resultatet](
https://github.com/TantBella/Lab1Csharp/blob/main/example.png)

Skapa en konsollapplikation som tar en textsträng (string) som argument till
Main eller uppmanar användaren mata in en sträng i konsollen.
Textsträngen ska sedan sökas igenom efter alla delsträngar som är tal som börjar
och slutar på samma siffra, utan att start/slutsiffran, eller något annat tecken än
siffror förekommer där emellan. ex. 3463 är ett korrekt sådant tal, men 34363 är det inte eftersom det finns
ytterligare en 3:a i talet, förutom start och slutsiffran. Strängar med bokstäver i
t.ex 95a9 är inte heller ett korrekt tal. Skriv ut och markera varje korrekt delsträng
För varje sådan delsträng som matchar kriteriet ovan ska programmet skriva ut
en rad med hela strängen, men där delsträngen är markerad i en annan färg.

#### Exempel output för input ”29535123p48723487597645723645”:
**2953512**3p48723487597645723645 

29**535**123p48723487597645723645 

295**35123**p48723487597645723645 

29535123p**487234**87597645723645 

29535123p4**872348**7597645723645 

29535123p48**723487**597645723645 

29535123p487**2348759764572**3645 

29535123p4872**3487597645723**645 

29535123p48723**48759764**5723645 

29535123p4872348**7597**645723645 

29535123p48723487**597645**723645 

29535123p4872348759**76457**23645 

29535123p48723487597**6457236**45 

29535123p487234875976**4572364**5 

29535123p4872348759764**5723645** 

Ni kan välja vilka färger ni skriver ut med så länge man ser skillnad på dem.
Ni byter färg genom att ändra värde på Console.ForegroundColor.
Addera ihop alla tal och skriv ut totalen
Programmet ska också addera ihop alla tal den hittat enligt ovan och skriva ut
det sist i programmet. Gör gärna en tom rad emellan för att skilja från output ovan.

Exempel output för input ”29535123p48723487597645723645”:
Total = 5836428677242

## Redovisning
Uppgiften ska lösas individuellt.
Lämna in uppgiften på ithsdistans med en kommentar med github-länken.

## Betygskriterier
### För godkänt:
⦁ Räcker att lösa en av uppgifterna, d.v.s. antingen skriva ut alla delsträngar som i exemplet ovan, eller räkna ut och skriva ut totalen.

⦁ Om man matar in strängen i exemplet ska man få samma output som ovan.

⦁ Det ska även fungera generellt, oavsett vilken sträng man matar in

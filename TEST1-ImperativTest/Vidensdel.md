# Vidensdel - 12 spørgsmål

Du skal besvare følgende spørgsmål skiftligt i et word dokument.

## 1. Hvad er forskellen på en variabel og en datatype?
En variabel er en allokeret plads i hukommelsen hvor vi kan gemme data, imens en datatype er den type variablen er. 

## 2. Hvad er den generelle syntaks for erklæring af en variabel?

```csharp
string name
// datatype NavnPaaVar
// Nedenfor er den GENERELLE syntaks
// <datatype><identifier>
```

## 3. Er det muligt for en variabel af datatypen `int`, at indeholde følgende værdi: 0
Ja

## 4. Er det muligt for en variabl af datatypen `bool`, at indeholde følgende værdi: 'perhaps'
Nej

## 5. Angiv samtlige mulige værdier en variabel af datatypen bool, kan antage
true, false

## 6. Er det muligt at konvertere en variabel af datatypen byte til datatypen int? Er det omvendte også muligt? Beskriv hvorfor det er muligt/ikke muligt.
byte(0 - 256) til int, ja. En int kan være større end 256, det der flyder ud over bliver byte. 

det vil ikke kunne konverteres til en byte. Vil smide en outOfRange

## 7. Hvilken metode skal kaldes på Console klassen, når man ønsker at indlæse indtastninger fra tastaturet?
ReadLine()

## 8. Hvilken metode skal kaldes på Console klassen, når man ønsker at udskrive tekst til konsol vinduet?
Writeline() eller Write()

## 9.	Hvilke(t) statement(s) kan anvendes, når man ønsker at bestemte andre statements eksekveres, mens igen andre ikke gør – på baggrund af en logisk betingelse?
Kontrolstrukturer som if-else, switch-case,

## 10.	Hvilke(t) statement(s) kan anvendes, når man ønsker at gentage et eller flere andre statements, indtil en logisk betingelse er opfyldt?
Løkke som do-while, while, foreach, for. 

## 11.	Angiv en syntaks til initialisering af en lineær datastruktur der kan indeholde præcis 100 heltal.
int[] arr = new int[100];


## 12.	Angiv en syntaks for en iteration over en lineær datastruktur, der til konsollen udskriver alle værdier i den lineære datastruktur.

foreach(var element in array) {
	Console.WriteLine(element);
}
# Vidensdel - 12 sp�rgsm�l

Du skal besvare f�lgende sp�rgsm�l skiftligt i et word dokument.

## 1. Hvad er forskellen p� en variabel og en datatype?
En variabel er en allokeret plads i hukommelsen hvor vi kan gemme data, imens en datatype er den type variablen er. 

## 2. Hvad er den generelle syntaks for erkl�ring af en variabel?

```csharp
string name
// datatype NavnPaaVar
// Nedenfor er den GENERELLE syntaks
// <datatype><identifier>
```

## 3. Er det muligt for en variabel af datatypen `int`, at indeholde f�lgende v�rdi: 0
Ja

## 4. Er det muligt for en variabl af datatypen `bool`, at indeholde f�lgende v�rdi: 'perhaps'
Nej

## 5. Angiv samtlige mulige v�rdier en variabel af datatypen bool, kan antage
true, false

## 6. Er det muligt at konvertere en variabel af datatypen byte til datatypen int? Er det omvendte ogs� muligt? Beskriv hvorfor det er muligt/ikke muligt.
byte(0 - 256) til int, ja. En int kan v�re st�rre end 256, det der flyder ud over bliver byte. 

det vil ikke kunne konverteres til en byte. Vil smide en outOfRange

## 7. Hvilken metode skal kaldes p� Console klassen, n�r man �nsker at indl�se indtastninger fra tastaturet?
ReadLine()

## 8. Hvilken metode skal kaldes p� Console klassen, n�r man �nsker at udskrive tekst til konsol vinduet?
Writeline() eller Write()

## 9.	Hvilke(t) statement(s) kan anvendes, n�r man �nsker at bestemte andre statements eksekveres, mens igen andre ikke g�r � p� baggrund af en logisk betingelse?
Kontrolstrukturer som if-else, switch-case,

## 10.	Hvilke(t) statement(s) kan anvendes, n�r man �nsker at gentage et eller flere andre statements, indtil en logisk betingelse er opfyldt?
L�kke som do-while, while, foreach, for. 

## 11.	Angiv en syntaks til initialisering af en line�r datastruktur der kan indeholde pr�cis 100 heltal.
int[] arr = new int[100];


## 12.	Angiv en syntaks for en iteration over en line�r datastruktur, der til konsollen udskriver alle v�rdier i den line�re datastruktur.

foreach(var element in array) {
	Console.WriteLine(element);
}
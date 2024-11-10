# Kapiteltest 2A - Variablen, Verzweigungen und Berechnungen 

## Aufgabe 1: Dreieckstyp

Schreibe ein Programm, bei dem der Benutzer die
drei Seitenlängen eines Dreiecks eingeben kann.
Wir gehen davon aus, dass c die längste Seite ist.

Programmiere folgende Verzweigungen:
* Falls das Dreieck gleichseitig ist, sollst du mit Print den Text "Gleichseitig" ausgeben
* Falls das Dreieck gleichschenkelig ist, sollst du mit Print den Text "Gleichschenkelig" ausgeben
* Falls das Dreieck rechtwinkelig ist, sollst du mit Print den Text "Rechtwinkelig" ausgeben

**Tipps:**
* Gleichseitig: a == b und b == c und c == a
* Gleichschenkelig a == b oder b == c oder c == a
* Rechtwinkelig a*a + b*b == c*c
* Jedes gleichseitige Dreieck ist auch gleichschenkelig

```
⌨️Input: Geben Sie die Länge der Seite a ein: 5  
⌨️Input: Geben Sie die Länge der Seite b ein: 5
⌨️Input: Geben Sie die Länge der Seite c ein: 5
🖨️Print: Gleichseitig
🖨️Print: Gleichschenkelig
```

```
⌨️Input: Geben Sie die Länge der Seite a ein: 5  
⌨️Input: Geben Sie die Länge der Seite b ein: 5
⌨️Input: Geben Sie die Länge der Seite c ein: 10
🖨️Print: Gleichschenkelig
```

```
⌨️Input: Geben Sie die Länge der Seite a ein: 3  
⌨️Input: Geben Sie die Länge der Seite b ein: 4
⌨️Input: Geben Sie die Länge der Seite c ein: 5
🖨️Print: Rechtwinkelig
```

## Aufgabe 2: Rechteck-Klassifikation

Schreibe ein Programm, bei dem der Benutzer die Länge und Breite eines Rechtecks eingeben kann.

Programmiere folgende Verzweigungen:

* Falls Länge und Breite gleich sind, sollst du mit Print den Text "Quadrat" ausgeben.
* Falls die Länge mehr als doppelt so groß wie die Breite ist, sollst du mit Print den Text 3 "Langgestrecktes Rechteck" ausgeben.
* Falls die Länge kleiner 10 ist und die Breite kleiner 10 ist, so gib den Text: "Ein kleines Rechteck :)" ausgegeben werden
* Falls die Länge oder die Breite negativ ist, so soll der Text "Fehler in der Eingabe, negative Längen gibt es nicht" ausgegeben werden.

## Aufgabe 3: Aggregatzustand von H<sub>2</sub>O

Schreibe ein Programm, bei dem der Benutzer eine Temperatur in Grad Celsius eingeben kann.

Programmiere folgende Verzweigungen:

* Falls die Temperatur unter 0 Grad liegt, sollst du mit Print den Text "Gefrierpunkt unterschritten" ausgeben.
* Falls die Temperatur genau 0 Grad beträgt, sollst du mit Print den Text "Gefrierpunkt erreicht" ausgeben.
* Falls die Temperatur zwischen 0 Grad und 100 Grad liegt, sollst du mit Print den Text "Wasser ist flüssig"
* Falls die Temperatur über 100 Grad liegt, sollst du mit Print den Text "Siedepunkt überschritten" ausgeben.

## Aufgabe 4: Alterskategorisierung

Schreibe ein Programm, bei dem der Benutzer sein Alter in Jahren eingeben kann.

Programmiere folgende Verzweigungen:

* Falls das Alter unter 13 Jahren liegt, sollst du mit Print den Text "Kind" ausgeben.
* Falls das Alter zwischen 13 und 17 Jahren liegt (einschließlich), sollst du mit Print den Text "Jugendlicher" ausgeben.
* Falls das Alter 18 Jahre oder älter ist, sollst du mit Print den Text "Erwachsener" ausgeben.
* Berechne das ungefähre Alter in Tagen, indem du die Jahre mit 365 multiplizierst und ausgibst.

## Aufgabe 5: Quadervolumen und Quaderoberfläche

Schreibe ein Programm bei dem der Benutzer die drei Seiten eines Quaders eingeben kann.

* Falls eine der Seiten negativ ist, soll das Programm den Text "Ungültige Daten" ausgeben
* **Sonst** soll das Programm
    * Das Volumen mit der Formel `l*b*h` berechen und ausgeben
    * Die Oberfläche mit der Formel `2*a*b+2*a*c+2*b*c` berechnen und ausgeben
* Falls das Berechnete Volumen größer als 100 ist, soll "Ein großer Quader" ausgegeben werden

## Aufgabe 6: Kreisberechnung
Schreibe ein Programm, bei dem der Benutzer den Radius eines Kreises eingeben kann.

* Falls der Radius negativ ist, soll das Programm den Text "Ungültiger Radius" ausgeben.
* **Sonst** soll das Programm
    * Die Fläche mit der Formel pi * r * r berechnen und ausgeben.
    * Den Umfang mit der Formel 2 * pi * r berechnen und ausgeben.
* Falls die berechnete Fläche größer als 50 ist, soll "Großer Kreis" ausgegeben werden.

**Tipp:** Definiere die Variable pi mit: `double pi = 3.141592;`

## Aufgabe 7: Geschwindigkeit und Verkehrswarnungen

Schreibe ein Programm, bei dem der Benutzer eine Geschwindigkeit in km/h eingeben kann.

Programmiere folgende Verzweigungen:

* Falls die Geschwindigkeit unter 0 km/h liegt, soll das Programm den Text "Ungültige Geschwindigkeit" ausgeben.
* Falls die Geschwindigkeit 0 km/h beträgt, soll das Programm den Text "Fahrzeug steht" ausgeben.
* Falls die Geschwindigkeit zwischen 1 und 50 km/h liegt, soll das Programm den Text "Langsam unterwegs" ausgeben.
* Falls die Geschwindigkeit zwischen 51 und 120 km/h liegt, soll das Programm den Text "Normale Geschwindigkeit" ausgeben.
* Falls die Geschwindigkeit über 120 km/h liegt, soll das Programm den Text "Zu schnell!" ausgeben.

## Aufgabe 8: Zinsen auf ein Bankguthaben
Schreibe ein Programm, bei dem der Benutzer den Anlagebetrag und den Zinssatz in Prozent eingeben kann.

* Falls der Anlagebetrag oder der Zinssatz negativ ist, soll das Programm den Text "Ungültige Eingabe" ausgeben.
* Sonst soll das Programm
    * Die jährlichen Zinsen mit der Formel betrag * (zins / 100) berechnen und ausgeben.
    * Den Endbetrag nach einem Jahr mit der Formel betrag + jahreszinsen berechnen und ausgeben.
* Falls die jährlichen Zinsen mehr als 500 Euro betragen, soll das Programm den Text "Hohe Zinseinnahmen" ausgeben.

# Logische Operatoren

Mit der `if`-Verzweigung haben wir geprüft, ob eine Bedingung zutrifft.
Doch was, wenn wir prüfen möchten, ob bei zwei Bedingungen, beide erfüllt sind.
Nehmen wir an, wir möchten ein Programm schreiben, welches prüft,
ob einem Bankkunden eine Kredit vergeben werden darf.

Für einen Kredit muss der Kunde:
* über 18 Jahre alt sein
* **und** über 50000€ auf seinem Sparkonto haben.

Für solche Bedingungen benötigen wir **logische Operatoren**.
Mit diesen lassen sich zwei oder mehrere
Bedingungen zu einer Bedingung kombinieren.
In diesem Kapitel lernen wir die Operatoren **Und**, **Oder** und **Nicht** in C# kennen.

Diese Operatoren werden dir bekannt vorkommen,
denn du kennst sie bereits aus **NWES**. 😉

In C# werden folgende Symbole für die Operatoren verwendet:

| Operator | Symbol | Tastatur |
| -------- | ------- | ------- |
| Und | && | <kbd>Shift</kbd> + <kbd>6</kbd>  |
| Oder | &#124;&#124; |  <kbd>AltGr</kbd>  + <kbd>&lt;</kbd>  | 
| Nicht | ! | <kbd>Shift</kbd> + <kbd>1</kbd>  |


## Und, Oder, Nicht

Das Ergebnis einer Bedingung ist ein Wahrheitswert, also entweder **wahr** oder **falsch**.
In C# werden diese beiden Begriffe mit `true`, bzw. mit `false` bezeichnet.
Intern handelt es sich aber nur um Platzhalter für die Werte `0` und `1`.
Überall, wo wir `true`, bzw. `false` schreiben, könnten wir genauso gut `1`
bzw. `0` schreiben, jedoch sind die ausgeschriebenen Platzhalter leichter lesbar.

Diese Wahrheitswerte können mit logischen Operatoren
kombiniert werden. In den folgenden Tabellen siehst du das 
Ergebnis der Operation.

### Logisches Und - &&

| A        | B | A && B |
| :------: | :------: | :------: |
| false    |   false   | false |
| false    |   true   | false |
| true     |  false   | false |
| true     |  true   | true |

### Logisches Oder - ||

| A        | B | A &#124;&#124; B |
| :------: | :------: | :------: |
| false    |   false   | false |
| false    |   true   | true |
| true     |  false   | true |
| true     |  true   | true |

### Logisches Nicht - !

| A        | ! A |
| :------: | :------: | 
| false    |   true   |
| true    |   false   | 


## 💡 Beispiel

Im folgenden Beispiel siehst du mehrere `if`-Verzweigungen.
Die Bedinungen der `if`-Verzweigungen bestehen aus mehreren
Bedingungen, die mit logischen Operatoren kombiniert werden.


```cs
#r "nuget: BulmeSharp, 0.10.1"
using BulmeSharp;

int zahl1 = Turtle.InputInt("Geben Sie eine Zahl ein");
int zahl2 = Turtle.InputInt("Geben Sie noch eine Zahl ein");

if ((zahl1 > 0) && (zahl2 > 0))
{
    Turtle.Print("Beide Zahlen sind größer als 0");
}

if ((zahl1 == 5) || (zahl2 == 5))
{
    Turtle.Print("Zumindest eine der beiden Zahlen ist 5");
}

if ((zahl1 >= 5) && (zahl1 < 10))
{
    Turtle.Print("Die erste Zahl ist größer oder gleich als 5 und kleiner als 10");
}

if ((zahl1 == 1) || (zahl1 == 3) || (zahl1 == 5))
{
    Turtle.Print("Die erste Zahl ist entweder 1, 3 oder 5");
}

if (!(zahl1 > 1))
{
    Turtle.Print("Die erste Zahl ist nicht größer als 1");
    Turtle.Print("sie ist also kleiner oder gleich 1");
}

if ((!(zahl1 == 5)) && (zahl2 < 3))
{
    Turtle.Print("Die erste zahl ist nicht 5 und die zweite ist kleiner als 3");
}

```

**💡 Anmerkung**:
In diesem Beispiel wurden die einzelnen Bedingungen in runde
Klammern geschrieben. Das macht den Code leichter lesbar
und sagt ausdrücklich, welche Bedingungen mit den logischen Operatoren
verknüpft werden.

**⚠️ Vorsicht**: Die Klammernsetzung **nicht** ist egal,
sondern verändert die Bedeutung einer Bedingung.
Die Bedingung `! ((A > 0) && (A < 5))` ist beispielsweise **nicht** dasselbe wie 
`(! (A > 0)) && (A < 5))`. 

* Die erste Bedingung `! ((A > 0) && (A < 5))` ist erfüllt
falls A nicht 1, 2, 3 oder 4 ist.
Die Bedingung ist also zum Beispiel für die Zahlen: 0, -1, -23, 5, 6 oder 334 erfüllt.

* Die zweite Bedingung `(! (A > 0)) && (A < 5)` sagt:
die Bedingung ist erfüllt, falls A entweder 0, -1, -2, -3, -4, -5 und so weiter ist.

**Deshalb** gilt bei Bedingungen, und beim Programmieren allgemein:
"Lieber ein paar Klammern zu viel, als eine zu wenig!".



## Übungen

### 📝 Übung 25

Schreibe ein Programm, bei dem der Benutzer die Länge und die Breite
eines Rechtecks eingeben soll.
Falls die Länge gleich ist, wie die Breite, so soll "Quadrat" ausgegeben werden.
Falls die Länge oder die Breite kleiner oder gleich `0` ist,
soll "Fehler: Falsche Eingabe" ausgegeben werden.
Falls die Länge und die Breite größer als `0` sind, soll
der Umfang und der Flächeninhalt berechnet und ausgegeben werden.

### 📝 Übung 26

Schreibe ein Programm, bei dem der Benutzer sein Geburtsjahr eingeben kann.
Falls das Geburtsjahr größer oder gleich `2020` ist,
soll "Du solltest noch keinen Computer benutzen 😉" ausgegeben werden.
Falls das Geburtsjahr kleiner als `2020` soll das ungefähre Alter in Tagen
berechnet und ausgegeben werden.

### 📝 Übung 27

Schreibe ein Programm, bei dem der Benutzer drei Zahlen eingeben kann.
Das Programm soll die größte der drei Zahlen ausgeben.

### 📝 Übung 28
Schreibe ein Programm, bei dem der Benutzer die drei Seiten eines Dreiecks eingeben kann.

Das Programm soll ausgeben, ob es sich um ein:

* gleichseitiges Dreieck
* gleichschenkeliges
* rechtwinkeliges
* oder allgemeines Dreieck handelt

### 📝 Übung 29
Schreibe ein Programm, bei dem der Benutzer eine Jahreszahl eingeben.
Das Programm gibt aus, ob es sich um ein Schaltjahr handelt oder nicht.

Die Regel ist die folgende:

* Die durch 4 ganzzahlig teilbaren Jahre sind, abgesehen von den folgenden Ausnahmen, Schaltjahre.
* Säkularjahre, also die Jahre, die ein Jahrhundert abschließen (z. B. 1800, 1900, 2100 und 2200), sind, abgesehen von der folgenden Ausnahme, keine Schaltjahre.
* Die durch 400 ganzzahlig teilbaren Säkularjahre, zum Beispiel das Jahr 2000, sind jedoch Schaltjahre.




## 🧭 Zusammenfassung

Die logischen Operatoren in C# werden verwendet, um mehrere Bedingungen zu verknüpfen
und zusammengesetzte logische Ausdrücke zu erstellen.

* Der Operator `&&` (und) prüft, ob beide Bedingungen wahr sind.
* Der Operator `||` (oder) überprüft, ob mindestens eine der Bedingungen wahr ist.
* Der Operator `!` (nicht) dreht den Wahrheitswert einer Bedingung um. Aus `true` wird `false`
und aus `false` wird `true`










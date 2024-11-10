# Rechnen mit Variablen 

Variablen sind benannte Speicherplätze für Werte.
Bis jetzt haben wir die Werte von Variablen
bei der Definition auf einen konkreten Wert gesetzt
oder vom Benutzer eingeben lassen.

Wir können Werte aber auch berechnen lassen.
Das lernst du in diesem Kapitel.

## Zuweisen von Werten

Der Wert einer Variable kann sich nach der Definition
beliebig oft ändern.

Im folgenden Beispiel wird eine Variable `laenge`
mit dem Wert `20` erstellt und später wieder abgeändert.

```cs
double laenge = 20;
Turtle.fd(laenge);
Turtle.rt(90);
laenge = 70;
Turtle.fd(laenge);
```

Du kannst bei der erneuten Zuweisung sogar den alten Wert verwenden,
also `laenge = laenge + 50;` schreiben.

```cs
double laenge = 20;
Turtle.fd(laenge);
Turtle.rt(90);
laenge = laenge + 50;
Turtle.fd(laenge);
```
Dabei musst du dir vorstellen, dass schrittweise Folgendes geschieht:

+ der alte Wert 20 von size wird in ein Rechenwerk übertragen
+ die Zahl 50 wird dazugezählt
+ der neue Wert 70 wird wieder in die Variable `laenge` gespeichert

**⚠️ Vorsicht:** Du darfst die dabei verwendete Schreibweise nicht mit einer mathematischen Gleichung verwechseln. Die Programmanweisung:
`n = n + 1;`
hat nichts mit einer mathematischen Gleichung zu tun, also mit der Aufgabe,
n so zu bestimmen, dass sich links und rechts von Gleichheitszeichen derselbe Wert ergibt.
Für `n = n + 1;` gibt es noch die Kurzschreibweise `n += 1;` , die genau dasselbe macht.

## Berechnungen

Rechnen in C# funktioniert gleich wie bei vielen Taschenrechnern.

Es ist wichtig, dass du dir bewusst bist, dass C# nicht algebraisch
rechnen kann und auch die mathematische Notation ein wenig anders
interpretiert. In der Mathematik kannst du die Multiplikationszeichen
oft weglassen, beim Programmieren dürfen sie aber auf keinen Fall fehlen. 

+ In der Mathematik ist folgendes gültig: *3ab(2a + 1)*.
Der Ausdruck bedeutet: *3 × a × b × (2 × a + 1)*.
+ In C# müssen wir das Multiplikationszeichen immer schreiben: 
`3 * a * b * (2 * a + 1)`

Möchten wir also das Ergebnis des mathematischen Ausdrucks:
*3ab(2a + 1)* berechnen, so können wir folgendes schreiben:

```cs
int a = 5;
int b = 7;
int x = 3 * a * b * (2 * a + 1);
Turtle.Print(x);
```

In den ersten zwei Zeilen haben wir die beiden Variablen `a` und `b`
angelegt und ihnen einen Wert zugewiesen.
in der dritten Zeile definieren wir eine neue Variable x
und weisen der Variable das Ergebnis der Berechnung `3 * a * b * (2 * a + 1)` zu.

In der letzten Zeile folgt eine neue Funktion: `Turtle.Print(ausdruck)`.
Die Funktion `Turtle.Print` gibt den Wert eines Ausdrucks im Ausgabefenster aus.
Als Ausdrücke bezeichnen wir alles, was einen Wert hat,
also beispielsweise Variablen, Zahlen, Berechnungen
oder auch ein Funktionsaufruf.

Folgende `Print` Funktionsaufrufe sind beispielsweise gültig:
```cs
int a = 23;
Turtle.Print(a);
Turtle.Print(123);
Turtle.Print(a * a);
Turtle.Print(a * 23 - 3 / (a - 6));
Turtle.Print(Turtle.InputInt("Geben Sie eine Zahl ein"));
```

## Operatoren

Die Programmiersprache C# kennt Operatoren,
die in der folgenden Tabelle aufgelistet sind.
Die beiden Zahlen mit denen die Rechenoperation durchgeführt wird,
nennen wir auch die **Operanden**.

| Operator |  Beschreibung | Beispiel |
|-------|-------|-------|
| `+` | Addition | `x + y` |
| `-` | Subtraktion | `x - y` |
| `*` | Multiplikation | `x * y` |
| `/` | Division | `x / y` |
| `%` | Modulo, **Rest** der Integer Division, 7 % 3 ergibt 1 | `x % y` |

## ⚠️ Spezialfall: Division

Alle Rechenoperatoren funktionieren so wie du es vom Taschenrechner her kennst.
Bei der Division gibt jedoch es zwei Fälle die wir unterscheiden müssen.
Denn das Ergebnis der Division hängt von den Datentypen der beiden
Zahlen ab, mit denen die Division ausgeführt wird.

### Division von zwei `int`-Werten:
```cs
int x = 5;
int y = 2;
Turtle.Print(x / y);
```
Ergebnis ist ein `int` Wert also **2**

### Division, wenn **zumindest einer der beiden** Werte vom Datentyp `double` (oder `float`) ist:
```cs
int x = 5;
double y = 2.0;
Turtle.Print(x / y);
```
Ergebnis ist ein `double` Wert also **2.5**

Wäre `y` vom Typ `float` gewesen wäre das Ergebnis auch vom Typ `float`.

## Kombinierte Rechen- und Zuweisungsoperatoren

Sehr häufig kommt es vor, dass man zu einer gegebenen Variable
einen Wert hinzuaddieren möchte.
Im folgenden Beispiel wird beispielsweise die Zahl 4 zur Variable x
hinzuaddiert.

```cs
x = x + 4;
```

Da das hinzuaddieren sehr häufig vorkommt und Programmierer schreibfaul sind,
wurden eigene Operatoren eingeführt um weniger schreiben zu müssen.

Das obige Beispiel kann auch so geschrieben werden:

| Langvariante | Kurzvariante | Beispiel | Ergebnis |
| ----- | ----- | ----- | ----- |
| `x = x + y;` | `x += y;` | `x = 8; x += 3;` | `11` |
| `x = x - y;` | `x -= y;` | `x = 8; x -= 3;` | `5` |
| `x = x * y;` | `x *= y;` | `x = 8; x *= 3;` | `24` |
| `x = x / y;` | `x /= y;` | `x = 8; x /= 2;` | `4` |
| `x = x % y;` | `x %= y;` | `x = 8; x %= 3;` | `2` |

## Inkrement und Dekrement Operatoren

Für Programmierer ist sogar die Anweisung `x += 1` zu viel zu schreiben.
Deshalb wurden noch zwei Operatoren eingeführt, welche eine 
Variable um eins erhöhen, bzw. um eins verringern.
Um eins erhöhen, nennt man auch **inkrementieren**,
um eins verringern nennt man auch **dekrementieren**.

| Langvariante | Kurzvariante 1 | Kurzvariante 2 | Beispiel | Ergebnis |
| ----- | ----- | ----- | ----- | ----- |
| `x = x + 1;` | `x += 1;` | `x++;` | `x = 8; x++;` | `9` |
| `x = x - 1;` | `x -= 1;` | `x--;` | `x = 8; x--;` | `7` |

## Übungen

### 📝 Übung 14
Schreibe ein Programm, bei dem der Benutzer das Geburtsjahr als Integer eingeben kann.
Das Programm soll das ungefähre Alter der Person in Tagen berechnen.
Verwende dafür die Formel: (aktuelles Jahr - Geburtsjahr) \* 365,
also beispielsweise `(2024 - 2009) * 365`

Gib das Ergebnis mit `Turtle.Print` aus.


### 📝 Übung 15
In den USA werden Temperaturen in Grad Fahrenheit angegeben.
Die Umrechnung solcher Temperaturangaben von Grad Fahrenheit (T<sub>F</sub>)
in Grad Celsius (T<sub>C</sub>) erfolgt nach der folgenden einfachen Formel:
T<sub>C</sub> = (T<sub>F</sub> − 32) * 5/9

Programmiere diese Formel in C# und verwende zwei Variablen
`temp_F` und `temp_C`. Bestimme damit, wie vielen  die
Temperatur 86F entspricht.

### 📝 Übung 16
Schreibe ein Programm, das Längenangaben von Zoll (z. B. 27" für
die Diagonale eines Displays) in cm umrechnet.

**Tipp:** 1" = 2.54cm

### 📝 Übung 17
Schreibe ein Programm, welches die Fläche eines rechtwinkeligen
Dreiecks berechnet. Der Benutzer soll die Längen a und b eingeben können
und das Programm berechnet die Fläche berechnen.

### 📝 Übung 18
Schreibe ein Programm, bei dem der Benutzer den Flächeninhalt 
eines Quadrats eingeben kann. Das Programm soll die Seitenlänge des Quadrats
berechnen und das Quadrat zeichnen.

### 📝 Übung 19
Überlege dir was das Programm ausgibt.
Teste deine Überlegung, indem du das Programm
in WebTigerJython kopierst und ausführst.

```cs
int a = 4;
int b = 3 * a;
int c = 2 * b;
Turtle.Print(a);
Turtle.Print(b);
Turtle.Print(c);

a = 5;
c = c + 1;
Turtle.Print(a);
Turtle.Print(b);
Turtle.Print(c);
```

### 📝 Übung 20
Überlege dir was das Programm ausgibt.
Teste deine Überlegung, indem du das Programm
in WebTigerJython kopierst und ausführst.

```cs
int a = 7;
int b = 9;
b = a;
a = b;
Turtle.Print(a);
Turtle.Print(b);
```

## 🧭 Zusammenfassung

Eine Variable entsteht dann, wenn du ihr mit dem Gleichheitszeichen einen Wert zuweist.
Du kannst ihren Wert jederzeit durch eine neue Zuweisung ändern und dabei sogar ihren eigenen (alten) Wert gebrauchen.

Eine Zuweisung wird in der Form `Variable = Ausdruck;` geschrieben,
wobei der Ausdruck eine Variable,
eine Zahl, eine Berechnung oder ein Funktionsaufruf sein kann.





























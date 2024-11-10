# Variablen 

Bis jetzt haben wir schon einige Programme geschrieben, welche Grafiken gezeichnet haben.
Jedoch sehen diese Grafiken immer gleich aus. 
Spannender wäre es, wenn der Benutzer unseres Programms bei jedem Start
des Programms eingeben könnte, wie genau die Grafik genau aussehen sollte.
Beispielsweise könnte ein Benutzer eingeben,
dass er gerne drei Schneeflocken mit je acht Ästen haben möchte.

In diesem Kapitel lernst du **Variablen** kennen.
Mit Variablen kannst du dein Programm beispielsweise von
Benutzereingaben abhängig machen.
Dadurch werden die Programme **interaktiv** und viel **flexibler**.

## Was sind Variablen?
Variablen sind benannte Speicherplätze für Werte.
Immer wenn man sich im Programm etwas "merken" möchte,
um es später wieder zu verwenden, benötigt man Variablen.

Nehmen wir an, wir möchten ein Quadrat zeichnen und schreiben dazu folgenden Code:

```cs
#r "nuget: BulmeSharp, 0.10.1"
using BulmeSharp;

Turtle.fd(50);
Turtle.rt(90);
Turtle.fd(50);
Turtle.rt(90);
Turtle.fd(50);
Turtle.rt(90);
Turtle.fd(50);
Turtle.rt(90);

Turtle.showTurtle();
```

Dieses Quadrat ist aber immer gleich groß, denn es hat die Seitenlänge `50`.
Möchten wir das Quadrat vergrößern, also beispielsweise von `50` auf `75`,
so müssten wir vier mal die Zahl `50` abändern.

Besser wäre es, wenn wir die Zahl `50` einmal in einen Speicherplatz ablegen,
und jedes mal den Wert des Speicherplatzes benutzen.
So müssen wir die Zahl `50` nur einmal schreiben.

## Definition von Variablen

Bevor wir eine Variable benutzen müssen wir sie anlegen.
Wir geben ihr dabei einen Namen, einen Datentyp und einen Startwert.
Den Vorgang des Anlegens einer Variable nennt man **Definition** der Variable.
Die Namen für Variablen sollten kurz und verständlich sein.

Der Datentyp bestimmt welche Werte eine Variable annehmen kann.
Beispielsweise existieren Datentypen für Texte, Ganzzahlen oder Gleitkommazahlen.
Eine Auflistung der in C# üblichen Datentypen findest du am Ende des Kapitels.
Wir werden an dieser Stelle nur auf zwei Datentypen verweisen:
* `int` - Datentyp für **Ganzzahlen**. Der Wert könnte beispielsweise 10 oder -23 oder auch 0 sein
* `double`- Datentyp für **Gleitkommazahlen**. Der Wert könnte 1.23 oder 17.0 oder auch 3.141592 sein

Für die Seite eines Quadrats könnte man als Variablenname beispielsweise `a` verwenden.
Als Datentyp für die Seitenlänge verwenden wir `double`, damit kann die Seite auch
einen Gleitkommwert wie `20.5` haben.

Um eine Variable mit dem Namen `a`, dem Typ `double` und dem Startwert `50` zu definieren,
schreibt man:

```cs
double a = 50;
```

Die Variable mit dem Namen `a` kann nun überall dort verwendet werden,
wo normalerweise der Wert `50` steht.

Wir könnten also ein neues Programm schreiben,
bei dem die Seitenlänge deutlich einfacher geändert werden kann,
da die Zahl `50` nur an einer Stelle vorkommt.


```cs
#r "nuget: BulmeSharp, 0.10.1"
using BulmeSharp;

double a = 50;

Turtle.fd(a);
Turtle.rt(90);
Turtle.fd(a);
Turtle.rt(90);
Turtle.fd(a);
Turtle.rt(90);
Turtle.fd(a);
Turtle.rt(90);

Turtle.showTurtle();
```

**⚠️ Vorsicht:** Der Name der Variable muss auf der linken Seite des `=` Zeichens stehen
und auf der rechten Seite der Wert, welcher der Variable zugewiesen werden soll.
Die Zeile `double 50 = a;` führt zu einem Fehler.


## Eigenschaften von Variablen

Variablen haben in C# drei Eigenschaften

+ Name
+ Datentyp
+ Wert

**Name**: Mit dem Namen wird die Variable angesprochen.
Der Name sollte kurz und vielsagend sein.
Variablennamen müssen mit einem Buchstaben beginnen und 
dürfen nur Buchstaben, Ziffern und das Zeichen Underscore "_" enthalten.
Leerzeichen sind nicht erlaubt und deutsche Sonderzeichen,
wie "ß" oder "ö", sollten vermieden werden.

+ **Gültige** Variablennamen sind bspw.: `seite_a`, `hoehe` oder `radius2`
+ **Ungültige** Variablennamen sind bspw.: `2radius`, `höhe` oder `seite a`


**Datentyp**: Eine Variable kann verschiedene Arten von Werten beinhalten.
Wir unterscheiden hier drei grundlegende Typen:

+ Ganzzahlige Datentypen: Zahlen des Zählens, wie beispielsweise: 1, 2, 3 aber auch 0 und -1, -2 etc.
+ Zahlen in Gleitkommadarstellung: 1.001, 3.2, 8.9293 oder -1130.23
+ String: Texte wie beispielsweise "Hallo" oder "Guten Morgen"

**Wert**: Jede Variable hat einen Wert. Der Wert der Variable kann
im Programm laufend geändert werden. 

## Weitere Datentypen

Datentypen bestimmen, welche Art von Daten eine Variable enthalten kann.
Die am häufigsten verwendeten C# Datentypen sind in der folgenden Tabelle aufgeführt:

| Datentyp  | Beschreibung |  Speicherverbrauch | 
| ------------- | ------------- | ------------- |
| `int`  | eine Ganzzahl, ungefähr im Bereich ± 2 Milliarden, wie bspw. `129`  | 4 Byte |
| `long`  | eine lange Ganzzahl, wie bspw. `487693613292387`  | 8 Byte |
| `char`  | Ein einzelner Buchstabe, wie bspw. der Buchstabe `'A'`  | 2 Byte (in anderen Sprachen häufig nur 1 Byte)|
| `float`  | Eine Gleitkommazahl mit einer Präzision von maximal **7** Stellen, wie bspw. `12.832`  | 8 Byte |
| `double`  | Eine Gleitkommazahl mit einer Präzision von maximal **15** Stellen, wie bspw. `3.14159265358`  | 16 Byte |
| `bool`  | Ein Wahrheitswert, also entweder `true` oder `false`  | 1 Byte (theoretisch nur 1 Bit, aber aufgrund Rechnerarchitektur nicht möglich) |
| `string`  | Ein Zeichenkette (also ein Text), wie bspw. `"Hallo Welt :)"`  | ~2 Byte pro Zeichen |

## Übungen

### 📝 Übung 9
Prüfe welche der folgenden Variablendefinitionen gültig sind,
indem du sie Zeile für Zeile in den Codeeingabe-Bereich kopierst und Start klickst

```c#
double meine_Variable = 123.4;
int beste Variable Ever = 123;
int x_y_z = 2000;
int t = -7;
double 15.4 = y;
int x-y-z = 2000;
int using = 4;
```

### 📝 Übung 10

Schreibe ein Programm, bei dem am Anfang zwei Variablen definiert werden.
Die Variable `seite_a` soll den Wert 60 bekommen, und die Variable `seite_b`
soll den Wert 80 bekommen.

Nach der Variablendefinition soll ein Rechteck mit den Seitenlängen
`seite_a` und `seite_b` gezeichnet werden.

**Wichtig:** Beachte, dass du die Zahlen `60` und `80` nur einmal im Programm benötigst. 



## 🧭 Zusammenfassung

+ Variablen sind benannte Speicherplätze für Werte
+ Variablen müssen vor der Verwendung angelegt (definiert) werden
+ Dabei steht der Name der Variablen immer links vom Gleichheitszeichen (=) und der Wert rechts davon. Beispiel `double seite_a = 23;`
+ Variablen haben drei Eigenschaften: Name, Datentyp und Wert
+ Datentyp sind bspw. `int` (Ganzzahl), `double` (Gleitkommazahl) oder `string` (Text)





























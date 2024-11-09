# Verzweigungen

In diesem Kapitel sehen wir uns an wie
Programmblöcke nur unter gewissen **Bedingungen** ausgeführt werden.

## Die if-Verzweigung
Stell dir beispielsweise vor, du möchtest die aktuelle Temperatur prüfen,
und eine Warnung ausgeben, falls die Temperatur unter 0° ist.
Nehmen wir an, wir haben die aktuelle Temperatur in einer Variable gespeichert.
Wir können sie dann mit einer `if`-Verzweigung überprüfen:

```c#
if (temperatur < 0)
{
    Turtle.Print("Vorsicht Glatteis!");
}
```

Mit `if` hast du also beim Programmieren die Möglichkeit, auf spezielle
Situationen gezielt zu reagieren. Dazu braucht `if` immer eine Bedingung,
um entscheiden zu können, ob diese Situation wirklich eintrifft.
Eine **Bedingung** ist ein Ausdruck, der entweder **wahr** oder **falsch** ist.

**⚠️ Vorsicht:** Achte darauf, dass die Bedingung in **runden Klammern** steht. Die Anweisungen, die ausgeführt werden, wenn die Bedingung zutrifft, schreibst du in **geschweifte Klammern**.


Üblicherweise entstehen Bedingungen durch die Anwendung von Vergleichsoperatoren.
Diese sind uns bereits aus der Mathematik bekannt,
müssen aber beim Programmieren anders geschrieben werden,
da Spezialzeichen wie "≤" nicht auf der Tastatur vorhanden sind.


| Operator | Beschreibung |
|-------|-------|
| < | kleiner |
| <= | kleiner oder gleich |
| == | gleich |
| >= | größer oder gleich |
| > | größer |
| != | ungleich |

**⚠️ Vorsicht:** Bei "ist gleich" benötigst du unbedingt zwei Gleichheitszeichen!
Ein Gleichheitszeichen ist der Zuweisungsoperator und damit eine
komplett andere Operation.

## 💡 Beispiel

Im folgenden Beispiel gibt der Benutzer die Seitenlaenge eines Quadrats ein,
und das Programm berechnet den Umfang und den Flächeninhalt.
Das ist jedoch nur möglich, wenn die Seitenlänge positiv ist,
da eine negative Seitenlänge keinen Sinn macht.

```c#
double seitenlaenge = Turtle.InputDouble("Bitte Seitenlänge eingeben!");
if (seitenlaenge > 0) 
{
    double umfang = seitenlaenge * 4;
    double flaeche = seitenlaenge * seitenlaenge;

    Turtle.Print("Der Umfang ist " + umfang);
    Turtle.Print("Die Fläche ist " + flaeche);
}
```

Das Programm gibt die Seitenlänge aus, falls die Fläche größer oder gleich 0 ist.
Das Programm gibt aber nichts aus, falls die Zahl negativ ist.
Besser wäre es, wenn das Programm eine Fehlermeldung ausgeben würde,
falls die Eingabe negativ war. Das können wir mit der `if`-`else` Verzweigung erreichen.

## Die if-else Verzweigung

Du kannst die if-Verzweigung um das Schlüsselwort `else` und einen weiteren
Programmblock erweitern. Dieser Programmblock wird dann ausgeführt,
wenn die Bedingung nicht wahr ist.


```c#
double seitenlaenge = Turtle.InputDouble("Bitte Seitenlänge eingeben!");
if (seitenlaenge > 0) 
{
    double umfang = seitenlaenge * 4;
    double flaeche = seitenlaenge * seitenlaenge;

    Turtle.Print("Der Umfang ist " + umfang);
    Turtle.Print("Die Fläche ist " + flaeche);
}
else
{
    Turtle.Print("Falsche Eingabe: Die Seitenlänge darf nicht negativ sein");
}
```
## 📜 Syntax

Die Syntax der `if`-Verzweigung ist im folgenden Codestück angegeben:


```cs
if (Bedingung)
{
    Anweisungen, die
    ausgeführt werden
    falls Bedingung erfüllt ist
}
```

**⚠️ Vorsicht:** Beachte, dass nach den runden Klammern kein Semikolon kommt. 

### Beispiel

```cs
if (temperatur > 30)
{
    Turtle.Print("Es ist unglaublich heiss heute :)");
    Turtle.Print("Zeit für eine Eiscreme!");
}
```

Der `else`-Teil der `if`-Verzweigung muss nicht zwingend
mit angegeben werden. Man sagt auch dieser ist *optional*,
es besteht also die Option diesen dazuzunehmen,
man muss aber nicht.

Die Syntax  der `if`-Verzweigung mit `else`-Teil ist:
```cs
if (Bedingung)
{
    Anweisungen, die
    ausgeführt werden
    falls Bedingung erfüllt ist
}
else
    Anweisungen, die
    ausgeführt werden
    falls Bedingung NICHT erfüllt ist
}
```

### Beispiel

```cs
if (temperatur > 25)
{
    Turtle.Print("Es ist warm genug fürs Freibad");
}
else
{
    Turtle.Print("Die Temperatur ist zu niedrig um ins Freibad zu gehen");
}
```

## Übungen

### 📝 Übung 21

Schreibe ein Programm bei dem der Benutzer seine Punkteanzahl vom 
SWP-Test eingeben kann. Falls die Punkteanzahl größer oder gleich 16 ist,
soll "Positive Note" werden.
Ansonsten soll "Negative Note" ausgegeben werden.

### 📝 Übung 22

Schreibe ein Programm bei dem der Benutzer eine Ganzzahl eingeben kann.
Das Programm soll ausgeben, ob die Zahl positiv, negativ oder Null ist.

**Tipp:** Du wirst mehr als eine if-Verzweigung brauchen.

### 📝 Übung 23
Schreibe ein Programm bei dem der Benutzer zwei Ganzzahlen eingeben kann.
Das Programm soll ausgeben, ob die erste Zahl größer als die zweite Zahl ist.

### 📝 Übung 24
Schreibe ein Programm bei dem der Benutzer eine Ganzzahl eingeben kann.
Das Programm soll ausgeben, ob die zahl eine gerade Zahl ist, oder nicht.

<!-- 
Schreibe ein Programm bei dem der Benutzer einen String eingeben kann.
Prüfe ob der eingegebene Wert gleich "Sesam öffne dich" ist.
Falls ja, soll "Du hast das Passwort erraten" ausgegeben werden.
Falls nein, soll "Das war falsch" ausgegeben werden.

**Tipp:** Beachte, dass du Strings immer in doppelten Hochkomma schreiben musst!
-->



## 🧭 Zusammenfassung
Mit der `if`-Verzweigung kannst du Codeblöcke nur dann ausführen lassen,
wenn eine Bestimmte Bedingung erfüllt ist.
Eine Bedingung ist ein Ausdruck, der entweder wahr oder falsch ist.
Eine `if`-Verzweigung kann zusätzlich einen `else`-Teil enthalten.
Dieser `else`-Teil wird ausgeführt, falls die Bedingung nicht erfüllt ist.

Der `else`-Teil ist **optional**, das heißt, er kann angeführt werden, muss aber nicht.

Die Syntax einer `if`-Verzweigung ist:
```cs
if (Bedingung)
{
    Anweisungen, die
    ausgeführt werden
    falls Bedingung erfüllt ist
}
else
{
    Anweisungen, die
    ausgeführt werden
    falls Bedingung NICHT erfüllt
}
```
 






























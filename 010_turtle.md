# Grafik mit der Turtle 🐢

Die Turtle ist eine kleine Schildkröte, die eine Spur zeichnet, wenn sie
sich bewegt. Du kannst ihr sagen, sie soll vorwärts gehen oder sich nach
links oder rechts drehen. Indem du diese Anweisungen geschickt
kombinierst, entstehen Zeichnungen und Bilder.

## Minimalprogramm

Bevor du mit der Turtle arbeiten kannst, musst du zuerst eine Bibliothek einbinden.
Eine Bibliothe ist eine Sammlung von vorgefertigten Codebausteinen,
welche normalerweise nicht im Standardumfang einer Programmiersprache enthalten sind,
die du wiederverwenden kannst, um bestimmte Aufgaben schneller und einfacher zu lösen.
Um die Turtle zu verwenden, benötigen wir die Bibliothek *BulmeSharp*.

Das machst du in RoslynPad indem du in der Eingabezeile der "NuGet Bibliotheken"
den Text *BulmeSharp* eingibst und die entsprechende Bibliothek anklickst.
Daraufhin wird folgende Zeile automatisch im Code eingefügt.

```cs
#r "nuget: BulmeSharp, 0.9.0"
```

Um die Bibliothek tatsächlich zu benutzen müssen wir unterhalb noch eine Zeile hinzufügen.

```cs
#r "nuget: BulmeSharp, 0.9.0"
using BulmeSharp;
```


## Bewegen der Turtle

Die Turtle selbst wird in der Programmierung als ein **Objekt** bezeichnet.
Die Fähigkeiten der Turtle, bezeichnen wir in der Programmierung als **Funktionen**.
Um der Turtle zu sagen, dass sie etwas tun soll, müssen wir diese Funktionen **aufrufen**.
 
Funktionsaufrufe der Turtle sind Abkürzungen für englische Begriffe und enden immer mit 
einer öffnenden und einer schließenden **runden** Klammer.
Zwischen den Klammern können weitere Angaben zum Funktionsaufruf stehen.
Diese Angaben nennt man auch **Argumente**.
Selbst wenn keine Argumente nötig sind, muss ein leeres Klammerpaar vorhanden sein.
Damit klar ist, dass eine Funktion des Objekts Turtle gemeint ist,
schreibt man zuerst den Namen des Objekts, gefolgt von einem Punkt
und anschließend den Funktionsaufruf.

In der folgenden Grafik siehst du die wichtigsten Funktionen:

![Bewegen und drehen der Turtle](./images/turtle.png)

| Funktion  | Beschreibung | Beispiel |
| ------------- | ------------- | ------------- |
| fd  | Abkürzung für **f**orwar**d**, Anzahl Pixel nach vorne gehen  | `Turtle.fd(50);`  |
| bk  | Abkürzung für **b**ac**k**, Anzahl Pixel nach hinten gehen  | `Turtle.bk(18);`  |
| rt  | Abkürzung für **r**igh**t**, Angegebenen Winkel (in Grad) nach **rechts** drehen  | `Turtle.rt(39.5);`  |
| lt  | Abkürzung für **l**ef**t**, Angegebenen Winkel (in Grad) nach **links** drehen  | `Turtle.lt(45);`  |

**Zusatz:** Die Einheit für Distanzen ist hier Pixel.
Ein Pixel entspricht einem einzelnen Bildpunkt auf deinem Bildschirm.

**Tipp:** Du kannst auch Zahlen mit Nachkommastellen verwenden.
Jedoch ist das Dezimaltrennzeichen in C# der Punkt "." und nicht das Komma ",".
Das ist deshalb der Fall, da viele der wichtigen Entwicklungen der Informatik 
aus Nordamerika stammen, und dort der Punkt das gängige Dezimaltrennzeichen ist.

Weitere Funktionen, welche die Turtle ausführen kann sind:

| Funktion  | Beschreibung | Beispiel |
| ------------- | ------------- | ------------- |
| pu  | Abkürzung für **p**en **u**p, Turtle zeichnet nicht mehr  | `Turtle.pu();`  |
| pd  | Abkürzung für **p**en **d**own, Turtle zeichnet wieder  | `Turtle.pd();`  |
| dot  | Turtle zeichnet einen gefüllten Punkt (*engl.* dot) mit angegebenen Durchmesser  | `Turtle.dot(10);`  |
| ht  | Abkürzung für **h**ide **t**urtle, Turtle wird unsichtbar  | `Turtle.ht();`  |
| st  | Abkürzung für **s**how **t**urtle, Turtle wird sichtbar  | `Turtle.st();`  |


## Ein größeres Programm

In der folgenden Abbildung siehst du bereits ein größeres Programm
und daneben die Ausgabe des Programms.

![Code und Ausgabe](./images/codeausgabe.png)

Lass uns das Programm Zeile für Zeile analysieren.
Programme werden immer von oben nach unten abgearbeitet.

In Zeile 1 und 2 siehst du die bereits bekannten Anweisungen des Minimalprogramms.
In Zeile 1 wird eine spezielle Datei namens `gturtle` eingebunden.
Diese Datei enthält die Funktionen um mit der Turtle zu arbeiten.
Dateien, die wir zusätzlich einbinden können, und die den Funktionsumfang erweitern,
nennen wir **Module** oder auch **Bibliotheken**.
In Zeile 2 wird mit `makeTurtle()` die Turtle erstellt und angezeigt. 

In Zeile 3 machen wir der Turtle Beine und sagen sie soll sich mit der
Geschwindigkeit 10 fortbewegen, wodurch das Bild viel schneller gezeichnet wird.
Es macht aber auch die Fehlersuche schwieriger, da wir mit dem Schauen
ab einer gewissen Geschwindigkeit nicht mehr mitkommen.

Zeile 4 ist eine Leerzeile. Wir dürfen beliebig viele Leerzeilen
an beliebigen Stellen einfügen. Das wird häufig gemacht um das
Programm in Form zu bringen und leichter lesbar zu machen.

In Zeile 5 bis inkl. 7 fährt die Turtle 100 Pixel nach vorne,
dreht sich 90° nach links und macht dann einen 10 Pixel großen Punkt.

In Zeile 8 bis inkl. 11 hebt die Turtle den Stift auf und zeichnet ab hier nichts mehr.
Dann fährt sie 50 Pixel nach vorne und setzt den Stift wieder ab, damit sie wieder
etwas zeichnet und macht dann wieder einen 10 Pixel großen Punkt.
Man sieht, dass zwischen den zwei Punkten der Stift aufgehoben wurde,
da keine durchgezogene Linie zwischen den beiden Punkten zu sehen ist.

In Zeile 12 dreht sich die Turtle 90° nach links und sieht damit nach unten.
In Zeile 13 bis inkl. 15 geht sie 50 Pixel nach vorne, dreht sich 90° nach rechts
und geht dann wieder 50 Pixel nach vorne.

In Zeile 16 versteckt sie die Turtle, damit ist sie im finalen Bild nicht mehr sichtbar.

## 🧭 Zusammenfassung
Wir haben uns die wichtigsten Funktionen der Turtle angesehen.
Funktionen haben am Ende zwei runde Klammern.
Zwischen den runden Klammern können Argumente stehen,
das sind weitere Angaben zum Funktionsaufruf,
beispielsweise die Anzahl der Pixel bei der Funktion `fd`

Im nächsten Abschnitt sollst du selbst Programme schreiben,
um vorgegebene Grafiken zu erzeugen.




























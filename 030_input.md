# Eingabe von Werten

Mit Variablen haben wir unsere Programme bereits flexibler gemacht.
Jedoch möchten wir noch, dass der Benutzer des Programms,
jedes Mal andere Variablenwerte verwenden kann.

In diesem Kapitel sehen wir uns an, wie Benutzer Werte für Variablen eingeben können.

## Eingabe mit den `Input` Funktionen

Bevor wir den Benutzer nach einem Wert für eine Variable fragen, müssen wir uns
Gedanken machen, welchen **Typ** die Variable haben soll.
Die Turtle stellt zur Eingabe von Daten vier Funktionen zur Verfügung:

* `InputInt` zur Eingabe von Ganzzahlen
* `InputDouble` zur Eingabe von Gleitkommzahlen mit doppelter Genauigkeit
* `InputFloat` zur Eingabe von Gleitkommzahlen mit einfacher Genauigkeit
* `InputString` zur Eingabe von Strings (Texten)

Um Werte vom Benutzer abzufragen, können wir die Funktionen wie folgt aufrufen:

+ `int a = Turtle.InputInt("Bitte Zahl eingeben!");` - um **Integer** Werte einzulesen
+ `double c = Turtle.InputDouble("Bitte Zahl eingeben!");` - um **Double** Werte einzulesen
+ `float b = Turtle.InputFloat("Bitte Zahl eingeben!");` - um **Float** Werte einzulesen
+ `string d = Turtle.InputString("Etwas eingeben!");` - um **String** Werte einzulesen

Auf der linken Seite des Zeichens `=` steht der Name der Variablen,
der ein neuer Wert zugewiesen werden soll.
Auf der rechten Seite hatten wir bis jetzt immer einen fixen Wert.
Statt dem fixen Wert steht jetzt der Funktionsaufruf der jeweiligen `Input`-Funktion mit einem Argument.
Das Argument ist der Text der dem Benutzer angezeigt wird,
wenn er einen Wert eingeben soll.


In den ersten Kapiteln beschäftigen wir uns ausschließlich mit den beiden
Typen Integer und Double. Für Strings gibt es später ein eigenes Kapitel.

In der folgenden Abbildung ist das Eingabefenster zu sehen:

![Eingabe eines Werts](./images/input.png)



## Übungen


### 📝 Übung 11

Schreibe ein Programm, welches ein gleichseitiges Dreieck zeichnet.
Die Länge a des Dreiecks soll der Benutzer selbst eingeben.
Der Typ der Eingabe soll Double sein, damit der Benutzer beispielsweise 20.5 
eingeben kann.

### 📝 Übung 12

Schreibe ein Programm, welches ein Haus zeichnet.
Die Höhe des Hauses soll vom Benutzer eingegeben werden können.
Im folgenden Bild siehst du drei mögliche Ergebnisse.
Je nachdem welchen Wert der Benutzer eingibt, kommt ein anderes Haus dabei raus.

![Haus mit verschiedenen Höhen](./images/house.png)

### 📝 Übung 13

Erweitere das Programm von Übung 12 um eine weitere Eingabe.
Der Benutzer soll zusätzlich die Größe der Fenster eingeben können.

## 🧭 Zusammenfassung

Unsere Programme können nun Zahlenwerte als Eingabe vom Benutzer entgegennehmen.
Hierzu nutzen sie die Funktionen `InputInt` und `InputDouble`.
Dadurch sind die Programme flexibler einsetzbar.





























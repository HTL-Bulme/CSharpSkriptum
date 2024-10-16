# Farben verwenden

In diesem Abschnitt lernst du wie man mit der Turtle bunte Bilder zeichnen kann.
Die Turtle kann sowohl farbige Linien als auch farbige Flächen zeichnen.

## Farbe des Stifts ändern

Über die Funktion `Turtle.setPenColor("farbname");` kannst du die Farbe des Stifts auswählen.
Wichtig ist, dass du den Farbnamen doppelte Hochkomma (Umschalttaste + 2) setzt.
Wie immer beim Programmieren kennt die Turtle nur englische Farbnamen.
Die folgende Liste ist zwar nicht vollständig, aber doch ein erster Anhaltspunkt: yellow, gold, orange, red, maroon, violet, magenta, purple, navy, blue, skyblue, cyan, turquoise, lightgreen, green, darkgreen, chocolate, brown, black, gray, white.

Zusätzlich kannst du noch die Dicke der des Stifts ändern.
Mit der Funktion `Turtle.setPenWidth(dicke);` setzt du die Dicke auf den gewünschten Wert.

Das folgende Beispiel zeigt wie du die Funktionen aufrufen kannst.
Wichtig ist bei `Turtle.setPenColor("farbname")`, dass du den Namen der Farbe in doppelte Hochkomma schreibst,
da es sich um einen Text handelt.

```cs
#r "nuget: BulmeSharp, 0.10.1"
using BulmeSharp;

Turtle.setColor("blue");
Turtle.dot(25);
Turtle.penUp();
Turtle.fd(35);
Turtle.setPenColor("red");
Turtle.setPenWidth(25);
Turtle.pd();
Turtle.fd(50);
Turtle.showTurtle();
```

Das Programm erzeugt folgende Grafik:

![Ergebnis des Programms](./images/rufzeichen.png)

## Flächen mit einer Farbe füllen

Um eine Fläche auszufüllen, sagst du zuerst der Turtle mit `startPath()`,
dass sie sich ausgehend vom aktuellen Ort die nachfolgend gezeichnete Figur merken soll.
Mit der Funktion `fillPath()` wird der jetzige Ort mit dem Startort verbunden 
und die eingeschlossene Fläche eingefärbt. Mit `setFillColor("farbname")`
kannst du die Füllfarbe angeben (sagst du nichts, so ist sie standardmässig schwarz).

```cs
#r "nuget: BulmeSharp, 0.10.1"
using BulmeSharp;

Turtle.setColor("magenta");
Turtle.beginFill();
Turtle.fd(50);
Turtle.rt(120);
Turtle.fd(50);
Turtle.rt(120);
Turtle.fd(50);
Turtle.rt(120);
Turtle.endFill();
Turtle.showTurtle();
```
Das Programm erzeugt folgende Grafik:

![Ergebnis des Programms](./images/triangle.png)





























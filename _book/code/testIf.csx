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
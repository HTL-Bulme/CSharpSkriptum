#r "nuget: TurtleGraphics, 1.0.2"
using TurtleGraphics;

Turtle.SetPenWidth(2);
Turtle.SetColor("blue");

double distanzStaebe = Turtle.InputInt("dist");
double laenge = distanzStaebe * 7;

for (int i = 0; i < 8; i++)
{
    Turtle.Forward(laenge);
    Turtle.Forward(-laenge);
    Turtle.PenUp();
    Turtle.TurnRight(90);
    Turtle.Forward(distanzStaebe);
    Turtle.TurnRight(-90);
    Turtle.PenDown();
}
Turtle.PenUp();
Turtle.TurnRight(90);
Turtle.Forward(-distanzStaebe);
 Turtle.PenDown();
for (int i = 0; i < 8; i++)
{
    Turtle.Forward(-laenge);
    Turtle.Forward(laenge);
    Turtle.PenUp();
    Turtle.TurnRight(-90);
    Turtle.Forward(distanzStaebe);
    Turtle.TurnRight(90);
    Turtle.PenDown();
}

Turtle.ShowTurtle();
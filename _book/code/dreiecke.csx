#r "nuget: TurtleGraphics, 1.0.2"
using TurtleGraphics;


double anzahl = Turtle.InputInt("dist");
double size = Turtle.InputInt("size");

Turtle.SetPenWidth(4);
Turtle.SetColor("red");
for (int i = 0; i < anzahl; i++)
{
    Turtle.Forward(size);
    Turtle.TurnRight(120);
    Turtle.Forward(size);
    Turtle.TurnRight(120);
    Turtle.Forward(size);
    Turtle.TurnRight(120);
    Turtle.PenUp();
    Turtle.Forward(size);
    Turtle.PenDown();
}
Turtle.ShowTurtle();
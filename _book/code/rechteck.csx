#r "nuget: TurtleGraphics, 1.0.2"
using TurtleGraphics;

Turtle.SetPenWidth(4);

double seite_a = Turtle.InputDouble("a eingeben");
double seite_b = Turtle.InputDouble("b eingeben");

for (int i = 0; i < 2; i++)
{
    Turtle.Forward(seite_a);
    Turtle.TurnRight(90);
    Turtle.Forward(seite_b);
    Turtle.TurnRight(90);
}
Turtle.ShowTurtle();
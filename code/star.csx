#r "nuget: TurtleGraphics, 1.0.2"
using TurtleGraphics;

Turtle.SetPenWidth(5);
Turtle.SetColor("red");
for (int i = 0; i < 8; i++)
{
    Turtle.Forward(20);
    Turtle.TurnLeft(90);
    Turtle.Forward(10);
    Turtle.SetColor("blue");
    Turtle.Dot(4);
    Turtle.SetColor("red");
    Turtle.Forward(-10);
    Turtle.TurnLeft(-90);
    Turtle.TurnRight(45);
}
Turtle.ShowTurtle();
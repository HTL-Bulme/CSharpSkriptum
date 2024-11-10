#r "nuget: TurtleGraphics, 1.0.2"
using TurtleGraphics;

Turtle.SetPenWidth(10);
Turtle.SetColor("orange");
for (int i = 0; i < 6; i++)
{
    Turtle.Forward(50);
    Turtle.Forward(-50);
    Turtle.PenUp();
    Turtle.TurnRight(90);
    Turtle.Forward(10);
    Turtle.PenDown();
    Turtle.TurnRight(-90);
}
Turtle.ShowTurtle();
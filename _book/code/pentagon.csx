#r "nuget: TurtleGraphics, 1.0.2"
using TurtleGraphics;

Turtle.SetPenWidth(3);
Turtle.SetColor("purple");
for (int i = 0; i < 5; i++)
{
    Turtle.Forward(50);
    Turtle.TurnRight(72);
}
Turtle.ShowTurtle();
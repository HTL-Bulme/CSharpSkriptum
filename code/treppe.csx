#r "nuget: TurtleGraphics, 1.0.2"
using TurtleGraphics;

Turtle.SetPenWidth(3);
Turtle.SetColor("brown");
for (int i = 0; i < 15; i++)
{
    Turtle.Forward(5);
    Turtle.TurnRight(90);
    Turtle.Forward(5);
    Turtle.TurnRight(-90);
}

Turtle.Forward(-20);

for (int i = 0; i < 15; i++)
{
    Turtle.Forward(-5);
    Turtle.TurnRight(90);
    Turtle.Forward(-5);
    Turtle.TurnRight(-90);
}

Turtle.Forward(20);

Turtle.ShowTurtle();
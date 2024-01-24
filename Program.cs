using Design_Pattern.Interface;
using Design_Pattern;


public class Shapes
{
    static void Main()
    {
        ShapeFactory shapeFactory = new ShapeFactory();

        // Create a circle and draw it
        Ishape circle = shapeFactory.CreateShape("circle");
        circle.Draw();

        // Create a square and draw it
        Ishape square = shapeFactory.CreateShape("square");
        square.Draw();

        // Create a triangle and draw it
        Ishape triangle = shapeFactory.CreateShape("triangle");
        triangle.Draw();

     
 
    }
}
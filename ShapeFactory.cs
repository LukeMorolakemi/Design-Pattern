using Design_Pattern.Implementation;
using Design_Pattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern
{
    public class ShapeFactory
    {
        public Ishape CreateShape(string shapeType)
        {
            switch (shapeType.ToLower())
            {
                case "circle":
                    return new Circle();
                case "square":
                    return new Square();
                case "triangle":
                    return new Triangle();
                default:
                    throw new ArgumentException("Invalid shape type");
            }
        }
    }
}

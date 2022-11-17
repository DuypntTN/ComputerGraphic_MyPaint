using System;

namespace _20127149
{

    internal class Graphic
    {
        public struct ShapeTypes
        {
            public short Line, Triangle, Ellipse, None, Circle;
            public ShapeTypes()
            {
                None = 0;
                Line = 1;
                Circle = 2;
                Triangle = 3;
                Ellipse = 4;
            }
        }
        public readonly ShapeTypes shapeTypes = new ShapeTypes();
        public short _selectedShapeType;
        public Graphic()
        {
            _selectedShapeType = shapeTypes.None;
        }
        public void SetSelectedShapeType(short type)
        {
            Console.WriteLine("Type selected" + type);
            _selectedShapeType = type;

        }
    }
}

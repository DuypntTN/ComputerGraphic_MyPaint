using SharpGL;
using System.Collections.Generic;
using System.Drawing;

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
        public Shape _curShape;
        public readonly ShapeTypes shapeTypes = new();
        public short _selectedShapeType;
        public bool _isMouseUp, _isMouseDown, _isDoneDrawing, _isDrawing;
        public float _borderWidth;
        public Color _borderColor;
        public Point _startPoint, _endPoint;
        public List<Point> _verticesList;
        public List<Shape> _shapes;
        public Graphic()
        {
            _isDoneDrawing = false;
            _isMouseDown = false;
            _isMouseUp |= _isMouseDown;
            _isDrawing = false;
            _selectedShapeType = shapeTypes.None;
            _verticesList = new List<Point>();
            _shapes = new List<Shape>();
            _curShape = null;
            _borderWidth = 1f;
            _borderColor = Color.White;
        }
        public void SetSelectedShapeType(short type)
        {
            _selectedShapeType = type;

        }
        public void SetBorderWidth(float size)
        {
            _borderWidth = size;
        }
        public void SetBorderColor(Color color)
        {
            _borderColor = color;
        }
        public void ShowListShapes(OpenGL gl)
        {
            int n = _shapes.Count;
            for (int i = 0; i < n; i++)
            {
                if (_shapes[i] != null)
                {
                    _shapes[i].ShowShape(gl);
                }
            }
        }

        public void CreateShape()
        {
            if (_selectedShapeType == shapeTypes.Line)
            {
                _curShape = new Line(_verticesList, _startPoint, _endPoint, _borderWidth, _borderColor);
            }
        }
        public void GetInfo()
        {
        }
        public void HandleDraw(OpenGL gl)
        {
            if (_isDoneDrawing == true)
            {
                HandleDrawDone();
            }
            if (_isDrawing == true)
            {
                HandleDrawing(gl);
            }
            if (_curShape != null && _isDrawing == false)
            {
                _curShape.ShowShape(gl);
            }
        }
        public void HandleDrawing(OpenGL gl)
        {
            CreateShape();
            _curShape.ShowShape(gl);
        }
        public void HandleDrawDone()
        {
            _shapes.Add(_curShape);
            _curShape = null;
            if (_verticesList.Count != 0)
            {
                _verticesList.Clear();
            }
        }
    }
}

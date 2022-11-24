using SharpGL;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;

namespace _20127149
{

    internal class Graphic
    {
        public struct ShapeTypes
        {
            public short Line, Rectangular, Ellipse, None, Circle;
            public ShapeTypes()
            {
                None = 0;
                Line = 1;
                Rectangular = 2;
                Circle = 3;
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
        public Stopwatch _watcher;
        public double _timeExecuted;
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
            _borderColor = Color.Black;
            _watcher = new();
            _timeExecuted = 0;
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
                _curShape = new Line(_verticesList, _startPoint, _endPoint, _borderWidth, _borderColor, shapeTypes.Line);
            }
            if (_selectedShapeType == shapeTypes.Rectangular)
            {
                _curShape = new Rectangular(_verticesList, _startPoint, _endPoint, _borderWidth, _borderColor, shapeTypes.Rectangular);
            }
            if (_selectedShapeType == shapeTypes.Circle)
            {
                _curShape = new Circle(_verticesList, _startPoint, _endPoint, _borderWidth, _borderColor, shapeTypes.Circle);
            }
        }
        public List<int> GetInfoCurrentShapesList()
        {
            if (_shapes == null)
                return new();
            List<int> listShape = new();
            for (int i = 0; i < _shapes.Count; i++)
            {
                if (_shapes[i] != null)
                    listShape.Add(_shapes[i]._typeSharp);
            }
            return listShape;
        }

        public void ChangeColorShape(Color color, int index)
        {
            if (_shapes[index] != null)
            {
                if (_shapes[index]._borderColor == color)
                {
                    _shapes[index]._borderColor = _borderColor;
                }
                _shapes[index]._borderColor = color;
            }

        }
        public void HandleDraw(OpenGL gl)
        {
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
            // start the watcher
            _watcher.Start();
            _curShape.ShowShape(gl);
            _watcher.Stop();
            _timeExecuted = _watcher.Elapsed.TotalMilliseconds * 1000;
            _curShape._timeExecuted = _timeExecuted;
        }
        public void HandleDrawDone()
        {
            _shapes.Add(_curShape);
            _curShape = null;
            _timeExecuted = 0;
            _watcher = new();
            if (_verticesList.Count != 0)
            {
                _verticesList.Clear();
            }
        }


    }
}

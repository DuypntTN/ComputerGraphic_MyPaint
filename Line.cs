using SharpGL;
using System.Collections.Generic;
using System.Drawing;

namespace _20127149
{
    internal class Line : Shape
    {
        public Line(List<Point> _verticesList, Point startPoint, Point endPoint, float borderWidth, Color borderColor) : base(_verticesList, startPoint, endPoint, borderWidth, borderColor)
        {
            List<Point> points = new();
            this._verticesList = points;
            this._verticesList.Add(startPoint);
            this._verticesList.Add(endPoint);
            this._borderWidth = borderWidth;
            this._borderColor = borderColor;
        }
        public override void ShowShape(OpenGL gl)
        {
            if (_points.Count != 0)
            {
                _points.Clear();
            }
            DrawLine(_verticesList[0], _verticesList[1], gl);
        }

    }
}

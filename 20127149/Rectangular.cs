using SharpGL;
using System.Collections.Generic;
using System.Drawing;

namespace _20127149
{
    internal class Rectangular : Shape
    {
        Point tl; // point top-left
        Point br; // point bottom-right
        Point bl; // point bottom -left
        Point tr; // point top-right
        public Rectangular(List<Point> _verticesList, Point startPoint, Point endPoint, float borderWidth, Color borderColor, int typeShape) : base(_verticesList, startPoint, endPoint, borderWidth, borderColor, typeShape)
        {
            List<Point> points = new();
            this._verticesList = points;
            this.tl = startPoint;
            this.br = endPoint;
            // Config for bl and tr
            this.tr.X = endPoint.X;
            this.tr.Y = startPoint.Y;
            this.bl.X = startPoint.X;
            this.bl.Y = endPoint.Y;

            // Add to vertices
            this._verticesList.Add(tl);
            this._verticesList.Add(tr);
            this._verticesList.Add(br);
            this._verticesList.Add(bl);
            // Config color
            this._borderWidth = borderWidth;
            this._borderColor = borderColor;
            this._typeSharp = typeShape;

            /*  this._verticesList.Add(startPoint);
              this._verticesList.Add(endPoint);
              this._borderWidth = borderWidth;
              this._borderColor = borderColor;
              this._typeSharp = typeShape;*/
        }
        public override void ShowShape(OpenGL gl)
        {
            if (_points.Count != 0)
            {
                _points.Clear();
            }
            DrawLine(_verticesList[3], _verticesList[0], gl);
            for (int i = 0; i < 3; i++)
            {
                DrawLine(_verticesList[i], _verticesList[i + 1], gl);
            }

        }

    }
}

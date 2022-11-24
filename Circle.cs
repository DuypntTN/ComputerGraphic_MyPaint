using SharpGL;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace _20127149
{
    internal class Circle : Shape
    {
        /*double r; // radius of circle*/
        public Circle(List<Point> _verticesList, Point startPoint, Point endPoint, float borderWidth, Color borderColor, int typeShape) : base(_verticesList, startPoint, endPoint, borderWidth, borderColor, typeShape)
        {
            List<Point> points = new();
            this._verticesList = points;
            ContributePoints(startPoint, endPoint);
        }
        public override void ShowShape(OpenGL gl)
        {
            if (_points.Count != 0)
            {
                _points.Clear();
            }
            DrawListPoint(_verticesList, gl);
        }

        public override void ContributePoints(Point startPoint, Point endPoint)
        {
            // distance between 2 points sqrt((x1-x2)^2 + (y1-y2)^2)
            int r = (int)Math.Round(Math.Sqrt(Math.Pow(startPoint.X - endPoint.X, 2) - Math.Pow(startPoint.Y - endPoint.Y, 2)));
            if (_verticesList.Count != 0)
                _verticesList.Clear();
            // this is the center point
            Point centerPoint = startPoint;
            // this is the start point
            Point point = new(0, r);
            // add 4 points on axises
            //(0,r)
            _verticesList.Add(new(centerPoint.X, r + centerPoint.Y));
            //(0,-r)
            _verticesList.Add(new(centerPoint.X, -r + centerPoint.Y));
            //(r,0)
            _verticesList.Add(new(r + centerPoint.X, centerPoint.Y));
            //(-r,0)
            _verticesList.Add(new(-r + centerPoint.X, centerPoint.Y));
            //
            int p = 5 / 4 - r;
            // Draw circle method
            while (point.X < point.Y)
            {
                if (p < 0)
                {
                    point.X += 1;
                    p += 2 * point.X + 1;
                }
                else
                {
                    point.X += 1;
                    point.Y -= 1;
                    p += 2 * point.X - 2 * point.Y + 1;
                }
                Point temp = new();
                temp.X = point.X + centerPoint.X;
                temp.Y = point.Y + centerPoint.Y;
                _verticesList.Add(temp);
                Point temp1 = new Point();
                temp1.X = point.Y + centerPoint.X;
                temp1.Y = point.X + centerPoint.Y;
                _verticesList.Add(temp1);
                Point temp2 = new Point();
                temp2.X = point.Y + centerPoint.X;
                temp2.Y = -point.X + centerPoint.Y;
                _verticesList.Add(temp2);
                Point temp3 = new Point();
                temp3.X = point.X + centerPoint.X;
                temp3.Y = -point.Y + centerPoint.Y;
                _verticesList.Add(temp3);
                Point temp4 = new Point();
                temp4.X = -point.X + centerPoint.X;
                temp4.Y = -point.Y + centerPoint.Y;
                _verticesList.Add(temp4);
                Point temp5 = new Point();
                temp5.X = -point.Y + centerPoint.X;
                temp5.Y = -point.X + centerPoint.Y;
                _verticesList.Add(temp5);
                Point temp6 = new Point();
                temp6.X = -point.Y + centerPoint.X;
                temp6.Y = point.X + centerPoint.Y;
                _verticesList.Add(temp6);
                Point temp7 = new Point();
                temp7.X = -point.X + centerPoint.X;
                temp7.Y = point.Y + centerPoint.Y;
                _verticesList.Add(temp7);
            }
        }

    }
}

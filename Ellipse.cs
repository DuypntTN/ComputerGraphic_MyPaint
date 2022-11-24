using SharpGL;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace _20127149
{
    internal class Ellipse : Shape
    {
        /*double r; // radius of circle*/
        public Ellipse(List<Point> _verticesList, Point startPoint, Point endPoint, float borderWidth, Color borderColor, int typeShape) : base(_verticesList, startPoint, endPoint, borderWidth, borderColor, typeShape)
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
            if (_verticesList.Count != 0)
                _verticesList.Clear();
            //rx, ry
            int rx = Math.Abs(endPoint.X - startPoint.X);
            int ry = Math.Abs(endPoint.Y - startPoint.Y);
            Point centerPoint = new(startPoint.X, startPoint.Y);
            Point point = new(0, ry);
            //(0,ry)
            _verticesList.Add(new(centerPoint.X, ry + centerPoint.Y));
            //(0,-ry)
            _verticesList.Add(new(centerPoint.X, -ry + centerPoint.Y));
            //(rx,0)
            _verticesList.Add(new(rx + centerPoint.X, -ry + centerPoint.Y));
            //(-rx,0)
            _verticesList.Add(new(-rx + centerPoint.X, centerPoint.Y));
            //ry^2
            int powRy2 = ry * ry;
            //rx^2
            int powRx2 = rx * rx;
            //p0
            int p = powRy2 - powRx2 * ry - powRx2 / 4;
            //loop 1st
            while (powRy2 * point.X < powRx2 * point.Y)
            {
                if (p < 0)
                {
                    point.X += 1;
                    p += 2 * powRy2 * point.X + powRy2;
                }
                else
                {
                    point.X += 1;
                    point.Y -= 1;
                    p += 2 * powRy2 * point.X - 2 * powRx2 * point.Y + powRy2;
                }
                //(x,y)
                _verticesList.Add(new(point.X + centerPoint.X, point.Y + centerPoint.Y));
                //(-x,y)
                _verticesList.Add(new(-point.X + centerPoint.X, point.Y + centerPoint.Y));
                //(-x,-y)
                _verticesList.Add(new(-point.X + centerPoint.X, -point.Y + centerPoint.Y));
                //(x,-y)
                Point temp3 = new();
                temp3.X = point.X + centerPoint.X;
                temp3.Y = -point.Y + centerPoint.Y;
                _verticesList.Add(temp3);
            }
            // loop 2nd
            p = powRy2 * (point.X + 1 / 2) * (point.X + 1 / 2) + powRx2 * (point.Y - 1) * (point.Y - 1) - powRx2 * powRy2;
            while (point.Y != 0)
            {
                if (p > 0)
                {
                    point.Y -= 1;
                    p += -2 * powRx2 * point.Y + powRx2;
                }
                else
                {
                    point.Y -= 1;
                    point.X += 1;
                    p += 2 * powRy2 * point.X - 2 * powRx2 * point.Y + powRx2;
                }
                //(x,y)
                Point temp = new();
                temp.X = point.X + centerPoint.X;
                temp.Y = point.Y + centerPoint.Y;
                _verticesList.Add(temp);
                //(-x,y)
                Point temp1 = new();
                temp1.X = -point.X + centerPoint.X;
                temp1.Y = point.Y + centerPoint.Y;
                _verticesList.Add(temp1);
                //(-x,-y)
                Point temp2 = new();
                temp2.X = -point.X + centerPoint.X;
                temp2.Y = -point.Y + centerPoint.Y;
                _verticesList.Add(temp2);
                //(x,-y)
                Point temp3 = new();
                temp3.X = point.X + centerPoint.X;
                temp3.Y = -point.Y + centerPoint.Y;
                _verticesList.Add(temp3);
            }
        }

    }
}

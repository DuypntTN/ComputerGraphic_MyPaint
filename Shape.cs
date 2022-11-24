using SharpGL;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace _20127149
{
    internal class Shape
    {
        public List<Point> _verticesList = new();
        protected Point _startPoint, _endPoint;
        public double _timeExecuted;
        public List<Point> _points;
        protected float _borderWidth;
        public Color _borderColor;
        public int _typeSharp;
        public Shape(List<Point> vertices, Point startPoint, Point endPoint, float borderWidth, Color borderColor, int typeShape)
        {
            _verticesList = new List<Point>(vertices);
            _startPoint = startPoint;
            _endPoint = endPoint;
            _points = new();
            _borderWidth = borderWidth;
            _borderColor = borderColor;
            _timeExecuted = 0;
            _typeSharp = typeShape;
        }

        public virtual void ShowShape(OpenGL gl)
        {
        }
        public virtual void ContributePoints(Point startPoint, Point endPoint)
        {

        }
        public void DrawListPoint(List<Point> points, OpenGL gl)
        {
            gl.Color(_borderColor.R / 255.0, _borderColor.G / 255.0, _borderColor.B / 255.0);
            gl.PointSize(_borderWidth);
            gl.Begin(OpenGL.GL_POINTS);
            for (int i = 0; i < points.Count(); i += 1)
            {
                gl.Vertex(points[i].X, gl.RenderContextProvider.Height - points[i].Y);
            }
            gl.End();
            gl.Flush();
        }
        public void DrawListPointWithColor(List<Point> points, OpenGL gl, Color color)
        {
            gl.Color(color.R / 255.0, color.G / 255.0, color.B / 255.0);
            gl.PointSize(_borderWidth);
            gl.Begin(OpenGL.GL_POINTS);
            for (int i = 0; i < points.Count(); i += 1)
            {
                gl.Vertex(points[i].X, gl.RenderContextProvider.Height - points[i].Y);
            }
            gl.End();
            gl.Flush();
        }
        public void DrawLine(Point startPoint, Point endPoint, OpenGL gl)
        {
            int dx = endPoint.X - startPoint.X;
            int dy = endPoint.Y - startPoint.Y;
            int stepX, stepY;
            Point newPoint = new(startPoint.X, startPoint.Y);
            _points.Add(newPoint);
            //xét dấu dx,dy
            if (dx < 0)
            {
                dx *= -1;
                stepX = -1;
            }
            else
            {
                stepX = 1;
            }
            if (dy < 0)
            {
                dy *= -1;
                stepY = -1;
            }
            else
            {
                stepY = 1;
            }
            //tìm tập điểm của đoạn thẳng
            //nếu |m| < 1
            if (dx > dy)
            {
                int p = 2 * dy - 2 * dx;
                while (newPoint.X != endPoint.X)
                {
                    if (p < 0)
                    {
                        p += 2 * dy;
                    }
                    else
                    {
                        newPoint.Y += stepY;
                        p += 2 * dy - 2 * dx;
                    }
                    newPoint.X += stepX;
                    _points.Add(newPoint);
                }

            }
            else
            {
                //|m|>1
                int p = 2 * dx - 2 * dy;
                while (newPoint.Y != endPoint.Y)
                {
                    if (p < 0)
                    {
                        p += 2 * dx;
                    }
                    else
                    {
                        newPoint.X += stepX;
                        p += 2 * dx - 2 * dy;
                    }
                    newPoint.Y += stepY;
                    _points.Add(newPoint);
                }
            }
            DrawListPoint(_points, gl);
        }
    }
}

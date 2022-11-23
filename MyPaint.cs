using SharpGL;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace _20127149
{
    public partial class MyPaint : Form
    {
        readonly Graphic _graphic;
        public MyPaint()
        {
            InitializeComponent();
            _graphic = new();
        }


        private void Btn_Line_Cliked(object sender, System.EventArgs e)
        {
            _graphic.SetSelectedShapeType(_graphic.shapeTypes.Line);
        }

        private void Btn_Ellipse_Clicked(object sender, System.EventArgs e)
        {
            _graphic.SetSelectedShapeType(_graphic.shapeTypes.Ellipse);
        }

        private void Btn_Circle_Clicked(object sender, System.EventArgs e)
        {
            _graphic.SetSelectedShapeType(_graphic.shapeTypes.Circle);
        }

        private void GlControlMouseUp(object sender, MouseEventArgs e)
        {
            _graphic._isMouseUp = true;
            _graphic._isMouseDown = false;

            if (_graphic._isDrawing == true)
            {
                _graphic._endPoint = e.Location;
                _graphic._isDrawing = false;
                _graphic._isDoneDrawing = true;
                _graphic.HandleDrawDone();
            }
        }
        private void GlControlMouseDown(object sender, MouseEventArgs e)
        {
            _graphic._isMouseUp = false;
            _graphic._isMouseDown = true;
            _graphic._isDoneDrawing = false;
            if (e.Button == MouseButtons.Left)
            {
                _graphic._startPoint = e.Location;
                _graphic._endPoint = _graphic._startPoint;
                _graphic._isDrawing = true;
            }
        }

        private void GlControlMouseMove(object sender, MouseEventArgs e)
        {
            if (_graphic._isMouseDown == true && _graphic._isMouseUp == false)
            {
                _graphic._isDrawing = true;
            }
            if (_graphic._isDrawing == true && _graphic._selectedShapeType != _graphic.shapeTypes.None) // Mouse khong an giu va khong chon shape
            {
                /* Console.WriteLine("Is Drawing" + e.Location);*/
                _graphic._endPoint = e.Location;
            }
            return;
        }

        private void GlControl_OpenGLDraw(object sender, SharpGL.RenderEventArgs args)
        {
            OpenGL gl = glControl.OpenGL;
            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);
            if (_graphic._selectedShapeType != _graphic.shapeTypes.None)
            {

                if (_graphic._isDrawing == true)
                {
                    _graphic.HandleDraw(gl); ;
                };
                if (_graphic != null)
                {
                    _graphic.ShowListShapes(gl);
                }

            }
        }

        private void GlControl_OpenGLInitialized(object sender, EventArgs e)
        {
            OpenGL gl = glControl.OpenGL;
            // Set the clear color.
            gl.ClearColor(1, 1, 1, 1);
            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);
            // Set the projection matrix.
            gl.MatrixMode(OpenGL.GL_PROJECTION);
            gl.LoadIdentity();
        }

        private void GlControl_Resized(object sender, EventArgs e)
        {
            OpenGL gl = glControl.OpenGL;
            // Set the projection matrix.
            gl.MatrixMode(OpenGL.GL_PROJECTION);
            // Load the identity.
            gl.LoadIdentity();
            // Create a perspective transformation.
            gl.Viewport(0, 0, glControl.Width, glControl.Height);
            gl.Ortho2D(0, glControl.Width, 0, glControl.Height);

        }

        private void BorderWidthControlValueChanged(object sender, EventArgs e)
        {
            float value = (float)borderWidthControl.Value;
            _graphic.SetBorderWidth(value);
        }


        private void BtnColorPickerClick(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Color color = colorDialog1.Color;
                _graphic.SetBorderColor(color);
                btnPickColorBorder.BackColor = color;
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

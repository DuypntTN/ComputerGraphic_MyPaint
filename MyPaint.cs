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

        }
        private void GlControlMouseDown(object sender, MouseEventArgs e)
        {

        }

        private void GlControlMouseMove(object sender, MouseEventArgs e)
        {

        }

    }
}

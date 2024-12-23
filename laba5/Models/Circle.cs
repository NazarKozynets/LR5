using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace laba5.Models
{
    public class Circle : Figure
    {
        public double Radius { get; private set; }
        private Ellipse _ellipse;

        public Circle(double x, double y, double radius) : base(x, y)
        {
            Radius = radius;
            _ellipse = new Ellipse
            {
                Width = radius * 2,
                Height = radius * 2,
                Fill = Brushes.Black
            };
        }

        public override void DrawBlack(Canvas canvas)
        {
            if (!canvas.Children.Contains(_ellipse))
            {
                canvas.Children.Add(_ellipse);
            }
            Canvas.SetLeft(_ellipse, X);
            Canvas.SetTop(_ellipse, Y);
        }

        public override void HideDrawingBackGround(Canvas canvas)
        {
            if (canvas.Children.Contains(_ellipse))
            {
                canvas.Children.Remove(_ellipse);
            }
        }
    }
}
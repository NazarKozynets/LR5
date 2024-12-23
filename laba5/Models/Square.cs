using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace laba5.Models
{
    public class Square : Figure
    {
        public double SideLength { get; private set; }
        private Rectangle _rectangle;

        public Square(double x, double y, double sideLength) : base(x, y)
        {
            SideLength = sideLength;
            _rectangle = new Rectangle
            {
                Width = sideLength,
                Height = sideLength,
                Fill = Brushes.Black
            };
        }

        public override void DrawBlack(Canvas canvas)
        {
            if (!canvas.Children.Contains(_rectangle))
            {
                canvas.Children.Add(_rectangle);
            }
            Canvas.SetLeft(_rectangle, X);
            Canvas.SetTop(_rectangle, Y);
        }

        public override void HideDrawingBackGround(Canvas canvas)
        {
            if (canvas.Children.Contains(_rectangle))
            {
                canvas.Children.Remove(_rectangle);
            }
        }
    }
}
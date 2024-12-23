using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace laba5.Models
{
    public class Rhomb : Figure
    {
        public double HorDiagLen { get; private set; }
        public double VertDiagLen { get; private set; }
        private Polygon _polygon;

        public Rhomb(double x, double y, double horDiagLen, double vertDiagLen) : base(x, y)
        {
            HorDiagLen = horDiagLen;
            VertDiagLen = vertDiagLen;

            _polygon = new Polygon
            {
                Points = new PointCollection
                {
                    new System.Windows.Point(x + horDiagLen / 2, y),
                    new System.Windows.Point(x + horDiagLen, y + vertDiagLen / 2),
                    new System.Windows.Point(x + horDiagLen / 2, y + vertDiagLen),
                    new System.Windows.Point(x, y + vertDiagLen / 2)
                },
                Fill = Brushes.Black
            };
        }

        public override void DrawBlack(Canvas canvas)
        {
            if (!canvas.Children.Contains(_polygon))
            {
                canvas.Children.Add(_polygon);
            }
            Canvas.SetLeft(_polygon, X);
            Canvas.SetTop(_polygon, Y);
        }

        public override void HideDrawingBackGround(Canvas canvas)
        {
            if (canvas.Children.Contains(_polygon))
            {
                canvas.Children.Remove(_polygon);
            }
        }
    }
}
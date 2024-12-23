using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace laba5.Models
{
    public abstract class Figure
    {
        public double X { get; protected set; }
        public double Y { get; protected set; }

        protected Figure(double x, double y)
        {
            X = x;
            Y = y;
        }

        public abstract void DrawBlack(Canvas canvas);
        public abstract void HideDrawingBackGround(Canvas canvas);

        public async Task MoveRight(Canvas canvas)
        {
            for (int i = 0; i < 10; i++)
            {
                DrawBlack(canvas);
                await Task.Delay(100);
                HideDrawingBackGround(canvas);
                X += 10;
            }
        }
    }
}
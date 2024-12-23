using System.Threading.Tasks;
using System.Windows;
using laba5.Models;

namespace laba5
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async Task DrawAndMoveFigure(Figure figure)
        {
            await figure.MoveRight(DrawingCanvas);
        }

        private async void CircleButton_Click(object sender, RoutedEventArgs e)
        {
            var circle = new Circle(10, 100, 50);
            await DrawAndMoveFigure(circle);
        }

        private async void SquareButton_Click(object sender, RoutedEventArgs e)
        {
            var square = new Square(10, 100, 50);
            await DrawAndMoveFigure(square);
        }

        private async void RhombButton_Click(object sender, RoutedEventArgs e)
        {
            var rhomb = new Rhomb(10, 100, 60, 40);
            await DrawAndMoveFigure(rhomb);
        }
    }
}
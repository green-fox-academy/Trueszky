using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
namespace reQtry
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            List<Point> points = new List<Point>();
            double size = 9;
            points.Add(new Point(0, 0));
            points.Add(new Point(canvas.Width, canvas.Height));
            for (int i = 0; i < size; i++)
            {
                for (int k=0;k<i;k++)
                {
                    points.Add(new Point();
                    points.Add(new Point();
                }
            }
            for (int j = 0; j < size; j+=3)
            {
                foxDraw.DrawLine(points[j], points[j + 2]);
                foxDraw.DrawLine(points[j], points[j + 3]);
                foxDraw.DrawLine(points[j + 2], points[j + 1]);
                foxDraw.DrawLine(points[j + 3], points[j + 1]);
            }
        }

        public static void reQTry(FoxDraw foxDraw, Canvas canvas, int volume)
        {
            if (volume == 0)
            {
            }

        }
    }
}

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

namespace ColoredBox
{

    // Draw a box that has different colored lines on each edge
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            foxDraw.StrokeColor(Colors.Green);
           foxDraw.DrawLine(25,25,25,200);
            foxDraw.StrokeColor(Colors.Purple);
            foxDraw.DrawLine(200,25,25,25);
            foxDraw.StrokeColor(Colors.Blue);
            foxDraw.DrawLine(25,200,200,200);
            foxDraw.StrokeColor(Colors.Red);
            foxDraw.DrawLine(200,25,200,200);

            
        }
    }
}

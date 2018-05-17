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

namespace GoToCenter
{
    // Create a line drawing function that takes 2 parameters:
    // The x and y coordinates of the line's starting point
    // and draws a line from that point to the center of the canvas.
    // Draw 3 lines with that function. Use loop for that
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            GoToCenterMethod(canvas,5,3);
            

        }
        public static void GoToCenterMethod(Canvas canvas,double x,double y)
        {
            var foxDraw = new FoxDraw(canvas);
            for (int i = 0; i < 3; i++)
            {
                foxDraw.DrawLine(400, 225, x+i*175, y+i * 175);
            }
        }
    }
}

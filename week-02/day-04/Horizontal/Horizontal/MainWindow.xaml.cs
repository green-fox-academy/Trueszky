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

namespace Horizontal
{
    // Create a line drawing function that takes 2 parameters:
    // The x and y coordinates of the line's starting point
    // and draws a 50 long horizontal line from that point.
    // Draw 3 lines with that function. Use loop for that.
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            double x = 10, y = 25;

            GoToCenterMethod(foxDraw, x, y);
            

        }
        public static void GoToCenterMethod(FoxDraw foxDraw, double x, double y)
        {
            
            for (int i = 0; i < 50; i++)
            {
                foxDraw.DrawLine(x, (y+i)*5, x+50 , (y+i)*5);
            }
            
        }
    }
}

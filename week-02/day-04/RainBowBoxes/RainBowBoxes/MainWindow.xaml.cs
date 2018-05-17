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

namespace RainBowBoxes
{
    // Create a square drawing function that takes 2 parameters:
    // The square size, and the fill color,
    // and draws a square of that size and color to the center of the canvas.
    // Create a loop that fills the canvas with rainbow colored squares,
    // all squares should be centered, but growing in size
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            BoxesOfRainbow(foxDraw, 400, 222);
        }
        public static void BoxesOfRainbow(FoxDraw foxDraw, double x,byte y)
        {
            
            for(double i = 0; i <= x; i+=25)
            {
                
                foxDraw.FillColor(Color.FromRgb(y+=55,y+=35,y+=25));
                foxDraw.StrokeColor(Color.FromRgb(y+=45,y-=255,y+=15));
                foxDraw.DrawRectangle(400 - ((x-i) / 2), 225 - ((x-i)/ 2), x-(i), x-(i));
                
            }
        }
    }
}

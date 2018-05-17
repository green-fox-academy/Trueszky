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

namespace CenterSquare
{
    // Draw a green 10x10 square to the canvas' center.
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            CenterSquareMethod(foxDraw, 400, 225,200);


        }
        public static void CenterSquareMethod(FoxDraw foxDraw, double x, double y,double hw)
        {            
            for (int i = 0; i < 3; i++)
            {               
                foxDraw.DrawRectangle(x-(hw/2), y-(hw/2), hw, hw);
                foxDraw.FillColor(Colors.Beige);
            }
        }
    }
}

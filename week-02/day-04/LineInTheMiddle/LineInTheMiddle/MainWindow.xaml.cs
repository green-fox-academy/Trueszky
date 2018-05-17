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

namespace LineInTheMiddle
{

    // draw a red horizontal line to the canvas' middle.
    // draw a green vertical line to the canvas' middle.
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);            
            foxDraw.DrawLine(400, 0, 400, 450);
            foxDraw.FillColor(Colors.DarkBlue);
            foxDraw.DrawLine(0, 225, 800, 225);

            
        }
    }
}

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

namespace Triangles
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            int Size = 9;
            var foxDraw = new FoxDraw(canvas);
            Triangles(foxDraw,Size);


        }
        public static void Triangles(FoxDraw foxDraw,int size)
        {
            int x = 300;
            int y = 0;
            for (int i = 0; i <=size; i++)
            {               
                for (int k=1;k<i;k++)
                {
                    foxDraw.DrawLine(x, y, x + 25, y + 50);
                        foxDraw.DrawLine(x + 25, y + 50, x - 25, y + 50);
                        foxDraw.DrawLine(x - 25, y + 50, x, y);
                    foxDraw.DrawLine(x +=50, y, x, y);
                }
                foxDraw.DrawLine(x+=25-(50*i), y+=50, x, y);
                
            }
            
        }
    }
}

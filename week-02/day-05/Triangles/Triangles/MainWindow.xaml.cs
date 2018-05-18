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
            int size = 80;
            double tHeight = 20;
            var foxDraw = new FoxDraw(canvas);
            Triangles(canvas,foxDraw,size,tHeight);


        }
        public static void Triangles(Canvas canvas,FoxDraw foxDraw,int size,double tHeight)
        {
            double h = canvas.Height;
            double w = canvas.Width;
            w = w /2;
            h = 0;
            
            for (int i = 0; i <=size; i++)
            {               
                for (int k=1;k<i;k++)
                {
                    foxDraw.DrawLine(w, h, w + tHeight/2, h + tHeight);
                        foxDraw.DrawLine(w + tHeight/2, h + tHeight, w - tHeight/2, h + tHeight);
                        foxDraw.DrawLine(w - tHeight/2, h + tHeight, w, h);
                    foxDraw.DrawLine(w +=tHeight, h, w, h);
                }
                foxDraw.DrawLine(w+=tHeight/2-(tHeight*i), h+=tHeight, w, h);
                
            }
            
        }
    }
}

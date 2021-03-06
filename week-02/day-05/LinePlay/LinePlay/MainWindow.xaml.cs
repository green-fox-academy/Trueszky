﻿using System;
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

namespace LinePlay
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            int pixelRange = 80;
            Lines(foxDraw,pixelRange);
        }
        public static void Lines(FoxDraw foxDraw, int x)
        {
            foxDraw.StrokeColor(Colors.ForestGreen);

            for (int i = 0; i < 600; i += x)
            {
                foxDraw.DrawLine(0+i,0,600,25+i,5);
            }
            foxDraw.StrokeColor(Colors.Purple);
            for (int i = 0; i < 600; i += x)
            {
                foxDraw.DrawLine(0 , 0+i, x+i,600, 5);
            }
        }
    }
}

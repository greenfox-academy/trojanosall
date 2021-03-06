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
using GreenFox;

namespace PurpleSteps
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);

            PurpleSteps(foxDraw);

        }

        private void PurpleSteps(FoxDraw foxDraw)
        {
            for (int i = 0; i < 19; i++)
            {
                double a = 10;
                double x1 = 0 + i * a;
                double y1 = 0 + i * a;
                

                foxDraw.FillColor(Colors.Purple);
                foxDraw.DrawRectangle(x1, y1, a, a);
            }
            
            
        }
    }
}

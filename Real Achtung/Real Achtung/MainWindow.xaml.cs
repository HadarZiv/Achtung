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

namespace Real_Achtung
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TryMe();
        }

        private void TryMe()
        {
            Random r = new Random();
            int x = r.Next(1, 500);
            int y = r.Next(1, 500);
            for (int i = 0; i <= 5; i++)
            {
                Ellipse e = new Ellipse();
                e.Fill = Brushes.Yellow;
                e.Height = 10;
                e.Width = 10;
                Canvas.SetTop(e, y);
                Canvas.SetLeft(e, x);
                MyCanvas.Children.Add(e);
            }

        }
    }
}

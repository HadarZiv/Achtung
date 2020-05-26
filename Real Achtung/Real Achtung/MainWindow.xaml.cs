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
        List<Player> players;
        public MainWindow()
        {
            InitializeComponent();
            TryMe();
        }

        private void TryMe()
        {
            players = new List<Player>();
            players.Add(new Player('w', 'r', "hadar", "#FF0000"));
            players.Add(new Player('g', 'h', "kobi", "#00FF00"));
            Random r = new Random();

            for (int i = 0; i < players.Count; i++)
            {
                int x = r.Next(1, 500);
                int y = r.Next(1, 500);
                Ellipse e = new Ellipse();
                e.Height = 10;
                e.Width = 10;
                if (i == 0)
                {
                    e.Fill = Brushes.Yellow;
                }
                else
                    e.Fill = Brushes.Blue;
                Canvas.SetTop(e, y);
                Canvas.SetLeft(e, x);
                MyCanvas.Children.Add(e);
            }


        }
        public class Player
        {
            int points;
            char left;
            char right;
            string name;
            string color;
            public Player(char l, char r, string name, string color)
            {
                this.left = l;
                this.right = r;
                this.name = name;
                this.color = color;
                this.points = 0;
            }
        }
    }
}

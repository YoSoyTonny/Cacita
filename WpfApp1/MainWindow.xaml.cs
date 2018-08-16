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

namespace WpfApp1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            plnLinea.Points.Add(new Point(200.0, 200.0));
            plnLinea.Points.Add(new Point(400.0, 200.0));
            plnLinea.Points.Add(new Point(300.0, 100.0));
            plnLinea.Points.Add(new Point(200.0, 200.0));

            plnLinea2.Points.Add(new Point(210.0, 200.0));
            plnLinea2.Points.Add(new Point(210.0, 290.0));
            plnLinea2.Points.Add(new Point(389.0, 290.0));
            plnLinea2.Points.Add(new Point(389.0, 200.0));

            plnLinea3.Points.Add(new Point(330.0, 205.0));
            plnLinea3.Points.Add(new Point(330.0, 250.0));
            plnLinea3.Points.Add(new Point(375.0, 250.0));
            plnLinea3.Points.Add(new Point(375.0, 205.0));
            plnLinea3.Points.Add(new Point(330.0, 205.0));

            plnLinea4.Points.Add(new Point(280.0, 290.0));
            plnLinea4.Points.Add(new Point(280.0, 230.0));
            plnLinea4.Points.Add(new Point(240.0, 230.0));
            plnLinea4.Points.Add(new Point(240.0, 290.0));

            plnLinea5.Points.Add(new Point(500.0, 290.0));
            plnLinea5.Points.Add(new Point(500.0, 200.0));
            plnLinea5.Points.Add(new Point(530.0, 200.0));
            plnLinea5.Points.Add(new Point(530.0, 290.0));
            plnLinea5.Points.Add(new Point(500.0, 290.0));

            plnLinea6.Points.Add(new Point(500.0, 220.0));
            plnLinea6.Points.Add(new Point(460.0, 160.0));
            plnLinea6.Points.Add(new Point(460.0, 110.0));
            plnLinea6.Points.Add(new Point(500.0, 50.0));
            plnLinea6.Points.Add(new Point(535.0, 50.0));
            plnLinea6.Points.Add(new Point(570.0, 110.0));
            plnLinea6.Points.Add(new Point(570.0, 160.0));
            plnLinea6.Points.Add(new Point(530.0, 220.0));

            for(float i=0; i<=360; i++)
            {
                plnLinea7.Points.Add(new Point(Math.Cos(i) * 50 + 100, Math.Sin(i) * 50 + 100));
            }

            plnLinea8.Points.Add(new Point(30.0, 300.0));
            plnLinea8.Points.Add(new Point(50.0, 290.0));
            plnLinea8.Points.Add(new Point(80.0, 300.0));
            plnLinea8.Points.Add(new Point(100.0, 290.0));
            plnLinea8.Points.Add(new Point(120.0, 300.0));
            plnLinea8.Points.Add(new Point(150.0, 290.0));
            plnLinea8.Points.Add(new Point(180.0, 300.0));

        }
    }
}

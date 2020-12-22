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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DoubleAnimation da = new DoubleAnimation(360, 0, new Duration(TimeSpan.FromSeconds(9)));
            RotateTransform rt = new RotateTransform();
            Rotate.RenderTransform = rt;
            Rotate.RenderTransformOrigin = new Point(0.5, 0.5);
            da.RepeatBehavior = RepeatBehavior.Forever;
            rt.BeginAnimation(RotateTransform.AngleProperty, da);
        }

        private void Zero_Click(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text + "0";
     
        }

        private void Point_Click(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text + ".";
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            screen.Text =" ";
        }

        private void One_Click(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text + "1";
        }

        private void Two_Click(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text + "2";
        }

        private void Three_Click(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text + "3";
        }

        private void Four_Click(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text + "4";
        }

        private void Five_Click(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text + "5";
        }

        private void Six_Click(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text + "6";
        }

        private void Seven_Click(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text + "7";
        }

        private void Eight_Click(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text + "8";
        }

        private void Nine_Click(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text + "9";
        }

        private void LPar_Click(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text + "(";
        }

        private void RPar_Click(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text + ")";
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text + "+";
        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text + "-";
        }

        private void Mul_Click(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text + "*";
        }

        private void Div_Click(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text + "/";
        }

        private void Result_Click(object sender, RoutedEventArgs e)
        {
            Type scriptType = Type.GetTypeFromCLSID(Guid.Parse("0E59F1D5-1FBE-11D0-8FF2-00A0D10038BC"));
            dynamic obj = Activator.CreateInstance(scriptType, false);
            obj.Language = "javascript";
            string str = null;

            try
            {
                var res = obj.Eval(screen.Text);
                str = Convert.ToString(res);
                screen.Text = screen.Text + "=" + str;

            }
            catch(Exception)
            {
                screen.Text = "Syntax Error";

            }
           
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            if (screen.Text != "")
                screen.Text = screen.Text.Remove(screen.Text.Length - 1);
        }
    }
}

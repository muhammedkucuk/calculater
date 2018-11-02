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
namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        long n1 = 0, n2 = 0;
        string opr = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        public void numaraYaz(long x)
        {
            if (opr == "")
            {
                n1 = n1 * 10 + x;
                result.Text = n1.ToString();
            }
            else
            {
                n2 = n2 * 10 + x;
                result.Text = n2.ToString();
            }
        }

        public void opsel()
        {
            switch (opr)
            {
                case "+":
                    n1 += n2; n2 = 0; opr="";
                    result.Text = n1.ToString();
                    break;
                case "-":
                    n1 -= n2; n2 = 0; opr="";
                    result.Text = n1.ToString();
                    break;
                case "*":
                    n1 *= n2; n2 = 0; opr="";
                    result.Text = n1.ToString();
                    break;
                case "/":
                    if (n2 != 0)
                    {
                        n1 /= n2; n2 = 0; opr = "";
                        result.Text = n1.ToString();
                    }
                    else
                    {
                        result.Text = "error!";
                        n1 = 0; n2 = 0; opr = "";
                    }
                    break;
            }
        }

        private void zero_Click(object sender, RoutedEventArgs e)
        {

            long c = Convert.ToInt64(((Button)sender).Content);
            numaraYaz(c);
        }

        private void zeros_Click(object sender, RoutedEventArgs e)
        {
            if (opr == "")
            {
                n1 = n1 * 100;
                result.Text = n1.ToString();
            }
            else
            {
                n2 = n2 * 100;
                result.Text = n2.ToString();
            }
        }

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            opsel();
            opr = Convert.ToString(((Button)sender).Content);
        }

        private void negate_Click(object sender, RoutedEventArgs e)
        {
            if (opr == "")
            {
                n1 = n1 * -1;
                result.Text = n1.ToString();
            }
            else
            {
                n2 = n2 * -1;
                result.Text = n2.ToString();
            }
        }

        private void equal_Click(object sender, RoutedEventArgs e)
        {
            opsel();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            if (opr == "")
            {
                n1 = n1 / 10;
                result.Text = n1.ToString();
            }
            else
            {
                n2 = n2 / 10;
                result.Text = n2.ToString();
            }
        }

        private void ce_Click(object sender, RoutedEventArgs e)
        {
            if (opr == "")
            {
                n1 = 0;
                result.Text = n1.ToString();
            }
            else
            {
                n2 = 0;
                result.Text = n2.ToString();
            }
        }

        private void result_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void c_Click(object sender, RoutedEventArgs e)
        {
            n1 = 0; n2 = 0; opr = "";
            result.Text = "0";
        }
    }
}
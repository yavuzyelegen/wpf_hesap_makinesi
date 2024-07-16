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

namespace MyProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        int _deger1 = 0;
        int _deger2 = 0;
        char _islem;

        private void rakam1Btn_Click(object sender, RoutedEventArgs e)
        {
            if (ekranLabel.Content.ToString() == "0")
            {
                ekranLabel.Content = "";
            }
            ekranLabel.Content += "1";
        }

        private void rakam2Btn_Click(object sender, RoutedEventArgs e)
        {
            if (ekranLabel.Content.ToString() == "0")
            {
                ekranLabel.Content = "";
            }
            ekranLabel.Content += "2";
        }

        private void rakam3Btn_Click(object sender, RoutedEventArgs e)
        {
            if (ekranLabel.Content.ToString() == "0")
            {
                ekranLabel.Content = "";
            }
            ekranLabel.Content += "3";
        }

        private void rakam4Btn_Click(object sender, RoutedEventArgs e)
        {
            if (ekranLabel.Content.ToString() == "0")
            {
                ekranLabel.Content = "";
            }
            ekranLabel.Content += "4";
        }

        private void rakam5Btn_Click(object sender, RoutedEventArgs e)
        {
            if (ekranLabel.Content.ToString() == "0")
            {
                ekranLabel.Content = "";
            }
            ekranLabel.Content += "5";
        }

        private void rakam6Btn_Click(object sender, RoutedEventArgs e)
        {
            if (ekranLabel.Content.ToString() == "0")
            {
                ekranLabel.Content = "";
            }
            ekranLabel.Content += "6";
        }

        private void rakam7Btn_Click(object sender, RoutedEventArgs e)
        {
            if (ekranLabel.Content.ToString() == "0")
            {
                ekranLabel.Content = "";
            }
            ekranLabel.Content += "7";
        }

        private void rakam8Btn_Click(object sender, RoutedEventArgs e)
        {
            if (ekranLabel.Content.ToString() == "0")
            {
                ekranLabel.Content = "";
            }
            ekranLabel.Content += "8";
        }

        private void rakam9Btn_Click(object sender, RoutedEventArgs e)
        {
            if (ekranLabel.Content.ToString() == "0")
            {
                ekranLabel.Content = "";
            }
            ekranLabel.Content += "9";
        }

        private void rakam0Btn_Click(object sender, RoutedEventArgs e)
        {
            if (ekranLabel.Content.ToString() == "0")
            {
                ekranLabel.Content = "";
            }
            ekranLabel.Content += "0";
        }

        private void artiBtn_Click(object sender, RoutedEventArgs e)
        {
            _deger1 = Convert.ToInt32(ekranLabel.Content);
            _islem = '+';
            ekranLabel.Content = "0";
        }

        private void eksiBtn_Click(object sender, RoutedEventArgs e)
        {
            _deger1 = Convert.ToInt32(ekranLabel.Content);
            _islem = '-';
            ekranLabel.Content = "0";
        }

        private void carpiBtn_Click(object sender, RoutedEventArgs e)
        {
            _deger1 = Convert.ToInt32(ekranLabel.Content);
            _islem = '*';
            ekranLabel.Content = "0";
        }

        private void bolBtn_Click(object sender, RoutedEventArgs e)
        {
            _deger1 = Convert.ToInt32(ekranLabel.Content);
            _islem = '/';
            ekranLabel.Content = "0";
        }

        private void esittirBtn_Click(object sender, RoutedEventArgs e)
        {
            _deger2 = Convert.ToInt32(ekranLabel.Content);
            if (_islem == '+') { _deger1 += _deger2; }
            else if (_islem == '-') { _deger1 -= _deger2; }
            else if (_islem == '*') { _deger1 *= _deger2; }
            else if (_islem == '/') { _deger1 /= _deger2; }
            ekranLabel.Content = _deger1;
            _islem = ' ';
            _deger1 = 0;
        }

        private void silBtn_Click(object sender, RoutedEventArgs e)
        {
            _deger1 = 0;
            ekranLabel.Content = "0";
            _islem = ' ';
        }
    }
}

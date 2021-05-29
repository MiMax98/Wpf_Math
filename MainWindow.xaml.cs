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

namespace WpfMat
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

        private void btnSuma_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                float x = float.Parse(txtBox1.Text);
                float y = float.Parse(txtBox2.Text);
                lblWynik.Content = (x + y);
            }
            catch (Exception)
            {
                MessageBox.Show("Podano błędne dane!", "Uwaga!");
            }
        }

        private void btnRoznica_Click(object sender, RoutedEventArgs e)
        {
            try
            { 
            float x = float.Parse(txtBox1.Text);
            float y = float.Parse(txtBox2.Text);
            lblWynik.Content = (x - y);
            }
            catch (Exception)
            {
                MessageBox.Show("Podano błędne dane!", "Uwaga!");
            }
        }

        private void btnIloczyn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                float x = float.Parse(txtBox1.Text);
                float y = float.Parse(txtBox2.Text);
                lblWynik.Content = (x * y);
            }
            catch (Exception)
            {
                MessageBox.Show("Podano błędne dane!", "Uwaga!");
            }
        }

        private void btnIloraz_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                float x = float.Parse(txtBox1.Text);
                float y = float.Parse(txtBox2.Text);
                if (y == 0)
                {
                    MessageBox.Show("Nie można dzielić przez 0!", "Uwaga!");
                }
                else
                {
                    lblWynik.Content = (x / y);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Podano błędne dane!", "Uwaga!");
            }
        }
    }
}

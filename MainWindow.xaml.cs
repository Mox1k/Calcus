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

namespace Calcus
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.z1.PreviewTextInput += new TextCompositionEventHandler(textBox_PreviewTextInput);
            this.z2.PreviewTextInput += new TextCompositionEventHandler(textBox_PreviewTextInput);
        }

        public void Plus(object sender, RoutedEventArgs e)
        {
            var znac1 = z1.Text;

            var znac2 = z2.Text;

            var plus = Convert.ToDouble(znac1) + Convert.ToDouble(znac2);

            Result.Text = plus.ToString();
        }

        public void Delenie(object sender, RoutedEventArgs e)
        {
            var znac1 = z1.Text;

            var znac2 = z2.Text;

            var Delenie = Convert.ToDouble(znac1) / Convert.ToDouble(znac2);

            Result.Text = Delenie.ToString();
        }

        void textBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0) && e.Text != ",") 
                e.Handled = true;
        }
    }
}

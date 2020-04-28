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

namespace Q5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int clickCount = 0;
        private int evenCount = 0;
        private int oddCount = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

       

        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.clickCount++;

            if (this.clickCount % 2 == 0)
            {
                even.Header = $"Even : {evenCount}";
            }
            else
            {
                odd.Header = $"Odd : {oddCount}";
            }

            //treeView.UpdateLayout();
        }
    }
}

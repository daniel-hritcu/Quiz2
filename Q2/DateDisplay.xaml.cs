using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Shapes;

namespace Q2
{
    /// <summary>
    /// Interaction logic for DateDisplay.xaml
    /// </summary>
    public partial class DateDisplay : Window
    {
        public DateDisplay()
        {
            InitializeComponent();
        }

        public DateDisplay(string dateToShow)
        {
            InitializeComponent();
            //assign date to Label
            try
            {
                showDateLabel.Content = dateToShow;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
           
        }
    }
}

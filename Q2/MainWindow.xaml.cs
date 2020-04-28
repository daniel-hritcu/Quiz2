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

namespace Q2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string selectedDate;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void calendarDate_Selected(object sender, RoutedEventArgs e)
        {
            var cal = sender as Calendar;
            
            // If date is selected
            if (cal.SelectedDate.HasValue)
            {
                // get selected date
                DateTime date = calendar.SelectedDate.Value;
                // save in var
                this.selectedDate = date.ToShortDateString();
            }
        }

        private void showDateButton_Click(object sender, RoutedEventArgs e)
        {
            if (selectedDate != null) 
            {
                DateDisplay dateDisplay = new DateDisplay(selectedDate);
                dateDisplay.Show();
            }
        }
    }
}

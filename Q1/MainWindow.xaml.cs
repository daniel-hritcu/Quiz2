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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Q1
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

        //reset button
        private void resetButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                foreach (Control control in grid.Children)
                {
                    if (control is TextBox)
                    {
                        TextBox textBox = control as TextBox;
                        textBox.Text = "";
                    }
                }
            }
            catch (Exception  ex)
            {
                Debug.WriteLine(ex);
            }
        }

        //save button
        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox title
            string title = "Form Content";

            //MessageBox content
            string message =    $"{this.firstNameLabel.Name}   : {this.firstNameTextBox.Text} \n" +
                                $"{this.lastNameLabel.Name}    : {this.lastNameTextBox.Text} \n" +
                                $"{this.phoneNumberLabel.Name} : {this.phoneNumberTextBox.Text}";

            //Show MessageBox
            MessageBox.Show(message, title);
        }
    }
}

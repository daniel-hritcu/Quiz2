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

namespace Q4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {

        private List<Student> studentList;
        public MainWindow()
        {
            InitializeComponent();

            //add students
            studentList = new List<Student>();
            
            //generate student list
            for (int i = 1; i < 6; i++) {
                studentList.Add(new Student(i, $"test{i}"));
            }
        }

        private void isInList() { 
        
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text != null || textBox.Text != "" ) {

                int.TryParse(textBox.Text, out int studentId);

                Student foundStudent = studentList.SingleOrDefault(s => s.id == studentId);

                if (foundStudent != null)
                {
                    if (listBox.Items.Cast<String>().Any(x => x == foundStudent.name))
                    {
                        MessageBox.Show("In list!", "Info");

                    }
                    else
                    {
                        MessageBox.Show("Not in list!", "Info");
                    }
                    //add student to list
                    listBox.Items.Add(foundStudent.name);
                }
                else
                {
                    MessageBox.Show("Id does not exist!", "Info");
                }

                
            }
        }
    }
}

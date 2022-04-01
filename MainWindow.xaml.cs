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

namespace Calendar
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> tasks = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
            string aktualna_data = DateTime.Today.ToShortDateString();
            string tmp = "Zadania do wykonania w dniu: " + aktualna_data;
            label1.Content = tmp;
        }


        private void Create_task(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.ShowDialog();
            tasks.Add(window1.new_task.Text);
            list_of_tasks.ItemsSource = tasks;
            list_of_tasks.Items.Refresh();
        }
    }
}

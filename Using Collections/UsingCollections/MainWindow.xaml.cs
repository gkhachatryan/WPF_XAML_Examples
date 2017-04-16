using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace UsingCollections
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<string> list = new ObservableCollection<string>();
        public MainWindow()
        {
            InitializeComponent();
            string[] arr = { "Add Date Time Now :)" };
            foreach (string item in arr)
            {
                list.Add(item);
            }

            listboxname.ItemsSource = list;
        }

        private void buttonname_Click(object sender, RoutedEventArgs e)
        {
            list.Add(DateTime.Now.ToLongTimeString());
        }
    }
}

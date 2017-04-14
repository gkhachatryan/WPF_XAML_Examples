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

namespace LoginPassword
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

        private void buttonname_Click(object sender, RoutedEventArgs e)
        {
            if((loginname.Text == string.Empty && passwordname.Password == string.Empty) || (passwordname.Password.Length<=4 && passwordname.Password.Length>=15))
            {
                MessageBox.Show("Please correctly enter the Login or Password");
            }
            else
            {
                MessageBox.Show("Hello " + loginname.Text + "!!!" + " \nYour login and password have been saved!!! ");
            }
        }
    }
}

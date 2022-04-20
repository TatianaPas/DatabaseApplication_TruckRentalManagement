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
using AssignmentProject_TatianaPasechnik.View;

namespace AssignmentProject_TatianaPasechnik
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

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            
            if (usernameTextBox.Text == "admin")
            {
                adminDashboardNew form = new adminDashboardNew();
                form.Show();
                this.Hide();
            }else if(usernameTextBox.Text =="user")
            {
                userDashboardNew form = new userDashboardNew();
                form.Show();
                this.Hide();
            }
            
            
        }
    }
}

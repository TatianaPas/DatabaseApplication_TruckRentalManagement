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
using System.Windows.Shapes;

namespace AssignmentProject_TatianaPasechnik.View
{
    /// <summary>
    /// Interaction logic for userDashboardNew.xaml
    /// </summary>
    public partial class userDashboardNew : Window
    {
        public userDashboardNew()
        {
            InitializeComponent();
        }

        private void logoutBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow form= new MainWindow();
            this.Hide();
            form.Show();
        }
    }
}

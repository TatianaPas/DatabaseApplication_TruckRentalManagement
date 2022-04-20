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
using AssignmentProject_TatianaPasechnik.View;
using AssignmentProject_TatianaPasechnik.Models.DB;

namespace AssignmentProject_TatianaPasechnik.View
{
    /// <summary>
    /// Interaction logic for adminDashboardNew.xaml
    /// </summary>
    public partial class adminDashboardNew : Window
    {
        public adminDashboardNew()
        {
            InitializeComponent();
        }

        private void logoutBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow form = new MainWindow();
            form.Show();
            this.Hide();
        }
    }
}

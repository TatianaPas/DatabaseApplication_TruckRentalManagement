using System;
using System.Collections.Generic;
using System.Globalization;
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
    /// Interaction logic for responsivness_trial.xaml
    /// </summary>
    public partial class responsivness_trial : Window
    {
        public class WpConverter : IValueConverter
        {
            public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
            {
                return Int32.Parse(value.ToString()) - 200;
            }

            

            public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
            {
                throw new NotImplementedException();
            }

            
        }
        public responsivness_trial()
        {
            InitializeComponent();
        }
    }
}

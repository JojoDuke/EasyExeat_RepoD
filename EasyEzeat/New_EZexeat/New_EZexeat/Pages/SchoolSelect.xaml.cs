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

namespace New_EZexeat.Pages
{
    /// <summary>
    /// Interaction logic for SchoolSelect.xaml
    /// </summary>
    public partial class SchoolSelect : UserControl
    {
        public SchoolSelect()
        {
            InitializeComponent();
        }

        private void Owass_Click(object sender, RoutedEventArgs e)
        {
            Controls.SchoolDetails schoolDetails = new Controls.SchoolDetails();

            detailsGrid.Children.Clear();
            detailsGrid.Children.Add(schoolDetails);

            schoolA.IsChecked = false;
        }

        private void SchoolA_Click(object sender, RoutedEventArgs e)
        {
            owass.IsChecked = false;
        }

        private void AddSchool_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

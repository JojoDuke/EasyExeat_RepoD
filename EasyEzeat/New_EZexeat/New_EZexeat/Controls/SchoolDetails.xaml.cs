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

namespace New_EZexeat.Controls
{
    /// <summary>
    /// Interaction logic for SchoolDetails.xaml
    /// </summary>
    public partial class SchoolDetails : UserControl
    {
        public SchoolDetails()
        {
            InitializeComponent();
        }

        private void Slogan_IsKeyboardFocusedChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            slogan.Text = null;
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            schoolName.IsEnabled = true;
            schoolMobile.IsEnabled = true;
            poBox.IsEnabled = true;
            Email.IsEnabled = true;
            webSite.IsEnabled = true;
        }
    }
}

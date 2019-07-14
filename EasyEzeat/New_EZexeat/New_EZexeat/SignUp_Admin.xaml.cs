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

namespace New_EZexeat
{
    /// <summary>
    /// Interaction logic for SignUp_Admin.xaml
    /// </summary>
    public partial class SignUp_Admin : Page
    {
        public SignUp_Admin()
        {
            InitializeComponent();
        }

        private void BkBtnAdminSignUp_Click(object sender, RoutedEventArgs e)
        {
            var SignUp_Admin = new User_Homepage();
            NavigationService.Navigate(SignUp_Admin);
        }

        private void Supadmin_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

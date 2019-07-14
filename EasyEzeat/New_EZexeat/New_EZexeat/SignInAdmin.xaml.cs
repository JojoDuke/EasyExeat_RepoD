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
    /// Interaction logic for SignInAdmin.xaml
    /// </summary>
    public partial class SignInAdmin : Page
    {
        public SignInAdmin()
        {
            InitializeComponent();
        }

        private void BkBtnAdmin_Click(object sender, RoutedEventArgs e)
        {
            var SignInAdmin = new Page();
            NavigationService.Navigate(SignInAdmin);
        }

        private void Siadmin_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SignupBtnAdmin_Click(object sender, RoutedEventArgs e)
        {
            var SignUp_Admin = new SignUp_Admin();
            NavigationService.Navigate(SignUp_Admin);


        }
    }
}

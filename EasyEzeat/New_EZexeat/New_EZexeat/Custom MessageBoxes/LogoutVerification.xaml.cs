using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using static New_EZexeat.User_Homepage;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace New_EZexeat.Custom_MessageBoxes
{
    /// <summary>
    /// Interaction logic for LogoutVerification.xaml
    /// </summary>
    public partial class LogoutVerification : Window
    {
       

        public LogoutVerification()
        {
            InitializeComponent();
        }

        private void YesLogoutBtn_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        private void NoLogoutBtn(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

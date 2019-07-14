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
using static New_EZexeat.Custom_MessageBoxes.LogoutVerification;
using System.Windows.Navigation;
using System.Data.SqlClient;
using Microsoft.Win32;
using System.Data.Sql;
using System.Data;
using System.Windows.Shapes;

namespace New_EZexeat
{
    /// <summary>
    /// Interaction logic for User_Homepage.xaml
    /// </summary>
    public partial class User_Homepage : Page
    {
        string connectionString = @"Data Source=HP;Initial Catalog=User_SignUpDB;Integrated Security=True;";

        public User_Homepage()
        {
            InitializeComponent();

            Pages.UHP hP = new Pages.UHP();
            GridPrincipal.Children.Add(hP); 
        }

        

        public void UserLogoutBtn_Click(object sender, RoutedEventArgs e)
        {

            Custom_MessageBoxes.LogoutVerification dialog = new Custom_MessageBoxes.LogoutVerification();

            // Returns when the dialog window was closed
            bool? dialogResult = dialog.ShowDialog();

            if (dialogResult.Value)
            {
                // Ok was clicked
                var mainWin = new Page();
                NavigationService.Navigate(mainWin);
            }
            else
            {
                // Cancel was clicked or the window was closed
            }
            
        }

        private void HomeBtn_Click(object sender, RoutedEventArgs e)
        {
            takeExeatBtn.IsChecked = false;
            homeBtn.IsChecked = true;
            messagesBtn.IsChecked = false;

            GridPrincipal.Children.Add(new Pages.UHP());
            
        }

        public void TakeExeatBtn_Click(object sender, RoutedEventArgs e)
        {
            takeExeatBtn.IsChecked = true;
            homeBtn.IsChecked = false;
            messagesBtn.IsChecked = false;

            
           GridPrincipal.Children.Add(new Pages.TakeExeatPage());
        }

        private void MessagesBtn_Click(object sender, RoutedEventArgs e)
        {
            takeExeatBtn.IsChecked = false;
            homeBtn.IsChecked = false;
            messagesBtn.IsChecked = true;

            
            GridPrincipal.Children.Add(new Pages.CheckMessagesPage());
        }
    }
}

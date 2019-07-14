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
    /// Interaction logic for Admin_Homepage.xaml
    /// </summary>
    public partial class Admin_Homepage : Page
    {
        public Admin_Homepage()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            var Main = new Page();
            NavigationService.Navigate(Main);
        }

        private void Students_Click(object sender, RoutedEventArgs e)
        {
            about.IsChecked = false;
            help.IsChecked = false;
            hsemasters.IsChecked = false;
            students.IsChecked = true;
            school.IsChecked = false;

            contentGrid.Children.Clear();
            contentGrid.Children.Add(new Pages.StudentsDB());
        }

        private void School_Click(object sender, RoutedEventArgs e)
        {
            about.IsChecked = false;
            help.IsChecked = false;
            hsemasters.IsChecked = false;
            students.IsChecked = false;
            school.IsChecked = true;

            contentGrid.Children.Clear();
            contentGrid.Children.Add(new Pages.SchoolSelect());
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            about.IsChecked = true;
            help.IsChecked = false;
            hsemasters.IsChecked = false;
            students.IsChecked = false;
            school.IsChecked = false;

            contentGrid.Children.Clear();
            contentGrid.Children.Add(new Pages.AboutWindow());
        }

        private void Hsemasters_Click(object sender, RoutedEventArgs e)
        {
            about.IsChecked = false;
            help.IsChecked = false;
            hsemasters.IsChecked = true;
            students.IsChecked = false;
            school.IsChecked = false;

            contentGrid.Children.Clear();
            contentGrid.Children.Add(new Pages.Housemaster_Window());
        }

        private void Help_Click(object sender, RoutedEventArgs e)
        {
            about.IsChecked = false;
            help.IsChecked = true;
            hsemasters.IsChecked = false;
            students.IsChecked = false;
            school.IsChecked = false;

            contentGrid.Children.Clear();
            contentGrid.Children.Add(new Pages.HelpWindow());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace New_EZexeat.Custom_MessageBoxes
{
    /// <summary>
    /// Interaction logic for AddUserDetails.xaml
    /// </summary>
    public partial class AddUserDetails : Window
    {
        public AddUserDetails()
        {
            InitializeComponent();
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            Pages.UHP uHP = new Pages.UHP();


            //Close();
        }
    }
}

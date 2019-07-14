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
using System.Windows.Forms;
using System.Windows.Shapes;

namespace New_EZexeat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void BtnClickP1(object sender, RoutedEventArgs e)
        {

            mainFrame.Content = new Page1();
            
        }

        private void MainFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void AdminBtn_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Content = new Admin_Homepage();
        }
    }
}

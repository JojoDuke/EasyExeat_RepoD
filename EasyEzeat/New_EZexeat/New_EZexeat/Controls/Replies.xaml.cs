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
    /// Interaction logic for Replies.xaml
    /// </summary>
    public partial class Replies : UserControl
    {
        public Replies()
        {
            InitializeComponent();
            DnTSent.Text = DateTime.Now.ToString();
        }

        private void PrintIt_Click(object sender, RoutedEventArgs e)
        {
            ExeatSlip exeatSlip = new ExeatSlip();
            exeatSlip.Show();
        }
    }
}

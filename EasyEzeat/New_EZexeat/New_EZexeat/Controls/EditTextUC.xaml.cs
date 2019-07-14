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
using System.Windows.Media.Animation;

namespace New_EZexeat.Controls
{
    /// <summary>
    /// Interaction logic for EditTextUC.xaml
    /// </summary>
    public partial class EditTextUC : UserControl
    {
        public EditTextUC()
        {
            InitializeComponent();
        }

        private void EditButton(object sender, RoutedEventArgs e)
        {
            religionTB.IsEnabled = true;
            medical.IsEnabled = true;
            allergies.IsEnabled = true;
            religionTB.IsEnabled = true;
            other.IsEnabled = true;
            genderTxt.IsEnabled = true;
            bloodTxt.IsEnabled = true;
            datePicker.IsEnabled = true;

            DoubleAnimation fade = new DoubleAnimation(1,TimeSpan.FromSeconds(0.2));

            religionTB.BeginAnimation(OpacityProperty, fade);
            medical.BeginAnimation(OpacityProperty, fade);
            allergies.BeginAnimation(OpacityProperty, fade);
            other.BeginAnimation(OpacityProperty, fade);
            genderTxt.BeginAnimation(OpacityProperty, fade);
            bloodTxt.BeginAnimation(OpacityProperty, fade);
            datePicker.BeginAnimation(OpacityProperty, fade);
        }

        private void SaveButton(object sender, RoutedEventArgs e)
        {
            religionTB.IsEnabled = false;
            medical.IsEnabled = false;
            allergies.IsEnabled = false;
            religionTB.IsEnabled = false;
            other.IsEnabled = false;
            genderTxt.IsEnabled = false;
            bloodTxt.IsEnabled = false;
            datePicker.IsEnabled = false;
        }
    }
}

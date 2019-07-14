using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
using MaterialDesignThemes;
using System.Windows.Shapes;
using System.Windows.Media.Effects;
using System.IO;

namespace New_EZexeat.Pages
{
    /// <summary>
    /// Interaction logic for UHP.xaml
    /// </summary>
    public partial class UHP : UserControl
    {
        string connectionString = @"Data Source=HP;Initial Catalog=User_SignUpDB;Integrated Security=True;";
        

        public UHP()
        {
            InitializeComponent();
            
            /*
            Page1 p1 = new Page1();
            var pls = p1.tbID.Text;
            
            SqlConnection sqlCon = new SqlConnection(connectionString);
            sqlCon.Open();

            string query = "SELECT * FROM tblSignUP WHERE StudentName = StudentName and HouseName = HouseName";
            SqlCommand createCommand = new SqlCommand(query, sqlCon);

            
            SqlDataReader dr = createCommand.ExecuteReader();
            if (dr.Read())
            {
                nameTxt.Text = (dr["StudentName"].ToString());
                hseTxt.Text = (dr["HouseName"].ToString());
                progTxt.Text = (dr["Prog"].ToString());
            }
            

            sqlCon.Close();
            */
            
        }

        private void LoadImgBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Select your picture";
            op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
                "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
                "Portable Network Graphic (*.png)|*.png";
            if (op.ShowDialog() == true)
            {
                brushImg.ImageSource = new BitmapImage(new Uri(op.FileName));
            }
            
        }

        private void BorderBtn_Click(object sender, RoutedEventArgs e)
        {

            Controls.EditTextUC textUC = new Controls.EditTextUC();
            gridz.Children.Add(textUC);
            borderBtn.Visibility = Visibility.Collapsed;
            borderBtn.Cursor = null;
            borderBtn.IsEnabled = false;
        }
    }
}

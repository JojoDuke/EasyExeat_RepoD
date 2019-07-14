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
using System.Data.SqlClient;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Media.Effects;
using New_EZexeat.FingerprintCode;

namespace New_EZexeat
{
    /// <summary>
    /// Interaction logic for Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        string connectionString = @"Data Source=HP;Initial Catalog=User_SignUpDB;Integrated Security=True;";
        public Page2()
        {
            InitializeComponent();
            StaticFarm.Label = this.LBLSTATUS;
            StaticFarm.Button = this.ErnollBtn;
        }


        private void BkBtn_Click(object sender, RoutedEventArgs e)
        {
            var page1 = new Page1();
            NavigationService.Navigate(page1);
        }

        private void SiBtn_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void SubmitBtn_Click(object sender, RoutedEventArgs e)
        {
            if (tbStudentName.Text == "" || pbPassword.Password == "" || tbSchoolName.Text == "" || tbHouseName.Text == ""
                || tbProg.Text == "" || tbPhoneNumber.Text == "" || tbAddress.Text == "")
            {
                var dim = new Dim();
                dim.Show();
                this.Effect = new BlurEffect();

                var cmb = new Custom_MessageBoxes.CustomMsgBox2();
                cmb.ShowDialog();

                this.Effect = null;
                dim.Close();
            }
            
            else
            {
                Connect obj = new Connect();
                
                obj.conn.ConnectionString = obj.locate;
                obj.conn.Open();
                string InsertUser = "INSERT INTO tblSignUp values ('"+tbStudentName.Text+ "', '" + tbSchoolName.Text + "', '" + tbHouseName.Text + "', '" + tbProg.Text + "', '" + tbPhoneNumber.Text + "', '" + tbAddress.Text + "', '" + pbPassword.Password + "', '"+StaticFarm.NewFingerBase64String+"')";
                obj.cmd.Connection = obj.conn;
                obj.cmd.CommandText = InsertUser;
                obj.cmd.ExecuteNonQuery();
                obj.conn.Close();

                var dim = new Dim();
                dim.Show();
                this.Effect = new BlurEffect();

                var cmb = new Custom_MessageBoxes.RegistrationComplete();
                cmb.ShowDialog();

                this.Effect = null;
                dim.Close();
                Clear();
            }
        }
        void Clear()
        {
            tbStudentName.Text = tbSchoolName.Text = tbHouseName.Text = tbProg.Text = tbPhoneNumber.Text = tbAddress.Text = pbPassword.Password = "";
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
                Regex regex = new Regex("[^0-9]+");
                e.Handled = regex.IsMatch(e.Text);
        }

        private void En_Click(object sender, RoutedEventArgs e)
        {
            NewFingerPrint ns = new NewFingerPrint();
            ns.ShowDialog();
        }
    }
    }

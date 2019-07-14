using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;
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
using System.Windows.Media.Effects;
using System.Diagnostics;
using New_EZexeat.FingerprintCode;

namespace New_EZexeat
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        string connectionString = @"Data Source=HP;Initial Catalog=User_SignUpDB;Integrated Security=True;";

        public Page1()
        {
            InitializeComponent();
            StaticFarm.SignInPage = this;
        }

        public void GotoHome() {
            var User_Homepage = new User_Homepage();
            NavigationService.Navigate(User_Homepage);
        }

        //Create new account button click event
        private void SignUp_Page(object sender, RoutedEventArgs e)
        {
            var page2 = new Page2();
            NavigationService.Navigate(page2);
        }

        //Back button click event
        private void BackBtnClick(object sender, RoutedEventArgs e)
        {
            var page = new Page();
            NavigationService.Navigate(page);
        }

        //Sign In button click event
        private void UserSignInBtn_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(connectionString);
            try
            {
                Connect obj = new Connect();
                obj.conn.ConnectionString = obj.locate;

                obj.conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT COUNT (*) FROM tblSignUp WHERE StudentName = '"+tbID.Text+"' AND Password = '"+PB.Password+"'", obj.conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    // Custom Message Box and Dim Effect
                    var jim = new Dim();

                    jim.Show();
                    this.Effect = new BlurEffect();

                    var lsmb = new Custom_MessageBoxes.LoginSuccessfulMsgBox();
                    lsmb.ShowDialog();

                    this.Effect = null;
                    jim.Close();

                    var User_Homepage = new User_Homepage();
                    NavigationService.Navigate(User_Homepage);
                }
                else
                {
                    // Custom Message Box and Dim Effect 2
                    var him = new Dim();

                    him.Show();
                    this.Effect = new BlurEffect();

                    var rmdlgb = new ReturnMessageDialogueBox();
                    rmdlgb.ShowDialog();

                    this.Effect = null;
                    him.Close();
                }


                obj.conn.Close();

            }
            catch(Exception ex)
            {
                using (EventLog eventlog = new EventLog("Application"))
                {
                    eventlog.Source = "SQL Error: From My Application";
                    eventlog.WriteEntry(ex.StackTrace, EventLogEntryType.Error, 101, 1);
                }
            }
            finally
            {
                sqlCon.Close();
            }
        }

        //Press Enter Function (PasswordBox)
        private void PB_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                UserSignInBtn_Click(sender, e);
            }
            
        }

        //Press Enter Function (ID TextBox)
        private void TbID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                UserSignInBtn_Click(sender, e);
            }

        }

        private void FingerPrint_Signin(object sender, RoutedEventArgs e)
        {
            LoginForm fm1 = new LoginForm();
            fm1.ShowDialog();
        }
    }
    }

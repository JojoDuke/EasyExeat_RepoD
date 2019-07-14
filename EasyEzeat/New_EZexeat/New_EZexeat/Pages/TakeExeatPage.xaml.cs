using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MessageBox = System.Windows.MessageBox;
using UserControl = System.Windows.Controls.UserControl;

namespace New_EZexeat.Pages
{
    /// <summary>
    /// Interaction logic for TakeExeatPage.xaml
    /// </summary>
    public partial class TakeExeatPage : UserControl
    {
        PrintDocument document = new PrintDocument();
        System.Windows.Forms.PrintDialog dialog = new System.Windows.Forms.PrintDialog();

        public TakeExeatPage()
        {
            InitializeComponent();
            document.PrintPage += new PrintPageEventHandler(document_PrintPage);
        }

        void document_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(contentTextBox.Text, new Font("Arial", 15), System.Drawing.Brushes.Black, 20, 20);
        }

        private void Send_Click(object sentby, RoutedEventArgs e)
        {
            String result;
            string apiKey = "7GL3uo7CbHk-mhnjD1vrlv7wNc54gbFzZM0rtpvnT8";
            string numbers = parentsNumberTB.Text; // in a comma seperated list
            string message = "Subject: " + subjectTextBox.Text + "\r\n" + contentTextBox.Text;
            string sendBy = "";

            String url = "https://api.txtlocal.com/send/?apikey=" + apiKey + "&numbers=" + numbers + "&message=" + message + "&sender=" + sendBy;
            //refer to parameters to complete correct url string

            StreamWriter myWriter = null;
            HttpWebRequest objRequest = (HttpWebRequest)WebRequest.Create(url);

            objRequest.Method = "POST";
            objRequest.ContentLength = Encoding.UTF8.GetByteCount(url);
            objRequest.ContentType = "application/x-www-form-urlencoded";
            try
            {
                myWriter = new StreamWriter(objRequest.GetRequestStream());
                myWriter.Write(url);

                MessageBox.Show("Your Exeat request has been sent!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, ex.Message, MessageBoxButton.OK, MessageBoxImage.Information);
            }
            finally
            {
                myWriter.Close();
            }

            HttpWebResponse objResponse = (HttpWebResponse)objRequest.GetResponse();
            using (StreamReader sr = new StreamReader(objResponse.GetResponseStream()))
            {
                result = sr.ReadToEnd();
                // Close and clean up the StreamReader
                sr.Close();
            }
            //return result;
        }

        private void PrintIt_Click(object sender, RoutedEventArgs e)
        {
            var jim = new Dim();

            jim.Show();
            this.Effect = new BlurEffect();

            ExeatSlip exeatSlip = new ExeatSlip();
            exeatSlip.Show();

            this.Effect = null;
            jim.Close();
        }
    }
  
}

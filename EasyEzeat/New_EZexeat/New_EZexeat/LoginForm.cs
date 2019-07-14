using New_EZexeat.FingerprintCode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace New_EZexeat
{
    public partial class LoginForm : Form
    {
        List<FingerData> fdx = new List<FingerData>();

        public LoginForm()
        {
            InitializeComponent();
            LoadFingersIn();
        }

        private DPFP.Template convertTemplate(string p)
        {
            byte[] decByte3 = Convert.FromBase64String(p);
            DPFP.Template tmp = new DPFP.Template();
            tmp.DeSerialize(decByte3);
            return tmp;
        }
        
        private void LoadFingersIn()
        {
            // Load From DB into FingerData
            Connect c = new Connect();
            SqlConnection sqlCon = new SqlConnection(c.locate);
            try
            {
                Connect obj = new Connect();
                obj.conn.ConnectionString = obj.locate;

                obj.conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM tblSignUp;", obj.conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                foreach (DataRow dr in dt.Rows) {
                    String Base64 = dr["Data"].ToString();
                    String UserID = dr["UserID"].ToString();
                    FingerData fd = new FingerData();
                    fd.id = UserID;
                    fd.finger = Base64;
                    fdx.Add(fd);
                }

                Console.Write(fdx.Count.ToString());
                obj.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot Read Fingerprint Data");
            }
            finally
            {
                sqlCon.Close();
            }
        }

        private void VerificationControl_OnComplete(object Control, DPFP.FeatureSet FeatureSet, ref DPFP.Gui.EventHandlerStatus Status)
        {
            lblStatus.Text = "Checking ...";
            // TODO: get templates and compare
            DPFP.Verification.Verification ver = new DPFP.Verification.Verification();
            DPFP.Verification.Verification.Result res = new DPFP.Verification.Verification.Result();
            FingerData last_tested = StaticFarm.lastFinger;
            foreach (FingerData fd in fdx)
            {
                DPFP.Template template = convertTemplate(fd.finger);
                if (fd.finger == String.Empty) {
                    template = null;
                }
                
                // Get template from storage.
                if (template != null)
                {
                    // Compare feature set with particular template.
                    ver.Verify(FeatureSet, template, ref res);
                    last_tested = fd;
                    if (res.Verified)
                        break; // success
                }
            }
            if (!res.Verified)
            {
                Status = DPFP.Gui.EventHandlerStatus.Failure;
                lblStatus.Text = "Authorization Failed Try again ...";
            }
            else
            {
                lblStatus.Text = "Successfully Verified.";
                Status = DPFP.Gui.EventHandlerStatus.Success;
                
                
                StaticFarm.SignInPage.GotoHome();
                this.Close();
            }
        }

        private void VerificationControl_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

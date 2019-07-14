using New_EZexeat.FingerprintCode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_EZexeat
{
    public partial class NewFingerPrint : Form
    {
        public NewFingerPrint()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (StaticFarm.NewFingerTemplate != null)
            {
                this.Close();
                StaticFarm.SaveToDB(StaticFarm.NewFingerTemplate);
                StaticFarm.Label.Visibility =  System.Windows.Visibility.Visible;
                StaticFarm.Button.Visibility = System.Windows.Visibility.Hidden;
                
            }
            else {
                MessageBox.Show("Add At least One Finger");
            }
        }

        private void EnrollmentControl_OnEnroll(object Control, int FingerMask, DPFP.Template Template, ref DPFP.Gui.EventHandlerStatus EventHandlerStatus)
        {
            StaticFarm.NewFingerTemplate = Template;
            StaticFarm.NewFingerBase64String = StaticFarm.ConvertM(Template.Bytes);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using DPFP;

namespace New_EZexeat.FingerprintCode
{
    class StaticFarm
    {
        public static string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\NewDB.mdf;Integrated Security=True;Connect Timeout=30";
        public static string NewConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\User_SignUpDB.mdf;Integrated Security=True;Connect Timeout=30";
        internal static FingerData lastFinger;

        public static string NewFingerBase64String { get; internal set; }
        public static Template NewFingerTemplate { get; internal set; }
        public static FingerData currentFinger { get; internal set; }
        public static Label Label { get; internal set; }
        public static Button Button { get; internal set; }
        public static Page1 SignInPage { get; internal set; }

        internal static string ConvertM(byte[] bytes)
        {
            string bstr = Convert.ToBase64String(bytes);
            return bstr;
        }

        internal static void SaveToDB(Template newFingerTemplate)
        {
            // 
        }
    }
}

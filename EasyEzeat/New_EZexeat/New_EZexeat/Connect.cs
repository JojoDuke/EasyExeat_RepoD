using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using New_EZexeat.FingerprintCode;

namespace New_EZexeat
{
    class Connect
    {
        public SqlConnection conn = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        //Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;
        public string locate = @"Data Source=HP;Initial Catalog=User_SignUpDB;Integrated Security=True;";
        public string new_CS = StaticFarm.NewConnectionString;
    }
}

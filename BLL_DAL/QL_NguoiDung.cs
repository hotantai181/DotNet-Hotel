using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using BLL_DAL.QLKSTableAdapters;

namespace BLL_DAL
{
    public class QL_NguoiDung
    {
        public int Check_Config()
        {
            if (Properties.Settings.Default.CNN == string.Empty)
                return 1;
            SqlConnection _Sqlconn = new SqlConnection(Properties.Settings.Default.CNN);
            try
            {
                if (_Sqlconn.State == System.Data.ConnectionState.Closed)
                    _Sqlconn.Open();
                return 0;// Thanh cong
            }
            catch
            {
                return 2;//Chuoi cau hinh ko hop le
            }
        }
        public LoginResult Check_User(string pUser, string pPass)
        {
            SqlDataAdapter daUser = new SqlDataAdapter("select * from Account where Username='" + pUser + "' and PassWord ='" + pPass + "'", Properties.Settings.Default.CNN);
            DataTable dt = new DataTable();
            daUser.Fill(dt);
            if (dt.Rows.Count == 0)
                return LoginResult.Invalid;
            else if (dt.Rows[0][2] == null || dt.Rows[0][2].ToString() == "False")
            {
                return LoginResult.Disabled;
            }
            return LoginResult.Success;
        }
    }
}

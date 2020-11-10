using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTHUVIEN
{
    class DataProvider
    {
        //xây cầu kết nối
        public static SqlConnection Connect()
        {
           
            string CTR = "Data Source=DESKTOP-H9LM095\\SQLEXPRESS;Initial Catalog=QLThuViens;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection con = new SqlConnection(CTR);
            con.InfoMessage += new SqlInfoMessageEventHandler(conn_InfoMessage);
            con.FireInfoMessageEventOnUserErrors = true;
            con.Open();
            return con;
        }
        //dùng thưực thi câu lệnh insert update delete
        public static bool ExecuteNonQuery(string CTR)
        {
            SqlCommand cmd = new SqlCommand(CTR, Connect());
            int icmd = cmd.ExecuteNonQuery();
            Connect().Close();
            if (icmd > 0) //check xem có truy vấn nào hay không
            {
                return true;
            }
            else
            {
                return false;
            }
            try//trả lại 1 biến true hặc flase để báo thực thi được truy vấn hay không
            {

            }
            catch (Exception ex)
            {

                Connect().Close();
                return false;
            }
        }

        public static DataTable ExecuteQuery(string CTR)
        {
            try// bắt lỗi khi thưực thi truy vấn
            {
                SqlDataAdapter da = new SqlDataAdapter(CTR, Connect());
                DataTable dt = new DataTable();
                da.Fill(dt);
                Connect().Close();
                return dt;
            }
            catch (Exception ex)
            {

                return null;//trả về null nêú không thực hiện được truy vấn
            }
        }

        public static string ExecuteScalar(string CTR)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(CTR, Connect());
                string kq = cmd.ExecuteScalar().ToString();
                Connect().Close();
                return kq;
            }
            catch (Exception ex)
            {
                Connect().Close();
                return null;
            }
        }

        static void conn_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {
            MessageBox.Show("InfoMessage Handled Error Level-" +
            e.Errors[0].Class.ToString() + ":" + e.Message);
        }
    }
}


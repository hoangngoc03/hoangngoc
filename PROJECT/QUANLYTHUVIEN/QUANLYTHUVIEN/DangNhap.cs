using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYTHUVIEN
{
    public partial class DangNhap : Form
    {
        QuanLyThuVienEntities1 ql = new QuanLyThuVienEntities1();
        ACCOUNT a = new ACCOUNT();
        public DangNhap()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-H9LM095\\SQLEXPRESS;Initial Catalog=QuanLyThuVien;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from ACCOUNT where TenDangNhap = '" + textBox1.Text + "' and MatKhau = '" + textBox2.Text + "'", con);
            DataTable dta = new DataTable();
            sda.Fill(dta);
            int i;
            if (dta.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                QuanLy ql1 = new QuanLy();
                ql1.ShowDialog();
                this.Show();

            }
            else
            {
                MessageBox.Show("Sai Tên Đăng Nhập Hoặc Mật Khẩu");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

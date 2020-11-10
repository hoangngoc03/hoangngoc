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

namespace QLTHUVIEN
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
            
        }
     

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
          //  string userName = txtDangNhap.Text;
           // string passWord = txtMatKhau.Text;
           // if(Login(userName,passWord))
           // {
                QLy qls = new QLy();
                this.Hide();
                qls.ShowDialog();
                this.Show();
           // }
           // else
           // {
             //   MessageBox.Show("Sai Tên Đăng Nhập Hoặc Mật Khẩu");
           // }
   // }
     //   bool Login(string userName, string passWord)
       // {
         //   return Account.Instance.Login(userName, passWord);

        }
   }
}



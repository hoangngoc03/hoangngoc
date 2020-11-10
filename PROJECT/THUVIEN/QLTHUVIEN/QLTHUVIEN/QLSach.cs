using QLTHUVIEN.Models;
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
    public partial class QLSach : Form
    {
        bool c = true;
        string cs = "Data Source=DESKTOP-H9LM095\\SQLEXPRESS;Initial Catalog=QLThuViens;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection con;
        SqlDataAdapter adapt;
        DataTable dt;
        public QLSach()
        {
            InitializeComponent();
            setNut(true);
            Load();
           
        }
      

        private void Load()
        {
            Models.ModSach tb = new Models.ModSach();
            DataTable dt = tb.docdulieu();
            dgvSach.DataSource = dt;
        }
        public void TimKiem()
        {
            Models.ModSach tb = new Models.ModSach();
            DataTable dt = tb.docdulieu();
            dgvSach.DataSource = dt.Equals("select * from SACH where TenSach like '%" + txtTenSach.Text + "%'");
            
        }
       

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void setNut(bool a)
        {
            btnThem.Enabled = a;
            btnSua.Enabled = a;
            btnXoa.Enabled = a;
            btnLuu.Enabled = !a;
            btnKluu.Enabled = !a;
        }
        private void datasach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaSach.ReadOnly = true;
            int index = dgvSach.CurrentRow.Index;
            txtMaSach.Text = dgvSach.Rows[index].Cells[0].Value.ToString();
            txtTenSach.Text = dgvSach.Rows[index].Cells[1].Value.ToString();
            txtTacGia.Text = dgvSach.Rows[index].Cells[2].Value.ToString();
            txtTheLoai.Text = dgvSach.Rows[index].Cells[3].Value.ToString();
            txtNXB.Text = dgvSach.Rows[index].Cells[4].Value.ToString();
            txtGiaBan.Text = dgvSach.Rows[index].Cells[5].Value.ToString();
            txtSoLuong.Text = dgvSach.Rows[index].Cells[6].Value.ToString();
            cbTinhTrang.Text = dgvSach.Rows[index].Cells[7].Value.ToString();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //chọn thêm thì ẩn nut sửa , xoá + xoá hết dữ liệu đang nhập
            setNut(false);
            c = true;
            txtTenSach.Clear();
            txtTacGia.Clear();
            txtTheLoai.Clear();
            txtNXB.Clear();
            txtGiaBan.Clear();
            txtSoLuong.Clear();
            cbTinhTrang.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (c == true)
            {
                ModSach them = new ModSach();
                string tensach = txtTenSach.Text;
                string tacgia = txtTacGia.Text;
                string theloai = txtTheLoai.Text;
                string nhaxuatban = txtNXB.Text;
                int giasach = int.Parse(txtGiaBan.Text);
                int soluong = int.Parse(txtSoLuong.Text);
                string tinhtrang = cbTinhTrang.Text;
                bool kq = them.ThemSach(tensach, tacgia, theloai, nhaxuatban, giasach, soluong,tinhtrang);
                if (kq == true)
                    MessageBox.Show("Thêm thành công!", "Thông báo");
                setNut(true);
                Load();// load lai du lieu vao dgv
            }
            else
            {
                ModSach Sua = new ModSach();
                int masach = int.Parse(txtMaSach.Text);
                string tensach = txtTenSach.Text;
                string tacgia = txtTacGia.Text;
                string theloai = txtTheLoai.Text;
                string nhaxuatban = txtNXB.Text;
                int giasach = int.Parse(txtGiaBan.Text);
                int soluong = int.Parse(txtSoLuong.Text);
                string tinhtrang = cbTinhTrang.Text;
                bool kq1 = Sua.SuaSach(masach, tensach, tacgia, theloai, nhaxuatban, giasach, soluong,tinhtrang);
                setNut(true);
                Load();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //sau khi chọn dòng cần xoá bấm xoá thì ẩn nút sửa và thêm
            setNut(false);
            //hiện lên message hỏi có muốn xoá hay không
            if (MessageBox.Show("Bạn Có Muốn Xoá Sách Này", "Cảnh Báo", MessageBoxButtons.OKCancel) == DialogResult.OK) 
            {
                //nếu ok thì thực hiện lệnh xoá theo mã đọc giả
                ModSach Xoa = new ModSach();
                string Ma = txtMaSach.Text;
                bool kq = Xoa.XoaSach(Ma);
                if (kq == true) 
                {
                    MessageBox.Show("Xoá Thành Công!");
                }
                Load();
                setNut(true);
                txtTenSach.Clear();
                txtTacGia.Clear();
                txtTheLoai.Clear();
                txtNXB.Clear();
                txtGiaBan.Clear();
                txtSoLuong.Clear();
                cbTinhTrang.Text = "";
               
            } 
            else
            {
                 // chọn cancel thì bật tất cả nút, xoá dữ liệu trên textbox
                 setNut(true);
                
                 txtTenSach.Clear();
                 txtTacGia.Clear();
                 txtTheLoai.Clear();
                 txtNXB.Clear();
                 txtGiaBan.Clear();
                 txtSoLuong.Clear();
                cbTinhTrang.Text = "";
            }
        }

        private void btnKluu_Click(object sender, EventArgs e)
        {
            setNut(true);
          
            txtMaSach.Clear();
            txtTenSach.Clear();
            txtTacGia.Clear();
            txtTheLoai.Clear();
            txtNXB.Clear();
            txtGiaBan.Clear();
            txtSoLuong.Clear();
            cbTinhTrang.Text = "";

        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            setNut(false);
            c = false;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            TimKiem();
          
        }

        private void QLSach_Load(object sender, EventArgs e)
        {
            string cs = "Data Source=DESKTOP-H9LM095\\SQLEXPRESS;Initial Catalog=QLThuViens;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            con = new SqlConnection(cs);
            con.Open();
            adapt = new SqlDataAdapter("select * from SACH", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dgvSach.DataSource = dt;
            con.Close();
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            con = new SqlConnection(cs);
            con.Open();
            adapt = new SqlDataAdapter("select * from SACH where TenSach like '" + txtTenSach.Text + "%'", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dgvSach.DataSource = dt;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Load();
        }
    }
}


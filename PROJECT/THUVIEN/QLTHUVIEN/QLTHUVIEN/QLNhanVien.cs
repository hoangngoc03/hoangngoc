using QLTHUVIEN.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTHUVIEN
{
    public partial class QLNhanVien : Form
    {

        bool c;
        public QLNhanVien()
        {
            InitializeComponent();
            setNut(true);
            Load();
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Load()
        {
            Models.ModNhanVien tb = new Models.ModNhanVien();
            DataTable dt = tb.docdulieu();
            dgvNhanVien.DataSource = dt;
        }

        private void setNut(bool a)
        {
            btnThem.Enabled = a;
            btnSua.Enabled = a;
            btnXoa.Enabled = a;
            btnLuu.Enabled = !a;
            btnKluu.Enabled = !a;
        }

        private void datanv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNVien.ReadOnly = true;
            int index = dgvNhanVien.CurrentRow.Index;
            txtMaNVien.Text = dgvNhanVien.Rows[index].Cells[0].Value.ToString();
            txtHoTen.Text = dgvNhanVien.Rows[index].Cells[1].Value.ToString();
            txtTenDNhap.Text = dgvNhanVien.Rows[index].Cells[2].Value.ToString();
            dtpNamSinh.Text = dgvNhanVien.Rows[index].Cells[3].Value.ToString();
            txtDiaChi.Text = dgvNhanVien.Rows[index].Cells[4].Value.ToString();
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            //chọn thêm thì ẩn nut sửa , xoá + xoá hết dữ liệu đang nhập
            setNut(false);
            c = true;
            txtHoTen.Clear();
            txtTenDNhap.Clear();
            dtpNamSinh.Value = DateTime.Now;
            txtDiaChi.Clear();
            Load();
           
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            setNut(false);
            c = false;
        }

        private void btnKluu_Click(object sender, EventArgs e)
        {
            setNut(true);
            txtMaNVien.Clear();
            txtHoTen.Clear();
            txtTenDNhap.Clear();
            dtpNamSinh.Value = DateTime.Now;
            txtDiaChi.Clear();
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //sau khi chọn dòng cần xoá bấm xoá thì ẩn nút sửa và thêm
            setNut(false);
            //hiện lên message hỏi có muốn xoá hay khôn
            if (MessageBox.Show("Bạn Có Muốn Xoá Nhân Viên Này", "Cảnh Báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                //nếu ok thì thực hiện lệnh xoá theo mã đọc giả
                ModNhanVien xoa = new ModNhanVien();
                string Ma = txtMaNVien.Text;
                bool kq = xoa.XoaNhanVien(Ma);
                if (kq == true)
                {
                    MessageBox.Show("Xoá Thành Công!");
                }
                // load lại dữ liệu set lại nút xoá dữ liện trên textbox
                Load();
                setNut(true);
                txtHoTen.Clear();
                txtTenDNhap.Clear();
                dtpNamSinh.Value = DateTime.Now;
                txtDiaChi.Clear();
               
            }
            else
            {
                // chọn cancel thì bật tất cả nút, xoá dữ liệu trên textbox
                setNut(true);

                txtHoTen.Clear();
                txtTenDNhap.Clear();
                dtpNamSinh.Value = DateTime.Now;
                txtDiaChi.Clear();
                
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // lấy dữ liệu đang nhập lưu vào database
            if (c == true)
            {
                ModNhanVien add = new ModNhanVien();
                
                dtpNamSinh.CustomFormat = "yyyy/MM/dd";// cài đặt ngày giờ của datetimepicker theo dạng của sql
                
                string hoten = txtHoTen.Text;
                string tenhienthi = txtTenDNhap.Text;
                string namsinh = dtpNamSinh.Value.ToString();
                string diachi = txtDiaChi.Text;
                bool kq = add.ThemNhanVien(hoten,tenhienthi, namsinh, diachi);
                if (kq == true)
                    MessageBox.Show("Thêm Thành Công!", "Thông Báo");
                setNut(true);
                Load();//load lại dư liêệu vào dgv
            }
            else
            {
                ModNhanVien Sua = new ModNhanVien();
                dtpNamSinh.CustomFormat = "yyyy/MM/dd";
                int manhanvien = int.Parse(txtMaNVien.Text);
                string hoten = txtHoTen.Text;
                string tenhienthi = txtTenDNhap.Text;
                string namsinh = dtpNamSinh.Value.ToString();
                string diachi = txtDiaChi.Text;
                bool kq1 = Sua.SuaNhanVien(manhanvien,hoten, tenhienthi, namsinh, diachi);
                setNut(true);
                Load();
            }
        }

       
    }
}

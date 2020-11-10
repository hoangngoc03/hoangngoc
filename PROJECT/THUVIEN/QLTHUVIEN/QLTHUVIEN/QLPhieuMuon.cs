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
    public partial class QLPhieuMuon : Form
    {
        bool c = true;
        public QLPhieuMuon()
        {
            InitializeComponent();
            setNut(true);
            Load();
        }
        private void Load()
        {
            Models.ModPhieuMuon tb = new Models.ModPhieuMuon();
            DataTable dt = tb.docdulieu();
            dgvMuon.DataSource = dt;
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


        private void dgvMuon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaPhieuMuon.ReadOnly = true;
            int index = dgvMuon.CurrentRow.Index;
            txtMaPhieuMuon.Text = dgvMuon.Rows[index].Cells[0].Value.ToString();
            txtMaNhanVien.Text = dgvMuon.Rows[index].Cells[1].Value.ToString();
            txtMaSach.Text = dgvMuon.Rows[index].Cells[2].Value.ToString();
            dtpNgayMuon.Text = dgvMuon.Rows[index].Cells[3].Value.ToString();
            dtpNgayPhaiTra.Text = dgvMuon.Rows[index].Cells[4].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            setNut(false);
            c = true;
            
            txtMaNhanVien.Clear();
            txtMaSach.Clear();
            dtpNgayMuon.Value = DateTime.Now;
            dtpNgayPhaiTra.Value = DateTime.Now;
            txtMaPhieuMuon.Clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            setNut(false);
            c = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            setNut(false);
            if (MessageBox.Show("Bạn Có Muốn Xoá Phiếu Này", "Cảnh Báo", MessageBoxButtons.OKCancel)==DialogResult.OK)
            {
                //nếu ok thì thực hiện lệnh xoá theo mã đọc giả
                ModPhieuMuon Xoa = new ModPhieuMuon();
                string Ma = txtMaPhieuMuon.Text;
                bool kq = Xoa.XoaPhieuMuon(Ma);
                if (kq == true)
                {
                    MessageBox.Show("Xoá Thành Công!");
                }
                // load lại dữ liệu set lại nút xoá dữ liện trên textbox
                Load();
                setNut(true);
                
                txtMaNhanVien.Clear();
                txtMaSach.Clear();
                dtpNgayMuon.Value = DateTime.Now;
                dtpNgayPhaiTra.Value = DateTime.Now;
            }
            else
            {
                Load();
                setNut(true);
                txtMaNhanVien.Clear();
                txtMaSach.Clear();
                dtpNgayMuon.Value = DateTime.Now;
                dtpNgayPhaiTra.Value = DateTime.Now;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // lấy dữ liệu đang nhập lưu vào database
            if (c == true)

            {
                ModPhieuMuon add = new ModPhieuMuon();
                dtpNgayMuon.CustomFormat = "yyyy/MM/dd";// cài đặt ngày giờ của datetimepicker theo dạng của sql
                dtpNgayPhaiTra.CustomFormat = "yyyy/MM/dd";
                int manhanvien = int.Parse(txtMaNhanVien.Text);
                int masach = int.Parse(txtMaSach.Text);
                string ngaymuon = dtpNgayMuon.Value.ToString();
                string ngayphaitra = dtpNgayPhaiTra.Value.ToString();
                bool kq = add.ThemPhieuMuon(manhanvien,masach,ngaymuon,ngayphaitra);
                if (kq == true)
                    MessageBox.Show("Thêm Thành Công!", "Thông Báo");
                setNut(true);
                Load();//load lại dư liêệu vào dgv
            }
            else
            {
                ModPhieuMuon Sua = new ModPhieuMuon();
                dtpNgayMuon.CustomFormat = "yyyy/MM/dd";// cài đặt ngày giờ của datetimepicker theo dạng của sql
                dtpNgayPhaiTra.CustomFormat = "yyyy/MM/dd";
                int maphieumuon = int.Parse(txtMaPhieuMuon.Text);
                int manhanvien = int.Parse(txtMaNhanVien.Text);
                int masach = int.Parse(txtMaSach.Text);
                string ngaymuon = dtpNgayMuon.Value.ToString();
                string ngayphaitra = dtpNgayPhaiTra.Value.ToString();
                bool kq1 = Sua.SuaPhieuMuon(maphieumuon, manhanvien, masach, ngaymuon, ngayphaitra);
                setNut(true);
                Load();
            }
        }

        private void btnKluu_Click(object sender, EventArgs e)
        {
            setNut(true);
            txtMaPhieuMuon.Clear();
            txtMaNhanVien.Clear();
            txtMaSach.Clear();
            dtpNgayMuon.Value = DateTime.Now;
            dtpNgayPhaiTra.Value = DateTime.Now;
        }  
    }
}

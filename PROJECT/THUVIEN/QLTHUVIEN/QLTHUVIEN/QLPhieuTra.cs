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
    public partial class QLPhieuTra : Form
    {
        bool c = true;
        public QLPhieuTra()
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
            Models.ModPhieuTra tb = new Models.ModPhieuTra();
            DataTable dt = tb.docdulieu();
            dgvTra.DataSource = dt;
        }
        private void setNut(bool a)
        {
            btnThem.Enabled = a;
            btnSua.Enabled = a;
            btnXoa.Enabled = a;
            btnLuu.Enabled = !a;
            btnKluu.Enabled = !a;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //chọn thêm thì ẩn nut sửa , xoá + xoá hết dữ liệu đang nhập
            setNut(false);
            c = true;
            txtMaPhieuMuon.Clear();
            txtMaSach.Clear();
            dtpNgayTra.Value = DateTime.Now;
            txtMaPhieuTra.Clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            setNut(false);
            c = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //sau khi chọn dòng cần xoá bấm xoá thì ẩn nút sửa và thêm
            setNut(false);
            //hiện lên message hỏi có muốn xoá hay khôn
            if (MessageBox.Show("Bạn Có Muốn Xoá Phieu Này", "Cảnh Báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                //nếu ok thì thực hiện lệnh xoá theo mã đọc giả
                ModPhieuTra Xoa = new ModPhieuTra();
                string Ma = txtMaPhieuTra.Text;
                bool kq = Xoa.XoaPhieuTra(Ma);
                if (kq == true)
                {
                    MessageBox.Show("Xoá Thành Công!");
                }
                // load lại dữ liệu set lại nút xoá dữ liện trên textbox
                Load();
                setNut(true);

                txtMaPhieuMuon.Clear();
                txtMaSach.Clear();
                dtpNgayTra.Value = DateTime.Now;

            }
            else
            {
                // chọn cancel thì bật tất cả nút, xoá dữ liệu trên textbox
                setNut(true);

                txtMaPhieuMuon.Clear();
                txtMaSach.Clear();
                dtpNgayTra.Value = DateTime.Now;

            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // lấy dữ liệu đang nhập lưu vào database
            if (c == true)
            {
                ModPhieuTra add = new ModPhieuTra();
                dtpNgayTra.CustomFormat = "yyyy/MM/dd";// cài đặt ngày giờ của datetimepicker theo dạng của sql

                int maphieumuon = int.Parse(txtMaPhieuMuon.Text);
                int masach = int.Parse(txtMaSach.Text);
                string ngaytra = dtpNgayTra.Value.ToString();
                bool kq = add.ThemPhieuTra(maphieumuon, masach, ngaytra);
                if (kq == true)
                    MessageBox.Show("Thêm Thành Công!", "Thông Báo");
                setNut(true);
                Load();//load lại dư liêệu vào dgv
            }
            else
            {
                ModPhieuTra Sua = new ModPhieuTra();
                dtpNgayTra.CustomFormat = "yyyy/MM/dd";
                int maphieutra = int.Parse(txtMaPhieuTra.Text);
                int maphieumuon = int.Parse(txtMaPhieuMuon.Text);
                int masach = int.Parse(txtMaSach.Text);
                string ngaytra = dtpNgayTra.Value.ToString();
                bool kq1 = Sua.SuaPhieuTra(maphieutra,maphieumuon, masach, ngaytra);
                setNut(true);
                Load();
            }

        }

        private void btnKluu_Click(object sender, EventArgs e)
        {
            setNut(true);
            txtMaPhieuTra.Clear();
            txtMaPhieuMuon.Clear();
            txtMaSach.Clear();
            dtpNgayTra.Value = DateTime.Now;
        }

        private void dgvTra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaPhieuTra.ReadOnly = true;
            int index = dgvTra.CurrentRow.Index;
            txtMaPhieuTra.Text = dgvTra.Rows[index].Cells[0].Value.ToString();
            txtMaPhieuMuon.Text = dgvTra.Rows[index].Cells[1].Value.ToString();
            txtMaSach.Text = dgvTra.Rows[index].Cells[2].Value.ToString();
            dtpNgayTra.Text = dgvTra.Rows[index].Cells[3].Value.ToString();
        }
    }
}

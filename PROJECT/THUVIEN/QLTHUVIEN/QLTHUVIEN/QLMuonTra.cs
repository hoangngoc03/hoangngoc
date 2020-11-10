using QLTHUVIEN.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTHUVIEN
{
    public partial class QLMuonTra : Form
    {
        bool c = true;
        public QLMuonTra()
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
            Models.ModMuonTra tb = new Models.ModMuonTra();
            DataTable dt = tb.docdulieu();
            dgvMuonTra.DataSource = dt;
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
            txtDocGia.Clear();
            txtMaSach.Clear();
            txtMaPhieuMuon.Clear();
            txtMaPhieuTra.Clear();
            cbTinhTrang.Text = "";
            txtMaPhieuMuon.Clear();
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
            if (MessageBox.Show("Bạn Có Muốn Xoá Phiếu Này", "Cảnh Báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                //nếu ok thì thực hiện lệnh xoá theo mã đọc giả
                ModMuonTra Xoa = new ModMuonTra();
                string Ma = txtMaPhieuMuon.Text;
                bool kq = Xoa.XoaMuonTra(Ma);
                if (kq == true)
                {
                    MessageBox.Show("Xoá Thành Công!");
                }
                // load lại dữ liệu set lại nút xoá dữ liện trên textbox
                Load();
                setNut(true);

                txtDocGia.Clear();
                txtMaSach.Clear();
                txtMaPhieuMuon.Clear();
                txtMaPhieuTra.Clear();
                cbTinhTrang.Text = "";

            }
            else
            {
                // chọn cancel thì bật tất cả nút, xoá dữ liệu trên textbox
                setNut(true);
                txtDocGia.Clear();
                txtMaSach.Clear();
                txtMaPhieuMuon.Clear();
                txtMaPhieuTra.Clear();
                cbTinhTrang.Text = "";

            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // lấy dữ liệu đang nhập lưu vào database
            if (c == true)
            {
                ModMuonTra add = new ModMuonTra();
                int madocgia =int.Parse(txtDocGia.Text);
                int masach = int.Parse(txtMaSach.Text);
                int maphieumuon = int.Parse(txtMaPhieuMuon.Text);
                int maphieutra = int.Parse(txtMaPhieuTra.Text);
                string tinhtrang = cbTinhTrang.Text;
                bool kq = add.ThemMuonTra(madocgia,masach,maphieumuon,maphieutra,tinhtrang);
                if (kq == true)
                    MessageBox.Show("Thêm Thành Công!", "Thông Báo");
                setNut(true);
                Load();//load lại dư liêệu vào dgv
            }
            else
            {
                ModMuonTra Sua = new ModMuonTra();
                int maql = int.Parse(txtMaQL.Text);
                int madocgia = int.Parse(txtDocGia.Text);
                int masach= int.Parse(txtMaSach.Text);
                int maphieumuon = int.Parse(txtMaPhieuMuon.Text);
                int maphieutra = int.Parse(txtMaPhieuTra.Text);
                string tinhtrang = cbTinhTrang.Text;
                bool kq1 = Sua.SuaMuonTra(maql,madocgia,masach,maphieumuon,maphieutra,tinhtrang);
                setNut(true);
                Load();
            }
        }

        private void btnKluu_Click(object sender, EventArgs e)
        {
            setNut(true);
            txtMaQL.Clear();
            txtDocGia.Clear();
            txtMaSach.Clear();
            txtMaPhieuMuon.Clear();
            txtMaPhieuTra.Clear();
            cbTinhTrang.Text = "";
        }

        private void dgvMuonTra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaQL.ReadOnly = true;
            int index = dgvMuonTra.CurrentRow.Index;
            txtMaQL.Text = dgvMuonTra.Rows[index].Cells[0].Value.ToString();
            txtDocGia.Text = dgvMuonTra.Rows[index].Cells[1].Value.ToString();
            txtMaSach.Text = dgvMuonTra.Rows[index].Cells[2].Value.ToString();
            txtMaPhieuMuon.Text = dgvMuonTra.Rows[index].Cells[3].Value.ToString();
            txtMaPhieuTra.Text = dgvMuonTra.Rows[index].Cells[4].Value.ToString();
            cbTinhTrang.Text = dgvMuonTra.Rows[index].Cells[5].Value.ToString();
           
        }
    }
}

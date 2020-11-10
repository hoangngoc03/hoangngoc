using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QUANLYTHUVIEN
{

    public partial class QuanLyNhanVien : Form
    {
        QuanLyThuVienEntities1 ql = new QuanLyThuVienEntities1();
       
        public QuanLyNhanVien()
        {
            InitializeComponent();
            showNV();
        }
        private void showNV()
        {
            dtgvnhanvien.DataSource = ql.GetNV();
        }

        private void locktext()
        {
            btthemnhanvien.Enabled = true;
            btxoanhanvien.Enabled = true;
            btsuanhanvien.Enabled = true;
            btluunhanvien.Enabled = false;
            btkluunhanvien.Enabled = false;
            btxemnhanvien.Enabled = false;
        }
        private void unlocket()
        {

            btthemnhanvien.Enabled = false;
            btxoanhanvien.Enabled = false;
            btsuanhanvien.Enabled = false;
            btluunhanvien.Enabled = true;
            btkluunhanvien.Enabled = true;
            btxemnhanvien.Enabled = true;
        }
        bool nut;

        private void btxoanhanvien_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn Có Muốn Xoá Nhân Viên Này", "Cảnh Báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                int i = int.Parse(tbmanv.Text);
                NHANVIEN nv = ql.NHANVIENs.FirstOrDefault(a => a.MaNV == i);
                ql.NHANVIENs.Remove(nv);
                ql.SaveChanges();
                showNV();

            }

        }
       

        private void dtgvnhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                locktext();
                DataGridViewRow rowNV = new DataGridViewRow();
                rowNV = dtgvnhanvien.Rows[e.RowIndex];
                tbmanv.Text = rowNV.Cells[0].Value.ToString();
                tbhotenv.Text = rowNV.Cells[1].Value.ToString();
                tbtendnnv.Text = rowNV.Cells[2].Value.ToString();
                dtnv.Text = rowNV.Cells[3].Value.ToString();
                tbdiachinv.Text = rowNV.Cells[4].Value.ToString();
            }
            catch
            {

            }
        }
       

       

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btthemnhanvien_Click(object sender, EventArgs e)
        {
            nut = true;
            unlocket();
            showNV();
        }

       

        

        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            locktext();
            showNV();

        }

        private void btsuanhanvien_Click(object sender, EventArgs e)
        {
            nut = false;
            unlocket();
            showNV();
        }

        private void btluunhanvien_Click(object sender, EventArgs e)
        {
            locktext();
            if (nut == true)
            {
                ql.ThemNV(tbhotenv.Text,
                    tbtendnnv.Text,
                    dtnv.Value,
                    tbdiachinv.Text);
                try
                {
                    MessageBox.Show("Lưu Thành Công", "Thông Báo");
                    showNV();
                }
                catch
                {
                    MessageBox.Show("Không Lưu Được");
                }
            }
            else
            {
                ql.SuaNV(int.Parse(tbmanv.Text), int.Parse(tbmanv.Text),
                        tbhotenv.Text,
                        tbtendnnv.Text,
                        dtnv.Value,
                        tbdiachinv.Text);
                try
                {
                    MessageBox.Show("Đã Sửa Được", "Thông Báo");
                    showNV();
                }
                catch
                {
                    MessageBox.Show("Không Sửa Được");
                }
            }
        }

        private void bttimnhanvien_Click(object sender, EventArgs e)
        {
            locktext();
            var tim = from c in ql.NHANVIENs where tbtimnhanvien.Text == c.HoTen select c;
            dtgvnhanvien.DataSource = tim.ToList();
        }
    }
}

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
    public partial class QuanLyMuonTra : Form
    {
        QuanLyThuVienEntities1 ql = new QuanLyThuVienEntities1();
        public QuanLyMuonTra()
        {
            InitializeComponent();
            showQLMT();
           
        }
        void showQLMT()
        {
            dtgvmuontra.DataSource = ql.GetQlMT();
        }

        private void locktext()
        {
            btthem.Enabled = true;
            btxoa.Enabled = true;
            btsua.Enabled = true;
            btluu.Enabled = false;
           
        }
        private void unlocket()
        {

            btthem.Enabled = false;
            btxoa.Enabled = false;
            btsua.Enabled = false;
            btluu.Enabled = true;
            
        }
        bool nut;
        private void btthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btthemdocgia_Click(object sender, EventArgs e)
        {
            nut = true;
            unlocket();
            showQLMT();
        }

        private void btxoadocgia_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Có Muốn Xoá Phiếu Này", "Cảnh Báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                int i = int.Parse(tbmaql.Text);
                QLMUONTRA mt = ql.QLMUONTRAs.FirstOrDefault(a => a.MaQL == i);
                ql.QLMUONTRAs.Remove(mt);
                ql.SaveChanges();
                showQLMT();

            }
        }

        private void QuanLyMuonTra_Load(object sender, EventArgs e)
        {
            locktext();
            showQLMT();
        }

        private void dtgvmuontra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow rowQLMT = new DataGridViewRow();
                rowQLMT = dtgvmuontra.Rows[e.RowIndex];
                tbmaql.Text = rowQLMT.Cells[0].Value.ToString();
                tbmadocgia.Text = rowQLMT.Cells[1].Value.ToString();
                tbmasach.Text = rowQLMT.Cells[2].Value.ToString();
                tbmaphieumuon.Text = rowQLMT.Cells[3].Value.ToString();
                tbmaphieutra.Text = rowQLMT.Cells[4].Value.ToString();
                tbtinhtrang.Text = rowQLMT.Cells[5].Value.ToString();
            }
            catch
            {

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btsua_Click(object sender, EventArgs e)
        {
            nut = false;
            unlocket();
            showQLMT();
        }

        private void bttimdocgia_Click(object sender, EventArgs e)
        {
            locktext();
            int i = int.Parse(tbtim.Text);
            var tim = from c in ql.QLMUONTRAs where c.MaQL == i select c;
            dtgvmuontra.DataSource = tim.ToList();
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            if (nut == true)
            {
                ql.ThemQLMT(int.Parse(tbmadocgia.Text),
                    int.Parse(tbmasach.Text),
                    int.Parse(tbmaphieumuon.Text),
                    int.Parse(tbmaphieutra.Text),
                    tbtinhtrang.Text);
                try
                {
                    MessageBox.Show("Lưu Thành Công", "Thông Báo");
                    showQLMT();
                }
                catch
                {
                    MessageBox.Show("Không Lưu Được");
                }
            }
            else
            {
                ql.SuaQLMT(int.Parse(tbmaql.Text), int.Parse(tbmaql.Text),
                    int.Parse(tbmadocgia.Text),
                    int.Parse(tbmasach.Text),
                    int.Parse(tbmaphieumuon.Text),
                    int.Parse(tbmaphieutra.Text),
                    tbtinhtrang.Text);
                try
                {
                    MessageBox.Show("Đã Sửa Được", "Thông Báo");
                    showQLMT();
                }
                catch
                {
                    MessageBox.Show("Không Sửa Được");
                }
            }
        }

        private void btluu_Click_1(object sender, EventArgs e)
        {
            locktext();
            if (nut == true)
            {
                ql.ThemQLMT(int.Parse(tbmadocgia.Text),
                    int.Parse(tbmasach.Text),
                    int.Parse(tbmaphieumuon.Text),
                    int.Parse(tbmaphieutra.Text),
                    tbtinhtrang.Text);
                try
                {
                    MessageBox.Show("Lưu Thành Công", "Thông Báo");
                    showQLMT();
                }
                catch
                {
                    MessageBox.Show("Không Lưu Được");
                }
            }
            else
            {
                ql.SuaQLMT(int.Parse(tbmaql.Text), int.Parse(tbmaql.Text),
                    int.Parse(tbmadocgia.Text),
                    int.Parse(tbmasach.Text),
                    int.Parse(tbmaphieumuon.Text),
                    int.Parse(tbmaphieutra.Text),
                    tbtinhtrang.Text);
                try
                {
                    MessageBox.Show("Đã Sửa Được", "Thông Báo");
                    showQLMT();
                }
                catch
                {
                    MessageBox.Show("Không Sửa Được");
                }
            }
        }
    }
}

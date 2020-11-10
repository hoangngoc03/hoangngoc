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
    public partial class QuanLyTra : Form
    {
        QuanLyThuVienEntities1 ql = new QuanLyThuVienEntities1();
        public QuanLyTra()
        {
            InitializeComponent();
            showT();
        }
        void showT()
        {
            dtgvtra.DataSource = ql.GetPT();
        }

        private void locktext()
        {
            btthemtra.Enabled = true;
            btxoatra.Enabled = true;
            btsuatra.Enabled = true;
            btluutra.Enabled = false;
            btkluutra.Enabled = false;
            btxemtra.Enabled = false;
        }
        private void unlocket()
        {

            btthemtra.Enabled = false;
            btxoatra.Enabled = false;
            btsuatra.Enabled = false;
            btluutra.Enabled = true;
            btkluutra.Enabled = true;
            btxemtra.Enabled = true;
        }
        bool nut;
        private void dtgvtra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                locktext();
                DataGridViewRow rowT = new DataGridViewRow();
                rowT = dtgvtra.Rows[e.RowIndex];
                tbmaphieutra.Text = rowT.Cells[0].Value.ToString();
                tbmaphieumuon.Text = rowT.Cells[1].Value.ToString();
                tbmasach.Text = rowT.Cells[2].Value.ToString();
                dtngaytra.Text = rowT.Cells[3].Value.ToString();
            }
            catch
            {

            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btthemtra_Click(object sender, EventArgs e)
        {
            nut = true;
            unlocket();
            showT();
        }

        private void QuanLyTra_Load(object sender, EventArgs e)
        {
            locktext();
            showT();
        }

        private void btluutra_Click(object sender, EventArgs e)
        {
            locktext();
            if (nut == true)
            {
                ql.ThemPT(int.Parse(tbmaphieumuon.Text),
                    int.Parse(tbmasach.Text),
                    dtngaytra.Value);
                try
                {
                    MessageBox.Show("Lưu Thành Công", "Thông Báo");
                    showT();
                }
                catch
                {
                    MessageBox.Show("Không Lưu Được");
                }
            }
            else
            {
                ql.SuaPT(int.Parse(tbmaphieutra.Text), int.Parse(tbmaphieutra.Text),
                        int.Parse(tbmaphieumuon.Text),
                        int.Parse(tbmasach.Text),
                        dtngaytra.Value);
                try
                {
                    MessageBox.Show("Đã Sửa Được", "Thông Báo");
                    showT();
                }
                catch
                {
                    MessageBox.Show("Không Sửa Được");
                }
            }
        }

        private void btsuatra_Click(object sender, EventArgs e)
        {
            nut = false;
            unlocket();
            showT();
        }

        private void btxoatra_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Có Muốn Xoá Phiếu Này", "Cảnh Báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                int i = int.Parse(tbmaphieutra.Text);
                PHIEUTRA pt = ql.PHIEUTRAs.FirstOrDefault(a => a.MaPhieuTra == i);
                ql.PHIEUTRAs.Remove(pt);
                ql.SaveChanges();
                showT();

            }
        }

        private void bttimtra_Click(object sender, EventArgs e)
        {
            locktext();
            int i = int.Parse(tbtimtra.Text);
            var tim = from c in ql.PHIEUTRAs where c.MaPhieuTra == i select c;
            dtgvtra.DataSource = tim.ToList();
        }
    }
}

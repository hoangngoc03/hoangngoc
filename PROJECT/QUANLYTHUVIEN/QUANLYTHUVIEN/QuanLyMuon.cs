using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYTHUVIEN
{
    public partial class QuanLyMuon : Form
    {
        QuanLyThuVienEntities1 ql = new QuanLyThuVienEntities1();
        public QuanLyMuon()
        {
            InitializeComponent();
            showM();
        }
        void showM()
        {
            dtgvmuon.DataSource = ql.GetPM();
        }

        private void locktext()
        {
            btthemmuon.Enabled = true;
            btxoamuon.Enabled = true;
            btsuamuon.Enabled = true;
            btluumuon.Enabled = false;
            btkluumuon.Enabled = false;
            btxemmuon.Enabled = false;
        }
        private void unlocket()
        {

            btthemmuon.Enabled = false;
            btxoamuon.Enabled = false;
            btsuamuon.Enabled = false;
            btluumuon.Enabled = true;
            btkluumuon.Enabled = true;
            btxemmuon.Enabled = true;
        }
        bool nut;



        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       

        private void btthemmuon_Click(object sender, EventArgs e)
        {
            nut = true;
            unlocket();
            showM();
        }

        private void btxoamuon_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn Có Muốn Xoá Phiếu Này", "Cảnh Báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                int i = int.Parse(txtmapm.Text);
                PHIEUMUON pm = ql.PHIEUMUONs.FirstOrDefault(a => a.MaPhieuMuon == i);
                ql.PHIEUMUONs.Remove(pm);
                ql.SaveChanges();
                showM();

            }
        }

        private void QuanLyMuon_Load(object sender, EventArgs e)
        {
            locktext();
            showM();
        }

        private void dtgvmuon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                locktext();
                DataGridViewRow rowM = new DataGridViewRow();
                rowM = dtgvmuon.Rows[e.RowIndex];
                txtmapm.Text = rowM.Cells[0].Value.ToString();
                txtmnv.Text = rowM.Cells[1].Value.ToString();
                txtms.Text = rowM.Cells[2].Value.ToString();
                dtngaymuon.Text = rowM.Cells[3].Value.ToString();
                dtngaytra.Text = rowM.Cells[4].Value.ToString();
            }
            catch
            {

            }
        }

        private void btsuamuon_Click(object sender, EventArgs e)
        {
            nut = false;
            unlocket();
            showM();
        }

        private void btluumuon_Click(object sender, EventArgs e)
        {
            locktext();
            if (nut == true)
            {
                ql.ThemPM(int.Parse(txtmnv.Text),
                    int.Parse(txtms.Text),
                    dtngaymuon.Value,
                    dtngaytra.Value);
                try
                {
                    MessageBox.Show("Lưu Thành Công", "Thông Báo");
                    showM();
                }
                catch
                {
                    MessageBox.Show("Không Lưu Được");
                }
            }
            else
            {
                ql.SuaPM(int.Parse(txtmapm.Text), int.Parse(txtmapm.Text),
                        int.Parse(txtmnv.Text),
                        int.Parse(txtms.Text),
                        dtngaymuon.Value,
                        dtngaytra.Value);
                try
                {
                    MessageBox.Show("Đã Sửa Được", "Thông Báo");
                    showM();
                }
                catch
                {
                    MessageBox.Show("Không Sửa Được");
                }
            }
        }

        private void bttimmuon_Click(object sender, EventArgs e)
        {
            locktext();
            int i = int.Parse(tbtimmuon.Text);
            var tim = from c in ql.PHIEUMUONs where c.MaPhieuMuon == i select c;
            dtgvmuon.DataSource = tim.ToList();
        }
    }
}

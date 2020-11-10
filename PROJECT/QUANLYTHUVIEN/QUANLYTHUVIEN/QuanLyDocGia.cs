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
    public partial class QuanLyDocGia : Form
    {

        QuanLyThuVienEntities1 ql = new QuanLyThuVienEntities1();
        public QuanLyDocGia()
        {
            InitializeComponent();
            showDg();
        }
        

        private void locktext()
        {
            btthemdocgia.Enabled = true;
            btxoadocgia.Enabled = true;
            btsuadocgia.Enabled = true;
            btluudogia.Enabled = false;
            btkluudocgia.Enabled = false;
            btxemdocgia.Enabled = false;
        }
        private void unlocket()
        {
            btthemdocgia.Enabled = false;
            btxoadocgia.Enabled = false;
            btsuadocgia.Enabled = false;
            btluudogia.Enabled = true;
            btkluudocgia.Enabled = true;
            btxemdocgia.Enabled = true;
        }
        bool nut;

        private void showDg()
        {
            dtgvdocgia.DataSource = ql.GetDG();
        }


        private void btluudogia_Click(object sender, EventArgs e)
        {
            locktext();
            if (nut == true)
            {
                ql.ThemDG(txthotendg.Text,
                    cbgioitinhdg.Text,
                    dtnamsinhdg.Value);
                try
                {
                    MessageBox.Show("Lưu Thành Công", "Thông Báo");
                    showDg();
                }
                catch
                {
                    MessageBox.Show("Không Lưu Được");
                }
            }
            else
            {
                ql.SuaDg(int.Parse(txtmadocgia.Text), int.Parse(txtmadocgia.Text),
                        txthotendg.Text,
                        cbgioitinhdg.Text,
                        dtnamsinhdg.Value);
                try
                {
                    MessageBox.Show("Đã Sửa Được", "Thông Báo");
                    showDg();
                }
                catch
                {
                    MessageBox.Show("Không Sửa Được");
                }
            }

        }
        private void dtgvdocgia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                locktext();//mở
                DataGridViewRow rowDg = new DataGridViewRow();
                rowDg = dtgvdocgia.Rows[e.RowIndex];
                txtmadocgia.Text = rowDg.Cells[0].Value.ToString();
                txthotendg.Text = rowDg.Cells[1].Value.ToString();
                cbgioitinhdg.Text = rowDg.Cells[2].Value.ToString();
                dtnamsinhdg.Text = rowDg.Cells[3].Value.ToString();
            }
            catch
            {

            }
        }
        private void btxoadocgia_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Có Muốn Xoá Đọc Giả Này", "Cảnh Báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                int i = int.Parse(txtmadocgia.Text);
                DOCGIA dg = ql.DOCGIAs.FirstOrDefault(a => a.MaDocGia == i);
                ql.DOCGIAs.Remove(dg);
                ql.SaveChanges();
                showDg();

            }
        }

      

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btthemdocgia_Click(object sender, EventArgs e)
        {
            nut = true;
            unlocket();
            showDg();
        }
       private void QuanLyDocGia_Load(object sender, EventArgs e)
        {
            locktext();
            showDg();
        }

        private void btsuadocgia_Click(object sender, EventArgs e)
        {
            nut = false;
            unlocket();
            showDg();
        }

        private void bttimdocgia_Click(object sender, EventArgs e)
        {
            locktext();
            var tim = from c in ql.DOCGIAs where tbtimdogia.Text == c.HoTen select c;
            dtgvdocgia.DataSource = tim.ToList();
        }
    }
}

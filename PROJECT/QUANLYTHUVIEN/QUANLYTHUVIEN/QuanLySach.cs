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
    public partial class QuanLySach : Form
    {
        QuanLyThuVienEntities1 ql = new QuanLyThuVienEntities1();
        SACH s = new SACH();

        public QuanLySach()
        {
            InitializeComponent();
            showS();
        }
        private void locktext()
        {
            btthemsach.Enabled = true;
            btxoasach.Enabled = true;
            btsuasach.Enabled = true;
            btluusach.Enabled = false;
            btkluusach.Enabled = false;
            btxemsach.Enabled = false;
        }
        private void unlocket()
        {

            btthemsach.Enabled = false;
            btxoasach.Enabled = false;
            btsuasach.Enabled = false;
            btluusach.Enabled = true;
            btkluusach.Enabled = true;
            btxemsach.Enabled = true;
        }
        private void btluusach_Click(object sender, EventArgs e)
        {
            locktext();
           if(nut == true)
            {
                ql.ThemS(tbtensach.Text,
                    tbtacgia.Text,
                    tbtheloai.Text,
                    tbnhaxuatban.Text,
                    int.Parse(tbgiasach.Text),
                    int.Parse(nbsoluong.Value.ToString()),
                    cbtinhtrang.Text);
                try
                {
                    MessageBox.Show("Lưu Thành Công", "Thông Báo");
                    showS();
                }
                catch
                {
                    MessageBox.Show("Không Lưu Được");
                }
            }
            else
            {
                ql.SuaS(int.Parse(tbmasach.Text), int.Parse(tbmasach.Text),
                        tbtensach.Text,
                        tbtacgia.Text,
                        tbtheloai.Text,
                        tbnhaxuatban.Text,
                        int.Parse(tbgiasach.Text),
                        int.Parse(nbsoluong.Text),
                        cbtinhtrang.Text);
                try
                {
                    MessageBox.Show("Đã Sửa Được", "Thông Báo");
                    showS();
                }catch
                {
                    MessageBox.Show("Không Sửa Được");
                }
            }
        }
        private void dtgvsach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                locktext();
                DataGridViewRow rowS = new DataGridViewRow();
                rowS = dtgvsach.Rows[e.RowIndex];
                tbmasach.Text = rowS.Cells[0].Value.ToString();
                tbtensach.Text = rowS.Cells[1].Value.ToString();
                tbtacgia.Text = rowS.Cells[2].Value.ToString();
                tbtheloai.Text = rowS.Cells[3].Value.ToString();
                tbnhaxuatban.Text = rowS.Cells[4].Value.ToString();
                tbgiasach.Text = rowS.Cells[5].Value.ToString();
                nbsoluong.Text = rowS.Cells[6].Value.ToString();
                cbtinhtrang.Text = rowS.Cells[7].Value.ToString();
            }
            catch
            {
                
            }
        }

        private void showS()
        {
            dtgvsach.DataSource = ql.GetS();
        }
        bool nut;
        private void btxoasach_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Có Muốn Xoá Sách Này", "Cảnh Báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                int i = int.Parse(tbmasach.Text);
                SACH s = ql.SACHes.FirstOrDefault(a => a.MaSach == i);
                ql.SACHes.Remove(s);
                ql.SaveChanges();
                showS();

            }
        }
         private void button7_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private void QuanLySach_Load(object sender, EventArgs e)
        {
            locktext();
            showS();
        }
        private void btthemsach_Click(object sender, EventArgs e)
        {
            nut = true;
            unlocket();
            showS();
        }

        private void btsuasach_Click(object sender, EventArgs e)
        {
            nut = false;
            unlocket();
            showS();
        }

        private void bttimsach_Click(object sender, EventArgs e)
        {
            locktext();
            var tim = from c in ql.SACHes where tbtimsach.Text == c.TenSach select c;
            dtgvsach.DataSource = tim.ToList();
            
        }
    }
}

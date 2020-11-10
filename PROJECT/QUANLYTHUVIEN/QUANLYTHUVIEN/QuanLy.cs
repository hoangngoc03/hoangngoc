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
    public partial class QuanLy : Form
    {
        public QuanLy()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QuanLySach qls = new QuanLySach();
            this.Hide();
            qls.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            QuanLyDocGia qldg = new QuanLyDocGia();
            this.Hide();
            qldg.ShowDialog();
            this.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            QuanLyMuon qlm = new QuanLyMuon();
            this.Hide();
            qlm.ShowDialog();
            this.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            QuanLyTra qlt = new QuanLyTra();
            this.Hide();
            qlt.ShowDialog();
            this.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            QuanLyNhanVien qlnv = new QuanLyNhanVien();
            this.Hide();
            qlnv.ShowDialog();
            this.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            QuanLyMuonTra qlmt = new QuanLyMuonTra();
            this.Hide();
            qlmt.ShowDialog();
            this.Show();
        }
    }
}

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
    public partial class QLy : Form
    {
        public QLy()
        {
            InitializeComponent();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            QLDocGia qldg = new QLDocGia();
            this.Hide();
            qldg.ShowDialog();
            this.Show();
        }

      

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnQLSach_Click(object sender, EventArgs e)
        {
            QLSach qls = new QLSach();
            this.Hide();
            qls.ShowDialog();
            this.Show();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            QLNhanVien qlnv = new QLNhanVien();
            this.Hide();
            qlnv.ShowDialog();
            this.Show();
        }

        private void btnQLMuon_Click(object sender, EventArgs e)
        {
            QLPhieuMuon qlpm = new QLPhieuMuon();
            this.Hide();
            qlpm.ShowDialog();
            this.Show();
           }

        private void btnQLTra_Click(object sender, EventArgs e)
        {
            QLPhieuTra qlpt = new QLPhieuTra();
            this.Hide();
            qlpt.ShowDialog();
            this.Show();
        }

        private void QLMuonTra_Click(object sender, EventArgs e)
        {
            QLMuonTra qlpt = new QLMuonTra();
            this.Hide();
            qlpt.ShowDialog();
            this.Show();
        }
    }
}

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
   
    public partial class QLDocGia : Form
    {
        bool c=true;
        public QLDocGia()
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
            Models.ModDocGia tb = new Models.ModDocGia();
            DataTable dt = tb.docdulieu();
            dgvDocgia.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Load();
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
            txtHoTen.Clear();
            cbGioiTinh.Text="";
            dtpNamSinh.Value = DateTime.Now;
            txtDocGia.Clear();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // lấy dữ liệu đang nhập lưu vào database
            if (c == true)
            {
                ModDocGia add = new ModDocGia();
                dtpNamSinh.CustomFormat = "yyyy/MM/dd";// cài đặt ngày giờ của datetimepicker theo dạng của sql
                
                string hoten = txtHoTen.Text;
                string gioitinh = cbGioiTinh.Text;
                string namsinh = dtpNamSinh.Value.ToString();
                bool kq = add.ThemDocGia(hoten, gioitinh, namsinh);
                if (kq == true)
                    MessageBox.Show("Thêm Thành Công!", "Thông Báo");
                setNut(true);
                Load();//load lại dư liêệu vào dgv
            }
            else
            {
                ModDocGia Sua = new ModDocGia();
                dtpNamSinh.CustomFormat= "yyyy/MM/dd";
                int madocgia = int.Parse(txtDocGia.Text);
                string hoten = txtHoTen.Text;
                string gioitinh = cbGioiTinh.Text;
                string namsinh = dtpNamSinh.Value.ToString();
                bool kq1 = Sua.SuaDocGia(madocgia, hoten, gioitinh, namsinh);
                setNut(true);
                Load();
            }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //sau khi chọn dòng cần xoá bấm xoá thì ẩn nút sửa và thêm
            setNut(false);
            //hiện lên message hỏi có muốn xoá hay khôn
            if (MessageBox.Show("Bạn Có Muốn Xoá Đọc Giả Này", "Cảnh Báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                //nếu ok thì thực hiện lệnh xoá theo mã đọc giả
                ModDocGia Xoa = new ModDocGia();
                string Ma = txtDocGia.Text;
                bool kq = Xoa.XoaDocGia(Ma);               
                if (kq == true)
                {
                    MessageBox.Show("Xoá Thành Công!");
                }
                // load lại dữ liệu set lại nút xoá dữ liện trên textbox
                Load();
                setNut(true);
                txtHoTen.Clear();
                cbGioiTinh.Text = "";
                dtpNamSinh.Value = DateTime.Now;
                
            }
            else
            {
                // chọn cancel thì bật tất cả nút, xoá dữ liệu trên textbox
                setNut(true);
               
                txtHoTen.Clear();
                cbGioiTinh.Text = "";
                dtpNamSinh.Value = DateTime.Now;

            }
        }

        private void btnKluu_Click(object sender, EventArgs e)
        {
            setNut(true);
            txtDocGia.Clear();
            txtHoTen.Clear();
            cbGioiTinh.Text = "";
            dtpNamSinh.Value = DateTime.Now;
           
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            setNut(false);
            c = false;
        }

   

        private void dgvDocgia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDocGia.ReadOnly = true;
            int index = dgvDocgia.CurrentRow.Index;
            txtDocGia.Text = dgvDocgia.Rows[index].Cells[0].Value.ToString();
            txtHoTen.Text = dgvDocgia.Rows[index].Cells[1].Value.ToString();
            cbGioiTinh.Text = dgvDocgia.Rows[index].Cells[2].Value.ToString();
            dtpNamSinh.Text = dgvDocgia.Rows[index].Cells[3].Value.ToString();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            ModDocGia tim = new ModDocGia();
            DataTable dt = tim.timtheoten(txtTim.Text);
            if(dt.Rows.Count > 0)
            {
                dgvDocgia.DataSource = null;
                dgvDocgia.DataSource = dt;
            }
            else
            {
             dgvDocgia.DataSource = null;
                MessageBox.Show("Không tìm thấy đọc giả !", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK
               Load();
            }

        }
    }
}

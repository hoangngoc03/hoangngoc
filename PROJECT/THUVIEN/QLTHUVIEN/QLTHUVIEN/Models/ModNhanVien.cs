using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTHUVIEN.Models
{
    class ModNhanVien
    {
        public DataTable docdulieu()
        {
            string str = "select * from NHANVIEN";
            DataTable dt = DataProvider.ExecuteQuery(str);
            return dt;
        }
        public bool ThemNhanVien(string hoten, string tenhienthi, string namsinh, string diachi)
        {
            //insert into DOCGIA (HoTen,GioiTinh,NamSinh) values (N'Lê Thị Hoàng Ngọc',N'Nữ','2000')
            string str = "insert into NHANVIEN (HoTen,TenDangNhap,NamSinh,DiaChi) values (N'"
                           + hoten.ToString() + "','" + tenhienthi.ToString() + "','" + namsinh.ToString() +"','"+diachi.ToString()+"')";
            bool result = DataProvider.ExecuteNonQuery(str);
            return result;
        }
        public bool XoaNhanVien(string Ma)
        {
            //delete from NHANVIEN where HoTen=N'Thoại'
            string str = "delete from NHANVIEN where MaNV=N'" + Ma + "'";
            bool result = DataProvider.ExecuteNonQuery(str);
            return result;
        }
        public bool SuaNhanVien(int manhanvien, string hoten, string tenhienthi, string namsinh,string diachi)
        {
            //update DOCGIA Set HoTen= N'tu', GioiTinh=N'Nữ',NamSinh='2020-02-03' Where MaDocGia=1
            string str = "update NHANVIEN Set HoTen = N'" + hoten + "', TenDangNhap ='" + tenhienthi + "',NamSinh = '" + namsinh+"',DiaChi=N'"+diachi + "' Where MaNV =" + manhanvien ;
            bool result = DataProvider.ExecuteNonQuery(str);
            return result;

        }
    }
}
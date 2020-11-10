using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTHUVIEN.Models
{
    class ModSach
    {
        public DataTable docdulieu()
        {
            string str = "select * from SACH";
            DataTable dt = DataProvider.ExecuteQuery(str);
            return dt;
        }
        
      
        public bool ThemSach(string tensach, string tacgia, string theloai, string nhaxuatban, int giasach, int soluong, string tinhtrang)
        {
            //insert into SACH (HoTen,GioiTinh,NamSinh) values (N'Lê Thị Hoàng Ngọc',N'Nữ','2000')
            string str = "insert into SACH (TenSach, TacGia, TheLoai, NhaXuatBan, GiaSach, SoLuong, TinhTrang) values (N'"
                           + tensach.ToString() + "',N'" + tacgia.ToString() + "',N'"
                           + theloai.ToString() + "',N'"+nhaxuatban.ToString()+"','"
                           +giasach.ToString()+"','"+soluong.ToString()+"',N'"+tinhtrang.ToString()+"')";
            bool result = DataProvider.ExecuteNonQuery(str);
            return result;
        }

        public bool XoaSach(string Ma)
        {
            //delete from DOCGIA where HoTen=N'Thoại'
            string str = "delete from SACH where MaSach=N'" + Ma + "'";
            bool result = DataProvider.ExecuteNonQuery(str);
            return result;
        }

        public bool SuaSach(int masach, string tensach, string tacgia, string theloai, string nhaxuatban,int giasach, int soluong, string tinhtrang)
        {
            //update DOCGIA Set HoTen= N'tu', GioiTinh=N'Nữ',NamSinh='2020-02-03' Where MaDocGia=1
            string str = "update SACH Set TenSach = N'" + tensach + "', TacGia = N'" + tacgia + "',TheLoai = N'"
                + theloai +"',NhaXuatBan='"+nhaxuatban+"',GiaSach='"+giasach+"',SoLuong='"
                +soluong +"', TinhTrang=N'"+tinhtrang+"' Where MaSach =" + masach;
            bool result = DataProvider.ExecuteNonQuery(str);
            return result;

        }
    }
}

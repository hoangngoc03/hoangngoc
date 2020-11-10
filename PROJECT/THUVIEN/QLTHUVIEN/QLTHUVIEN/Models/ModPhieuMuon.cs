using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTHUVIEN.Models
{
    class ModPhieuMuon
    {
        public DataTable docdulieu()
        {
            string str = "select * from PHIEUMUON";
            DataTable dt = DataProvider.ExecuteQuery(str);
            return dt;
        }
        public bool ThemPhieuMuon(int manhanvien, int masach, string ngaymuon,string ngayphaitra)
        {
            //insert into DOCGIA (HoTen,GioiTinh,NamSinh) values (N'Lê Thị Hoàng Ngọc',N'Nữ','2000')
            string str = "insert into PHIEUMUON (MaNV, MaSach, NgayMuon, NgayPhaiTra) values ('"
                     + manhanvien.ToString() + "','" 
                     + masach.ToString()+"','"+ngaymuon.ToString()+"','"+ngayphaitra.ToString()+ "')";
            bool result = DataProvider.ExecuteNonQuery(str);
            return result;
        }
        public bool XoaPhieuMuon(string Ma)
        {
            //delete from DOCGIA where HoTen=N'Thoại'
            string str = "delete from PHIEUMUON where MaPhieuMuon='" + Ma + "'";
            bool result = DataProvider.ExecuteNonQuery(str);
            return result;
        }
        public bool SuaPhieuMuon(int maphieumuon, int manhanvien, int masach, string ngaymuon, string ngayphaitra)
        {
            //update DOCGIA Set HoTen= N'tu', GioiTinh=N'Nữ',NamSinh='2020-02-03' Where MaDocGia=1
            string str = "update PHIEUMUON Set  MaNV = '" + manhanvien 
                +"', MaSach = '" + masach +"',NgayMuon='"+ngaymuon+"',NgayPhaiTra='"+ngayphaitra+"' Where MaPhieuMuon =" + maphieumuon;
            bool result = DataProvider.ExecuteNonQuery(str);
            return result;

        }
    }
}

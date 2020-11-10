using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTHUVIEN.Models
{
    class ModPhieuTra
    {
        public DataTable docdulieu()
        {
            string str = "select * from PHIEUTRA";
            DataTable dt = DataProvider.ExecuteQuery(str);
            return dt;
        }
        public bool ThemPhieuTra(int maphieumuon, int masach, string ngaytra)
        {
            //insert into DOCGIA (HoTen,GioiTinh,NamSinh) values (N'Lê Thị Hoàng Ngọc',N'Nữ','2000')
            string str = "insert into PHIEUTRA (MaPhieuMuon, MaSach, NgayTra) values ('"
                            + maphieumuon.ToString()+ "','" + masach.ToString()+ "','" + ngaytra.ToString() + "')";
            bool result = DataProvider.ExecuteNonQuery(str);
            return result;
        }

        public bool XoaPhieuTra(string Ma)
        {
            //delete from DOCGIA where HoTen=N'Thoại'
            string str = "delete from PHIEUTRA where MaPhieuTra='" + Ma + "'";
            bool result = DataProvider.ExecuteNonQuery(str);
            return result;
        }

        public bool SuaPhieuTra(int maphieutra, int maphieumuon, int masach, string ngaytra)
        {
            //update DOCGIA Set HoTen= N'tu', GioiTinh=N'Nữ',NamSinh='2020-02-03' Where MaDocGia=1
            string str = "update PHIEUTRA Set MaPhieuMuon = '" + maphieumuon + "', MaSach = '" + masach + "',NgayTra= '" + ngaytra + "' Where MaPhieuTra =" + maphieutra;
            bool result = DataProvider.ExecuteNonQuery(str);
            return result;

        }
    }
}

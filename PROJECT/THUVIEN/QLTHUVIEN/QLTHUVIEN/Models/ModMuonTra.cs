using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace QLTHUVIEN.Models
{
    class ModMuonTra
    {
        public DataTable docdulieu()
        {
            string str = "select * from QLMUONTRA";
            DataTable dt = DataProvider.ExecuteQuery(str);
            return dt;
        }
        public bool ThemMuonTra(int madocgia,int masach, int maphieumuon, int maphieutra, string tinhtrang)
        {
            //insert into DOCGIA (HoTen,GioiTinh,NamSinh) values (N'Lê Thị Hoàng Ngọc',N'Nữ','2000')
            string str = "insert into QLMUONTRA (MaDocGia,MaSach,MaPhieuMuon,MaPhieuTra,TinhTrang) values (N'"
                           + madocgia.ToString() + "',N'"+ masach.ToString()  + "',N'" 
                           + maphieumuon.ToString() + "',N'" + maphieutra.ToString() + "',N'" + tinhtrang.ToString() + "')";
            bool result = DataProvider.ExecuteNonQuery(str);
            return result;
        }

        public bool XoaMuonTra(string Ma)
        {
            //delete from DOCGIA where HoTen=N'Thoại'
            string str = "delete from QLMUONTRA where MaQL='" + Ma + "'";
            bool result = DataProvider.ExecuteNonQuery(str);
            return result;
        }

        public bool SuaMuonTra(int maql, int madocgia,int masach,int maphieumuon, int maphieutra,  string tinhtrang)
        {
            //update DOCGIA Set HoTen= N'tu', GioiTinh=N'Nữ',NamSinh='2020-02-03' Where MaDocGia=1
            string str = "update QLMUONTRA Set MaDocGia ='" + madocgia +
                "', MaSach ='" + masach+"', MaPhieuMuon ='" + maphieumuon + "', MaPhieuTra ='" + maphieutra +
                "', TinhTrang = N'" + tinhtrang + "' Where MaQL =" + maql;
            bool result = DataProvider.ExecuteNonQuery(str);
            return result;

        }
    }
}

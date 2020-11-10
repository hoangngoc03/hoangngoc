using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTHUVIEN.Models
{
    class ModDocGia
    {
        public DataTable docdulieu()
        {
            string str = "select * from DOCGIA";
            DataTable dt= DataProvider.ExecuteQuery(str);
            return dt;
        }
        public bool ThemDocGia(string hoten, string gioitinh, string namsinh)
        {
            //insert into DOCGIA (HoTen,GioiTinh,NamSinh) values (N'Lê Thị Hoàng Ngọc',N'Nữ','2000')
            string str = "insert into DOCGIA (HoTen,GioiTinh,NamSinh) values (N'"
                           +hoten.ToString()+"',N'"+gioitinh.ToString()+"','"+namsinh.ToString()+"')";
            bool result = DataProvider.ExecuteNonQuery(str);
            return result;
        }

        public bool XoaDocGia(string Ma)
        {
            //delete from DOCGIA where HoTen=N'Thoại'
            string str = "delete from DOCGIA where MaDocGia='" + Ma+"'";
            bool result = DataProvider.ExecuteNonQuery(str);
            return result;
        }
        
        public bool SuaDocGia(int madocgia, string hoten, string gioitinh, string namsinh)
        {
            //update DOCGIA Set HoTen= N'tu', GioiTinh=N'Nữ',NamSinh='2020-02-03' Where MaDocGia=1
            string str= "update DOCGIA Set HoTen = N'"+hoten+"', GioiTinh = N'"+gioitinh+"',NamSinh = '"+namsinh+"' Where MaDocGia ="+madocgia;
            bool result = DataProvider.ExecuteNonQuery(str);
                return result;

        }

        // select HoTen from DOCGIA where HoTen like N'%Phúc%'
        public DataTable timtheoten(string name)
        {
            string str = "select * from DOCGIA where HoTen like N'%"+name+"%'";
            DataTable dt = DataProvider.ExecuteQuery(str);
            return dt;
        }
    }
}

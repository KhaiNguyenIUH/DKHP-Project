using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BusinessEntity;
using System.Data.Linq;
namespace BusinessLogic
{
    public class SinhVienBLL
    {
        DKHPDataContext db;
        public SinhVienBLL()
        {

        }
        //public int laythongtinsv(int msv)
        //{
        //    using (db = new DKHPDataContext())
        //    {
        //        var user = db.SinhViens.Where(x => x.maSV == msv).FirstOrDefault();               
        //        user.hotenSV=
        //    }
        //    return 0;
        //}
        //public int ThemSV(eSinhVien s)
        //{
        //    if(s!= null)
        //    {
        //        SinhVien g = new SinhVien();
        //        db = new DKHPDataContext();
        //        g.maSV = s.MaSV1;
        //        g.hotenSV = s.Ten1;
        //        g.khoa = s.Khoa1;
        //        g.nganh = s.ChuyenNganh1;
        //        g.image=s

        //    }
        //    return 0;
        //}
    }
}

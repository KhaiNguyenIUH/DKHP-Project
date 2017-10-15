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

    public class SvDangKiBLL
    {
        DKHPDataContext db;
        public SvDangKiBLL()
        {
            db = new DKHPDataContext();
        }
        public List<eSVDangKi> laydsSVDangKi (int mactlhp)
        {
            List<eSVDangKi> s = new List<eSVDangKi>();
            var kq = db.SinhVienDangKies.Where(c => c.maChiTietLopHP == mactlhp).ToList();
            foreach (SinhVienDangKy b in kq )
            {
                s.Add(new eSVDangKi()
                {
                    MaSV=b.maSV.Value,
                    MaCTLHP=b.maChiTietLopHP.Value
                });
            }
            return s;
        }
        public int ThemSVDK(eSVDangKi h)
        {
            if(h!=null)
            {
                SinhVienDangKy v = new SinhVienDangKy();
                db = new DKHPDataContext();
                v.maSV = h.MaSV;
                v.maChiTietLopHP = h.MaCTLHP;
                db.SinhVienDangKies.InsertOnSubmit(v);
                db.SubmitChanges();
                return 1;
            }
            return 0;
        }
    }
}

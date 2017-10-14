using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using DAL;
namespace BusinessLogic
{
    public class TaiKhoanBLL
    {
        DKHPDataContext db;
        public TaiKhoanBLL()
        {

        }
        
        public int KiemTraDangNhap(int uname, string pass)
        {
            using (db = new DKHPDataContext())
            {
                var user = db.TaiKhoans.Where(x => x.maTK == uname).FirstOrDefault();
                if (user != null)
                    if (user.pass == pass)
                        if (user.quyentruycap == 1)
                            return 1;
                        else if (user.quyentruycap == 2)
                            return 2;
                return 4;
            }
            
        }
    }
}

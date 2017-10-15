using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntity
{
    public class eSVDangKi
    {
        private int maSV;
        private int maCTLHP;
        

        public int MaSV { get => maSV; set => maSV = value; }
        public int MaCTLHP { get => maCTLHP; set => maCTLHP = value; }
        public eSVDangKi()
        {

        }
        public eSVDangKi(int masvdk, int maSV, int maCTLHP)
        {
            this.maSV = maSV;
            this.maCTLHP = maCTLHP;
        }
    }
}

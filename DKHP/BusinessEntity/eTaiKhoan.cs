using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntity
{
    public class eTaiKhoan
    {
        private int maTK;
        private string Pass;
        private int Quyen;
        public int MaTK { get => maTK; set => maTK = value; }
        public string Pass1 { get => Pass; set => Pass = value; }
        public int Quyen1 { get => Quyen; set => Quyen = value; }
        public eTaiKhoan()
        {

        }
        public eTaiKhoan(int maTK, string pass, int quyen)
        {
            this.maTK = maTK;
            Pass = pass;
            Quyen = quyen;
        }
        
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntity
{
    public class eSinhVien
    {
        private int MaSV;
        private string Ten;
        private string Khoa;
        private string Lop;
        private string ChuyenNganh;

        public int MaSV1 { get => MaSV; set => MaSV = value; }
        public string Ten1 { get => Ten; set => Ten = value; }
        public string Khoa1 { get => Khoa; set => Khoa = value; }
        public string Lop1 { get => Lop; set => Lop = value; }
        public string ChuyenNganh1 { get => ChuyenNganh; set => ChuyenNganh = value; }
        public eSinhVien(int maSV, string ten, string khoa, string lop, string chuyenNganh)
        {
            MaSV = maSV;
            Ten = ten;
            Khoa = khoa;
            Lop = lop;
            ChuyenNganh = chuyenNganh;
        }
        public eSinhVien()
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HopDong
    {
        private string _MaHD;

        public string MaHD
        {
            get { return _MaHD; }
            set { _MaHD = value; }
        }

        private DateTime _NgayLap;

        public DateTime NgayLap
        {
            get { return _NgayLap; }
            set { _NgayLap = value; }
        }

        private DateTime _NgayHetHan;

        public DateTime NgayHetHan
        {
            get { return _NgayHetHan; }
            set { _NgayHetHan = value; }
        }

        private string _MaSV;

        public string MaSV
        {
            get { return _MaSV; }
            set { _MaSV = value; }
        }

        private int _SoPhong;

        public int SoPhong
        {
            get { return _SoPhong; }
            set { _SoPhong = value; }
        }

        private string _MaNV;

        public string MaNV
        {
            get { return _MaNV; }
            set { _MaNV = value; }
        }

        public HopDong() { }
        public HopDong(string mahd, DateTime ngaylap, DateTime ngayhethan, string masv, int sophong, string manv)
        {
            this._MaHD = mahd;
            this._NgayLap = ngaylap;
            this._NgayHetHan = ngayhethan;
            this._MaSV = masv;
            this._SoPhong = sophong;
            this._MaNV = manv;
        }
        
        
    }
}

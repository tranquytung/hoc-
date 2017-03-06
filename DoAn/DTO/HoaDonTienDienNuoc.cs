using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDonTienDienNuoc
    {
        private string _MaHDTDN;

        public string MaHDTDN
        {
            get { return _MaHDTDN; }
            set { _MaHDTDN = value; }
        }

        private DateTime _NgayLap;

        public DateTime NgayLap
        {
            get { return _NgayLap; }
            set { _NgayLap = value; }
        }

        private string _Thang;

        public string Thang
        {
            get { return _Thang; }
            set { _Thang = value; }
        }

        private int _SoPhong;

        public int SoPhong
        {
            get { return _SoPhong; }
            set { _SoPhong = value; }
        }

        private string _MaSV;

        public string MaSV
        {
            get { return _MaSV; }
            set { _MaSV = value; }
        }

        private string _MaNV;

        public string MaNV
        {
            get { return _MaNV; }
            set { _MaNV = value; }
        }

        private int _TongTien;

        public int TongTien
        {
            get { return _TongTien; }
            set { _TongTien = value; }
        }

        public HoaDonTienDienNuoc() { }
        public HoaDonTienDienNuoc(string mahd, DateTime ngaylap, string thang, int sophong, string masv, string manv, int tongtien)
        {
            this._MaHDTDN = mahd;
            this._NgayLap = ngaylap;
            this._Thang = thang;
            this._SoPhong = sophong;
            this._MaSV = masv;
            this._MaNV = manv;
            this._TongTien = tongtien;
        }
        
    }
}

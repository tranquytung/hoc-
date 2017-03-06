using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDongTienPhong
    {
        private string _MaHDTP;

        public string MaHDTP
        {
            get { return _MaHDTP; }
            set { _MaHDTP = value; }
        }

        private DateTime _NgayLap;

	public DateTime NgayLap
	{
		get { return _NgayLap;}
		set { _NgayLap = value;}
	}
	

        private string _KyThu;

        public string KyThu
        {
            get { return _KyThu; }
            set { _KyThu = value; }
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

        public HoaDongTienPhong() { }
        public HoaDongTienPhong(string mahd, DateTime ngaylap, string kythu, string masv, string manv, int tongtien)
        {
            this._MaHDTP = mahd;
            this._NgayLap = ngaylap;
            this._KyThu = kythu;
            this._MaSV = masv;
            this._MaNV = manv;
            this._TongTien = tongtien;
        }
    }
}

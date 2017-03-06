using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SinhVien
    {
        private string _MaSV;

        public string MaSV
        {
            get { return _MaSV; }
            set { _MaSV = value; }
        }

        private string _TenSV;

        public string TenSV
        {
            get { return _TenSV; }
            set { _TenSV = value; }
        }

        private DateTime _NgaySinh;

        public DateTime NgaySinh
        {
            get { return _NgaySinh; }
            set { _NgaySinh = value; }
        }

        private string _GioiTinh;

        public string GioiTinh
        {
            get { return _GioiTinh; }
            set { _GioiTinh = value; }
        }

        private string _QueQuan;

        public string QueQuan
        {
            get { return _QueQuan; }
            set { _QueQuan = value; }
        }

        private int _CMT;

        public int CMT
        {
            get { return _CMT; }
            set { _CMT = value; }
        }

        private string _SoDT;

        public string SoDT
        {
            get { return _SoDT; }
            set { _SoDT = value; }
        }

        private string _ChinhSach;

        public string ChinhSach
        {
            get { return _ChinhSach; }
            set { _ChinhSach = value; }
        }

        public SinhVien() { }
        public SinhVien(string masv, string tensv,string gioitinh, string quequan, string sdt, string chinhsach)
        {
            this._MaSV = masv;
            this._TenSV = tensv;
            this._GioiTinh = gioitinh;
            this._QueQuan = quequan;
            this._SoDT = sdt;
            this._ChinhSach = chinhsach;
        }
        public SinhVien(string masv, string tensv, DateTime ngaysinh, string gioitinh, string quequan, int cmt, string sdt, string chinhsach)
        {
            this._MaSV = masv;
            this._TenSV = tensv;
            this._NgaySinh = ngaysinh;
            this._GioiTinh = gioitinh;
            this._QueQuan = quequan;
            this._CMT = cmt;
            this._SoDT = sdt;
            this._ChinhSach = chinhsach;
        }

    }
}

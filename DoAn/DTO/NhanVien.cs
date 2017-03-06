using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien
    {
        private string _MaNV;

        public string MaNV
        {
            get { return _MaNV; }
            set { _MaNV = value; }
        }

        private string _TenNV;

        public string TenNV
        {
            get { return _TenNV; }
            set { _TenNV = value; }
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

        private string _ChucVu;

        public string ChucVu
        {
            get { return _ChucVu; }
            set { _ChucVu = value; }
        }

        private int _CMT;

        public int CMT
        {
            get { return _CMT; }
            set { _CMT = value; }
        }

        private string _SDT;

        public string SDT
        {
            get { return _SDT; }
            set { _SDT = value; }
        }

        private string _TrangThai;

        public string TrangThai
        {
            get { return _TrangThai; }
            set { _TrangThai = value; }
        }
        

        public NhanVien() { }
        public NhanVien(string manv, string tennv, string gioitinh, string quequan, string chucvu, string sdt, string trangthai)
        {
            this._MaNV = manv;
            this._TenNV = tennv;
            this._GioiTinh = gioitinh;
            this._QueQuan = quequan;
            this._ChucVu = chucvu;
            this._SDT = sdt;
            this._TrangThai = trangthai;
        }
        public NhanVien(string manv, string tennv, DateTime ngaysinh, string gioitinh, string quequan, string chucvu, int cmt, string sdt, string trangthai)
        {
            this._MaNV = manv;
            this._TenNV = tennv;
            this._NgaySinh = ngaysinh;
            this._GioiTinh = gioitinh;
            this._QueQuan = quequan;
            this._ChucVu = chucvu;
            this._CMT = cmt;
            this._SDT = sdt;
            this._TrangThai = trangthai;
        }
    }
}

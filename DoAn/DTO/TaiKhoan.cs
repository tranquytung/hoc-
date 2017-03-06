using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoan
    {
        private string _TenDN;

        public string TenDN
        {
            get { return _TenDN; }
            set { _TenDN = value; }
        }

        private string _MatKhau;

        public string MatKhau
        {
            get { return _MatKhau; }
            set { _MatKhau = value; }
        }

        private string _PhanQuyen;

        public string PhanQuyen
        {
            get { return _PhanQuyen; }
            set { _PhanQuyen = value; }
        }

        public TaiKhoan() { }
        public TaiKhoan(string tendn)
        {
            this._TenDN = tendn;
            this._MatKhau = "123";
        }
        public TaiKhoan(string tendn, string phanquyen)
        {
            this._TenDN = tendn;
            this._MatKhau = "123";
            this._PhanQuyen = phanquyen;
        }
        public TaiKhoan(string tendn, string mk, string phanquyen)
        {
            this._TenDN = tendn;
            this._MatKhau = mk;
            this._PhanQuyen = phanquyen;
        }
        
    }
}

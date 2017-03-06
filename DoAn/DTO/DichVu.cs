using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DichVu
    {
        private string _MaDV;

        public string MaDV
        {
            get { return _MaDV; }
            set { _MaDV = value; }
        }

        private string _TenDV;

        public string TenDV
        {
            get { return _TenDV; }
            set { _TenDV = value; }
        }

        private int _Gia;

        public int Gia
        {
            get { return _Gia; }
            set { _Gia = value; }
        }

        public DichVu() { }
        public DichVu(string madv, int gia)
        {
            this._MaDV = madv;
            this._Gia = gia;
        }
        public DichVu(string madv, string tendv, int gia)
        {
            this._MaDV = madv;
            this._TenDV = tendv;
            this._Gia = gia;
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SoGhiDienNuoc
    {
        private int _Id;

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
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
        

        private int _SoDien;

        public int SoDien
        {
            get { return _SoDien; }
            set { _SoDien = value; }
        }

        private int _SoNuoc;

        public int SoNuoc
        {
            get { return _SoNuoc; }
            set { _SoNuoc = value; }
        }

        public SoGhiDienNuoc() { }
        public SoGhiDienNuoc(int id, string thang, int sophong, int sodien, int sonuoc)
        {
            this._Id = id;
            this._Thang = thang;
            this._SoPhong = sophong;
            this._SoDien = sodien;
            this._SoNuoc = sonuoc;
        }
        
    }
}

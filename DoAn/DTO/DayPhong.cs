using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DayPhong
    {
        private string _MaDay;

        public string MaDay
        {
            get { return _MaDay; }
            set { _MaDay = value; }
        }

        private string _LoaiPhong;

        public string LoaiPhong
        {
            get { return _LoaiPhong; }
            set { _LoaiPhong = value; }
        }

        private string _MaNV;

        public string MaNV
        {
            get { return _MaNV; }
            set { _MaNV = value; }
        }

        public DayPhong() { }
        public DayPhong(string maday, string loaiphong, string manv)
        {
            this._MaDay = maday;
            this._LoaiPhong = loaiphong;
            this._MaNV = manv;
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Phong
    {
        private int _SoPhong;

        public int SoPhong
        {
            get { return _SoPhong; }
            set { _SoPhong = value; }
        }

        private int _SucChua;

        public int SucChua
        {
            get { return _SucChua; }
            set { _SucChua = value; }
        }

        private int _SoSVHT;

        public int SoSVHT
        {
            get { return _SoSVHT; }
            set { _SoSVHT = value; }
        }

        private string _MaDay;

        public string MaDay
        {
            get { return _MaDay; }
            set { _MaDay = value; }
        }

        private string _TrangThai;

        public string TrangThai
        {
            get { return _TrangThai; }
            set { _TrangThai = value; }
        }


        public Phong() { }
        public Phong(int sophong, int succhua, int sosvht, string maday, string trangthai)
        {
            this._SoPhong = sophong;
            this._SucChua = succhua;
            this._SoSVHT = sosvht;
            this._MaDay = maday;
            this._TrangThai = trangthai;
        }
	
    }
}

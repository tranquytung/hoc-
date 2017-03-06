using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Utility
    {
        
        public string ChuanHoaXau(string xau)
        {
            string s = xau.Trim();
            while (s.IndexOf("  ") >= 0) s = s.Remove(s.IndexOf("  "),1);
            string[] a = s.Split(' ');
            string xaumoi = "";
            foreach(string str in a)
            {
                xaumoi = xaumoi + char.ToUpper(str[0]) + str.Substring(1).ToLower() + " ";
            }
            xaumoi = xaumoi.Trim();
            return xaumoi;
        }

        public string XuLyNgay(DateTime dt)
        {
            int ngay = dt.Day, thang = dt.Month, nam = dt.Year;
            string strngay = ngay.ToString();
            string strthang = thang.ToString();
            string strnam = nam.ToString();
            if (ngay < 10) strngay = '0' + strngay;
            if (thang < 10) strthang = '0' + strthang;
            return strthang + '/' + strngay + '/' + strnam;
        }

        public static byte[] encryptData(string data)
        {
            System.Security.Cryptography.MD5CryptoServiceProvider md5Hasher = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] hashedBytes;
            System.Text.UTF8Encoding encoder = new System.Text.UTF8Encoding();
            hashedBytes = md5Hasher.ComputeHash(encoder.GetBytes(data));
            return hashedBytes;
        }
        public static string md5(string data)
        {
            return BitConverter.ToString(encryptData(data)).Replace("-", "").ToLower();
        }
    }
}

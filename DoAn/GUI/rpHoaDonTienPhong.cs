using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class rpHoaDonTienPhong : Form
    {
        string mahd = "";
        public rpHoaDonTienPhong(string mahd)
        {
            InitializeComponent();
            this.mahd = mahd;
        }

        private void rpHoaDonTienPhong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.HoaDonTienPhong' table. You can move, or remove it, as needed.
            this.HoaDonTienPhongTableAdapter.Fill(this.DataSet1.HoaDonTienPhong, mahd);

            this.reportViewer1.RefreshReport();
        }
    }
}

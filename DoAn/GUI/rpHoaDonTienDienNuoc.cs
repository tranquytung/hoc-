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
    public partial class rpHoaDonTienDienNuoc : Form
    {
        string mahd = "";
        public rpHoaDonTienDienNuoc(string mahd)
        {
            InitializeComponent();
            this.mahd = mahd;
        }

        private void rpHoaDonTienDienNuoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.HoaDonTienDienNuoc' table. You can move, or remove it, as needed.
            this.HoaDonTienDienNuocTableAdapter.Fill(this.DataSet1.HoaDonTienDienNuoc, mahd);

            this.reportViewer1.RefreshReport();
        }

      
    }
}

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
    public partial class rpHopDong : Form
    {
        string mahd = "";
        public rpHopDong(string mahd)
        {
            InitializeComponent();
            this.mahd = mahd;
        }

        private void rpHopDong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.HopDong' table. You can move, or remove it, as needed.
            this.HopDongTableAdapter.Fill(this.DataSet1.HopDong, mahd);

            this.reportViewer1.RefreshReport();
        }

      
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace quanlybanhang
{
    public partial class ThongKeKhoHang : DevExpress.XtraEditors.XtraUserControl
    {
        public ThongKeKhoHang()
        {
            InitializeComponent();
        }

        public hethong MdiParent { get; internal set; }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

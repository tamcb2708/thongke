using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace quanlybanhang
{
    public partial class hethong : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public hethong()
        {
            InitializeComponent();
        }

        private void hethong_Load(object sender, EventArgs e)
        {

        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            ThongKeKhoHang tkkh = new ThongKeKhoHang();
            tkkh.MdiParent = this;
            tkkh.Show();

        }

        private void ht_thoat_ItemClick(object sender, ItemClickEventArgs e)
        {
            base.Close();
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
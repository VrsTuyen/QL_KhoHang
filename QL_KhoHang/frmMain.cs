using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_KhoHang
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void hàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHanghoa hh = new frmHanghoa();
            this.Hide();
            hh.ShowDialog();
            
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhachhang kh = new frmKhachhang();
            this.Hide();
            kh.ShowDialog();

        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhanvien nv = new frmNhanvien();
            this.Hide();
            nv.ShowDialog();
        }

        private void khoHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhohang kh = new frmKhohang();
            this.Hide();
            kh.ShowDialog();

        }

        private void đơnĐặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoadon hd = new frmHoadon();
            this.Hide();
            hd.ShowDialog();
        }

        private void phiếuNhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhieunhap ph = new frmPhieunhap();
            this.Hide();
            ph.ShowDialog();
            
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmDangnhap dn = new frmDangnhap();
            this.Hide();
            dn.ShowDialog();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_KhoHang.Model;

namespace QL_KhoHang
{
    public partial class frmKhohang : Form
    {
        public frmKhohang()
        {
            InitializeComponent();
        }
        DataTable table;
        String sql;
        private void frmKhohang_Load(object sender, EventArgs e)
        {
            sql = "select * from tbl_KhoHang";
            table = Data.Table(sql);
            dvKhohang.DataSource = table;
            dvKhoHang.Colunm
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

        }

        private void dvKhohang_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

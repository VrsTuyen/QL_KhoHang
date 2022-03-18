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
    public partial class frmPhieunhap : Form
    {
        public frmPhieunhap()
        {
            InitializeComponent();
        }
        int index;
        DataTable table;
        private void frmPhieunhap_Load(object sender, EventArgs e)
        {
            String sql = "select * from tbl_PhieuNhap";
            table = Data.Table(sql);
            dvNhap.DataSource = table;
            dvNhap.Columns[0].HeaderText = "Mã phiếu";
            dvNhap.Columns[01].HeaderText = "Mã nhân viên";
            dvNhap.Columns[02].HeaderText = "Ngày nhập";
            dvNhap.Columns[03].HeaderText = "Tổng tiền";

            dvNhap.Columns[0].Width = 150;
            dvNhap.Columns[01].Width = 180;
            dvNhap.Columns[02].Width = 200;
            dvNhap.Columns[03].Width = 240;

            dvNhap.SelectionMode = DataGridViewSelectionMode.FullRowSelect;



        }

        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            frmPhieunhapCT ct = new frmPhieunhapCT();
            ct.Tag = "T";
            ct.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            frmPhieunhapCT ct = new frmPhieunhapCT();
            ct.Tag = this.Tag;
            ct.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                String sql = "delete from tbl_PhieuNhapChiTiet where Maphieu = '" + dvNhap.Rows[index].Cells[0].Value.ToString() + "'";
                Data.SQL(sql);

                sql = "delete from tbl_PhieuNhap where Maphieu = '" + dvNhap.Rows[index].Cells[0].Value.ToString() + "'";
                Data.SQL(sql);
                table.Rows[index].Delete();
            }
        }

        private void dvNhap_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (table.Rows.Count != 0)
            {
                this.Tag = dvNhap.Rows[index].Cells[0].Value.ToString();
            }
        }

        private void frmPhieunhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMain m = new frmMain();
            this.Hide();
            m.ShowDialog();
        }
    }
}

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
    public partial class frmHoadon : Form
    {
        public frmHoadon()
        {
            InitializeComponent();
        }
        DataTable table;
        int index;
        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            frmHoadonCT ct = new frmHoadonCT();
            ct.Tag = "T";
            ct.Show();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            frmHoadonCT ct = new frmHoadonCT();
            ct.Tag = this.Tag;
            ct.Show();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                String sql = "delete from tbl_HoaDonChiTiet where Mahoadon = '"+ dvHoadon.Rows[index].Cells[0].Value.ToString() + "'";
                Data.SQL(sql);
                    
                sql = "delete from tbl_HoaDon where Mahoadon = '"+dvHoadon.Rows[index].Cells[0].Value.ToString()+"'";
                Data.SQL(sql);
                table.Rows[index].Delete();
            }
            
        }

        private void frmHoadon_Load(object sender, EventArgs e)
        {
            string sql = "select tbl_HoaDon.Mahoadon, tbl_NhanVien.Manhanvien, tbl_KhachHang.Hoten, Ngaymua, Tongtien from tbl_HoaDon inner join tbl_NhanVien on tbl_NhanVien.Manhanvien = tbl_HoaDon.Manhanvien inner join tbl_KhachHang on tbl_HoaDon.Makhach = tbl_KhachHang.Makhach";
            table = Data.Table(sql);
            dvHoadon.DataSource = table;
            dvHoadon.Columns[0].HeaderText = "Mã hóa đơn";
            dvHoadon.Columns[01].HeaderText = "Mã nhân viên";
            dvHoadon.Columns[02].HeaderText = "Khách hàng";
            dvHoadon.Columns[03].HeaderText = "Ngày mua";
            dvHoadon.Columns[04].HeaderText = "Tổng tiền";

            dvHoadon.Columns[0].Width = 150;
            dvHoadon.Columns[01].Width = 180;
            dvHoadon.Columns[02].Width = 200;
            dvHoadon.Columns[03].Width = 150;
            dvHoadon.Columns[04].Width = 180;
            dvHoadon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void dvHoadon_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (table.Rows.Count != 0)
            {
                this.Tag = dvHoadon.Rows[index].Cells[0].Value.ToString();
            }
           
        }

        private void frmHoadon_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMain m = new frmMain();
            this.Hide();
            m.ShowDialog();
        }
    }
}

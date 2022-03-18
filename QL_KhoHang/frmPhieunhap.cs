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
        String sql;
        DataTable table, tb;
        int index;

        private void frmPhieunhap_Load(object sender, EventArgs e)
        {
            sql = "select * from tbl_NhanVien";
            tb = Data.Table(sql);
            cbNhanvien.DataSource = tb;
            cbNhanvien.DisplayMember = "Hoten";
            cbNhanvien.ValueMember = "Manhanvien";
            cbNhanvien.DropDownStyle = ComboBoxStyle.DropDownList;


            sql = "select * from tbl_HangHoa";
            tb = Data.Table(sql);
            cbHanghoa.DataSource = tb;
            cbHanghoa.DisplayMember = "Tenhang";
            cbHanghoa.ValueMember = "Mahang";
            cbHanghoa.DropDownStyle = ComboBoxStyle.DropDownList;

            sql = "select tbl_PhieuNhap.Maphieu, Manhanvien, tbl_PhieuNhapChiTiet.Mahang, Soluong, Dongia,Thanhtien from tbl_PhieuNhap inner join tbl_PhieuNhapChiTiet on tbl_PhieuNhap.Maphieu = tbl_PhieuNhapChiTiet.Maphieu;";
            table = Data.Table(sql);
            dvNhap.DataSource = table;
            dvNhap.Columns[0].HeaderText = "Mã phiếu";
            dvNhap.Columns[1].HeaderText = "Mã nhân viên";
            dvNhap.Columns[02].HeaderText = "Mã hàng";
            dvNhap.Columns[03].HeaderText = "Số lượng";
            dvNhap.Columns[04].HeaderText = "Đơn giá";
            dvNhap.Columns[05].HeaderText = "Thành tiền";

            dvNhap.Columns[0].Width = 150 ;
            dvNhap.Columns[01].Width = 180;
            dvNhap.Columns[02].Width = 150;
            dvNhap.Columns[03].Width = 150;
            dvNhap.Columns[04].Width = 180;
            dvNhap.Columns[05].Width = 200;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
           if(!txtMaphieu.Text.Equals("") && !txtDongia.Text.Equals("") && !txtSL.Text.Equals(""))
            {
                sql = "insert into tbl_PhieuNhap values('"+txtMaphieu.Text+"','"+cbNhanvien.SelectedValue+"','"+dtNgaynhap.Value+"','"+lb.Text+"')";
                Data.SQL(sql);
                sql = "insert into tbl_PhieuNhapChiTiet values('"+txtMaphieu.Text+"','"+cbHanghoa.SelectedValue+"','"+txtSL.Text+"','"+txtDongia.Text+"',)";
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void cbHanghoa_SelectionChangeCommitted(object sender, EventArgs e)
        {
            sql = "select Dongia, Soluong from tbl_Hanghoa where Mahang = '" + cbHanghoa.SelectedValue + "'";
            tb = Data.Table(sql);
            txtDongia.Text = tb.Rows[0][0].ToString().Trim();
            txtSL.Text = tb.Rows[0][1].ToString().Trim();
        }

        private void txtSL_TextChanged(object sender, EventArgs e)
        {
            if (!txtDongia.Text.Equals("") && !txtSL.Text.Equals(""))
            {
                int sl = int.Parse(txtSL.Text.Trim());
                int dg = int.Parse(txtDongia.Text.Trim());

                lb.Text = sl * dg + "";
            }
            else return;

        }

        private void txtDongia_TextChanged(object sender, EventArgs e)
        {
            if (!txtDongia.Text.Equals("") && !txtSL.Text.Equals(""))
            {
                int sl = int.Parse(txtSL.Text.Trim());
                int dg = int.Parse(txtDongia.Text.Trim());

                lb.Text = sl * dg + "";
            }
            else return;
        }

        private void txtSL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDongia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            
        }

    }
}

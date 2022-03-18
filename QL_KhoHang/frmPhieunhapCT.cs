using QL_KhoHang.Model;
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
    public partial class frmPhieunhapCT : Form
    {
        public frmPhieunhapCT()
        {
            InitializeComponent();
        }
        DataTable table;
        int TT;

        private void frmPhieunhapCT_Load(object sender, EventArgs e)
        {
            /* String sql = "select * from tbl_HangHoa";
             table = Data.Table(sql);
             cbHanghoa.DataSource = table;
             cbHanghoa.DisplayMember = "Tenhang";
             cbHanghoa.ValueMember = "Mahang";
             cbHanghoa.DropDownStyle = ComboBoxStyle.DropDownList;*/
            String sql;

            sql = "select * from tbl_NhanVien";
            cbNhanvien.DataSource = Data.Table(sql);
            cbNhanvien.DisplayMember = "Hoten";
            cbNhanvien.ValueMember = "Manhanvien";
            cbNhanvien.DropDownStyle = ComboBoxStyle.DropDownList;

            DataGridViewColumn dgvc = new DataGridViewColumn();
            DataGridViewCell cell = new DataGridViewTextBoxCell();

            DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn();
            sql = "select * from tbl_HangHoa";
            table = Data.Table(sql);
            for (int i = 0; i < table.Rows.Count; i++)
            {
                comboBoxColumn.Items.Add(table.Rows[i][0]);
            }
            comboBoxColumn.HeaderText = "Mã hàng";
            dtv.Columns.Add(comboBoxColumn);



            dgvc.HeaderText = "Số lượng";
            dgvc.Name = "Soluong";
            dgvc.Width = 120;
            dgvc.CellTemplate = cell;
            dtv.Columns.Add(dgvc);

            DataGridViewColumn d1 = new DataGridViewColumn();
            d1.HeaderText = "Đơn giá";
            d1.Name = "Dongia";
            d1.Width = 180;
            d1.CellTemplate = cell;
            dtv.Columns.Add(d1);

            DataGridViewColumn d2 = new DataGridViewColumn();
            d2.HeaderText = "Thành Tiền";
            d2.Name = "Thanhtien";
            d2.Width = 180;
            d2.CellTemplate = cell;
            dtv.Columns.Add(d2);



            if (Tag.ToString() == "T")
            {
                lbMaphieu.Text = String.Format("{0:ddMMyyyyhhmmss}", DateTime.Now);
                dtNgaynhap.Value = DateTime.Today;
            }
            else
            {
                String mahd = this.Tag.ToString();
                sql = "select Manhanvien,Ngaynhap, Tongtien from tbl_PhieuNhap where Maphieu = '" + mahd + "'";
                table = Data.Table(sql);
                lbMaphieu.Text = mahd;
                dtNgaynhap.Value = DateTime.Parse(table.Rows[0][1].ToString());
                lbTT.Text = table.Rows[0][2].ToString().Trim();

                sql = "select Mahang, Soluong,Dongia, Thanhtien from tbl_PhieuNhapChiTiet where Maphieu = '" + mahd + "'";
                table = Data.Table(sql);
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    String[] row = new string[]
                    {
                        table.Rows[i][0].ToString(),
                        table.Rows[i][01].ToString(),
                        table.Rows[i][02].ToString(),
                        table.Rows[i][03].ToString(),
                    };
                    dtv.Rows.Add(row);
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dtv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dtv.CurrentRow.Index >= 0)
            {
                if (dtv.CurrentCell.ColumnIndex == 0)
                {
                    String sql = "select Dongia from  tbl_HangHoa where Mahang = '" + dtv.CurrentRow.Cells[0].Value.ToString() + "'";
                    table = Data.Table(sql);
                    dtv.CurrentRow.Cells[1].Value = 1;
                    dtv.CurrentRow.Cells[2].Value = table.Rows[0][0].ToString();
                    dtv.CurrentRow.Cells[3].Value = table.Rows[0][0].ToString();
                }
                if (dtv.CurrentCell.ColumnIndex == 1)
                {
                    int tt, sl, dg;
                    sl = int.Parse(dtv.CurrentRow.Cells[1].Value.ToString());
                    dg = int.Parse(dtv.CurrentRow.Cells[2].Value.ToString());
                    tt = sl * dg;
                    dtv.CurrentRow.Cells[3].Value = tt.ToString();

                    
                    
                }
                TT = 0;
                for (int i = 0; i < dtv.Rows.Count - 1; i++)
                {
                    TT = TT + int.Parse(dtv.Rows[i].Cells[3].Value.ToString());

                }
                lbTT.Text = TT.ToString();

            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            String sql;
            if (this.Tag.ToString() == "T")
            {
                sql = "insert into tbl_PhieuNhap values('" + lbMaphieu.Text + "','" + cbNhanvien.SelectedValue + "','" + dtNgaynhap.Value + "','" + lbTT.Text + "')";
                Data.SQL(sql);
            }
            else
            {
                sql = "update tbl_PhieuNhap set Manhanvien = '" + cbNhanvien.SelectedValue + "',Ngaynhap = '" + dtNgaynhap.Value + "', Tongtien = '" + lbTT.Text + "' where Maphieu = '" + lbMaphieu.Text + "'";
                Data.SQL(sql);

            }
            for (int i = 0; i < dtv.Rows.Count - 1; i++)
            {
                sql = "select * from tbl_PhieuNhapChiTiet where Mahang = '" + dtv.Rows[i].Cells[0].Value + "' and Maphieu = '" + lbMaphieu.Text + "'";
                table = Data.Table(sql);
                if (table.Rows.Count == 0)
                {
                    DataGridViewRow r = new DataGridViewRow();
                    r = dtv.Rows[i];
                    sql = "insert into tbl_PhieuNhapChiTiet values('" + lbMaphieu.Text + "','" + r.Cells[0].Value.ToString() + "','" + r.Cells[1].Value.ToString() + "','" + r.Cells[2].Value.ToString() + "','" + r.Cells[3].Value.ToString() + "')";
                    Data.SQL(sql);
                }
                else
                {
                    DataGridViewRow r = new DataGridViewRow();
                    r = dtv.Rows[i];
                    sql = "update tbl_PhieuNhapChiTiet set Soluong = '" + r.Cells[1].Value + "', Thanhtien = '" + r.Cells[3].Value + "', Dongia = '" + r.Cells[2].Value + "' where Maphieu = '" + lbMaphieu.Text + "' and Mahang = '" + r.Cells[0].Value + "'";
                    Data.SQL(sql);
                }

            }
            MessageBox.Show("Thành Công","Thông Báo");
        }

        private void frmPhieunhapCT_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmPhieunhap ph = new frmPhieunhap();
            this.Hide();
            ph.ShowDialog();
        }
    }
}

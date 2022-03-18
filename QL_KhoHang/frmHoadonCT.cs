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
    public partial class frmHoadonCT : Form
    {
        public frmHoadonCT()
        {
            InitializeComponent();
        }
        DataTable table;
        int Tongt;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            String sql;
            if (this.Tag.ToString() == "T")
            {
                 sql = "insert into tbl_HoaDon values('"+lbMaHD.Text+"','"+cbKhach.SelectedValue+"','"+cbNhanvien.SelectedValue+"','"+dtMua.Value+"','"+lbTongtien.Text+"')";
                Data.SQL(sql);
            }
            else
            {
                sql = "update tbl_HoaDon set Makhach = '"+cbKhach.SelectedValue+"',Manhanvien = '"+cbNhanvien.SelectedValue+"',Ngaymua = '"+dtMua.Value+"', Tongtien = '"+lbTongtien.Text+"' where Mahoadon = '"+lbMaHD.Text+"'";
                Data.SQL(sql);

            }
            for(int i = 0; i< dvHDCT.Rows.Count - 1; i++)
            {
                sql = "select * from tbl_HoaDonChiTiet where Mahang = '"+dvHDCT.Rows[i].Cells[0].Value+"' and Mahoadon = '"+lbMaHD.Text+"'";
                table = Data.Table(sql);
                if(table.Rows.Count == 0)
                {
                    DataGridViewRow r = new DataGridViewRow();
                    r = dvHDCT.Rows[i];
                    sql = "insert into tbl_HoaDonChiTiet values('"+lbMaHD.Text+"','"+r.Cells[0].Value.ToString()+"','"+r.Cells[1].Value.ToString()+"','"+r.Cells[2].Value.ToString()+"','"+r.Cells[3].Value.ToString()+"')";
                    Data.SQL(sql);
                }
                else
                {
                    DataGridViewRow r = new DataGridViewRow();
                    r = dvHDCT.Rows[i];
                    sql = "update tbl_HoaDonChiTiet set Soluong = '"+r.Cells[1].Value+"', Thanhtien = '"+ r.Cells[3].Value + "', Dongia = '"+ r.Cells[2].Value + "' where Mahoadon = '"+lbMaHD.Text+"' and Mahang = '"+ r.Cells[0].Value + "'";
                    Data.SQL(sql);
                }
                
            }
            MessageBox.Show("Thành Công","Thông Báo");
        }

        private void frmHoadonCT_Load(object sender, EventArgs e)
        {
            String sql = "select * from tbl_Khachhang";
            cbKhach.DataSource = Data.Table(sql);
            cbKhach.DisplayMember = "Hoten";
            cbKhach.ValueMember = "Makhach";
            cbKhach.DropDownStyle = ComboBoxStyle.DropDownList;

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
           for(int i = 0; i< table.Rows.Count; i++)
            {
                comboBoxColumn.Items.Add(table.Rows[i][0]);
            }
            comboBoxColumn.HeaderText = "Mã hàng";
            dvHDCT.Columns.Add(comboBoxColumn);


            dgvc.HeaderText = "Số lượng";
            dgvc.Name = "Soluong";
            dgvc.Width = 120;
            dgvc.CellTemplate = cell;
            dvHDCT.Columns.Add(dgvc);

            DataGridViewColumn d1 = new DataGridViewColumn();
            d1.HeaderText = "Đơn giá";
            d1.Name = "Dongia";
            d1.Width = 180;
            d1.CellTemplate = cell;
            dvHDCT.Columns.Add(d1);
            
            DataGridViewColumn d2 = new DataGridViewColumn();
            d2.HeaderText = "Thành Tiền";
            d2.Name = "Thanhtien";
            d2.Width = 180;
            d2.CellTemplate = cell;
            dvHDCT.Columns.Add(d2);


            
            if (Tag.ToString() == "T")
            {
                lbMaHD.Text = String.Format("{0:ddMMyyyyhhmmss}", DateTime.Now);
                dtMua.Value = DateTime.Today;
            }
            else
            {
                String mahd = this.Tag.ToString();
                sql = "select Makhach, Ngaymua, Tongtien from tbl_HoaDon where Mahoadon = '"+ mahd + "'";
                table = Data.Table(sql);
                lbMaHD.Text = mahd;
                cbKhach.SelectedValue = table.Rows[0][0].ToString().Trim();
                dtMua.Value = DateTime.Parse(table.Rows[0][1].ToString().Trim());
                lbTongtien.Text = table.Rows[0][2].ToString().Trim();

                sql = "select Mahang, Soluong,Dongia, Thanhtien from tbl_HoaDonChiTiet where Mahoadon = '"+mahd+"'";
                table = Data.Table(sql);
                for(int i = 0; i< table.Rows.Count; i++)
                {
                    String[] row = new string[]
                    {
                        table.Rows[i][0].ToString(),
                        table.Rows[i][01].ToString(),
                        table.Rows[i][02].ToString(),
                        table.Rows[i][03].ToString(),
                    };
                    dvHDCT.Rows.Add(row);
                }
            }

        }

        private void dvHDCT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dvHDCT_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dvHDCT.CurrentRow.Index >= 0)
            {
                if (dvHDCT.CurrentCell.ColumnIndex == 0)
                {
                    String sql = "select Dongia from  tbl_HangHoa where Mahang = '" + dvHDCT.CurrentRow.Cells[0].Value.ToString() + "'";
                    table = Data.Table(sql);
                    dvHDCT.CurrentRow.Cells[1].Value = 1;
                    dvHDCT.CurrentRow.Cells[2].Value = table.Rows[0][0].ToString();
                    dvHDCT.CurrentRow.Cells[3].Value = table.Rows[0][0].ToString();
                }
                if(dvHDCT.CurrentCell.ColumnIndex == 1)
                {
                    int tt, sl, dg;
                    sl = int.Parse(dvHDCT.CurrentRow.Cells[1].Value.ToString()) ;
                    dg = int.Parse(dvHDCT.CurrentRow.Cells[2].Value.ToString()) ;
                    tt = sl * dg;
                    dvHDCT.CurrentRow.Cells[3].Value = tt.ToString();

                    
                }
                Tongt = 0;
                for (int i = 0; i < dvHDCT.Rows.Count - 1; i++)
                {
                    Tongt = Tongt + int.Parse(dvHDCT.Rows[i].Cells[3].Value.ToString());

                }
                lbTongtien.Text = Tongt.ToString();

            }
        }

        private void frmHoadonCT_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmHoadon hd = new frmHoadon();
            this.Hide();
            hd.ShowDialog();
        }
    }
}

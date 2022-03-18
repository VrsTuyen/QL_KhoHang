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
    public partial class frmHanghoa : Form
    {
        public frmHanghoa()
        {
            InitializeComponent();
        }
        String sql;
        DataTable table, tb;
        int index;
        private void btnThem_Click(object sender, EventArgs e)
        {
           if(!txtMahang.Text.Equals("") && !txtTenhang.Text.Equals("") && !txtSoluong.Text.Equals("") && !txtDVT.Text.Equals("") && !txtDongia.Text.Equals(""))
            {
                sql = "select count(*) from tbl_HangHoa where Makho = '"+txtMahang.Text+"'";
                if(Data.Counter(sql) != 0)
                {
                    MessageBox.Show("Mặt hàng đã tồn tại","Thông báo");return;
                }
                else
                {
                    sql = "insert into tbl_HangHoa values('"+txtMahang.Text+"',N'"+txtTenhang.Text+"','"+txtDongia.Text+"','"+txtSoluong.Text+"',N'"+txtDVT.Text+"','"+cbKho.SelectedValue+"')";
                    Data.SQL(sql);
                    table.Rows.Add(txtMahang.Text,txtTenhang.Text,txtDongia.Text, txtSoluong.Text,txtDVT.Text, cbKho.SelectedValue);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Thông báo");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!txtMahang.Text.Equals("") && !txtTenhang.Text.Equals("") && !txtSoluong.Text.Equals("") && !txtDVT.Text.Equals("") && !txtDongia.Text.Equals(""))
            {
                sql = "select count(*) from tbl_HangHoa where Mahang = '" + txtMahang.Text + "'";
                if (Data.Counter(sql) != 0)
                {
                    sql = "update tbl_HangHoa set Tenhang = N'" + txtTenhang.Text + "', Dongia = '" + txtDongia.Text + "', Soluong = '" + txtSoluong.Text + "',DVT = N'" + txtDVT.Text + "', Makho = '" + cbKho.SelectedValue + "' where Mahang = '" + txtMahang.Text + "'";
                    Data.SQL(sql);
                    table.Rows[index][0] = txtMahang.Text;
                    table.Rows[index][1] = txtTenhang.Text;
                    table.Rows[index][02] = txtDongia.Text;
                    table.Rows[index][03] = txtSoluong.Text;
                    table.Rows[index][04] = txtDVT.Text;
                    table.Rows[index][05] = cbKho.SelectedValue;

                }
                else
                {
                    MessageBox.Show("Không tìm thấy mặt hàng", "Thông báo"); return;
                    
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Thông báo"); return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa khách hàng: " + txtMahang.Text + "? ", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (!txtMahang.Text.Equals(""))
                {
                    sql = "delete from tbl_HangHoa where Mahang = '" + txtMahang.Text + "'";
                    Data.SQL(sql);
                    table.Rows[index].Delete();
                }
                else
                {
                    MessageBox.Show("Chọn hàng cần xóa", "Thông Báo"); return;
                }
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if (!txtMahang.Text.Equals(""))
            {
                sql = "select * from tbl_HangHoa where Mahang = '"+txtMahang.Text+"'";
                tb = Data.Table(sql);
                if(tb.Rows.Count != 0)
                {
                txtTenhang.Text = tb.Rows[0][1].ToString().Trim();
                txtDongia.Text = tb.Rows[0][2].ToString().Trim();
                txtSoluong.Text = tb.Rows[0][3].ToString().Trim();
                txtDVT.Text = tb.Rows[0][4].ToString().Trim();
                cbKho.SelectedValue = tb.Rows[0][5].ToString().Trim();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mặt hàng", "Thông Báo");
                }
               
            }
            else
            {
                MessageBox.Show("Vui lòng nhập mã hàng", "Thông Báo");
            }
        }

        private void dvHanghoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index >= dvHanghoa.RowCount - 1) return;
            txtMahang.Text = dvHanghoa.Rows[index].Cells[0].Value.ToString().Trim();
            txtTenhang.Text = dvHanghoa.Rows[index].Cells[01].Value.ToString().Trim();
            txtDongia.Text = dvHanghoa.Rows[index].Cells[02].Value.ToString().Trim();
            txtSoluong.Text = dvHanghoa.Rows[index].Cells[03].Value.ToString().Trim();
            txtDVT.Text = dvHanghoa.Rows[index].Cells[04].Value.ToString().Trim();
            cbKho.SelectedValue = dvHanghoa.Rows[index].Cells[5].Value.ToString().Trim();

        }

        private void txtSoluong_KeyPress(object sender, KeyPressEventArgs e)
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

        private void frmHanghoa_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMain m = new frmMain();
            this.Hide();
            m.ShowDialog();
        }

        private void frmHanghoa_Load(object sender, EventArgs e)
        {
            sql = "select * from tbl_KhoHang";
            table = Data.Table(sql);
            cbKho.DataSource = table;
            cbKho.DisplayMember = "Tenkho";
            cbKho.ValueMember = "Makho";
            cbKho.DropDownStyle = ComboBoxStyle.DropDownList;

            sql = "select * from tbl_HangHoa";
            table = Data.Table(sql);
            dvHanghoa.DataSource = table;
            dvHanghoa.Columns[0].HeaderText = "Mã hàng";
            dvHanghoa.Columns[1].HeaderText = "Tên hàng";
            dvHanghoa.Columns[2].HeaderText = "Đơn giá";
            dvHanghoa.Columns[03].HeaderText = "Số lượng";
            dvHanghoa.Columns[04].HeaderText = "DVT";
            dvHanghoa.Columns[05].HeaderText = "Mã kho";

            dvHanghoa.Columns[0].Width = 120 ;
            dvHanghoa.Columns[01].Width = 200 ;
            dvHanghoa.Columns[02].Width = 180 ;
            dvHanghoa.Columns[03].Width = 140 ;
            dvHanghoa.Columns[04].Width = 120 ;
            dvHanghoa.Columns[05].Width = 150 ;

            dvHanghoa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
}

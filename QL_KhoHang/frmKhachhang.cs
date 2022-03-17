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
    public partial class frmKhachhang : Form
    {

        String sql;
        DataTable table, tb;
        int index;

        public frmKhachhang()
        {
            InitializeComponent();
        }

        private void frmKhachhang_Load(object sender, EventArgs e)
        {
            sql = "select * from tbl_KhachHang";
            table = Data.Table(sql);
            dvKhachhang.DataSource = table;

            dvKhachhang.Columns[0].HeaderText = "Mã khách";
            dvKhachhang.Columns[1].HeaderText = "Họ tên";
            dvKhachhang.Columns[2].HeaderText = "Ngày sinh";
            dvKhachhang.Columns[3].HeaderText = "Giới tính";
            dvKhachhang.Columns[4].HeaderText = "Điện thoại";
            dvKhachhang.Columns[5].HeaderText = "Email";

            dvKhachhang.Columns[0].Width = 120;
            dvKhachhang.Columns[1].Width = 200;
            dvKhachhang.Columns[2].Width = 180;
            dvKhachhang.Columns[3].Width = 120;
            dvKhachhang.Columns[4].Width = 180;
            dvKhachhang.Columns[5].Width = 180;

            dvKhachhang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(!txtMa.Text.Equals("") && !txtHoten.Text.Equals("") && !txtMail.Text.Equals("") && !txtSDT.Text.Equals(""))
            {
                sql = "select count(*) from tbl_KhachHang where Makhach = '"+txtMa.Text+"'";
                if(Data.Counter(sql) != 0)
                {
                    MessageBox.Show("Khách hàng đã tồn tại","Thông Báo");return;
                }
                else
                {
                    sql = "insert into tbl_KhachHang values('"+txtMa.Text+"',N'"+txtHoten.Text+"','"+ dtNgaysinh.Value+"',N'"+ Rad() + "','"+txtSDT.Text+"','"+txtMail.Text+"')";
                    Data.SQL(sql);
                    table.Rows.Add(txtMa.Text,txtHoten.Text,dtNgaysinh.Value,Rad(),txtSDT.Text,txtMail.Text);

                }
            }
            else
            {
                MessageBox.Show("Chưa nhập đủ thông tin khách hàng", "Thông Báo"); return;
            }
        }
        private String Rad()
        {
            return rdNam.Checked ? "Nam" : "Nữ";
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!txtMa.Text.Equals("") && !txtHoten.Text.Equals("") && !txtMail.Text.Equals("") && !txtSDT.Text.Equals(""))
            {
                sql = "select count(*) from tbl_KhachHang where Makhach = '"+txtMa.Text+"'" ;
                if(Data.Counter(sql) != 0)
                {
                    sql = "update tbl_KhachHang set Hoten = N'"+txtHoten.Text+"',Ngaysinh = '"+dtNgaysinh.Value+"', Gioitinh = N'"+Rad()+"', Dienthoai = '"+txtSDT.Text+"', Email = '"+txtMail.Text+"' where Makhach = '"+txtMa.Text+"'  ";
                    Data.SQL(sql);
                    table.Rows[index][1] = txtHoten.Text;
                    table.Rows[index][2] = dtNgaysinh.Value;
                    table.Rows[index][3] = Rad();
                    table.Rows[index][4] = txtSDT.Text;
                    table.Rows[index][5] = txtMail.Text;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy khách hàng: " +txtMa.Text+ "", "Thông Báo"); return;
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập đủ thông tin khách hàng", "Thông Báo"); return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
           if(MessageBox.Show("Xóa khách hàng: " +txtMa.Text+ "? ","Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question ) == DialogResult.Yes)
            {
                if (!txtMa.Text.Equals(""))
                {
                    sql = "delete from tbl_KhachHang where Makhach = '" + txtMa.Text + "'";
                    Data.SQL(sql);
                    table.Rows[index].Delete();
                }
                else
                {
                    MessageBox.Show("Chọn khách hàng cần xóa", "Thông Báo"); return;
                }
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if (!txtMa.Text.Equals(""))
            {
                sql = "select count(*) from tbl_KhachHang where Makhach = '"+txtMa.Text+"'";
                if(Data.Counter(sql) != 0)
                {
                    sql = "select * from tbl_KhachHang where Makhach = '" + txtMa.Text + "'";
                    tb = Data.Table(sql);
                    txtHoten.Text = tb.Rows[0][1].ToString().Trim();
                    dtNgaysinh.Value = DateTime.Parse( tb.Rows[0][2].ToString().Trim());
                    if(tb.Rows[0][3].ToString().Trim() == "Nam")
                    {
                        rdNam.Checked = true;

                    }
                    else
                    {
                        rdNu.Checked = true;
                    }
                    txtSDT.Text = tb.Rows[0][4].ToString().Trim();
                    txtMail.Text = tb.Rows[0][5].ToString().Trim();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin khách hàng", "Thông Báo"); return;
                }

            }
            else
            {
                MessageBox.Show("Chưa nhập đủ thông tin kháchh hàng", "Thông Báo"); return;
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dvKhachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index >= dvKhachhang.RowCount - 1) return;
            txtMa.Text = dvKhachhang.Rows[index].Cells[0].Value.ToString().Trim();
            txtHoten.Text = dvKhachhang.Rows[index].Cells[1].Value.ToString().Trim();
            dtNgaysinh.Value = DateTime.Parse( dvKhachhang.Rows[index].Cells[2].Value.ToString().Trim());
            if(dvKhachhang.Rows[index].Cells[3].Value.ToString().Trim() == "Nam")
            {
                rdNam.Checked = true;
            }
            else
            {
                rdNu.Checked = true;
            }
            txtSDT.Text = dvKhachhang.Rows[index].Cells[04].Value.ToString().Trim();
            txtMail.Text = dvKhachhang.Rows[index].Cells[05].Value.ToString().Trim();
        }
    }
}

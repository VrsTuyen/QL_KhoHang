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
        int index;
        private void frmKhohang_Load(object sender, EventArgs e)
        {
            sql = "select * from tbl_KhoHang";
            table = Data.Table(sql);
            dvKhohang.DataSource = table;
            dvKhohang.Columns[0].HeaderText = "Mã kho hàng";
            dvKhohang.Columns[1].HeaderText = "Tên kho hàng";

            dvKhohang.Columns[0].Width = 150;
            dvKhohang.Columns[1].Width = 230;

            dvKhohang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(!txtMakho.Text.Equals("") && !txtTenkho.Text.Equals(""))
            {
                sql = "select count(*) from tbl_KhoHang where Makho = '"+txtMakho.Text+"'";
                if(Data.Counter(sql) !=0)
                {
                    MessageBox.Show("Kho đã tồn tại","Thông báo");return;
                }
                sql = "insert into tbl_KhoHang values('"+txtMakho.Text+"',N'"+txtTenkho.Text+"')";
                Data.SQL(sql);
                table.Rows.Add(txtMakho.Text,txtTenkho.Text);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ kho hàng", "Thông báo"); return;
            }
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!txtMakho.Text.Equals("") && !txtTenkho.Text.Equals(""))
            {
                sql = "select count (*) from tbl_KhoHang where Makho = '" + txtMakho.Text + "'";
                if (Data.Counter(sql) > 0)
                {
                    sql = "update tbl_KhoHang set Tenkho = N'" + txtTenkho.Text + "' where Makho = '" + txtMakho.Text + "'";
                    Data.SQL(sql);
                    table.Rows[index][1] = txtTenkho.Text;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy kho hàng","Thông báo");return;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ", "Thông báo");
                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Xóa: " + txtTenkho.Text + "?  ", "Thông báo" , MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "delete from tbl_KhoHang where Makho = '"+txtMakho.Text+"'";
                table.Rows[index].Delete();
            }
        }


        private void dvKhohang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index >= dvKhohang.RowCount - 1) return;
            txtMakho.Text = dvKhohang.Rows[index].Cells[0].Value.ToString().Trim();
            txtTenkho.Text = dvKhohang.Rows[index].Cells[1].Value.ToString().Trim();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if (!txtMakho.Text.Equals(""))
            {
                sql = "select * from tbl_KhoHang where Makho = '"+txtMakho.Text+"'";
                if(Data.Table(sql).Rows.Count != 0)
                {
                    txtTenkho.Text = Data.Table(sql).Rows[0][1].ToString().Trim();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy dữ liệu","Thông báo");
                }
            }
            else
            {
                
            }
        }

        private void frmKhohang_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMain m = new frmMain();
            this.Hide();
            m.ShowDialog();
        }
    }
}

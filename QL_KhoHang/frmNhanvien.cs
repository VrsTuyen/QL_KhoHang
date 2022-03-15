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
    public partial class frmNhanvien : Form
    {
        public frmNhanvien()
        {
            InitializeComponent();
        }
        String sql;
        DataTable table;
        int index;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        private String Rad()
        {
            return rdNam.Checked? "Nam" : "Nữ";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if(!txtManv.Text.Equals("") && !txtTen.Text.Equals("") && !txtSDT.Text.Equals("") && !txtQuequan.Text.Equals("") && !txtCMTND.Text.Equals(""))
            {
                sql = "select count(*) from tbl_NhanVien where Manhanvien = '"+txtManv.Text+"'";
                if(Data.Counter(sql) != 0)
                {
                    MessageBox.Show("Nhan vien da ton tai","Thong bao");
                }
                else
                {
                    sql = "insert into tbl_NhanVien values('"+txtManv.Text+"',N'"+txtTen.Text+"','"+dateTimePicker1.Value+"',N'"+Rad()+"',N'"+txtQuequan.Text+"','"+txtSDT.Text+"','"+txtCMTND.Text+"')";
                    Data.SQL(sql);
                    table.Rows.Add(txtManv.Text,txtTen.Text,dateTimePicker1.Value,Rad(),txtQuequan.Text, txtSDT.Text,txtCMTND.Text );
                    
                }
            }
            else
            {

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!txtManv.Text.Equals("") && !txtTen.Text.Equals("") && !txtSDT.Text.Equals("") && !txtQuequan.Text.Equals("") && !txtCMTND.Text.Equals(""))
            {

                sql = "select count (*) from tbl_NhanVien where Manhanvien = '"+txtManv.Text+"'";
                if(Data.Counter(sql) != 0)
                {
                    sql = "update tbl_NhanVien set Hoten = N'"+txtTen.Text+"', Ngaysinh = '"+dateTimePicker1.Value+"', Gioitinh = N'"+Rad()+"', Quequan = N'"+txtQuequan.Text+"', Sodienthoai = '"+txtSDT.Text+"',CMTND = '"+txtCMTND.Text+"' where Manhanvien = '"+txtManv.Text+"' ";
                    Data.SQL(sql);
                    table.Rows[index][1] = txtTen.Text;
                    table.Rows[index][2] = dateTimePicker1.Value;
                    table.Rows[index][3] = Rad();
                    table.Rows[index][4] = txtQuequan.Text;
                    table.Rows[index][5] = txtSDT.Text;
                    table.Rows[index][6] = txtCMTND.Text;
                }
                else
                {
                    MessageBox.Show("Không tồn tại nhân viên trên","Thông Báo");
                }


            }
            else
            {
                
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!txtManv.Text.Equals(""))
            {
                if(MessageBox.Show("Xóa nhân viên: " +txtManv.Text+ "? ","Xóa", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                     sql = "delete from tbl_NhanVien where Manhanvien = '"+txtManv.Text+"'";
                    Data.SQL(sql);
                    table.Rows[index].Delete();
                }
            }
            else
            {
                MessageBox.Show("Chọn mã nhân viên","Thông báo");
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if (!txtManv.Text.Equals(""))
            {
                sql = "select * from tbl_NhanVien where Manhanvien = '"+txtManv.Text+"'";
                if(Data.Table(sql).Rows.Count != 0)
                {
                    txtTen.Text = Data.Table(sql).Rows[0][1].ToString().Trim();
                    dateTimePicker1.Value = DateTime.Parse( Data.Table(sql).Rows[0][2].ToString().Trim());
                    if (Data.Table(sql).Rows[0][3].ToString().Trim() == "Nam")
                    {
                        rdNam.Checked = true;
                    }
                    else
                    {
                        rdNu.Checked = true;
                    }
                    txtQuequan.Text = Data.Table(sql).Rows[0][4].ToString().Trim();
                    txtSDT.Text = Data.Table(sql).Rows[0][5].ToString().Trim();
                    txtCMTND.Text = Data.Table(sql).Rows[0][6].ToString().Trim();
                }

            }
            else
            {
                MessageBox.Show("Nhập mã nhân viên", "Thông báo");
            }
        }

        private void frmNhanvien_Load(object sender, EventArgs e)
        {
            sql = "select * from tbl_NhanVien";
            table = Data.Table(sql);
            dvNhanvien.DataSource = table;

            dvNhanvien.Columns[0].HeaderText = "Mã NV";
            dvNhanvien.Columns[1].HeaderText = "Họ tên";
            dvNhanvien.Columns[2].HeaderText = "Ngày sinh";
            dvNhanvien.Columns[3].HeaderText = "Giới tính";
            dvNhanvien.Columns[4].HeaderText = "Quê quán";
            dvNhanvien.Columns[5].HeaderText = "Số điện thoại";
            dvNhanvien.Columns[6].HeaderText = "CMND";

            dvNhanvien.Columns[0].Width = 120  ;
            dvNhanvien.Columns[1].Width = 200  ;
            dvNhanvien.Columns[2].Width =  150 ;
            dvNhanvien.Columns[3].Width =  120 ;
            dvNhanvien.Columns[4].Width =  200 ;
            dvNhanvien.Columns[5].Width = 180 ;
            dvNhanvien.Columns[6].Width = 180 ;

            dvNhanvien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void dvNhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index >= dvNhanvien.RowCount - 1) return;
            txtManv.Text = dvNhanvien.Rows[index].Cells[0].Value.ToString().Trim();
            txtTen.Text = dvNhanvien.Rows[index].Cells[1].Value.ToString().Trim();
            dateTimePicker1.Value = DateTime.Parse(dvNhanvien.Rows[index].Cells[2].Value.ToString().Trim());
           if(dvNhanvien.Rows[index].Cells[3].Value.ToString().Trim() == "Nam")
            {
                rdNam.Checked = true;
            }
            else
            {
                rdNu.Checked = true;
            }
            txtQuequan.Text = dvNhanvien.Rows[index].Cells[4].Value.ToString().Trim();
            txtSDT.Text = dvNhanvien.Rows[index].Cells[5].Value.ToString().Trim();
            txtCMTND.Text = dvNhanvien.Rows[index].Cells[6].Value.ToString().Trim();
        }
    }
}

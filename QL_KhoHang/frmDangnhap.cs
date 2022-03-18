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
    public partial class frmDangnhap : Form
    {
        public frmDangnhap()
        {
            InitializeComponent();
        }
        int count = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Equals("") && textBox2.Text.Equals(""))
            {
                return;
            }
            else
            {
                if(!textBox1.Text.Equals("admin") && !textBox2.Text.Equals("123"))
                {
                    MessageBox.Show("Tài khoản không chính xác","Thông Báo");
                    count++;
                    if(count >= 3)
                    {
                        Environment.Exit(0);
                    }
                }
                else
                {
                    frmMain frm = new frmMain();
                    frm.Show();
                    this.Hide();
                    count = 0;
                }
            }
        }

        private void frmDangnhap_Load(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*if (!char.IsLetter(e.KeyChar) && (e.KeyChar != '.') && !char.IsSurrogate(e.KeyChar)  )
            {
                e.Handled = true;
            }*/

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void frmDangnhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}

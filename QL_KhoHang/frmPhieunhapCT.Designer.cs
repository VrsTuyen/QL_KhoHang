
namespace QL_KhoHang
{
    partial class frmPhieunhapCT
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lbMaphieu = new System.Windows.Forms.Label();
            this.dtv = new System.Windows.Forms.DataGridView();
            this.btnLuu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTT = new System.Windows.Forms.Label();
            this.cbNhanvien = new System.Windows.Forms.ComboBox();
            this.dtNgaynhap = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phiếu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbMaphieu
            // 
            this.lbMaphieu.AutoSize = true;
            this.lbMaphieu.Location = new System.Drawing.Point(152, 32);
            this.lbMaphieu.Name = "lbMaphieu";
            this.lbMaphieu.Size = new System.Drawing.Size(0, 28);
            this.lbMaphieu.TabIndex = 0;
            // 
            // dtv
            // 
            this.dtv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtv.Location = new System.Drawing.Point(12, 180);
            this.dtv.Name = "dtv";
            this.dtv.RowHeadersWidth = 51;
            this.dtv.RowTemplate.Height = 29;
            this.dtv.Size = new System.Drawing.Size(1163, 466);
            this.dtv.TabIndex = 3;
            this.dtv.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtv_CellValueChanged);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(517, 663);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(204, 44);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(873, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tổng tiền";
            // 
            // lbTT
            // 
            this.lbTT.AutoSize = true;
            this.lbTT.Location = new System.Drawing.Point(1005, 135);
            this.lbTT.Name = "lbTT";
            this.lbTT.Size = new System.Drawing.Size(0, 28);
            this.lbTT.TabIndex = 0;
            // 
            // cbNhanvien
            // 
            this.cbNhanvien.FormattingEnabled = true;
            this.cbNhanvien.Location = new System.Drawing.Point(152, 73);
            this.cbNhanvien.Name = "cbNhanvien";
            this.cbNhanvien.Size = new System.Drawing.Size(250, 36);
            this.cbNhanvien.TabIndex = 5;
            // 
            // dtNgaynhap
            // 
            this.dtNgaynhap.CustomFormat = "dd/MM/yyyy";
            this.dtNgaynhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgaynhap.Location = new System.Drawing.Point(152, 115);
            this.dtNgaynhap.Name = "dtNgaynhap";
            this.dtNgaynhap.Size = new System.Drawing.Size(250, 34);
            this.dtNgaynhap.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã nhân viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày nhập";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmPhieunhapCT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 736);
            this.Controls.Add(this.dtNgaynhap);
            this.Controls.Add(this.cbNhanvien);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.dtv);
            this.Controls.Add(this.lbTT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbMaphieu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPhieunhapCT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPhieunhapCT";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPhieunhapCT_FormClosing);
            this.Load += new System.EventHandler(this.frmPhieunhapCT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbMaphieu;
        private System.Windows.Forms.ComboBox cbHanghoa;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtTT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dtv;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label lbTT;
        private System.Windows.Forms.ComboBox cbNhanvien;
        private System.Windows.Forms.DateTimePicker dtNgaynhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}
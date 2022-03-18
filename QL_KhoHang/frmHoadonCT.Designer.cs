
namespace QL_KhoHang
{
    partial class frmHoadonCT
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
            this.cbKhach = new System.Windows.Forms.ComboBox();
            this.dtMua = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dvHDCT = new System.Windows.Forms.DataGridView();
            this.btnLuu = new System.Windows.Forms.Button();
            this.lbMaHD = new System.Windows.Forms.Label();
            this.lbTongtien = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbNhanvien = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvHDCT)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hóa đơn";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbKhach
            // 
            this.cbKhach.FormattingEnabled = true;
            this.cbKhach.Location = new System.Drawing.Point(168, 94);
            this.cbKhach.Name = "cbKhach";
            this.cbKhach.Size = new System.Drawing.Size(330, 36);
            this.cbKhach.TabIndex = 2;
            // 
            // dtMua
            // 
            this.dtMua.CustomFormat = "dd/MM/yyyy";
            this.dtMua.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtMua.Location = new System.Drawing.Point(683, 37);
            this.dtMua.Name = "dtMua";
            this.dtMua.Size = new System.Drawing.Size(330, 34);
            this.dtMua.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã khách";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(542, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày mua";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(773, 524);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tổng tiền";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // dvHDCT
            // 
            this.dvHDCT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvHDCT.Location = new System.Drawing.Point(12, 152);
            this.dvHDCT.Name = "dvHDCT";
            this.dvHDCT.RowHeadersWidth = 51;
            this.dvHDCT.RowTemplate.Height = 29;
            this.dvHDCT.Size = new System.Drawing.Size(1076, 360);
            this.dvHDCT.TabIndex = 4;
            this.dvHDCT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvHDCT_CellClick);
            this.dvHDCT.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvHDCT_CellValueChanged);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(397, 539);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(201, 45);
            this.btnLuu.TabIndex = 6;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // lbMaHD
            // 
            this.lbMaHD.AutoSize = true;
            this.lbMaHD.Location = new System.Drawing.Point(168, 42);
            this.lbMaHD.Name = "lbMaHD";
            this.lbMaHD.Size = new System.Drawing.Size(0, 28);
            this.lbMaHD.TabIndex = 0;
            this.lbMaHD.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbTongtien
            // 
            this.lbTongtien.AutoSize = true;
            this.lbTongtien.Location = new System.Drawing.Point(914, 525);
            this.lbTongtien.Name = "lbTongtien";
            this.lbTongtien.Size = new System.Drawing.Size(0, 28);
            this.lbTongtien.TabIndex = 0;
            this.lbTongtien.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(527, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nhân viên";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbNhanvien
            // 
            this.cbNhanvien.FormattingEnabled = true;
            this.cbNhanvien.Location = new System.Drawing.Point(683, 94);
            this.cbNhanvien.Name = "cbNhanvien";
            this.cbNhanvien.Size = new System.Drawing.Size(330, 36);
            this.cbNhanvien.TabIndex = 2;
            // 
            // frmHoadonCT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 630);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.dvHDCT);
            this.Controls.Add(this.dtMua);
            this.Controls.Add(this.cbNhanvien);
            this.Controls.Add(this.cbKhach);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbTongtien);
            this.Controls.Add(this.lbMaHD);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmHoadonCT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHoadonCT";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHoadonCT_FormClosing);
            this.Load += new System.EventHandler(this.frmHoadonCT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvHDCT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbKhach;
        private System.Windows.Forms.DateTimePicker dtMua;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dvHDCT;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label lbMaHD;
        private System.Windows.Forms.Label lbTongtien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbNhanvien;
    }
}
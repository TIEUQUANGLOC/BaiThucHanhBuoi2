namespace Lab2_Demo
{
    partial class frmTrungTam
    {
        
        private System.ComponentModel.IContainer components = null;

       
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
            this.cbomahocvien = new System.Windows.Forms.Label();
            this.cboMaHV = new System.Windows.Forms.ComboBox();
            this.lbl_gioitinh = new System.Windows.Forms.Label();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblNgayDangKy = new System.Windows.Forms.Label();
            this.dtpNgayDangKy = new System.Windows.Forms.DateTimePicker();
            this.lblTinhTienHocTT = new System.Windows.Forms.Label();
            this.chkTinHocA = new System.Windows.Forms.CheckBox();
            this.chkTinHocB = new System.Windows.Forms.CheckBox();
            this.chkTiengAnhA = new System.Windows.Forms.CheckBox();
            this.chkTiengAnhB = new System.Windows.Forms.CheckBox();
            this.lblTienTHA = new System.Windows.Forms.Label();
            this.lblTienTHB = new System.Windows.Forms.Label();
            this.lblTienTAA = new System.Windows.Forms.Label();
            this.lblTienTAB = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbomahocvien
            // 
            this.cbomahocvien.AutoSize = true;
            this.cbomahocvien.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbomahocvien.Location = new System.Drawing.Point(265, 98);
            this.cbomahocvien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cbomahocvien.Name = "cbomahocvien";
            this.cbomahocvien.Size = new System.Drawing.Size(94, 17);
            this.cbomahocvien.TabIndex = 2;
            this.cbomahocvien.Text = "Mã Học Viên";
            // 
            // cboMaHV
            // 
            this.cboMaHV.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaHV.FormattingEnabled = true;
            this.cboMaHV.Location = new System.Drawing.Point(377, 95);
            this.cboMaHV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboMaHV.Name = "cboMaHV";
            this.cboMaHV.Size = new System.Drawing.Size(160, 25);
            this.cboMaHV.TabIndex = 0;
            // 
            // lbl_gioitinh
            // 
            this.lbl_gioitinh.AutoSize = true;
            this.lbl_gioitinh.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gioitinh.Location = new System.Drawing.Point(580, 98);
            this.lbl_gioitinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_gioitinh.Name = "lbl_gioitinh";
            this.lbl_gioitinh.Size = new System.Drawing.Size(69, 17);
            this.lbl_gioitinh.TabIndex = 2;
            this.lbl_gioitinh.Text = "Giới Tính";
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdNam.Location = new System.Drawing.Point(656, 96);
            this.rdNam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(58, 21);
            this.rdNam.TabIndex = 1;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdNu.Location = new System.Drawing.Point(727, 96);
            this.rdNu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(48, 21);
            this.rdNu.TabIndex = 2;
            this.rdNu.TabStop = true;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTen.Location = new System.Drawing.Point(265, 154);
            this.lblHoTen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(58, 17);
            this.lblHoTen.TabIndex = 2;
            this.lblHoTen.Text = "Họ Tên";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(377, 150);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(400, 25);
            this.txtHoTen.TabIndex = 3;
            // 
            // lblNgayDangKy
            // 
            this.lblNgayDangKy.AutoSize = true;
            this.lblNgayDangKy.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayDangKy.Location = new System.Drawing.Point(256, 203);
            this.lblNgayDangKy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgayDangKy.Name = "lblNgayDangKy";
            this.lblNgayDangKy.Size = new System.Drawing.Size(102, 17);
            this.lblNgayDangKy.TabIndex = 2;
            this.lblNgayDangKy.Text = "Ngày Đăng Ký";
            // 
            // dtpNgayDangKy
            // 
            this.dtpNgayDangKy.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayDangKy.Location = new System.Drawing.Point(381, 196);
            this.dtpNgayDangKy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpNgayDangKy.Name = "dtpNgayDangKy";
            this.dtpNgayDangKy.Size = new System.Drawing.Size(265, 25);
            this.dtpNgayDangKy.TabIndex = 4;
            // 
            // lblTinhTienHocTT
            // 
            this.lblTinhTienHocTT.AutoSize = true;
            this.lblTinhTienHocTT.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTinhTienHocTT.ForeColor = System.Drawing.Color.Orchid;
            this.lblTinhTienHocTT.Location = new System.Drawing.Point(187, 9);
            this.lblTinhTienHocTT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTinhTienHocTT.Name = "lblTinhTienHocTT";
            this.lblTinhTienHocTT.Size = new System.Drawing.Size(689, 53);
            this.lblTinhTienHocTT.TabIndex = 1;
            this.lblTinhTienHocTT.Text = "TÍNH TIỀN HỌC TRUNG TÂM";
            this.lblTinhTienHocTT.Click += new System.EventHandler(this.lblTinhTienHocTT_Click);
            // 
            // chkTinHocA
            // 
            this.chkTinHocA.AutoSize = true;
            this.chkTinHocA.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTinHocA.Location = new System.Drawing.Point(377, 258);
            this.chkTinHocA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkTinHocA.Name = "chkTinHocA";
            this.chkTinHocA.Size = new System.Drawing.Size(87, 21);
            this.chkTinHocA.TabIndex = 5;
            this.chkTinHocA.Text = "Tin học A";
            this.chkTinHocA.UseVisualStyleBackColor = true;
            // 
            // chkTinHocB
            // 
            this.chkTinHocB.AutoSize = true;
            this.chkTinHocB.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTinHocB.Location = new System.Drawing.Point(377, 299);
            this.chkTinHocB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkTinHocB.Name = "chkTinHocB";
            this.chkTinHocB.Size = new System.Drawing.Size(87, 21);
            this.chkTinHocB.TabIndex = 6;
            this.chkTinHocB.Text = "Tin học B";
            this.chkTinHocB.UseVisualStyleBackColor = true;
            // 
            // chkTiengAnhA
            // 
            this.chkTiengAnhA.AutoSize = true;
            this.chkTiengAnhA.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTiengAnhA.Location = new System.Drawing.Point(377, 340);
            this.chkTiengAnhA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkTiengAnhA.Name = "chkTiengAnhA";
            this.chkTiengAnhA.Size = new System.Drawing.Size(101, 21);
            this.chkTiengAnhA.TabIndex = 7;
            this.chkTiengAnhA.Text = "Tiếng anh A";
            this.chkTiengAnhA.UseVisualStyleBackColor = true;
            // 
            // chkTiengAnhB
            // 
            this.chkTiengAnhB.AutoSize = true;
            this.chkTiengAnhB.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTiengAnhB.Location = new System.Drawing.Point(377, 384);
            this.chkTiengAnhB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkTiengAnhB.Name = "chkTiengAnhB";
            this.chkTiengAnhB.Size = new System.Drawing.Size(101, 21);
            this.chkTiengAnhB.TabIndex = 8;
            this.chkTiengAnhB.Text = "Tiếng anh B";
            this.chkTiengAnhB.UseVisualStyleBackColor = true;
            // 
            // lblTienTHA
            // 
            this.lblTienTHA.AutoSize = true;
            this.lblTienTHA.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienTHA.Location = new System.Drawing.Point(551, 263);
            this.lblTienTHA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTienTHA.Name = "lblTienTHA";
            this.lblTienTHA.Size = new System.Drawing.Size(87, 17);
            this.lblTienTHA.TabIndex = 2;
            this.lblTienTHA.Text = "300.000 đồng";
            // 
            // lblTienTHB
            // 
            this.lblTienTHB.AutoSize = true;
            this.lblTienTHB.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienTHB.Location = new System.Drawing.Point(551, 304);
            this.lblTienTHB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTienTHB.Name = "lblTienTHB";
            this.lblTienTHB.Size = new System.Drawing.Size(87, 17);
            this.lblTienTHB.TabIndex = 2;
            this.lblTienTHB.Text = "500.000 đồng";
            // 
            // lblTienTAA
            // 
            this.lblTienTAA.AutoSize = true;
            this.lblTienTAA.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienTAA.Location = new System.Drawing.Point(551, 345);
            this.lblTienTAA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTienTAA.Name = "lblTienTAA";
            this.lblTienTAA.Size = new System.Drawing.Size(87, 17);
            this.lblTienTAA.TabIndex = 2;
            this.lblTienTAA.Text = "400.000 đồng";
            // 
            // lblTienTAB
            // 
            this.lblTienTAB.AutoSize = true;
            this.lblTienTAB.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienTAB.Location = new System.Drawing.Point(551, 384);
            this.lblTienTAB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTienTAB.Name = "lblTienTAB";
            this.lblTienTAB.Size = new System.Drawing.Size(87, 17);
            this.lblTienTAB.TabIndex = 2;
            this.lblTienTAB.Text = "600.000 đồng";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Location = new System.Drawing.Point(413, 426);
            this.lblTongTien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(71, 17);
            this.lblTongTien.TabIndex = 2;
            this.lblTongTien.Text = "Tổng tiền";
            this.lblTongTien.Click += new System.EventHandler(this.lblTongTien_Click);
            // 
            // txtTongTien
            // 
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Location = new System.Drawing.Point(512, 417);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(191, 25);
            this.txtTongTien.TabIndex = 9;
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhTien.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnTinhTien.Location = new System.Drawing.Point(336, 475);
            this.btnTinhTien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(100, 28);
            this.btnTinhTien.TabIndex = 11;
            this.btnTinhTien.Text = "Tính Tiền";
            this.btnTinhTien.UseVisualStyleBackColor = true;
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancel.Location = new System.Drawing.Point(487, 475);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(117, 28);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnExit.Location = new System.Drawing.Point(651, 473);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 28);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmTrungTam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnTinhTien);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.lblTienTAB);
            this.Controls.Add(this.lblTienTAA);
            this.Controls.Add(this.lblTienTHB);
            this.Controls.Add(this.lblTienTHA);
            this.Controls.Add(this.chkTiengAnhB);
            this.Controls.Add(this.chkTiengAnhA);
            this.Controls.Add(this.chkTinHocB);
            this.Controls.Add(this.chkTinHocA);
            this.Controls.Add(this.lblTinhTienHocTT);
            this.Controls.Add(this.dtpNgayDangKy);
            this.Controls.Add(this.lblNgayDangKy);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.rdNu);
            this.Controls.Add(this.rdNam);
            this.Controls.Add(this.lbl_gioitinh);
            this.Controls.Add(this.cboMaHV);
            this.Controls.Add(this.cbomahocvien);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmTrungTam";
            this.Text = "Simple Drawing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cbomahocvien;
        private System.Windows.Forms.ComboBox cboMaHV;
        private System.Windows.Forms.Label lbl_gioitinh;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblNgayDangKy;
        private System.Windows.Forms.DateTimePicker dtpNgayDangKy;
        private System.Windows.Forms.Label lblTinhTienHocTT;
        private System.Windows.Forms.CheckBox chkTinHocA;
        private System.Windows.Forms.CheckBox chkTinHocB;
        private System.Windows.Forms.CheckBox chkTiengAnhA;
        private System.Windows.Forms.CheckBox chkTiengAnhB;
        private System.Windows.Forms.Label lblTienTHA;
        private System.Windows.Forms.Label lblTienTHB;
        private System.Windows.Forms.Label lblTienTAA;
        private System.Windows.Forms.Label lblTienTAB;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnExit;
    }
}
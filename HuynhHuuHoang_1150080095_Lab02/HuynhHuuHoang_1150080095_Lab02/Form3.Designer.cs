namespace HuynhHuuHoang_1150080095_Lab02
{
    partial class Form3
    {
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.grpDichVu = new System.Windows.Forms.GroupBox();
            this.chkCaoRang = new System.Windows.Forms.CheckBox();
            this.chkTayTrang = new System.Windows.Forms.CheckBox();
            this.chkHanRang = new System.Windows.Forms.CheckBox();
            this.chkBeRang = new System.Windows.Forms.CheckBox();
            this.chkBocRang = new System.Windows.Forms.CheckBox();
            this.numHanRang = new System.Windows.Forms.NumericUpDown();
            this.numBeRang = new System.Windows.Forms.NumericUpDown();
            this.numBocRang = new System.Windows.Forms.NumericUpDown();
            this.lblThanhTien = new System.Windows.Forms.Label();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();

            this.grpDichVu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHanRang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBeRang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBocRang)).BeginInit();
            this.SuspendLayout();

            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.LimeGreen;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(600, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "PHÒNG KHÁM NHA KHOA HẢI ÂU";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTenKH
            // 
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.Location = new System.Drawing.Point(20, 70);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(100, 16);
            this.lblTenKH.Text = "Tên khách hàng:";
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Location = new System.Drawing.Point(140, 67);
            this.txtTenKhachHang.Size = new System.Drawing.Size(300, 22);
            // 
            // grpDichVu
            // 
            this.grpDichVu.Controls.Add(this.chkCaoRang);
            this.grpDichVu.Controls.Add(this.chkTayTrang);
            this.grpDichVu.Controls.Add(this.chkHanRang);
            this.grpDichVu.Controls.Add(this.chkBeRang);
            this.grpDichVu.Controls.Add(this.chkBocRang);
            this.grpDichVu.Controls.Add(this.numHanRang);
            this.grpDichVu.Controls.Add(this.numBeRang);
            this.grpDichVu.Controls.Add(this.numBocRang);
            this.grpDichVu.Location = new System.Drawing.Point(20, 110);
            this.grpDichVu.Size = new System.Drawing.Size(560, 180);
            this.grpDichVu.Text = "Dịch vụ tại phòng khám:";
            // 
            // chkCaoRang
            // 
            this.chkCaoRang.AutoSize = true;
            this.chkCaoRang.Location = new System.Drawing.Point(20, 30);
            this.chkCaoRang.Text = "Lấy cao răng (50.000đ/2 hàm)";
            // 
            // chkTayTrang
            // 
            this.chkTayTrang.AutoSize = true;
            this.chkTayTrang.Location = new System.Drawing.Point(20, 60);
            this.chkTayTrang.Text = "Tẩy trắng răng (100.000đ/2 hàm)";
            // 
            // chkHanRang
            // 
            this.chkHanRang.AutoSize = true;
            this.chkHanRang.Location = new System.Drawing.Point(20, 90);
            this.chkHanRang.Text = "Hàn răng (100.000đ/1 răng)";
            // 
            // numHanRang
            // 
            this.numHanRang.Location = new System.Drawing.Point(400, 88);
            this.numHanRang.Minimum = 1;
            this.numHanRang.Value = 1;
            // 
            // chkBeRang
            // 
            this.chkBeRang.AutoSize = true;
            this.chkBeRang.Location = new System.Drawing.Point(20, 120);
            this.chkBeRang.Text = "Bẻ răng (10.000đ/1 răng)";
            // 
            // numBeRang
            // 
            this.numBeRang.Location = new System.Drawing.Point(400, 118);
            this.numBeRang.Minimum = 1;
            this.numBeRang.Value = 1;
            // 
            // chkBocRang
            // 
            this.chkBocRang.AutoSize = true;
            this.chkBocRang.Location = new System.Drawing.Point(20, 150);
            this.chkBocRang.Text = "Bọc răng (1.000.000đ/1 răng)";
            // 
            // numBocRang
            // 
            this.numBocRang.Location = new System.Drawing.Point(400, 148);
            this.numBocRang.Minimum = 1;
            this.numBocRang.Value = 1;
            // 
            // lblThanhTien
            // 
            this.lblThanhTien.AutoSize = true;
            this.lblThanhTien.Location = new System.Drawing.Point(20, 310);
            this.lblThanhTien.Text = "Thành tiền:";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(100, 307);
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.Size = new System.Drawing.Size(250, 22);
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.Location = new System.Drawing.Point(380, 305);
            this.btnTinhTien.Size = new System.Drawing.Size(90, 30);
            this.btnTinhTien.Text = "Tính tiền";
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(480, 305);
            this.btnThoat.Size = new System.Drawing.Size(90, 30);
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(600, 370);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblTenKH);
            this.Controls.Add(this.txtTenKhachHang);
            this.Controls.Add(this.grpDichVu);
            this.Controls.Add(this.lblThanhTien);
            this.Controls.Add(this.txtThanhTien);
            this.Controls.Add(this.btnTinhTien);
            this.Controls.Add(this.btnThoat);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phòng khám Nha Khoa Hải Âu";

            this.grpDichVu.ResumeLayout(false);
            this.grpDichVu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHanRang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBeRang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBocRang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.GroupBox grpDichVu;
        private System.Windows.Forms.CheckBox chkCaoRang;
        private System.Windows.Forms.CheckBox chkTayTrang;
        private System.Windows.Forms.CheckBox chkHanRang;
        private System.Windows.Forms.CheckBox chkBeRang;
        private System.Windows.Forms.CheckBox chkBocRang;
        private System.Windows.Forms.NumericUpDown numHanRang;
        private System.Windows.Forms.NumericUpDown numBeRang;
        private System.Windows.Forms.NumericUpDown numBocRang;
        private System.Windows.Forms.Label lblThanhTien;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.Button btnThoat;

    }
}
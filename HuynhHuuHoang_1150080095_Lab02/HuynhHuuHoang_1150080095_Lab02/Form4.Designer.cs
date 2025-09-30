namespace HuynhHuuHoang_1150080095_Lab02
{
    partial class Form4
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblNhapSo = new System.Windows.Forms.Label();
            this.txtSoNguyen = new System.Windows.Forms.TextBox();
            this.btnNhap = new System.Windows.Forms.Button();
            this.lsbDaySo = new System.Windows.Forms.ListBox();
            this.grpChucNang = new System.Windows.Forms.GroupBox();
            this.btnTang2 = new System.Windows.Forms.Button();
            this.btnChonChanDau = new System.Windows.Forms.Button();
            this.btnChonLeCuoi = new System.Windows.Forms.Button();
            this.btnXoaDangChon = new System.Windows.Forms.Button();
            this.btnXoaDau = new System.Windows.Forms.Button();
            this.btnXoaCuoi = new System.Windows.Forms.Button();
            this.btnXoaDay = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();

            this.grpChucNang.SuspendLayout();
            this.SuspendLayout();

            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Teal;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(600, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Ứng dụng xử lý dãy số";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // lblNhapSo
            // 
            this.lblNhapSo.AutoSize = true;
            this.lblNhapSo.Location = new System.Drawing.Point(20, 70);
            this.lblNhapSo.Name = "lblNhapSo";
            this.lblNhapSo.Size = new System.Drawing.Size(90, 16);
            this.lblNhapSo.Text = "Nhập số nguyên:";

            // 
            // txtSoNguyen
            // 
            this.txtSoNguyen.Location = new System.Drawing.Point(120, 67);
            this.txtSoNguyen.Size = new System.Drawing.Size(150, 22);

            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(290, 65);
            this.btnNhap.Size = new System.Drawing.Size(90, 25);
            this.btnNhap.Text = "Nhập số";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);

            // 
            // lsbDaySo
            // 
            this.lsbDaySo.Location = new System.Drawing.Point(20, 110);
            this.lsbDaySo.Size = new System.Drawing.Size(200, 200);

            // 
            // grpChucNang
            // 
            this.grpChucNang.Controls.Add(this.btnTang2);
            this.grpChucNang.Controls.Add(this.btnChonChanDau);
            this.grpChucNang.Controls.Add(this.btnChonLeCuoi);
            this.grpChucNang.Controls.Add(this.btnXoaDangChon);
            this.grpChucNang.Controls.Add(this.btnXoaDau);
            this.grpChucNang.Controls.Add(this.btnXoaCuoi);
            this.grpChucNang.Location = new System.Drawing.Point(240, 110);
            this.grpChucNang.Size = new System.Drawing.Size(200, 200);
            this.grpChucNang.Text = "Chức năng:";

            // 
            // btnTang2
            // 
            this.btnTang2.Location = new System.Drawing.Point(20, 20);
            this.btnTang2.Size = new System.Drawing.Size(150, 26);
            this.btnTang2.Text = "Tăng mỗi phần tử lên 2";
            this.btnTang2.Click += new System.EventHandler(this.btnTang2_Click);

            // 
            // btnChonChanDau
            // 
            this.btnChonChanDau.Location = new System.Drawing.Point(20, 55);
            this.btnChonChanDau.Size = new System.Drawing.Size(150, 26);
            this.btnChonChanDau.Text = "Chọn số chẵn đầu";
            this.btnChonChanDau.Click += new System.EventHandler(this.btnChonChanDau_Click);

            // 
            // btnChonLeCuoi
            // 
            this.btnChonLeCuoi.Location = new System.Drawing.Point(20, 90);
            this.btnChonLeCuoi.Size = new System.Drawing.Size(150, 26);
            this.btnChonLeCuoi.Text = "Chọn số lẻ cuối";
            this.btnChonLeCuoi.Click += new System.EventHandler(this.btnChonLeCuoi_Click);

            // 
            // btnXoaDangChon
            // 
            this.btnXoaDangChon.Location = new System.Drawing.Point(20, 125);
            this.btnXoaDangChon.Size = new System.Drawing.Size(150, 26);
            this.btnXoaDangChon.Text = "Xóa phần tử đang chọn";
            this.btnXoaDangChon.Click += new System.EventHandler(this.btnXoaDangChon_Click);

            // 
            // btnXoaDau
            // 
            this.btnXoaDau.Location = new System.Drawing.Point(20, 160);
            this.btnXoaDau.Size = new System.Drawing.Size(150, 26);
            this.btnXoaDau.Text = "Xóa phần tử đầu";
            this.btnXoaDau.Click += new System.EventHandler(this.btnXoaDau_Click);

            // 
            // btnXoaCuoi
            // 
            this.btnXoaCuoi.Location = new System.Drawing.Point(20, 195);
            this.btnXoaCuoi.Size = new System.Drawing.Size(150, 26);
            this.btnXoaCuoi.Text = "Xóa phần tử cuối";
            this.btnXoaCuoi.Click += new System.EventHandler(this.btnXoaCuoi_Click);

            // 
            // btnXoaDay
            // 
            this.btnXoaDay.BackColor = System.Drawing.Color.DimGray;
            this.btnXoaDay.ForeColor = System.Drawing.Color.White;
            this.btnXoaDay.Location = new System.Drawing.Point(240, 330);
            this.btnXoaDay.Size = new System.Drawing.Size(150, 35);
            this.btnXoaDay.Text = "Xóa dãy số";
            this.btnXoaDay.UseVisualStyleBackColor = false;
            this.btnXoaDay.Click += new System.EventHandler(this.btnXoaDay_Click);

            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Red;
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(20, 330);
            this.btnThoat.Size = new System.Drawing.Size(150, 35);
            this.btnThoat.Text = "Kết thúc ứng dụng";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);

            // 
            // Form4
            // 
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblNhapSo);
            this.Controls.Add(this.txtSoNguyen);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.lsbDaySo);
            this.Controls.Add(this.grpChucNang);
            this.Controls.Add(this.btnXoaDay);
            this.Controls.Add(this.btnThoat);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ứng dụng xử lý dãy số";

            this.grpChucNang.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblNhapSo;
        private System.Windows.Forms.TextBox txtSoNguyen;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.ListBox lsbDaySo;
        private System.Windows.Forms.GroupBox grpChucNang;
        private System.Windows.Forms.Button btnTang2;
        private System.Windows.Forms.Button btnChonChanDau;
        private System.Windows.Forms.Button btnChonLeCuoi;
        private System.Windows.Forms.Button btnXoaDangChon;
        private System.Windows.Forms.Button btnXoaDau;
        private System.Windows.Forms.Button btnXoaCuoi;
        private System.Windows.Forms.Button btnXoaDay;
        private System.Windows.Forms.Button btnThoat;
    }
}

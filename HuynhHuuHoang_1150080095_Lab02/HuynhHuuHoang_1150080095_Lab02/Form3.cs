using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HuynhHuuHoang_1150080095_Lab02
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        // Hàm tính tiền
        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            string tenKH = txtTenKhachHang.Text.Trim();

            if (string.IsNullOrEmpty(tenKH))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double tongTien = 0;

            // Lấy cao răng
            if (chkCaoRang.Checked)
                tongTien += 50000;

            // Tẩy trắng răng
            if (chkTayTrang.Checked)
                tongTien += 100000;

            // Hàn răng
            if (chkHanRang.Checked)
                tongTien += 100000 * (int)numHanRang.Value;

            // Bẻ răng
            if (chkBeRang.Checked)
                tongTien += 10000 * (int)numBeRang.Value;

            // Bọc răng
            if (chkBocRang.Checked)
                tongTien += 1000000 * (int)numBocRang.Value;

            // Hiển thị kết quả
            txtThanhTien.Text = tongTien.ToString("N0") + " VNĐ";
        }

        // Thoát chương trình
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
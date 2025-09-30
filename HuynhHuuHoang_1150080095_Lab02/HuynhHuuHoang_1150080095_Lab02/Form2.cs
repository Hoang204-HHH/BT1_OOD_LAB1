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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        // Sự kiện nút Tìm
        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(txtA.Text);
                int b = int.Parse(txtB.Text);
                int result = 0;

                if (radUSCLN.Checked)
                {
                    result = USCLN(a, b);
                }
                else if (radBSCNN.Checked)
                {
                    result = BSCNN(a, b);
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn USCLN hoặc BSCNN!", "Thông báo");
                    return;
                }

                txtKetQua.Text = result.ToString();
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ!", "Lỗi");
            }
        }

        // Sự kiện nút Thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Hàm tính USCLN (Ước số chung lớn nhất)
        private int USCLN(int a, int b)
        {
            while (b != 0)
            {
                int r = a % b;
                a = b;
                b = r;
            }
            return Math.Abs(a);
        }

        // Hàm tính BSCNN (Bội số chung nhỏ nhất)
        private int BSCNN(int a, int b)
        {
            return Math.Abs(a * b) / USCLN(a, b);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
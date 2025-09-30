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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        // Nhập số vào dãy
        private void btnNhap_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSoNguyen.Text, out int so))
            {
                lsbDaySo.Items.Add(so);
                txtSoNguyen.Clear();
                txtSoNguyen.Focus();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ!", "Thông báo");
            }
        }

        // Tăng mỗi phần tử lên 2
        private void btnTang2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lsbDaySo.Items.Count; i++)
            {
                int so = int.Parse(lsbDaySo.Items[i].ToString());
                lsbDaySo.Items[i] = so + 2;
            }
        }

        // Chọn số chẵn đầu tiên
        private void btnChonChanDau_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lsbDaySo.Items.Count; i++)
            {
                int so = int.Parse(lsbDaySo.Items[i].ToString());
                if (so % 2 == 0)
                {
                    lsbDaySo.SelectedIndex = i;
                    return;
                }
            }
            MessageBox.Show("Không có số chẵn trong dãy!", "Thông báo");
        }

        // Chọn số lẻ cuối cùng
        private void btnChonLeCuoi_Click(object sender, EventArgs e)
        {
            for (int i = lsbDaySo.Items.Count - 1; i >= 0; i--)
            {
                int so = int.Parse(lsbDaySo.Items[i].ToString());
                if (so % 2 != 0)
                {
                    lsbDaySo.SelectedIndex = i;
                    return;
                }
            }
            MessageBox.Show("Không có số lẻ trong dãy!", "Thông báo");
        }

        // Xóa phần tử đang chọn
        private void btnXoaDangChon_Click(object sender, EventArgs e)
        {
            if (lsbDaySo.SelectedIndex != -1)
                lsbDaySo.Items.RemoveAt(lsbDaySo.SelectedIndex);
            else
                MessageBox.Show("Vui lòng chọn phần tử cần xóa!", "Thông báo");
        }

        // Xóa phần tử đầu
        private void btnXoaDau_Click(object sender, EventArgs e)
        {
            if (lsbDaySo.Items.Count > 0)
                lsbDaySo.Items.RemoveAt(0);
        }

        // Xóa phần tử cuối
        private void btnXoaCuoi_Click(object sender, EventArgs e)
        {
            if (lsbDaySo.Items.Count > 0)
                lsbDaySo.Items.RemoveAt(lsbDaySo.Items.Count - 1);
        }

        // Xóa cả dãy số
        private void btnXoaDay_Click(object sender, EventArgs e)
        {
            lsbDaySo.Items.Clear();
        }

        // Thoát chương trình
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

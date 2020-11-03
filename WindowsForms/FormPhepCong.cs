using SuDungHam;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class FormPhepCong : Form
    {
        public FormPhepCong()
        {
            InitializeComponent();
        }

        #region Button Thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FormPhepCong_FormClosing(object sender, FormClosingEventArgs e)
        {
            var exit = MessageBox.Show("Bạn có muốn thoát không?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (exit != DialogResult.OK)
                e.Cancel = true;
        }
        #endregion

        #region Button Click
        private void btnTinh_Click(object sender, EventArgs e)
        {
            try
            {
                int a, b;
                PhuongTrinh pt = new PhuongTrinh();

                if (int.TryParse(txtSoA.Text, out a) == false)
                {
                    txtSoA.SelectAll();
                    txtSoA.Focus();
                    throw new Exception("Dữ liệu không hợp lệ");
                }

                if (int.TryParse(txtSoB.Text, out b) == false)
                {
                    txtSoB.SelectAll();
                    txtSoB.Focus();
                    throw new Exception("Dữ liệu không hợp lệ");
                }

                txtTong.Text = pt.Tong(a, b).ToString();

                txtHieu.Text = pt.Hieu(a, b).ToString();

                txtTich.Text = pt.Tich(a, b).ToString();

                if (b != 0)
                    txtThuong.Text = pt.Thuong(a, b).ToString();
                else
                {
                    txtSoB.SelectAll();
                    txtSoB.Focus();
                    throw new Exception("Không thể chia được vì B bằng 0");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Không cho phép nhận chữ
        private void txtSoA_KeyUp(object sender, KeyEventArgs e)
        {
            int a;
            if (int.TryParse(txtSoA.Text, out a) == false)
                txtSoA.Text = "";
        }

        private void txtSoB_KeyUp(object sender, KeyEventArgs e)
        {
            int b;
            if (int.TryParse(txtSoB.Text, out b) == false)
                txtSoB.Text = "";
        }

        #endregion

    }
}

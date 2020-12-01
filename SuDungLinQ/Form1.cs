using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuDungLinQ
{
    public partial class Form1 : Form
    {
        static Estore20DataContext _Estore20DB = new Estore20DataContext();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvHangHoa.DataSource = _Estore20DB.HangHoas.ToList();

            List<Loai> listLoai = _Estore20DB.Loais.ToList();

            Loai chonLoai = new Loai()
            {
                MaLoai = 0,
                TenLoai = "Chọn loại hàng hóa"
            };

            listLoai.Insert(0, chonLoai);

            comboBoxLoai.DataSource = listLoai;
            comboBoxLoai.DisplayMember = "TenLoai";
            comboBoxLoai.ValueMember = "MaLoai";
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                string tuKhoa = txtTimKiem.Text.Trim();
                int maLoai = int.Parse(comboBoxLoai.SelectedValue.ToString());

                if (maLoai != 0)
                    dgvHangHoa.DataSource = _Estore20DB.HangHoas.Where(hh => hh.TenHH.Contains(tuKhoa) && hh.MaLoai == maLoai).ToList();

                throw new Exception("Bạn chưa chọn loại hàng hóa");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }
    }
}

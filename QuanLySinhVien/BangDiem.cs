using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class BangDiem : Form
    {
        #region Hàm khởi tạo
        public BangDiem()
        {
            InitializeComponent();
        }

        public int IsThem { get; private set; }
        #endregion

        #region Hàm Load
        private void BangDiem_Load(object sender, EventArgs e)
        {
            comboBoxMaLop.DataSource = ClassLop.GetDanhSachLopHoc().ToList();
            comboBoxMaLop.DisplayMember = "TenLop";
            comboBoxMaLop.ValueMember = "MaLop";

            comboBoxMaSV.DataSource = ClassSinhVien.GetDanhSachSinhVien().ToList();
            comboBoxMaSV.DisplayMember = "TenLop";
            comboBoxMaSV.ValueMember = "MaLop";
        }
        #endregion

        #region Button Save
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ClassBangDiem bangdiem = GetInputForm();

                if (IsThem == 1)
                {
                    ClassBangDiem.Them(bangdiem);    
                }   
                else
                {
                    ClassBangDiem.Sua(bangdiem);
                }    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #region Hàm GetInputForm
        private ClassBangDiem GetInputForm()
        {
            if (txtDiemToan.Text == "")
            {
                txtDiemToan.Focus();
                throw new Exception("Chưa nhập điểm Toán");
            }
            if (txtDiemLy.Text == "")
            {
                txtDiemLy.Focus();
                throw new Exception("Chưa nhập điểm Lý");
            }
            if (txtDiemHoa.Text == "")
            {
                txtDiemHoa.Focus();
                throw new Exception("Chưa nhập điểm Hóa");
            }

            double Toan, Ly, Hoa;

            if (double.TryParse(txtDiemToan.Text, out Toan) == true)
            {
                if (Toan > 10 || Toan < 0)
                {
                    txtDiemToan.Focus();
                    throw new Exception("Điểm Toán không hợp lệ");
                }
            }
            else
            {
                txtDiemToan.Focus();
                throw new Exception("Điểm Toán không hợp lệ");
            }

            if (double.TryParse(txtDiemLy.Text, out Ly) == true)
            {
                if (Ly > 10 || Ly < 0)
                {
                    txtDiemLy.Focus();
                    throw new Exception("Điểm Lý không hợp lệ");
                }
            }
            else
            {
                txtDiemLy.Focus();
                throw new Exception("Điểm Lý không hợp lệ");
            }

            if (double.TryParse(txtDiemHoa.Text, out Hoa) == true)
            {
                if (Hoa > 10 || Hoa < 0)
                {
                    txtDiemHoa.Focus();
                    throw new Exception("Điểm Hóa không hợp lệ");
                }
            }
            else
            {
                txtDiemHoa.Focus();
                throw new Exception("Điểm Hóa không hợp lệ");
            }

            ClassLop itemLop = (ClassLop) comboBoxMaLop.SelectedItem;

            ClassSinhVien itemSV = (ClassSinhVien)comboBoxMaSV.SelectedItem;

            return new ClassBangDiem(itemLop.MaLop, itemSV.MaSV, Toan, Ly, Hoa);

            #endregion

        }
        #endregion

    }
}

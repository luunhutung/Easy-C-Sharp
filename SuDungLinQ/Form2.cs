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
    public partial class Form2 : Form
    {
        static Estore20DataContext _Estore20DB = new Estore20DataContext();

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dgvLoai.DataSource = _Estore20DB.Loais.ToList();    
        }

        private void dgvLoai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string maLoai = dgvLoai.Rows[e.RowIndex].Cells[0].Value.ToString();

            Loai chonLoai = _Estore20DB.Loais.Where(loai => loai.MaLoai.ToString().Equals(maLoai)).FirstOrDefault();

            SetInputForm(chonLoai);
        }

        private void ResetListLoai()
        {
            dgvLoai.DataSource = _Estore20DB.Loais.ToList();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim();

            dgvLoai.DataSource = _Estore20DB.Loais.Where(loai => loai.TenLoai.Contains(tuKhoa) 
            || loai.MaLoai.ToString().Contains(tuKhoa)).ToList();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Loai themLoai = new Loai()
            {
                MaLoai = int.Parse(txtMaLoai.Text.ToString()),
                TenLoai = txtTenLoai.Text,
                MoTa = txtMoTa.Text
            };

            _Estore20DB.Loais.InsertOnSubmit(themLoai);

            _Estore20DB.SubmitChanges();

            ResetListLoai();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Loai suaLoai = GetInputForm();

            _Estore20DB.Loais.
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Loai xoaLoai = new Loai()
            {
                MaLoai = int.Parse(txtMaLoai.Text.ToString()),
                TenLoai = txtTenLoai.Text,
                MoTa = txtMoTa.Text
            };

            _Estore20DB.Loais.DeleteOnSubmit(xoaLoai);

            _Estore20DB.SubmitChanges();

            ResetListLoai();
        }

        private void SetInputForm(Loai chonLoai)
        {
            txtMaLoai.Text = chonLoai.MaLoai.ToString();
            txtTenLoai.Text = chonLoai.TenLoai;
            txtMoTa.Text = chonLoai.MoTa;
        }

        private Loai GetInputForm()
        {
            int maLoai = int.Parse(txtMaLoai.Text);
            string tenLoai = txtTenLoai.Text;
            string moTa = txtMoTa.Text;

            return new Loai()
            {
                MaLoai = maLoai,
                TenLoai = tenLoai,
                MoTa = moTa
            };
        }
    }
}

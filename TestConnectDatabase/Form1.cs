using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestConnectDatabase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'testDataSet1.SinhVien' table. You can move, or remove it, as needed.
            this.sinhVienTableAdapter1.Fill(this.testDataSet1.SinhVien);
        }

        private void btnThemSV_Click(object sender, EventArgs e)
        {
            ConnectDB connectDB = new ConnectDB();
           
            string sql = string.Format(@"INSERT INTO SinhVien(TenSV, GioiTinh, SoDT, DiaChi, NgaySinh) VALUES(N'{0}', '{1}', '{2}', N'{3}', '{4}')", "Nhất Nghệ", 1, "1234567890", "Địa Chỉ", new DateTime(2000, 10, 10).ToString());

            connectDB.InsertQuery(sql);

            this.sinhVienTableAdapter1.Fill(this.testDataSet1.SinhVien);
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            ConnectDB connectDB = new ConnectDB();

            string sql = string.Format(@"DELETE FROM SinhVien DBCC CHECKIDENT (SinhVien, RESEED, 0)");

            connectDB.InsertQuery(sql);

            this.sinhVienTableAdapter1.Fill(this.testDataSet1.SinhVien);
        }
    }
}

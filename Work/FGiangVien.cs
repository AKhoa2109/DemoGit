using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Work
{
    public partial class FGiangVien : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        public FGiangVien()
        {
            InitializeComponent();
        }

        private void FGiangVien_Load(object sender, EventArgs e)
        {
            GiangVienDAO gvDao = new GiangVienDAO();
            gvGVien.DataSource = gvDao.Load();
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {

        }
        public static bool kiemTraEmail(string email)
        {
            string mail = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";
            return Regex.IsMatch(email, mail);
        }
        public static bool kiemTraSDT(string sdt)
        {
            string soDT = @"^[0-9]{10}$";
            return Regex.IsMatch(sdt, soDT);
        }
        public static bool kiemTraNgaySinh(DateTime ngaySinh)
        {
            DateTime ngayHienTai = DateTime.Now;
            int tuoi = ngayHienTai.Year-ngaySinh.Year;
            return tuoi >= 18;
        }
        private void btnThem_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtName.Text))
                {
                    throw new Exception("Vui lòng nhập lại họ tên");
                }
                if (string.IsNullOrEmpty(txtAddress.Text))
                {
                    throw new Exception("Vui lòng nhập lại địa chỉ");
                }
                if(string.IsNullOrEmpty(txtCMND.Text))
                {
                    throw new Exception("Vui lòng nhập lại CMND");
                }
                if (string.IsNullOrEmpty(txtGioiTinh.Text)) 
                {
                    throw new Exception("Vui lòng nhập lại giới tính");
                }
                if (string.IsNullOrEmpty(txtEmail.Text)) 
                {
                    throw new Exception("Vui lòng nhập lại email");
                }
                if (string.IsNullOrEmpty(txtId.Text))
                {
                    throw new Exception("Vui lòng nhập lại Id");
                }
                if(string.IsNullOrEmpty(txtSdt.Text))
                {
                    throw new Exception("Vui lòng nhập lại số điện thoại");
                }
                if (kiemTraEmail(txtEmail.Text))
                {
                    throw new Exception("Vui lòng nhập email hợp lệ!!!");
                }
                if (kiemTraSDT(txtSdt.Text))
                {
                    throw new Exception("Vui lòng nhập số điện thoại hợp lệ!!!");
                }
                if (kiemTraNgaySinh(dtpDate.Value))
                {
                    throw new Exception("Vui lòng điền ngày sinh hợp lệ!!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            GiangVien gv = new GiangVien(txtName.Text, txtAddress.Text, txtCMND.Text, dtpDate.Text, txtEmail.Text, txtSdt.Text, txtId.Text, txtGioiTinh.Text);
            GiangVienDAO gvDao = new GiangVienDAO();
            gvDao.Xoa(gv);
            FGiangVien_Load(sender, e);
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            GiangVien gv = new GiangVien(txtName.Text, txtAddress.Text, txtCMND.Text, dtpDate.Text, txtEmail.Text, txtSdt.Text, txtId.Text, txtGioiTinh.Text);
            GiangVienDAO gvDao = new GiangVienDAO();
            gvDao.Xoa(gv);
            FGiangVien_Load(sender, e);
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            GiangVien gv = new GiangVien(txtName.Text, txtAddress.Text, txtCMND.Text, dtpDate.Text, txtEmail.Text, txtSdt.Text, txtId.Text, txtGioiTinh.Text);
            GiangVienDAO gvDao = new GiangVienDAO();
            gvDao.Xoa(gv);
            FGiangVien_Load(sender, e);
        }

        private void btnNext_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FGiangVien frm2 = new FGiangVien();
            frm2.Show();
        }
    }
}

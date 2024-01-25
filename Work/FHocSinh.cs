using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;
using System.Diagnostics.Eventing.Reader;

namespace Work
{
    public partial class FHocSinh : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        public FHocSinh()
        {
            InitializeComponent();
        }
        
       
        private void Form1_Load(object sender, EventArgs e)
        {
            HocSinhDAO hsDao = new HocSinhDAO();
            gvHsinh.DataSource = hsDao.Load();
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
            int tuoi = ngayHienTai.Year - ngaySinh.Year;
            return tuoi >= 18;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!kiemTraEmail(txtEmail.Text))
                {
                    throw new Exception("Vui lòng nhập email hợp lệ!!!");
                }
                if (!kiemTraSDT(txtSdt.Text))
                {
                    throw new Exception("Vui lòng nhập số điện thoại hợp lệ!!!");
                }
                if (!kiemTraNgaySinh(dtpDate.Value))
                {
                    throw new Exception("Vui lòng điền ngày sinh hợp lệ!!!");
                }
                if (string.IsNullOrEmpty(txtName.Text))
                {
                    throw new Exception("Vui lòng nhập lại họ tên");
                }
                if (string.IsNullOrEmpty(txtAddress.Text))
                {
                    throw new Exception("Vui lòng nhập lại địa chỉ");
                }
                if (string.IsNullOrEmpty(txtCMND.Text))
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
                if (string.IsNullOrEmpty(txtSdt.Text))
                {
                    throw new Exception("Vui lòng nhập lại số điện thoại");
                }
                else
                {
                    HocSinh hs = new HocSinh(txtName.Text, txtAddress.Text, txtCMND.Text, dtpDate.Text, txtEmail.Text, txtSdt.Text, txtId.Text, txtGioiTinh.Text, txtDiem.Text);
                    HocSinhDAO hsDao = new HocSinhDAO();
                    hsDao.Them(hs);
                    Form1_Load(sender, e);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            HocSinh hs = new HocSinh(txtName.Text, txtAddress.Text, txtCMND.Text, dtpDate.Text, txtEmail.Text, txtSdt.Text, txtId.Text, txtGioiTinh.Text,txtDiem.Text);
            HocSinhDAO hsDao = new HocSinhDAO();
            hsDao.Xoa(hs);
            Form1_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            HocSinh hs = new HocSinh(txtName.Text, txtAddress.Text, txtCMND.Text, dtpDate.Text, txtEmail.Text, txtSdt.Text, txtId.Text, txtGioiTinh.Text, txtDiem.Text);
            HocSinhDAO hsDao = new HocSinhDAO();
            hsDao.Sua(hs);
            Form1_Load(sender, e);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Hide();
            FGiangVien frm2 = new FGiangVien();
            frm2.Show();
        }

        private void lblAdress_Click(object sender, EventArgs e)
        {

        }

        private void rdoGT8_CheckedChanged(object sender, EventArgs e)
        {
            HocSinh hs = new HocSinh(txtName.Text, txtAddress.Text, txtCMND.Text, dtpDate.Text, txtEmail.Text, txtSdt.Text, txtId.Text, txtGioiTinh.Text, "9");
            HocSinhDAO hsDao = new HocSinhDAO();
            gvHsinh.DataSource = hsDao.Loc(hs);
        }

        private void rdoLT8_CheckedChanged(object sender, EventArgs e)
        {
            HocSinh hs = new HocSinh(txtName.Text, txtAddress.Text, txtCMND.Text, dtpDate.Text, txtEmail.Text, txtSdt.Text, txtId.Text, txtGioiTinh.Text, "6");
            HocSinhDAO hsDao = new HocSinhDAO();
            gvHsinh.DataSource = hsDao.Loc(hs);
        }

        private void rdoLT5_CheckedChanged(object sender, EventArgs e)
        {
            HocSinh hs = new HocSinh(txtName.Text, txtAddress.Text, txtCMND.Text, dtpDate.Text, txtEmail.Text, txtSdt.Text, txtId.Text, txtGioiTinh.Text, "4");
            HocSinhDAO hsDao = new HocSinhDAO();
            gvHsinh.DataSource = hsDao.Loc(hs);
        }
    }
}

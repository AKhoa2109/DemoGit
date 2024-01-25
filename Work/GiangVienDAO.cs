using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Work
{
    internal class GiangVienDAO
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        DBconnection db = new DBconnection();
        
        public GiangVienDAO()
        {

        }
        public DataTable Load()
        {
           return db.Load("GiangVien");
        }
        public void Them(GiangVien gv)
        {
            string sqlStr = string.Format($"INSERT INTO GiangVien(Ten , Diachi, CMND, NgayThang) VALUES ('{gv.HoTen}','{gv.DiaChi}','{gv.Cmnd}','{gv.NgayThang}')");
            db.ThucThi(sqlStr);
        }
        public void Xoa(GiangVien gv)
        {
            string SQL = string.Format("DELETE FROM GiangVien WHERE Cmnd = '{0}'", gv.Cmnd);
            db.ThucThi(SQL);
        }
        public void Sua(GiangVien gv)
        {
            string SQL = string.Format("UPDATE GiangVien SET Ten = '{0}', DiaChi = '{1}', NgayThang = '{2}' WHERE Cmnd = {3}", gv.HoTen, gv.DiaChi, gv.NgayThang, gv.Cmnd);
            db.ThucThi(SQL);
        }
        
    }
}

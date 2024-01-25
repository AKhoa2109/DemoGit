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
    internal class HocSinhDAO
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        DBconnection db = new DBconnection();
        public DataTable Load()
        {
            return db.Load("HocSinh");
        }
        public void Them(HocSinh hs)
        {
            string sqlStr = string.Format($"INSERT INTO HocSinh(Ten , Diachi, CMND, Date, Diem) VALUES ('{hs.HoTen}','{hs.DiaChi}','{hs.Cmnd}','{hs.NgayThang}','{hs.Diem}')");
            db.ThucThi(sqlStr);
        }
        public void Xoa(HocSinh hs)
        {
            string SQL = string.Format("DELETE FROM HocSinh WHERE Cmnd = '{0}'", hs.Cmnd);
            db.ThucThi(SQL);
        }
        public void Sua(HocSinh hs)
        {
            string SQL = string.Format("UPDATE HocSinh SET Ten = '{0}', DiaChi = '{1}', Date = '{2}' WHERE Cmnd = {3}", hs.HoTen, hs.DiaChi, hs.NgayThang, hs.Cmnd);
            db.ThucThi(SQL);
        }
        public DataTable Loc(HocSinh hs)
        {
            string SQL;
            if (Convert.ToInt32(hs.Diem) > 8)
            {
                SQL = string.Format("SELECT * FROM HocSinh WHERE Diem >=8 ");
            }
            else if (Convert.ToInt32(hs.Diem) < 8 && Convert.ToInt32(hs.Diem) >= 5)
            {
                SQL = string.Format("SELECT * FROM HocSinh WHERE Diem >=5 AND Diem <8 ");
            }
            else
            {
                SQL = string.Format("SELECT * FROM HocSinh WHERE Diem <5");
            }
            
            try
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(SQL, conn);
                DataTable dtHocSinh = new DataTable();
                adapter.Fill(dtHocSinh);
                return dtHocSinh;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);

            }
            finally
            {
                conn.Close();
            }
            return null;
        }
    }
}

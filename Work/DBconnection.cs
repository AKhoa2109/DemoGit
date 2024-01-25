using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Work
{
    internal class DBconnection
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        public DataTable Load(string tenDoiTuong)
        {
            try
            {
                conn.Open();
                string sqlStr = string.Format("SELECT *FROM {0}",tenDoiTuong);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataTable dtGiangVien = new DataTable();
                adapter.Fill(dtGiangVien);
                return dtGiangVien;
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
        public void ThucThi(string s)
        {
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(s, conn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Thanh cong");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("That bai" + ex);
            }
            finally
            {
                conn.Close();
            }

        }
    }
}

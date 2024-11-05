using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    internal class function
    {
        protected SqlConnection getConnection()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\study\DoAnChuyenNganh\Project\QuanLyKhachSan\QuanLyKhachSan\QLKS.mdf;Integrated Security=True";
            return conn;
        }
        public DataSet getData(String query)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandText = query;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            da.Fill(ds);
            return ds;
        }
        public void setData(String query, String message)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            con.Open();

            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public SqlDataReader getForCombo(String query)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            con.Open();

            cmd = new SqlCommand(query, con);
            SqlDataReader sdr = cmd.ExecuteReader();

            return sdr;
        }

        public int login(string sql)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            int kq = (int)cmd.ExecuteScalar();
            con.Close();
            return kq;
        }
        public DataTable GetDataTable(string sql)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            DataTable dt = new DataTable();
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;

            try
            {
                con.Open();
                SqlDataAdapter sda  = new SqlDataAdapter(cmd);
                sda.Fill(dt);
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
            }
            con.Close();

            return dt;
        }
    }
}

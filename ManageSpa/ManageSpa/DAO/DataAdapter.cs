using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace DAO
{
    class DataAdapter
    {
        string cnstr;
        private SqlConnection cn;

        public SqlConnection CN
        {
            get { return cn; }
            set { cn = value; }
        }
        public void Connect()
        {

            try
            {
                if (cn != null && cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public void Disconnet()
        {
            try
            {
                if (cn != null && cn.State != ConnectionState.Closed)
                {
                    cn.Close();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public DataAdapter()
        {
            cnstr = ConfigurationManager.ConnectionStrings["cnstr"].ConnectionString;
            cn = new SqlConnection(cnstr);
        }
        /// <summary>
        /// thực hiện câu lệnh truy vấn bảng dữ liệu
        /// </summary>
        /// <param name="sql">câu lệnh SQL</param>
        /// <returns>SqlDataReader</returns>
        public SqlDataReader ExecuteReader(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, cn);
            return cmd.ExecuteReader();
        }


        /// <summary>
        /// thực hiện câu lệnh truy vấn không trả về giá trị (update insert)
        /// </summary>
        /// <param name="sql">câu lệnh SQL</param>
        /// <returns>trả về kiểu int để kiểm tra</returns>
        public int ExecuteNonQuery(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, cn);
            return cmd.ExecuteNonQuery();

        }
        /// <summary>
        /// thực hiện nhưng câu lệnh trả về đơn giá trị
        /// </summary>
        /// <param name="sql">câu lệnh SQL</param>
        /// <returns>trả về 1 giá trị object</returns>
        public object ExecuteScalar(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, cn);
            return cmd.ExecuteScalar();
        }

    }
}

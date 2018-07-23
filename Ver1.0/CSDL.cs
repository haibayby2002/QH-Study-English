using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Ver1._0
{
    public class CSDL
    {
        // Connection String thiết lập các thông số để kết nối.
        public static string cnStr = @"Data Source=.\SQLEXPRESS;Initial Catalog=HocTiengAnh;Integrated Security=True";

        // Tạo kết nối
        static SqlConnection cn;

        static public DataTable LoadCSDL(string sql)
        {
            DataTable dt = new DataTable();
            cn = new SqlConnection(cnStr);
            SqlCommand cm = new SqlCommand(sql, cn);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dt);
            return dt;
        }
        //insert, update, delete
        static public int Change(string sql)
        {
            cn = new SqlConnection(cnStr);
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }
            SqlCommand cm = new SqlCommand(sql, cn);
            int kq = cm.ExecuteNonQuery();
            cn.Close();
            return kq;
        }

        //Sửa trong sql
        public static void SuaTu(string tenTu, string tenBo, bool isRight, SqlConnection conn)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            //Update số lần trả lời sai và số lần luyện tập
            string query = @"UpDate TuVung set
SoLanLuyenTap = SoLanLuyenTap + 1,
SoLanTraLoiSai = SoLanTraLoiSai + 1
where TenBoTuVung = N'" + tenBo + "' and TenTuVung = '" + tenTu + "'";

            if (isRight)    //Trả lời đúng => số lần trả lời sai không tăng
            {
                query = @"UpDate TuVung set
SoLanLuyenTap = SoLanLuyenTap + 1
where TenBoTuVung = N'" + tenBo + "' and TenTuVung = '" + tenTu + "'";
            }

            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            Console.WriteLine(cmd.CommandText);

            //Update tỉ lệ trả lời sai
            string query2 = @"
Update TuVung set 
TiLeTraLoiSai = CONVERT(float, SoLanTraLoiSai) / SoLanLuyenTap
where TenBoTuVung = N'" + tenBo + "' and TenTuVung = '" + tenTu + "'";
            cmd.CommandText = query2;
            cmd.ExecuteNonQuery();
            //Console.WriteLine(cmd.CommandText);
        }
    }
}

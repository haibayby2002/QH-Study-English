using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ver1._0
{
    public class XuLyDuLieu
    {
        public static string ChuyenVeDataBase(string s)
        {
            s = s.Replace('\n', '@');
            for (int i = 0; i < s.Length; i++)
            {
                if(s[i] == '@')
                {
                    s = s.Remove(i - 1, 1);
                }
            }
            return s;
        }

        public static string ChuyenQuaGiaoDien(string s)
        {
            //s = s.Replace('@', '\n');
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '@')
                {
                    s = s.Remove(i, 1);
                    s = s.Insert(i, @" 
");
                }
            }

            return s;
        }

    }
}

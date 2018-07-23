using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ver1._0
{
    public partial class FormThemBo : Form
    {
        public FormThemBo()
        {
            InitializeComponent();
        }

        public static bool xacNhan;
        public static string ten, moTa;

        private void FormThemBo_Load(object sender, EventArgs e)
        {
            txtTenBo.Select();
            xacNhan = false;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if(txtTenBo.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên bộ từ", "Lỗi thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string query = @"INSERT Into BoTuVung(TenBoTuVung, GhiChu) values (N'" + XuLyDuLieu.ChuyenVeDataBase(txtTenBo.Text) + "', N'" + XuLyDuLieu.ChuyenVeDataBase(txtMoTa.Text) + "')";
                
                try
                {
                    if (CSDL.Change(query) != 1)
                    {
                        MessageBox.Show("Bộ từ đã bị trùng, xin vui lòng đổi tên hoặc xóa bộ đã có" + txtTenBo.Text, "Lỗi trùng lặp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        xacNhan = false;
                    }
                    else
                    {
                        xacNhan = true;
                        ten = txtTenBo.Text;
                        moTa = txtMoTa.Text;
                        this.Close();
                    }
                }
                catch(SqlException)
                {
                    MessageBox.Show("Bộ từ vựng đã bị trùng tên, xin vui lòng đổi tên hoặc xóa bộ đã có" + txtTenBo.Text, "Lỗi trùng lặp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

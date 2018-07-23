using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ver1._0
{
    public partial class ThemTu : Form
    {
        public ThemTu()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if(txtTuCanThem.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên từ cần thêm", "Lỗi thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTuCanThem.Select();
            }
            else if(txtNghiaCuaTu.Text == "")
            {
                MessageBox.Show("Nghĩa của từ không được bỏ trống", "Lỗi thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNghiaCuaTu.Select();
            }
        }
    }
}

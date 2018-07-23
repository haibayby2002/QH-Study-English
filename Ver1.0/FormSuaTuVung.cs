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
    public partial class FormSuaTuVung : Form
    {
        public FormSuaTuVung()
        {
            InitializeComponent();
        }

        public static bool checkSua = false;
        public static string nghiaTuMoi;
        
        private void FormSuaTuVung_Load(object sender, EventArgs e)
        {
            checkSua = false;
            txtTuCanSua.Text = ptbChe.tuCanSua;
            txtNghiaTuMoi.Text = ptbChe.nghiaTuMoi;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            //Cập nhật trên class trước
            if(txtNghiaTuMoi.Text == "")
            {
                MessageBox.Show("Nghĩa của từ không được bỏ trống. Xin kiểm tra lại", "Lỗi thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNghiaTuMoi.Select();
            }
            else
            {
                //Sửa trên database trước, thành công rồi mới sửa trên listview               
                int kq = CSDL.Change(@"Update TuVung set NghiaTuVung = N'" + XuLyDuLieu.ChuyenVeDataBase(txtNghiaTuMoi.Text) + "' where TenBoTuVung = N'" + ptbChe.suaTrongBo + "' and TenTuVung = '" + txtTuCanSua.Text + "'");
                checkSua = true;
                nghiaTuMoi = txtNghiaTuMoi.Text;

                MessageBox.Show("Sửa thành công!", "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}

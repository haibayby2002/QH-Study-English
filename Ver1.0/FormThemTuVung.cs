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
    public partial class FormThemTuVung : Form
    {
        public FormThemTuVung()
        {
            InitializeComponent();
        }

        public static bool checkThem;
        public static string tuCanThem, nghiaTuCanThem;
        private void FormThemTuVung_Load(object sender, EventArgs e)
        {
            txtTuCanThem.Select();
            checkThem = false;
            tuCanThem = nghiaTuCanThem = "";

            cmbBoThem.Items.Clear();
            for (int i = 0; i < ptbChe.dsBoTu.Items.Count; i++)
            {
                cmbBoThem.Items.Add(ptbChe.dsBoTu.Items[i]);
            }
            cmbBoThem.SelectedIndex = ptbChe.viTriBoThem;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if(txtTuCanThem.Text == "")
            {
                MessageBox.Show("Tên từ vựng thêm vào không được bỏ trống.", "Lỗi thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                try
                {
                    int kq = CSDL.Change(@"Insert into TuVung (TenTuVung, NghiaTuVung, TenBoTuVung, SoLanLuyenTap, SoLanTraLoiSai, TiLeTraLoiSai) values ('" + txtTuCanThem.Text + "', N'" + XuLyDuLieu.ChuyenVeDataBase(txtNghiaCuaTu.Text) + "', N'" + cmbBoThem.Text + "', 0, 0, 1006)");

                    //thêm vào class và listview, để form kia lo!
                    if (kq != 0)
                    {
                        //MessageBox.Show("Thêm thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        checkThem = true;
                        tuCanThem = txtTuCanThem.Text;
                        nghiaTuCanThem = txtNghiaCuaTu.Text;

                        this.Close();   //Đóng form lại

                    }
                    else
                    {
                        MessageBox.Show("Từ mới đã bị trùng, xin kiểm tra lại!", "Lỗi trùng lặp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (SqlException)
                {
                    MessageBox.Show("Từ mới đã bị trùng, xin kiểm tra lại!", "Lỗi trùng lặp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}

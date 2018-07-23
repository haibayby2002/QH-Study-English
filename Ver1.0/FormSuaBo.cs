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
    public partial class FormSuaBo : Form
    {
        public FormSuaBo()
        {
            InitializeComponent();
        }

        public static bool checkSua;
        public static string boMoi, boCu, moTaMoi;

        private void FormSuaBo_Load(object sender, EventArgs e)
        {
            boMoi = boCu = moTaMoi = "";
            checkSua = false;
            txtTenBoMoi.Select();

            cmbBoTuSua.Items.Clear();

            for(int i = 0; i<ptbChe.dsBoTu.Items.Count;i++)
            {
                cmbBoTuSua.Items.Add(ptbChe.dsBoTu.Items[i].ToString());
                //MessageBox.Show(ptbChe.dsTu.Items[i].ToString());
            }
            
            cmbBoTuSua.SelectedIndex = ptbChe.viTriSua;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbBoTuSua_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(TenChuoi.ketNoi);
            conn.Open();

            //Truy vấn lấy chú thích
            string query = @"select btv.GhiChu 
                                from BoTuVung btv 
                                where btv.TenBoTuVung = N'" + cmbBoTuSua.Text + "'";

            SqlCommand cmd = new SqlCommand(query, conn);

            txtTenBoMoi.Text = cmbBoTuSua.SelectedItem.ToString();
            txtMoTaMoi.Text = XuLyDuLieu.ChuyenQuaGiaoDien(cmd.ExecuteScalar().ToString());
            
        }
      
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if(txtTenBoMoi.Text == "")
            {
                MessageBox.Show("Tên bộ từ không được bỏ trống", "Lỗi thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int kq = CSDL.Change("Update BoTuVung set TenBoTuVung = N'" + txtTenBoMoi.Text + "', GhiChu = N'" + XuLyDuLieu.ChuyenVeDataBase(txtMoTaMoi.Text) + "' where TenBoTuVung = N'" + cmbBoTuSua.Text + "'");

                    if (kq == 0)
                    {
                        MessageBox.Show("Tên bộ từ vựng này đã bị trùng hoặc chưa sửa, vui lòng kiểm tra lại!", "Lỗi thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Sửa thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        checkSua = true;
                        boMoi = txtTenBoMoi.Text;
                        boCu = cmbBoTuSua.Text;
                        moTaMoi = txtMoTaMoi.Text;
                        this.Close();
                    }
                }
                catch(SqlException a)
                {
                    MessageBox.Show("Tên bộ từ vựng này đã bị trùng hoặc chưa sửa, vui lòng kiểm tra lại!", "Lỗi thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

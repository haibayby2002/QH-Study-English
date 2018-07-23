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
    public partial class FormMoBoTu : Form
    {
        public FormMoBoTu()
        {
            InitializeComponent();
        }

        public static string tenBoTu;
        public static string moTa;
        private static BoTuVung btv = new BoTuVung();

        internal static BoTuVung Btv { get => btv; set => btv = value; }

        private void FormMoBoTu_Load(object sender, EventArgs e)
        {
            txtTenBo.Text = tenBoTu;
            txtMoTa.Text = moTa;
            btv = new BoTuVung();
            btv.ListTuVung = new List<TuVung>();
            foreach (TuVung tv in ptbChe.BoTuMo.ListTuVung)
            {
                btv.ListTuVung.Add(tv);
                ListViewItem i = new ListViewItem(tv.TenTu);
                i.SubItems.Add(tv.NghiaTu);
                lvDanhSachTu.Items.Add(i);
            }

            txtTenBo.Select();
            xacNhan = false;
            chkAll.Checked = true;
        }

        private void chkAll_CheckedChanged(object sender, EventArgs e)
        {
            foreach(ListViewItem i in lvDanhSachTu.Items)
            {
                i.Checked = chkAll.Checked;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static bool xacNhan;
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTenBo.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên bộ từ", "Lỗi thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string query = @"INSERT Into BoTuVung(TenBoTuVung, GhiChu) values (N'" + XuLyDuLieu.ChuyenVeDataBase(txtTenBo.Text) + "', N'" + XuLyDuLieu.ChuyenVeDataBase(txtMoTa.Text) + "')";

                try
                {
                    if (CSDL.Change(query) != 1)
                    {
                        MessageBox.Show("Bộ từ đã bị trùng, xin vui lòng đổi tên hoặc xóa bộ đã có " + txtTenBo.Text, "Lỗi trùng lặp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Thêm thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        xacNhan = true;
                        this.Close();
                    }
                }
                catch (SqlException)
                {
                    MessageBox.Show("Bộ từ vựng đã bị trùng tên, xin vui lòng đổi tên hoặc xóa bộ đã có " + txtTenBo.Text, "Lỗi trùng lặp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //Chạy được tới đây là thêm thành công
                SqlConnection cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=HocTiengAnh;Integrated Security=True");
                try
                {
                    
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = cn;
                    if (cn.State == ConnectionState.Closed)
                    {
                        cn.Open();
                    }
                    //Thêm từ vựng vào
                    for (int i = 0; i < lvDanhSachTu.Items.Count; i++) 
                    {
                        if (lvDanhSachTu.Items[i].Checked)
                        {
                            TuVung tv = new TuVung();
                            tv = btv.ListTuVung[i];
                            cmd = new SqlCommand(@"insert into TuVung(TenTuVung, NghiaTuVung, TenBoTuVung, SoLanLuyenTap, SoLanTraLoiSai, TiLeTraLoiSai)
values
('" + tv.TenTu + "', N'" + XuLyDuLieu.ChuyenVeDataBase(tv.NghiaTu) + "', N'" + txtTenBo.Text + "', 0, 0, 1006)", cn);

                            cmd.ExecuteNonQuery();
                        }

                    }
                }
                catch (SqlException)
                {
                    MessageBox.Show("Lỗi");
                }
                finally
                {
                    cn.Close();
                }
            }
        }
    }
}

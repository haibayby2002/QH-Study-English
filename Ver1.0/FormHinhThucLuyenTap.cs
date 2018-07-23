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
    public partial class FormHinhThucLuyenTap : Form
    {
        public FormHinhThucLuyenTap()
        {
            InitializeComponent();
        }
        public static int hinhThuc;
        public static bool luyenTapHet, xacNhan;
        private void FormHinhThucLuyenTap_Load(object sender, EventArgs e)
        {
            xacNhan = false;    //Không luyện tập
            cmbHinhThuc.SelectedIndex = 0;
            hinhThuc = 0;

            if (ptbChe.camChon)
            {
                rdbLuyenTapTuDaChon.Enabled = false;
            }
            else
            {
                rdbLuyenTapTuDaChon.Enabled = true;
            }
            if (ptbChe.luyenTapHet)
            {
                rdbLuyenTapHet.Checked = true;
            }
            else
            {
                rdbLuyenTapTuDaChon.Checked = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuyenTap_Click(object sender, EventArgs e)
        {
            if(cmbHinhThuc.SelectedIndex == 0)
            {
                MessageBox.Show("Vui lòng chọn hình thức luyện tập", "Lỗi chưa chọn phần tử", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbHinhThuc.Select();
            }
            else
            {
                hinhThuc = cmbHinhThuc.SelectedIndex;
                luyenTapHet = rdbLuyenTapHet.Checked;
                xacNhan = true;

                this.Close();
            }
        }
    }
}

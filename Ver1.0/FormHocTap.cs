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
    public partial class FormHocTap : Form
    {
        public FormHocTap()
        {
            InitializeComponent();
        }

        BoTuVung btv;
        int i;
        List<bool> check = new List<bool>();

        private void FormHocTap_Load(object sender, EventArgs e)
        {
            //Tạo bộ từ vựng
            btv = new BoTuVung();
            btv.ListTuVung = new List<TuVung>();
            check = new List<bool>();
            foreach (TuVung tv in ptbChe.Btv.ListTuVung)
            {
                btv.ListTuVung.Add(tv);
                check.Add(false);
            }

            i = 0;

            Scene();

            
        }

        void Scene()
        {
            lblThuTu.Text = (i + 1).ToString() + "/" + btv.ListTuVung.Count;
            lblTenTuVung.Text = btv.ListTuVung[i].TenTu;

            txtNghiaTuVung.Text = btv.ListTuVung[i].NghiaTu;
            txtNghiaTuVung.Visible = check[i];
            btnAnHien.Text = check[i] == true ? "Ẩn nghĩa" : "Hiện nghĩa";
            btnAnHien.BackColor = check[i] == true ? Color.LightBlue : Color.GreenYellow;
            
        }

        void BackScene()
        {
            if (i > 0)
            {
                i--;
                Scene();
            }
        }

        void NextScene()
        {
            if (i < btv.ListTuVung.Count - 1)
            {
                i++;
                Scene();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            BackScene();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            NextScene();
        }

        private void btnAnHien_Click(object sender, EventArgs e)
        {
            if (btnAnHien.Text == "Hiện nghĩa")       //Nếu đang có text là hiện tức là ấn => ấn vào hiện từ
            {
                txtNghiaTuVung.Visible = true;  //Hiện nghĩa
                btnAnHien.Text = "Ẩn nghĩa";
                btnAnHien.BackColor = Color.LightBlue;
                check[i] = true;
            }
            else
            {
                txtNghiaTuVung.Visible = false;     //Ẩn nghĩa
                btnAnHien.Text = "Hiện nghĩa";
                btnAnHien.BackColor = Color.GreenYellow;
                check[i] = false;
            }
        }

        private void FormHocTap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                BackScene();
            }
            else if (e.KeyCode == Keys.Right)
            {
                NextScene();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                btnAnHien_Click(sender, e);
            }
        }

        private void txtNghiaTuVung_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Left)
            {
                BackScene();
            }
            else if (e.KeyCode == Keys.Right)
            {
                NextScene();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                btnAnHien_Click(sender, e);
            }
        }

        private void btnNext_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                BackScene();
            }
            else if (e.KeyCode == Keys.Right)
            {
                NextScene();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                btnAnHien_Click(sender, e);
            }
        }
    }
}

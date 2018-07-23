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
    public partial class FormLtTuLuan : Form
    {
        public FormLtTuLuan()
        {
            InitializeComponent();
        }

        public static bool menu;
        public static SqlConnection conn = new SqlConnection(CSDL.cnStr);

        private void FormLtTuLuan_Load(object sender, EventArgs e)
        {
            menu = false;
            //-------------------------Khai báo tào lao
            thuTuCauHoi = 0;
            soCauDung = 0;
            soCauDaTraLoi = 0;

            listCauHoi = new List<CauHoiTuLuan>();
            //Lấy các câu hỏi từ từ vựng ở form bên kia
            foreach (TuVung tv in ptbChe.Btv.ListTuVung)
            {
                CauHoiTuLuan ch = new CauHoiTuLuan(tv);
                listCauHoi.Add(ch);
            }

            //
            tenBo = new string[listCauHoi.Count];
            for (int i = 0; i < tenBo.Length; i++)
            {
                tenBo[i] = ptbChe.tenBo[i];
            }

            tongSoCau = listCauHoi.Count;
            xem = new byte[tongSoCau];

            for(int i = 0; i < tongSoCau; i++)
            {
                xem[i] = 0; //Chưa trả lời
            }

            txtCauHoi.Text = listCauHoi[thuTuCauHoi].CauHoi;
            txtCauTraLoi.Text = listCauHoi[thuTuCauHoi].CauTraLoi;
            lblThuTuCau.Text = "Câu: " + (thuTuCauHoi + 1).ToString();
            lblSoCauDung.Text = "Đúng: " + soCauDung.ToString() + "/" + tongSoCau.ToString();

            conn.Open();    //Mở kết nối
        }

        List<CauHoiTuLuan> listCauHoi = new List<CauHoiTuLuan>();
        int thuTuCauHoi, soCauDung, tongSoCau, soCauDaTraLoi;
        byte[] xem;     //0 là chưa trả lời, 1 là trả lời đúng, 2 là trả lời sai
        string[] tenBo;

        bool KiemTraTraLoiHet()
        {
            for(int i = 0; i < tongSoCau; i++)
            {
                if(xem[i] == 0)
                {
                    return false;
                }
            }
            return true;
        }

        void Scene()
        {
            txtCauHoi.Text = listCauHoi[thuTuCauHoi].CauHoi;
            txtCauTraLoi.Text = listCauHoi[thuTuCauHoi].CauTraLoi;
            lblThuTuCau.Text = "Câu: " + (thuTuCauHoi + 1).ToString();
            lblSoCauDung.Text = "Đúng: " + soCauDung.ToString() + "/" + tongSoCau.ToString();

            if (xem[thuTuCauHoi] != 0)
            {
                txtCauTraLoi.ReadOnly = true;
                txtCauTraLoi.Text = listCauHoi[thuTuCauHoi].CauTraLoi;
                btnChiuThua.Enabled = false;
                btnChiuThua.Text = listCauHoi[thuTuCauHoi].DapAn;
            }
            else
            {
                txtCauTraLoi.ReadOnly = false;
                btnChiuThua.Text = "Chịu thua";
                btnChiuThua.Enabled = true;
                txtCauTraLoi.ReadOnly = false;
            }

            if (thuTuCauHoi < soCauDaTraLoi)
            {
                btnNext.Enabled = true;
                btnNext.Visible = true;
            }
            else
            {
                btnNext.Enabled = false;
                btnNext.Visible = false;
            }

            //Console.WriteLine("Order " + thuTuCauHoi.ToString());
        }

        void NextScene()
        {
            if(soCauDaTraLoi == tongSoCau)
            {
                FormThongKe frmThongKe = new FormThongKe();
                FormThongKe.tongSoCau = soCauDaTraLoi;
                FormThongKe.soCauDung = soCauDung;

                frmThongKe.ShowDialog();

                if (FormThongKe.luaChon == 2)
                {
                    this.Close();
                }
                else if (FormThongKe.luaChon == 3)
                {
                    this.Close();
                }
                else if (FormThongKe.luaChon == 4)
                {
                    this.Close();
                }
            }
            else if (thuTuCauHoi < soCauDaTraLoi)
            {
                thuTuCauHoi++;
            }
            Scene();
        }

        void BackScene()
        {
            if (thuTuCauHoi > 0) 
            {
                thuTuCauHoi--;
            }
            Scene();
        }

        void HieuUng(bool traLoi)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            NextScene();
        }

        private void FormLtTuLuan_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                BackScene();
            }
            else if(e.KeyCode == Keys.Right)
            {
                NextScene();
            }
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            FormThongKe frmThongKe = new FormThongKe();
            FormThongKe.tongSoCau = soCauDaTraLoi;
            FormThongKe.soCauDung = soCauDung;

            frmThongKe.ShowDialog();

            if (FormThongKe.luaChon == 2)
            {
                this.Close();
            }
            else if (FormThongKe.luaChon == 3)
            {
                this.Close();
            }
            else if (FormThongKe.luaChon == 4)
            {
                this.Close();
            }
        }

        private void FormLtTuLuan_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (conn.State == ConnectionState.Open)     //Khi óng thì sẽ đóng luôn kết nối
            {
                conn.Close();
            }
        }

        private void txtCauHoi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                BackScene();
            }
            else if(e.KeyCode == Keys.Right)
            {
                NextScene();
            }
        }

        private void txtCauTraLoi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnChiuThua_Click(sender, e);
            }
            else if (txtCauTraLoi.Enabled == false)     //Không cho phép thì được dịch chuyển tự do 
            {
                if(e.KeyCode == Keys.Left)
                {
                    BackScene();
                }
                else if(e.KeyCode == Keys.Right)
                {
                    NextScene();
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            BackScene();
        }

        private void btnChiuThua_Click(object sender, EventArgs e)
        {

            soCauDaTraLoi++;
            CSDL.SuaTu(listCauHoi[thuTuCauHoi].DapAn, tenBo[thuTuCauHoi], false, conn);     //Update false

            xem[thuTuCauHoi] = 2;   //Trả lời sai
            txtCauTraLoi.ReadOnly = true;
            HieuUng(false);


            NextScene();

        }
       

        private void txtCauTraLoi_TextChanged(object sender, EventArgs e)
        {
            listCauHoi[thuTuCauHoi].CauTraLoi = txtCauTraLoi.Text;

            if (xem[thuTuCauHoi] == 0)
            {             
                if (listCauHoi[thuTuCauHoi].KiemTraDung())
                {
                    HieuUng(true);
                    soCauDung++;
                    soCauDaTraLoi++;

                    CSDL.SuaTu(listCauHoi[thuTuCauHoi].DapAn, tenBo[thuTuCauHoi], true, conn);

                    xem[thuTuCauHoi] = 1;   //Trả lời đúng
                    txtCauTraLoi.ReadOnly = true;

                    xem[thuTuCauHoi] = 1;   //Đã trả lời
                    NextScene();
                }              

            }
        }
       
    }
}

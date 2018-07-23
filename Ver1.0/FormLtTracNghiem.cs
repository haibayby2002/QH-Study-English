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
    public partial class FormLtTracNghiem : Form
    {
        public FormLtTracNghiem()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(CSDL.cnStr);

        int thuTuCauHoi, soCauDung, tongSoCau, soCauDaTraLoi;
        byte[] xem;     //0 là chưa trả lời, 1 là trả lời đúng, 2 là trả lời sai
        string[] tenBo;
        List<CauHoiTracNghiem> listCauHoi = new List<CauHoiTracNghiem>();


        private void FormLtTracNghiem_Load(object sender, EventArgs e)
        {
            this.Select();
            this.Focus();
            btnNext.Enabled = false;
            btnNext.Visible = false;

            conn = new SqlConnection(CSDL.cnStr);
            conn.Open();    //Mở kết nối

            //Thiết lập một số cái linh tinh
            thuTuCauHoi = 0;
            soCauDung = 0;
            soCauDaTraLoi = 0;
            //---------------------------------------------


            //Thiết lập câu hỏi
            tongSoCau = ptbChe.Btv.ListTuVung.Count;
            listCauHoi = new List<CauHoiTracNghiem>();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            SqlDataReader r;
            //-------------------------------------------------------------------
            foreach (TuVung tv in ptbChe.Btv.ListTuVung)
            {
                //Bắt đầu tiến hành select nè^ ahihi:
                string cauA, cauB, cauC, cauD;  //Tạo ra các câu hỏi tí nữa add vô luôn cho nhanh^^
                cauA = cauB = cauC = cauD = "";

                //Giờ là đến câu trả lời-------------------------------------------------
                string query = @"select top 4 TenTuVung from TuVung where TenBoTuVung = N'admin' and TenTuVung not like '%" + tv.TenTu + @"' and NghiaTuVung not like N'%" + XuLyDuLieu.ChuyenVeDataBase(tv.NghiaTu) + @"%' and NghiaTuVung not like N'%" + tv.TenTu + @"%' order by newid()";  //Chuỗi truy vấn để lấy 4 câu trả lồi ngẫu nhiên---------------------------------------------

                //MessageBox.Show(query);

                cmd.CommandText = query;
                
                try
                {
                    r = cmd.ExecuteReader();
                }
                catch(Exception error)
                {
                    MessageBox.Show(error.Message);
                    continue;
                }
                

                //----Đọc vô từng câu trả lời
                r.Read();
                cauA = r["TenTuVung"].ToString();

                r.Read();
                cauB = r["TenTuVung"].ToString();

                r.Read();
                cauC = r["TenTuVung"].ToString();

                r.Read();
                cauD = r["TenTuVung"].ToString();
                //-----------------------------------------------------------------------

                CauHoiTracNghiem ch = new CauHoiTracNghiem(tv.NghiaTu, tv.TenTu, cauA, cauB, cauC, cauD);
                listCauHoi.Add(ch);

                r.Close();
            }

            //Thiết lập tên bộ để tí còn cập nhật lại
            tenBo = new string[listCauHoi.Count];
            for (int i = 0; i < tenBo.Length; i++)
            {
                tenBo[i] = ptbChe.tenBo[i];
            }
            //-----------------------------------------------

            //Thiết lập trạng thái câu hỏi: 0: chưa trả lời; 1: trả lời đúng; 2: trả lời sai
            xem = new byte[tongSoCau];

            for (int i = 0; i < tongSoCau; i++)
            {
                xem[i] = 0; //Chưa trả lời
            }
            //------------------------------------------------------------------------------

            Scene();
        }

        private void FormLtTracNghiem_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Close();
        }

        Button NutLuaChon(int i)
        {
            if(i == 0)
            {
                return btnCauA;
            }
            else if(i == 1)
            {
                return btnCauB;
            }
            else if(i==2)
            {
                return btnCauC;
            }
            return btnCauD;
        }

        void Scene()
        {
            this.Select();
            this.Focus();
            lblSoCauDung.Text = "Số câu đúng: " + soCauDung.ToString() + "/" + tongSoCau.ToString();
            lblThuTuCau.Text = "Câu hỏi thứ: " + (thuTuCauHoi + 1).ToString();
            txtCauHoi.Text = listCauHoi[thuTuCauHoi].CauHoi;
            btnCauA.Text = listCauHoi[thuTuCauHoi].CauTraLoi[0];
            btnCauB.Text = listCauHoi[thuTuCauHoi].CauTraLoi[1];
            btnCauC.Text = listCauHoi[thuTuCauHoi].CauTraLoi[2];
            btnCauD.Text = listCauHoi[thuTuCauHoi].CauTraLoi[3];
            btnCauA.BackColor = btnCauB.BackColor = btnCauC.BackColor = btnCauD.BackColor = Color.Black;

            if(thuTuCauHoi < soCauDaTraLoi)
            {
                btnNext.Enabled = true;
                btnNext.Visible = true;
            }
            else
            {
                btnNext.Enabled = false;
                btnNext.Visible = false;
            }

            if (xem[thuTuCauHoi] != 0)   //Đã trả lời
            {
                NutLuaChon(listCauHoi[thuTuCauHoi].LuaChonCuaBan).BackColor = Color.Red;
                NutLuaChon(listCauHoi[thuTuCauHoi].LuaChon).BackColor = Color.LightGreen;
                btnCauA.Enabled = btnCauB.Enabled = btnCauC.Enabled = btnCauD.Enabled = false;

                if (xem[thuTuCauHoi] == 1)   //Trả lời đúng
                {
                    ptbRight.Visible = true;
                    ptbWrong.Visible = false;
                }
                else    //Trả lời sai
                {
                    ptbWrong.Visible = true;
                    ptbRight.Visible = false;
                }
            }
            else    //Chưa trả lời
            {
                btnCauA.Enabled = btnCauB.Enabled = btnCauC.Enabled = btnCauD.Enabled = true;
                ptbWrong.Visible = ptbRight.Visible = false;
            }
        }

        private void btnCauA_Click(object sender, EventArgs e)
        {
            listCauHoi[thuTuCauHoi].LuaChonCuaBan = 0;

            if (listCauHoi[thuTuCauHoi].KiemTraDung())   //Cập nhật ở trong này
            {
                xem[thuTuCauHoi] = 1;   //Trả lời đúng
                soCauDung++;
                HieuUng(true);
                CSDL.SuaTu(listCauHoi[thuTuCauHoi].DapAn, tenBo[thuTuCauHoi], true, conn);    
            }
            else
            {
                xem[thuTuCauHoi] = 2;   //Trả lời sai
                HieuUng(false);
                CSDL.SuaTu(listCauHoi[thuTuCauHoi].DapAn, tenBo[thuTuCauHoi], false, conn);
            }
            soCauDaTraLoi++;
        }

        private void btnCauB_Click(object sender, EventArgs e)
        {
            listCauHoi[thuTuCauHoi].LuaChonCuaBan = 1;

            if (listCauHoi[thuTuCauHoi].KiemTraDung())   //Cập nhật ở trong này
            {
                xem[thuTuCauHoi] = 1;   //Trả lời đúng
                soCauDung++;
                HieuUng(true);
                CSDL.SuaTu(listCauHoi[thuTuCauHoi].DapAn, tenBo[thuTuCauHoi], true, conn);
            }
            else
            {
                xem[thuTuCauHoi] = 2;   //Trả lời sai
                HieuUng(false);
                CSDL.SuaTu(listCauHoi[thuTuCauHoi].DapAn, tenBo[thuTuCauHoi], false, conn);
            }
            soCauDaTraLoi++;
        }

        private void btnCauC_Click(object sender, EventArgs e)
        {
            listCauHoi[thuTuCauHoi].LuaChonCuaBan = 2;

            if (listCauHoi[thuTuCauHoi].KiemTraDung())   //Cập nhật ở trong này
            {
                xem[thuTuCauHoi] = 1;   //Trả lời đúng
                soCauDung++;
                HieuUng(true);
                CSDL.SuaTu(listCauHoi[thuTuCauHoi].DapAn, tenBo[thuTuCauHoi], true, conn);
            }
            else
            {
                xem[thuTuCauHoi] = 2;   //Trả lời sai
                HieuUng(false);
                CSDL.SuaTu(listCauHoi[thuTuCauHoi].DapAn, tenBo[thuTuCauHoi], false, conn);
            }
            soCauDaTraLoi++;
        }

        private void btnCauD_Click(object sender, EventArgs e)
        {
            listCauHoi[thuTuCauHoi].LuaChonCuaBan = 3;

            if (listCauHoi[thuTuCauHoi].KiemTraDung())   //Cập nhật ở trong này
            {
                xem[thuTuCauHoi] = 1;   //Trả lời đúng
                soCauDung++;
                HieuUng(true);
                CSDL.SuaTu(listCauHoi[thuTuCauHoi].DapAn, tenBo[thuTuCauHoi], true, conn);
            }
            else
            {
                xem[thuTuCauHoi] = 2;   //Trả lời sai
                HieuUng(false);
                CSDL.SuaTu(listCauHoi[thuTuCauHoi].DapAn, tenBo[thuTuCauHoi], false, conn);
            }
            soCauDaTraLoi++;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            BackScene();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            NextScene();
        }

        void NextScene()
        {
            if (thuTuCauHoi < listCauHoi.Count - 1)
            {
                thuTuCauHoi++;
                Scene();
            }
            else
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
            
        }

        private void timerChuyenCanh_Tick(object sender, EventArgs e)
        {
            //MessageBox.Show(dem.ToString());
            if (dem == 9)
            {
                timerChuyenCanh.Stop();
                //MessageBox.Show("đã chạy xong");
                NextScene();
            }
            else
            {
                dem++;
            }
        }

        private void FormLtTracNghiem_KeyDown(object sender, KeyEventArgs e)
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

        void BackScene()
        {
            if (thuTuCauHoi > 0)
            {
                thuTuCauHoi--;
            }
            Scene();
        }

        int dem;
        void HieuUng(bool isTrue)
        {
            Scene();
            dem = 0;
            timerChuyenCanh.Start();
        }

    }
}

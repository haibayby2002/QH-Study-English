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
    public partial class FormThongKe : Form
    {
        public FormThongKe()
        {
            InitializeComponent();
        }

        public static int luaChon;  //1 là review, 2 là reload, 3 là home, 4 là exit
        public static int soCauDung, tongSoCau;


        private void FormThongKe_Load(object sender, EventArgs e)
        {
            lblTongSoCau.Text = "Tổng số câu: " + tongSoCau.ToString();
            lblSoCauDung.Text = "Số câu đúng: " + soCauDung.ToString();
            luaChon = 0;
        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            luaChon = 1;
            this.Close();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            luaChon = 2;
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            luaChon = 3;
            this.Close();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            luaChon = 4;
            this.Close();
        }

        
    }
}

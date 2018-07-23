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
using System.IO;

namespace Ver1._0
{
    public partial class ptbChe : Form
    {
        public ptbChe()
        {
            InitializeComponent();
        }

        SqlConnection conn;

        void LoadBoTu()
        {
            try
            {
                lvDanhSachBoTu.Items.Clear();
                cmbTenBo.Items.Clear();

                conn = new SqlConnection(TenChuoi.ketNoi);

                conn.Open();
                string query = @"select btv.TenBoTuVung, btv.GhiChu from BoTuVung btv where btv.TenBoTuVung != N'admin'";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader read = cmd.ExecuteReader();

                //Tên những bộ từ vựng
                while (read.Read())
                {
                    ListViewItem item = new ListViewItem(read["TenBoTuVung"].ToString());
                    item.SubItems.Add(XuLyDuLieu.ChuyenQuaGiaoDien(read["GhiChu"].ToString()));
                    //item.ImageList.Images = imgAnh.Images[0];

                    lvDanhSachBoTu.Items.Add(item);
                    lvDanhSachBoTu.Items[lvDanhSachBoTu.Items.Count - 1].ImageIndex = 0;

                    cmbTenBo.Items.Add(read["TenBoTuVung"].ToString());

                }

                btv = new BoTuVung();
            }
            catch (SqlException)
            {
                MessageBox.Show("Kết nối thất bại", "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbHienThi.SelectedIndex = 0;
            try
            {
                conn = new SqlConnection(TenChuoi.ketNoi);

                conn.Open();
                string query = @"select btv.TenBoTuVung, btv.GhiChu from BoTuVung btv where btv.TenBoTuVung != N'admin'";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader read = cmd.ExecuteReader();

                //Tên những bộ từ vựng
                while (read.Read())
                {
                    ListViewItem item = new ListViewItem(read["TenBoTuVung"].ToString());
                    item.SubItems.Add(XuLyDuLieu.ChuyenQuaGiaoDien(read["GhiChu"].ToString()));
                    //item.ImageList.Images = imgAnh.Images[0];

                    lvDanhSachBoTu.Items.Add(item);
                    lvDanhSachBoTu.Items[lvDanhSachBoTu.Items.Count - 1].ImageIndex = 0;

                    cmbTenBo.Items.Add(read["TenBoTuVung"].ToString());
                    
                }

                btv = new BoTuVung();
            }
            catch(SqlException)
            {
                MessageBox.Show("Kết nối thất bại", "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

           
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            tab.SelectedTab = tabTrangChu;
        }

        private void cmbHienThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(cmbHienThi.Text);
            if(cmbHienThi.Text == "Details")
            {
                lvDanhSachBoTu.View = View.Details;
            }
            else if (cmbHienThi.Text == "SmallIcon")
            {
                lvDanhSachBoTu.View = View.SmallIcon;
            }
            else if (cmbHienThi.Text == "Tiles")
            {
                lvDanhSachBoTu.View = View.Tile;
            }



        }

        static BoTuVung btv = new BoTuVung();
        internal static BoTuVung Btv { get => btv; set => btv = value; }
        internal static BoTuVung BoTuMo { get => boTuMo; set => boTuMo = value; }

        public void LoadLenTuCSDL()
        {
            try
            {
                //MessageBox.Show()
                conn = new SqlConnection(TenChuoi.ketNoi);
                conn.Open();

                //Truy vấn lấy chú thích
                string query = @"select btv.GhiChu 
                                from BoTuVung btv 
                                where btv.TenBoTuVung = N'" + cmbTenBo.Text + "'";

                SqlCommand cmd = new SqlCommand(query, conn);

                txtMoTaBo.Text = XuLyDuLieu.ChuyenQuaGiaoDien(cmd.ExecuteScalar().ToString());


                //Truy vấn lấy danh sách cách từ đổ vào class và listview
                string query2 = @"select tv.*
                                  from TuVung tv
                                  where tv.TenBoTuVung = N'" + cmbTenBo.Text + "'" + "order by TiLeTraLoiSai desc, SoLanLuyenTap asc, newid()";

                cmd = new SqlCommand(query2, conn);
                SqlDataReader read = cmd.ExecuteReader();





                btv = new BoTuVung(cmbTenBo.Text, txtMoTaBo.Text);  //New lại bộ mới

                lvDanhSachTu.Items.Clear();                 //Xóa hết các item cũ trong bộ từ vựng cũ


                while (read.Read())
                {
                    int LanLuyenTap = int.Parse(read["SoLanLuyenTap"].ToString());
                    int LanTraLoiSai = int.Parse(read["SoLanTraLoiSai"].ToString());
                    double TiLeSai = double.Parse(read["TiLeTraLoiSai"].ToString());
                    
                    //DateTime d = (DateTime)read["ThoiGianSaiCuoi"];

                    //Thêm vào class
                    TuVung tv = new TuVung(read["TenTuVung"].ToString(), XuLyDuLieu.ChuyenQuaGiaoDien(read["NghiaTuVung"].ToString()), LanLuyenTap, LanTraLoiSai);
                    btv.ListTuVung.Add(tv);
                    //MessageBox.Show(tv.TenTu + ":" + tv.NghiaTu + " pra " + tv.SoLanLuyenTap.ToString());

                    //Thêm vào listview       
                    ListViewItem item = new ListViewItem(tv.TenTu);
                    item.SubItems.Add(tv.NghiaTu);
                    item.SubItems.Add(tv.SoLanLuyenTap.ToString());

                    if (TiLeSai != 1006)
                    {
                        item.SubItems.Add(String.Format("{0:0.##}", TiLeSai * 100) + "%");
                    }
                    else
                    {
                        item.SubItems.Add("Chưa luyện tập");
                    }

                    lvDanhSachTu.Items.Add(item);
                }

                read.Close();   //Đóng cái đọc từng dòng

                chkAll.Checked = false;
            }
            catch (SqlException)
            {
                MessageBox.Show("Kết nối CSDL thất bại");
            }
            finally
            {
                conn.Close();
            }
        }

        private void cmbTenBo_SelectedIndexChanged(object sender, EventArgs e)
        {          
            LoadLenTuCSDL();
        }

        private void btnThemBo_Click(object sender, EventArgs e)
        {
            FormThemBo frmThemBo = new FormThemBo();
            frmThemBo.ShowDialog();

            if (FormThemBo.xacNhan) 
            {
                cmbTenBo.Items.Add(FormThemBo.ten);

                ListViewItem i = new ListViewItem(FormThemBo.ten);
                i.SubItems.Add(FormThemBo.moTa);
                i.ImageIndex = 0;

                lvDanhSachBoTu.Items.Add(i);
            }
        }

        private void btnXoaBoTu_Click(object sender, EventArgs e)
        {
            
            if (lvDanhSachBoTu.SelectedItems.Count == 0) 
            {
                MessageBox.Show("Vui lòng bộ chọn từ để xóa", "Lỗi chưa chọn phần tử", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string s = lvDanhSachBoTu.SelectedItems[0].Text;
                int thuTu = lvDanhSachBoTu.SelectedItems[0].Index;
                DialogResult dgr = MessageBox.Show("Bạn có chắc chắn muốn xóa bộ từ " + s + " không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dgr == DialogResult.Yes)
                {
                    //Xóa trong bảng Cơ sở dữ liệu trước nha

                    int n = CSDL.Change("Delete from BoTuVung where TenBoTuVung = N'" + s + "'");
                    
                    if (n == 1)
                    {
                        lvDanhSachBoTu.Items.RemoveAt(thuTu);
                        cmbTenBo.Items.RemoveAt(thuTu);
                        MessageBox.Show("Bạn đã xóa thành công bộ " + s + "!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }                   
                }                
            }
        }

        public static ComboBox dsBoTu = new ComboBox();
        public static int viTriSua;
        private void btnSuaBoTu_Click(object sender, EventArgs e)
        {
            if (lvDanhSachBoTu.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng bộ chọn từ để sửa", "Lỗi chưa chọn phần tử", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dsBoTu.Items.Clear();
                for (int i = 0; i < lvDanhSachBoTu.Items.Count; i++) 
                {
                    dsBoTu.Items.Add(lvDanhSachBoTu.Items[i].Text);
                }

                viTriSua = lvDanhSachBoTu.SelectedItems[0].Index;

                FormSuaBo frmSua = new FormSuaBo();
                frmSua.ShowDialog();

                if (FormSuaBo.checkSua)
                {
                    lvDanhSachBoTu.Items[viTriSua].Text = FormSuaBo.boMoi;
                    lvDanhSachBoTu.Items[viTriSua].SubItems[1].Text = FormSuaBo.moTaMoi;
                    cmbTenBo.Items[viTriSua] = FormSuaBo.boMoi;
                }
            }
        }

        private void lvDanhSachBoTu_DoubleClick(object sender, EventArgs e)
        {
            string chon = lvDanhSachBoTu.SelectedItems[0].Text;
            tab.SelectedTab = tabTuVung;
            cmbTenBo.Text = chon;            
        }

        public static int viTriBoThem;
        private void btnThem_Click(object sender, EventArgs e)
        {
            if(cmbTenBo.Text == "Chọn tên bộ")
            {
                MessageBox.Show("Vui lòng chọn tên bộ từ cần thêm", "Lỗi chưa chọn phần tử", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                FormThemTuVung frmThemTu = new FormThemTuVung();
                dsBoTu = cmbTenBo;
                viTriBoThem = cmbTenBo.SelectedIndex;
                frmThemTu.ShowDialog();

                if (FormThemTuVung.checkThem)
                {
                    //Thêm vào class
                    TuVung temp = new TuVung(FormThemTuVung.tuCanThem, FormThemTuVung.nghiaTuCanThem);
                    btv.ListTuVung.Insert(0, temp);

                    //Thêm vào listview
                    ListViewItem item = new ListViewItem(temp.TenTu);
                    item.SubItems.Add(temp.NghiaTu);
                    item.SubItems.Add(temp.SoLanLuyenTap.ToString());

                    if (temp.TinhTiLeSai() != 1006)
                    {
                        item.SubItems.Add((temp.TinhTiLeSai() * 100).ToString("0.0") + "%");
                    }
                    else
                    {
                        item.SubItems.Add("Chưa luyện tập");
                    }

                    lvDanhSachTu.Items.Insert(0, item);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int dem = 0;

            if(lvDanhSachTu.CheckedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn từ để xóa", "Lỗi chưa chọn phần tử", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                DialogResult dlr = MessageBox.Show("Bạn có chắc chắn muốn xóa " + lvDanhSachTu.CheckedItems.Count + " từ được chọn không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //Làm ở đây
                if(dlr == DialogResult.Yes)
                {
                    //Mở kết nối CDSL
                    SqlConnection cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=HocTiengAnh;Integrated Security=True");
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = cn;
                    if (cn.State == ConnectionState.Closed)
                    {
                        cn.Open();
                    }
                    foreach (ListViewItem item in lvDanhSachTu.Items)
                    {

                        if (item.Checked)
                        {
                            //Xóa trong class trước
                            //MessageBox.Show(item.Text);
                            btv.XoaTu(item.Text);


                            //Tiếp theo là CSDL
                            cmd = new SqlCommand(@"delete from TuVung where TenTuVung = '" + item.Text + "' and TenBoTuVung = N'" + cmbTenBo.Text + "'", cn);

                            //Xóa trong ListView
                            lvDanhSachTu.Items.Remove(item);

                            dem += cmd.ExecuteNonQuery();

                            //----------------------------------------------------
                        }
                    }
                    //Đóng kết nối
                    cn.Close();

                    //Thông báo
                    MessageBox.Show("Đã xóa thành công " + dem.ToString() + " từ trong bộ " + cmbTenBo.Text, "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    chkAll.Checked = false;
                }
            }                  
        }

        

        private void lvDanhSachTu_DoubleClick(object sender, EventArgs e)
        {
            btnSua_Click(sender, e);
        }

        public static bool luyenTapHet;
        public static bool camChon;
        public static string []tenBo;
        private void btnPractice_Click(object sender, EventArgs e)
        {
            camChon = false;
            if(lvDanhSachTu.Items.Count == 0)
            {
                MessageBox.Show("Không tìm thấy từ trong danh sách để luyện tập, xin kiểm tra lại", "Lỗi chưa có phần tử", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (lvDanhSachTu.CheckedItems.Count != 0)
                {
                    luyenTapHet = false;
                }
                else
                {
                    luyenTapHet = true;
                    camChon = true;
                }

                FormHinhThucLuyenTap frmHinhThucLuyenTap = new FormHinhThucLuyenTap();
                frmHinhThucLuyenTap.ShowDialog();

                //-------------------------------------------------------------
                if(FormHinhThucLuyenTap.xacNhan)    //nếu người dùng ấn nút xác nhận
                {
                    if (!FormHinhThucLuyenTap.luyenTapHet)    //Trường hợp không luyện tập hết mà luyện tập theo từ chọn thì class sẽ đổi theo  
                    {
                        for (int i = lvDanhSachTu.Items.Count - 1; i >= 0; i--)
                        {
                            if(!lvDanhSachTu.Items[i].Checked)  //Nếu không được chọn
                            {
                                btv.ListTuVung.RemoveAt(i);
                            }
                        }
                    }

                    //Tên bộ cho từng từ vựng
                    tenBo = new string[btv.ListTuVung.Count];
                    for (int i = 0; i < btv.ListTuVung.Count; i++)
                    {
                        tenBo[i] = cmbTenBo.Text;
                    }

                    //Xét loại hình thức luyện tập
                    if (FormHinhThucLuyenTap.hinhThuc == 2)     //Luyện tập tự luận
                    {
                        LuyenTapTuLuan:
                        FormLtTuLuan frmLt = new FormLtTuLuan();
                        this.Visible = false;
                        frmLt.ShowDialog();
                        this.Visible = true;

                        //if (FormLtTuLuan.menu)  //Trở về menu <=> reload lại form
                        //{
                        //    this.OnLoad(e);
                        //}

                        //Có thể là luyện tập lại
                        if(FormThongKe.luaChon == 1)
                        {
                            LoadLenTuCSDL();
                        }
                        else if (FormThongKe.luaChon == 2)
                        {
                            FormThongKe.luaChon = 0;
                            goto LuyenTapTuLuan;
                        }
                        else if (FormThongKe.luaChon == 3)
                        {
                            frmLt.Close();
                            LoadLenTuCSDL();
                            tab.SelectedTab = tabTrangChu;
                        }
                        else if (FormThongKe.luaChon == 4)
                        {
                            frmLt.Close();
                            LoadLenTuCSDL();
                        }

                        //Luyện tập xong thì load lại CSDL


                        chkAll.Checked = false;
                        LoadLenTuCSDL();
                    }
                    else if(FormHinhThucLuyenTap.hinhThuc == 1)         //Trắc nghiệm
                    {
                        LuyenTapTracNghiem:
                        FormLtTracNghiem frmLt = new FormLtTracNghiem();
                        this.Visible = false;
                        frmLt.ShowDialog();
                        this.Visible = true;

                        //Có thể là luyện tập lại
                        if (FormThongKe.luaChon == 1)
                        {
                            LoadLenTuCSDL();
                        }
                        else if (FormThongKe.luaChon == 2)
                        {
                            FormThongKe.luaChon = 0;
                            goto LuyenTapTracNghiem;
                        }
                        else if (FormThongKe.luaChon == 3)
                        {
                            frmLt.Close();
                            LoadLenTuCSDL();
                            tab.SelectedTab = tabTrangChu;
                        }
                        else if (FormThongKe.luaChon == 4)
                        {
                            frmLt.Close();
                            LoadLenTuCSDL();
                        }

                        //Luyện tập xong thì load lại CSDL


                        chkAll.Checked = false;
                        LoadLenTuCSDL();

                        chkAll.Checked = false;
                        LoadLenTuCSDL();
                    }




                }

            }          
        }

        private void chkAll_CheckedChanged(object sender, EventArgs e)
        {
            if (lvDanhSachTu.Items.Count == 0) 
            {
                chkAll.Checked = false;
            }
            else
            {
                foreach (ListViewItem item in lvDanhSachTu.Items)
                {
                    item.Checked = chkAll.Checked;
                }
            }
        }


        private static BoTuVung boTuMo = new BoTuVung();
        private void btnMoTuVung_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                
                StreamReader r = new StreamReader(openFileDialog1.FileName);               
                int check;
                if (r.ReadLine() == "@QH Study")
                {
                    check = int.Parse(r.ReadLine());    //Kiểm tra xem có ghi lại lần luyện tập hay không.
                    if(check == 0)  //Không trùng
                    {
                        try
                        {
                            FormMoBoTu frmMo = new FormMoBoTu();
                            FormMoBoTu.moTa = "";

                            string tenBo = "";
                            int i = openFileDialog1.FileName.Length - 1;
                            while (openFileDialog1.FileName[i] != '\\' && i >= 0)
                            {
                                tenBo = openFileDialog1.FileName[i] + tenBo;
                                i--;
                            }
                            
                            if(tenBo.Substring(tenBo.Length - 4, 4) == ".txt")
                            {
                                FormMoBoTu.tenBoTu = tenBo.Remove(tenBo.Length - 4);
                            }
                            else
                            {
                                FormMoBoTu.tenBoTu = tenBo;
                            }

                            //Đọc mô tả và dòng mô tả
                            string dongMoTa;
                            string moTa = "";
                            do
                            {
                                dongMoTa = r.ReadLine();
                                if(dongMoTa[dongMoTa.Length - 1] != '|')
                                {
                                    moTa += dongMoTa + @"
";
                                }
                                else
                                {
                                    moTa += dongMoTa.Substring(0, dongMoTa.Length - 1);
                                }
                            }
                            while (dongMoTa[dongMoTa.Length - 1] != '|');
                            moTa.Remove(moTa.Length - 5, 4);
                            FormMoBoTu.moTa = moTa;

                            //Giờ là đến lượt từ vựng
                            //Trước tiên là từ vựng
                            string tv, nghia, temp;
                            boTuMo.ListTuVung = new List<TuVung>();
                            while (!r.EndOfStream)
                            {
                                tv = nghia = "";    //Khởi tạo mặc định
                                //Cắt từ vựng và nghĩa ở đầu
                                temp = r.ReadLine();
                                int idx = 0;
                                while(temp[idx] != ':')
                                {
                                    tv += temp[idx];
                                    idx++;
                                }
                                nghia = temp.Substring(idx + 1);

                                while(temp[temp.Length - 1] != '~')
                                {
                                    temp = r.ReadLine();
                                    nghia += @"
" + temp;
                                }

                                //MessageBox.Show(tv + ": " + nghia);

                                TuVung tuVung = new TuVung(tv, nghia.Remove(nghia.Length - 1));
                                boTuMo.ListTuVung.Add(tuVung);
                                
                            }
                            

                            frmMo.ShowDialog();
                            if (FormMoBoTu.xacNhan)
                            {
                                //Thêm vào listview và thêm vào class
                                LoadBoTu();
                            }
                        }
                        catch(FileLoadException)
                        {
                            MessageBox.Show("Tập tin này không do tự tạo hoặc đã bị chỉnh sửa. Xin vui lòng chọn tập tin khác", "Lỗi tập tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }                 
                }
                else
                {
                    MessageBox.Show("Tập tin này không do tự tạo hoặc đã bị chỉnh sửa. Xin vui lòng chọn tập tin khác", "Lỗi tập tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                r.Close();
                boTuMo.ListTuVung.Clear();
            }
        }

        public static string tuCanSua, nghiaTuMoi, suaTrongBo;

        private void btnHocTu_Click(object sender, EventArgs e)
        {
            if (lvDanhSachTu.CheckedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn từ vựng để học", "Lỗi chưa có phần tử", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                for (int i = lvDanhSachTu.Items.Count - 1; i >= 0; i--)
                {
                    if (!lvDanhSachTu.Items[i].Checked)  //Nếu không được chọn
                    {
                        btv.ListTuVung.RemoveAt(i);
                    }
                }

                FormHocTap frmHocTap = new FormHocTap();
                frmHocTap.ShowDialog();

                LoadLenTuCSDL();
            }
        }

        private void btnLuuTuVung_Click(object sender, EventArgs e)
        {
            if (lvDanhSachTu.CheckedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn từ cần lưu lại", "Lỗi chưa chọn phần tử", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                saveFileDialog1.FileName = cmbTenBo.Text;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Lưu thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    StreamWriter w = new StreamWriter(saveFileDialog1.FileName);

                    w.WriteLine("@QH Study");
                    w.WriteLine("0");

                    w.Write(txtMoTaBo.Text + "|");

                    foreach (ListViewItem i in lvDanhSachTu.Items)
                    {
                        if (i.Checked)
                        {
                            w.WriteLine();
                            w.Write(i.Text + ":" + btv.ListTuVung[i.Index].NghiaTu + "~");
                        }
                    }


                    w.Close();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lvDanhSachTu.SelectedItems.Count == 0) 
            {
                MessageBox.Show("Vui lòng chọn từ vựng cần sửa", "Lỗi chưa chọn phần tử", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(lvDanhSachTu.SelectedItems.Count != 1)
            {
                MessageBox.Show("Vui lòng chỉ chọn 1 từ vựng để sửa", "Lỗi chọn nhiều phần tử", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else    //Số phần tử bằng 1
            {
                tuCanSua = btv.ListTuVung[lvDanhSachTu.SelectedItems[0].Index].TenTu;
                nghiaTuMoi = btv.ListTuVung[lvDanhSachTu.SelectedItems[0].Index].NghiaTu;
                suaTrongBo = cmbTenBo.Text;

                FormSuaTuVung frmSuaTu = new FormSuaTuVung();
                frmSuaTu.ShowDialog();

                if(FormSuaTuVung.checkSua)  //Sửa thành công
                {
                    //Sửa trên listview
                    lvDanhSachTu.Items[lvDanhSachTu.SelectedItems[0].Index].SubItems[1].Text = FormSuaTuVung.nghiaTuMoi;

                    //Sửa trên class
                    btv.SuaTu(lvDanhSachTu.Items[lvDanhSachTu.SelectedItems[0].Index].Text, FormSuaTuVung.nghiaTuMoi);
                }
            }
        }
    }
}

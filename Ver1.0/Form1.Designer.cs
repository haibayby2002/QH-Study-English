using System;

namespace Ver1._0
{
    partial class ptbChe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Bộ từ đề xuất",
            "Chứa những từ trong từ điển phần mềm muốn gợi ý cho bạn"}, 0);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Bộ từ nên tập của bạn",
            "Chứa những từ cần luyện tập của bạn để cải thiện và nâng cao kĩ năng"}, 0);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "Bộ từ ngẫu nhiên",
            "Phát sinh ngẫu nhiên những từ để bạn luyện tập"}, 0);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ptbChe));
            this.tab = new System.Windows.Forms.TabControl();
            this.tabTrangChu = new System.Windows.Forms.TabPage();
            this.lvBoTuNenTap = new System.Windows.Forms.ListView();
            this.tenBoNenTap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.moTaBoNenTap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imgAnhLon = new System.Windows.Forms.ImageList(this.components);
            this.imgAnh = new System.Windows.Forms.ImageList(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMoBoTu = new System.Windows.Forms.Button();
            this.btnSuaBoTu = new System.Windows.Forms.Button();
            this.btnXoaBoTu = new System.Windows.Forms.Button();
            this.btnThemBoTu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbHienThi = new System.Windows.Forms.ComboBox();
            this.lvDanhSachBoTu = new System.Windows.Forms.ListView();
            this.TenBoTu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MoTa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabTuVung = new System.Windows.Forms.TabPage();
            this.lvDanhSachTu = new System.Windows.Forms.ListView();
            this.TenTu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NghiaTu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NPractice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NTiLe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnHocTu = new System.Windows.Forms.Button();
            this.btnLuyenTap = new System.Windows.Forms.Button();
            this.chkAll = new System.Windows.Forms.CheckBox();
            this.grbBoTuVung = new System.Windows.Forms.GroupBox();
            this.txtMoTaBo = new System.Windows.Forms.TextBox();
            this.cmbTenBo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnMoTuVung = new System.Windows.Forms.Button();
            this.btnLuuTuVung = new System.Windows.Forms.Button();
            this.btnChuyenTiep = new System.Windows.Forms.Button();
            this.btnTrangChu = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnInTuVung = new System.Windows.Forms.Button();
            this.tab.SuspendLayout();
            this.tabTrangChu.SuspendLayout();
            this.tabTuVung.SuspendLayout();
            this.grbBoTuVung.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab
            // 
            this.tab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab.Controls.Add(this.tabTrangChu);
            this.tab.Controls.Add(this.tabTuVung);
            this.tab.Location = new System.Drawing.Point(13, 84);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(983, 484);
            this.tab.TabIndex = 2;
            // 
            // tabTrangChu
            // 
            this.tabTrangChu.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tabTrangChu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabTrangChu.Controls.Add(this.lvBoTuNenTap);
            this.tabTrangChu.Controls.Add(this.label5);
            this.tabTrangChu.Controls.Add(this.label4);
            this.tabTrangChu.Controls.Add(this.btnMoBoTu);
            this.tabTrangChu.Controls.Add(this.btnSuaBoTu);
            this.tabTrangChu.Controls.Add(this.btnXoaBoTu);
            this.tabTrangChu.Controls.Add(this.btnThemBoTu);
            this.tabTrangChu.Controls.Add(this.label3);
            this.tabTrangChu.Controls.Add(this.cmbHienThi);
            this.tabTrangChu.Controls.Add(this.lvDanhSachBoTu);
            this.tabTrangChu.Location = new System.Drawing.Point(4, 28);
            this.tabTrangChu.Name = "tabTrangChu";
            this.tabTrangChu.Padding = new System.Windows.Forms.Padding(3);
            this.tabTrangChu.Size = new System.Drawing.Size(975, 452);
            this.tabTrangChu.TabIndex = 0;
            this.tabTrangChu.Text = "Trang Chủ";
            // 
            // lvBoTuNenTap
            // 
            this.lvBoTuNenTap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvBoTuNenTap.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.tenBoNenTap,
            this.moTaBoNenTap});
            this.lvBoTuNenTap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            listViewItem1.ToolTipText = "Chứa những từ trong từ điển phần mềm muốn gợi ý cho bạn";
            listViewItem2.ToolTipText = "Chứa những từ cần luyện tập của bạn để cải thiện và nâng cao kĩ năng";
            listViewItem3.ToolTipText = "Phát sinh ngẫu nhiên những từ để bạn luyện tập";
            this.lvBoTuNenTap.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.lvBoTuNenTap.LargeImageList = this.imgAnhLon;
            this.lvBoTuNenTap.Location = new System.Drawing.Point(7, 315);
            this.lvBoTuNenTap.Name = "lvBoTuNenTap";
            this.lvBoTuNenTap.ShowItemToolTips = true;
            this.lvBoTuNenTap.Size = new System.Drawing.Size(958, 127);
            this.lvBoTuNenTap.SmallImageList = this.imgAnh;
            this.lvBoTuNenTap.TabIndex = 6;
            this.lvBoTuNenTap.UseCompatibleStateImageBehavior = false;
            this.lvBoTuNenTap.View = System.Windows.Forms.View.Tile;
            // 
            // tenBoNenTap
            // 
            this.tenBoNenTap.Text = "Tên bộ";
            this.tenBoNenTap.Width = 200;
            // 
            // moTaBoNenTap
            // 
            this.moTaBoNenTap.Text = "Mô tả";
            this.moTaBoNenTap.Width = 550;
            // 
            // imgAnhLon
            // 
            this.imgAnhLon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgAnhLon.ImageStream")));
            this.imgAnhLon.TransparentColor = System.Drawing.Color.Transparent;
            this.imgAnhLon.Images.SetKeyName(0, "English Image icon.png");
            this.imgAnhLon.Images.SetKeyName(1, "Button Add-01.ico");
            this.imgAnhLon.Images.SetKeyName(2, "delete button.jpg");
            this.imgAnhLon.Images.SetKeyName(3, "edit button.ico");
            this.imgAnhLon.Images.SetKeyName(4, "forward change button.png");
            this.imgAnhLon.Images.SetKeyName(5, "check button.png");
            this.imgAnhLon.Images.SetKeyName(6, "mutiple check button.png");
            // 
            // imgAnh
            // 
            this.imgAnh.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgAnh.ImageStream")));
            this.imgAnh.TransparentColor = System.Drawing.Color.Transparent;
            this.imgAnh.Images.SetKeyName(0, "English Image icon.png");
            this.imgAnh.Images.SetKeyName(1, "Button Add-01.ico");
            this.imgAnh.Images.SetKeyName(2, "delete button.jpg");
            this.imgAnh.Images.SetKeyName(3, "edit button.ico");
            this.imgAnh.Images.SetKeyName(4, "forward change button.png");
            this.imgAnh.Images.SetKeyName(5, "check button.png");
            this.imgAnh.Images.SetKeyName(6, "mutiple check button.png");
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(288, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(404, 31);
            this.label5.TabIndex = 5;
            this.label5.Text = "Bộ từ nên tập (Phát sinh tự động)";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(398, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 31);
            this.label4.TabIndex = 4;
            this.label4.Text = "Bộ từ của bạn";
            // 
            // btnMoBoTu
            // 
            this.btnMoBoTu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMoBoTu.BackgroundImage = global::Ver1._0.Properties.Resources.open;
            this.btnMoBoTu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMoBoTu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMoBoTu.Location = new System.Drawing.Point(916, 17);
            this.btnMoBoTu.Name = "btnMoBoTu";
            this.btnMoBoTu.Size = new System.Drawing.Size(39, 39);
            this.btnMoBoTu.TabIndex = 3;
            this.btnMoBoTu.UseVisualStyleBackColor = true;
            this.btnMoBoTu.Click += new System.EventHandler(this.btnMoTuVung_Click);
            // 
            // btnSuaBoTu
            // 
            this.btnSuaBoTu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSuaBoTu.BackgroundImage = global::Ver1._0.Properties.Resources.edit_button;
            this.btnSuaBoTu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSuaBoTu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSuaBoTu.Location = new System.Drawing.Point(871, 17);
            this.btnSuaBoTu.Name = "btnSuaBoTu";
            this.btnSuaBoTu.Size = new System.Drawing.Size(39, 39);
            this.btnSuaBoTu.TabIndex = 0;
            this.btnSuaBoTu.UseVisualStyleBackColor = true;
            this.btnSuaBoTu.Click += new System.EventHandler(this.btnSuaBoTu_Click);
            // 
            // btnXoaBoTu
            // 
            this.btnXoaBoTu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaBoTu.BackgroundImage = global::Ver1._0.Properties.Resources.delete_icon_2;
            this.btnXoaBoTu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoaBoTu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoaBoTu.Location = new System.Drawing.Point(826, 17);
            this.btnXoaBoTu.Name = "btnXoaBoTu";
            this.btnXoaBoTu.Size = new System.Drawing.Size(39, 39);
            this.btnXoaBoTu.TabIndex = 0;
            this.btnXoaBoTu.UseVisualStyleBackColor = true;
            this.btnXoaBoTu.Click += new System.EventHandler(this.btnXoaBoTu_Click);
            // 
            // btnThemBoTu
            // 
            this.btnThemBoTu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemBoTu.BackgroundImage = global::Ver1._0.Properties.Resources.Button_Add_01;
            this.btnThemBoTu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnThemBoTu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThemBoTu.Location = new System.Drawing.Point(781, 17);
            this.btnThemBoTu.Name = "btnThemBoTu";
            this.btnThemBoTu.Size = new System.Drawing.Size(39, 39);
            this.btnThemBoTu.TabIndex = 0;
            this.btnThemBoTu.UseVisualStyleBackColor = true;
            this.btnThemBoTu.Click += new System.EventHandler(this.btnThemBo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hiển thị";
            // 
            // cmbHienThi
            // 
            this.cmbHienThi.FormattingEnabled = true;
            this.cmbHienThi.Items.AddRange(new object[] {
            "SmallIcon",
            "Details",
            "Tiles"});
            this.cmbHienThi.Location = new System.Drawing.Point(71, 29);
            this.cmbHienThi.Name = "cmbHienThi";
            this.cmbHienThi.Size = new System.Drawing.Size(182, 27);
            this.cmbHienThi.TabIndex = 1;
            this.cmbHienThi.Text = "Hiển thị";
            this.cmbHienThi.SelectedIndexChanged += new System.EventHandler(this.cmbHienThi_SelectedIndexChanged);
            // 
            // lvDanhSachBoTu
            // 
            this.lvDanhSachBoTu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvDanhSachBoTu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TenBoTu,
            this.MoTa});
            this.lvDanhSachBoTu.FullRowSelect = true;
            this.lvDanhSachBoTu.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvDanhSachBoTu.LargeImageList = this.imgAnhLon;
            this.lvDanhSachBoTu.Location = new System.Drawing.Point(7, 62);
            this.lvDanhSachBoTu.MultiSelect = false;
            this.lvDanhSachBoTu.Name = "lvDanhSachBoTu";
            this.lvDanhSachBoTu.Size = new System.Drawing.Size(958, 206);
            this.lvDanhSachBoTu.SmallImageList = this.imgAnh;
            this.lvDanhSachBoTu.TabIndex = 0;
            this.lvDanhSachBoTu.UseCompatibleStateImageBehavior = false;
            this.lvDanhSachBoTu.View = System.Windows.Forms.View.Details;
            this.lvDanhSachBoTu.DoubleClick += new System.EventHandler(this.lvDanhSachBoTu_DoubleClick);
            // 
            // TenBoTu
            // 
            this.TenBoTu.Text = "Tên bộ từ vựng";
            this.TenBoTu.Width = 200;
            // 
            // MoTa
            // 
            this.MoTa.Text = "Mô tả";
            this.MoTa.Width = 450;
            // 
            // tabTuVung
            // 
            this.tabTuVung.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tabTuVung.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabTuVung.Controls.Add(this.btnInTuVung);
            this.tabTuVung.Controls.Add(this.lvDanhSachTu);
            this.tabTuVung.Controls.Add(this.btnHocTu);
            this.tabTuVung.Controls.Add(this.btnLuyenTap);
            this.tabTuVung.Controls.Add(this.chkAll);
            this.tabTuVung.Controls.Add(this.grbBoTuVung);
            this.tabTuVung.Controls.Add(this.flowLayoutPanel1);
            this.tabTuVung.Location = new System.Drawing.Point(4, 28);
            this.tabTuVung.Name = "tabTuVung";
            this.tabTuVung.Padding = new System.Windows.Forms.Padding(3);
            this.tabTuVung.Size = new System.Drawing.Size(975, 452);
            this.tabTuVung.TabIndex = 1;
            this.tabTuVung.Text = "Từ Vựng";
            // 
            // lvDanhSachTu
            // 
            this.lvDanhSachTu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvDanhSachTu.CheckBoxes = true;
            this.lvDanhSachTu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TenTu,
            this.NghiaTu,
            this.NPractice,
            this.NTiLe});
            this.lvDanhSachTu.FullRowSelect = true;
            this.lvDanhSachTu.GridLines = true;
            this.lvDanhSachTu.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvDanhSachTu.Location = new System.Drawing.Point(6, 146);
            this.lvDanhSachTu.MultiSelect = false;
            this.lvDanhSachTu.Name = "lvDanhSachTu";
            this.lvDanhSachTu.Size = new System.Drawing.Size(956, 293);
            this.lvDanhSachTu.TabIndex = 0;
            this.lvDanhSachTu.UseCompatibleStateImageBehavior = false;
            this.lvDanhSachTu.View = System.Windows.Forms.View.Details;
            this.lvDanhSachTu.DoubleClick += new System.EventHandler(this.lvDanhSachTu_DoubleClick);
            // 
            // TenTu
            // 
            this.TenTu.Text = "Tên từ";
            this.TenTu.Width = 200;
            // 
            // NghiaTu
            // 
            this.NghiaTu.Text = "Nghĩa từ";
            this.NghiaTu.Width = 450;
            // 
            // NPractice
            // 
            this.NPractice.Text = "Lần luyện tập";
            this.NPractice.Width = 120;
            // 
            // NTiLe
            // 
            this.NTiLe.Text = "Tỉ lệ trả lời sai";
            this.NTiLe.Width = 120;
            // 
            // btnHocTu
            // 
            this.btnHocTu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHocTu.Location = new System.Drawing.Point(430, 100);
            this.btnHocTu.Name = "btnHocTu";
            this.btnHocTu.Size = new System.Drawing.Size(106, 40);
            this.btnHocTu.TabIndex = 5;
            this.btnHocTu.Text = "Học từ vựng";
            this.btnHocTu.UseVisualStyleBackColor = true;
            this.btnHocTu.Click += new System.EventHandler(this.btnHocTu_Click);
            // 
            // btnLuyenTap
            // 
            this.btnLuyenTap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuyenTap.Location = new System.Drawing.Point(542, 100);
            this.btnLuyenTap.Name = "btnLuyenTap";
            this.btnLuyenTap.Size = new System.Drawing.Size(106, 40);
            this.btnLuyenTap.TabIndex = 4;
            this.btnLuyenTap.Text = "Luyện tập";
            this.btnLuyenTap.UseVisualStyleBackColor = true;
            this.btnLuyenTap.Click += new System.EventHandler(this.btnPractice_Click);
            // 
            // chkAll
            // 
            this.chkAll.AutoSize = true;
            this.chkAll.Location = new System.Drawing.Point(12, 126);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(15, 14);
            this.chkAll.TabIndex = 3;
            this.chkAll.UseVisualStyleBackColor = true;
            this.chkAll.CheckedChanged += new System.EventHandler(this.chkAll_CheckedChanged);
            // 
            // grbBoTuVung
            // 
            this.grbBoTuVung.Controls.Add(this.txtMoTaBo);
            this.grbBoTuVung.Controls.Add(this.cmbTenBo);
            this.grbBoTuVung.Controls.Add(this.label2);
            this.grbBoTuVung.Controls.Add(this.label1);
            this.grbBoTuVung.Dock = System.Windows.Forms.DockStyle.Right;
            this.grbBoTuVung.Location = new System.Drawing.Point(654, 3);
            this.grbBoTuVung.Name = "grbBoTuVung";
            this.grbBoTuVung.Size = new System.Drawing.Size(314, 442);
            this.grbBoTuVung.TabIndex = 2;
            this.grbBoTuVung.TabStop = false;
            this.grbBoTuVung.Text = "Bộ từ vựng";
            // 
            // txtMoTaBo
            // 
            this.txtMoTaBo.Location = new System.Drawing.Point(74, 60);
            this.txtMoTaBo.Multiline = true;
            this.txtMoTaBo.Name = "txtMoTaBo";
            this.txtMoTaBo.ReadOnly = true;
            this.txtMoTaBo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMoTaBo.Size = new System.Drawing.Size(234, 68);
            this.txtMoTaBo.TabIndex = 2;
            // 
            // cmbTenBo
            // 
            this.cmbTenBo.FormattingEnabled = true;
            this.cmbTenBo.Location = new System.Drawing.Point(74, 26);
            this.cmbTenBo.Name = "cmbTenBo";
            this.cmbTenBo.Size = new System.Drawing.Size(234, 27);
            this.cmbTenBo.TabIndex = 1;
            this.cmbTenBo.Text = "Chọn tên bộ";
            this.cmbTenBo.SelectedIndexChanged += new System.EventHandler(this.cmbTenBo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mô tả";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên bộ";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.btnThem);
            this.flowLayoutPanel1.Controls.Add(this.btnXoa);
            this.flowLayoutPanel1.Controls.Add(this.btnSua);
            this.flowLayoutPanel1.Controls.Add(this.btnMoTuVung);
            this.flowLayoutPanel1.Controls.Add(this.btnLuuTuVung);
            this.flowLayoutPanel1.Controls.Add(this.btnChuyenTiep);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(39, 95);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(231, 45);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btnThem
            // 
            this.btnThem.BackgroundImage = global::Ver1._0.Properties.Resources.Button_Add_01;
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThem.Location = new System.Drawing.Point(3, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(40, 40);
            this.btnThem.TabIndex = 0;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackgroundImage = global::Ver1._0.Properties.Resources.delete_icon_2;
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoa.Location = new System.Drawing.Point(49, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(40, 40);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackgroundImage = global::Ver1._0.Properties.Resources.edit_button;
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSua.Location = new System.Drawing.Point(95, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(40, 40);
            this.btnSua.TabIndex = 2;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnMoTuVung
            // 
            this.btnMoTuVung.BackgroundImage = global::Ver1._0.Properties.Resources.open;
            this.btnMoTuVung.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMoTuVung.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMoTuVung.Location = new System.Drawing.Point(141, 3);
            this.btnMoTuVung.Name = "btnMoTuVung";
            this.btnMoTuVung.Size = new System.Drawing.Size(39, 39);
            this.btnMoTuVung.TabIndex = 5;
            this.btnMoTuVung.UseVisualStyleBackColor = true;
            this.btnMoTuVung.Click += new System.EventHandler(this.btnMoTuVung_Click);
            // 
            // btnLuuTuVung
            // 
            this.btnLuuTuVung.BackColor = System.Drawing.SystemColors.Control;
            this.btnLuuTuVung.BackgroundImage = global::Ver1._0.Properties.Resources.save_button;
            this.btnLuuTuVung.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLuuTuVung.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLuuTuVung.Location = new System.Drawing.Point(186, 3);
            this.btnLuuTuVung.Name = "btnLuuTuVung";
            this.btnLuuTuVung.Size = new System.Drawing.Size(39, 39);
            this.btnLuuTuVung.TabIndex = 4;
            this.btnLuuTuVung.UseVisualStyleBackColor = false;
            this.btnLuuTuVung.Click += new System.EventHandler(this.btnLuuTuVung_Click);
            // 
            // btnChuyenTiep
            // 
            this.btnChuyenTiep.BackgroundImage = global::Ver1._0.Properties.Resources.forward_change_button;
            this.btnChuyenTiep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChuyenTiep.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChuyenTiep.Location = new System.Drawing.Point(3, 49);
            this.btnChuyenTiep.Name = "btnChuyenTiep";
            this.btnChuyenTiep.Size = new System.Drawing.Size(40, 40);
            this.btnChuyenTiep.TabIndex = 3;
            this.btnChuyenTiep.UseVisualStyleBackColor = true;
            // 
            // btnTrangChu
            // 
            this.btnTrangChu.BackgroundImage = global::Ver1._0.Properties.Resources.button_home1;
            this.btnTrangChu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTrangChu.FlatAppearance.BorderSize = 0;
            this.btnTrangChu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTrangChu.Location = new System.Drawing.Point(17, 7);
            this.btnTrangChu.Margin = new System.Windows.Forms.Padding(4);
            this.btnTrangChu.Name = "btnTrangChu";
            this.btnTrangChu.Size = new System.Drawing.Size(70, 70);
            this.btnTrangChu.TabIndex = 1;
            this.btnTrangChu.UseVisualStyleBackColor = true;
            this.btnTrangChu.Click += new System.EventHandler(this.btnTrangChu_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "(*.txt)|*.txt";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "(*.txt)|*.txt";
            // 
            // btnInTuVung
            // 
            this.btnInTuVung.Location = new System.Drawing.Point(430, 53);
            this.btnInTuVung.Name = "btnInTuVung";
            this.btnInTuVung.Size = new System.Drawing.Size(106, 41);
            this.btnInTuVung.TabIndex = 3;
            this.btnInTuVung.Text = "In Từ Vựng";
            this.btnInTuVung.UseVisualStyleBackColor = true;
            this.btnInTuVung.Click += new System.EventHandler(this.btnInTuVung_Click);
            // 
            // ptbChe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(1008, 580);
            this.Controls.Add(this.btnTrangChu);
            this.Controls.Add(this.tab);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ptbChe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QH Study English";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tab.ResumeLayout(false);
            this.tabTrangChu.ResumeLayout(false);
            this.tabTrangChu.PerformLayout();
            this.tabTuVung.ResumeLayout(false);
            this.tabTuVung.PerformLayout();
            this.grbBoTuVung.ResumeLayout(false);
            this.grbBoTuVung.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        

        #endregion
        private System.Windows.Forms.Button btnTrangChu;
        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tabTrangChu;
        private System.Windows.Forms.TabPage tabTuVung;
        private System.Windows.Forms.ListView lvDanhSachBoTu;
        private System.Windows.Forms.ColumnHeader TenBoTu;
        private System.Windows.Forms.ComboBox cmbHienThi;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ListView lvDanhSachTu;
        private System.Windows.Forms.ColumnHeader TenTu;
        private System.Windows.Forms.ColumnHeader NghiaTu;
        private System.Windows.Forms.ColumnHeader NPractice;
        private System.Windows.Forms.ColumnHeader NTiLe;
        private System.Windows.Forms.GroupBox grbBoTuVung;
        private System.Windows.Forms.TextBox txtMoTaBo;
        private System.Windows.Forms.ComboBox cmbTenBo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imgAnh;
        private System.Windows.Forms.ImageList imgAnhLon;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnChuyenTiep;
        private System.Windows.Forms.ColumnHeader MoTa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnXoaBoTu;
        private System.Windows.Forms.Button btnThemBoTu;
        private System.Windows.Forms.Button btnSuaBoTu;
        private System.Windows.Forms.CheckBox chkAll;
        private System.Windows.Forms.Button btnLuyenTap;
        private System.Windows.Forms.Button btnHocTu;
        private System.Windows.Forms.Button btnMoBoTu;
        private System.Windows.Forms.Button btnMoTuVung;
        private System.Windows.Forms.Button btnLuuTuVung;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lvBoTuNenTap;
        private System.Windows.Forms.ColumnHeader tenBoNenTap;
        private System.Windows.Forms.ColumnHeader moTaBoNenTap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnInTuVung;
    }
}


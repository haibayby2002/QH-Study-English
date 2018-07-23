namespace Ver1._0
{
    partial class FormMoBoTu
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
            this.txtTenBo = new System.Windows.Forms.TextBox();
            this.lvDanhSachTu = new System.Windows.Forms.ListView();
            this.TenTu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NghiaTu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.chkAll = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtTenBo
            // 
            this.txtTenBo.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenBo.Location = new System.Drawing.Point(237, 12);
            this.txtTenBo.Name = "txtTenBo";
            this.txtTenBo.Size = new System.Drawing.Size(402, 39);
            this.txtTenBo.TabIndex = 0;
            // 
            // lvDanhSachTu
            // 
            this.lvDanhSachTu.CheckBoxes = true;
            this.lvDanhSachTu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TenTu,
            this.NghiaTu});
            this.lvDanhSachTu.FullRowSelect = true;
            this.lvDanhSachTu.Location = new System.Drawing.Point(12, 192);
            this.lvDanhSachTu.Name = "lvDanhSachTu";
            this.lvDanhSachTu.Size = new System.Drawing.Size(847, 291);
            this.lvDanhSachTu.TabIndex = 1;
            this.lvDanhSachTu.UseCompatibleStateImageBehavior = false;
            this.lvDanhSachTu.View = System.Windows.Forms.View.Details;
            // 
            // TenTu
            // 
            this.TenTu.Text = "Tên từ";
            this.TenTu.Width = 149;
            // 
            // NghiaTu
            // 
            this.NghiaTu.Text = "Nghĩa của từ";
            this.NghiaTu.Width = 350;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên bộ từ:";
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(237, 57);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMoTa.Size = new System.Drawing.Size(402, 129);
            this.txtMoTa.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mô tả: ";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(715, 489);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(144, 36);
            this.btnLuu.TabIndex = 5;
            this.btnLuu.Text = "Lưu vào từ của tôi";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(627, 489);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(82, 36);
            this.btnHuy.TabIndex = 6;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // chkAll
            // 
            this.chkAll.AutoSize = true;
            this.chkAll.Location = new System.Drawing.Point(21, 172);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(15, 14);
            this.chkAll.TabIndex = 7;
            this.chkAll.UseVisualStyleBackColor = true;
            this.chkAll.CheckedChanged += new System.EventHandler(this.chkAll_CheckedChanged);
            // 
            // FormMoBoTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 537);
            this.Controls.Add(this.chkAll);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvDanhSachTu);
            this.Controls.Add(this.txtTenBo);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMoBoTu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mở bộ từ";
            this.Load += new System.EventHandler(this.FormMoBoTu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTenBo;
        private System.Windows.Forms.ListView lvDanhSachTu;
        private System.Windows.Forms.ColumnHeader TenTu;
        private System.Windows.Forms.ColumnHeader NghiaTu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.CheckBox chkAll;
    }
}
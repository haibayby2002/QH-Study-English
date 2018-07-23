namespace Ver1._0
{
    partial class FormSuaBo
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
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.cmbBoTuSua = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenBoMoi = new System.Windows.Forms.TextBox();
            this.txtMoTaMoi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(252, 226);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(101, 30);
            this.btnXacNhan.TabIndex = 2;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHuy.Location = new System.Drawing.Point(145, 226);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(101, 30);
            this.btnHuy.TabIndex = 3;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // cmbBoTuSua
            // 
            this.cmbBoTuSua.FormattingEnabled = true;
            this.cmbBoTuSua.Location = new System.Drawing.Point(145, 25);
            this.cmbBoTuSua.Name = "cmbBoTuSua";
            this.cmbBoTuSua.Size = new System.Drawing.Size(208, 27);
            this.cmbBoTuSua.TabIndex = 4;
            this.cmbBoTuSua.Text = "Chọn bộ từ";
            this.cmbBoTuSua.SelectedIndexChanged += new System.EventHandler(this.cmbBoTuSua_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bộ từ cần sửa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sửa thành bộ: ";
            // 
            // txtTenBoMoi
            // 
            this.txtTenBoMoi.Location = new System.Drawing.Point(145, 65);
            this.txtTenBoMoi.Name = "txtTenBoMoi";
            this.txtTenBoMoi.Size = new System.Drawing.Size(208, 26);
            this.txtTenBoMoi.TabIndex = 0;
            // 
            // txtMoTaMoi
            // 
            this.txtMoTaMoi.Location = new System.Drawing.Point(145, 107);
            this.txtMoTaMoi.Multiline = true;
            this.txtMoTaMoi.Name = "txtMoTaMoi";
            this.txtMoTaMoi.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMoTaMoi.Size = new System.Drawing.Size(208, 100);
            this.txtMoTaMoi.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mô tả mới:";
            // 
            // FormSuaBo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnHuy;
            this.ClientSize = new System.Drawing.Size(384, 276);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMoTaMoi);
            this.Controls.Add(this.txtTenBoMoi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBoTuSua);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnXacNhan);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSuaBo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sửa bộ từ";
            this.Load += new System.EventHandler(this.FormSuaBo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.ComboBox cmbBoTuSua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenBoMoi;
        private System.Windows.Forms.TextBox txtMoTaMoi;
        private System.Windows.Forms.Label label3;
    }
}
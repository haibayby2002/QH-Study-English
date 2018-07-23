namespace Ver1._0
{
    partial class FormHinhThucLuyenTap
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbHinhThuc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rdbLuyenTapHet = new System.Windows.Forms.RadioButton();
            this.rdbLuyenTapTuDaChon = new System.Windows.Forms.RadioButton();
            this.btnLuyenTap = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hình thức:";
            // 
            // cmbHinhThuc
            // 
            this.cmbHinhThuc.FormattingEnabled = true;
            this.cmbHinhThuc.Items.AddRange(new object[] {
            "Chọn hình thức",
            "Trắc nghiệm",
            "Tự luận",
            "Sắp xếp",
            "Điền khuyết"});
            this.cmbHinhThuc.Location = new System.Drawing.Point(138, 37);
            this.cmbHinhThuc.Name = "cmbHinhThuc";
            this.cmbHinhThuc.Size = new System.Drawing.Size(286, 27);
            this.cmbHinhThuc.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Từ luyện tập:";
            // 
            // rdbLuyenTapHet
            // 
            this.rdbLuyenTapHet.AutoSize = true;
            this.rdbLuyenTapHet.Location = new System.Drawing.Point(138, 96);
            this.rdbLuyenTapHet.Name = "rdbLuyenTapHet";
            this.rdbLuyenTapHet.Size = new System.Drawing.Size(109, 23);
            this.rdbLuyenTapHet.TabIndex = 3;
            this.rdbLuyenTapHet.TabStop = true;
            this.rdbLuyenTapHet.Text = "Luyện tập hết";
            this.rdbLuyenTapHet.UseVisualStyleBackColor = true;
            // 
            // rdbLuyenTapTuDaChon
            // 
            this.rdbLuyenTapTuDaChon.AutoSize = true;
            this.rdbLuyenTapTuDaChon.Location = new System.Drawing.Point(268, 96);
            this.rdbLuyenTapTuDaChon.Name = "rdbLuyenTapTuDaChon";
            this.rdbLuyenTapTuDaChon.Size = new System.Drawing.Size(156, 23);
            this.rdbLuyenTapTuDaChon.TabIndex = 4;
            this.rdbLuyenTapTuDaChon.TabStop = true;
            this.rdbLuyenTapTuDaChon.Text = "Luyện tập từ đã chọn";
            this.rdbLuyenTapTuDaChon.UseVisualStyleBackColor = true;
            // 
            // btnLuyenTap
            // 
            this.btnLuyenTap.Location = new System.Drawing.Point(284, 153);
            this.btnLuyenTap.Name = "btnLuyenTap";
            this.btnLuyenTap.Size = new System.Drawing.Size(140, 35);
            this.btnLuyenTap.TabIndex = 5;
            this.btnLuyenTap.Text = "Practice";
            this.btnLuyenTap.UseVisualStyleBackColor = true;
            this.btnLuyenTap.Click += new System.EventHandler(this.btnLuyenTap_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(138, 153);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(140, 35);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormHinhThucLuyenTap
            // 
            this.AcceptButton = this.btnLuyenTap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(438, 207);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLuyenTap);
            this.Controls.Add(this.rdbLuyenTapTuDaChon);
            this.Controls.Add(this.rdbLuyenTapHet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbHinhThuc);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormHinhThucLuyenTap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chế độ luyện tập";
            this.Load += new System.EventHandler(this.FormHinhThucLuyenTap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbHinhThuc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdbLuyenTapHet;
        private System.Windows.Forms.RadioButton rdbLuyenTapTuDaChon;
        private System.Windows.Forms.Button btnLuyenTap;
        private System.Windows.Forms.Button btnCancel;
    }
}
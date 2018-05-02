namespace ThucHanhLamViecNhom
{
    partial class frmManHinhChinh
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_DangXuat = new System.Windows.Forms.Button();
            this.btn_LuuThong = new System.Windows.Forms.Button();
            this.btn_BanVe = new System.Windows.Forms.Button();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.btn_CapNhat = new System.Windows.Forms.Button();
            this.lb_CTQLHTXB = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.btn_DangXuat);
            this.panel1.Controls.Add(this.btn_LuuThong);
            this.panel1.Controls.Add(this.btn_BanVe);
            this.panel1.Controls.Add(this.btn_TimKiem);
            this.panel1.Controls.Add(this.btn_CapNhat);
            this.panel1.Controls.Add(this.lb_CTQLHTXB);
            this.panel1.Location = new System.Drawing.Point(71, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(516, 265);
            this.panel1.TabIndex = 0;
            // 
            // btn_DangXuat
            // 
            this.btn_DangXuat.Location = new System.Drawing.Point(393, 222);
            this.btn_DangXuat.Name = "btn_DangXuat";
            this.btn_DangXuat.Size = new System.Drawing.Size(75, 23);
            this.btn_DangXuat.TabIndex = 5;
            this.btn_DangXuat.Text = "Đăng xuất";
            this.btn_DangXuat.UseVisualStyleBackColor = true;
            // 
            // btn_LuuThong
            // 
            this.btn_LuuThong.Location = new System.Drawing.Point(393, 35);
            this.btn_LuuThong.Name = "btn_LuuThong";
            this.btn_LuuThong.Size = new System.Drawing.Size(75, 58);
            this.btn_LuuThong.TabIndex = 4;
            this.btn_LuuThong.Text = "Quản lí lưu thông tuyến xe buýt";
            this.btn_LuuThong.UseVisualStyleBackColor = true;
            // 
            // btn_BanVe
            // 
            this.btn_BanVe.Location = new System.Drawing.Point(275, 35);
            this.btn_BanVe.Name = "btn_BanVe";
            this.btn_BanVe.Size = new System.Drawing.Size(75, 58);
            this.btn_BanVe.TabIndex = 3;
            this.btn_BanVe.Text = "Quản lí thông tin bán vé";
            this.btn_BanVe.UseVisualStyleBackColor = true;
            this.btn_BanVe.Click += new System.EventHandler(this.btn_BanVe_Click);
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Location = new System.Drawing.Point(151, 34);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(75, 59);
            this.btn_TimKiem.TabIndex = 2;
            this.btn_TimKiem.Text = "Tìm kiếm thông tin tài xế";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.Location = new System.Drawing.Point(22, 35);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(75, 58);
            this.btn_CapNhat.TabIndex = 1;
            this.btn_CapNhat.Text = "Cập nhật thông tin tài xế";
            this.btn_CapNhat.UseVisualStyleBackColor = true;
            // 
            // lb_CTQLHTXB
            // 
            this.lb_CTQLHTXB.AutoSize = true;
            this.lb_CTQLHTXB.Location = new System.Drawing.Point(0, 4);
            this.lb_CTQLHTXB.Name = "lb_CTQLHTXB";
            this.lb_CTQLHTXB.Size = new System.Drawing.Size(187, 13);
            this.lb_CTQLHTXB.TabIndex = 0;
            this.lb_CTQLHTXB.Text = "Chuong Trinh quan li he thong xe buyt";
            // 
            // frmManHinhChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(636, 352);
            this.Controls.Add(this.panel1);
            this.Name = "frmManHinhChinh";
            this.Text = "Man Hinh Chinh";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_LuuThong;
        private System.Windows.Forms.Button btn_BanVe;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.Button btn_CapNhat;
        private System.Windows.Forms.Label lb_CTQLHTXB;
        private System.Windows.Forms.Button btn_DangXuat;
    }
}


namespace QuanLiThongTinBanVeNgay
{
    partial class Form1
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
            this.lbMaGD = new System.Windows.Forms.Label();
            this.lbNgay = new System.Windows.Forms.Label();
            this.txtMaGD = new System.Windows.Forms.TextBox();
            this.txtNgay = new System.Windows.Forms.TextBox();
            this.grbThongTinTaiXe = new System.Windows.Forms.GroupBox();
            this.lbTenTX = new System.Windows.Forms.Label();
            this.txttenTX = new System.Windows.Forms.TextBox();
            this.txtMaTX = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbMaTX = new System.Windows.Forms.Label();
            this.grpThongTinVeNgay = new System.Windows.Forms.GroupBox();
            this.txtDG = new System.Windows.Forms.TextBox();
            this.txtMaVeNgay = new System.Windows.Forms.TextBox();
            this.lbDG = new System.Windows.Forms.Label();
            this.lbMaVeNgay = new System.Windows.Forms.Label();
            this.txtBanRa = new System.Windows.Forms.TextBox();
            this.txtBanDuoc = new System.Windows.Forms.TextBox();
            this.txtThuVao = new System.Windows.Forms.TextBox();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.lbBanRa = new System.Windows.Forms.Label();
            this.lbBanDuoc = new System.Windows.Forms.Label();
            this.lbThuVao = new System.Windows.Forms.Label();
            this.lbThanhTien = new System.Windows.Forms.Label();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.MaGD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaVeNgay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VePhatRa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VeThuVao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VeBanDuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTinh = new System.Windows.Forms.Button();
            this.grbThongTinTaiXe.SuspendLayout();
            this.grpThongTinVeNgay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(263, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lí thông tin bán vé ngày";
            // 
            // lbMaGD
            // 
            this.lbMaGD.AutoSize = true;
            this.lbMaGD.Location = new System.Drawing.Point(18, 65);
            this.lbMaGD.Name = "lbMaGD";
            this.lbMaGD.Size = new System.Drawing.Size(72, 13);
            this.lbMaGD.TabIndex = 1;
            this.lbMaGD.Text = "Mã Giao Dịch";
            // 
            // lbNgay
            // 
            this.lbNgay.AutoSize = true;
            this.lbNgay.Location = new System.Drawing.Point(29, 96);
            this.lbNgay.Name = "lbNgay";
            this.lbNgay.Size = new System.Drawing.Size(32, 13);
            this.lbNgay.TabIndex = 2;
            this.lbNgay.Text = "Ngày";
            // 
            // txtMaGD
            // 
            this.txtMaGD.Location = new System.Drawing.Point(96, 65);
            this.txtMaGD.Name = "txtMaGD";
            this.txtMaGD.Size = new System.Drawing.Size(212, 20);
            this.txtMaGD.TabIndex = 3;
            this.txtMaGD.TextChanged += new System.EventHandler(this.txtMaGD_TextChanged);
            // 
            // txtNgay
            // 
            this.txtNgay.Location = new System.Drawing.Point(96, 96);
            this.txtNgay.Name = "txtNgay";
            this.txtNgay.Size = new System.Drawing.Size(212, 20);
            this.txtNgay.TabIndex = 4;
            // 
            // grbThongTinTaiXe
            // 
            this.grbThongTinTaiXe.Controls.Add(this.lbTenTX);
            this.grbThongTinTaiXe.Controls.Add(this.txttenTX);
            this.grbThongTinTaiXe.Controls.Add(this.txtMaTX);
            this.grbThongTinTaiXe.Controls.Add(this.label5);
            this.grbThongTinTaiXe.Controls.Add(this.lbMaTX);
            this.grbThongTinTaiXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbThongTinTaiXe.Location = new System.Drawing.Point(32, 139);
            this.grbThongTinTaiXe.Name = "grbThongTinTaiXe";
            this.grbThongTinTaiXe.Size = new System.Drawing.Size(685, 53);
            this.grbThongTinTaiXe.TabIndex = 6;
            this.grbThongTinTaiXe.TabStop = false;
            this.grbThongTinTaiXe.Text = "Thông tin tài xế";
            // 
            // lbTenTX
            // 
            this.lbTenTX.AutoSize = true;
            this.lbTenTX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenTX.Location = new System.Drawing.Point(404, 19);
            this.lbTenTX.Name = "lbTenTX";
            this.lbTenTX.Size = new System.Drawing.Size(54, 13);
            this.lbTenTX.TabIndex = 4;
            this.lbTenTX.Text = "Tên tài xế";
            // 
            // txttenTX
            // 
            this.txttenTX.Location = new System.Drawing.Point(483, 19);
            this.txttenTX.Name = "txttenTX";
            this.txttenTX.Size = new System.Drawing.Size(145, 20);
            this.txttenTX.TabIndex = 3;
            // 
            // txtMaTX
            // 
            this.txtMaTX.Location = new System.Drawing.Point(64, 16);
            this.txtMaTX.Name = "txtMaTX";
            this.txtMaTX.Size = new System.Drawing.Size(170, 20);
            this.txtMaTX.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(480, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 1;
            // 
            // lbMaTX
            // 
            this.lbMaTX.AutoSize = true;
            this.lbMaTX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaTX.Location = new System.Drawing.Point(6, 16);
            this.lbMaTX.Name = "lbMaTX";
            this.lbMaTX.Size = new System.Drawing.Size(54, 13);
            this.lbMaTX.TabIndex = 0;
            this.lbMaTX.Text = "Mã Tài xế";
            // 
            // grpThongTinVeNgay
            // 
            this.grpThongTinVeNgay.Controls.Add(this.txtDG);
            this.grpThongTinVeNgay.Controls.Add(this.txtMaVeNgay);
            this.grpThongTinVeNgay.Controls.Add(this.lbDG);
            this.grpThongTinVeNgay.Controls.Add(this.lbMaVeNgay);
            this.grpThongTinVeNgay.Location = new System.Drawing.Point(32, 217);
            this.grpThongTinVeNgay.Name = "grpThongTinVeNgay";
            this.grpThongTinVeNgay.Size = new System.Drawing.Size(685, 63);
            this.grpThongTinVeNgay.TabIndex = 7;
            this.grpThongTinVeNgay.TabStop = false;
            this.grpThongTinVeNgay.Text = "Thông tin vé ngày";
            // 
            // txtDG
            // 
            this.txtDG.Location = new System.Drawing.Point(483, 13);
            this.txtDG.Name = "txtDG";
            this.txtDG.Size = new System.Drawing.Size(145, 20);
            this.txtDG.TabIndex = 3;
            this.txtDG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBanRa_KeyPress);
            // 
            // txtMaVeNgay
            // 
            this.txtMaVeNgay.Location = new System.Drawing.Point(67, 16);
            this.txtMaVeNgay.Name = "txtMaVeNgay";
            this.txtMaVeNgay.Size = new System.Drawing.Size(170, 20);
            this.txtMaVeNgay.TabIndex = 2;
            // 
            // lbDG
            // 
            this.lbDG.AutoSize = true;
            this.lbDG.Location = new System.Drawing.Point(404, 16);
            this.lbDG.Name = "lbDG";
            this.lbDG.Size = new System.Drawing.Size(44, 13);
            this.lbDG.TabIndex = 1;
            this.lbDG.Text = "Đơn giá";
            // 
            // lbMaVeNgay
            // 
            this.lbMaVeNgay.AutoSize = true;
            this.lbMaVeNgay.Location = new System.Drawing.Point(6, 20);
            this.lbMaVeNgay.Name = "lbMaVeNgay";
            this.lbMaVeNgay.Size = new System.Drawing.Size(63, 13);
            this.lbMaVeNgay.TabIndex = 0;
            this.lbMaVeNgay.Text = "Mã vé ngày";
            // 
            // txtBanRa
            // 
            this.txtBanRa.Location = new System.Drawing.Point(191, 296);
            this.txtBanRa.Name = "txtBanRa";
            this.txtBanRa.Size = new System.Drawing.Size(100, 20);
            this.txtBanRa.TabIndex = 8;
            this.txtBanRa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBanRa_KeyPress);
            // 
            // txtBanDuoc
            // 
            this.txtBanDuoc.Location = new System.Drawing.Point(191, 343);
            this.txtBanDuoc.Name = "txtBanDuoc";
            this.txtBanDuoc.Size = new System.Drawing.Size(100, 20);
            this.txtBanDuoc.TabIndex = 9;
            // 
            // txtThuVao
            // 
            this.txtThuVao.Location = new System.Drawing.Point(515, 292);
            this.txtThuVao.Name = "txtThuVao";
            this.txtThuVao.Size = new System.Drawing.Size(100, 20);
            this.txtThuVao.TabIndex = 10;
            this.txtThuVao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBanRa_KeyPress);
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(515, 344);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(100, 20);
            this.txtThanhTien.TabIndex = 11;
            // 
            // lbBanRa
            // 
            this.lbBanRa.AutoSize = true;
            this.lbBanRa.Location = new System.Drawing.Point(96, 302);
            this.lbBanRa.Name = "lbBanRa";
            this.lbBanRa.Size = new System.Drawing.Size(68, 13);
            this.lbBanRa.TabIndex = 12;
            this.lbBanRa.Text = "Số vé bán ra";
            // 
            // lbBanDuoc
            // 
            this.lbBanDuoc.AutoSize = true;
            this.lbBanDuoc.Location = new System.Drawing.Point(99, 350);
            this.lbBanDuoc.Name = "lbBanDuoc";
            this.lbBanDuoc.Size = new System.Drawing.Size(84, 13);
            this.lbBanDuoc.TabIndex = 13;
            this.lbBanDuoc.Text = "Số vé bán được";
            // 
            // lbThuVao
            // 
            this.lbThuVao.AutoSize = true;
            this.lbThuVao.Location = new System.Drawing.Point(436, 299);
            this.lbThuVao.Name = "lbThuVao";
            this.lbThuVao.Size = new System.Drawing.Size(74, 13);
            this.lbThuVao.TabIndex = 14;
            this.lbThuVao.Text = "Số vé thu vào";
            // 
            // lbThanhTien
            // 
            this.lbThanhTien.AutoSize = true;
            this.lbThanhTien.Location = new System.Drawing.Point(436, 350);
            this.lbThanhTien.Name = "lbThanhTien";
            this.lbThanhTien.Size = new System.Drawing.Size(62, 13);
            this.lbThanhTien.TabIndex = 15;
            this.lbThanhTien.Text = "Thành Tiền";
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaGD,
            this.Ngay,
            this.MaTX,
            this.TenTX,
            this.MaVeNgay,
            this.DG,
            this.VePhatRa,
            this.VeThuVao,
            this.VeBanDuoc,
            this.ThanhTien});
            this.dgvDanhSach.Location = new System.Drawing.Point(13, 370);
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.Size = new System.Drawing.Size(740, 150);
            this.dgvDanhSach.TabIndex = 16;
            // 
            // MaGD
            // 
            this.MaGD.DataPropertyName = "MaGD";
            this.MaGD.HeaderText = "Mã GD";
            this.MaGD.Name = "MaGD";
            // 
            // Ngay
            // 
            this.Ngay.DataPropertyName = "ngay";
            this.Ngay.HeaderText = "Ngày";
            this.Ngay.Name = "Ngay";
            // 
            // MaTX
            // 
            this.MaTX.DataPropertyName = "MaTX";
            this.MaTX.HeaderText = "Mã TX";
            this.MaTX.Name = "MaTX";
            // 
            // TenTX
            // 
            this.TenTX.DataPropertyName = "TenTX";
            this.TenTX.HeaderText = "Tên TX";
            this.TenTX.Name = "TenTX";
            // 
            // MaVeNgay
            // 
            this.MaVeNgay.DataPropertyName = "MaVeNgay";
            this.MaVeNgay.HeaderText = "Mã vé ngày";
            this.MaVeNgay.Name = "MaVeNgay";
            // 
            // DG
            // 
            this.DG.DataPropertyName = "DG";
            this.DG.HeaderText = "DG";
            this.DG.Name = "DG";
            // 
            // VePhatRa
            // 
            this.VePhatRa.DataPropertyName = "VePhatRa";
            this.VePhatRa.HeaderText = "Phát ra";
            this.VePhatRa.Name = "VePhatRa";
            // 
            // VeThuVao
            // 
            this.VeThuVao.DataPropertyName = "VeThuVao";
            this.VeThuVao.HeaderText = "ThuVao";
            this.VeThuVao.Name = "VeThuVao";
            // 
            // VeBanDuoc
            // 
            this.VeBanDuoc.DataPropertyName = "VeBanDuoc";
            this.VeBanDuoc.HeaderText = "Bán Được";
            this.VeBanDuoc.Name = "VeBanDuoc";
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.Name = "ThanhTien";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(12, 562);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 17;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(166, 562);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 18;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(306, 562);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 19;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(472, 562);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 20;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(642, 562);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 21;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(642, 343);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(75, 21);
            this.btnTinh.TabIndex = 22;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(788, 597);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvDanhSach);
            this.Controls.Add(this.lbThanhTien);
            this.Controls.Add(this.lbThuVao);
            this.Controls.Add(this.lbBanDuoc);
            this.Controls.Add(this.lbBanRa);
            this.Controls.Add(this.txtThanhTien);
            this.Controls.Add(this.txtThuVao);
            this.Controls.Add(this.txtBanDuoc);
            this.Controls.Add(this.txtBanRa);
            this.Controls.Add(this.grpThongTinVeNgay);
            this.Controls.Add(this.grbThongTinTaiXe);
            this.Controls.Add(this.txtNgay);
            this.Controls.Add(this.txtMaGD);
            this.Controls.Add(this.lbNgay);
            this.Controls.Add(this.lbMaGD);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbThongTinTaiXe.ResumeLayout(false);
            this.grbThongTinTaiXe.PerformLayout();
            this.grpThongTinVeNgay.ResumeLayout(false);
            this.grpThongTinVeNgay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbMaGD;
        private System.Windows.Forms.Label lbNgay;
        private System.Windows.Forms.TextBox txtMaGD;
        private System.Windows.Forms.TextBox txtNgay;
        private System.Windows.Forms.GroupBox grbThongTinTaiXe;
        private System.Windows.Forms.TextBox txttenTX;
        private System.Windows.Forms.TextBox txtMaTX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbMaTX;
        private System.Windows.Forms.GroupBox grpThongTinVeNgay;
        private System.Windows.Forms.TextBox txtDG;
        private System.Windows.Forms.TextBox txtMaVeNgay;
        private System.Windows.Forms.Label lbDG;
        private System.Windows.Forms.Label lbMaVeNgay;
        private System.Windows.Forms.TextBox txtBanRa;
        private System.Windows.Forms.TextBox txtBanDuoc;
        private System.Windows.Forms.TextBox txtThuVao;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Label lbBanRa;
        private System.Windows.Forms.Label lbBanDuoc;
        private System.Windows.Forms.Label lbThuVao;
        private System.Windows.Forms.Label lbThanhTien;
        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lbTenTX;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTX;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTX;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaVeNgay;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG;
        private System.Windows.Forms.DataGridViewTextBoxColumn VePhatRa;
        private System.Windows.Forms.DataGridViewTextBoxColumn VeThuVao;
        private System.Windows.Forms.DataGridViewTextBoxColumn VeBanDuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.Button btnTinh;
    }
}


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
using System.Configuration;

namespace QuanLiThongTinBanVeNgay
{
    public partial class Form1 : Form
    {
        int thaoTac = 0;
        string connectionString = ConfigurationManager.ConnectionStrings["QuanLiThongTinBanVeNgay.Properties.Settings.Setting"].ConnectionString;
       // string connectionString = @"Data Source=DESKTOP-8U00IH5;Initial Catalog = QLTX; Integrated Security = True";
        public Form1()
        { 
            InitializeComponent();
            dgvDanhSach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

     

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaGD.ReadOnly = false;
            txtNgay.ReadOnly = false;
            txtMaTX.ReadOnly = false;
            txttenTX.ReadOnly = false;
            txtMaVeNgay.ReadOnly = false;
            txtDG.ReadOnly = false;
            txtBanRa.ReadOnly = false;
            txtThuVao.ReadOnly = false;
            txtBanDuoc.ReadOnly = true;
            txtThanhTien.ReadOnly = true;
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            dgvDanhSach.Enabled = true;
           
            thaoTac = 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtMaGD.ReadOnly = true;
            txtNgay.ReadOnly = true;
            txtMaTX.ReadOnly = true;
            txttenTX.ReadOnly = true;
            txtMaVeNgay.ReadOnly = true;
            txtDG.ReadOnly = true;
            txtBanRa.ReadOnly = true;
            txtThuVao.ReadOnly = true;
            txtBanDuoc.ReadOnly = true;
            txtThanhTien.ReadOnly = true;
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            laydanhsach();
            dgvDanhSach.Enabled = false;
            
           // hienthi();
        }

        private void laydanhsach()
        {
            string query = "Select * from ThongTinBanVe";
            SqlDataAdapter da = new SqlDataAdapter(query, connectionString);
            DataSet ds = new DataSet();
            da.Fill(ds,"ThongTinBanVe");
            dgvDanhSach.DataSource = ds.Tables["ThongTinBanVe"];
        }

     

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string MaGD = txtMaGD.Text;
            string Ngay = txtNgay.Text;
            string MaTX = txtMaTX.Text;
            string TenTX = txttenTX.Text;
            string MaVeNgay = txtMaVeNgay.Text;
            int donGia = int.Parse(txtDG.Text);
            int phatRa = int.Parse(txtBanRa.Text);
            int thuVao = int.Parse(txtThuVao.Text);
            int banDuoc = int.Parse(txtBanDuoc.Text);
            int thanhTien = int.Parse(txtThanhTien.Text);
            //kiem tra co trung ma giao dich trong database hay khong ?
            if (MaGD == null || Ngay == null ||MaTX == null|| TenTX == null || lbMaVeNgay == null || DG == null || VePhatRa == null || VeThuVao == null || VeBanDuoc == null || ThanhTien == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ");
            }
            else
            {
                switch (thaoTac)
                {
                    case 1:
                      
                        QuanLi(MaGD,Ngay,MaTX,TenTX,MaVeNgay,donGia,phatRa,thuVao,banDuoc,thanhTien );
                        laydanhsach();
                        hienthi();
                        break;
                }
            }
        }

        private void QuanLi(string maGD, string Ngay, string MaTX, string TenTX, string MaVeNgay, int DG, int VePhatRa, int VeThuVao, int VeBanDuoc, int ThanhTien)
        {

            //string query = string.Format("insert into ThongTinBanVe values('{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')",maGD, Ngay, MaTX, TenTX, MaVeNgay, DG, VePhatRa, VeThuVao, VeBanDuoc, ThanhTien);
            string query = "insert into ThongTinBanVe values('"+maGD+"','"+Ngay+"','"+MaTX+"',N'"+TenTX+"','"+MaVeNgay+"','"+DG+"','"+VePhatRa+"','"+VeThuVao+"','"+VeBanDuoc+"','"+ThanhTien+"')";
            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                int kq = cmd.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("Đã thêm thành công","Thông báo");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra");
            }
            finally 
            {
                if (con != null)
                con.Close();
            }   
               
           
        }

        private bool kiemtratontai()
        {
            bool tatkt = false;
            string maGD = txtMaGD.Text;
            SqlConnection con = new SqlConnection(connectionString);
            string query = "SELECT MaGD FROM ThongTinBanVe";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (maGD == dr.GetString(0))
                {
                    tatkt = true;
                    break;
                }
            }
            con.Close();
            return tatkt;
        }

   /*     private void tinhToan()
        {
            int donGia = Convert.ToInt32(txtDG.Text);
            int phatRa = Convert.ToInt32(txtBanRa.Text);
            int thuVao = Convert.ToInt32(txtThuVao.Text);
            int banDuoc = Convert.ToInt32(txtBanDuoc.Text);
            int thanhTien = Convert.ToInt32(txtThanhTien.Text);
            
            string query = "select * form ThongTinBanVe where VeBanDuoc = VePhatRa - VeThuVao and ThanhTien = DG * VeBanDuoc";
            SqlConnection con = new SqlConnection(conncectionString);

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                try
                {
                    con.Open();
                    int kq1 = cmd.ExecuteNonQuery();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("đã xảy ra lỗi khi thực hiện" + ex.ToString());
                }

            } 
        } */
        private void hienthi()
        {
            if (dgvDanhSach.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvDanhSach.SelectedRows[0];
                string MaGD = row.Cells[0].Value.ToString();
                string Ngay = row.Cells[1].Value.ToString();
                string MaTX = row.Cells[2].Value.ToString();
                string TenTX = row.Cells[3].Value.ToString();
                string MaVeNgay = row.Cells[4].Value.ToString();
                string DG = row.Cells[5].Value.ToString();
                string VePhatRa = row.Cells[6].Value.ToString();
                string VeThuVao = row.Cells[7].Value.ToString();
                string VeBanDuoc = row.Cells[8].Value.ToString();
                string ThanhTien = row.Cells[9].Value.ToString();
                txtMaGD.Text = MaGD;
                txtNgay.Text = Ngay;
                txtMaTX.Text = MaTX;
                txttenTX.Text = TenTX;
                txtMaVeNgay.Text = MaVeNgay;
                txtDG.Text = DG;
                txtBanRa.Text = VePhatRa;
                txtThuVao.Text = VeThuVao;
                txtBanDuoc.Text = VeBanDuoc;
                txtThanhTien.Text = ThanhTien;
            }
        }
        // sự kiện chỉ cho phép nhập giá trị là số trong các ô textbox
        private void txtBanRa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar)|| e.KeyChar =='.')
            {

            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void btnTinh_Click(object sender, EventArgs e)
        { 
            int donGia = Convert.ToInt32(txtDG.Text);
            int phatRa = Convert.ToInt32(txtBanRa.Text);
            int thuVao = Convert.ToInt32(txtThuVao.Text);
            if (phatRa > thuVao)
            {
                int kq1 = phatRa - thuVao;
                int kq2 = kq1 * donGia;
                txtBanDuoc.Text = kq1.ToString();
                txtThanhTien.Text = kq2.ToString();
            }
            else
            {
                MessageBox.Show("vui lòng nhập lại đơn giá, số vé phát ra, hoặc số thu vào", "Thông báo");
            }
        }
        //kiểm tra xem có trùng mã giao dịch trong database hay không?
        private void txtMaGD_TextChanged(object sender, EventArgs e)
        {
            if (kiemtratontai())
            {
                txtMaGD.ForeColor = System.Drawing.Color.Red;
                MessageBox.Show("Trùng mã");
            }
        }
    }
}

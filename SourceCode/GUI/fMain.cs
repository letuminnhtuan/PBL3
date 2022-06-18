using SourceCode.BLL;
using SourceCode.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SourceCode.GUI
{
    public partial class fMain : Form
    {
        private object o;
        public string Role = "";
        public string MaNV = "";
        private List<DatMonAn> temp = new List<DatMonAn>();
        public fMain(string Role, string MaNhanVien)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            this.Role = Role;
            this.MaNV = MaNhanVien;
            if (!this.Role.Equals("ADMIN")) this.menuQL.Enabled = false;
            LoadCBB();
            LoadStatusBanAn();
        }
        public void LoadCBB()
        {
            this.cbbLoaiMonAn.Items.AddRange(BLL_QLMA.Instance.GetCBBLoaiMonAn().ToArray());
        }
        public void LoadStatusBanAn()
        {
            Button[] arr = new Button[]
            {
                this.button1, this.button2, this.button3, this.button4,
                this.button5, this.button6 ,this.button7,this.button8 ,
                this.button9,this.button10,this.button11,this.button12,
                this.button13,this.button14,this.button15,this.button16
            };
            foreach(Button i in arr)
            {
                if (!BLL_QLDatmon.Instance.GetStatusBanAn(i.Text)) // => not complete
                {
                    i.BackColor = Color.FromArgb(255, 51, 51);
                }
            }
        }
        private void LogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.None, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                this.Dispose();
            }
        }
        private void menuQL_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            f.ShowDialog();
        }
        private void cbbLoaiMonAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbbLoaiMonAn.SelectedIndex >= 0)
            {
                this.cbbMonAn.Items.Clear();
                string MaLoaiMonAn = ((CBBItem)this.cbbLoaiMonAn.SelectedItem).Key;
                this.cbbMonAn.Text = "";
                this.cbbMonAn.Items.AddRange(BLL_QLMA.Instance.GetCBBMonAnByLoaiMonAn(MaLoaiMonAn).ToArray());
            }
        }
        private void cbbMonAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbbMonAn.SelectedIndex >= 0)
            {
                string MaMonAn = ((CBBItem)this.cbbMonAn.SelectedItem).Key;
                this.numMon.Maximum = BLL_QLMA.Instance.GetMonAnByMaMonAn(MaMonAn).SoLuong;
            }
        }
        public void Order(object o, EventArgs e)
        {
            this.dataDatMon.Rows.Clear();
            this.txtThe.Text = ((Button)o).Text;
            this.o = o;
            if (!BLL_QLDatmon.Instance.GetStatusBanAn(((Button)o).Text))
            {
                List<DatMonAn> data = BLL_QLHoaDon.Instance.GetHoaDonHienTaiByMaBan(((Button)o).Text);
                foreach (DatMonAn i in data)
                {
                    string TenMonAn = BLL_QLMA.Instance.GetMonAnByMaMonAn(i.MaMonAn).TenMonAn;
                    this.dataDatMon.Rows.Add(TenMonAn, i.SoLuong, string.Format(new CultureInfo("vi-VN"), "{0:#,##0.00}", i.TongTien));
                }
            }
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DatMonAn data = new DatMonAn
            {
                MaMonAn = ((CBBItem)this.cbbMonAn.SelectedItem).Key,
                SoLuong = Convert.ToInt32(this.numMon.Value),
            };
            data.TongTien = BLL_QLMA.Instance.GetMonAnByMaMonAn(data.MaMonAn).GiaTien * data.SoLuong;
            if (Check(data.MaMonAn) && data.SoLuong != 0) temp.Add(data);
            else if (data.SoLuong != 0)
            {
                for (int i = 0; i < temp.Count; i++)
                {
                    if (temp[i].MaMonAn.Equals(data.MaMonAn))
                    {
                        temp[i].SoLuong += data.SoLuong;
                        temp[i].TongTien += data.TongTien;
                        break;
                    }
                }
            }
            LoadDSDatMon();
            decimal Tong = 0;
            foreach (DatMonAn i in temp)
            {
                Tong += i.TongTien;
            }
            this.txtTien.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0.00}", Tong);
        }
        private bool Check(string MaMonAn)
        {
            foreach (DatMonAn i in temp)
            {
                if (i.MaMonAn.Equals(MaMonAn)) return false;
            }
            return true;
        }
        private void LoadDSDatMon()
        {
            this.dataDatMon.Rows.Clear();
            foreach (DatMonAn i in temp)
            {
                string TenMonAn = BLL_QLMA.Instance.GetMonAnByMaMonAn(i.MaMonAn).TenMonAn;
                this.dataDatMon.Rows.Add(TenMonAn, i.SoLuong, string.Format(new CultureInfo("vi-VN"), "{0:#,##0.00}", i.TongTien));
            }
        }
        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn đã xác nhận đặt món?", "Đặt món", MessageBoxButtons.OKCancel, MessageBoxIcon.None, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                if (cbbThanhToan.SelectedIndex >= 0)
                {
                    decimal Tong = 0;
                    foreach (DatMonAn i in temp)
                    {
                        Tong += i.TongTien;
                    }
                    HoaDon HD = new HoaDon
                    {
                        MaBanAn = this.txtThe.Text,
                        TongTien = Tong,
                        HinhThucTT = this.cbbThanhToan.Text,
                        TrangThaiTT = true,
                        MaNVOrder = this.MaNV,
                        NgayThanhToan = this.dateTimePicker1.Value
                    };
                    BLL_QLDatmon.Instance.AddHoaDon(HD);
                    BLL_QLDatmon.Instance.AddDatMon(temp);
                    BLL_QLDatmon.Instance.SetStatusBanAn(HD.MaBanAn, false);
                    temp = new List<DatMonAn>();
                    ReloadForm();
                    ((Button)o).BackColor = Color.FromArgb(255, 51, 51);
                }
            }
        }
        public void ReloadForm()
        {
            this.dataDatMon.Rows.Clear();
            this.cbbLoaiMonAn.Text = "";
            this.cbbMonAn.Text = "";
            this.txtThe.Text = "";
            this.txtTien.Text = "";
            this.numMon.Maximum = 0;
            this.numMon.Value = 0;
        }
        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.txtThe.Text = "";
            this.txtTien.Text = "";
            temp = new List<DatMonAn>();
            LoadDSDatMon();
        }
        private void btnHoanThanh_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn đã xác nhận hoàn thành?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.None, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                string MaBanAn = ((Button)o).Text;
                if (!BLL_QLDatmon.Instance.GetStatusBanAn(MaBanAn))
                {
                    ((Button)o).BackColor = Color.PaleGreen;
                    BLL_QLDatmon.Instance.SetStatusBanAn(MaBanAn, true);
                }
            }
        }

        private void dataDatMon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 3 && e.RowIndex > -1)
            {
                string TenMonAn = this.dataDatMon.SelectedRows[0].Cells["colTenMon"].Value.ToString();
                for (int i = 0; i < temp.Count; i++)
                {
                    MonAn s = BLL_QLMA.Instance.GetMonAnByMaMonAn(temp[i].MaMonAn);
                    if (s.TenMonAn.Equals(TenMonAn))
                    {
                        temp[i].SoLuong -= 1;
                        temp[i].TongTien -= s.GiaTien;
                        if (temp[i].SoLuong == 0) temp.RemoveAt(i);
                        break;
                    }
                }
                LoadDSDatMon();
                decimal Tong = 0;
                foreach (DatMonAn i in temp)
                {
                    Tong += i.TongTien;
                }
                this.txtTien.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0.00}", Tong);
            }
        }
    }
}

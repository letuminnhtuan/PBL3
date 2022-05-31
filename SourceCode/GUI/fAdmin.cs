using SourceCode.BLL;
using SourceCode.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SourceCode.GUI
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            LoadComboBox();
            ShowDSMonAn();
            ShowDSThanhVien();
            ShowDSHoaDon();
        }
        public void LoadComboBox()
        {
            this.cbbLoaiMonAn.Items.Add(new CBBItem { Key = "All", Value = "All" });
            this.cbbLoaiMonAn.Items.AddRange(BLL_QLMA.Instance.GetCBBLoaiMonAn().ToArray());
            this.cbbLoaiMonAn.SelectedIndex = 0;
            this.cbbLoaiNV.Items.AddRange(new CBBItem[] 
            {
                 new CBBItem { Key = "All", Value = "All" },
                 new CBBItem { Key = "NHANVIEN", Value = "Nhan vien" },
                 new CBBItem { Key = "ADMIN", Value = "Admin" },
            });
            this.cbbLoaiNV.SelectedIndex = 0;
        }
        public void ShowDSMonAn()
        {
            string MaLoaiMonAn = ((CBBItem)(this.cbbLoaiMonAn.SelectedItem)).Key;
            string txt = this.txtSearchMA.Text;
            this.dataMonAn.DataSource = BLL_QLMA.Instance.GetDSMonAn(MaLoaiMonAn, txt);
        }
        private void cbbLoaiMonAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.cbbLoaiMonAn.SelectedIndex >= 0)
            {
                ShowDSMonAn();
            }
        }
        private void btnDelMonAn_Click(object sender, EventArgs e)
        {
            if(this.dataMonAn.SelectedRows.Count == 1)
            {
                string MaMonAn = this.dataMonAn.SelectedRows[0].Cells["MaMonAn"].Value.ToString();
                BLL_QLMA.Instance.DeleteMonAn(MaMonAn);
                string MaLoai = ((CBBItem)(this.cbbLoaiMonAn.SelectedItem)).Key;
                string txt = this.txtSearchMA.Text;
                ShowDSMonAn();
            }
        }
        private void btnSearchMonAn_Click(object sender, EventArgs e)
        {
            ShowDSMonAn();
        }

        private void btnAddMonAn_Click(object sender, EventArgs e)
        {
            fMonAn f = new fMonAn("");
            f.MyDel = new fMonAn.Del(ShowDSMonAn);
            f.Show();
        }
        private void btnUpdateMonAn_Click(object sender, EventArgs e)
        {
            if(this.dataMonAn.SelectedRows.Count == 1)
            {
                string MaMonAn = this.dataMonAn.SelectedRows[0].Cells["MaMonAn"].Value.ToString();
                fMonAn f = new fMonAn(MaMonAn);
                f.MyDel = new fMonAn.Del(ShowDSMonAn);
                f.Show();
            }
        }
        public void ShowDSThanhVien()
        {
            string LoaiThanhVien = ((CBBItem)(this.cbbLoaiNV.SelectedItem)).Key;
            string txt = this.txtSearchNV.Text;
            this.dataNV.DataSource = BLL_QLNV.Instance.GetDSThanhVien(LoaiThanhVien, txt);
        }

        private void btnUpdateNV_Click(object sender, EventArgs e)
        {
            if(this.dataNV.SelectedRows.Count == 1)
            {
                string TenDN = this.dataNV.SelectedRows[0].Cells["TenDangNhap"].Value.ToString();
                fNhanVien f = new fNhanVien(TenDN);
                f.D = new fNhanVien.Del(ShowDSThanhVien);
                f.Show();
            }
        }
        private void btnAddNV_Click(object sender, EventArgs e)
        {
            fNhanVien f = new fNhanVien("");
            f.D = new fNhanVien.Del(ShowDSThanhVien);
            f.Show();
        }
        private void btnDelNV_Click(object sender, EventArgs e)
        {
            if (this.dataNV.SelectedRows.Count == 1)
            {
                string TenDN = this.dataNV.SelectedRows[0].Cells["TenDangNhap"].Value.ToString();
                BLL_QLNV.Instance.DeleteThanhVien(TenDN);
                string LoaiThanhVien = ((CBBItem)(this.cbbLoaiNV.SelectedItem)).Key;
                string txt = this.txtSearchNV.Text;
                ShowDSThanhVien();
            }
        }

        private void btnSearchNV_Click(object sender, EventArgs e)
        {
            ShowDSThanhVien();
        }

        private void cbbLoaiNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbbLoaiMonAn.SelectedIndex >= 0)
            {
                string LoaiThanhVien = ((CBBItem)(this.cbbLoaiNV.SelectedItem)).Key;
                string txt = this.txtSearchNV.Text;
                ShowDSThanhVien();
            }
        }
        public void ShowDSHoaDon()
        {
            this.dataHoaDon.DataSource = BLL_QLHoaDon.Instance.GetAllHoaDon();
        }
        private void btnThK_Click(object sender, EventArgs e)
        {
            if (this.dateStart.Value.CompareTo(this.dateEnd.Value) != 1)
            {
                DateTime dateStart = this.dateStart.Value;
                DateTime dateEnd = this.dateEnd.Value;
                this.dataHoaDon.DataSource = BLL_QLHoaDon.Instance.GetDSHoaDon(dateStart, dateEnd);
            }
        }
    }
}

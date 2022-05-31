using SourceCodePBL3.BLL;
using SourceCodePBL3.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SourceCodePBL3.GUI
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            LoadComboBox();
            ShowDSMonAn("All", "");
        }
        public void LoadComboBox()
        {
            this.cbbLoaiMonAn.Items.Add(new CBBItem { Key = "All", Value = "All" });
            this.cbbLoaiMonAn.Items.AddRange(BLL_QLMonAn.Instance.GetLoaiMonAn().ToArray());
            this.cbbLoaiMonAn.SelectedIndex = 0;
            this.cbbLoaiNV.Items.AddRange(new CBBItem[] 
            {
                 new CBBItem { Key = "All", Value = "All" },
                 new CBBItem { Key = "NHANVIEN", Value = "Nhan vien" },
                 new CBBItem { Key = "ADMIN", Value = "Admin" },
            });

        }
        public void ShowDSMonAn(string MaLoaiMonAn, string txt)
        {
            this.dataMonAn.DataSource = BLL_QLMonAn.Instance.GetDSMonAn(MaLoaiMonAn, txt);
        }
        private void cbbLoaiMonAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.cbbLoaiMonAn.SelectedIndex >= 0)
            {
                string MaLoai = ((CBBItem)(this.cbbLoaiMonAn.SelectedItem)).Key;
                string txt = this.txtSearchMA.Text;
                ShowDSMonAn(MaLoai, txt);
            }
        }

        private void btnDelMonAn_Click(object sender, EventArgs e)
        {
            if(this.dataMonAn.SelectedRows.Count == 1)
            {
                string MaMonAn = this.dataMonAn.SelectedRows[0].Cells["MaMonAn"].Value.ToString();
                BLL_QLMonAn.Instance.DeleteMA(MaMonAn);
                string MaLoai = ((CBBItem)(this.cbbLoaiMonAn.SelectedItem)).Key;
                string txt = this.txtSearchMA.Text;
                ShowDSMonAn(MaLoai, txt);
            }
        }

        private void btnSearchMonAn_Click(object sender, EventArgs e)
        {
            string MaLoai = ((CBBItem)(this.cbbLoaiMonAn.SelectedItem)).Key;
            string txt = this.txtSearchMA.Text;
            ShowDSMonAn(MaLoai, txt);
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
        public void ShowDSThanhVien(string MaLoaiMonAn, string txt)
        {
            this.dataMonAn.DataSource = BLL_QLMonAn.Instance.GetDSMonAn(MaLoaiMonAn, txt);
        }

        private void btnUpdateNV_Click(object sender, EventArgs e)
        {

        }

        private void btnAddNV_Click(object sender, EventArgs e)
        {

        }

        private void btnDelNV_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchNV_Click(object sender, EventArgs e)
        {

        }
    }
}

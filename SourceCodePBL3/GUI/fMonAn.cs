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
    public partial class fMonAn : Form
    {
        public delegate void Del(string MaLoaiMonAn, string txt);
        public string MaMonAn { get; set; }
        public Del MyDel;
        public fMonAn(string MaMonAn)
        {
            InitializeComponent();
            this.MaMonAn = MaMonAn;
            this.cbbLoaiMonAn.Items.AddRange(BLL_QLMonAn.Instance.GetLoaiMonAn().ToArray());
            SetGUI();
        }
        public void SetGUI()
        {
            if(BLL_QLMonAn.Instance.GetMonAnByMaMonAn(this.MaMonAn) != null)
            {
                MonAn MA = new MonAn(BLL_QLMonAn.Instance.GetMonAnByMaMonAn(this.MaMonAn));
                foreach (CBBItem i in this.cbbLoaiMonAn.Items)
                {
                    if (i.Key.Equals(MA.MaLoaiMonAn))
                    {
                        this.cbbLoaiMonAn.Text = i.Value;
                        break;
                    }
                }
                this.txtMaMonAn.Text = MA.MaMonAn;
                this.txtMaMonAn.Enabled = false;
                this.txtTenMonAn.Text = MA.TenMonAn;
                this.txtGiaTien.Text = MA.GiaTien + "";
            }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            MonAn MA = new MonAn
            {
                MaLoaiMonAn = ((CBBItem)this.cbbLoaiMonAn.SelectedItem).Key,
                MaMonAn = this.txtMaMonAn.Text,
                TenMonAn = this.txtTenMonAn.Text,
                GiaTien = Convert.ToDecimal(this.txtGiaTien.Text)
            };
            BLL_QLMonAn.Instance.AddUpdateMA(MA);
            MyDel("All", "");
        }
        private void btnCancle_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.None, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                this.Dispose();
            }
        }
    }
}

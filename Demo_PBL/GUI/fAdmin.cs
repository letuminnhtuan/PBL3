using Demo_PBL.BLL;
using Demo_PBL.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_PBL.GUI
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            LoadComboBox();
            LoadDTGNV();
        }
        public void LoadComboBox()
        {
            foreach(CBBItem i in BLL_Demo.Instance.ListLoaiMonAn())
            {
                this.cbbLoaiMonAn.Items.Add(i);
            }
        }
        public void LoadDTGNV()
        {
            this.dataMonAn.DataSource = BLL_Demo.Instance.TimMA(this.txtSearchMA.Text);
        }
        private void btnUpdateNV_Click(object sender, EventArgs e)
        {

        }

        private void btnDelNV_Click(object sender, EventArgs e)
        {

        }

        private void btnAddNV_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchTK_Click(object sender, EventArgs e)
        {
            string str = this.txtSearchTK.Text;
            this.dataTK.DataSource = BLL_Demo.Instance.GetTK(str);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.comboBox2.SelectedIndex >= 0)
            {
                this.dateStart.Enabled = !this.dateStart.Enabled;
                this.dateEnd.Enabled = !this.dateEnd.Enabled;
            }
        }

        private void btnThK_Click(object sender, EventArgs e)
        {
            string dateStart = "";
            string dateEnd = "";
            if(this.comboBox2.SelectedIndex == 1)
            {
                dateStart = this.dateStart.Text;
                dateEnd = this.dateEnd.Text;
            }
            if (this.comboBox2.SelectedIndex >= 0) this.dataHoaDon.DataSource = BLL_Demo.Instance.GetHD(this.comboBox2.SelectedIndex, dateStart, dateEnd);
        }

        private void dataMonAn_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(this.dataMonAn.SelectedRows.Count == 1)
            {
                string MaMonAn = this.dataMonAn.SelectedRows[0].Cells["MaMonAn"].Value.ToString();
                this.txtMaMonAn.Text = MaMonAn;
                this.txtMaMonAn.Enabled = false;
                string MaLoai = BLL_Demo.Instance.GetMA(MaMonAn).Rows[0]["MaLoaiMonAn"].ToString();
                foreach(CBBItem i in BLL_Demo.Instance.ListLoaiMonAn())
                {
                    if(i.Key.Equals(MaLoai))
                    {
                        this.cbbLoaiMonAn.Text = i.Value;
                        break;
                    }
                }
                this.txtTenMonAn.Text = BLL_Demo.Instance.GetMA(MaMonAn).Rows[0]["TenMonAn"].ToString();
                this.txtGiaTien.Text = BLL_Demo.Instance.GetMA(MaMonAn).Rows[0]["GiaTien"].ToString();
            }
        }

        private void BTN_Add_Update(object sender, EventArgs e)
        {
            MonAn ma = new MonAn
            {
                MaLoaiMonAn = this.cbbLoaiMonAn.Text,
                MaMonAn = this.txtMaMonAn.Text,
                TenMonAn = this.txtTenMonAn.Text,
                GiaTien = Convert.ToInt32(this.txtGiaTien.Text),
            };
            BLL_Demo.Instance.Add_UpdateMonAn(ma);
            LoadDTGNV();
        }
    }
}

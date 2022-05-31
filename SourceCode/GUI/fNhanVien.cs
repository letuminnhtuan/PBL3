﻿using SourceCode.BLL;
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
    public partial class fNhanVien : Form
    {
        public delegate void Del();
        public Del D;
        private string TenDangNhap;
        public fNhanVien(string TenDangNhap)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            this.TenDangNhap = TenDangNhap;
            this.cbbLoaiNhanVien.Items.Add(new CBBItem { Key = "ADMIN", Value = "Quan li" });
            this.cbbLoaiNhanVien.Items.Add(new CBBItem { Key = "NHANVIEN", Value = "Nhan vien" });
            SetGUI();
        }
        public void SetGUI()
        {
            if(BLL_QLNV.Instance.GetThanhVienByTenDangNhap(this.TenDangNhap) != null)
            {
                foreach(CBBItem i in this.cbbLoaiNhanVien.Items)
                {
                    if (i.Key.Equals(BLL_QLNV.Instance.GetThanhVienByTenDangNhap(this.TenDangNhap).LoaiThanhVien))
                    {
                        this.cbbLoaiNhanVien.SelectedItem = i;
                        break;
                    }
                }
                this.txtTenNhanVien.Text = BLL_QLNV.Instance.GetThanhVienByTenDangNhap(this.TenDangNhap).TenThanhVien;
                this.txtTK.Text = BLL_QLNV.Instance.GetThanhVienByTenDangNhap(this.TenDangNhap).TenDangNhap;
                this.txtTK.Enabled = false;
                this.txtMK.Text = BLL_QLNV.Instance.GetThanhVienByTenDangNhap(this.TenDangNhap).MatKhau;
                this.txtLuong.Text = BLL_QLNV.Instance.GetThanhVienByTenDangNhap(this.TenDangNhap).Luong.ToString();
                this.dateLamViec.Value = BLL_QLNV.Instance.GetThanhVienByTenDangNhap(this.TenDangNhap).NgayLamViec;
                this.txtSDT.Text = BLL_QLNV.Instance.GetThanhVienByTenDangNhap(this.TenDangNhap).SDT;
            }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            ThanhVien data = new ThanhVien
            {
                TenDangNhap = this.txtTK.Text,
                MatKhau = this.txtMK.Text,
                LoaiThanhVien = ((CBBItem)this.cbbLoaiNhanVien.SelectedItem).Key,
                TenThanhVien = this.txtTenNhanVien.Text,
                Luong = Convert.ToDecimal(this.txtLuong.Text),
                SDT = this.txtSDT.Text,
                NgayLamViec = this.dateLamViec.Value,
            };
            BLL_QLNV.Instance.AddUpdateThanhVien(data);
            D();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.None, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                this.Dispose();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.txtMK.UseSystemPasswordChar = !this.txtMK.UseSystemPasswordChar;
        }
    }
}
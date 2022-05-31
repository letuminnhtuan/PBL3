using SourceCodePBL3.BLL;
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
    public partial class fLogin : Form
    {
        public fLogin()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = this.txtUser.Text;
            string pass = this.txtPass.Text;
            if(BLL_QLNhanVien.Instance.LogIn(username, pass) != null)
            {
                string Role = BLL_QLNhanVien.Instance.LogIn(username, pass).LoaiThanhVien;
                fMain f = new fMain(Role);
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sai thông tin đăng nhập!");
            }
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.None, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                this.Dispose();
            }
        }
        private void checkMK_CheckedChanged(object sender, EventArgs e)
        {
            this.txtPass.UseSystemPasswordChar = !this.txtPass.UseSystemPasswordChar;
        }
    }
}

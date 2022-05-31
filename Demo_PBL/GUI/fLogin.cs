using Demo_PBL.BLL;
using Demo_PBL.DAL;
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
    public partial class fLogin : Form
    {
        public fLogin()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (this.txtUser.Text != "" && this.txtPass.Text != "")
            {
                if (BLL_Demo.Instance.LogIn(this.txtUser.Text, this.txtPass.Text))
                {
                    string str = BLL_Demo.Instance.Role(this.txtUser.Text);
                    fMain f = new fMain(str);
                    f.ShowDialog();
                }
                else MessageBox.Show("Kiểm tra lại tài khoản, mật khẩu");
            }
            else MessageBox.Show("Không để trống tài khoản, mật khẩu");
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.None, MessageBoxDefaultButton.Button2) == DialogResult.OK)
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

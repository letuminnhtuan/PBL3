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
    public partial class fMain : Form
    {
        string Role = "";
        public fMain(string str)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            this.Role = str;
            if (!this.Role.Equals("ADMIN") && this.Role != null) this.menuQL.Enabled = false;
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
    }
}

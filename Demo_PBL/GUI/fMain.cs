using Demo_PBL.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_PBL
{
    public partial class fMain : Form
    {
        string VaiTro;
        public fMain(string str)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            this.VaiTro = str;
            if (!str.Equals("ADMIN")) this.menuQL.Enabled = false;
        }

        private void Infor_Click(object sender, EventArgs e)
        {

        }

        private void menuQL_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            f.ShowDialog();
        }
    }
}


namespace SourceCode.GUI
{
    partial class fMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuQL = new System.Windows.Forms.ToolStripMenuItem();
            this.Account = new System.Windows.Forms.ToolStripMenuItem();
            this.Infor = new System.Windows.Forms.ToolStripMenuItem();
            this.LogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlBill = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtThe = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataDatMon = new System.Windows.Forms.DataGridView();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.cbbLoaiMonAn = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbMonAn = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numMon = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbThanhToan = new System.Windows.Forms.ComboBox();
            this.btnHoanThanh = new System.Windows.Forms.Button();
            this.colTenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiaTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.menuStrip1.SuspendLayout();
            this.pnlBill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDatMon)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMon)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuQL,
            this.Account});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1143, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuQL
            // 
            this.menuQL.Name = "menuQL";
            this.menuQL.Size = new System.Drawing.Size(72, 25);
            this.menuQL.Text = "Quản lí";
            this.menuQL.Click += new System.EventHandler(this.menuQL_Click);
            // 
            // Account
            // 
            this.Account.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Infor,
            this.LogOut});
            this.Account.Name = "Account";
            this.Account.Size = new System.Drawing.Size(87, 25);
            this.Account.Text = "Tài khoản";
            // 
            // Infor
            // 
            this.Infor.Name = "Infor";
            this.Infor.Size = new System.Drawing.Size(150, 26);
            this.Infor.Text = "Thông tin";
            // 
            // LogOut
            // 
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(150, 26);
            this.LogOut.Text = "Đăng xuất";
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // pnlBill
            // 
            this.pnlBill.Controls.Add(this.dateTimePicker1);
            this.pnlBill.Controls.Add(this.label6);
            this.pnlBill.Controls.Add(this.txtThe);
            this.pnlBill.Controls.Add(this.label4);
            this.pnlBill.Controls.Add(this.txtTien);
            this.pnlBill.Controls.Add(this.label3);
            this.pnlBill.Controls.Add(this.dataDatMon);
            this.pnlBill.Location = new System.Drawing.Point(605, 145);
            this.pnlBill.Margin = new System.Windows.Forms.Padding(2);
            this.pnlBill.Name = "pnlBill";
            this.pnlBill.Size = new System.Drawing.Size(531, 436);
            this.pnlBill.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(425, 6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(97, 22);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(294, 8);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Ngày thanh toán";
            // 
            // txtThe
            // 
            this.txtThe.Enabled = false;
            this.txtThe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThe.Location = new System.Drawing.Point(71, 5);
            this.txtThe.Name = "txtThe";
            this.txtThe.Size = new System.Drawing.Size(45, 26);
            this.txtThe.TabIndex = 7;
            this.txtThe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 8);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Thẻ số:";
            // 
            // txtTien
            // 
            this.txtTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTien.Location = new System.Drawing.Point(380, 408);
            this.txtTien.Margin = new System.Windows.Forms.Padding(2);
            this.txtTien.Name = "txtTien";
            this.txtTien.Size = new System.Drawing.Size(143, 26);
            this.txtTien.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(286, 408);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tổng tiền";
            // 
            // dataDatMon
            // 
            this.dataDatMon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataDatMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDatMon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTenMon,
            this.colSoLuong,
            this.colGiaTien,
            this.colDel});
            this.dataDatMon.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataDatMon.Location = new System.Drawing.Point(6, 32);
            this.dataDatMon.Margin = new System.Windows.Forms.Padding(2);
            this.dataDatMon.Name = "dataDatMon";
            this.dataDatMon.RowHeadersWidth = 51;
            this.dataDatMon.RowTemplate.Height = 24;
            this.dataDatMon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataDatMon.Size = new System.Drawing.Size(516, 372);
            this.dataDatMon.TabIndex = 0;
            this.dataDatMon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataDatMon_CellContentClick);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(410, 68);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(112, 34);
            this.btnConfirm.TabIndex = 5;
            this.btnConfirm.Text = "Xác nhận";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.Location = new System.Drawing.Point(841, 584);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(112, 33);
            this.btnOrder.TabIndex = 2;
            this.btnOrder.Text = "Đặt món";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancle.Location = new System.Drawing.Point(725, 584);
            this.btnCancle.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(112, 33);
            this.btnCancle.TabIndex = 3;
            this.btnCancle.Text = "Hủy";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.button4);
            this.flowLayoutPanel1.Controls.Add(this.button5);
            this.flowLayoutPanel1.Controls.Add(this.button6);
            this.flowLayoutPanel1.Controls.Add(this.button7);
            this.flowLayoutPanel1.Controls.Add(this.button8);
            this.flowLayoutPanel1.Controls.Add(this.button9);
            this.flowLayoutPanel1.Controls.Add(this.button10);
            this.flowLayoutPanel1.Controls.Add(this.button11);
            this.flowLayoutPanel1.Controls.Add(this.button12);
            this.flowLayoutPanel1.Controls.Add(this.button13);
            this.flowLayoutPanel1.Controls.Add(this.button14);
            this.flowLayoutPanel1.Controls.Add(this.button15);
            this.flowLayoutPanel1.Controls.Add(this.button16);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 32);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(588, 587);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 140);
            this.button1.TabIndex = 0;
            this.button1.Text = "B1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Order);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PaleGreen;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(149, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 140);
            this.button2.TabIndex = 1;
            this.button2.Text = "B2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Order);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.PaleGreen;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(295, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 140);
            this.button3.TabIndex = 2;
            this.button3.Text = "B3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Order);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.PaleGreen;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(441, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(140, 140);
            this.button4.TabIndex = 3;
            this.button4.Text = "B4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Order);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.PaleGreen;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(3, 149);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(140, 140);
            this.button5.TabIndex = 4;
            this.button5.Text = "B5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.Order);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.PaleGreen;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(149, 149);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(140, 140);
            this.button6.TabIndex = 5;
            this.button6.Text = "B6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.Order);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.PaleGreen;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(295, 149);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(140, 140);
            this.button7.TabIndex = 6;
            this.button7.Text = "B7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.Order);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.PaleGreen;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(441, 149);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(140, 140);
            this.button8.TabIndex = 7;
            this.button8.Text = "B8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.Order);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.PaleGreen;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(3, 295);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(140, 140);
            this.button9.TabIndex = 8;
            this.button9.Text = "B9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.Order);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.PaleGreen;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(149, 295);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(140, 140);
            this.button10.TabIndex = 9;
            this.button10.Text = "B10";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.Order);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.PaleGreen;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(295, 295);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(140, 140);
            this.button11.TabIndex = 10;
            this.button11.Text = "B11";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.Order);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.PaleGreen;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(441, 295);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(140, 140);
            this.button12.TabIndex = 11;
            this.button12.Text = "B12";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.Order);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.PaleGreen;
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(3, 441);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(140, 140);
            this.button13.TabIndex = 12;
            this.button13.Text = "B13";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.Order);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.PaleGreen;
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(149, 441);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(140, 140);
            this.button14.TabIndex = 13;
            this.button14.Text = "B14";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.Order);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.PaleGreen;
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.Location = new System.Drawing.Point(295, 441);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(140, 140);
            this.button15.TabIndex = 14;
            this.button15.Text = "B15";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.Order);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.PaleGreen;
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.Location = new System.Drawing.Point(441, 441);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(140, 140);
            this.button16.TabIndex = 15;
            this.button16.Text = "B16";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.Order);
            // 
            // cbbLoaiMonAn
            // 
            this.cbbLoaiMonAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbLoaiMonAn.FormattingEnabled = true;
            this.cbbLoaiMonAn.Location = new System.Drawing.Point(161, 6);
            this.cbbLoaiMonAn.Margin = new System.Windows.Forms.Padding(2);
            this.cbbLoaiMonAn.Name = "cbbLoaiMonAn";
            this.cbbLoaiMonAn.Size = new System.Drawing.Size(361, 28);
            this.cbbLoaiMonAn.TabIndex = 0;
            this.cbbLoaiMonAn.SelectedIndexChanged += new System.EventHandler(this.cbbLoaiMonAn_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Loại món ăn";
            // 
            // cbbMonAn
            // 
            this.cbbMonAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMonAn.FormattingEnabled = true;
            this.cbbMonAn.Location = new System.Drawing.Point(161, 37);
            this.cbbMonAn.Margin = new System.Windows.Forms.Padding(2);
            this.cbbMonAn.Name = "cbbMonAn";
            this.cbbMonAn.Size = new System.Drawing.Size(361, 28);
            this.cbbMonAn.TabIndex = 2;
            this.cbbMonAn.SelectedIndexChanged += new System.EventHandler(this.cbbMonAn_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Món ăn";
            // 
            // numMon
            // 
            this.numMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numMon.Location = new System.Drawing.Point(161, 74);
            this.numMon.Margin = new System.Windows.Forms.Padding(2);
            this.numMon.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numMon.Name = "numMon";
            this.numMon.Size = new System.Drawing.Size(73, 26);
            this.numMon.TabIndex = 4;
            this.numMon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnConfirm);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.numMon);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbbMonAn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbbLoaiMonAn);
            this.panel1.Location = new System.Drawing.Point(605, 32);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(531, 109);
            this.panel1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 73);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Số lượng đặt";
            // 
            // cbbThanhToan
            // 
            this.cbbThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbThanhToan.FormattingEnabled = true;
            this.cbbThanhToan.Items.AddRange(new object[] {
            "Truc tiep",
            "Chuyen khoang"});
            this.cbbThanhToan.Location = new System.Drawing.Point(957, 586);
            this.cbbThanhToan.Margin = new System.Windows.Forms.Padding(2);
            this.cbbThanhToan.Name = "cbbThanhToan";
            this.cbbThanhToan.Size = new System.Drawing.Size(179, 28);
            this.cbbThanhToan.TabIndex = 6;
            // 
            // btnHoanThanh
            // 
            this.btnHoanThanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoanThanh.Location = new System.Drawing.Point(609, 584);
            this.btnHoanThanh.Margin = new System.Windows.Forms.Padding(2);
            this.btnHoanThanh.Name = "btnHoanThanh";
            this.btnHoanThanh.Size = new System.Drawing.Size(112, 33);
            this.btnHoanThanh.TabIndex = 10;
            this.btnHoanThanh.Text = "Hoàn thành";
            this.btnHoanThanh.UseVisualStyleBackColor = true;
            this.btnHoanThanh.Click += new System.EventHandler(this.btnHoanThanh_Click);
            // 
            // colTenMon
            // 
            this.colTenMon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenMon.FillWeight = 124.7772F;
            this.colTenMon.HeaderText = "Tên món";
            this.colTenMon.MinimumWidth = 6;
            this.colTenMon.Name = "colTenMon";
            // 
            // colSoLuong
            // 
            this.colSoLuong.FillWeight = 124.7772F;
            this.colSoLuong.HeaderText = "Số lượng";
            this.colSoLuong.MinimumWidth = 6;
            this.colSoLuong.Name = "colSoLuong";
            // 
            // colGiaTien
            // 
            this.colGiaTien.FillWeight = 124.7772F;
            this.colGiaTien.HeaderText = "Giá tiền";
            this.colGiaTien.MinimumWidth = 6;
            this.colGiaTien.Name = "colGiaTien";
            // 
            // colDel
            // 
            this.colDel.FillWeight = 25.66845F;
            this.colDel.HeaderText = "-";
            this.colDel.MinimumWidth = 6;
            this.colDel.Name = "colDel";
            this.colDel.Text = "-";
            this.colDel.UseColumnTextForButtonValue = true;
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 625);
            this.Controls.Add(this.btnHoanThanh);
            this.Controls.Add(this.cbbThanhToan);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.pnlBill);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fMain";
            this.Text = "fMain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlBill.ResumeLayout(false);
            this.pnlBill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDatMon)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numMon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuQL;
        private System.Windows.Forms.ToolStripMenuItem Account;
        private System.Windows.Forms.ToolStripMenuItem Infor;
        private System.Windows.Forms.ToolStripMenuItem LogOut;
        private System.Windows.Forms.Panel pnlBill;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.TextBox txtTien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataDatMon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.TextBox txtThe;
        private System.Windows.Forms.ComboBox cbbLoaiMonAn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbMonAn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.NumericUpDown numMon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbThanhToan;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnHoanThanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaTien;
        private System.Windows.Forms.DataGridViewButtonColumn colDel;
    }
}


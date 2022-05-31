
namespace SourceCodePBL3.GUI
{
    partial class fAdmin
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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbLoaiNV = new System.Windows.Forms.ComboBox();
            this.btnSearchNV = new System.Windows.Forms.Button();
            this.txtSearchNV = new System.Windows.Forms.TextBox();
            this.btnAddNV = new System.Windows.Forms.Button();
            this.btnUpdateNV = new System.Windows.Forms.Button();
            this.btnDelNV = new System.Windows.Forms.Button();
            this.btnSortNV = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataNV = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbLoaiMonAn = new System.Windows.Forms.ComboBox();
            this.btnAddMonAn = new System.Windows.Forms.Button();
            this.btnUpdateMonAn = new System.Windows.Forms.Button();
            this.btnDelMonAn = new System.Windows.Forms.Button();
            this.btnSortMonAn = new System.Windows.Forms.Button();
            this.cbbSortMonAn = new System.Windows.Forms.ComboBox();
            this.btnSearchMonAn = new System.Windows.Forms.Button();
            this.txtSearchMA = new System.Windows.Forms.TextBox();
            this.dataMonAn = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThK = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dataHoaDon = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataNV)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataMonAn)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataHoaDon)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.cbbLoaiNV);
            this.tabPage3.Controls.Add(this.btnSearchNV);
            this.tabPage3.Controls.Add(this.txtSearchNV);
            this.tabPage3.Controls.Add(this.btnAddNV);
            this.tabPage3.Controls.Add(this.btnUpdateNV);
            this.tabPage3.Controls.Add(this.btnDelNV);
            this.tabPage3.Controls.Add(this.btnSortNV);
            this.tabPage3.Controls.Add(this.comboBox1);
            this.tabPage3.Controls.Add(this.dataNV);
            this.tabPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 35);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1303, 659);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Nhân viên";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 14);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 25);
            this.label5.TabIndex = 33;
            this.label5.Text = "Loại nhân viên";
            // 
            // cbbLoaiNV
            // 
            this.cbbLoaiNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbLoaiNV.FormattingEnabled = true;
            this.cbbLoaiNV.Location = new System.Drawing.Point(159, 10);
            this.cbbLoaiNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbLoaiNV.Name = "cbbLoaiNV";
            this.cbbLoaiNV.Size = new System.Drawing.Size(265, 33);
            this.cbbLoaiNV.TabIndex = 32;
            // 
            // btnSearchNV
            // 
            this.btnSearchNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchNV.Location = new System.Drawing.Point(1163, 6);
            this.btnSearchNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchNV.Name = "btnSearchNV";
            this.btnSearchNV.Size = new System.Drawing.Size(128, 39);
            this.btnSearchNV.TabIndex = 31;
            this.btnSearchNV.Text = "Tìm kiếm";
            this.btnSearchNV.UseVisualStyleBackColor = true;
            this.btnSearchNV.Click += new System.EventHandler(this.btnSearchNV_Click);
            // 
            // txtSearchNV
            // 
            this.txtSearchNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchNV.Location = new System.Drawing.Point(884, 10);
            this.txtSearchNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchNV.Name = "txtSearchNV";
            this.txtSearchNV.Size = new System.Drawing.Size(273, 30);
            this.txtSearchNV.TabIndex = 30;
            // 
            // btnAddNV
            // 
            this.btnAddNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNV.Location = new System.Drawing.Point(484, 613);
            this.btnAddNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddNV.Name = "btnAddNV";
            this.btnAddNV.Size = new System.Drawing.Size(128, 39);
            this.btnAddNV.TabIndex = 29;
            this.btnAddNV.Text = "Thêm";
            this.btnAddNV.UseVisualStyleBackColor = true;
            this.btnAddNV.Click += new System.EventHandler(this.btnAddNV_Click);
            // 
            // btnUpdateNV
            // 
            this.btnUpdateNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateNV.Location = new System.Drawing.Point(617, 613);
            this.btnUpdateNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateNV.Name = "btnUpdateNV";
            this.btnUpdateNV.Size = new System.Drawing.Size(128, 39);
            this.btnUpdateNV.TabIndex = 28;
            this.btnUpdateNV.Text = "Cập nhập";
            this.btnUpdateNV.UseVisualStyleBackColor = true;
            this.btnUpdateNV.Click += new System.EventHandler(this.btnUpdateNV_Click);
            // 
            // btnDelNV
            // 
            this.btnDelNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelNV.Location = new System.Drawing.Point(751, 613);
            this.btnDelNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelNV.Name = "btnDelNV";
            this.btnDelNV.Size = new System.Drawing.Size(128, 39);
            this.btnDelNV.TabIndex = 27;
            this.btnDelNV.Text = "Xóa";
            this.btnDelNV.UseVisualStyleBackColor = true;
            this.btnDelNV.Click += new System.EventHandler(this.btnDelNV_Click);
            // 
            // btnSortNV
            // 
            this.btnSortNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortNV.Location = new System.Drawing.Point(1163, 613);
            this.btnSortNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSortNV.Name = "btnSortNV";
            this.btnSortNV.Size = new System.Drawing.Size(128, 39);
            this.btnSortNV.TabIndex = 26;
            this.btnSortNV.Text = "Sắp xếp";
            this.btnSortNV.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(884, 615);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(273, 33);
            this.comboBox1.TabIndex = 25;
            // 
            // dataNV
            // 
            this.dataNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataNV.Location = new System.Drawing.Point(3, 50);
            this.dataNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataNV.Name = "dataNV";
            this.dataNV.RowHeadersWidth = 51;
            this.dataNV.RowTemplate.Height = 24;
            this.dataNV.Size = new System.Drawing.Size(1289, 558);
            this.dataNV.TabIndex = 16;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.cbbLoaiMonAn);
            this.tabPage2.Controls.Add(this.btnAddMonAn);
            this.tabPage2.Controls.Add(this.btnUpdateMonAn);
            this.tabPage2.Controls.Add(this.btnDelMonAn);
            this.tabPage2.Controls.Add(this.btnSortMonAn);
            this.tabPage2.Controls.Add(this.cbbSortMonAn);
            this.tabPage2.Controls.Add(this.btnSearchMonAn);
            this.tabPage2.Controls.Add(this.txtSearchMA);
            this.tabPage2.Controls.Add(this.dataMonAn);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 35);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1303, 659);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Món ăn";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 14);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Loại món ăn";
            // 
            // cbbLoaiMonAn
            // 
            this.cbbLoaiMonAn.FormattingEnabled = true;
            this.cbbLoaiMonAn.Location = new System.Drawing.Point(141, 9);
            this.cbbLoaiMonAn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbLoaiMonAn.Name = "cbbLoaiMonAn";
            this.cbbLoaiMonAn.Size = new System.Drawing.Size(265, 33);
            this.cbbLoaiMonAn.TabIndex = 17;
            this.cbbLoaiMonAn.SelectedIndexChanged += new System.EventHandler(this.cbbLoaiMonAn_SelectedIndexChanged);
            // 
            // btnAddMonAn
            // 
            this.btnAddMonAn.Location = new System.Drawing.Point(483, 610);
            this.btnAddMonAn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddMonAn.Name = "btnAddMonAn";
            this.btnAddMonAn.Size = new System.Drawing.Size(128, 39);
            this.btnAddMonAn.TabIndex = 16;
            this.btnAddMonAn.Text = "Thêm";
            this.btnAddMonAn.UseVisualStyleBackColor = true;
            this.btnAddMonAn.Click += new System.EventHandler(this.btnAddMonAn_Click);
            // 
            // btnUpdateMonAn
            // 
            this.btnUpdateMonAn.Location = new System.Drawing.Point(616, 610);
            this.btnUpdateMonAn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateMonAn.Name = "btnUpdateMonAn";
            this.btnUpdateMonAn.Size = new System.Drawing.Size(128, 39);
            this.btnUpdateMonAn.TabIndex = 15;
            this.btnUpdateMonAn.Text = "Cập nhập";
            this.btnUpdateMonAn.UseVisualStyleBackColor = true;
            this.btnUpdateMonAn.Click += new System.EventHandler(this.btnUpdateMonAn_Click);
            // 
            // btnDelMonAn
            // 
            this.btnDelMonAn.Location = new System.Drawing.Point(749, 610);
            this.btnDelMonAn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelMonAn.Name = "btnDelMonAn";
            this.btnDelMonAn.Size = new System.Drawing.Size(128, 39);
            this.btnDelMonAn.TabIndex = 14;
            this.btnDelMonAn.Text = "Xóa";
            this.btnDelMonAn.UseVisualStyleBackColor = true;
            this.btnDelMonAn.Click += new System.EventHandler(this.btnDelMonAn_Click);
            // 
            // btnSortMonAn
            // 
            this.btnSortMonAn.Location = new System.Drawing.Point(1161, 610);
            this.btnSortMonAn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSortMonAn.Name = "btnSortMonAn";
            this.btnSortMonAn.Size = new System.Drawing.Size(128, 39);
            this.btnSortMonAn.TabIndex = 12;
            this.btnSortMonAn.Text = "Sắp xếp";
            this.btnSortMonAn.UseVisualStyleBackColor = true;
            // 
            // cbbSortMonAn
            // 
            this.cbbSortMonAn.FormattingEnabled = true;
            this.cbbSortMonAn.Location = new System.Drawing.Point(883, 613);
            this.cbbSortMonAn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbSortMonAn.Name = "cbbSortMonAn";
            this.cbbSortMonAn.Size = new System.Drawing.Size(273, 33);
            this.cbbSortMonAn.TabIndex = 11;
            // 
            // btnSearchMonAn
            // 
            this.btnSearchMonAn.Location = new System.Drawing.Point(1161, 5);
            this.btnSearchMonAn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchMonAn.Name = "btnSearchMonAn";
            this.btnSearchMonAn.Size = new System.Drawing.Size(128, 39);
            this.btnSearchMonAn.TabIndex = 10;
            this.btnSearchMonAn.Text = "Tìm kiếm";
            this.btnSearchMonAn.UseVisualStyleBackColor = true;
            this.btnSearchMonAn.Click += new System.EventHandler(this.btnSearchMonAn_Click);
            // 
            // txtSearchMA
            // 
            this.txtSearchMA.Location = new System.Drawing.Point(883, 9);
            this.txtSearchMA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchMA.Name = "txtSearchMA";
            this.txtSearchMA.Size = new System.Drawing.Size(273, 30);
            this.txtSearchMA.TabIndex = 9;
            // 
            // dataMonAn
            // 
            this.dataMonAn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataMonAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMonAn.Location = new System.Drawing.Point(5, 49);
            this.dataMonAn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataMonAn.Name = "dataMonAn";
            this.dataMonAn.RowHeadersWidth = 51;
            this.dataMonAn.RowTemplate.Height = 24;
            this.dataMonAn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataMonAn.Size = new System.Drawing.Size(1284, 556);
            this.dataMonAn.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.comboBox2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btnThK);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.dataHoaDon);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 35);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1303, 659);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thống kê";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Tat ca",
            "Tim kiem"});
            this.comboBox2.Location = new System.Drawing.Point(885, 196);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(267, 33);
            this.comboBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(601, 614);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(251, 34);
            this.textBox1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(479, 619);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tổng tiền";
            // 
            // btnThK
            // 
            this.btnThK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThK.Location = new System.Drawing.Point(1160, 191);
            this.btnThK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThK.Name = "btnThK";
            this.btnThK.Size = new System.Drawing.Size(129, 43);
            this.btnThK.TabIndex = 2;
            this.btnThK.Text = "Thống kê";
            this.btnThK.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateEnd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateStart);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(857, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(432, 180);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thời gian:";
            // 
            // dateEnd
            // 
            this.dateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateEnd.Location = new System.Drawing.Point(119, 114);
            this.dateEnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(301, 30);
            this.dateEnd.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Đến ngày:";
            // 
            // dateStart
            // 
            this.dateStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateStart.Location = new System.Drawing.Point(119, 43);
            this.dateStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(301, 30);
            this.dateStart.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ ngày:";
            // 
            // dataHoaDon
            // 
            this.dataHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataHoaDon.Location = new System.Drawing.Point(3, 6);
            this.dataHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataHoaDon.Name = "dataHoaDon";
            this.dataHoaDon.RowHeadersWidth = 51;
            this.dataHoaDon.RowTemplate.Height = 24;
            this.dataHoaDon.Size = new System.Drawing.Size(849, 603);
            this.dataHoaDon.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1311, 698);
            this.tabControl1.TabIndex = 0;
            // 
            // fAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 722);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fAdmin";
            this.Text = "fAdmin";
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataNV)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataMonAn)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataHoaDon)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbLoaiNV;
        private System.Windows.Forms.Button btnSearchNV;
        private System.Windows.Forms.TextBox txtSearchNV;
        private System.Windows.Forms.Button btnAddNV;
        private System.Windows.Forms.Button btnUpdateNV;
        private System.Windows.Forms.Button btnDelNV;
        private System.Windows.Forms.Button btnSortNV;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataNV;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbLoaiMonAn;
        private System.Windows.Forms.Button btnAddMonAn;
        private System.Windows.Forms.Button btnUpdateMonAn;
        private System.Windows.Forms.Button btnDelMonAn;
        private System.Windows.Forms.Button btnSortMonAn;
        private System.Windows.Forms.ComboBox cbbSortMonAn;
        private System.Windows.Forms.Button btnSearchMonAn;
        private System.Windows.Forms.TextBox txtSearchMA;
        private System.Windows.Forms.DataGridView dataMonAn;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataHoaDon;
        private System.Windows.Forms.TabControl tabControl1;
    }
}

namespace SourceCode.GUI
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
            this.cbbSortMA = new System.Windows.Forms.ComboBox();
            this.dataNV = new System.Windows.Forms.DataGridView();
            this.PageMonAn = new System.Windows.Forms.TabPage();
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
            this.PageThongKe = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThK = new System.Windows.Forms.Button();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dataHoaDon = new System.Windows.Forms.DataGridView();
            this.PageNhanVien = new System.Windows.Forms.TabControl();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataNV)).BeginInit();
            this.PageMonAn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataMonAn)).BeginInit();
            this.PageThongKe.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataHoaDon)).BeginInit();
            this.PageNhanVien.SuspendLayout();
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
            this.tabPage3.Controls.Add(this.cbbSortMA);
            this.tabPage3.Controls.Add(this.dataNV);
            this.tabPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 31);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(975, 532);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Nhân viên";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 20);
            this.label5.TabIndex = 33;
            this.label5.Text = "Loại nhân viên";
            // 
            // cbbLoaiNV
            // 
            this.cbbLoaiNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbLoaiNV.FormattingEnabled = true;
            this.cbbLoaiNV.Location = new System.Drawing.Point(119, 8);
            this.cbbLoaiNV.Margin = new System.Windows.Forms.Padding(2);
            this.cbbLoaiNV.Name = "cbbLoaiNV";
            this.cbbLoaiNV.Size = new System.Drawing.Size(200, 28);
            this.cbbLoaiNV.TabIndex = 32;
            this.cbbLoaiNV.SelectedIndexChanged += new System.EventHandler(this.cbbLoaiNV_SelectedIndexChanged);
            // 
            // btnSearchNV
            // 
            this.btnSearchNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchNV.Location = new System.Drawing.Point(872, 5);
            this.btnSearchNV.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchNV.Name = "btnSearchNV";
            this.btnSearchNV.Size = new System.Drawing.Size(96, 32);
            this.btnSearchNV.TabIndex = 31;
            this.btnSearchNV.Text = "Tìm kiếm";
            this.btnSearchNV.UseVisualStyleBackColor = true;
            this.btnSearchNV.Click += new System.EventHandler(this.btnSearchNV_Click);
            // 
            // txtSearchNV
            // 
            this.txtSearchNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchNV.Location = new System.Drawing.Point(663, 8);
            this.txtSearchNV.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchNV.Name = "txtSearchNV";
            this.txtSearchNV.Size = new System.Drawing.Size(206, 26);
            this.txtSearchNV.TabIndex = 30;
            // 
            // btnAddNV
            // 
            this.btnAddNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNV.Location = new System.Drawing.Point(363, 498);
            this.btnAddNV.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddNV.Name = "btnAddNV";
            this.btnAddNV.Size = new System.Drawing.Size(96, 32);
            this.btnAddNV.TabIndex = 29;
            this.btnAddNV.Text = "Thêm";
            this.btnAddNV.UseVisualStyleBackColor = true;
            this.btnAddNV.Click += new System.EventHandler(this.btnAddNV_Click);
            // 
            // btnUpdateNV
            // 
            this.btnUpdateNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateNV.Location = new System.Drawing.Point(463, 498);
            this.btnUpdateNV.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateNV.Name = "btnUpdateNV";
            this.btnUpdateNV.Size = new System.Drawing.Size(96, 32);
            this.btnUpdateNV.TabIndex = 28;
            this.btnUpdateNV.Text = "Cập nhập";
            this.btnUpdateNV.UseVisualStyleBackColor = true;
            this.btnUpdateNV.Click += new System.EventHandler(this.btnUpdateNV_Click);
            // 
            // btnDelNV
            // 
            this.btnDelNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelNV.Location = new System.Drawing.Point(563, 498);
            this.btnDelNV.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelNV.Name = "btnDelNV";
            this.btnDelNV.Size = new System.Drawing.Size(96, 32);
            this.btnDelNV.TabIndex = 27;
            this.btnDelNV.Text = "Xóa";
            this.btnDelNV.UseVisualStyleBackColor = true;
            this.btnDelNV.Click += new System.EventHandler(this.btnDelNV_Click);
            // 
            // btnSortNV
            // 
            this.btnSortNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortNV.Location = new System.Drawing.Point(872, 498);
            this.btnSortNV.Margin = new System.Windows.Forms.Padding(2);
            this.btnSortNV.Name = "btnSortNV";
            this.btnSortNV.Size = new System.Drawing.Size(96, 32);
            this.btnSortNV.TabIndex = 26;
            this.btnSortNV.Text = "Sắp xếp";
            this.btnSortNV.UseVisualStyleBackColor = true;
            // 
            // cbbSortMA
            // 
            this.cbbSortMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSortMA.FormattingEnabled = true;
            this.cbbSortMA.Location = new System.Drawing.Point(663, 500);
            this.cbbSortMA.Margin = new System.Windows.Forms.Padding(2);
            this.cbbSortMA.Name = "cbbSortMA";
            this.cbbSortMA.Size = new System.Drawing.Size(206, 28);
            this.cbbSortMA.TabIndex = 25;
            // 
            // dataNV
            // 
            this.dataNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataNV.Location = new System.Drawing.Point(2, 41);
            this.dataNV.Margin = new System.Windows.Forms.Padding(2);
            this.dataNV.Name = "dataNV";
            this.dataNV.RowHeadersWidth = 51;
            this.dataNV.RowTemplate.Height = 24;
            this.dataNV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataNV.Size = new System.Drawing.Size(967, 453);
            this.dataNV.TabIndex = 16;
            // 
            // PageMonAn
            // 
            this.PageMonAn.Controls.Add(this.label4);
            this.PageMonAn.Controls.Add(this.cbbLoaiMonAn);
            this.PageMonAn.Controls.Add(this.btnAddMonAn);
            this.PageMonAn.Controls.Add(this.btnUpdateMonAn);
            this.PageMonAn.Controls.Add(this.btnDelMonAn);
            this.PageMonAn.Controls.Add(this.btnSortMonAn);
            this.PageMonAn.Controls.Add(this.cbbSortMonAn);
            this.PageMonAn.Controls.Add(this.btnSearchMonAn);
            this.PageMonAn.Controls.Add(this.txtSearchMA);
            this.PageMonAn.Controls.Add(this.dataMonAn);
            this.PageMonAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageMonAn.Location = new System.Drawing.Point(4, 31);
            this.PageMonAn.Margin = new System.Windows.Forms.Padding(2);
            this.PageMonAn.Name = "PageMonAn";
            this.PageMonAn.Padding = new System.Windows.Forms.Padding(2);
            this.PageMonAn.Size = new System.Drawing.Size(975, 532);
            this.PageMonAn.TabIndex = 1;
            this.PageMonAn.Text = "Món ăn";
            this.PageMonAn.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Loại món ăn";
            // 
            // cbbLoaiMonAn
            // 
            this.cbbLoaiMonAn.FormattingEnabled = true;
            this.cbbLoaiMonAn.Location = new System.Drawing.Point(106, 7);
            this.cbbLoaiMonAn.Margin = new System.Windows.Forms.Padding(2);
            this.cbbLoaiMonAn.Name = "cbbLoaiMonAn";
            this.cbbLoaiMonAn.Size = new System.Drawing.Size(200, 28);
            this.cbbLoaiMonAn.TabIndex = 17;
            this.cbbLoaiMonAn.SelectedIndexChanged += new System.EventHandler(this.cbbLoaiMonAn_SelectedIndexChanged);
            // 
            // btnAddMonAn
            // 
            this.btnAddMonAn.Location = new System.Drawing.Point(362, 496);
            this.btnAddMonAn.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddMonAn.Name = "btnAddMonAn";
            this.btnAddMonAn.Size = new System.Drawing.Size(96, 32);
            this.btnAddMonAn.TabIndex = 16;
            this.btnAddMonAn.Text = "Thêm";
            this.btnAddMonAn.UseVisualStyleBackColor = true;
            this.btnAddMonAn.Click += new System.EventHandler(this.btnAddMonAn_Click);
            // 
            // btnUpdateMonAn
            // 
            this.btnUpdateMonAn.Location = new System.Drawing.Point(462, 496);
            this.btnUpdateMonAn.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateMonAn.Name = "btnUpdateMonAn";
            this.btnUpdateMonAn.Size = new System.Drawing.Size(96, 32);
            this.btnUpdateMonAn.TabIndex = 15;
            this.btnUpdateMonAn.Text = "Cập nhập";
            this.btnUpdateMonAn.UseVisualStyleBackColor = true;
            this.btnUpdateMonAn.Click += new System.EventHandler(this.btnUpdateMonAn_Click);
            // 
            // btnDelMonAn
            // 
            this.btnDelMonAn.Location = new System.Drawing.Point(562, 496);
            this.btnDelMonAn.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelMonAn.Name = "btnDelMonAn";
            this.btnDelMonAn.Size = new System.Drawing.Size(96, 32);
            this.btnDelMonAn.TabIndex = 14;
            this.btnDelMonAn.Text = "Xóa";
            this.btnDelMonAn.UseVisualStyleBackColor = true;
            this.btnDelMonAn.Click += new System.EventHandler(this.btnDelMonAn_Click);
            // 
            // btnSortMonAn
            // 
            this.btnSortMonAn.Location = new System.Drawing.Point(871, 496);
            this.btnSortMonAn.Margin = new System.Windows.Forms.Padding(2);
            this.btnSortMonAn.Name = "btnSortMonAn";
            this.btnSortMonAn.Size = new System.Drawing.Size(96, 32);
            this.btnSortMonAn.TabIndex = 12;
            this.btnSortMonAn.Text = "Sắp xếp";
            this.btnSortMonAn.UseVisualStyleBackColor = true;
            // 
            // cbbSortMonAn
            // 
            this.cbbSortMonAn.FormattingEnabled = true;
            this.cbbSortMonAn.Location = new System.Drawing.Point(662, 498);
            this.cbbSortMonAn.Margin = new System.Windows.Forms.Padding(2);
            this.cbbSortMonAn.Name = "cbbSortMonAn";
            this.cbbSortMonAn.Size = new System.Drawing.Size(206, 28);
            this.cbbSortMonAn.TabIndex = 11;
            // 
            // btnSearchMonAn
            // 
            this.btnSearchMonAn.Location = new System.Drawing.Point(871, 4);
            this.btnSearchMonAn.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchMonAn.Name = "btnSearchMonAn";
            this.btnSearchMonAn.Size = new System.Drawing.Size(96, 32);
            this.btnSearchMonAn.TabIndex = 10;
            this.btnSearchMonAn.Text = "Tìm kiếm";
            this.btnSearchMonAn.UseVisualStyleBackColor = true;
            this.btnSearchMonAn.Click += new System.EventHandler(this.btnSearchMonAn_Click);
            // 
            // txtSearchMA
            // 
            this.txtSearchMA.Location = new System.Drawing.Point(662, 7);
            this.txtSearchMA.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchMA.Name = "txtSearchMA";
            this.txtSearchMA.Size = new System.Drawing.Size(206, 26);
            this.txtSearchMA.TabIndex = 9;
            // 
            // dataMonAn
            // 
            this.dataMonAn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataMonAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMonAn.Location = new System.Drawing.Point(4, 40);
            this.dataMonAn.Margin = new System.Windows.Forms.Padding(2);
            this.dataMonAn.Name = "dataMonAn";
            this.dataMonAn.RowHeadersWidth = 51;
            this.dataMonAn.RowTemplate.Height = 24;
            this.dataMonAn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataMonAn.Size = new System.Drawing.Size(963, 452);
            this.dataMonAn.TabIndex = 0;
            // 
            // PageThongKe
            // 
            this.PageThongKe.Controls.Add(this.textBox1);
            this.PageThongKe.Controls.Add(this.label3);
            this.PageThongKe.Controls.Add(this.groupBox1);
            this.PageThongKe.Controls.Add(this.dataHoaDon);
            this.PageThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageThongKe.Location = new System.Drawing.Point(4, 31);
            this.PageThongKe.Margin = new System.Windows.Forms.Padding(2);
            this.PageThongKe.Name = "PageThongKe";
            this.PageThongKe.Padding = new System.Windows.Forms.Padding(2);
            this.PageThongKe.Size = new System.Drawing.Size(975, 532);
            this.PageThongKe.TabIndex = 0;
            this.PageThongKe.Text = "Thống kê";
            this.PageThongKe.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(784, 498);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 28);
            this.textBox1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(693, 502);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tổng tiền";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateEnd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnThK);
            this.groupBox1.Controls.Add(this.dateStart);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 3);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(673, 62);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thời gian:";
            // 
            // dateEnd
            // 
            this.dateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateEnd.Location = new System.Drawing.Point(360, 22);
            this.dateEnd.Margin = new System.Windows.Forms.Padding(2);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(154, 26);
            this.dateEnd.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Đến ngày:";
            // 
            // btnThK
            // 
            this.btnThK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThK.Location = new System.Drawing.Point(556, 23);
            this.btnThK.Margin = new System.Windows.Forms.Padding(2);
            this.btnThK.Name = "btnThK";
            this.btnThK.Size = new System.Drawing.Size(97, 29);
            this.btnThK.TabIndex = 2;
            this.btnThK.Text = "Thống kê";
            this.btnThK.UseVisualStyleBackColor = true;
            this.btnThK.Click += new System.EventHandler(this.btnThK_Click);
            // 
            // dateStart
            // 
            this.dateStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateStart.Location = new System.Drawing.Point(89, 22);
            this.dateStart.Margin = new System.Windows.Forms.Padding(2);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(154, 26);
            this.dateStart.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ ngày:";
            // 
            // dataHoaDon
            // 
            this.dataHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataHoaDon.Location = new System.Drawing.Point(4, 68);
            this.dataHoaDon.Margin = new System.Windows.Forms.Padding(2);
            this.dataHoaDon.Name = "dataHoaDon";
            this.dataHoaDon.RowHeadersWidth = 51;
            this.dataHoaDon.RowTemplate.Height = 24;
            this.dataHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataHoaDon.Size = new System.Drawing.Size(968, 427);
            this.dataHoaDon.TabIndex = 0;
            // 
            // PageNhanVien
            // 
            this.PageNhanVien.Controls.Add(this.PageThongKe);
            this.PageNhanVien.Controls.Add(this.PageMonAn);
            this.PageNhanVien.Controls.Add(this.tabPage3);
            this.PageNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageNhanVien.Location = new System.Drawing.Point(9, 10);
            this.PageNhanVien.Margin = new System.Windows.Forms.Padding(2);
            this.PageNhanVien.Name = "PageNhanVien";
            this.PageNhanVien.SelectedIndex = 0;
            this.PageNhanVien.Size = new System.Drawing.Size(983, 567);
            this.PageNhanVien.TabIndex = 0;
            // 
            // fAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 587);
            this.Controls.Add(this.PageNhanVien);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fAdmin";
            this.Text = "fAdmin";
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataNV)).EndInit();
            this.PageMonAn.ResumeLayout(false);
            this.PageMonAn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataMonAn)).EndInit();
            this.PageThongKe.ResumeLayout(false);
            this.PageThongKe.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataHoaDon)).EndInit();
            this.PageNhanVien.ResumeLayout(false);
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
        private System.Windows.Forms.ComboBox cbbSortMA;
        private System.Windows.Forms.DataGridView dataNV;
        private System.Windows.Forms.TabPage PageMonAn;
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
        private System.Windows.Forms.TabPage PageThongKe;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThK;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataHoaDon;
        private System.Windows.Forms.TabControl PageNhanVien;
    }
}
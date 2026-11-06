namespace QuanLySach.GUI
{
    partial class frmQuanLySach
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
            lblTitle = new Label();
            groupBox1 = new GroupBox();
            label1 = new Label();
            cboTheLoai = new ComboBox();
            label3 = new Label();
            txtMaSach = new TextBox();
            label5 = new Label();
            txtTenSach = new TextBox();
            label2 = new Label();
            dtpNgayNhap = new DateTimePicker();
            label4 = new Label();
            txtSoLuong = new TextBox();
            label6 = new Label();
            txtDonGia = new TextBox();
            btnMoi = new Button();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            groupBox2 = new GroupBox();
            dgvSach = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSach).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(0, 32, 160);
            lblTitle.Location = new Point(294, 15);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(552, 48);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "QUẢN LÝ SÁCH THEO THỂ LOẠI";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cboTheLoai);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtMaSach);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtTenSach);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(dtpNgayNhap);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtSoLuong);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtDonGia);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            groupBox1.Location = new Point(20, 65);
            groupBox1.Margin = new Padding(4, 4, 4, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 4, 4, 4);
            groupBox1.Size = new Size(906, 219);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sách";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.5F);
            label1.Location = new Point(25, 48);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(83, 25);
            label1.TabIndex = 0;
            label1.Text = "Thể loại:";
            // 
            // cboTheLoai
            // 
            cboTheLoai.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTheLoai.Font = new Font("Segoe UI", 9.5F);
            cboTheLoai.FormattingEnabled = true;
            cboTheLoai.Location = new Point(131, 42);
            cboTheLoai.Margin = new Padding(4, 4, 4, 4);
            cboTheLoai.Name = "cboTheLoai";
            cboTheLoai.Size = new Size(293, 33);
            cboTheLoai.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.5F);
            label3.Location = new Point(25, 102);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(86, 25);
            label3.TabIndex = 2;
            label3.Text = "Mã sách:";
            // 
            // txtMaSach
            // 
            txtMaSach.Font = new Font("Segoe UI", 9.5F);
            txtMaSach.Location = new Point(131, 98);
            txtMaSach.Margin = new Padding(4, 4, 4, 4);
            txtMaSach.Name = "txtMaSach";
            txtMaSach.Size = new Size(293, 33);
            txtMaSach.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.5F);
            label5.Location = new Point(25, 158);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(88, 25);
            label5.TabIndex = 4;
            label5.Text = "Tên sách:";
            // 
            // txtTenSach
            // 
            txtTenSach.Font = new Font("Segoe UI", 9.5F);
            txtTenSach.Location = new Point(131, 152);
            txtTenSach.Margin = new Padding(4, 4, 4, 4);
            txtTenSach.Name = "txtTenSach";
            txtTenSach.Size = new Size(293, 33);
            txtTenSach.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.5F);
            label2.Location = new Point(456, 48);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(108, 25);
            label2.TabIndex = 1;
            label2.Text = "Ngày nhập:";
            // 
            // dtpNgayNhap
            // 
            dtpNgayNhap.CustomFormat = "dd/MM/yyyy";
            dtpNgayNhap.Font = new Font("Segoe UI", 9.5F);
            dtpNgayNhap.Format = DateTimePickerFormat.Custom;
            dtpNgayNhap.Location = new Point(575, 42);
            dtpNgayNhap.Margin = new Padding(4, 4, 4, 4);
            dtpNgayNhap.Name = "dtpNgayNhap";
            dtpNgayNhap.Size = new Size(305, 33);
            dtpNgayNhap.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.5F);
            label4.Location = new Point(456, 102);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(91, 25);
            label4.TabIndex = 3;
            label4.Text = "Số lượng:";
            // 
            // txtSoLuong
            // 
            txtSoLuong.Font = new Font("Segoe UI", 9.5F);
            txtSoLuong.Location = new Point(575, 98);
            txtSoLuong.Margin = new Padding(4, 4, 4, 4);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(305, 33);
            txtSoLuong.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.5F);
            label6.Location = new Point(456, 158);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(82, 25);
            label6.TabIndex = 5;
            label6.Text = "Đơn giá:";
            // 
            // txtDonGia
            // 
            txtDonGia.Font = new Font("Segoe UI", 9.5F);
            txtDonGia.Location = new Point(575, 152);
            txtDonGia.Margin = new Padding(4, 4, 4, 4);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(305, 33);
            txtDonGia.TabIndex = 5;
            // 
            // btnMoi
            // 
            btnMoi.Font = new Font("Segoe UI", 9.75F);
            btnMoi.Location = new Point(948, 78);
            btnMoi.Margin = new Padding(4, 4, 4, 4);
            btnMoi.Name = "btnMoi";
            btnMoi.Size = new Size(175, 40);
            btnMoi.TabIndex = 6;
            btnMoi.Text = "    Mới";
            btnMoi.UseVisualStyleBackColor = true;
            btnMoi.Click += btnMoi_Click;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI", 9.75F);
            btnThem.Location = new Point(948, 122);
            btnThem.Margin = new Padding(4, 4, 4, 4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(175, 40);
            btnThem.TabIndex = 7;
            btnThem.Text = "    Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Segoe UI", 9.75F);
            btnSua.Location = new Point(948, 168);
            btnSua.Margin = new Padding(4, 4, 4, 4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(175, 40);
            btnSua.TabIndex = 8;
            btnSua.Text = "    Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 9.75F);
            btnXoa.Location = new Point(948, 212);
            btnXoa.Margin = new Padding(4, 4, 4, 4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(175, 40);
            btnXoa.TabIndex = 9;
            btnXoa.Text = "    Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 9.75F);
            btnThoat.Location = new Point(948, 258);
            btnThoat.Margin = new Padding(4, 4, 4, 4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(175, 40);
            btnThoat.TabIndex = 10;
            btnThoat.Text = "    Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvSach);
            groupBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            groupBox2.Location = new Point(20, 306);
            groupBox2.Margin = new Padding(4, 4, 4, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 4, 4, 4);
            groupBox2.Size = new Size(1102, 444);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách sách";
            // 
            // dgvSach
            // 
            dgvSach.AllowUserToAddRows = false;
            dgvSach.AllowUserToDeleteRows = false;
            dgvSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSach.BackgroundColor = SystemColors.Window;
            dgvSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSach.Font = new Font("Segoe UI", 9.25F);
            dgvSach.Location = new Point(20, 52);
            dgvSach.Margin = new Padding(4, 4, 4, 4);
            dgvSach.MultiSelect = false;
            dgvSach.Name = "dgvSach";
            dgvSach.ReadOnly = true;
            dgvSach.RowHeadersWidth = 35;
            dgvSach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSach.Size = new Size(1062, 383);
            dgvSach.TabIndex = 0;
            dgvSach.CellClick += dgvSach_CellClick;
            // 
            // frmQuanLySach
            // 
            AcceptButton = btnThem;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnThoat;
            ClientSize = new Size(1144, 769);
            Controls.Add(groupBox2);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(btnMoi);
            Controls.Add(groupBox1);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 4, 4, 4);
            Name = "frmQuanLySach";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý sách – 24110228 – Nguyễn Thái Hoàng";
            FormClosing += frmQuanLySach_FormClosing;
            Load += frmQuanLySach_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSach).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTheLoai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Button btnMoi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvSach;
    }
}

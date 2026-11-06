using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using QuanLySach.BUS;
using QuanLySach.Entities;

namespace QuanLySach.GUI
{
    public partial class frmQuanLySach : Form
    {
        private readonly TheLoaiBUS _theLoaiBUS = new TheLoaiBUS();
        private readonly SachBUS _sachBUS = new SachBUS();

        public frmQuanLySach()
        {
            InitializeComponent();
        }

        private void frmQuanLySach_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AcceptButton = btnThem;
            this.CancelButton = btnThoat;

            SetupButtonIcons();
            LoadTheLoai();
            LoadDanhSachSach();
            ResetForm();
        }

        private void SetupButtonIcons()
        {
            try
            {
                btnMoi.Image = CreateIconMoi();
                btnMoi.TextImageRelation = TextImageRelation.ImageBeforeText;
                btnMoi.ImageAlign = ContentAlignment.MiddleLeft;

                btnThem.Image = CreateIconThem();
                btnThem.TextImageRelation = TextImageRelation.ImageBeforeText;
                btnThem.ImageAlign = ContentAlignment.MiddleLeft;

                btnSua.Image = CreateIconSua();
                btnSua.TextImageRelation = TextImageRelation.ImageBeforeText;
                btnSua.ImageAlign = ContentAlignment.MiddleLeft;

                btnXoa.Image = CreateIconXoa();
                btnXoa.TextImageRelation = TextImageRelation.ImageBeforeText;
                btnXoa.ImageAlign = ContentAlignment.MiddleLeft;

                btnThoat.Image = CreateIconThoat();
                btnThoat.TextImageRelation = TextImageRelation.ImageBeforeText;
                btnThoat.ImageAlign = ContentAlignment.MiddleLeft;
            }
            catch
            {
                // Fallback nếu môi trường không hỗ trợ vẽ icon động
            }
        }

        private Image CreateIconMoi()
        {
            var bmp = new Bitmap(18, 18);
            using (var g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                using (var pen = new Pen(Color.FromArgb(0, 120, 215), 1.8f))
                {
                    g.DrawRectangle(pen, 3, 2, 11, 14);
                    g.DrawLine(pen, 5, 6, 11, 6);
                    g.DrawLine(pen, 5, 9, 11, 9);
                    g.DrawLine(pen, 5, 12, 9, 12);
                }
            }
            return bmp;
        }

        private Image CreateIconThem()
        {
            var bmp = new Bitmap(18, 18);
            using (var g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                using (var brush = new SolidBrush(Color.FromArgb(46, 139, 87)))
                {
                    g.FillRectangle(brush, 7, 3, 4, 12);
                    g.FillRectangle(brush, 3, 7, 12, 4);
                }
            }
            return bmp;
        }

        private Image CreateIconSua()
        {
            var bmp = new Bitmap(18, 18);
            using (var g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                using (var brush = new SolidBrush(Color.FromArgb(230, 140, 20)))
                {
                    PointF[] pts = {
                        new PointF(13, 2),
                        new PointF(16, 5),
                        new PointF(6, 15),
                        new PointF(2, 16),
                        new PointF(3, 12)
                    };
                    g.FillPolygon(brush, pts);
                }
            }
            return bmp;
        }

        private Image CreateIconXoa()
        {
            var bmp = new Bitmap(18, 18);
            using (var g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                using (var pen = new Pen(Color.FromArgb(220, 20, 20), 2.5f))
                {
                    g.DrawLine(pen, 3, 3, 15, 15);
                    g.DrawLine(pen, 15, 3, 3, 15);
                }
            }
            return bmp;
        }

        private Image CreateIconThoat()
        {
            var bmp = new Bitmap(18, 18);
            using (var g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                using (var pen = new Pen(Color.FromArgb(220, 20, 20), 2.2f))
                {
                    g.DrawArc(pen, 3, 3, 12, 12, -60, 300);
                    g.DrawLine(pen, 9, 2, 9, 8);
                }
            }
            return bmp;
        }

        private void LoadTheLoai()
        {
            try
            {
                var listTheLoai = _theLoaiBUS.GetAll();
                cboTheLoai.DataSource = listTheLoai;
                cboTheLoai.DisplayMember = "TenLoai";
                cboTheLoai.ValueMember = "MaLoai";
                cboTheLoai.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi nạp thể loại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDanhSachSach()
        {
            try
            {
                var list = _sachBUS.GetAll();
                var viCulture = new CultureInfo("vi-VN");
                var displayList = list.Select(s => new
                {
                    MaSach = s.MaSach,
                    TenSach = s.TenSach,
                    NgayNhap = s.NgayNhap.ToString("dd/MM/yyyy"),
                    SoLuong = s.SoLuong,
                    DonGia = s.DonGia.ToString("#,##0", viCulture),
                    TenLoai = s.TheLoai != null ? s.TheLoai.TenLoai : "",
                    MaLoai = s.MaLoai
                }).ToList();

                dgvSach.DataSource = displayList;

                if (dgvSach.Columns["MaSach"] != null)
                {
                    dgvSach.Columns["MaSach"].HeaderText = "Mã sách";
                    dgvSach.Columns["MaSach"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dgvSach.Columns["MaSach"].FillWeight = 80;
                }
                if (dgvSach.Columns["TenSach"] != null)
                {
                    dgvSach.Columns["TenSach"].HeaderText = "Tên sách";
                    dgvSach.Columns["TenSach"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dgvSach.Columns["TenSach"].FillWeight = 160;
                }
                if (dgvSach.Columns["NgayNhap"] != null)
                {
                    dgvSach.Columns["NgayNhap"].HeaderText = "Ngày nhập";
                    dgvSach.Columns["NgayNhap"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgvSach.Columns["NgayNhap"].FillWeight = 100;
                }
                if (dgvSach.Columns["SoLuong"] != null)
                {
                    dgvSach.Columns["SoLuong"].HeaderText = "Số lượng";
                    dgvSach.Columns["SoLuong"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgvSach.Columns["SoLuong"].FillWeight = 80;
                }
                if (dgvSach.Columns["DonGia"] != null)
                {
                    dgvSach.Columns["DonGia"].HeaderText = "Đơn giá";
                    dgvSach.Columns["DonGia"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgvSach.Columns["DonGia"].FillWeight = 100;
                }
                if (dgvSach.Columns["TenLoai"] != null)
                {
                    dgvSach.Columns["TenLoai"].HeaderText = "Thể loại";
                    dgvSach.Columns["TenLoai"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dgvSach.Columns["TenLoai"].FillWeight = 100;
                }
                if (dgvSach.Columns["MaLoai"] != null)
                {
                    dgvSach.Columns["MaLoai"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi nạp danh sách sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetForm()
        {
            txtMaSach.Clear();
            txtTenSach.Clear();
            txtSoLuong.Clear();
            txtDonGia.Clear();
            dtpNgayNhap.Value = DateTime.Now;
            cboTheLoai.SelectedIndex = -1;

            txtMaSach.ReadOnly = false;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            dgvSach.ClearSelection();
            txtMaSach.Focus();
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void dgvSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvSach.Rows.Count)
            {
                var row = dgvSach.Rows[e.RowIndex];
                if (row.Cells["MaSach"].Value != null)
                {
                    txtMaSach.Text = row.Cells["MaSach"].Value.ToString();
                    txtTenSach.Text = row.Cells["TenSach"].Value?.ToString();

                    if (DateTime.TryParseExact(row.Cells["NgayNhap"].Value?.ToString(), "dd/MM/yyyy", null, DateTimeStyles.None, out DateTime ngay))
                        dtpNgayNhap.Value = ngay;

                    txtSoLuong.Text = row.Cells["SoLuong"].Value?.ToString();

                    string rawDonGia = "";
                    if (row.Cells["DonGia"].Value != null)
                    {
                        rawDonGia = row.Cells["DonGia"].Value.ToString().Replace(".", "").Replace(",", "");
                    }
                    txtDonGia.Text = rawDonGia;

                    if (row.Cells["MaLoai"].Value != null)
                    {
                        cboTheLoai.SelectedValue = row.Cells["MaLoai"].Value.ToString();
                    }

                    txtMaSach.ReadOnly = true;
                    btnThem.Enabled = false;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtSoLuong.Text.Trim(), out int soLuong))
                    throw new ArgumentException("Số lượng phải là số nguyên hợp lệ!");

                if (!decimal.TryParse(txtDonGia.Text.Trim(), out decimal donGia))
                    throw new ArgumentException("Đơn giá phải là số hợp lệ!");

                var sach = new Sach
                {
                    MaSach = txtMaSach.Text.Trim(),
                    TenSach = txtTenSach.Text.Trim(),
                    NgayNhap = dtpNgayNhap.Value,
                    SoLuong = soLuong,
                    DonGia = donGia,
                    MaLoai = cboTheLoai.SelectedValue?.ToString() ?? string.Empty
                };

                _sachBUS.AddSach(sach);
                MessageBox.Show("Thêm sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSachSach();
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtSoLuong.Text.Trim(), out int soLuong))
                    throw new ArgumentException("Số lượng phải là số nguyên hợp lệ!");

                if (!decimal.TryParse(txtDonGia.Text.Trim(), out decimal donGia))
                    throw new ArgumentException("Đơn giá phải là số hợp lệ!");

                var sach = new Sach
                {
                    MaSach = txtMaSach.Text.Trim(),
                    TenSach = txtTenSach.Text.Trim(),
                    NgayNhap = dtpNgayNhap.Value,
                    SoLuong = soLuong,
                    DonGia = donGia,
                    MaLoai = cboTheLoai.SelectedValue?.ToString() ?? string.Empty
                };

                _sachBUS.UpdateSach(sach);
                MessageBox.Show("Cập nhật thông tin sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSachSach();
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string maSach = txtMaSach.Text.Trim();
                if (string.IsNullOrEmpty(maSach))
                {
                    MessageBox.Show("Vui lòng chọn sách cần xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa sách có mã '{maSach}' không?",
                    "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    _sachBUS.DeleteSach(maSach);
                    MessageBox.Show("Xóa sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachSach();
                    ResetForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmQuanLySach_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát khỏi chương trình?", "Xác nhận thoát",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}

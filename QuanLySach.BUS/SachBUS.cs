using System;
using System.Collections.Generic;
using QuanLySach.DAL;
using QuanLySach.Entities;

namespace QuanLySach.BUS
{
    public class SachBUS
    {
        private readonly SachDAL _sachDAL = new SachDAL();

        public List<Sach> GetAll()
        {
            return _sachDAL.GetAll();
        }

        public Sach? GetById(string maSach)
        {
            return _sachDAL.GetById(maSach);
        }

        public void AddSach(Sach s)
        {
            ValidateSach(s, isUpdate: false);
            _sachDAL.Add(s);
        }

        public void UpdateSach(Sach s)
        {
            ValidateSach(s, isUpdate: true);
            _sachDAL.Update(s);
        }

        public void DeleteSach(string maSach)
        {
            if (string.IsNullOrWhiteSpace(maSach))
                throw new ArgumentException("Mã sách không hợp lệ để xóa!");

            var exist = _sachDAL.GetById(maSach);
            if (exist == null)
                throw new InvalidOperationException("Không tìm thấy sách cần xóa!");

            _sachDAL.Delete(maSach);
        }

        private void ValidateSach(Sach s, bool isUpdate)
        {
            s.MaSach = s.MaSach?.Trim() ?? string.Empty;
            s.TenSach = s.TenSach?.Trim() ?? string.Empty;

            if (string.IsNullOrEmpty(s.MaSach))
                throw new ArgumentException("Mã sách không được để trống!");

            if (s.MaSach.Length > 20)
                throw new ArgumentException("Mã sách tối đa 20 ký tự!");

            if (string.IsNullOrEmpty(s.TenSach))
                throw new ArgumentException("Tên sách không được để trống!");

            if (s.TenSach.Length > 150)
                throw new ArgumentException("Tên sách tối đa 150 ký tự!");

            if (string.IsNullOrEmpty(s.MaLoai))
                throw new ArgumentException("Vui lòng chọn thể loại sách!");

            if (s.NgayNhap.Date > DateTime.Now.Date)
                throw new ArgumentException("Ngày nhập không được lớn hơn ngày hiện tại!");

            if (s.SoLuong <= 0)
                throw new ArgumentException("Số lượng phải là số nguyên lớn hơn 0!");

            if (s.DonGia <= 0)
                throw new ArgumentException("Đơn giá phải là số lớn hơn 0!");

            if (!isUpdate)
            {
                var exist = _sachDAL.GetById(s.MaSach);
                if (exist != null)
                    throw new InvalidOperationException($"Mã sách '{s.MaSach}' đã tồn tại trong hệ thống!");
            }
        }
    }
}
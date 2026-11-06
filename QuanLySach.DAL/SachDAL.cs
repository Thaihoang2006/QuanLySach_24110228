using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using QuanLySach.Entities;

namespace QuanLySach.DAL
{
    public class SachDAL
    {
        public List<Sach> GetAll()
        {
            using (var context = new BookContext())
            {
                // Include TheLoai để lấy tên thể loại hiển thị lên DataGridView
                return context.Sachs.Include(s => s.TheLoai).ToList();
            }
        }

        public Sach? GetById(string maSach)
        {
            using (var context = new BookContext())
            {
                return context.Sachs.FirstOrDefault(s => s.MaSach == maSach);
            }
        }

        public void Add(Sach s)
        {
            using (var context = new BookContext())
            {
                context.Sachs.Add(s);
                context.SaveChanges();
            }
        }

        public void Update(Sach s)
        {
            using (var context = new BookContext())
            {
                var exist = context.Sachs.Find(s.MaSach);
                if (exist != null)
                {
                    exist.TenSach = s.TenSach;
                    exist.NgayNhap = s.NgayNhap;
                    exist.SoLuong = s.SoLuong;
                    exist.DonGia = s.DonGia;
                    exist.MaLoai = s.MaLoai;
                    context.SaveChanges();
                }
            }
        }

        public void Delete(string maSach)
        {
            using (var context = new BookContext())
            {
                var exist = context.Sachs.Find(maSach);
                if (exist != null)
                {
                    context.Sachs.Remove(exist);
                    context.SaveChanges();
                }
            }
        }
    }
}
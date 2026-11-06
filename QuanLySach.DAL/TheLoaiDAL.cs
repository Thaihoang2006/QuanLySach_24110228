using System.Collections.Generic;
using System.Linq;
using QuanLySach.Entities;

namespace QuanLySach.DAL
{
    public class TheLoaiDAL
    {
        public List<TheLoai> GetAll()
        {
            using (var context = new BookContext())
            {
                return context.TheLoais.OrderBy(t => t.TenLoai).ToList();
            }
        }
    }
}
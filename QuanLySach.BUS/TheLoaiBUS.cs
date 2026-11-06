using System.Collections.Generic;
using QuanLySach.DAL;
using QuanLySach.Entities;

namespace QuanLySach.BUS
{
    public class TheLoaiBUS
    {
        private readonly TheLoaiDAL _theLoaiDAL = new TheLoaiDAL();

        public List<TheLoai> GetAll()
        {
            return _theLoaiDAL.GetAll();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;
using DAO;
//using DTO;
using System.Data;

namespace BUS
{
    public class DeadlineBUS
    {
        public DataTable LayDanhSach()
        {
            DeadlineDAO ddao = new DeadlineDAO();
            return ddao.LayDanhSach();
        }
    }
}

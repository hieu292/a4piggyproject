using System;
using System.Collections.Generic;
using System.Text;
using DAO;
//using DTO;
using System.Collections;
using System.Data;

namespace BUS
{
    public class SubjectBUS
    {
        public DataTable LayDanhSach()
        {
            SubjectDAO sdao = new SubjectDAO();
            return sdao.LayDanhSach();
        }
    }
}

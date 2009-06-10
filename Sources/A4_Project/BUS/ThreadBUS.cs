using System;
using System.Collections.Generic;
using System.Text;
//using DTO;
using DAO;
using System.Data;

namespace BUS
{
    public class ThreadBUS
    {
        public DataTable LayDanhSach(int sID)
        {
            ThreadDAO tdao = new ThreadDAO();
            return tdao.LayDanhSach(sID);
        }

        public DataTable LayDanhSach(string strmon)
        {
            ThreadDAO tdao = new ThreadDAO();
            return tdao.LayDanhSach(strmon);
        }

        public DataTable LayBang()
        {
            ThreadDAO tdao = new ThreadDAO();
            return tdao.LayBang();
        }

        public DataTable ThongTinThread(int iThread)
        {
            ThreadDAO tdao = new ThreadDAO();
            return tdao.ThongTinThread(iThread);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DAO;
using DTO;

namespace BUS
{
    public class ReplyThreadBUS
    {
        public DataTable LayDanhSach(int iThread)
        {
            ReplyThreadDAO rtbus = new ReplyThreadDAO();
            return rtbus.LayDanhSach(iThread);
        }

        public void ThemReply(ReplyThreadDTO rtdto)
        {
            ReplyThreadDAO rtbus = new ReplyThreadDAO();
            rtbus.ThemReply(rtdto);
        }
    }
}

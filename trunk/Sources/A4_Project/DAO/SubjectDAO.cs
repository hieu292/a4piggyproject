using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using System.Data;

namespace DAO
{
    public class SubjectDAO
    {
        public DataTable LayDanhSach()
        {
            return DataProvider.LayBang("Subject");
        }
    }
}

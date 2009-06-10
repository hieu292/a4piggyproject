using System;
using System.Collections.Generic;
using System.Text;
using DTO;

namespace DAO
{
    class StudentDAO
    {
        public bool isExist(StudentDTO sd)
        {
            AccessDatabase adb = new AccessDatabase();
            DataTable dt;
            dt = new DataTable();
            OleDbConnection cn;
            cn = adb.ConnectionData();
            string strSQL;
            strSQL = "Select gv.MaGiaoVien, gv.TenGiaoVien, mh.TenMonHoc From MonHoc mh, GiaoVien gv ,PhanCong pc   Where pc.maLop ='" + maLop + "' and mh.MaMonHoc=pc.MaMonHoc  and gv.MaGiaoVien=pc.MaGiaoVien";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            cmd.Parameters.Add("@MaLop", OleDbType.Integer);
            cmd.Parameters["@MaLop"].Value = maLop;
            OleDbDataAdapter da;
            da = new OleDbDataAdapter(cmd);
            // da.FillSchema(dt, SchemaType.Source);
            da.Fill(dt);
            cn.Close();
        }
    }
}

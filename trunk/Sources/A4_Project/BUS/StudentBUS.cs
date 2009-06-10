using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAO;

namespace BUS
{
    public class StudentBUS
    {
        StudentDTO sdDTO;
        public StudentBUS(StudentDTO s)
        {
            sdDTO = s;
        }
        public int isAtuthencation()
        {
            StudentDAO s = new StudentDAO();
            if (s.isExist(sdDTO) > 0)
                return s.isExist(sdDTO);
            else
                return -1;
        }
        public bool ChangePass()
        {
            StudentDAO s = new StudentDAO();
            if (s.isExist(sdDTO) >0)
                return true;
            else
                return false;
        }
    }
}

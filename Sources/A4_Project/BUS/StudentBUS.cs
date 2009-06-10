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
        public bool isAtuthencation()
        {
            StudentDAO s = new StudentDAO();
            if (s.isExist(sdDTO) == true)
                return true;
            else
                return false;
        }
    }
}

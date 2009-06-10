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
            StudentDAO s = new StudentDAO(sdDTO);
            if (s.isExist() > 0)
                return s.isExist();
            else
                return -1;
        }
        public bool ChangePass(string newpass)
        {
           
            if (this.sdDTO.StudentID > 0)
            {
                StudentDAO s = new StudentDAO(sdDTO);
                if (s.ChangePassword(newpass) == true)
                    return true;
                return false;
            }
            else
                return false;
        }
    }
}

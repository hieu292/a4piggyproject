using System;
using System.Collections.Generic;
using System.Text;

namespace BUS
{
    class StudentBO
    {
        public bool isAuthencation(StudentDTO user)
        {
            StudentDAO ud = new StudentDAO();
            if (ud.CheckPassword(user) == true)
                return true;
            else
                return false;
        }
    }
}

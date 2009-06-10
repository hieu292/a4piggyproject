using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class StudentDTO
    {
        protected int _StudentID;
        protected string _Name;
        protected string _Email;
        protected string _Password;
        public StudentDTO()
        {
        }
        public StudentDTO(int _StudentID, string _Name, string _Email, string _Password)
        {
            this.StudentID = _StudentID;
            this.Name = _Name;
            this.Email = _Email;
            this.Password = _Password;
        }
        public int StudentID
        {
            get { return _StudentID; }
            set { _StudentID = value; }
        }
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }
        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }
    }
}

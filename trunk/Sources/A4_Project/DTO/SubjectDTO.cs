using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class SubjectDTO
    {
        protected  string _Name ;
        protected int _SubjectID;
        public  SubjectDTO()
        {
        }
        public  SubjectDTO( int _SubjectID ,string _Name  )
        {
           this.SubjectID = _SubjectID ;
           this.Name = _Name ;
        }
        public int SubjectID
        {
            get { return _SubjectID ; }
            set { _SubjectID = value ; }
        }
        public string Name
        {
            get { return _Name ; }
            set { _Name = value ; }
        }
    }
}

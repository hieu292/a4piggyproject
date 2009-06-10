using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
   public class StudyDTO
    {
        protected  int _StudentID ;
        protected  int _OpenSubjectID ;
        public  StudyDTO()
        {
        }
        public  StudyDTO( int _StudentID ,int _OpenSubjectID  )
        {
           this.StudentID = _StudentID ;
           this.OpenSubjectID = _OpenSubjectID ;
        }
        public int StudentID
        {
            get { return _StudentID ; }
            set { _StudentID = value ; }
        }
        public int OpenSubjectID
        {
            get { return _OpenSubjectID ; }
            set { _OpenSubjectID = value ; }
        }
    }
}

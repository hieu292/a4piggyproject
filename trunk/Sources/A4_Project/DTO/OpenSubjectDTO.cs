using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;

namespace DTO
{
    public class OpenSubjectDTO
    {
        protected  int _OpenSubjectID ;
        protected  int _TermID ;
        protected  int _SubjectID ;
        public  OpenSubjectDTO()
        {
        }
        public  OpenSubjectDTO( int _OpenSubjectID ,int _TermID ,int _SubjectID  )
        {
           this.OpenSubjectID = _OpenSubjectID ;
           this.TermID = _TermID ;
           this.SubjectID = _SubjectID ;
        }
        public int OpenSubjectID
        {
            get { return _OpenSubjectID ; }
            set { _OpenSubjectID = value ; }
        }
        public int TermID
        {
            get { return _TermID ; }
            set { _TermID = value ; }
        }
        public int SubjectID
        {
            get { return _SubjectID ; }
            set { _SubjectID = value ; }
        }
    }
}

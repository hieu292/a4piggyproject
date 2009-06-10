using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    class DeadlineDTO
    {
        protected  string _Title ;
        protected  DateTime _Time ;
        protected  int _OpenSubjectID ;
        public  DeadlineDTO()
        {
        }
        public  DeadlineDTO( string _Title ,DateTime _Time ,int _OpenSubjectID  )
        {
           this.Title = _Title ;
           this.Time = _Time ;
           this.OpenSubjectID = _OpenSubjectID ;
        }
        public string Title
        {
            get { return _Title ; }
            set { _Title = value ; }
        }
        public DateTime Time
        {
            get { return _Time ; }
            set { _Time = value ; }
        }
        public int OpenSubjectID
        {
            get { return _OpenSubjectID ; }
            set { _OpenSubjectID = value ; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
   public class ThreadDTO
    {
        protected  int _ThreadID ;
        protected  string _Title ;
        protected  string _Content ;
        protected  DateTime _Time ;
        protected  int _OpenSubjectID ;
        protected  int _StudentID ;
        public  ThreadDTO()
        {
        }
        public  ThreadDTO( int _ThreadID ,string _Title ,string _Content ,DateTime _Time ,int _OpenSubjectID ,int _StudentID  )
        {
           this.ThreadID = _ThreadID ;
           this.Title = _Title ;
           this.Content = _Content ;
           this.Time = _Time ;
           this.OpenSubjectID = _OpenSubjectID ;
           this.StudentID = _StudentID ;
        }
        public int ThreadID
        {
            get { return _ThreadID ; }
            set { _ThreadID = value ; }
        }
        public string Title
        {
            get { return _Title ; }
            set { _Title = value ; }
        }
        public string Content
        {
            get { return _Content ; }
            set { _Content = value ; }
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
        public int StudentID
        {
            get { return _StudentID ; }
            set { _StudentID = value ; }
        }
    }
}
